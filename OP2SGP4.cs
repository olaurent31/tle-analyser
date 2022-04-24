// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.OP2SGP4
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic.CompilerServices;
using System;

namespace TLE_Analyser
{
  [StandardModule]
  internal sealed class OP2SGP4
  {
    public static double ik;
    public static double ok;
    public static double ek;
    public static double wk;
    public static double mk;
    public static double nk;
    public static double iz;
    public static double oz;
    public static double ez;
    public static double wz;
    public static double mz;
    public static double nz;
    public static double[] rr1 = new double[3];
    public static double[] vv1 = new double[3];
    public static double xincl;
    public static double xnodeo;
    public static double eo;
    public static double omegao;
    public static double xmo;
    public static double xno;
    public static double[] rr = new double[3];
    public static double[] vv = new double[3];
    public static double xkmper = 6378.136658;
    public static double qo = 120.0;
    public static double so = 78.0;
    public static double s = 1.0 + OP2SGP4.so / OP2SGP4.xkmper;
    public static double aodp;
    public static double c2;
    public static double bstar;
    public static double twopi = 2.0 * Math.PI;
    public const double xj3 = -2.53881E-06;
    public const double ck2 = 0.0005413079;
    public const double ck4 = 6.2098875E-07;
    public static double xke = Terre.KE;
    public const double qoms2t = 1.88027915901527E-09;
    public static double a3ovk2;

    public static void rv2el(double[] rri, double[] vvi)
    {
      OP2SGP4.rr = rri;
      OP2SGP4.vv = vvi;
      OP2SGP4.rvel(OP2SGP4.rr, OP2SGP4.vv);
      OP2SGP4.ik = OP2SGP4.xincl;
      OP2SGP4.ok = OP2SGP4.xnodeo;
      OP2SGP4.ek = OP2SGP4.eo;
      OP2SGP4.wk = OP2SGP4.omegao;
      OP2SGP4.mk = OP2SGP4.xmo;
      OP2SGP4.nk = OP2SGP4.xno;
      OP2SGP4.rr1[0] = OP2SGP4.rr[0];
      OP2SGP4.rr1[1] = OP2SGP4.rr[1];
      OP2SGP4.rr1[2] = OP2SGP4.rr[2];
      OP2SGP4.vv1[0] = OP2SGP4.vv[0];
      OP2SGP4.vv1[1] = OP2SGP4.vv[1];
      OP2SGP4.vv1[2] = OP2SGP4.vv[2];
      OP2SGP4.sgp4((object) 0.0);
      OP2SGP4.rvel(OP2SGP4.rr, OP2SGP4.vv);
      OP2SGP4.xincl = OP2SGP4.ik + OP2SGP4.ik - OP2SGP4.xincl;
      OP2SGP4.xnodeo = OP2SGP4.ok + OP2SGP4.ok - OP2SGP4.xnodeo;
      OP2SGP4.eo = OP2SGP4.ek + OP2SGP4.ek - OP2SGP4.eo;
      OP2SGP4.omegao = OP2SGP4.wk + OP2SGP4.wk - OP2SGP4.omegao;
      OP2SGP4.xmo = OP2SGP4.mk + OP2SGP4.mk - OP2SGP4.xmo;
      OP2SGP4.xno = OP2SGP4.nk + OP2SGP4.nk - OP2SGP4.xno;
      OP2SGP4.iz = OP2SGP4.xincl;
      OP2SGP4.oz = OP2SGP4.xnodeo;
      OP2SGP4.ez = OP2SGP4.eo;
      OP2SGP4.wz = OP2SGP4.omegao;
      OP2SGP4.mz = OP2SGP4.xmo;
      OP2SGP4.nz = OP2SGP4.xno;
      OP2SGP4.sgp4((object) 0.0);
      OP2SGP4.rvel(OP2SGP4.rr, OP2SGP4.vv);
      OP2SGP4.xincl = OP2SGP4.iz + OP2SGP4.ik - OP2SGP4.xincl;
      OP2SGP4.xnodeo = OP2SGP4.oz + OP2SGP4.ok - OP2SGP4.xnodeo;
      OP2SGP4.eo = OP2SGP4.ez + OP2SGP4.ek - OP2SGP4.eo;
      OP2SGP4.omegao = OP2SGP4.wz + OP2SGP4.wk - OP2SGP4.omegao;
      OP2SGP4.xmo = OP2SGP4.mz + OP2SGP4.mk - OP2SGP4.xmo;
      OP2SGP4.xno = OP2SGP4.nz + OP2SGP4.nk - OP2SGP4.xno;
      OP2SGP4.xincl = Math.Abs(OP2SGP4.xincl);
      OP2SGP4.xnodeo = OP2SGP4.fmod2p(OP2SGP4.xnodeo);
      OP2SGP4.omegao = OP2SGP4.fmod2p(OP2SGP4.omegao);
      OP2SGP4.xmo = OP2SGP4.fmod2p(OP2SGP4.xmo);
      OP2SGP4.rr[0] = OP2SGP4.rr1[0];
      OP2SGP4.rr[1] = OP2SGP4.rr1[1];
      OP2SGP4.rr[2] = OP2SGP4.rr1[2];
      OP2SGP4.vv[0] = OP2SGP4.vv1[0];
      OP2SGP4.vv[1] = OP2SGP4.vv1[1];
      OP2SGP4.vv[2] = OP2SGP4.vv1[2];
      rri = OP2SGP4.rr;
      vvi = OP2SGP4.vv;
    }

