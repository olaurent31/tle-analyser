// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Lune
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using System;
using System.Diagnostics;

namespace TLE_Analyser
{
  public class Lune : Corps
  {
    public const double RAYON = 1738.0;
    private double _elongation;
    private double _fractionIlluminee;
    private string _phase;
    private static double[] tabLon = new double[60]
    {
      6288774.0,
      1274027.0,
      658314.0,
      213618.0,
      -185116.0,
      -114332.0,
      58793.0,
      57066.0,
      53322.0,
      45758.0,
      -40923.0,
      -34720.0,
      -30383.0,
      15327.0,
      -12528.0,
      10980.0,
      10675.0,
      10034.0,
      8548.0,
      -7888.0,
      -6766.0,
      -5163.0,
      4987.0,
      4036.0,
      3994.0,
      3861.0,
      3665.0,
      -2689.0,
      -2602.0,
      2390.0,
      -2348.0,
      2236.0,
      -2120.0,
      -2069.0,
      2048.0,
      -1773.0,
      -1595.0,
      1215.0,
      -1110.0,
      -892.0,
      -810.0,
      759.0,
      -713.0,
      -700.0,
      691.0,
      596.0,
      549.0,
      537.0,
      520.0,
      -487.0,
      -399.0,
      -381.0,
      351.0,
      -340.0,
      330.0,
      327.0,
      -323.0,
      299.0,
      294.0,
      0.0
    };
    private static double[] tabDist = new double[60]
    {
      -20905355.0,
      -3699111.0,
      -2955968.0,
      -569925.0,
      48888.0,
      -3149.0,
      246158.0,
      -152138.0,
      -170733.0,
      -204586.0,
      -129620.0,
      108743.0,
      104755.0,
      10321.0,
      0.0,
      79661.0,
      -34782.0,
      -23210.0,
      -21636.0,
      24208.0,
      30824.0,
      -8379.0,
      -16675.0,
      -12831.0,
      -10445.0,
      -11650.0,
      14403.0,
      -7003.0,
      0.0,
      10056.0,
      6322.0,
      -9884.0,
      5751.0,
      0.0,
      -4950.0,
      4130.0,
      0.0,
      -3958.0,
      0.0,
      3258.0,
      2616.0,
      -1897.0,
      -2117.0,
      2354.0,
      0.0,
      0.0,
      -1423.0,
      -1117.0,
      -1571.0,
      -1739.0,
      0.0,
      -4421.0,
      0.0,
      0.0,
      0.0,
      0.0,
      1165.0,
      0.0,
      0.0,
      8752.0
    };
    private static double[] tabLat = new double[60]
    {
      5128122.0,
      280602.0,
      277693.0,
      173237.0,
      55413.0,
      46271.0,
      32573.0,
      17198.0,
      9266.0,
      8822.0,
      8216.0,
      4324.0,
      4200.0,
      -3359.0,
      2463.0,
      2211.0,
      2065.0,
      -1870.0,
      1828.0,
      -1794.0,
      -1749.0,
      -1565.0,
      -1491.0,
      -1475.0,
      -1410.0,
      -1344.0,
      -1335.0,
      1107.0,
      1021.0,
      833.0,
      777.0,
      671.0,
      607.0,
      596.0,
      491.0,
      -451.0,
      439.0,
      422.0,
      421.0,
      -366.0,
      -351.0,
      331.0,
      315.0,
      302.0,
      -283.0,
      -229.0,
      223.0,
      223.0,
      -220.0,
      -220.0,
      -185.0,
      181.0,
      -177.0,
      176.0,
      166.0,
      -164.0,
      132.0,
      -119.0,
      115.0,
      107.0
    };
    private static int[,] tabCoef1 = new int[60, 4]
    {
      {
        0,
        0,
        1,
        0
      },
      {
        2,
        0,
        -1,
        0
      },
      {
        2,
        0,
        0,
        0
      },
      {
        0,
        0,
        2,
        0
      },
      {
        0,
        1,
        0,
        0
      },
      {
        0,
        0,
        0,
        2
      },
      {
        2,
        0,
        -2,
        0
      },
      {
        2,
        -1,
        -1,
        0
      },
      {
        2,
        0,
        1,
        0
      },
      {
        2,
        -1,
        0,
        0
      },
      {
        0,
        1,
        -1,
        0
      },
      {
        1,
        0,
        0,
        0
      },
      {
        0,
        1,
        1,
        0
      },
      {
        2,
        0,
        0,
        -2
      },
      {
        0,
        0,
        1,
        2
      },
      {
        0,
        0,
        1,
        -2
      },
      {
        4,
        0,
        -1,
        0
      },
      {
        0,
        0,
        3,
        0
      },
      {
        4,
        0,
        -2,
        0
      },
      {
        2,
        1,
        -1,
        0
      },
      {
        2,
        1,
        0,
        0
      },
      {
        1,
        0,
        -1,
        0
      },
      {
        1,
        1,
        0,
        0
      },
      {
        2,
        -1,
        1,
        0
      },
      {
        2,
        0,
        2,
        0
      },
      {
        4,
        0,
        0,
        0
      },
      {
        2,
        0,
        -3,
        0
      },
      {
        0,
        1,
        -2,
        0
      },
      {
        2,
        0,
        -1,
        2
      },
      {
        2,
        -1,
        -2,
        0
      },
      {
        1,
        0,
        1,
        0
      },
      {
        2,
        -2,
        0,
        0
      },
      {
        0,
        1,
        2,
        0
      },
      {
        0,
        2,
        0,
        0
      },
      {
        2,
        -2,
        -1,
        0
      },
      {
        2,
        0,
        1,
        -2
      },
      {
        2,
        0,
        0,
        2
      },
      {
        4,
        -1,
        -1,
        0
      },
      {
        0,
        0,
        2,
        2
      },
      {
        3,
        0,
        -1,
        0
      },
      {
        2,
        1,
        1,
        0
      },
      {
        4,
        -1,
        -2,
        0
      },
      {
        0,
        2,
        -1,
        0
      },
      {
        2,
        2,
        -1,
        0
      },
      {
        2,
        1,
        -2,
        0
      },
      {
        2,
        -1,
        0,
        -2
      },
      {
        4,
        0,
        1,
        0
      },
      {
        0,
        0,
        4,
        0
      },
      {
        4,
        -1,
        0,
        0
      },
      {
        1,
        0,
        -2,
        0
      },
      {
        2,
        1,
        0,
        -2
      },
      {
        0,
        0,
        2,
        -2
      },
      {
        1,
        1,
        1,
        0
      },
      {
        3,
        0,
        -2,
        0
      },
      {
        4,
        0,
        -3,
        0
      },
      {
        2,
        -1,
        2,
        0
      },
      {
        0,
        2,
        1,
        0
      },
      {
        1,
        1,
        -1,
        0
      },
      {
        2,
        0,
        3,
        0
      },
      {
        2,
        0,
        -1,
        -2
      }
    };
    private static int[,] tabCoef2 = new int[60, 4]
    {
      {
        0,
        0,
        0,
        1
      },
      {
        0,
        0,
        1,
        1
      },
      {
        0,
        0,
        1,
        -1
      },
      {
        2,
        0,
        0,
        -1
      },
      {
        2,
        0,
        -1,
        1
      },
      {
        2,
        0,
        -1,
        -1
      },
      {
        2,
        0,
        0,
        1
      },
      {
        0,
        0,
        2,
        1
      },
      {
        2,
        0,
        1,
        -1
      },
      {
        0,
        0,
        2,
        -1
      },
      {
        2,
        -1,
        0,
        -1
      },
      {
        2,
        0,
        -2,
        -1
      },
      {
        2,
        0,
        1,
        1
      },
      {
        2,
        1,
        0,
        -1
      },
      {
        2,
        -1,
        -1,
        1
      },
      {
        2,
        -1,
        0,
        1
      },
      {
        2,
        -1,
        -1,
        -1
      },
      {
        0,
        1,
        -1,
        -1
      },
      {
        4,
        0,
        -1,
        -1
      },
      {
        0,
        1,
        0,
        1
      },
      {
        0,
        0,
        0,
        3
      },
      {
        0,
        1,
        -1,
        1
      },
      {
        1,
        0,
        0,
        1
      },
      {
        0,
        1,
        1,
        1
      },
      {
        0,
        1,
        1,
        -1
      },
      {
        0,
        1,
        0,
        -1
      },
      {
        1,
        0,
        0,
        -1
      },
      {
        0,
        0,
        3,
        1
      },
      {
        4,
        0,
        0,
        -1
      },
      {
        4,
        0,
        -1,
        1
      },
      {
        0,
        0,
        1,
        -3
      },
      {
        4,
        0,
        -2,
        1
      },
      {
        2,
        0,
        0,
        -3
      },
      {
        2,
        0,
        2,
        -1
      },
      {
        2,
        -1,
        1,
        -1
      },
      {
        2,
        0,
        -2,
        1
      },
      {
        0,
        0,
        3,
        -1
      },
      {
        2,
        0,
        2,
        1
      },
      {
        2,
        0,
        -3,
        -1
      },
      {
        2,
        1,
        -1,
        1
      },
      {
        2,
        1,
        0,
        1
      },
      {
        4,
        0,
        0,
        1
      },
      {
        2,
        -1,
        1,
        1
      },
      {
        2,
        -2,
        0,
        -1
      },
      {
        0,
        0,
        1,
        3
      },
      {
        2,
        1,
        1,
        -1
      },
      {
        1,
        1,
        0,
        -1
      },
      {
        1,
        1,
        0,
        1
      },
      {
        0,
        1,
        -2,
        -1
      },
      {
        2,
        1,
        -1,
        -1
      },
      {
        1,
        0,
        1,
        1
      },
      {
        2,
        -1,
        -2,
        -1
      },
      {
        0,
        1,
        2,
        1
      },
      {
        4,
        0,
        -2,
        -1
      },
      {
        4,
        -1,
        -1,
        -1
      },
      {
        1,
        0,
        1,
        -1
      },
      {
        4,
        0,
        1,
        -1
      },
      {
        1,
        0,
        -1,
        -1
      },
      {
        4,
        -1,
        0,
        -1
      },
      {
        2,
        -2,
        0,
        1
      }
    };

