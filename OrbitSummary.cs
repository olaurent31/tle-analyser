// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.OrbitSummary
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TLE_Analyser
{
  [DesignerGenerated]
  public class OrbitSummary : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("SUM_Close")]
    private Button _SUM_Close;
    [AccessedThroughProperty("SUM_Summary")]
    private TextBox _SUM_Summary;
    [AccessedThroughProperty("SUM_Copy")]
    private Button _SUM_Copy;

    [DebuggerNonUserCode]
    static OrbitSummary()
    {
    }

    [DebuggerNonUserCode]
    public OrbitSummary()
    {
      OrbitSummary.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (OrbitSummary.__ENCList)
      {
        if (OrbitSummary.__ENCList.Count == OrbitSummary.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (OrbitSummary.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (OrbitSummary.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                OrbitSummary.__ENCList[index1] = OrbitSummary.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          OrbitSummary.__ENCList.RemoveRange(index1, checked (OrbitSummary.__ENCList.Count - index1));
          OrbitSummary.__ENCList.Capacity = OrbitSummary.__ENCList.Count;
        }
        OrbitSummary.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (OrbitSummary));
      this.SUM_Close = new Button();
      this.SUM_Summary = new TextBox();
      this.SUM_Copy = new Button();
      this.SuspendLayout();
      this.SUM_Close.ImeMode = ImeMode.NoControl;
      Button sumClose1 = this.SUM_Close;
      Point point1 = new Point(248, 509);
      Point point2 = point1;
      sumClose1.Location = point2;
      this.SUM_Close.Name = "SUM_Close";
      Button sumClose2 = this.SUM_Close;
      Size size1 = new Size(75, 23);
      Size size2 = size1;
      sumClose2.Size = size2;
      this.SUM_Close.TabIndex = 36;
      this.SUM_Close.Text = "Close";
      this.SUM_Close.UseVisualStyleBackColor = true;
      this.SUM_Summary.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      TextBox sumSummary1 = this.SUM_Summary;
      point1 = new Point(13, 12);
      Point point3 = point1;
      sumSummary1.Location = point3;
      this.SUM_Summary.Multiline = true;
      this.SUM_Summary.Name = "SUM_Summary";
      this.SUM_Summary.ReadOnly = true;
      this.SUM_Summary.ScrollBars = ScrollBars.Vertical;
      TextBox sumSummary2 = this.SUM_Summary;
      size1 = new Size(310, 491);
      Size size3 = size1;
      sumSummary2.Size = size3;
      this.SUM_Summary.TabIndex = 37;
      this.SUM_Copy.ImeMode = ImeMode.NoControl;
      Button sumCopy1 = this.SUM_Copy;
      point1 = new Point(13, 509);
      Point point4 = point1;
      sumCopy1.Location = point4;
      this.SUM_Copy.Name = "SUM_Copy";
      Button sumCopy2 = this.SUM_Copy;
      size1 = new Size(140, 23);
      Size size4 = size1;
      sumCopy2.Size = size4;
      this.SUM_Copy.TabIndex = 39;
      this.SUM_Copy.Text = "Copy To Clipboard";
      this.SUM_Copy.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(335, 544);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.SUM_Copy);
      this.Controls.Add((Control) this.SUM_Summary);
      this.Controls.Add((Control) this.SUM_Close);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (OrbitSummary);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Orbit Report";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button SUM_Close
    {
      [DebuggerNonUserCode] get => this._SUM_Close;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OrbSum_OK_Click);
        if (this._SUM_Close != null)
          this._SUM_Close.Click -= eventHandler;
        this._SUM_Close = value;
        if (this._SUM_Close == null)
          return;
        this._SUM_Close.Click += eventHandler;
      }
    }

    internal virtual TextBox SUM_Summary
    {
      [DebuggerNonUserCode] get => this._SUM_Summary;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SUM_Summary = value;
    }

    internal virtual Button SUM_Copy
    {
      [DebuggerNonUserCode] get => this._SUM_Copy;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CopySummary_Click);
        if (this._SUM_Copy != null)
          this._SUM_Copy.Click -= eventHandler;
        this._SUM_Copy = value;
        if (this._SUM_Copy == null)
          return;
        this._SUM_Copy.Click += eventHandler;
      }
    }

    private void OrbSum_OK_Click(object sender, EventArgs e) => this.Hide();

    private void Button1_Click(object sender, EventArgs e) => this.SUM_Summary.SelectAll();

    private void CopySummary_Click(object sender, EventArgs e)
    {
      this.SUM_Summary.SelectAll();
      this.SUM_Summary.Copy();
      this.SUM_Summary.DeselectAll();
    }
  }
}