    public static void rvel(double[] rr2, double[] vv2)
    {
      double[] v1 = new double[3];
      double[] numArray1 = new double[3];
      double[] v2 = new double[3];
      double[] numArray2 = new double[3];
      OP2SGP4.smult(1.0 / OP2SGP4.xke, vv2, numArray2);
      OP2SGP4.cross(rr2, numArray2, v1);
      double num1 = OP2SGP4.dot(v1, v1);
      double[] numArray3 = new double[3]{ 0.0, 0.0, 1.0 };
      double[] numArray4 = new double[3];
      OP2SGP4.cross(numArray3, v1, numArray1);
      if (numArray1[0] == 0.0 && numArray1[1] == 0.0)
        numArray1[0] = 1.0;
      OP2SGP4.unitv(numArray1, numArray1);
      double num2 = OP2SGP4.norm(ref rr2);
      double num3 = OP2SGP4.dot(rr2, vv2) / num2;
      double num4 = OP2SGP4.norm(ref v1) * OP2SGP4.xke / num2;
      double num5 = OP2SGP4.acose(OP2SGP4.dot(rr2, numArray1) / num2);
      if (rr2[2] < 0.0)
        num5 = OP2SGP4.twopi - num5;
      OP2SGP4.cross(numArray2, v1, numArray3);
      OP2SGP4.smult(-1.0 / num2, rr2, numArray4);
      OP2SGP4.vadd(numArray3, numArray4, v2);
      double num6 = OP2SGP4.norm(ref v2);
      if (num6 >= 1.0)
        return;
      double num7 = Math.Atan2(numArray1[1], numArray1[0]);
      if (num7 < 0.0)
        num7 += OP2SGP4.twopi;
      double num8 = Math.Atan2(Math.Sqrt(v1[0] * v1[0] + v1[1] * v1[1]), v1[2]);
      double num9 = OP2SGP4.acose(OP2SGP4.dot(v2, numArray1) / num6);
      if (v2[2] < 0.0)
        num9 = OP2SGP4.fmod2p(OP2SGP4.twopi - num9);
      double num10 = num1 / (1.0 - num6 * num6);
      double num11 = OP2SGP4.xke * Math.Pow(num10, -1.5);
      OP2SGP4.xincl = num8;
      double num12 = num5;
      int num13 = 0;
      double num14;
      double num15;
      double num16;
      double num17;
      double num18;
      do
      {
        double num19 = num1;
        double num20 = Math.Sqrt(num1 / num10);
        double num21 = 0.0005413079 / num1;
        double num22 = num21 / num1;
        num14 = Math.Cos(OP2SGP4.xincl);
        num15 = Math.Sin(OP2SGP4.xincl);
        double num23 = Math.Sin(2.0 * num12);
        double num24 = Math.Cos(2.0 * num12);
        double num25 = num14 * num14;
        num16 = 3.0 * num25 - 1.0;
        double num26 = 1.0 - num25;
        double num27 = 7.0 * num25 - 1.0;
        num17 = (num2 - 0.5 * num21 * num26 * num24) / (1.0 - 1.5 * num22 * num20 * num16);
        num12 = num5 + 0.25 * num22 * num27 * num23;
        OP2SGP4.xnodeo = num7 - 1.5 * num22 * num14 * num23;
        OP2SGP4.xincl = num8 - 1.5 * num22 * num14 * num15 * num24;
        num18 = num3 + num11 * num21 * num26 * num23;
        double num28 = num4 - num11 * num21 * (num26 * num24 + 1.5 * num16);
        double num29 = num17 * num28 / OP2SGP4.xke;
        num1 = num29 * num29;
        num10 = 1.0 / (2.0 / num17 - (num18 * num18 + num28 * num28) / (OP2SGP4.xke * OP2SGP4.xke));
        num11 = OP2SGP4.xke * Math.Pow(num10, -1.5);
        if (Math.Abs(num19 - num1) >= 1E-12)
          checked { ++num13; }
        else
          break;
      }
      while (num13 <= 98);
      double num30 = 1.0 - num17 / num10;
      double num31 = num17 * num18 / (OP2SGP4.xke * Math.Sqrt(num10));
      double d1 = 1.0 - num1 / num10;
      OP2SGP4.a3ovk2 = 0.00469014030646883;
      double num32 = 0.125 * OP2SGP4.a3ovk2 * num15 * (3.0 + 5.0 * num14) / (1.0 + num14);
      double num33 = 0.25 * OP2SGP4.a3ovk2 * num15;
      double num34 = num31 / (1.0 + Math.Sqrt(1.0 - d1));
      double num35 = Math.Cos(num12);
      double num36 = Math.Sin(num12);
      OP2SGP4.eo = Math.Sqrt(d1);
      OP2SGP4.omegao = num9;
      double x1 = OP2SGP4.eo * Math.Cos(OP2SGP4.omegao);
      int num37 = 0;
      double d2;
      double num38;
      double x2;
      double y;
      do
      {
        double eo = OP2SGP4.eo;
        d2 = 1.0 - OP2SGP4.eo * OP2SGP4.eo;
        num38 = 1.0 / (num10 * d2);
        double num39 = num38 * num33;
        double num40 = OP2SGP4.eo * Math.Sin(OP2SGP4.omegao) + num39;
        x2 = num17 * num35 / num10 + x1 - num40 * num34;
        y = num17 * num36 / num10 + num40 + x1 * num34;
        x1 = x2 * num30 + y * num31;
        OP2SGP4.omegao = OP2SGP4.fmod2p(Math.Atan2(y * num30 - x2 * num31 - num39, x1));
        OP2SGP4.eo = OP2SGP4.eo <= 0.5 ? x1 / Math.Cos(OP2SGP4.omegao) : 0.9 * OP2SGP4.eo + 0.1 * (x1 / Math.Cos(OP2SGP4.omegao));
        if (OP2SGP4.eo > 0.999)
          OP2SGP4.eo = 0.999;
        if (Math.Abs(eo - OP2SGP4.eo) >= 1E-12)
          checked { ++num37; }
        else
          break;
      }
      while (num37 <= 98);
      OP2SGP4.xmo = OP2SGP4.fmod2p(Math.Atan2(y, x2) - num31 - num38 * num32 * x1 - OP2SGP4.omegao);
      double num41 = num10;
      double x3 = num41;
      double num42 = Math.Sqrt(d2);
      double num43 = 0.00081196185 * num16 / (d2 * num42);
      int num44 = 0;
      do
      {
        double num45 = x3;
        double num46 = num43 / (num41 * num41);
        num41 = num10 * (1.0 - num46);
        double num47 = num43 / (x3 * x3);
        x3 = num41 / (1.0 - num47 / 3.0 - num47 * num47 - 134.0 * num47 * num47 * num47 / 81.0);
        if (Math.Abs(num45 - x3) >= 1E-12)
          checked { ++num44; }
        else
          break;
      }
      while (num44 <= 98);
      OP2SGP4.xno = OP2SGP4.xke * Math.Pow(x3, -1.5);
    }

