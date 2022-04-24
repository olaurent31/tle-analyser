// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.SplashScreen
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
using TLE_Analyser.My;

namespace TLE_Analyser
{
  [DesignerGenerated]
  public sealed class SplashScreen : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    [AccessedThroughProperty("Version")]
    private Label _Version;
    [AccessedThroughProperty("Copyright")]
    private Label _Copyright;
    [AccessedThroughProperty("MainLayoutPanel")]
    private TableLayoutPanel _MainLayoutPanel;
    private IContainer components;
    [AccessedThroughProperty("Details")]
    private Label _Details;

    [DebuggerNonUserCode]
    static SplashScreen()
    {
    }

    [DebuggerNonUserCode]
    public SplashScreen()
    {
      this.Load += new EventHandler(this.SplashScreen1_Load);
      SplashScreen.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (SplashScreen.__ENCList)
      {
        if (SplashScreen.__ENCList.Count == SplashScreen.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (SplashScreen.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (SplashScreen.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                SplashScreen.__ENCList[index1] = SplashScreen.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          SplashScreen.__ENCList.RemoveRange(index1, checked (SplashScreen.__ENCList.Count - index1));
          SplashScreen.__ENCList.Capacity = SplashScreen.__ENCList.Count;
        }
        SplashScreen.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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

    internal virtual Label Version
    {
      [DebuggerNonUserCode] get => this._Version;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Version = value;
    }

    internal virtual Label Copyright
    {
      [DebuggerNonUserCode] get => this._Copyright;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Copyright = value;
    }

    internal virtual TableLayoutPanel MainLayoutPanel
    {
      [DebuggerNonUserCode] get => this._MainLayoutPanel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MainLayoutPanel = value;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SplashScreen));
      this.MainLayoutPanel = new TableLayoutPanel();
      this.Copyright = new Label();
      this.Version = new Label();
      this.Details = new Label();
      this.MainLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      this.MainLayoutPanel.BackgroundImage = (Image) componentResourceManager.GetObject("MainLayoutPanel.BackgroundImage");
      this.MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
      this.MainLayoutPanel.ColumnCount = 2;
      this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226f));
      this.MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 270f));
      this.MainLayoutPanel.Controls.Add((Control) this.Copyright, 1, 0);
      this.MainLayoutPanel.Controls.Add((Control) this.Version, 0, 0);
      this.MainLayoutPanel.Controls.Add((Control) this.Details, 1, 1);
      this.MainLayoutPanel.Dock = DockStyle.Fill;
      this.MainLayoutPanel.ForeColor = Color.Transparent;
      TableLayoutPanel mainLayoutPanel1 = this.MainLayoutPanel;
      Point point1 = new Point(0, 0);
      Point point2 = point1;
      mainLayoutPanel1.Location = point2;
      this.MainLayoutPanel.Name = "MainLayoutPanel";
      this.MainLayoutPanel.RowCount = 2;
      this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 236f));
      this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 8f));
      this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 229f));
      this.MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44f));
      TableLayoutPanel mainLayoutPanel2 = this.MainLayoutPanel;
      Size size1 = new Size(496, 303);
      Size size2 = size1;
      mainLayoutPanel2.Size = size2;
      this.MainLayoutPanel.TabIndex = 0;
      this.Copyright.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.Copyright.BackColor = Color.Transparent;
      this.Copyright.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label copyright1 = this.Copyright;
      point1 = new Point(252, 0);
      Point point3 = point1;
      copyright1.Location = point3;
      this.Copyright.Name = "Copyright";
      Label copyright2 = this.Copyright;
      size1 = new Size(241, 17);
      Size size3 = size1;
      copyright2.Size = size3;
      this.Copyright.TabIndex = 2;
      this.Copyright.Text = "Copyright";
      this.Copyright.TextAlign = ContentAlignment.TopRight;
      this.Version.BackColor = Color.Transparent;
      this.Version.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      Label version1 = this.Version;
      point1 = new Point(3, 0);
      Point point4 = point1;
      version1.Location = point4;
      this.Version.Name = "Version";
      Label version2 = this.Version;
      size1 = new Size(220, 17);
      Size size4 = size1;
      version2.Size = size4;
      this.Version.TabIndex = 1;
      this.Version.Text = "Version {0}.{1:0}";
      this.Details.Anchor = AnchorStyles.Top;
      this.Details.AutoSize = true;
      this.Details.BackColor = Color.Transparent;
      Label details1 = this.Details;
      point1 = new Point(341, 236);
      Point point5 = point1;
      details1.Location = point5;
      this.Details.Name = "Details";
      Label details2 = this.Details;
      size1 = new Size(39, 13);
      Size size5 = size1;
      details2.Size = size5;
      this.Details.TabIndex = 3;
      this.Details.Text = "Details";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(496, 303);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.MainLayoutPanel);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (SplashScreen);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.MainLayoutPanel.ResumeLayout(false);
      this.MainLayoutPanel.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual Label Details
    {
      [DebuggerNonUserCode] get => this._Details;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Details = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SplashScreen1_Load(object sender, EventArgs e)
    {
      this.Version.Text = string.Format(this.Version.Text, (object) MyProject.Application.Info.Version.Major, (object) MyProject.Application.Info.Version.Minor);
      this.Copyright.Text = MyProject.Application.Info.Copyright;
      this.Details.Text = MyProject.Application.Info.Description;
    }
  }
}
