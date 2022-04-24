// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Corps
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  public class Corps
  {
    protected double _azimut;
    protected double _hauteur;
    protected double _distance;
    protected double _ascensionDroite;
    protected double _declinaison;
    protected string _constellation;
    protected double _longitude;
    protected double _latitude;
    protected double _altitude;
    protected bool _visible;
    protected double _rangeRate;
    protected Vecteur _position;
    protected Vecteur _vitesse;
    protected Vecteur _dist;
    protected PointF[] _zone;
    private static bool _initCst;
    private static string[] _tabConst = new string[359];
    private static double[,] _tabCstCoord = new double[359, 3];

    public Corps()
    {
      this._position = new Vecteur();
      this._vitesse = new Vecteur();
      this._dist = new Vecteur();
      this._zone = new PointF[361];
    }

    /// <summary>Calcul des coordonnees equatoriales du corps (satellite, Soleil ...)</summary>
    /// <param name="observateur">Observateur</param>
    /// <remarks></remarks>
    public void CalculCoordEquat(Observateur observateur)
    {
      bool flag = false;
      int index = 0;
      double num = Math.Cos(this._hauteur);
      Vecteur vec = new Vecteur(-Math.Cos(this._azimut) * num, Math.Sin(this._azimut) * num, Math.Sin(this._hauteur));
      Vecteur vecteur = new Vecteur(observateur.RotEq.MultVec(vec));
      this._declinaison = Math.Asin(vecteur.Z);
      this._ascensionDroite = Math.Atan2(vecteur.Y, vecteur.X);
      if (this._ascensionDroite < 0.0)
        this._ascensionDroite += 2.0 * Math.PI;
      try
      {
        if (!Corps._initCst)
        {
          Corps.InitTabConstellations();
          Corps._initCst = true;
        }
        while (!flag)
        {
          if (this._declinaison >= Corps._tabCstCoord[index, 2] && this._ascensionDroite < Corps._tabCstCoord[index, 1] && this._ascensionDroite >= Corps._tabCstCoord[index, 0])
          {
            flag = true;
            this._constellation = Corps._tabConst[index];
          }
          checked { ++index; }
        }
      }
      catch (PreviSatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }

    /// <summary>
    /// Calcul des coordonnees horizontales du corps
    /// Le calcul de la refraction est issu de l'Astronomical Algorithms 2nd edition de Jean Meeus, p106.
    /// </summary>
    /// <param name="observateur">Observateur</param>
    /// <remarks></remarks>
    public void CalculCoordHoriz(Observateur observateur)
    {
      this._dist = this._position.Moins(observateur.Position);
      this._distance = this._dist.Norme();
      this._rangeRate = this._dist.ProduitScalaire(new Vecteur(this._vitesse.Moins(observateur.Vitesse))) / this._distance;
      Vecteur vecteur = new Vecteur(observateur.RotHz.MultVec(this._dist));
      this._azimut = Math.Atan2(vecteur.Y, -vecteur.X);
      if (this._azimut < 0.0)
        this._azimut += 2.0 * Math.PI;
      double num1 = Math.Asin(vecteur.Z / this._distance);
      double num2 = 180.0 / Math.PI * num1;
      double num3 = 0.0178023583703422 / (60.0 * Math.Tan(Math.PI / 180.0 * (num2 + 10.3 / (num2 + 5.11))));
      this._hauteur = num1 + num3;
      if (this._hauteur >= 0.0)
      {
        this._visible = true;
      }
      else
      {
        this._visible = false;
        this._hauteur = num1;
      }
    }

    /// <summary>Calcul des coordonnees terrestres du corps a la date courante</summary>
    /// <param name="observateur">Observateur</param>
    /// <remarks></remarks>
    public void CalculCoordTerrestres(Observateur observateur)
    {
      this._longitude = (observateur.TempsSideralGreenwich - Math.Atan2(this._position.Y, this._position.X)) % (2.0 * Math.PI);
      if (this._longitude > Math.PI)
        this._longitude -= 2.0 * Math.PI;
      if (this._longitude < -1.0 * Math.PI)
        this._longitude += 2.0 * Math.PI;
      this.CalculLatitudeAltitude();
    }

    /// <summary>Calcul des coordonnees terrestres du corps a une date donnee</summary>
    /// <param name="dat">Date</param>
    /// <remarks></remarks>
    public void CalculCoordTerrestres(Dates dat)
    {
      this._longitude = (Observateur.TempsSideralDeGreenwich(dat) - Math.Atan2(this._position.Y, this._position.X)) % (2.0 * Math.PI);
      if (this._longitude > Math.PI)
        this._longitude -= 2.0 * Math.PI;
      if (this._longitude < -1.0 * Math.PI)
        this._longitude += 2.0 * Math.PI;
      this.CalculLatitudeAltitude();
    }

    /// <summary>Calcul de la zone de visibilite</summary>
    /// <remarks></remarks>
    public void CalculZoneVisibilite()
    {
      double longitude = this._longitude;
      if (longitude > 0.0)
        longitude -= 2.0 * Math.PI;
      double num1 = Math.Cos(this._latitude);
      double num2 = Math.Sin(this._latitude);
      double num3 = Math.Acos(6363.136658 / this._position.Norme());
      if (double.IsNaN(num3))
        num3 = 0.0;
      double num4 = Math.Cos(num3);
      double num5 = Math.Sin(num3);
      int index = 0;
      do
      {
        double d1 = Math.PI / 180.0 * (double) index;
        double num6 = Math.Asin(num2 * num4 + Math.Cos(d1) * num5 * num1);
        double d2 = (num4 - num2 * Math.Sin(num6)) / (num1 * Math.Cos(num6));
        double num7 = index != 0 || num3 <= Math.PI / 2.0 - this._latitude ? (index != 180 || num3 <= Math.PI / 2.0 + this._latitude ? (Math.Abs(d2) <= 1.0 ? (index > 180 ? longitude - Math.Acos(d2) : longitude + Math.Acos(d2)) : longitude) : longitude + Math.PI) : longitude + Math.PI;
        this._zone[index].X = (float) ((Math.PI - num7) % (2.0 * Math.PI) * (180.0 / Math.PI));
        this._zone[index].Y = (float) ((Math.PI / 2.0 - num6) * (180.0 / Math.PI));
        checked { ++index; }
      }
      while (index <= 359);
      this._zone[360].X = this._zone[0].X;
      this._zone[360].Y = this._zone[0].Y;
    }

    /// <summary>Calcul de la zone de visibilite</summary>
    /// <remarks></remarks>
    public void CalculZoneVisibiliteSoleil()
    {
      Vecteur vecteur = new Vecteur(MyProject.Forms.Home.XS, MyProject.Forms.Home.YS, MyProject.Forms.Home.ZS);
      double num1 = Math.PI / 180.0 * MyProject.Forms.Home.LATS;
      double num2 = -(Math.PI / 180.0 * MyProject.Forms.Home.LONGIS);
      if (num2 > 0.0)
        num2 -= 2.0 * Math.PI;
      double num3 = Math.Cos(num1);
      double num4 = Math.Sin(num1);
      double num5 = Math.Acos(6363.136658 / vecteur.Norme());
      if (double.IsNaN(num5))
        num5 = 0.0;
      double num6 = Math.Cos(num5);
      double num7 = Math.Sin(num5);
      int index = 0;
      do
      {
        double d1 = Math.PI / 180.0 * (double) index;
        double num8 = Math.Asin(num4 * num6 + Math.Cos(d1) * num7 * num3);
        double d2 = (num6 - num4 * Math.Sin(num8)) / (num3 * Math.Cos(num8));
        double num9 = index != 0 || num5 <= Math.PI / 2.0 - num1 ? (index != 180 || num5 <= Math.PI / 2.0 + num1 ? (Math.Abs(d2) <= 1.0 ? (index > 180 ? num2 - Math.Acos(d2) : num2 + Math.Acos(d2)) : num2) : num2 + Math.PI) : num2 + Math.PI;
        MyProject.Forms.Home.SunZone[index].X = (float) ((Math.PI - num9) % (2.0 * Math.PI) * (180.0 / Math.PI));
        MyProject.Forms.Home.SunZone[index].Y = (float) ((Math.PI / 2.0 - num8) * (180.0 / Math.PI));
        checked { ++index; }
      }
      while (index <= 359);
      MyProject.Forms.Home.SunZone[360].X = MyProject.Forms.Home.SunZone[0].X;
      MyProject.Forms.Home.SunZone[360].Y = MyProject.Forms.Home.SunZone[0].Y;
    }

    /// <summary>Formattage des angles</summary>
    /// <remarks></remarks>
    public void FormatteAngles()
    {
      this._azimut *= 180.0 / Math.PI;
      this._hauteur *= 180.0 / Math.PI;
      this._declinaison *= 180.0 / Math.PI;
      this._ascensionDroite *= 12.0 / Math.PI;
    }

    /// <summary>Initialisation du tableau de constellations (un seul acces fichier)</summary>
    /// <remarks></remarks>
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private static void InitTabConstellations()
    {
      NumberFormatInfo numberFormat = new CultureInfo("en-US", false).NumberFormat;
      int index = 0;
      StreamReader streamReader = new StreamReader(MyProject.Application.Info.DirectoryPath + "\\data\\constellations.cst");
      while (streamReader.Peek() != -1)
      {
        string str = streamReader.ReadLine();
        Corps._tabConst[index] = str.Substring(0, 3);
        Corps._tabCstCoord[index, 0] = double.Parse(str.Substring(4, 7), (IFormatProvider) numberFormat) * (Math.PI / 12.0);
        Corps._tabCstCoord[index, 1] = double.Parse(str.Substring(12, 7), (IFormatProvider) numberFormat) * (Math.PI / 12.0);
        Corps._tabCstCoord[index, 2] = Math.PI / 180.0 * double.Parse(str.Substring(20, 8), (IFormatProvider) numberFormat);
        checked { ++index; }
      }
      streamReader.Close();
      if (index == 0)
        throw new PreviSatException();
    }

    /// <summary>Calcul de la latitude et de l'altitude survolees par le corps</summary>
    /// <remarks></remarks>
    private void CalculLatitudeAltitude()
    {
      this._latitude = Math.PI;
      double x = Math.Sqrt(this._position.X * this._position.X + this._position.Y * this._position.Y);
      this._latitude = Math.Atan2(this._position.Z, x);
      double latitude;
      double num1;
      do
      {
        latitude = this._latitude;
        double num2 = Math.Sin(latitude);
        num1 = 1.0 / Math.Sqrt(1.0 - 0.00669431777826672 * num2 * num2);
        this._latitude = Math.Atan((this._position.Z + 6378.136658 * num1 * 0.00669431777826672 * num2) / x);
      }
      while (Math.Abs(this._latitude - latitude) > 1E-07);
      this._altitude = Conversions.ToDouble(Interaction.IIf(x < 0.001, (object) (Math.Abs(this._position.Z) - 6356.75217245719), (object) (x / Math.Cos(this._latitude) - 6378.136658 * num1)));
    }

    public double Altitude => this._altitude;

    public double AscensionDroite => this._ascensionDroite;

    public double Azimut => this._azimut;

    public string Constellation => this._constellation;

    public double Declinaison => this._declinaison;

    public double Distance => this._distance;

    public Vecteur Dist => this._dist;

    public double Hauteur => this._hauteur;

    public double Latitude => this._latitude;

    public double Longitude => this._longitude;

    public Vecteur Position
    {
      get => this._position;
      set => this._position = value;
    }

    public double RangeRate => this._rangeRate;

    public bool Visible => this._visible;

    public Vecteur Vitesse => this._vitesse;

    public PointF[] Zone => this._zone;

    ~Corps() => base.Finalize();
  }
}
