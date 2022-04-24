// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.LigneConstellation
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  public class LigneConstellation
  {
    private const int MAXTAB = 646;
    private bool _dessin;
    private static bool _initLig;
    private Etoile _etoile1;
    private Etoile _etoile2;
    private static int[,] _tabLigCst = new int[647, 2];

    /// <summary>Constructeur d'une ligne de constellation</summary>
    /// <param name="etoile1">Etoile 1</param>
    /// <param name="etoile2">Etoile 2</param>
    /// <remarks></remarks>
    public LigneConstellation(Etoile etoile1, Etoile etoile2)
    {
      this._etoile1 = etoile1;
      this._etoile2 = etoile2;
      this._dessin = this._etoile1.Visible && this._etoile2.Visible;
    }

    /// <summary>Calcul des lignes de constellation</summary>
    /// <param name="etoiles">Catalogue d'etoiles</param>
    /// <param name="lignesCst">Lignes de constellation</param>
    /// <remarks></remarks>
    public static void CalculLignesCst(Etoile[] etoiles, ref LigneConstellation[] lignesCst)
    {
      if (!LigneConstellation._initLig)
      {
        lignesCst = new LigneConstellation[646];
        LigneConstellation.InitTabLignesCst();
        LigneConstellation._initLig = true;
      }
      int index1 = 0;
      do
      {
        int index2 = checked (LigneConstellation._tabLigCst[index1, 0] - 1);
        int index3 = checked (LigneConstellation._tabLigCst[index1, 1] - 1);
        lignesCst[index1] = new LigneConstellation(etoiles[index2], etoiles[index3]);
        checked { ++index1; }
      }
      while (index1 <= 645);
    }

    /// <summary>Lecture du fichier de constellations</summary>
    /// <remarks></remarks>
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private static void InitTabLignesCst()
    {
      NumberFormatInfo numberFormat = new CultureInfo("en-US", false).NumberFormat;
      int index1 = 0;
      StreamReader streamReader = new StreamReader(MyProject.Application.Info.DirectoryPath + "\\data\\constlines.cst");
      while (streamReader.Peek() != -1)
      {
        string[] strArray = streamReader.ReadLine().Split(' ');
        int index2 = 0;
        do
        {
          LigneConstellation._tabLigCst[index1, index2] = int.Parse(strArray[index2], (IFormatProvider) numberFormat);
          checked { ++index2; }
        }
        while (index2 <= 1);
        checked { ++index1; }
      }
      streamReader.Close();
      if (index1 == 0)
        throw new PreviSatException();
    }

    public bool Dessin => this._dessin;

    public Etoile Etoile1 => this._etoile1;

    public Etoile Etoile2 => this._etoile2;
  }
}
