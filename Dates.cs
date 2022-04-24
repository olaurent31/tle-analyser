// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Dates
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;

namespace TLE_Analyser
{
  public class Dates
  {
    public const int AN2000 = 2000;
    public const double NB_MIN_PAR_HEUR = 60.0;
    public const double NB_HEUR_PAR_JOUR = 24.0;
    public const double NB_MIN_PAR_JOUR = 1440.0;
    public const double NB_SEC_PAR_MIN = 60.0;
    public const double NB_SEC_PAR_HEUR = 3600.0;
    public const double NB_SEC_PAR_JOUR = 86400.0;
    public const double NB_JOURS_PAR_ANJ = 365.25;
    public const double NB_JOURS_PAR_SIECJ = 36525.0;
    public const double DATE_INFINIE = 9999999.0;
    public const double TJ2000 = 2451545.0;
    public const double EPS_DATES = 1E-07;
    public const double NB_JOUR_PAR_HEUR = 0.0416666666666667;
    public const double NB_JOUR_PAR_MIN = 0.000694444444444444;
    public const double NB_JOUR_PAR_SEC = 1.15740740740741E-05;
    public const double NB_HEUR_PAR_MIN = 0.0166666666666667;
    public const double NB_HEUR_PAR_SEC = 0.000277777777777778;
    public const double NB_MIN_PAR_SEC = 0.0166666666666667;
    public const double NB_ANJ_PAR_JOURS = 0.0027378507871321;
    public const double NB_SIECJ_PAR_JOURS = 2.7378507871321E-05;
    private int _annee;
    private int _mois;
    private int _jour;
    private int _heure;
    private int _minutes;
    private double _secondes;
    private double _jourJulien;
    private double _jourJulienUTC;
    private double _offsetUTC;

    /// <summary>Constructeur par defaut (obtention de la date systeme)</summary>
    /// <param name="offsetUTC">Ecart heure legale - UTC</param>
    /// <remarks></remarks>
    public Dates(double offsetUTC)
    {
      DateTime now = DateAndTime.Now;
      this._annee = now.Year;
      this._mois = now.Month;
      this._jour = now.Day;
      this._heure = now.Hour;
      this._minutes = now.Minute;
      this._secondes = (double) now.Second;
      this._offsetUTC = offsetUTC;
      this.CalculJourJulien();
    }

    /// <summary>Constructeur a partir d'une date</summary>
    /// <param name="dat">Date</param>
    /// <param name="offset">Ecart heure legale - UTC</param>
    /// <remarks></remarks>
    public Dates(Dates dat, double offset = 0.0)
    {
      this._annee = dat._annee;
      this._mois = dat._mois;
      this._jour = dat._jour;
      this._heure = dat._heure;
      this._minutes = dat._minutes;
      this._secondes = dat._secondes;
      this._offsetUTC = offset;
      this._jourJulien = dat._jourJulien;
      this._jourJulienUTC = this._jourJulien - offset;
    }

    /// <summary>Constructeur a partir d'un jour julien 2000</summary>
    /// <param name="jourJulien">Jour julien 2000</param>
    /// <param name="offsetUTC">Ecart heure legale - UTC</param>
    /// <param name="acalc">Calcul de la date calendaire</param>
    /// <remarks></remarks>
    public Dates(double jourJulien, double offsetUTC, bool acalc = true)
    {
      if (acalc)
      {
        double d1 = jourJulien + 0.5;
        int num1 = checked ((int) Math.Round(Math.Floor(d1)));
        double num2 = d1 - (double) num1;
        int num3 = checked (num1 + 2451545);
        int num4;
        if (num3 < 2299161)
        {
          num4 = num3;
        }
        else
        {
          int num5 = checked ((int) Math.Round(Math.Floor(unchecked ((double) num3 - 1867216.25 / 36524.25))));
          num4 = checked (num3 + 1 + num5 - unchecked (num5 / 4));
        }
        int num6 = checked (num4 + 1524);
        int num7 = checked ((int) Math.Round(Math.Floor(unchecked ((double) num6 - 122.1 * 0.0027378507871321))));
        int num8 = checked ((int) Math.Round(Math.Floor(unchecked (365.25 * (double) num7))));
        int num9 = checked ((int) Math.Round(Math.Floor(unchecked ((double) checked (num6 - num8) / 30.6001))));
        double d2 = (double) checked (num6 - num8) - Math.Floor(30.6001 * (double) num9) + num2;
        this._mois = Conversions.ToInteger(Interaction.IIf(num9 < 14, (object) checked (num9 - 1), (object) checked (num9 - 13)));
        this._annee = Conversions.ToInteger(Interaction.IIf(this._mois > 2, (object) checked (num7 - 4716), (object) checked (num7 - 4715)));
        this._jour = checked ((int) Math.Round(Math.Floor(d2)));
        this._heure = checked ((int) Math.Round(Math.Floor(unchecked (24.0 * d2 - (double) this._jour))));
        this._minutes = checked ((int) Math.Round(Math.Floor(unchecked (1440.0 * (d2 - (double) this._jour) - 60.0 * (double) this._heure))));
        this._secondes = 86400.0 * (d2 - (double) this._jour) - 3600.0 * (double) this._heure - 60.0 * (double) this._minutes;
      }
      this._offsetUTC = offsetUTC;
      this._jourJulien = jourJulien;
      this._jourJulienUTC = this._jourJulien - this._offsetUTC;
    }