    [DebuggerNonUserCode]
    public Lune()
    {
    }

    /// <summary>
    /// Calcul de la position de la Lune avec le modele simplifie issu de
    /// l'Astronomical Algorithms 2nd edition de Jean Meeus, pp337-342
    /// </summary>
    /// <param name="dat">Date</param>
    /// <remarks></remarks>
    public void CalculPosition(Dates dat)
    {
      double[] numArray = new double[5];
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = dat.JourJulienUTC * 2.7378507871321E-05;
      double num5 = num4 * num4;
      double num6 = num5 * num4;
      double num7 = num6 * num4;
      double a1 = Math.PI / 180.0 * ((218.3164477 + 481267.88123421 * num4 - 0.0015786 * num5 + num6 / 538841.0 - num7 / 65194000.0) % 360.0);
      numArray[0] = Math.PI / 180.0 * ((297.8501921 + 445267.1114034 * num4 - 0.0018819 * num5 + num6 / 545868.0 - num7 / 113065000.0) % 360.0);
      numArray[1] = Math.PI / 180.0 * ((357.5291092 + 35999.0502909 * num4 - 0.0001536 * num5 + num6 / 24490000.0) % 360.0);
      numArray[2] = Math.PI / 180.0 * ((134.9633964 + 477198.8675055 * num4 + 0.0087414 * num5 + num6 / 69699.0 - num7 / 14712000.0) % 360.0);
      numArray[3] = Math.PI / 180.0 * ((93.272095 + 483202.0175233 * num4 - 0.0036539 * num5 - num6 / 3526000.0 + num7 / 863310000.0) % 360.0);
      numArray[4] = 1.0 - 0.002516 * num4 - 7.4E-06 * num5;
      int index1 = 0;
      do
      {
        double num8 = 0.0;
        double a2 = 0.0;
        double num9 = 1.0;
        double num10 = 1.0;
        int index2 = 0;
        do
        {
          num8 += numArray[index2] * (double) Lune.tabCoef1[index1, index2];
          a2 += numArray[index2] * (double) Lune.tabCoef2[index1, index2];
          checked { ++index2; }
        }
        while (index2 <= 3);
        if (Lune.tabCoef1[index1, 1] != 0)
          num9 = Math.Pow(numArray[4], (double) Math.Abs(Lune.tabCoef1[index1, 1]));
        if (Lune.tabCoef2[index1, 1] != 0)
          num10 = Math.Pow(numArray[4], (double) Math.Abs(Lune.tabCoef2[index1, 1]));
        num2 += Lune.tabLon[index1] * num9 * Math.Sin(num8);
        num3 += Lune.tabDist[index1] * num9 * Math.Cos(num8);
        num1 += Lune.tabLat[index1] * num10 * Math.Sin(a2);
        checked { ++index1; }
      }
      while (index1 <= 59);
      double a3 = Math.PI / 180.0 * ((119.75 + 131.849 * num4) % 360.0);
      double a4 = Math.PI / 180.0 * ((53.09 + 479264.29 * num4) % 360.0);
      double a5 = Math.PI / 180.0 * ((313.45 + 481266.484 * num4) % 360.0);
      double num11 = num2 + (3958.0 * Math.Sin(a3) + 1962.0 * Math.Sin(a1 - numArray[3]) + 318.0 * Math.Sin(a4));
      double num12 = num1 + (-2235.0 * Math.Sin(a1) + 382.0 * Math.Sin(a5) + 175.0 * (Math.Sin(a3 - numArray[3]) + Math.Sin(a3 + numArray[3])) + (double) sbyte.MaxValue * Math.Sin(a1 - numArray[2]) - 115.0 * Math.Sin(a1 + numArray[2]));
      double num13 = a1 + Math.PI / 180.0 * num11 * 1E-06;
      double num14 = Math.PI / 180.0 * num12 * 1E-06;
      double num15 = 385000.56 + num3 * 0.001;
      double num16 = Math.Cos(num14);
      double num17 = Math.Sin(num14);
      double num18 = Math.PI / 180.0 * (84381.448 - 46.815 * num4 - 0.00059 * num5 + 0.001813 * num6) * 0.000277777777777778;
      double num19 = Math.Cos(num18);
      double num20 = Math.Sin(num18);
      double num21 = num15 * num16 * Math.Sin(num13);
      this._position = new Vecteur(num15 * num16 * Math.Cos(num13), num21 * num19 - num15 * num20 * num17, num21 * num20 + num15 * num19 * num17);
    }

