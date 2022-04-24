// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Soleil
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using System;
using System.Diagnostics;

namespace TLE_Analyser
{
  public class Soleil : Corps
  {
    public const double RAYON = 696000.0;
    public const double UA = 149597870.0;
    public const double MAGNITUDE = -26.98;
    private double _distanceUA;

    [DebuggerNonUserCode]
    public Soleil()
    {
    }

    /// <summary>
    /// Calcul de la position du Soleil avec le modele simplifie issu de
    /// l'Astronomical Algorithms 2nd edition de Jean Meeus, pp163-164
    /// </summary>
    /// <param name="dat">Date</param>
    /// <remarks></remarks>
    public void CalculPosition(Dates dat)
    {
      double num1 = dat.JourJulienUTC * 2.7378507871321E-05;
      double num2 = num1 * num1;
      double num3 = Math.PI / 180.0 * ((280.466457 + 36000.7698278 * num1 + 0.00030322 * num2) % 360.0);
      double num4 = Math.PI / 180.0 * ((282.937348 + 1.7195366 * num1 + 0.00045688 * num2) % 360.0);
      double num5 = 0.01670843 - 4.2037E-05 * num1 - 1.267E-07 * num2;
      double num6 = num3 - num4;
      double d = num6;
      double num7;
      do
      {
        num7 = d;
        d = num7 + (num6 + num5 * Math.Sin(num7) - num7) / (1.0 - num5 * Math.Cos(num7));
      }
      while (Math.Abs(d - num7) > 1E-09);
      double num8 = 2.0 * Math.Atan(Math.Sqrt((1.0 + num5) / (1.0 - num5)) * Math.Tan(0.5 * d));
      double num9 = num4 + num8;
      this._distanceUA = 1.000001018 * (1.0 - num5 * Math.Cos(d));
      double num10 = this._distanceUA * 149597870.0;
      double num11 = Math.PI / 180.0 * (84381.448 - 46.815 * num1 - 0.00059 * num2 + 0.001813 * num1 * num2) * 0.000277777777777778;
      double num12 = num10 * Math.Sin(num9);
      this._position = new Vecteur(num10 * Math.Cos(num9), num12 * Math.Cos(num11), num12 * Math.Sin(num11));
    }

    public double DistanceUA => this._distanceUA;
  }
}
