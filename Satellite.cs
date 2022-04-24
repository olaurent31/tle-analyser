// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Satellite
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
  public class Satellite : Corps
  {
    private const double J3SJ2 = -0.00234507015323442;
    private const double RPTIM = 0.00437526951318395;
    private const double ZEL = 0.0549;
    private const double ZES = 0.01675;
    private const double ZNL = 0.00015835218;
    private const double ZNS = 1.19459E-05;
    private const double C1SS = 2.9864797E-06;
    private const double C1L = 4.7968065E-07;
    private const double ZSINIS = 0.39785416;
    private const double ZCOSIS = 0.91744867;
    private const double ZCOSGS = 0.1945905;
    private const double ZSINGS = -0.98088458;
    private const double Q22 = 1.7891679E-06;
    private const double Q31 = 2.1460748E-06;
    private const double Q33 = 2.2123015E-07;
    private const double ROOT22 = 1.7891679E-06;
    private const double ROOT44 = 7.3636953E-09;
    private const double ROOT54 = 2.1765803E-09;
    private const double ROOT32 = 3.7393792E-07;
    private const double ROOT52 = 1.1428639E-07;
    private const double FASX2 = 0.13130908;
    private const double FASX4 = 2.8843198;
    private const double FASX6 = 0.37448087;
    private const double G22 = 5.7686396;
    private const double G32 = 0.95240898;
    private const double G44 = 1.8014998;
    private const double G52 = 1.050833;
    private const double G54 = 4.4108898;
    private const double STEPP = 720.0;
    private const double STEPN = -720.0;
    private const double STEP2 = 259200.0;
    public static bool initCalcul;
    private bool _eclipse;
    private bool _penombre;
    private char _methMagnitude;
    private int _nbOrbites;
    private double _elongation;
    private double _fractionIlluminee;
    private double _magnitude;
    private double _magnitudeStandard;
    private double _rayonApparentSoleil;
    private double _rayonApparentTerre;
    private double _section;
    private double _t1;
    private double _t2;
    private double _t3;
    private bool _ieralt;
    private char _method;
    private TLE _tle;
    private SatVariables _sat;
    private double[,] _trajectoire;
    private ElementsOsculateurs _elements;

    /// <summary>Constructeur par defaut</summary>
    /// <remarks></remarks>
    public Satellite(TLE tle)
    {
      this._eclipse = true;
      this._sat = new SatVariables();
      this._trajectoire = new double[361, 3];
      this._elements = new ElementsOsculateurs();
      this._tle = tle != null ? tle : throw new PreviSatException();
      this.SGP4Init();
    }

    /// <summary>Calcul de la position et de la vitesse d'un satellite</summary>
    /// <param name="dat">Date</param>
    /// <remarks>Modele SGP4 : d'apres l'article "Revisiting Spacetrack Report #3: Rev 1" de David Vallado (2006)</remarks>
    public void CalculPosVit(Dates dat, double dat2)
    {
      DateTime date = Conversions.ToDate(Functions.MJDtoGreg(Conversions.ToString(dat2)));
      double day = (double) date.Day;
      double month = (double) date.Month;
      double year = (double) date.Year;
      double hour = (double) date.Hour;
      double minute = (double) date.Minute;
      double second = (double) date.Second;
      Dates dates = new Dates(checked ((int) Math.Round(year)), checked ((int) Math.Round(month)), checked ((int) Math.Round(day)), checked ((int) Math.Round(hour)), checked ((int) Math.Round(minute)), second, 0.0);
      double num1 = 1440.0 * (dat.JourJulienUTC - dates.JourJulienUTC);
      try
      {
        this._sat.t = num1;
        double d1 = (this._sat.mo + this._sat.mdot * this._sat.t) % (2.0 * Math.PI);
        double num2 = this._sat.argpo + this._sat.argpdot * this._sat.t;
        double num3 = this._sat.omegao + this._sat.nodedot * this._sat.t;
        this._sat.argpm = num2;
        this._sat.mm = d1;
        double num4 = this._sat.t * this._sat.t;
        this._sat.nodem = num3 + this._sat.nodecf * num4;
        double num5 = 1.0 - this._sat.cc1 * this._sat.t;
        double num6 = this._sat.bstar * this._sat.cc4 * this._sat.t;
        double num7 = this._sat.t2cof * num4;
        if (!this._sat.isimp)
        {
          double num8 = this._sat.omgcof * this._sat.t + this._sat.xmcof * (Math.Pow(1.0 + this._sat.eta * Math.Cos(d1), 3.0) - this._sat.delmo);
          this._sat.mm = d1 + num8;
          this._sat.argpm = num2 - num8;
          double num9 = num4 * this._sat.t;
          double num10 = num9 * this._sat.t;
          num5 += -this._sat.d2 * num4 - this._sat.d3 * num9 - this._sat.d4 * num10;
          num6 += this._sat.bstar * this._sat.cc5 * (Math.Sin(this._sat.mm) - this._sat.sinmao);
          num7 += this._sat.t3cof * num9 + num10 * (this._sat.t4cof + this._sat.t * this._sat.t5cof);
        }
        this._sat.nm = this._sat.no;
        this._sat.em = this._sat.ecco;
        this._sat.inclm = this._sat.inclo;
        if (this._method == 'd')
          this.Dspace(this._sat.t);
        double num11 = Math.Pow(Terre.KE / this._sat.nm, 2.0 / 3.0) * num5 * num5;
        this._sat.nm = Terre.KE * Math.Pow(num11, -1.5);
        this._sat.em -= num6;
        if (this._sat.em < 1E-06)
          this._sat.em = 1E-06;
        this._sat.mm += this._sat.no * num7;
        double num12 = this._sat.mm + this._sat.argpm + this._sat.nodem;
        this._sat.emsq = this._sat.em * this._sat.em;
        double num13 = 1.0 - this._sat.emsq;
        this._sat.nodem %= 2.0 * Math.PI;
        this._sat.argpm %= 2.0 * Math.PI;
        this._sat.mm = (num12 % (2.0 * Math.PI) - this._sat.argpm - this._sat.nodem) % (2.0 * Math.PI);
        this._sat.sinim = Math.Sin(this._sat.inclm);
        this._sat.cosim = Math.Cos(this._sat.inclm);
        this._sat.ep = this._sat.em;
        this._sat.xincp = this._sat.inclm;
        this._sat.argpp = this._sat.argpm;
        this._sat.omegap = this._sat.nodem;
        this._sat.mp = this._sat.mm;
        double num14 = this._sat.sinim;
        double num15 = this._sat.cosim;
        if (this._method == 'd')
        {
          this.Dpper();
          if (this._sat.xincp < 0.0)
          {
            this._sat.xincp = -this._sat.xincp;
            this._sat.omegap += Math.PI;
            this._sat.argpp -= Math.PI;
          }
        }
        if (this._method == 'd')
        {
          num14 = Math.Sin(this._sat.xincp);
          num15 = Math.Cos(this._sat.xincp);
          this._sat.aycof = 0.00117253507661721 * num14;
          this._sat.xlcof = Math.Abs(num15 + 1.0) <= 1.5E-12 ? 0.000586267538308604 * num14 * (3.0 + 5.0 * num15) / 1.5E-12 : 0.000586267538308604 * num14 * (3.0 + 5.0 * num15) / (1.0 + num15);
        }
        double num16 = this._sat.ep * Math.Cos(this._sat.argpp);
        double num17 = 1.0 / (num11 * (1.0 - this._sat.ep * this._sat.ep));
        double num18 = this._sat.ep * Math.Sin(this._sat.argpp) + num17 * this._sat.aycof;
        double num19 = (this._sat.mp + this._sat.argpp + this._sat.omegap + num17 * this._sat.xlcof * num16 - this._sat.omegap) % (2.0 * Math.PI);
        double num20 = num19;
        double num21 = 9999.9;
        int num22 = 1;
        double num23;
        double num24;
        while (Math.Abs(num21) >= 1E-12 && num22 <= 10)
        {
          num23 = Math.Sin(num20);
          num24 = Math.Cos(num20);
          double num25 = 1.0 - num24 * num16 - num23 * num18;
          num21 = (num19 - num18 * num24 + num16 * num23 - num20) / num25;
          if (Math.Abs(num21) >= 0.95)
            num21 = Conversions.ToDouble(Interaction.IIf(num21 > 0.0, (object) 0.95, (object) -0.95));
          num20 += num21;
          checked { ++num22; }
        }
        double num26 = num16 * num24 + num18 * num23;
        double num27 = num16 * num23 - num18 * num24;
        double num28 = num16 * num16 + num18 * num18;
        double d2 = num11 * (1.0 - num28);
        if (d2 < 0.0)
          return;
        double num29 = num11 * (1.0 - num26);
        double num30 = Math.Sqrt(num11) * num27 / num29;
        double num31 = Math.Sqrt(d2) / num29;
        double num32 = Math.Sqrt(1.0 - num28);
        double num33 = num27 / (1.0 + num32);
        double y1 = num11 / num29 * (num23 - num18 - num16 * num33);
        double x1 = num11 / num29 * (num24 - num16 + num18 * num33);
        double num34 = Math.Atan2(y1, x1);
        double num35 = (x1 + x1) * y1;
        double num36 = 1.0 - 2.0 * y1 * y1;
        double num37 = 1.0 / d2;
        double num38 = 0.0005413079 * num37;
        double num39 = num38 * num37;
        if (this._method == 'd')
        {
          double num40 = num15 * num15;
          this._sat.con41 = 3.0 * num40 - 1.0;
          this._sat.x1mth2 = 1.0 - num40;
          this._sat.x7thm1 = 7.0 * num40 - 1.0;
        }
        double xval1 = 6378.136658 * (num29 * (1.0 - 1.5 * num39 * num32 * this._sat.con41) + 0.5 * num38 * this._sat.x1mth2 * num36);
        double num41 = num34 - 0.25 * num39 * this._sat.x7thm1 * num35;
        double num42 = this._sat.omegap + 1.5 * num39 * num15 * num35;
        double num43 = this._sat.xincp + 1.5 * num39 * num15 * num14 * num36;
        double xval2 = 106.302277633333 * (Terre.KE * num30 - this._sat.nm * num38 * this._sat.x1mth2 * num35);
        double num44 = 106.302277633333 * (Terre.KE * num31 + this._sat.nm * num38 * (this._sat.x1mth2 * num36 + 1.5 * this._sat.con41));
        double y2 = Math.Sin(num42);
        double x2 = Math.Cos(num42);
        double num45 = Math.Cos(num43);
        double xval3 = Math.Sin(num41);
        double xval4 = Math.Cos(num41);
        Vecteur vecteur1 = new Vecteur(-y2 * num45, x2 * num45, Math.Sin(num43));
        Vecteur vecteur2 = new Vecteur(x2, y2, 0.0);
        Vecteur vecteur3 = new Vecteur(vecteur1.MultScal(xval3).Moins(vecteur2.MultScal(-xval4)));
        Vecteur vecteur4 = new Vecteur(vecteur1.MultScal(xval4).Moins(vecteur2.MultScal(xval3)));
        this._position = vecteur3.MultScal(xval1);
        this._vitesse = vecteur3.MultScal(xval2).Moins(vecteur4.MultScal(-num44));
      }
      catch (PreviSatException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }

    /// <summary>Determination de la condition d'eclipse du satellite</summary>
    /// <param name="sun">Soleil</param>
    /// <remarks></remarks>
    public void CalculEclipse(Soleil sun)
    {
      this._rayonApparentTerre = Math.Asin(6378.136658 / this._position.Norme());
      if (double.IsNaN(this._rayonApparentTerre))
        this._rayonApparentTerre = Math.PI / 2.0;
      this._rayonApparentSoleil = Math.Asin(696000.0 / new Vecteur(sun.Position.Moins(this._position)).Norme());
      this._elongation = sun.Position.Angle(this._position.Oppose());
      this._eclipse = Conversions.ToBoolean(Interaction.IIf(this._rayonApparentTerre > this._rayonApparentSoleil && this._elongation < this._rayonApparentTerre - this._rayonApparentSoleil, (object) true, (object) false));
      this._penombre = Conversions.ToBoolean(Interaction.IIf(Math.Abs(this._rayonApparentTerre - this._rayonApparentSoleil) < this._elongation && this._elongation < this._rayonApparentTerre + this._rayonApparentSoleil, (object) true, (object) false));
    }

    /// <summary>Calcul de la magnitude du satellite</summary>
    /// <param name="observateur">Observateur</param>
    /// <param name="extinction">Prise en compte de l'extinction atmospherique</param>
    /// <remarks></remarks>
    public void CalculMagnitude(Observateur observateur, bool extinction)
    {
      this._magnitude = 99.0;
      if (this._eclipse)
        return;
      this._fractionIlluminee = 0.5 * (1.0 + Math.Cos(this._elongation));
      if (this._magnitudeStandard < 99.0)
      {
        this._magnitude = this._magnitudeStandard - 15.75 + 2.5 * Math.Log10(this._distance * this._distance / this._fractionIlluminee);
        if (extinction)
          this._magnitude += this.ExtinctionAtmospherique(observateur);
      }
    }

    /// <summary>
    /// Determination de l'extinction atmospherique, issu de l'article
    /// "Magnitude corrections for atmospheric extinction" de Daniel Green, 1992
    /// </summary>
    /// <param name="observateur">Observateur</param>
    /// <returns>Correction due a l'extinction atmospherique</returns>
    /// <remarks></remarks>
    public double ExtinctionAtmospherique(Observateur observateur)
    {
      double num1 = 0.0;
      if (this._hauteur > 0.0)
      {
        double num2 = Math.Cos(Math.PI / 2.0 - this._hauteur);
        num1 = 1.0 / (num2 + 0.025 * Math.Exp(-11.0 * num2)) * (0.016 + observateur.Aray + observateur.Aaer);
      }
      return num1;
    }

    /// <summary>Calcul des elements osculateurs du satellite</summary>
    /// <param name="dat">Dates</param>
    /// <param name="tle">TLE du satellite</param>
    /// <remarks></remarks>
    public void CalculElementsOsculateurs(Dates dat, TLE tle)
    {
      double num1 = 2.50877795188635E-06;
      double num2 = this._position.Norme();
      if (num2 < 1E-10)
        return;
      double num3 = 1.0 / num2;
      double num4 = this._vitesse.Norme();
      double num5 = num4 * num4;
      double num6 = this._position.ProduitScalaire(this._vitesse);
      this._elements._demiGrandAxe = 1.0 / (2.0 * num3 - num5 * num1);
      Vecteur vec = new Vecteur(this._position.MultScal(num5 * num1 - num3).Moins(this._vitesse.MultScal(num6 * num1)));
      this._elements._excentricite = vec.Norme();
      Vecteur vecteur1 = new Vecteur(this._position.ProduitVectoriel(this._vitesse));
      this._elements._inclinaison = Math.Acos(vecteur1.Z / vecteur1.Norme());
      Vecteur vecteur2 = new Vecteur(-vecteur1.Y, vecteur1.X, 0.0);
      this._elements._ascDroiteNA = Math.Acos(vecteur2.X / vecteur2.Norme());
      if (vecteur2.Y < 0.0)
        this._elements._ascDroiteNA = 2.0 * Math.PI - this._elements._ascDroiteNA;
      this._elements._argumentPerigee = Math.Acos(vecteur2.ProduitScalaire(vec) / (vecteur2.Norme() * this._elements._excentricite));
      if (vec.Z < 0.0)
        this._elements._argumentPerigee = 2.0 * Math.PI - this._elements._argumentPerigee;
      this._elements._anomalieVraie = Math.Acos(vec.ProduitScalaire(this._position) * num3 / this._elements._excentricite);
      if (num6 < 0.0)
        this._elements._anomalieVraie = 2.0 * Math.PI - this._elements._anomalieVraie;
      this._elements._anomalieExcentrique = 2.0 * Math.Atan(Math.Sqrt((1.0 - this._elements._excentricite) / (1.0 + this._elements._excentricite)) * Math.Tan(0.5 * this._elements._anomalieVraie));
      if (this._elements._anomalieExcentrique < 0.0)
        this._elements._anomalieExcentrique += 2.0 * Math.PI;
      this._elements._anomalieMoyenne = this._elements._anomalieExcentrique - this._elements._excentricite * Math.Sin(this._elements._anomalieExcentrique);
      if (this._elements._anomalieMoyenne < 0.0)
        this._elements._anomalieMoyenne += 2.0 * Math.PI;
      double num7 = this._elements._demiGrandAxe / 6378.136658;
      double num8 = num7 * num7;
      double d = 1.0 - this._elements._excentricite * this._elements._excentricite;
      double num9 = 1.0 + this._elements._excentricite * Math.Cos(this._elements._argumentPerigee);
      double num10 = num9 * num9;
      double num11 = Math.Sin(this._elements._inclinaison);
      double num12 = 1.0 - 0.0016239237 * ((2.0 - 2.5 * num11 * num11) / (num8 * Math.Sqrt(d) * num10) + num10 * num9 / (num8 * d * d * d));
      this._elements._apogee = this._elements._demiGrandAxe * (1.0 + this._elements._excentricite);
      this._elements._perigee = this._elements._demiGrandAxe * (1.0 - this._elements._excentricite);
      this._elements._periode = num12 * (2.0 * Math.PI) * Math.Sqrt(this._elements._demiGrandAxe * this._elements._demiGrandAxe * this._elements._demiGrandAxe / 398600.4418) * 0.000277777777777778;
      double num13 = dat.JourJulienUTC - tle.Epoque.JourJulienUTC;
      this._nbOrbites = checked (tle.Nb0 + (int) Math.Round(Math.Floor(unchecked ((tle.No + num13 * tle.Bstar) * num13 + (tle.Omegao + tle.Mo) % (2.0 * Math.PI) / 360.0 - (this._elements._argumentPerigee + this._elements._anomalieVraie) % (2.0 * Math.PI) / (2.0 * Math.PI) + 0.5))));
      this._elements._inclinaison *= 180.0 / Math.PI;
      this._elements._ascDroiteNA *= 180.0 / Math.PI;
      this._elements._argumentPerigee *= 180.0 / Math.PI;
      this._elements._anomalieVraie *= 180.0 / Math.PI;
      this._elements._anomalieMoyenne *= 180.0 / Math.PI;
      this._elements._anomalieExcentrique *= 180.0 / Math.PI;
    }

    /// <summary>Calcul de la position d'une liste de satellites</summary>
    /// <param name="dat">Date</param>
    /// <param name="tle">Ensemble des TLE de la liste de satellites</param>
    /// <param name="observateur">Observateur</param>
    /// <param name="soleil">Soleil</param>
    /// <param name="nbTrajectoires">Nombre de trajectoires a calculer</param>
    /// <param name="visibilite">Calcul de la zone de visibilite des satellites</param>
    /// <param name="extinction">Prise en compte de l'extinction atmospherique</param>
    /// <param name="satellites">Liste de satellites</param>
    /// <remarks></remarks>
    public static void CalculPositionListeSatellites(
      Dates dat,
      TLE[] tle,
      Observateur observateur,
      Soleil soleil,
      int nbTrajectoires,
      bool visibilite,
      bool extinction,
      ref Satellite[] satellites)
    {
      if (!Satellite.initCalcul)
      {
        satellites = new Satellite[checked (tle.Length - 1 + 1)];
        int num = checked (tle.Length - 1);
        int index = 0;
        while (index <= num)
        {
          satellites[index] = new Satellite(tle[index]);
          checked { ++index; }
        }
        if (tle.Length > 0)
          Satellite.initCalcul = true;
      }
      int num1 = checked (tle.Length - 1);
      int index1 = 0;
      while (index1 <= num1)
      {
        satellites[index1].CalculPosVit(Functions.MJD2JJ(MyProject.Forms.Home.EPOCH), MyProject.Forms.Home.TLEPOCH);
        satellites[index1].CalculCoordHoriz(observateur);
        satellites[index1].CalculEclipse(soleil);
        satellites[index1]._ieralt = satellites[index1].Altitude < 0.0;
        if (visibilite)
          satellites[index1].CalculZoneVisibilite();
        if (index1 == 0)
        {
          satellites[index1].CalculCoordEquat(observateur);
          satellites[index1].CalculMagnitude(observateur, extinction);
          satellites[index1].CalculElementsOsculateurs(dat, tle[index1]);
        }
        checked { ++index1; }
      }
    }

    /// <summary>Lecture du fichier de magnitude standard</summary>
    /// <param name="listeSatellites">Liste de satellites</param>
    /// <param name="sat">Ensemble des satellites</param>
    /// <remarks></remarks>
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void LectureMagnitudeStandard(
      string[] listeSatellites,
      TLE[] tabtle,
      ref Satellite[] sat)
    {
      NumberFormatInfo numberFormat = new CultureInfo("en-US", false).NumberFormat;
      int num1 = 0;
      if (!Satellite.initCalcul)
      {
        sat = new Satellite[checked (listeSatellites.Length - 1 + 1)];
        int num2 = checked (listeSatellites.Length - 1);
        int index = 0;
        while (index <= num2)
        {
          sat[index] = new Satellite(tabtle[index]);
          checked { ++index; }
        }
        if (listeSatellites.Length > 0)
          Satellite.initCalcul = true;
      }
      int num3 = checked (listeSatellites.Length - 1);
      int index1 = 0;
      while (index1 <= num3)
      {
        sat[index1]._magnitudeStandard = 99.0;
        checked { ++index1; }
      }
      StreamReader streamReader = new StreamReader(MyProject.Application.Info.DirectoryPath + "\\data\\magnitude");
      while (streamReader.Peek() != -1 && num1 <= checked (listeSatellites.Length - 1))
      {
        string str = streamReader.ReadLine();
        int num4 = checked (listeSatellites.Length - 1);
        int index2 = 0;
        while (index2 <= num4)
        {
          if (listeSatellites[index2].Equals(str.Substring(0, 5)))
          {
            sat[index2]._t1 = double.Parse(str.Substring(6, 5), (IFormatProvider) numberFormat);
            sat[index2]._t2 = double.Parse(str.Substring(12, 4), (IFormatProvider) numberFormat);
            sat[index2]._t3 = double.Parse(str.Substring(17, 4), (IFormatProvider) numberFormat);
            sat[index2]._magnitudeStandard = double.Parse(str.Substring(22, 4), (IFormatProvider) numberFormat);
            sat[index2]._methMagnitude = str[27];
            sat[index2]._section = double.Parse(str.Substring(29, 6), (IFormatProvider) numberFormat);
            checked { ++num1; }
            break;
          }
          checked { ++index2; }
        }
      }
      streamReader.Close();
    }

    public void SGP4Init()
    {
      this._method = 'n';
      this._sat.argpo = Math.PI / 180.0 * this._tle.Argpo;
      this._sat.bstar = this._tle.Bstar;
      this._sat.ecco = this._tle.Ecco;
      this._sat.epoque = this._tle.Epoque;
      this._sat.inclo = Math.PI / 180.0 * this._tle.Inclo;
      this._sat.mo = Math.PI / 180.0 * this._tle.Mo;
      this._sat.no = this._tle.No * (2.0 * Math.PI) * 0.000694444444444444;
      this._sat.omegao = Math.PI / 180.0 * this._tle.Omegao;
      double num1 = 1.01222927701026;
      double num2 = Math.Pow(0.00658499531321895, 4.0);
      this._sat.t = 0.0;
      this.Initl();
      if (this._sat.omeosq < 0.0 && this._sat.no <= 0.0)
        throw new PreviSatException();
      this._sat.isimp = false;
      if (this._sat.rp < 1.03449283259305)
        this._sat.isimp = true;
      double num3 = num1;
      double num4 = num2;
      if (this._sat.rp < 1.0)
        this._sat.rp = 1.0;
      double num5 = (this._sat.rp - 1.0) * 6378.136658;
      if (num5 < 156.0)
      {
        double num6 = num5 - 78.0;
        if (num5 < 98.0)
          num6 = 20.0;
        num4 = Math.Pow((120.0 - num6) / 6378.136658, 4.0);
        num3 = num6 / 6379.136658;
      }
      double num7 = 1.0 / this._sat.posq;
      double x1 = 1.0 / (this._sat.ao - num3);
      this._sat.eta = this._sat.ao * this._sat.ecco * x1;
      double num8 = this._sat.eta * this._sat.eta;
      double num9 = this._sat.ecco * this._sat.eta;
      double x2 = Math.Abs(1.0 - num8);
      double num10 = num4 * Math.Pow(x1, 4.0);
      double num11 = num10 * Math.Pow(x2, -3.5);
      this._sat.cc1 = this._sat.bstar * (num11 * this._sat.no * (this._sat.ao * (1.0 + 1.5 * num8 + num9 * (4.0 + num8)) + 0.000405980925 * x1 / x2 * this._sat.con41 * (8.0 + 3.0 * num8 * (8.0 + num8))));
      double num12 = 0.0;
      if (this._sat.ecco > 0.0001)
        num12 = -2.0 * num10 * x1 * -0.00234507015323442 * this._sat.no * this._sat.sinio / this._sat.ecco;
      this._sat.x1mth2 = 1.0 - this._sat.cosio2;
      this._sat.cc4 = 2.0 * this._sat.no * num11 * this._sat.ao * this._sat.omeosq * (this._sat.eta * (2.0 + 0.5 * num8) + this._sat.ecco * (0.5 + 2.0 * num8) - 0.0010826158 * x1 / (this._sat.ao * x2) * (-3.0 * this._sat.con41 * (1.0 - 2.0 * num9 + num8 * (1.5 - 0.5 * num9)) + 0.75 * this._sat.x1mth2 * (2.0 * num8 - num9 * (1.0 + num8)) * Math.Cos(2.0 * this._sat.argpo)));
      this._sat.cc5 = 2.0 * num11 * this._sat.ao * this._sat.omeosq * (1.0 + 2.75 * (num8 + num9) + num9 * num8);
      double num13 = this._sat.cosio2 * this._sat.cosio2;
      double num14 = 0.0016239237 * num7 * this._sat.no;
      double num15 = 0.5 * num14 * 0.0010826158 * num7;
      double num16 = 7.762359375E-07 * num7 * num7 * this._sat.no;
      this._sat.mdot = this._sat.no + 0.5 * num14 * this._sat.rteosq * this._sat.con41 + 1.0 / 16.0 * num15 * this._sat.rteosq * (13.0 - 78.0 * this._sat.cosio2 + 137.0 * num13);
      this._sat.argpdot = -0.5 * num14 * this._sat.con42 + 1.0 / 16.0 * num15 * (7.0 - 114.0 * this._sat.cosio2 + 395.0 * num13) + num16 * (3.0 - 36.0 * this._sat.cosio2 + 49.0 * num13);
      double num17 = -num14 * this._sat.cosio;
      this._sat.nodedot = num17 + (0.5 * num15 * (4.0 - 19.0 * this._sat.cosio2) + 2.0 * num16 * (3.0 - 7.0 * this._sat.cosio2)) * this._sat.cosio;
      this._sat.xpidot = this._sat.argpdot + this._sat.nodedot;
      this._sat.omgcof = this._sat.bstar * num12 * Math.Cos(this._sat.argpo);
      this._sat.xmcof = 0.0;
      if (this._sat.ecco > 0.0001)
        this._sat.xmcof = -2.0 / 3.0 * num10 * this._sat.bstar / num9;
      this._sat.nodecf = 3.5 * this._sat.omeosq * num17 * this._sat.cc1;
      this._sat.t2cof = 1.5 * this._sat.cc1;
      this._sat.xlcof = Math.Abs(this._sat.cosio + 1.0) <= 1.5E-12 ? 0.000586267538308604 * this._sat.sinio * (3.0 + 5.0 * this._sat.cosio) / 1.5E-12 : 0.000586267538308604 * this._sat.sinio * (3.0 + 5.0 * this._sat.cosio) / (1.0 + this._sat.cosio);
      this._sat.aycof = 0.00117253507661721 * this._sat.sinio;
      this._sat.delmo = Math.Pow(1.0 + this._sat.eta * Math.Cos(this._sat.mo), 3.0);
      this._sat.sinmao = Math.Sin(this._sat.mo);
      this._sat.x7thm1 = 7.0 * this._sat.cosio2 - 1.0;
      if (2.0 * Math.PI / this._sat.no >= 225.0)
      {
        this._method = 'd';
        this._sat.isimp = true;
        double tc = 0.0;
        this._sat.inclm = this._sat.inclo;
        this.Dscom(tc);
        this._sat.mp = this._sat.mo;
        this._sat.argpp = this._sat.argpo;
        this._sat.ep = this._sat.ecco;
        this._sat.omegap = this._sat.omegao;
        this._sat.xincp = this._sat.inclo;
        this.Dpper();
        this._sat.argpm = 0.0;
        this._sat.nodem = 0.0;
        this._sat.mm = 0.0;
        this.Dsinit(tc);
      }
      if (!this._sat.isimp)
      {
        double num18 = this._sat.cc1 * this._sat.cc1;
        this._sat.d2 = 4.0 * this._sat.ao * x1 * num18;
        double num19 = this._sat.d2 * x1 * this._sat.cc1 / 3.0;
        this._sat.d3 = (17.0 * this._sat.ao + num3) * num19;
        this._sat.d4 = 0.5 * num19 * this._sat.ao * x1 * (221.0 * this._sat.ao + 31.0 * num3) * this._sat.cc1;
        this._sat.t3cof = this._sat.d2 + 2.0 * num18;
        this._sat.t4cof = 0.25 * (3.0 * this._sat.d3 + this._sat.cc1 * (12.0 * this._sat.d2 + 10.0 * num18));
        this._sat.t5cof = 0.2 * (3.0 * this._sat.d4 + 12.0 * this._sat.cc1 * this._sat.d3 + 6.0 * this._sat.d2 * this._sat.d2 + 15.0 * num18 * (2.0 * this._sat.d2 + num18));
      }
      this._sat.init = true;
    }

    private void Initl()
    {
      if (this._sat.no < 1E-10)
        throw new PreviSatException();
      this._sat.eccsq = this._sat.ecco * this._sat.ecco;
      this._sat.omeosq = 1.0 - this._sat.eccsq;
      this._sat.rteosq = Math.Sqrt(this._sat.omeosq);
      this._sat.cosio = Math.Cos(this._sat.inclo);
      this._sat.cosio2 = this._sat.cosio * this._sat.cosio;
      double num1 = Math.Pow(Terre.KE / this._sat.no, 2.0 / 3.0);
      double num2 = 0.00081196185 * (3.0 * this._sat.cosio2 - 1.0) / (this._sat.rteosq * this._sat.omeosq);
      double num3 = num2 / (num1 * num1);
      double num4 = num1 * (1.0 - num3 * num3 - num3 * (1.0 / 3.0 + 134.0 * num3 * num3 / 81.0));
      this._sat.no /= 1.0 + num2 / (num4 * num4);
      this._sat.ao = Math.Pow(Terre.KE / this._sat.no, 2.0 / 3.0);
      this._sat.sinio = Math.Sin(this._sat.inclo);
      double num5 = this._sat.ao * this._sat.omeosq;
      this._sat.con42 = 1.0 - 5.0 * this._sat.cosio2;
      this._sat.con41 = -this._sat.con42 - this._sat.cosio2 - this._sat.cosio2;
      this._sat.posq = num5 * num5;
      this._sat.rp = this._sat.ao * (1.0 - this._sat.ecco);
      this._method = 'n';
      this._sat.gsto = Observateur.TempsSideralDeGreenwich(this._sat.epoque);
    }

    private void Dscom(double tc)
    {
      this._sat.nm = this._sat.no;
      this._sat.em = this._sat.ecco;
      this._sat.snodm = Math.Sin(this._sat.omegao);
      this._sat.cnodm = Math.Cos(this._sat.omegao);
      this._sat.sinomm = Math.Sin(this._sat.argpo);
      this._sat.cosomm = Math.Cos(this._sat.argpo);
      this._sat.sinim = Math.Sin(this._sat.inclo);
      this._sat.cosim = Math.Cos(this._sat.inclo);
      this._sat.emsq = this._sat.em * this._sat.em;
      double d = 1.0 - this._sat.emsq;
      this._sat.rtemsq = Math.Sqrt(d);
      this._sat.day = this._sat.epoque.JourJulienUTC + 36525.0 + tc * 0.000694444444444444;
      double num1 = (4.523602 - 0.00092422029 * this._sat.day) % (2.0 * Math.PI);
      double num2 = Math.Sin(num1);
      double num3 = Math.Cos(num1);
      double num4 = 0.91375164 - 0.03568096 * num3;
      double num5 = Math.Sqrt(1.0 - num4 * num4);
      double num6 = 0.089683511 * num2 / num5;
      double num7 = Math.Sqrt(1.0 - num6 * num6);
      this._sat.gam = 5.8351514 + 0.001944368 * this._sat.day;
      double num8 = this._sat.gam + Math.Atan2(0.39785416 * num2 / num5, num7 * num3 + 0.91744867 * num6 * num2) - num1;
      double num9 = Math.Cos(num8);
      double num10 = Math.Sin(num8);
      double num11 = 0.1945905;
      double num12 = -0.98088458;
      double num13 = 0.91744867;
      double num14 = 0.39785416;
      double num15 = this._sat.cnodm;
      double num16 = this._sat.snodm;
      double num17 = 2.9864797E-06;
      double num18 = 1.0 / this._sat.nm;
      int num19 = 1;
      do
      {
        double num20 = num11 * num15 + num12 * num13 * num16;
        double num21 = -num12 * num15 + num11 * num13 * num16;
        double num22 = -num11 * num16 + num12 * num13 * num15;
        double num23 = num12 * num14;
        double num24 = num12 * num16 + num11 * num13 * num15;
        double num25 = num11 * num14;
        double num26 = this._sat.cosim * num22 + this._sat.sinim * num23;
        double num27 = this._sat.cosim * num24 + this._sat.sinim * num25;
        double num28 = -this._sat.sinim * num22 + this._sat.cosim * num23;
        double num29 = -this._sat.sinim * num24 + this._sat.cosim * num25;
        double num30 = num20 * this._sat.cosomm + num26 * this._sat.sinomm;
        double num31 = num21 * this._sat.cosomm + num27 * this._sat.sinomm;
        double num32 = -num20 * this._sat.sinomm + num26 * this._sat.cosomm;
        double num33 = -num21 * this._sat.sinomm + num27 * this._sat.cosomm;
        double num34 = num28 * this._sat.sinomm;
        double num35 = num29 * this._sat.sinomm;
        double num36 = num28 * this._sat.cosomm;
        double num37 = num29 * this._sat.cosomm;
        this._sat.z31 = 12.0 * num30 * num30 - 3.0 * num32 * num32;
        this._sat.z32 = 24.0 * num30 * num31 - 6.0 * num32 * num33;
        this._sat.z33 = 12.0 * num31 * num31 - 3.0 * num33 * num33;
        this._sat.z1 = 3.0 * (num20 * num20 + num26 * num26) + this._sat.z31 * this._sat.emsq;
        this._sat.z2 = 6.0 * (num20 * num21 + num26 * num27) + this._sat.z32 * this._sat.emsq;
        this._sat.z3 = 3.0 * (num21 * num21 + num27 * num27) + this._sat.z33 * this._sat.emsq;
        this._sat.z11 = -6.0 * num20 * num28 + this._sat.emsq * (-24.0 * num30 * num36 - 6.0 * num32 * num34);
        this._sat.z12 = -6.0 * (num20 * num29 + num21 * num28) + this._sat.emsq * (-24.0 * (num31 * num36 + num30 * num37) - 6.0 * (num32 * num35 + num33 * num34));
        this._sat.z13 = -6.0 * num21 * num29 + this._sat.emsq * (-24.0 * num31 * num37 - 6.0 * num33 * num35);
        this._sat.z21 = 6.0 * num26 * num28 + this._sat.emsq * (24.0 * num30 * num34 - 6.0 * num32 * num36);
        this._sat.z22 = 6.0 * (num27 * num28 + num26 * num29) + this._sat.emsq * (24.0 * (num31 * num34 + num30 * num35) - 6.0 * (num33 * num36 + num32 * num37));
        this._sat.z23 = 6.0 * num27 * num29 + this._sat.emsq * (24.0 * num31 * num35 - 6.0 * num33 * num37);
        this._sat.z1 = this._sat.z1 + this._sat.z1 + d * this._sat.z31;
        this._sat.z2 = this._sat.z2 + this._sat.z2 + d * this._sat.z32;
        this._sat.z3 = this._sat.z3 + this._sat.z3 + d * this._sat.z33;
        this._sat.s3 = num17 * num18;
        this._sat.s2 = -0.5 * this._sat.s3 / this._sat.rtemsq;
        this._sat.s4 = this._sat.s3 * this._sat.rtemsq;
        this._sat.s1 = -15.0 * this._sat.em * this._sat.s4;
        this._sat.s5 = num30 * num32 + num31 * num33;
        this._sat.s6 = num31 * num32 + num30 * num33;
        this._sat.s7 = num31 * num33 - num30 * num32;
        if (num19 == 1)
        {
          this._sat.ss1 = this._sat.s1;
          this._sat.ss2 = this._sat.s2;
          this._sat.ss3 = this._sat.s3;
          this._sat.ss4 = this._sat.s4;
          this._sat.ss5 = this._sat.s5;
          this._sat.ss6 = this._sat.s6;
          this._sat.ss7 = this._sat.s7;
          this._sat.sz1 = this._sat.z1;
          this._sat.sz2 = this._sat.z2;
          this._sat.sz3 = this._sat.z3;
          this._sat.sz11 = this._sat.z11;
          this._sat.sz12 = this._sat.z12;
          this._sat.sz13 = this._sat.z13;
          this._sat.sz21 = this._sat.z21;
          this._sat.sz22 = this._sat.z22;
          this._sat.sz23 = this._sat.z23;
          this._sat.sz31 = this._sat.z31;
          this._sat.sz32 = this._sat.z32;
          this._sat.sz33 = this._sat.z33;
          num11 = num9;
          num12 = num10;
          num13 = num4;
          num14 = num5;
          num15 = num7 * this._sat.cnodm + num6 * this._sat.snodm;
          num16 = this._sat.snodm * num7 - this._sat.cnodm * num6;
          num17 = 4.7968065E-07;
        }
        checked { ++num19; }
      }
      while (num19 <= 2);
      this._sat.zmol = (4.7199672 + 0.2299715 * this._sat.day - this._sat.gam) % (2.0 * Math.PI);
      this._sat.zmos = (6.2565837 + 0.017201977 * this._sat.day) % (2.0 * Math.PI);
      this._sat.se2 = 2.0 * this._sat.ss1 * this._sat.ss6;
      this._sat.se3 = 2.0 * this._sat.ss1 * this._sat.ss7;
      this._sat.si2 = 2.0 * this._sat.ss2 * this._sat.sz12;
      this._sat.si3 = 2.0 * this._sat.ss2 * (this._sat.sz13 - this._sat.sz11);
      this._sat.sl2 = -2.0 * this._sat.ss3 * this._sat.sz2;
      this._sat.sl3 = -2.0 * this._sat.ss3 * (this._sat.sz3 - this._sat.sz1);
      this._sat.sl4 = -2.0 * this._sat.ss3 * (-21.0 - 9.0 * this._sat.emsq) * 0.01675;
      this._sat.sgh2 = 2.0 * this._sat.ss4 * this._sat.sz32;
      this._sat.sgh3 = 2.0 * this._sat.ss4 * (this._sat.sz33 - this._sat.sz31);
      this._sat.sgh4 = -18.0 * this._sat.ss4 * 0.01675;
      this._sat.sh2 = -2.0 * this._sat.ss2 * this._sat.sz22;
      this._sat.sh3 = -2.0 * this._sat.ss2 * (this._sat.sz23 - this._sat.sz21);
      this._sat.ee2 = 2.0 * this._sat.s1 * this._sat.s6;
      this._sat.e3 = 2.0 * this._sat.s1 * this._sat.s7;
      this._sat.xi2 = 2.0 * this._sat.s2 * this._sat.z12;
      this._sat.xi3 = 2.0 * this._sat.s2 * (this._sat.z13 - this._sat.z11);
      this._sat.xl2 = -2.0 * this._sat.s3 * this._sat.z2;
      this._sat.xl3 = -2.0 * this._sat.s3 * (this._sat.z3 - this._sat.z1);
      this._sat.xl4 = -2.0 * this._sat.s3 * (-21.0 - 9.0 * this._sat.emsq) * 0.0549;
      this._sat.xgh2 = 2.0 * this._sat.s4 * this._sat.z32;
      this._sat.xgh3 = 2.0 * this._sat.s4 * (this._sat.z33 - this._sat.z31);
      this._sat.xgh4 = -18.0 * this._sat.s4 * 0.0549;
      this._sat.xh2 = -2.0 * this._sat.s2 * this._sat.z22;
      this._sat.xh3 = -2.0 * this._sat.s2 * (this._sat.z23 - this._sat.z21);
    }

    private void Dpper()
    {
      double a1 = this._sat.zmos + 1.19459E-05 * this._sat.t;
      if (!this._sat.init)
        a1 = this._sat.zmos;
      double num1 = a1 + 0.0335 * Math.Sin(a1);
      double num2 = Math.Sin(num1);
      double num3 = 0.5 * num2 * num2 - 0.25;
      double num4 = -0.5 * num2 * Math.Cos(num1);
      double num5 = this._sat.se2 * num3 + this._sat.se3 * num4;
      double num6 = this._sat.si2 * num3 + this._sat.si3 * num4;
      double num7 = this._sat.sl2 * num3 + this._sat.sl3 * num4 + this._sat.sl4 * num2;
      double num8 = this._sat.sgh2 * num3 + this._sat.sgh3 * num4 + this._sat.sgh4 * num2;
      double num9 = this._sat.sh2 * num3 + this._sat.sh3 * num4;
      double a2 = this._sat.zmol + 0.00015835218 * this._sat.t;
      if (!this._sat.init)
        a2 = this._sat.zmol;
      double num10 = a2 + 0.1098 * Math.Sin(a2);
      double num11 = Math.Sin(num10);
      double num12 = 0.5 * num11 * num11 - 0.25;
      double num13 = -0.5 * num11 * Math.Cos(num10);
      double num14 = this._sat.ee2 * num12 + this._sat.e3 * num13;
      double num15 = this._sat.xi2 * num12 + this._sat.xi3 * num13;
      double num16 = this._sat.xl2 * num12 + this._sat.xl3 * num13 + this._sat.xl4 * num11;
      double num17 = this._sat.xgh2 * num12 + this._sat.xgh3 * num13 + this._sat.xgh4 * num11;
      double num18 = this._sat.xh2 * num12 + this._sat.xh3 * num13;
      double num19 = num5 + num14;
      double num20 = num6 + num15;
      double num21 = num7 + num16;
      double num22 = num8 + num17;
      double num23 = num9 + num18;
      if (!this._sat.init)
        return;
      this._sat.xincp += num20;
      this._sat.ep += num19;
      double num24 = Math.Sin(this._sat.xincp);
      double num25 = Math.Cos(this._sat.xincp);
      if (this._sat.xincp >= 0.2)
      {
        double num26 = num23 / num24;
        this._sat.argpp += num22 - num25 * num26;
        this._sat.omegap += num26;
        this._sat.mp += num21;
      }
      else
      {
        double num27 = Math.Sin(this._sat.omegap);
        double num28 = Math.Cos(this._sat.omegap);
        double num29 = num24 * num27;
        double num30 = num24 * num28;
        double num31 = num23 * num28 + num20 * num25 * num27;
        double num32 = -num23 * num27 + num20 * num25 * num28;
        double y = num29 + num31;
        double x = num30 + num32;
        this._sat.omegap %= 2.0 * Math.PI;
        if (this._sat.omegap < 0.0)
          this._sat.omegap += 2.0 * Math.PI;
        double num33 = this._sat.mp + this._sat.argpp + num25 * this._sat.omegap + (num21 + num22 - num20 * this._sat.omegap * num24);
        double omegap = this._sat.omegap;
        this._sat.omegap = Math.Atan2(y, x);
        if (this._sat.omegap < 0.0)
          this._sat.omegap += 2.0 * Math.PI;
        if (Math.Abs(omegap - this._sat.omegap) > Math.PI)
          this._sat.omegap = Conversions.ToDouble(Interaction.IIf(this._sat.omegap < omegap, (object) (this._sat.omegap + 2.0 * Math.PI), (object) (this._sat.omegap - 2.0 * Math.PI)));
        this._sat.mp += num21;
        this._sat.argpp = num33 - this._sat.mp - num25 * this._sat.omegap;
      }
    }

    private void Dsinit(double tc)
    {
      this._sat.irez = 0;
      if (this._sat.nm < Math.PI / 600.0 && this._sat.nm > Math.PI / 900.0)
        this._sat.irez = 1;
      if (this._sat.nm >= 0.00826 && this._sat.nm <= 0.00924 && this._sat.em >= 0.5)
        this._sat.irez = 2;
      double num1 = this._sat.ss1 * 1.19459E-05 * this._sat.ss5;
      double num2 = this._sat.ss2 * 1.19459E-05 * (this._sat.sz11 + this._sat.sz13);
      double num3 = -1.19459E-05 * this._sat.ss3 * (this._sat.sz1 + this._sat.sz3 - 14.0 - 6.0 * this._sat.emsq);
      double num4 = this._sat.ss4 * 1.19459E-05 * (this._sat.sz31 + this._sat.sz33 - 6.0);
      double num5 = -1.19459E-05 * this._sat.ss2 * (this._sat.sz21 + this._sat.sz23);
      if (this._sat.inclm < 0.052359877 || this._sat.inclm > 3.08923277658979)
        num5 = 0.0;
      if (this._sat.sinim != 0.0)
        num5 /= this._sat.sinim;
      double num6 = num4 - this._sat.cosim * num5;
      this._sat.dedt = num1 + this._sat.s1 * 0.00015835218 * this._sat.s5;
      this._sat.didt = num2 + this._sat.s2 * 0.00015835218 * (this._sat.z11 + this._sat.z13);
      this._sat.dmdt = num3 - 0.00015835218 * this._sat.s3 * (this._sat.z1 + this._sat.z3 - 14.0 - 6.0 * this._sat.emsq);
      double num7 = this._sat.s4 * 0.00015835218 * (this._sat.z31 + this._sat.z33 - 6.0);
      double num8 = -0.00015835218 * this._sat.s2 * (this._sat.z21 + this._sat.z23);
      if (this._sat.inclm < 0.052359877 || this._sat.inclm > 3.08923277658979)
        num8 = 0.0;
      this._sat.domdt = num6 + num7;
      this._sat.dnodt = num5;
      if (this._sat.sinim != 0.0)
      {
        this._sat.domdt -= this._sat.cosim / this._sat.sinim * num8;
        this._sat.dnodt += num8 / this._sat.sinim;
      }
      this._sat.dndt = 0.0;
      double num9 = (this._sat.gsto + tc * 0.00437526951318395) % (2.0 * Math.PI);
      this._sat.em += this._sat.dedt * this._sat.t;
      this._sat.inclm += this._sat.didt * this._sat.t;
      this._sat.argpm += this._sat.domdt * this._sat.t;
      this._sat.nodem += this._sat.dnodt * this._sat.t;
      this._sat.mm += this._sat.dmdt * this._sat.t;
      if (this._sat.irez == 0)
        return;
      double num10 = Math.Pow(this._sat.nm / Terre.KE, 2.0 / 3.0);
      if (this._sat.irez == 2)
      {
        double num11 = this._sat.cosim * this._sat.cosim;
        double em = this._sat.em;
        this._sat.em = this._sat.ecco;
        double emsq = this._sat.emsq;
        this._sat.emsq = this._sat.eccsq;
        double num12 = this._sat.em * this._sat.emsq;
        this._sat.g201 = -0.306 - (this._sat.em - 0.64) * 0.44;
        if (this._sat.em <= 0.65)
        {
          this._sat.g211 = 3.616 - 13.247 * this._sat.em + 16.29 * this._sat.emsq;
          this._sat.g310 = 117.39 * this._sat.em - 19.302 - 228.419 * this._sat.emsq + 156.591 * num12;
          this._sat.g322 = 109.7927 * this._sat.em - 18.9068 - 214.6334 * this._sat.emsq + 146.5816 * num12;
          this._sat.g410 = 242.694 * this._sat.em - 41.122 - 471.094 * this._sat.emsq + 313.953 * num12;
          this._sat.g422 = 841.88 * this._sat.em - 146.407 - 1629.014 * this._sat.emsq + 1083.435 * num12;
          this._sat.g520 = 3017.977 * this._sat.em - 532.114 - 5740.032 * this._sat.emsq + 3708.276 * num12;
        }
        else
        {
          this._sat.g211 = 331.819 * this._sat.em - 72.099 - 508.738 * this._sat.emsq + 266.724 * num12;
          this._sat.g310 = 1582.851 * this._sat.em - 346.844 - 2415.925 * this._sat.emsq + 1246.113 * num12;
          this._sat.g322 = 1554.908 * this._sat.em - 342.585 - 2366.899 * this._sat.emsq + 1215.972 * num12;
          this._sat.g410 = 4758.686 * this._sat.em - 1052.797 - 7193.992 * this._sat.emsq + 3651.957 * num12;
          this._sat.g422 = 16178.11 * this._sat.em - 3581.69 - 24462.77 * this._sat.emsq + 12422.52 * num12;
          this._sat.g520 = this._sat.em <= 0.715 ? 1464.74 - 4664.75 * this._sat.em + 3763.64 * this._sat.emsq : 29936.92 * this._sat.em - 5149.66 - 54087.36 * this._sat.emsq + 31324.56 * num12;
        }
        if (this._sat.em < 0.7)
        {
          this._sat.g533 = 4988.61 * this._sat.em - 919.2277 - 9064.77 * this._sat.emsq + 5542.21 * num12;
          this._sat.g521 = 4568.6173 * this._sat.em - 822.71072 - 8491.4146 * this._sat.emsq + 5337.524 * num12;
          this._sat.g532 = 4690.25 * this._sat.em - 853.666 - 8624.77 * this._sat.emsq + 5341.4 * num12;
        }
        else
        {
          this._sat.g533 = 161616.52 * this._sat.em - 37995.78 - 229838.2 * this._sat.emsq + 109377.94 * num12;
          this._sat.g521 = 218913.95 * this._sat.em - 51752.104 - 309468.16 * this._sat.emsq + 146349.42 * num12;
          this._sat.g532 = 170470.89 * this._sat.em - 40023.88 - 242699.48 * this._sat.emsq + 115605.82 * num12;
        }
        double num13 = this._sat.sinim * this._sat.sinim;
        this._sat.f220 = 0.75 * (1.0 + 2.0 * this._sat.cosim + num11);
        this._sat.f221 = 1.5 * num13;
        this._sat.f321 = 1.875 * this._sat.sinim * (1.0 - 2.0 * this._sat.cosim - 3.0 * num11);
        this._sat.f322 = -1.875 * this._sat.sinim * (1.0 + 2.0 * this._sat.cosim - 3.0 * num11);
        this._sat.f441 = 35.0 * num13 * this._sat.f220;
        this._sat.f442 = 39.375 * num13 * num13;
        this._sat.f522 = 315.0 / 32.0 * this._sat.sinim * (num13 * (1.0 - 2.0 * this._sat.cosim - 5.0 * num11) + 0.33333333 * (4.0 * this._sat.cosim - 2.0 + 6.0 * num11));
        this._sat.f523 = this._sat.sinim * (4.92187512 * num13 * (-2.0 - 4.0 * this._sat.cosim + 10.0 * num11) + 6.56250012 * (1.0 + 2.0 * this._sat.cosim - 3.0 * num11));
        this._sat.f542 = 945.0 / 32.0 * this._sat.sinim * (2.0 - 8.0 * this._sat.cosim + num11 * (8.0 * this._sat.cosim - 12.0 + 10.0 * num11));
        this._sat.f543 = 945.0 / 32.0 * this._sat.sinim * (-2.0 - 8.0 * this._sat.cosim + num11 * (12.0 + 8.0 * this._sat.cosim - 10.0 * num11));
        double num14 = 3.0 * (this._sat.nm * this._sat.nm) * (num10 * num10);
        double num15 = num14 * 1.7891679E-06;
        this._sat.d2201 = num15 * this._sat.f220 * this._sat.g201;
        this._sat.d2211 = num15 * this._sat.f221 * this._sat.g211;
        double num16 = num14 * num10;
        double num17 = num16 * 3.7393792E-07;
        this._sat.d3210 = num17 * this._sat.f321 * this._sat.g310;
        this._sat.d3222 = num17 * this._sat.f322 * this._sat.g322;
        double num18 = num16 * num10;
        double num19 = 2.0 * num18 * 7.3636953E-09;
        this._sat.d4410 = num19 * this._sat.f441 * this._sat.g410;
        this._sat.d4422 = num19 * this._sat.f442 * this._sat.g422;
        double num20 = num18 * num10;
        double num21 = num20 * 1.1428639E-07;
        this._sat.d5220 = num21 * this._sat.f522 * this._sat.g520;
        this._sat.d5232 = num21 * this._sat.f523 * this._sat.g532;
        double num22 = 2.0 * num20 * 2.1765803E-09;
        this._sat.d5421 = num22 * this._sat.f542 * this._sat.g521;
        this._sat.d5433 = num22 * this._sat.f543 * this._sat.g533;
        this._sat.xlamo = (this._sat.mo + this._sat.omegao + this._sat.omegao - num9 - num9) % (2.0 * Math.PI);
        this._sat.xfact = this._sat.mdot + this._sat.dmdt + 2.0 * (this._sat.nodedot + this._sat.dnodt - 0.00437526951318395) - this._sat.no;
        this._sat.em = em;
        this._sat.emsq = emsq;
      }
      if (this._sat.irez == 1)
      {
        this._sat.g200 = 1.0 + this._sat.emsq * (13.0 / 16.0 * this._sat.emsq - 2.5);
        this._sat.g310 = 1.0 + 2.0 * this._sat.emsq;
        this._sat.g300 = 1.0 + this._sat.emsq * (6.60937 * this._sat.emsq - 6.0);
        this._sat.f220 = 0.75 * (1.0 + this._sat.cosim) * (1.0 + this._sat.cosim);
        this._sat.f311 = 15.0 / 16.0 * this._sat.sinim * this._sat.sinim * (1.0 + 3.0 * this._sat.cosim) - 0.75 * (1.0 + this._sat.cosim);
        this._sat.f330 = 1.0 + this._sat.cosim;
        this._sat.f330 = 1.875 * this._sat.f330 * this._sat.f330 * this._sat.f330;
        this._sat.del1 = 3.0 * this._sat.nm * this._sat.nm * num10 * num10;
        this._sat.del2 = 2.0 * this._sat.del1 * this._sat.f220 * this._sat.g200 * 1.7891679E-06;
        this._sat.del3 = 3.0 * this._sat.del1 * this._sat.f330 * this._sat.g300 * 2.2123015E-07 * num10;
        this._sat.del1 *= this._sat.f311 * this._sat.g310 * 2.1460748E-06 * num10;
        this._sat.xlamo = (this._sat.mo + this._sat.omegao + this._sat.argpo - num9) % (2.0 * Math.PI);
        this._sat.xfact = this._sat.mdot + this._sat.xpidot - 0.00437526951318395 + this._sat.dmdt + this._sat.domdt + this._sat.dnodt - this._sat.no;
      }
      this._sat.xli = this._sat.xlamo;
      this._sat.xni = this._sat.no;
      this._sat.atime = 0.0;
      this._sat.nm = this._sat.no + this._sat.dndt;
    }

    private void Dspace(double tc)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      this._sat.dndt = 0.0;
      double num4 = (this._sat.gsto + tc * 0.00437526951318395) % (2.0 * Math.PI);
      this._sat.em += this._sat.dedt * this._sat.t;
      this._sat.inclm += this._sat.didt * this._sat.t;
      this._sat.argpm += this._sat.domdt * this._sat.t;
      this._sat.nodem += this._sat.dnodt * this._sat.t;
      this._sat.mm += this._sat.dmdt * this._sat.t;
      double num5 = 0.0;
      if (this._sat.irez == 0)
        return;
      if (this._sat.atime == 0.0 || this._sat.t * this._sat.atime <= 0.0 || Math.Abs(this._sat.t) < Math.Abs(this._sat.atime))
      {
        this._sat.atime = 0.0;
        this._sat.xni = this._sat.no;
        this._sat.xli = this._sat.xlamo;
      }
      this._sat.delt = Conversions.ToDouble(Interaction.IIf(this._sat.t > 0.0, (object) 720.0, (object) -720.0));
      int num6 = 381;
      while (num6 == 381)
      {
        if (this._sat.irez != 2)
        {
          num3 = this._sat.del1 * Math.Sin(this._sat.xli - 0.13130908) + this._sat.del2 * Math.Sin(2.0 * (this._sat.xli - 2.8843198)) + this._sat.del3 * Math.Sin(3.0 * (this._sat.xli - 0.37448087));
          num1 = this._sat.xni + this._sat.xfact;
          num2 = (this._sat.del1 * Math.Cos(this._sat.xli - 0.13130908) + 2.0 * this._sat.del2 * Math.Cos(2.0 * (this._sat.xli - 2.8843198)) + 3.0 * this._sat.del3 * Math.Cos(3.0 * (this._sat.xli - 0.37448087))) * num1;
        }
        else
        {
          double num7 = this._sat.argpo + this._sat.argpdot * this._sat.atime;
          double num8 = num7 + num7;
          double num9 = this._sat.xli + this._sat.xli;
          num3 = this._sat.d2201 * Math.Sin(num8 + this._sat.xli - 5.7686396) + this._sat.d2211 * Math.Sin(this._sat.xli - 5.7686396) + this._sat.d3210 * Math.Sin(num7 + this._sat.xli - 0.95240898) + this._sat.d3222 * Math.Sin(-num7 + this._sat.xli - 0.95240898) + this._sat.d4410 * Math.Sin(num8 + num9 - 1.8014998) + this._sat.d4422 * Math.Sin(num9 - 1.8014998) + this._sat.d5220 * Math.Sin(num7 + this._sat.xli - 1.050833) + this._sat.d5232 * Math.Sin(-num7 + this._sat.xli - 1.050833) + this._sat.d5421 * Math.Sin(num7 + num9 - 4.4108898) + this._sat.d5433 * Math.Sin(-num7 + num9 - 4.4108898);
          num1 = this._sat.xni + this._sat.xfact;
          num2 = (this._sat.d2201 * Math.Cos(num8 + this._sat.xli - 5.7686396) + this._sat.d2211 * Math.Cos(this._sat.xli - 5.7686396) + this._sat.d3210 * Math.Cos(num7 + this._sat.xli - 0.95240898) + this._sat.d3222 * Math.Cos(-num7 + this._sat.xli - 0.95240898) + this._sat.d5220 * Math.Cos(num7 + this._sat.xli - 1.050833) + this._sat.d5232 * Math.Cos(-num7 + this._sat.xli - 1.050833) + 2.0 * (this._sat.d4410 * Math.Cos(num8 + num9 - 1.8014998) + this._sat.d4422 * Math.Cos(num9 - 1.8014998) + this._sat.d5421 * Math.Cos(num7 + num9 - 4.4108898) + this._sat.d5433 * Math.Cos(-num7 + num9 - 4.4108898))) * num1;
        }
        if (Math.Abs(this._sat.t - this._sat.atime) >= 720.0)
        {
          num6 = 381;
        }
        else
        {
          num5 = this._sat.t - this._sat.atime;
          num6 = 0;
        }
        if (num6 == 381)
        {
          this._sat.xli += num1 * this._sat.delt + num3 * 259200.0;
          this._sat.xni += num3 * this._sat.delt + num2 * 259200.0;
          this._sat.atime += this._sat.delt;
        }
      }
      this._sat.nm = this._sat.xni + num3 * num5 + num2 * num5 * num5 * 0.5;
      double num10 = this._sat.xli + num1 * num5 + num3 * num5 * num5 * 0.5;
      if (this._sat.irez != 1)
      {
        this._sat.mm = num10 - 2.0 * this._sat.nodem + 2.0 * num4;
        this._sat.dndt = this._sat.nm - this._sat.no;
      }
      else
      {
        this._sat.mm = num10 - this._sat.nodem - this._sat.argpm + num4;
        this._sat.dndt = this._sat.nm - this._sat.no;
      }
      this._sat.nm = this._sat.no + this._sat.dndt;
    }

    /// <summary>Calcul de la trajectoire du satellite</summary>
    /// <param name="dat">Date</param>
    /// <param name="tle">TLE du satellite</param>
    /// <param name="nbTrajectoires">Nombre de trajectoires</param>
    /// <remarks></remarks>
    public void CalculTrajectoire(double dat, TLE tle, int nbTrajectoires)
    {
      Satellite satellite = new Satellite(tle);
      Soleil sun = new Soleil();
      double num1 = 1.0 / (tle.No * 360.0);
      this._trajectoire = new double[checked (360 * nbTrajectoires + 1), 3];
      int num2 = checked (360 * nbTrajectoires - 1);
      int index = 0;
      while (index <= num2)
      {
        Dates dat1 = new Dates(dat + (double) index * num1, 0.0, false);
        satellite.CalculPosVit(dat1, tle.Epoque.JourJulienUTC);
        double num3 = 180.0 / Math.PI * ((Math.PI + Math.Atan2(satellite._position.Y, satellite._position.X) - Observateur.TempsSideralDeGreenwich(dat1)) % (2.0 * Math.PI));
        if (num3 < 0.0)
          num3 += 360.0;
        double num4 = Math.Sqrt(satellite._position.X * satellite._position.X + satellite._position.Y * satellite._position.Y);
        double num5 = Math.Atan(satellite._position.Z / num4);
        double num6;
        double num7;
        for (double a = 7.0; Math.Abs(num5 - a) > 1E-07; num5 = Math.Atan((satellite._position.Z + 6378.136658 * num7 * 0.00669431777826672 * num6) / num4))
        {
          a = num5;
          num6 = Math.Sin(a);
          num7 = 1.0 / Math.Sqrt(1.0 - 0.00669431777826672 * num6 * num6);
        }
        double num8 = 180.0 / Math.PI * (Math.PI / 2.0 - num5);
        sun.CalculPosition(dat1);
        satellite.CalculEclipse(sun);
        this._trajectoire[index, 0] = num3;
        this._trajectoire[index, 1] = num8;
        this._trajectoire[index, 2] = Conversions.ToDouble(Interaction.IIf(satellite._eclipse, (object) 1, (object) 0));
        checked { ++index; }
      }
    }

    public bool Eclipse => this._eclipse;

    public ElementsOsculateurs Elements => this._elements;

    public double Elongation => this._elongation;

    public double FractionIlluminee => this._fractionIlluminee;

    public bool Ieralt => this._ieralt;

    public double Magnitude => this._magnitude;

    public double MagnitudeStandard => this._magnitudeStandard;

    public char MethMagnitude => this._methMagnitude;

    public char Method => this._method;

    public int NbOrbites => this._nbOrbites;

    public bool Penombre => this._penombre;

    public double RayonApparentTerre => this._rayonApparentTerre;

    public double RayonApparentSoleil => this._rayonApparentSoleil;

    public double Section => this._section;

    public double T1 => this._t1;

    public double T2 => this._t2;

    public double T3 => this._t3;

    public double[,] Trajectoire => this._trajectoire;

    ~Satellite() => base.Finalize();
  }
}