    /// <summary>
    /// Constructeur a partir d'une date calendaire, ou le jour est exprime sous forme decimale
    /// </summary>
    /// <param name="annee">Annee (1957-2056)</param>
    /// <param name="mois">Mois</param>
    /// <param name="xj">Jour (decimal)</param>
    /// <param name="offsetUTC">Ecart heure legale - UTC</param>
    /// <remarks></remarks>
    public Dates(int annee, int mois, double xj, double offsetUTC)
    {
      this._annee = annee;
      this._mois = mois;
      this._jour = checked ((int) Math.Round(Math.Floor(xj)));
      this._heure = checked ((int) Math.Round(Math.Floor(unchecked (24.0 * xj - (double) this._jour))));
      this._minutes = checked ((int) Math.Round(Math.Floor(unchecked (1440.0 * (xj - (double) this._jour) - 60.0 * (double) this._heure))));
      this._secondes = 86400.0 * (xj - (double) this._jour) - 3600.0 * (double) this._heure - 60.0 * (double) this._minutes;
      this._offsetUTC = offsetUTC;
      this.CalculJourJulien();
    }

    /// <summary>Constructeur a partir d'une date calendaire</summary>
    /// <param name="annee">Annee (1957-2056)</param>
    /// <param name="mois">Mois</param>
    /// <param name="jour">Jour</param>
    /// <param name="heure">Heure</param>
    /// <param name="minutes">Minutes</param>
    /// <param name="secondes">Secondes</param>
    /// <param name="offsetUTC">Ecart heure legale - UTC</param>
    /// <remarks></remarks>
    public Dates(
      int annee,
      int mois,
      int jour,
      int heure,
      int minutes,
      double secondes,
      double offsetUTC)
    {
      this._annee = annee;
      this._mois = mois;
      this._jour = jour;
      this._heure = heure;
      this._minutes = minutes;
      this._secondes = secondes;
      this._offsetUTC = offsetUTC;
      this.CalculJourJulien();
    }

    /// <summary>Conversion d'une date de type Dates au type DateTime</summary>
    /// <param name="type"></param>
    /// <returns>Date au format DateTime</returns>
    /// <remarks></remarks>
    public DateTime ToDate(int type)
    {
      Dates dates = new Dates(this._annee, this._mois, this._jour, this._heure, this._minutes, (double) Conversions.ToInteger(Interaction.IIf(type == 0, (object) 0.0, (object) Math.Round(this._secondes))), this._offsetUTC);
      return new DateTime(dates._annee, dates._mois, dates._jour, dates._heure, dates._minutes, checked ((int) Math.Round(dates._secondes)));
    }

    /// <summary>Conversion de la date en date locale</summary>
    /// <returns>Date locale</returns>
    /// <remarks></remarks>
    public Dates ToLocalDate() => new Dates(this._jourJulienUTC + this._offsetUTC);

    /// <summary>Conversion de la date en date locale</summary>
    /// <param name="offsetUTC">Ecart date locale - UTC</param>
    /// <returns>Date locale</returns>
    /// <remarks></remarks>
    public Dates ToLocalDate(double offsetUTC) => new Dates(this._jourJulienUTC + offsetUTC);

    /// <summary>Obtention de la date sous forme de chaine de caracteres (type ISO)</summary>
    /// <param name="type">Nombre de decimales pour les secondes (0 ou 1)</param>
    /// <returns>Date sous forme de chaine de caracteres</returns>
    /// <remarks></remarks>
    public string ToShortDate(int type)
    {
      NumberFormatInfo numberFormat = new CultureInfo("en-US", false).NumberFormat;
      string format = Interaction.IIf(type == 0, (object) "00", (object) "00.0").ToString();
      Math.Floor(this._jourJulien);
      Dates dates1;
      Dates dates2 = dates1;
      return string.Format((IFormatProvider) numberFormat, "{0:d4}/{1:d2}/{2:d2} {3:d2}:{4:d2}:{5}", (object) dates2._annee, (object) dates2._mois, (object) dates2._jour, (object) dates2._heure, (object) dates2._minutes, (object) dates2._secondes.ToString(format, (IFormatProvider) numberFormat));
    }

    /// <summary>Obtention de la date sous forme de chaine de caracteres</summary>
    /// <returns>Date sous forme de chaine de caracteres</returns>
    /// <remarks></remarks>
    public string ToLongDate()
    {
      DateTime dateTime = new DateTime(this._annee, this._mois, this._jour, this._heure, this._minutes, checked ((int) Math.Round(this._secondes)));
      return dateTime.ToLongDateString().Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + dateTime.ToLongDateString().Substring(1) + "  " + dateTime.ToLongTimeString();
    }

    /// <summary>
    /// Calcul du jour julien 2000 a partir de la date calendaire. Le jour julien
    /// est nul pour le 1er janvier 2000 12h. La date est supposee correcte et
    /// appartenir au calendrier gregorien.
    /// Inspire du calcul du jour julien dans l'Astronomical Algorithms
    /// 2nd edition de Jean Meeus, p61
    /// </summary>
    /// <remarks></remarks>
    private void CalculJourJulien()
    {
      int annee = this._annee;
      int mois = this._mois;
      double num1 = (double) this._jour + (double) this._heure * (1.0 / 24.0) + (double) this._minutes * 0.000694444444444444 + this._secondes * 1.15740740740741E-05;
      if (mois < 3)
      {
        checked { --annee; }
        checked { mois += 12; }
      }
      int num2 = annee / 100;
      int num3 = checked (2 - num2 + unchecked (num2 / 4));
      this._jourJulien = Math.Floor(365.25 * (double) checked (annee - 2000)) + Math.Floor(30.6001 * (double) checked (mois + 1)) + num1 + (double) num3 - 50.5;
      this._jourJulienUTC = this._jourJulien - this._offsetUTC;
    }

    public int Annee => this._annee;

    public double JourJulien => this._jourJulien;

    public double JourJulienUTC => this._jourJulienUTC;

    public double OffsetUTC => this._offsetUTC;
  }
}