    public static void sgp4(object tsince)
    {
      double num1 = 0.0001;
      double num2 = 1E-06;
      double y1 = 2.0 / 3.0;
      double num3 = Math.Pow(OP2SGP4.xke / OP2SGP4.xno, y1);
      double num4 = Math.Cos(OP2SGP4.xincl);
      double num5 = num4 * num4;
      double num6 = 3.0 * num5 - 1.0;
      double d1 = 1.0 - OP2SGP4.eo * OP2SGP4.eo;
      double num7 = Math.Sqrt(d1);
      double num8 = 0.00081196185 * num6 / (num7 * d1);
      double num9 = num8 / (num3 * num3);
      double num10 = num3 * (1.0 - num9 * (0.5 * y1 + num9 * (1.0 + 134.0 / 81.0 * num9)));
      double num11 = num8 / (num10 * num10);
      double num12 = OP2SGP4.xno / (1.0 + num11);
      OP2SGP4.aodp = num10 / (1.0 - num11);
      double num13 = 3.0 * num5 - 1.0;
      double num14 = OP2SGP4.s;
      double num15 = 1.88027915901527E-09;
      double num16 = (OP2SGP4.aodp * (1.0 - OP2SGP4.eo) - 1.0) * OP2SGP4.xkmper;
      if (num16 < 156.0)
      {
        double num17 = num16 > 98.0 ? num16 - 78.0 : 20.0;
        double num18 = (120.0 - num17) / OP2SGP4.xkmper;
        double num19 = num18 * num18;
        num15 = num19 * num19;
        num14 = num17 / OP2SGP4.xkmper + 1.0;
      }
      double num20 = 1.0 / (OP2SGP4.aodp * d1);
      double num21 = num20 * num20;
      double num22 = 1.0 / (OP2SGP4.aodp - num14);
      double num23 = OP2SGP4.aodp * OP2SGP4.eo * num22;
      double num24 = num23 * num23;
      double num25 = OP2SGP4.eo * num23;
      double x1 = Math.Abs(1.0 - num24);
      double num26 = num22 * num22;
      double num27 = num15 * num26 * num26;
      double num28 = num27 / Math.Pow(x1, 3.5);
      OP2SGP4.c2 = num28 * num12 * (OP2SGP4.aodp * (1.0 + 1.5 * num24 + num25 * (4.0 + num24)) + 0.000405980925 * num22 / x1 * num13 * (8.0 + 3.0 * num24 * (8.0 + num24)));
      double Left1 = OP2SGP4.bstar * OP2SGP4.c2;
      double num29 = Math.Sin(OP2SGP4.xincl);
      double num30 = 1.0 - num5;
      double num31 = 2.0 * num12 * num28 * OP2SGP4.aodp * d1 * (num23 * (2.0 + 0.5 * num24) + OP2SGP4.eo * (0.5 + 2.0 * num24) - 0.0010826158 * num22 / (OP2SGP4.aodp * x1) * (-3.0 * num13 * (1.0 - 2.0 * num25 + num24 * (1.5 - 0.5 * num25)) + 0.75 * num30 * (2.0 * num24 - num25 * (1.0 + num24)) * Math.Cos(2.0 * OP2SGP4.omegao)));
      double num32 = num5 * num5;
      double num33 = 0.0016239237 * num21 * num12;
      double num34 = num33 * 0.0005413079 * num21;
      double num35 = 7.762359375E-07 * num21 * num21 * num12;
      double Left2 = num12 + 0.5 * num33 * num7 * num13 + 1.0 / 16.0 * num34 * num7 * (13.0 - 78.0 * num5 + 137.0 * num32);
      double num36 = 1.0 - 5.0 * num5;
      double Left3 = -0.5 * num33 * num36 + 1.0 / 16.0 * num34 * (7.0 - 114.0 * num5 + 395.0 * num32) + num35 * (3.0 - 36.0 * num5 + 49.0 * num32);
      double num37 = -num33 * num4;
      double Left4 = num37 + (0.5 * num34 * (4.0 - 19.0 * num5) + 2.0 * num35 * (3.0 - 7.0 * num5)) * num4;
      double num38 = 3.5 * d1 * num37 * Left1;
      double num39 = 1.5 * Left1;
      double num40 = OP2SGP4.eo * num23;
      int num41 = -(OP2SGP4.aodp * (1.0 - OP2SGP4.eo) < 220.0 / OP2SGP4.xkmper + 1.0 ? 1 : 0);
      double num42;
      double num43;
      double num44;
      double num45;
      double num46;
      double Left5;
      double Right1;
      double num47;
      double num48;
      double Left6;
      if (num41 == 0)
      {
        double num49 = Left1 * Left1;
        num41 = 0;
        double num50 = 1.0 + num23 * Math.Cos(OP2SGP4.xmo);
        num42 = num50 * (num50 * num50);
        num43 = 4.0 * OP2SGP4.aodp * num22 * num49;
        double num51 = num43 * num22 * Left1 / 3.0;
        num44 = (17.0 * OP2SGP4.aodp + num14) * num51;
        num45 = 0.5 * num51 * OP2SGP4.aodp * num22 * (221.0 * OP2SGP4.aodp + 31.0 * num14) * Left1;
        num46 = num43 + 2.0 * num49;
        Left5 = 0.25 * (3.0 * num44 + Left1 * (12.0 * num43 + 10.0 * num49));
        Right1 = 0.2 * (3.0 * num45 + 12.0 * Left1 * num44 + 6.0 * num43 * num43 + 15.0 * num49 * (2.0 * num43 + num49));
        num47 = Math.Sin(OP2SGP4.xmo);
        if (OP2SGP4.eo < num1)
        {
          num48 = 0.0;
          Left6 = num48;
        }
        else
        {
          double num52 = num27 * num22 * OP2SGP4.a3ovk2 * num12 * num29 / OP2SGP4.eo;
          num48 = -y1 * num27 * OP2SGP4.bstar / num40;
          Left6 = OP2SGP4.bstar * num52 * Math.Cos(OP2SGP4.omegao);
        }
      }
      double num53 = num23 * num23;
      double num54 = 2.0 * num28 * OP2SGP4.aodp * d1 * (1.0 + 2.75 * (num53 + num40) + num40 * num53);
      double d2 = Conversions.ToDouble(Operators.AddObject((object) OP2SGP4.xmo, Operators.MultiplyObject((object) Left2, tsince)));
      double num55 = Conversions.ToDouble(Operators.AddObject((object) OP2SGP4.omegao, Operators.MultiplyObject((object) Left3, tsince)));
      double num56 = Conversions.ToDouble(Operators.AddObject((object) OP2SGP4.xnodeo, Operators.MultiplyObject((object) Left4, tsince)));
      double num57 = num55;
      double a = d2;
      double Left7 = Conversions.ToDouble(Operators.MultiplyObject(tsince, tsince));
      double num58 = num56 + num38 * Left7;
      double num59 = Conversions.ToDouble(Operators.SubtractObject((object) 1, Operators.MultiplyObject((object) Left1, tsince)));
      double num60 = Conversions.ToDouble(Operators.MultiplyObject((object) (OP2SGP4.bstar * num31), tsince));
      double num61 = num39 * Left7;
      if (~num41 != 0)
      {
        double num62 = Conversions.ToDouble(Operators.MultiplyObject((object) Left6, tsince));
        double num63 = 1.0 + num23 * Math.Cos(d2);
        double num64 = num48 * (num63 * num63 * num63 - num42);
        double num65 = num62 + num64;
        a = d2 + num65;
        num57 = num55 - num65;
        double Right2 = Conversions.ToDouble(Operators.MultiplyObject((object) Left7, tsince));
        double Left8 = Conversions.ToDouble(Operators.MultiplyObject(tsince, (object) Right2));
        num59 = num59 - num43 * Left7 - num44 * Right2 - num45 * Left8;
        num60 += OP2SGP4.bstar * num54 * (Math.Sin(a) - num47);
        num61 = Conversions.ToDouble(Operators.AddObject((object) (num61 + num46 * Right2), Operators.MultiplyObject((object) Left8, Operators.AddObject((object) Left5, Operators.MultiplyObject(tsince, (object) Right1)))));
      }
      double d3 = OP2SGP4.aodp * num59 * num59;
      double num66 = OP2SGP4.eo - num60;
      if (num66 < num2)
        num66 = num2;
      double num67 = a + num57 + num58 + num12 * num61;
      double num68 = num66 * Math.Cos(num57);
      double num69 = 1.0 / (d3 * (1.0 - num66 * num66));
      double num70 = 0.125 * OP2SGP4.a3ovk2 * num29 * (3.0 + 5.0 * num4) / (1.0 + num4);
      double num71 = 0.25 * OP2SGP4.a3ovk2 * num29;
      double num72 = num69 * num70 * num68;
      double num73 = num69 * num71;
      double num74 = num67 + num72;
      double num75 = num66 * Math.Sin(num57) + num73;
      double num76 = num68 * num68 + num75 * num75;
      double num77 = Math.IEEERemainder(num74 - num58, OP2SGP4.twopi);
      double num78 = 1E-05;
      double num79 = num77;
      double[] numArray = new double[3];
      int num80 = 0;
      double num81 = num4 * num4;
      double num82 = 3.0 * num81 - 1.0;
      double num83 = 1.0 - num81;
      double num84 = 7.0 * num81 - 1.0;
      if (num76 > 1.0 - num78)
        num80 = -1;
      if (d3 * (1.0 - num66) < 1.0 && d3 * (1.0 + num66) < 1.0)
        num80 = -3;
      if (d3 * (1.0 - num66) < 1.0 || d3 * (1.0 + num66) < 1.0)
        num80 = -4;
      int num85 = 0;
      double num86;
      double num87;
      double num88;
      double num89;
      do
      {
        double num90 = 1E-12;
        int num91 = 1;
        num86 = Math.Sin(num79);
        num87 = Math.Cos(num79);
        num88 = num68 * num87 + num75 * num86;
        num89 = num68 * num86 - num75 * num87;
        double num92 = num77 - num79 + num89;
        if (Math.Abs(num92) >= num90)
        {
          double num93 = 1.0 - num88;
          double num94 = num92 / num93;
          if (num85 == 0)
          {
            double num95 = 1.25 * Math.Abs(num66);
            num91 = 0;
            if (num94 > num95)
              num94 = num95;
            else if (num94 < -num95)
              num94 = -num95;
            else
              num91 = 1;
          }
          if (num91 != 0)
            num94 = num92 / (num93 + 0.5 * num89 * num94);
          num79 += num94;
          checked { ++num85; }
        }
        else
          break;
      }
      while (num85 <= 9);
      double d4 = 1.0 - num76;
      double d5 = d3 * d4;
      double num96 = d3 * (1.0 - num88);
      double num97 = d3 / num96;
      double num98 = Math.Sqrt(d4);
      double num99 = num89 / (1.0 + num98);
      double x2 = num97 * (num87 - num68 + num75 * num99);
      double y2 = num97 * (num86 - num75 - num68 * num99);
      double num100 = Math.Atan2(y2, x2);
      double num101 = 2.0 * y2 * x2;
      double num102 = 2.0 * x2 * x2 - 1.0;
      double num103 = 0.0005413079 / d5;
      double num104 = num103 / d5;
      double num105 = num96 * (1.0 - 1.5 * num104 * num98 * num82) + 0.5 * num103 * num83 * num102;
      double num106 = num100 - 0.25 * num104 * num84 * num101;
      double num107 = num58 + 1.5 * num104 * num4 * num101;
      double num108 = OP2SGP4.xincl + 1.5 * num104 * num4 * num29 * num102;
      double num109 = Math.Sin(num106);
      double num110 = Math.Cos(num106);
      double num111 = Math.Sin(num108);
      double num112 = Math.Cos(num108);
      double num113 = Math.Sin(num107);
      double num114 = Math.Cos(num107);
      double num115 = -num113 * num112;
      double num116 = num114 * num112;
      double num117 = num115 * num109 + num114 * num110;
      double num118 = num116 * num109 + num113 * num110;
      double num119 = num111 * num109;
      OP2SGP4.rr[0] = num105 * num117;
      OP2SGP4.rr[1] = num105 * num118;
      OP2SGP4.rr[2] = num105 * num119;
      double num120 = OP2SGP4.xke * Math.Sqrt(d3) * num89 / num96;
      double num121 = OP2SGP4.xke * Math.Sqrt(d5) / num96;
      double num122 = OP2SGP4.xke / (d3 * Math.Sqrt(d3));
      double num123 = num120 - num122 * num103 * num83 * num101;
      double num124 = num121 + num122 * num103 * (num83 * num102 + 1.5 * num82);
      double num125 = num115 * num110 - num114 * num109;
      double num126 = num116 * num110 - num113 * num109;
      double num127 = num111 * num110;
      OP2SGP4.vv[0] = num123 * num117 + num124 * num125;
      OP2SGP4.vv[1] = num123 * num118 + num124 * num126;
      OP2SGP4.vv[2] = num123 * num119 + num124 * num127;
      if (num80 == 0)
        return;
      OP2SGP4.unitv(OP2SGP4.rr, OP2SGP4.rr);
      OP2SGP4.unitv(OP2SGP4.vv, OP2SGP4.vv);
      OP2SGP4.cross(OP2SGP4.vv, OP2SGP4.rr, numArray);
      OP2SGP4.cross(OP2SGP4.rr, numArray, OP2SGP4.vv);
      OP2SGP4.smult(OP2SGP4.xke, OP2SGP4.vv, OP2SGP4.vv);
    }

