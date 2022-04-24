// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.GoogleEarthControl
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  [ComVisible(true)]
  public class GoogleEarthControl : UserControl
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private WebBrowser WebBrowser2;
    private StatusStrip StatusStrip2;
    private ToolStripButton GoToSat;
    private ToolStripButton GoToGround;
    private ToolStripButton InitialView;
    private ToolStripButton EarthGrid;
    private ToolStripButton Borders;
    private ToolStripButton Nav;

    [DebuggerNonUserCode]
    static GoogleEarthControl()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (GoogleEarthControl.__ENCList)
      {
        if (GoogleEarthControl.__ENCList.Count == GoogleEarthControl.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (GoogleEarthControl.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (GoogleEarthControl.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                GoogleEarthControl.__ENCList[index1] = GoogleEarthControl.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          GoogleEarthControl.__ENCList.RemoveRange(index1, checked (GoogleEarthControl.__ENCList.Count - index1));
          GoogleEarthControl.__ENCList.Capacity = GoogleEarthControl.__ENCList.Count;
        }
        GoogleEarthControl.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    private void GoogleEarthControl_Load(object sender, EventArgs e) => this.WebBrowser2.DocumentText = MyProject.Computer.FileSystem.ReadAllText(MyProject.Forms.Home.GOOGLEPath + "GoogleEarth.htm");

    public GoogleEarthControl()
    {
      this.Load += new EventHandler(this.GoogleEarthControl_Load);
      GoogleEarthControl.__ENCAddToList((object) this);
      this.WebBrowser2 = new WebBrowser();
      this.StatusStrip2 = new StatusStrip();
      this.GoToSat = new ToolStripButton();
      this.GoToGround = new ToolStripButton();
      this.InitialView = new ToolStripButton();
      this.EarthGrid = new ToolStripButton();
      this.Borders = new ToolStripButton();
      this.Nav = new ToolStripButton();
      this.WebBrowser2.Dock = DockStyle.Fill;
      this.WebBrowser2.AllowWebBrowserDrop = false;
      this.WebBrowser2.IsWebBrowserContextMenuEnabled = false;
      this.WebBrowser2.WebBrowserShortcutsEnabled = false;
      this.WebBrowser2.ObjectForScripting = (object) this;
      this.WebBrowser2.ScriptErrorsSuppressed = true;
      this.StatusStrip2.Dock = DockStyle.Bottom;
      this.StatusStrip2.Items.Add((ToolStripItem) this.InitialView);
      this.StatusStrip2.Items.Add((ToolStripItem) new ToolStripSeparator());
      this.StatusStrip2.Items.Add((ToolStripItem) this.GoToSat);
      this.StatusStrip2.Items.Add((ToolStripItem) new ToolStripSeparator());
      this.StatusStrip2.Items.Add((ToolStripItem) this.GoToGround);
      this.StatusStrip2.Items.Add((ToolStripItem) new ToolStripSeparator());
      this.StatusStrip2.Items.Add((ToolStripItem) this.EarthGrid);
      this.StatusStrip2.Items.Add((ToolStripItem) new ToolStripSeparator());
      this.StatusStrip2.Items.Add((ToolStripItem) this.Borders);
      this.StatusStrip2.Items.Add((ToolStripItem) new ToolStripSeparator());
      this.StatusStrip2.Items.Add((ToolStripItem) this.Nav);
      this.StatusStrip2.Items.Add((ToolStripItem) new ToolStripSeparator());
      this.GoToSat.Text = "Go to Satellite";
      this.GoToSat.Click += new EventHandler(this.GoToSat_Click);
      this.GoToGround.Text = "Go to Ground Point";
      this.GoToGround.Click += new EventHandler(this.GoToGround_Click);
      this.InitialView.Text = "Initial View";
      this.InitialView.Click += new EventHandler(this.InitialView_Click);
      this.EarthGrid.Text = "Grid On";
      this.EarthGrid.Click += new EventHandler(this.EarthGrid_Click);
      this.Borders.Text = "Borders On";
      this.Borders.Click += new EventHandler(this.Borders_Click);
      this.Nav.Text = "Show Nav";
      this.Nav.Click += new EventHandler(this.Nav_Click);
      this.Controls.Add((Control) this.WebBrowser2);
      this.Controls.Add((Control) this.StatusStrip2);
    }

    public void addTrace()
    {
      if (!MyProject.Forms.Home.MAP_ShowTrack.Checked)
        return;
      this.WebBrowser2.Document.InvokeScript("AddTrace");
    }

    public void addSat() => this.WebBrowser2.Document.InvokeScript(nameof (addSat), new object[5]
    {
      (object) MyProject.Forms.Home.SATNAME,
      (object) MyProject.Forms.Home.LAT,
      (object) MyProject.Forms.Home.LONGI,
      (object) (MyProject.Forms.Home.ALT * 1000.0),
      RuntimeHelpers.GetObjectValue((object) (Functions.MJDGGEDate(MyProject.Forms.Home.EPOCH) + "T" + Functions.MJDGGEHour(MyProject.Forms.Home.EPOCH) + "Z"))
    });

    public void AddLineToStation(
      int i,
      double latsa,
      double lngsa,
      double altsa,
      double latst,
      double lngst,
      double altst)
    {
      this.WebBrowser2.Document.InvokeScript(nameof (AddLineToStation), new object[7]
      {
        (object) i,
        (object) latsa,
        (object) lngsa,
        (object) (altsa * 1000.0),
        (object) latst,
        (object) lngst,
        (object) altst
      });
    }

    public void delLineToStation(int i) => this.WebBrowser2.Document.InvokeScript(nameof (delLineToStation), new object[1]
    {
      (object) i
    });

    public void InitOrb() => this.WebBrowser2.Document.InvokeScript(nameof (InitOrb));

    public void addStations(string name, double lat, double lng, double alt) => this.WebBrowser2.Document.InvokeScript(nameof (addStations), new object[4]
    {
      (object) name,
      (object) lat,
      (object) lng,
      (object) alt
    });

    public void delStations(object i) => this.WebBrowser2.Document.InvokeScript(nameof (delStations), new object[1]
    {
      (object) MyProject.Forms.Home.Stations[Conversions.ToInteger(i), 0]
    });

    public void addMoreSat(string name, double lat, double lng, double alt) => this.WebBrowser2.Document.InvokeScript(nameof (addMoreSat), new object[4]
    {
      (object) name,
      (object) lat,
      (object) lng,
      (object) alt
    });

    public void delSat(string name) => this.WebBrowser2.Document.InvokeScript(nameof (delSat), new object[1]
    {
      (object) name
    });

    public void CreateTrace()
    {
      object Counter;
      object LoopForResult;
      object CounterResult;
      if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(Counter, (object) 0, Operators.MultiplyObject((object) 360, MyProject.Forms.Home.MAP_Num_Period.SelectedItem), (object) 1, ref LoopForResult, ref CounterResult))
        return;
      do
      {
        this.WebBrowser2.Document.InvokeScript(nameof (CreateTrace), new object[3]
        {
          RuntimeHelpers.GetObjectValue(MyProject.Forms.Home.SatTrace[Conversions.ToInteger(CounterResult), 2]),
          RuntimeHelpers.GetObjectValue(MyProject.Forms.Home.SatTrace[Conversions.ToInteger(CounterResult), 3]),
          RuntimeHelpers.GetObjectValue(MyProject.Forms.Home.SatTrace[Conversions.ToInteger(CounterResult), 4])
        });
        MyProject.Forms.Home.ProgressBar.Value = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(CounterResult, (object) 100), Operators.MultiplyObject((object) 360, MyProject.Forms.Home.MAP_Num_Period.SelectedItem)));
      }
      while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
    }

    public void DeleteTrace() => this.WebBrowser2.Document.InvokeScript(nameof (DeleteTrace));

    private void GoToSat_Click(object sender, EventArgs e) => this.GoToSatF();

    public void GoToSatF()
    {
      object obj1;
      if (MyProject.Forms.Home.ALT < 1000.0)
        obj1 = (object) 70;
      else if (MyProject.Forms.Home.ALT > 1000.0 & MyProject.Forms.Home.ALT < 20000.0)
        obj1 = (object) 30;
      else if (MyProject.Forms.Home.ALT > 20000.0)
        obj1 = (object) 0;
      object obj2;
      if (MyProject.Forms.Home.INC > 90.0)
        obj2 = (object) (MyProject.Forms.Home.INC - 90.0 + 20.0);
      else if (MyProject.Forms.Home.INC < 90.0)
        obj2 = (object) -(90.0 - MyProject.Forms.Home.INC - 20.0);
      this.WebBrowser2.Document.InvokeScript("GoToSat", new object[5]
      {
        (object) MyProject.Forms.Home.LAT,
        (object) MyProject.Forms.Home.LONGI,
        (object) (MyProject.Forms.Home.ALT * 1000.0),
        RuntimeHelpers.GetObjectValue(obj1),
        RuntimeHelpers.GetObjectValue(obj2)
      });
    }

    private void GoToGround_Click(object sender, EventArgs e) => this.WebBrowser2.Document.InvokeScript("GoToSat", new object[5]
    {
      (object) MyProject.Forms.Home.LAT,
      (object) MyProject.Forms.Home.LONGI,
      (object) 10000,
      (object) 0,
      (object) 0
    });

    private void InitialView_Click(object sender, EventArgs e)
    {
      if (!MyProject.Forms.Home.CheckNW)
        return;
      this.InitialViewF();
    }

    public object InitialViewF()
    {
      if (MyProject.Forms.Home.CheckNW)
      {
        object obj;
        if (MyProject.Forms.Home.ALT < 2000.0)
          obj = (object) 13000000;
        else if (MyProject.Forms.Home.ALT > 2000.0)
          obj = (object) 63000000;
        this.WebBrowser2.Document.InvokeScript("InitialView", new object[4]
        {
          (object) MyProject.Forms.Home.LAT,
          (object) MyProject.Forms.Home.LONGI,
          (object) MyProject.Forms.Home.ALT,
          RuntimeHelpers.GetObjectValue(obj)
        });
      }
      object obj1;
      return obj1;
    }

    private void EarthGrid_Click(object sender, EventArgs e)
    {
      if (!MyProject.Forms.Home.CheckNW)
        return;
      bool flag;
      if (Operators.CompareString(this.EarthGrid.Text, "Grid OFF", false) == 0)
      {
        flag = false;
        this.EarthGrid.Text = "Grid ON";
      }
      else
      {
        flag = true;
        this.EarthGrid.Text = "Grid OFF";
      }
      this.WebBrowser2.Document.InvokeScript("EarthGrid", new object[1]
      {
        (object) flag
      });
    }

    private void Borders_Click(object sender, EventArgs e)
    {
      if (!MyProject.Forms.Home.CheckNW)
        return;
      bool flag;
      if (Operators.CompareString(this.Borders.Text, "Borders OFF", false) == 0)
      {
        flag = false;
        this.Borders.Text = "Borders ON";
      }
      else
      {
        flag = true;
        this.Borders.Text = "Borders OFF";
      }
      this.WebBrowser2.Document.InvokeScript("Borders", new object[1]
      {
        (object) flag
      });
    }

    private void Nav_Click(object sender, EventArgs e)
    {
      if (!MyProject.Forms.Home.CheckNW)
        return;
      bool flag;
      if (Operators.CompareString(this.Nav.Text, "Show Nav", false) == 0)
      {
        flag = true;
        this.Nav.Text = "Hide Nav";
      }
      else
      {
        flag = false;
        this.Nav.Text = "Show Nav";
      }
      this.WebBrowser2.Document.InvokeScript("Navigation", new object[1]
      {
        (object) flag
      });
    }

    public void DrawSun()
    {
      if (!MyProject.Forms.Home.CheckNW)
        return;
      this.WebBrowser2.Document.InvokeScript("Sun", new object[2]
      {
        (object) MyProject.Forms.Home.MAP_NightShadow.Checked,
        RuntimeHelpers.GetObjectValue((object) (Functions.MJDGGEDate(MyProject.Forms.Home.EPOCH) + "T" + Functions.MJDGGEHour(MyProject.Forms.Home.EPOCH) + "Z"))
      });
    }
  }
}
