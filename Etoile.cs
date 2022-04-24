// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Etoile
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  public class Etoile : Corps
  {
    private const int TABMAX = 9110;
    private double _magnitude;
    private string _nom;
    private static bool _initStar;

    /// <summary>Constructeur par defaut</summary>
    /// <param name="nom">Nom de l'etoile</param>
    /// <param name="ascensionDroite">Ascension droite (en heures)</param>
    /// <param name="declinaison">Declinaison (en degres)</param>
    /// <param name="magnitude">Magnitude visuelle</param>
    /// <remarks></remarks>
    public Etoile(string nom, double ascensionDroite, double declinaison, double magnitude)
    {
      this._nom = nom;
      this._ascensionDroite = ascensionDroite * (Math.PI / 12.0);
      this._declinaison = declinaison * (Math.PI / 180.0);
      this._magnitude = magnitude;
    }

    /// <summary>Calcul de la position du catalogue d'etoiles</summary>
    /// <param name="observateur">Observateur</param>
    /// <param name="etoiles">Catalogue d'etoiles</param>
    /// <remarks></remarks>
    public static void CalculPositionEtoiles(Observateur observateur, ref Etoile[] etoiles)
    {
      if (!Etoile._initStar)
      {
        Etoile.InitTabEtoiles(ref etoiles);
        Etoile._initStar = true;
      }
      int index = 0;
      do
      {
        etoiles[index].CalculCoordHoriz(observateur);
        checked { ++index; }
      }
      while (index <= 9109);
    }

    /// <summary>
    /// Calcul des coordonnees horizontales du corps
    /// Le calcul de la refraction est issu de l'Astronomical Algorithms 2nd edition de Jean Meeus, p106.
    /// </summary>
    /// <param name="observateur">Observateur</param>
    /// <remarks></remarks>
    public new void CalculCoordHoriz(Observateur observateur)
    {
      this._visible = false;
      this._hauteur = -1.0 * Math.PI;
      double num1 = Math.Cos(this._declinaison);
      Vecteur vec = new Vecteur(Math.Cos(this._ascensionDroite) * num1, Math.Sin(this._ascensionDroite) * num1, Math.Sin(this._declinaison));
      Vecteur vecteur = new Vecteur(observateur.RotHz.MultVec(vec));
      double num2 = Math.Asin(vecteur.Z);
      if (num2 <= -1.0 * Math.PI / 180.0)
        return;
      double num3 = 180.0 / Math.PI * num2;
      double num4 = 0.0178023583703422 / (60.0 * Math.Tan(Math.PI / 180.0 * (num3 + 10.3 / (num3 + 5.11))));
      this._hauteur = num2 + num4;
      if (this._hauteur >= 0.0)
      {
        this._azimut = Math.Atan2(vecteur.Y, -vecteur.X);
        if (this._azimut < 0.0)
          this._azimut += 2.0 * Math.PI;
        this._visible = true;
      }
      else
      {
        this._visible = false;
        this._hauteur = num2;
      }
    }

    /// <summary>Lecture du catalogue d'etoiles</summary>
    /// <param name="etoiles">Catalogue d'etoiles</param>
    /// <remarks></remarks>
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private static void InitTabEtoiles(ref Etoile[] etoiles)
    {
      NumberFormatInfo numberFormat = new CultureInfo("en-US", false).NumberFormat;
      int index = 0;
      etoiles = new Etoile[9110];
      StreamReader streamReader = new StreamReader(MyProject.Application.Info.DirectoryPath + "\\data\\etoiles.str");
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        string nom = "";
        double ascensionDroite = 0.0;
        double declinaison = 0.0;
        double magnitude = 99.0;
        if (str.Length > 34)
        {
          ascensionDroite = (double) int.Parse(str.Substring(0, 2), (IFormatProvider) numberFormat) + (double) int.Parse(str.Substring(2, 2), (IFormatProvider) numberFormat) * (1.0 / 60.0) + double.Parse(str.Substring(4, 4), (IFormatProvider) numberFormat) * 0.000277777777777778;
          declinaison = (double) Conversions.ToInteger(Interaction.IIf(Operators.CompareString(str.Substring(9, 1), "-", false) == 0, (object) -1, (object) 1)) * ((double) int.Parse(str.Substring(10, 2), (IFormatProvider) numberFormat) + (double) int.Parse(str.Substring(12, 2), (IFormatProvider) numberFormat) * (1.0 / 60.0) + double.Parse(str.Substring(14, 2), (IFormatProvider) numberFormat) * 0.000277777777777778);
          magnitude = double.Parse(str.Substring(31, 5), (IFormatProvider) numberFormat);
          if (str.Length > 37)
            nom = str.Substring(37);
        }
        etoiles[index] = new Etoile(nom, ascensionDroite, declinaison, magnitude);
        checked { ++index; }
      }
      streamReader.Close();
      if (index == 0)
        throw new PreviSatException();
    }

    public double Magnitude => this._magnitude;

    public string Nom => this._nom;
  }
}
