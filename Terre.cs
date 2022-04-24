// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Terre
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using System;

namespace TLE_Analyser
{
  public sealed class Terre
  {
    public const double RAYON = 6378.136658;
    public const double GE = 398600.4418;
    public static readonly double KE = 60.0 * Math.Sqrt(1.5362302589862E-06);
    public const double J2 = 0.0010826158;
    public const double J3 = -2.53881E-06;
    public const double J4 = -1.65597E-06;
    public const double OMEGA0 = 1.0027379093508;
    public const double OMEGA = 7.29211585530659E-05;
    public const double APLA = 0.0033527794541675;
    public const double E2 = 0.00669431777826672;
    public const double MILE_PAR_KM = 0.621371192237334;
    public const double PIED_PAR_METRE = 3.28083989501312;
    public const double km2er = 0.000156785602695689;
    public const double kmpersec2erpermin = 0.00940713616174136;

    private Terre()
    {
    }
  }
}
