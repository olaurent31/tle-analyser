// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Observateur
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using System;

namespace TLE_Analyser
{
  public class Observateur
  {
    private double _longitude;
    private double _latitude;
    private double _altitude;
    private string _nomlieu;
    private double _coslat;
    private double _sinlat;
    private double _rayon;
    private double _posZ;
    private double _aaer;
    private double _aray;
    private double _tempsSideralGreenwich;
    private Vecteur _position;
    private Vecteur _vitesse;
    private Matrice _rotHz;
    private Matrice _rotEq;

    /// <summary>Constructeur d'un lieu d'observation a partir de ses coordonnees</summary>
    /// <param name="lieu">Nom du lieu d'observation</param>
    /// <param name="longitude">Longitude (en degres, negative a l'est)</param>
    /// <param name="latitude">Latitude (en degres)</param>
    /// <param name="altitude">Altitude (en metres)</param>
    /// <remarks></remarks>
    public Observateur(string lieu, double longitude, double latitude, double altitude)
    {
      this._position = new Vecteur();
      this._vitesse = new Vecteur();
      this._rotHz = new Matrice();
      this._rotEq = new Matrice();
      this._nomlieu = lieu;
      this._longitude = Math.PI / 180.0 * longitude;
      this._latitude = Math.PI / 180.0 * latitude;
      this._altitude = altitude * 0.001;
      this._coslat = Math.Cos(this._latitude);
      this._sinlat = Math.Sin(this._latitude);
      double num1 = 1.0 / Math.Sqrt(1.0 - 0.00669431777826672 * this._sinlat * this._sinlat);
      double num2 = 0.993305682221733 * num1;
      this._rayon = (6378.136658 * num1 + this._altitude) * this._coslat;
      this._posZ = (6378.136658 * num2 + this._altitude) * this._sinlat;
      this._aray = 0.1451 * Math.Exp(-this._altitude / 7.996);
      this._aaer = 0.12 * Math.Exp(-this._altitude / 1.5);
    }

    /// <summary>Constructeur a partir d'un lieu d'observation</summary>
    /// <param name="observateur">Lieu d'observation</param>
    /// <remarks></remarks>
    public Observateur(Observateur observateur)
    {
      this._position = new Vecteur();
      this._vitesse = new Vecteur();
      this._rotHz = new Matrice();
      this._rotEq = new Matrice();
      this._nomlieu = observateur._nomlieu;
      this._longitude = observateur._longitude;
      this._latitude = observateur._latitude;
      this._altitude = observateur._altitude;
      this._coslat = observateur._coslat;
      this._sinlat = observateur._sinlat;
      this._rayon = observateur._rayon;
      this._posZ = observateur._posZ;
      this._aray = observateur._aray;
      this._aaer = observateur._aaer;
    }

    /// <summary>
    /// Calcul de la position et de la vitesse ECI de l'observateur a une date donnee
    /// </summary>
    /// <param name="dat">Date</param>
    /// <remarks></remarks>
    public void CalculPosVit(Dates dat)
    {
      this._tempsSideralGreenwich = Observateur.TempsSideralDeGreenwich(dat);
      double num1 = this._tempsSideralGreenwich - this._longitude;
      double y = Math.Cos(num1);
      double num2 = Math.Sin(num1);
      this._position = new Vecteur(this._rayon * y, this._rayon * num2, this._posZ);
      this._vitesse = new Vecteur(-7.29211585530659E-05 * this._position.Y, 7.29211585530659E-05 * this._position.X, 0.0);
      this._rotHz = new Matrice(new Vecteur(this._sinlat * y, -num2, this._coslat * y), new Vecteur(this._sinlat * num2, y, this._coslat * num2), new Vecteur(-this._coslat, 0.0, this._sinlat));
      this._rotEq = new Matrice(this._rotHz.Transpose());
    }

    /// <summary>
    /// Calcul du temps sideral de Greenwich.
    /// D'apres la formule donnee dans l'Astronomical Algorithms 2nd edition de Jean Meeus, p88
    /// </summary>
    /// <param name="dat">Date</param>
    /// <returns></returns>
    /// <remarks></remarks>
    public static double TempsSideralDeGreenwich(Dates dat)
    {
      double num1 = dat.JourJulienUTC * 2.7378507871321E-05;
      double num2 = num1 * num1;
      return Math.PI / 180.0 * ((280.46061837 + 360.98564736629 * dat.JourJulienUTC + 0.000387933 * num2 - num2 * num1 / 38710000.0) % 360.0);
    }

    public double Aaer => this._aaer;

    public double Altitude => this._altitude;

    public double Aray => this._aray;

    public double Latitude => this._latitude;

    public double Longitude => this._longitude;

    public string Nomlieu => this._nomlieu;

    public Vecteur Position => this._position;

    public Matrice RotEq => this._rotEq;

    public Matrice RotHz => this._rotHz;

    public double TempsSideralGreenwich => this._tempsSideralGreenwich;

    public Vecteur Vitesse => this._vitesse;
  }
}