    /// <summary>Calcul de la phase de la Lune</summary>
    /// <param name="sun">Soleil</param>
    /// <remarks></remarks>
    public void CalculPhase(Soleil sun)
    {
      Vecteur vec = new Vecteur(0.0, 0.0, 1.0);
      this._elongation = sun.Position.Angle(this._position.Oppose());
      double num = sun.Position.ProduitVectoriel(this._position).ProduitScalaire(vec);
      this._fractionIlluminee = 0.5 * (1.0 + Math.Cos(this._elongation));
      if (this._fractionIlluminee >= 0.0 && this._fractionIlluminee < 0.03)
        this._phase = TLE_Analyser.My.Resources.Resources.phase_lune1;
      if (this._fractionIlluminee >= 0.03 && this._fractionIlluminee < 0.31)
        this._phase = Interaction.IIf(num > 0.0, (object) TLE_Analyser.My.Resources.Resources.phase_lune2, (object) TLE_Analyser.My.Resources.Resources.phase_lune3).ToString();
      if (this._fractionIlluminee >= 0.31 && this._fractionIlluminee < 0.69)
        this._phase = Interaction.IIf(num > 0.0, (object) TLE_Analyser.My.Resources.Resources.phase_lune4, (object) TLE_Analyser.My.Resources.Resources.phase_lune5).ToString();
      if (this._fractionIlluminee >= 0.69 && this._fractionIlluminee < 0.97)
        this._phase = Interaction.IIf(num > 0.0, (object) TLE_Analyser.My.Resources.Resources.phase_lune6, (object) TLE_Analyser.My.Resources.Resources.phase_lune7).ToString();
      if (this._fractionIlluminee < 0.97 || this._fractionIlluminee > 1.0)
        return;
      this._phase = TLE_Analyser.My.Resources.Resources.phase_lune8;
    }

    public double Elongation => this._elongation;

    public double FractionIlluminee => this._fractionIlluminee;

    public string Phase => this._phase;
  }
}