    private static double acose(double x) => x < 1.0 ? (x > -1.0 ? Math.Acos(x) : Math.PI) : 0.0;

    private static double dot(double[] v1, double[] v2)
    {
      double num = 0.0;
      int index = 0;
      do
      {
        num += v1[index] * v2[index];
        checked { ++index; }
      }
      while (index <= 2);
      return num;
    }

    private static double norm(ref double[] v) => Math.Sqrt(OP2SGP4.dot(v, v));

    private static void smult(double a, double[] v, double[] av)
    {
      int index = 0;
      do
      {
        av[index] = a * v[index];
        checked { ++index; }
      }
      while (index <= 2);
    }

    private static void vadd(double[] v1, double[] v2, double[] s)
    {
      int index = 0;
      do
      {
        s[index] = v1[index] + v2[index];
        checked { ++index; }
      }
      while (index <= 2);
    }

    private static void cross(double[] v1, double[] v2, double[] b)
    {
      b[0] = v1[1] * v2[2] - v1[2] * v2[1];
      b[1] = v1[2] * v2[0] - v1[0] * v2[2];
      b[2] = v1[0] * v2[1] - v1[1] * v2[0];
    }

    private static void unitv(double[] v, double[] u)
    {
      double num = OP2SGP4.norm(ref v);
      int index = 0;
      do
      {
        u[index] = v[index] / num;
        checked { ++index; }
      }
      while (index <= 2);
    }

    private static double fmod2p(double x)
    {
      double num = Math.IEEERemainder(x, OP2SGP4.twopi);
      if (num < 0.0)
        num += OP2SGP4.twopi;
      return num;
    }
  }
}
