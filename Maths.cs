// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Maths
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using System;

namespace TLE_Analyser
{
  public sealed class Maths
  {
    public const double EPSDBL = 1E-12;
    public const double EPSDBL100 = 1E-10;
    public const double DEUX_TIERS = 0.666666666666667;
    public const double DEUX_PI = 6.28318530717959;
    public const double PI_SUR_DEUX = 1.5707963267949;
    public const double T360 = 360.0;
    public const double DEG2RAD = 0.0174532925199433;
    public const double ARCSEC_PAR_DEG = 3600.0;
    public const double ARCMIN_PAR_DEG = 60.0;
    public const double DEUX_SUR_PI = 0.636619772367581;
    public const double RAD2DEG = 57.2957795130823;
    public const double DEG_PAR_ARCSEC = 0.000277777777777778;
    public const double DEG_PAR_ARCMIN = 0.0166666666666667;
    public const double HEUR2RAD = 0.261799387799149;
    public const double RAD2HEUR = 3.81971863420549;

    private Maths()
    {
    }

    /// <summary>Reduction des valeurs decimales en valeurs sexagesimales</summary>
    /// <param name="xdec">Valeur decimale</param>
    /// <param name="deg">Degres</param>
    /// <param name="min">Minutes</param>
    /// <param name="sec">Secondes</param>
    /// <remarks></remarks>
    public static void Deg2DMS(double xdec, ref int deg, ref int min, ref int sec)
    {
      double d = Math.Abs(xdec);
      int num = Math.Sign(xdec);
      deg = checked ((int) Math.Round(Math.Floor(d)));
      min = checked ((int) Math.Round(Math.Floor(unchecked (60.0 * d - (double) deg))));
      sec = checked ((int) Math.Round(Math.Floor(unchecked (3600.0 * (d - (double) deg) - 60.0 * (double) min + 0.5))));
      if ((double) sec == 60.0)
      {
        sec = 0;
        checked { ++min; }
      }
      if ((double) min == 60.0)
      {
        min = 0;
        checked { ++deg; }
      }
      checked { deg *= num; }
    }

    /// <summary>
    /// Calcul d'un extremum par interpolation a l'ordre 3,
    /// issu de l'Astronomical Algorithms 2nd edition, de Jean Meeus, pp23-25
    /// </summary>
    /// <param name="xtab">Tableau des abscisses</param>
    /// <param name="ytab">Tableau des ordonnees</param>
    /// <param name="extremum">Extremum local</param>
    /// <remarks></remarks>
    public static void CalculExtremumInterpolation3(
      double[] xtab,
      double[] ytab,
      ref double[] extremum)
    {
      double num1 = ytab[1] - ytab[0];
      double num2 = ytab[2] - ytab[1];
      double num3 = (num1 + num2) / (num2 - num1);
      extremum[0] = xtab[1] - 0.5 * (xtab[1] - xtab[0]) * num3;
      extremum[1] = ytab[1] - 0.125 * (num1 + num2) * num3;
    }

    /// <summary>
    /// Calcul d'une valeur x pour une valeur y donnee, par interpolation a l'ordre 3,
    /// issu de l'Astronomical Algorithms 2nd edition, de Jean Meeus, pp23-27
    /// </summary>
    /// <param name="xtab">Tableau des abscisses</param>
    /// <param name="ytab">Tableau des ordonnees</param>
    /// <param name="epsilon">Precision pour laquelle la valeur x doit etre obtenue</param>
    /// <param name="yval">Valeur y donnee</param>
    /// <param name="xval">Valeur x calculee par interpolation</param>
    /// <remarks></remarks>
    public static void CalculValeurXInterpolation3(
      double[] xtab,
      double[] ytab,
      double epsilon,
      double yval,
      ref double xval)
    {
      double[] numArray = new double[3];
      int num1 = 0;
      double num2 = 100000.0;
      double num3 = 0.0;
      int index = 0;
      do
      {
        numArray[index] = ytab[index] - yval;
        checked { ++index; }
      }
      while (index <= 2);
      double num4 = numArray[1] - numArray[0];
      double num5 = numArray[2] - numArray[1];
      double num6 = num5 - num4;
      double num7 = 2.0 * numArray[1];
      while (Math.Abs(num2) >= epsilon && num1 < 10000)
      {
        double num8 = num6 * num3;
        double num9 = num4 + num5 + num8;
        num2 = -(num7 + num3 * num9) / (num8 + num9);
        num3 += num2;
        checked { ++num1; }
      }
      xval = xtab[1] + num3 * (xtab[1] - xtab[0]);
    }
  }
}
