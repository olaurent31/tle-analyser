// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.TLE
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  public class TLE
  {
    private int _nb0;
    private double _argpo;
    private double _bstar;
    private double _ecco;
    private double _inclo;
    private double _mo;
    private double _no;
    private double _omegao;
    private Dates _epoque;
    private string _nom;
    private string _ligne1;
    private string _ligne2;
    private string _norad;

    /// <summary>Constructeur a partir des 2 lignes du TLE</summary>
    /// <param name="li1">Ligne 1 du TLE</param>
    /// <param name="li2">Ligne 2 du TLE</param>
    /// <remarks></remarks>
    public TLE(string li1, string li2)
    {
      NumberFormatInfo numberFormat = new CultureInfo("en-US", false).NumberFormat;
      this._ligne1 = li1;
      this._ligne2 = li2;
      this._norad = this._ligne1.Substring(2, 5);
      int num1 = int.Parse(this._ligne1.Substring(18, 2), (IFormatProvider) numberFormat);
      double num2 = double.Parse(this._ligne1.Substring(20, 12), (IFormatProvider) numberFormat);
      this._epoque = new Dates(new Dates(Conversions.ToInteger(Interaction.IIf(num1 < 57, (object) checked (num1 + 2000), (object) checked (num1 + 1900))), 1, 1.0, 0.0).JourJulien + num2 - 1.0, 0.0);
      int y = int.Parse(this._ligne1.Substring(59, 2), (IFormatProvider) numberFormat);
      this._bstar = 1E-05 * double.Parse(this._ligne1.Substring(53, 6), (IFormatProvider) numberFormat) * Math.Pow(10.0, (double) y);
      MyProject.Forms.Home.BSTAR = this._bstar;
      this._inclo = double.Parse(this._ligne2.Substring(8, 8), (IFormatProvider) numberFormat);
      this._omegao = double.Parse(this._ligne2.Substring(17, 8), (IFormatProvider) numberFormat);
      this._ecco = 1E-07 * double.Parse(this._ligne2.Substring(26, 7), (IFormatProvider) numberFormat);
      this._argpo = double.Parse(this._ligne2.Substring(34, 8), (IFormatProvider) numberFormat);
      this._mo = double.Parse(this._ligne2.Substring(43, 8), (IFormatProvider) numberFormat);
      this._no = double.Parse(this._ligne2.Substring(52, 11), (IFormatProvider) numberFormat);
      MyProject.Forms.Home.N0 = this._no;
      this._nb0 = int.Parse(this._ligne2.Substring(63, 5), (IFormatProvider) numberFormat);
    }

    /// <summary>Verification d'un fichier TLE</summary>
    /// <param name="nomFichier">Nom du fichier TLE</param>
    /// <param name="alarm">Affichage du message d'erreur</param>
    /// <returns>Nombre de satellites contenus dans le fichier</returns>
    /// <remarks></remarks>
    public static int VerifieFichier(string nomFichier, bool alarm)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      string str1 = "---";
      string str2 = "";
      string li2 = "";
      StreamReader streamReader = new StreamReader(nomFichier);
      try
      {
        while (streamReader.Peek() != -1)
        {
          string str3 = streamReader.ReadLine();
          if (Operators.CompareString(str1, "---", false) == 0 || Operators.CompareString(str1.Trim(), "", false) == 0)
            str1 = str3.Trim();
          if (str3.Length > 0 && str3[0] == '1')
          {
            str2 = str3;
            do
            {
              li2 = streamReader.ReadLine();
            }
            while (li2.Trim().Length == 0);
            TLE.VerifieLignes(str2, li2);
            if (Operators.CompareString(str2, str1, false) == 0 && num2 == 3 || Operators.CompareString(str2, str1, false) != 0 && num2 == 2)
            {
              int ierr = 8;
              throw new PreviSatException(ref ierr);
            }
            num2 = Operators.CompareString(str2, str1, false) != 0 ? 3 : 2;
            checked { ++num3; }
            str1 = "---";
          }
        }
        streamReader.Close();
        if (num3 == 0 || Operators.CompareString(str1, "---", false) != 0)
        {
          int ierr = 8;
          throw new PreviSatException(ref ierr);
        }
      }
      catch (PreviSatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        PreviSatException previSatException = ex;
        string str4 = "";
        num3 = 0;
        int num4 = int.Parse(previSatException.Source);
        int num5 = num4;
        if (num5 <= 4)
          str4 = str1 + "#" + li2.Substring(1, 6).Trim();
        else if (num5 == 5)
          str4 = str1 + "#" + str2.Substring(2, 5) + "#" + li2.Substring(2, 5);
        else if (num5 == 6 || num5 == 7)
        {
          str4 = checked (num4 - 5).ToString((IFormatProvider) CultureInfo.CurrentCulture) + "#" + str1 + "#" + str2.Substring(2, 5);
          num1 = 6;
        }
        else
        {
          num1 = 0;
          str4 = nomFichier;
        }
        ProjectData.ClearProjectError();
      }
      return num3;
    }

    /// <summary>Lecture d'un fichier TLE</summary>
    /// <param name="nomFichier">Fichier TLE</param>
    /// <param name="listeSatellites">Liste de satellites (numeros NORAD)</param>
    /// <param name="tle">Ensemble des TLEs a initialiser</param>
    /// <remarks></remarks>
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void LectureFichier(string nomFichier, string[] listeSatellites, ref TLE[] tle)
    {
      int num1 = listeSatellites != null ? listeSatellites.Length : tle.Length;
      StreamReader streamReader1 = new StreamReader(MyProject.Application.Info.DirectoryPath + "\\data\\magnitude");
      string end = streamReader1.ReadToEnd();
      streamReader1.Close();
      try
      {
        StreamReader streamReader2 = new StreamReader(nomFichier);
        int num2 = 0;
        int index1 = 0;
        string Left = "---";
        while (streamReader2.Peek() != -1 && num2 <= num1)
        {
          string str = streamReader2.ReadLine();
          if (str[0] == '1')
          {
            string li1 = str;
            string li2;
            do
            {
              li2 = streamReader2.ReadLine();
            }
            while (li2.Trim().Length == 0);
            if (Left[0] == '1' || Operators.CompareString(Left, "---", false) == 0)
            {
              int startIndex = end.IndexOf(li1.Substring(2, 5));
              if (startIndex >= 0)
              {
                int num3 = checked (end.IndexOf(Environment.NewLine, startIndex) - startIndex);
                Left = end.Substring(checked (startIndex + 36), checked (num3 - 36)).Trim();
              }
              else
                Left = li1.Substring(2, 5);
            }
            if (Left.Length > 25 && Left.Substring(25).Contains("."))
              Left = Left.Substring(0, 15).Trim();
            if (Operators.CompareString(Left.ToLower(CultureInfo.CurrentCulture), "iss (zarya)", false) == 0)
              Left = "ISS";
            if (Left.ToLower(CultureInfo.CurrentCulture).Contains("iridium") && Left.Contains("["))
              Left = Left.Substring(0, Left.IndexOf("[", StringComparison.CurrentCulture)).Trim();
            if (listeSatellites == null)
            {
              tle[index1] = new TLE(li1, li2);
              tle[index1]._nom = Left.Trim();
              checked { ++index1; }
            }
            else
            {
              int num4 = checked (listeSatellites.Length - 1);
              int index2 = 0;
              while (index2 <= num4)
              {
                if (Operators.CompareString(listeSatellites[index2], str.Substring(2, 5), false) == 0)
                {
                  tle[index2] = new TLE(li1, li2);
                  tle[index2]._nom = Left.Trim();
                  checked { ++num2; }
                  break;
                }
                checked { ++index2; }
              }
            }
          }
          Left = str.Trim();
        }
        streamReader2.Close();
      }
      catch (FileNotFoundException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }

    /// <summary>Mise a jour d'un fichier TLE</summary>
    /// <param name="fic_old">Nom du fichier a mettre a jour</param>
    /// <param name="fic_new">Nom du fichier a lire</param>
    /// <param name="compteRendu">Compte-rendu de la mise a jour</param>
    /// <remarks></remarks>
    public static void MiseAJourFichier(string fic_old, string fic_new, ref ArrayList compteRendu)
    {
      int num1 = TLE.VerifieFichier(fic_old, false);
      TLE[] tle1 = num1 != 0 ? new TLE[checked (num1 - 1 + 1)] : throw new PreviSatException(fic_old, TLE_Analyser.My.Resources.Resources.mess14, 1);
      TLE.LectureFichier(fic_old, (string[]) null, ref tle1);
      int num2 = TLE.VerifieFichier(fic_new, false);
      TLE[] tle2 = num2 != 0 ? new TLE[checked (num2 - 1 + 1)] : throw new PreviSatException(fic_new, TLE_Analyser.My.Resources.Resources.mess14, 1);
      TLE.LectureFichier(fic_new, (string[]) null, ref tle2);
      if (num2 < num1)
        Messages.Afficher(fic_new + "#" + fic_old, TLE_Analyser.My.Resources.Resources.mess15, 0);
      int index1 = 0;
      int num3 = 0;
      int num4 = checked (num1 - 1);
      int index2 = 0;
      while (index2 <= num4)
      {
        string norad1 = tle1[index2]._norad;
        string norad2;
        for (norad2 = tle2[index1]._norad; string.Compare(norad2, norad1, StringComparison.CurrentCulture) < 0 && index1 < checked (num2 - 1); norad2 = tle2[index1]._norad)
          checked { ++index1; }
        if (norad1.Equals(norad2))
        {
          if (tle1[index2]._epoque.JourJulien < tle2[index1]._epoque.JourJulien)
          {
            string str = Interaction.IIf(tle2[index1]._nom.Equals(norad2), (object) tle1[index2]._nom, (object) tle2[index1]._nom).ToString();
            tle1[index2] = tle2[index1];
            tle1[index2]._nom = str.Trim();
            checked { ++num3; }
          }
          else
            compteRendu.Add((object) (tle1[index2]._nom + Strings.Space(checked (70 - tle1[index2]._nom.Length)) + tle1[index2]._norad));
        }
        else
          compteRendu.Add((object) (tle1[index2]._nom + Strings.Space(checked (70 - tle1[index2]._nom.Length)) + tle1[index2]._norad));
        checked { ++index2; }
      }
      compteRendu.Add((object) num3.ToString((IFormatProvider) CultureInfo.CurrentCulture));
      compteRendu.Add((object) num1.ToString((IFormatProvider) CultureInfo.CurrentCulture));
      if (num3 <= 0)
        return;
      try
      {
        StreamWriter streamWriter = new StreamWriter(fic_old);
        int num5 = checked (num1 - 1);
        int index3 = 0;
        while (index3 <= num5)
        {
          streamWriter.WriteLine(tle1[index3]._nom);
          streamWriter.WriteLine(tle1[index3]._ligne1);
          streamWriter.WriteLine(tle1[index3]._ligne2);
          checked { ++index3; }
        }
        streamWriter.Close();
      }
      catch (UnauthorizedAccessException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        throw new PreviSatException(TLE_Analyser.My.Resources.Resources.update01 + "#" + fic_old, TLE_Analyser.My.Resources.Resources.mess21, 1);
      }
    }

    /// <summary>Verification du checksum d'une ligne</summary>
    /// <param name="ligne">Ligne du TLE dont il faut verifier le checksum</param>
    /// <returns>Resultat de la verification</returns>
    /// <remarks></remarks>
    private static bool CheckSum(string ligne)
    {
      int num = 0;
      int index = 0;
      do
      {
        num = Conversions.ToInteger(Interaction.IIf(ligne[index] == '-', (object) checked (num + 1), (object) checked (num + Conversion.Val(ligne[index]))));
        checked { ++index; }
      }
      while (index <= 67);
      return num % 10 == int.Parse(ligne.Substring(68), (IFormatProvider) CultureInfo.CurrentCulture);
    }

    /// <summary>Verification des lignes d'un TLE</summary>
    /// <param name="li1">Ligne 1 du TLE</param>
    /// <param name="li2">Ligne 2 du TLE</param>
    /// <remarks></remarks>
    public static void VerifieLignes(string li1, string li2)
    {
      int ierr1 = 0;
      int num = 0;
      if (li1.Length != 69 || li2.Length != 69)
      {
        ierr1 = 1;
        checked { ++num; }
      }
      if (li1[0] != '1' || li2[0] != '2')
      {
        ierr1 = 2;
        checked { ++num; }
      }
      if (num == 1)
        throw new PreviSatException(ref ierr1);
      if (num > 1)
      {
        int ierr2 = 8;
        throw new PreviSatException(ref ierr2);
      }
      if (li1[1] != ' ' || li1[8] != ' ' || li1[17] != ' ' || li1[32] != ' ' || li1[43] != ' ' || li1[52] != ' ' || li1[61] != ' ' || li1[63] != ' ' || li2[1] != ' ' || li2[7] != ' ' || li2[16] != ' ' || li2[25] != ' ' || li2[33] != ' ' || li2[42] != ' ' || li2[51] != ' ')
      {
        int ierr3 = 3;
        throw new PreviSatException(ref ierr3);
      }
      if (li1[23] != '.' || li1[34] != '.' || li2[11] != '.' || li2[20] != '.' || li2[37] != '.' || li2[46] != '.' || li2[54] != '.')
      {
        int ierr4 = 4;
        throw new PreviSatException(ref ierr4);
      }
      if (!li1.Substring(2, 5).Equals(li2.Substring(2, 5)))
      {
        int ierr5 = 5;
        throw new PreviSatException(ref ierr5);
      }
      if (!TLE.CheckSum(li1))
      {
        int ierr6 = 6;
        throw new PreviSatException(ref ierr6);
      }
      if (!TLE.CheckSum(li2))
      {
        int ierr7 = 7;
        throw new PreviSatException(ref ierr7);
      }
    }

    public double Argpo => this._argpo;

    public double Bstar => this._bstar;

    public double Ecco => this._ecco;

    public Dates Epoque => this._epoque;

    public double Inclo => this._inclo;

    public string Ligne1 => this._ligne1;

    public string Ligne2 => this._ligne2;

    public double Mo => this._mo;

    public int Nb0 => this._nb0;

    public double No => this._no;

    public string Nom => this._nom;

    public string Norad => this._norad;

    public double Omegao => this._omegao;
  }
}
