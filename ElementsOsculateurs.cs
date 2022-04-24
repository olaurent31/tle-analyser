// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.ElementsOsculateurs
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using System.Diagnostics;

namespace TLE_Analyser
{
  public class ElementsOsculateurs
  {
    protected internal double _demiGrandAxe;
    protected internal double _excentricite;
    protected internal double _inclinaison;
    protected internal double _ascDroiteNA;
    protected internal double _argumentPerigee;
    protected internal double _anomalieVraie;
    protected internal double _anomalieMoyenne;
    protected internal double _anomalieExcentrique;
    protected internal double _apogee;
    protected internal double _perigee;
    protected internal double _periode;

    [DebuggerNonUserCode]
    public ElementsOsculateurs()
    {
    }

    public double AnomalieExcentrique => this._anomalieExcentrique;

    public double AnomalieMoyenne => this._anomalieMoyenne;

    public double AnomalieVraie => this._anomalieVraie;

    public double Apogee => this._apogee;

    public double ArgumentPerigee => this._argumentPerigee;

    public double AscDroiteNA => this._ascDroiteNA;

    public double DemiGrandAxe => this._demiGrandAxe;

    public double Excentricite => this._excentricite;

    public double Inclinaison => this._inclinaison;

    public double Perigee => this._perigee;

    public double Periode => this._periode;
  }
}
