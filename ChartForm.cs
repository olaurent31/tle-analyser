// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.ChartForm
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
using System.Windows.Forms.DataVisualization.Charting;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  [DesignerGenerated]
  public class ChartForm : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("CHART_TAB")]
    private TabControl _CHART_TAB;
    [AccessedThroughProperty("CHART_SMATab")]
    private TabPage _CHART_SMATab;
    [AccessedThroughProperty("CHART_ECCTab")]
    private TabPage _CHART_ECCTab;
    [AccessedThroughProperty("CHART_INCTab")]
    private TabPage _CHART_INCTab;
    [AccessedThroughProperty("GroupBox7")]
    private GroupBox _GroupBox7;
    [AccessedThroughProperty("CHART_SMA")]
    private CheckBox _CHART_SMA;
    [AccessedThroughProperty("CHART_ECC")]
    private CheckBox _CHART_ECC;
    [AccessedThroughProperty("CHART_INC")]
    private CheckBox _CHART_INC;
    [AccessedThroughProperty("CHARTS_OK")]
    private Button _CHARTS_OK;
    [AccessedThroughProperty("CHARTS_Step")]
    private TextBox _CHARTS_Step;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("CHART_MALT")]
    private CheckBox _CHART_MALT;
    [AccessedThroughProperty("CHART_LNGTab")]
    private TabPage _CHART_LNGTab;
    [AccessedThroughProperty("CHART_MALTTab")]
    private TabPage _CHART_MALTTab;
    [AccessedThroughProperty("CHART_LNG")]
    private CheckBox _CHART_LNG;
    [AccessedThroughProperty("CHARTS_Close")]
    private Button _CHARTS_Close;
    [AccessedThroughProperty("CHARTS_Unit")]
    private ComboBox _CHARTS_Unit;
    [AccessedThroughProperty("CHART_APATab")]
    private TabPage _CHART_APATab;
    [AccessedThroughProperty("CHART_PEATab")]
    private TabPage _CHART_PEATab;
    [AccessedThroughProperty("CHART_APA")]
    private CheckBox _CHART_APA;
    [AccessedThroughProperty("CHART_PEA")]
    private CheckBox _CHART_PEA;
    [AccessedThroughProperty("Label64")]
    private Label _Label64;
    [AccessedThroughProperty("CHARTS_NumPeriod")]
    private CheckBox _CHARTS_NumPeriod;

    [DebuggerNonUserCode]
    static ChartForm()
    {
    }

    [DebuggerNonUserCode]
    public ChartForm()
    {
      ChartForm.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (ChartForm.__ENCList)
      {
        if (ChartForm.__ENCList.Count == ChartForm.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (ChartForm.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (ChartForm.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                ChartForm.__ENCList[index1] = ChartForm.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          ChartForm.__ENCList.RemoveRange(index1, checked (ChartForm.__ENCList.Count - index1));
          ChartForm.__ENCList.Capacity = ChartForm.__ENCList.Count;
        }
        ChartForm.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ChartForm));
      this.CHART_TAB = new TabControl();
      this.CHART_SMATab = new TabPage();
      this.CHART_ECCTab = new TabPage();
      this.CHART_INCTab = new TabPage();
      this.CHART_MALTTab = new TabPage();
      this.CHART_APATab = new TabPage();
      this.CHART_PEATab = new TabPage();
      this.CHART_LNGTab = new TabPage();
      this.GroupBox7 = new GroupBox();
      this.CHART_APA = new CheckBox();
      this.CHART_PEA = new CheckBox();
      this.CHART_LNG = new CheckBox();
      this.CHART_SMA = new CheckBox();
      this.CHART_ECC = new CheckBox();
      this.CHART_INC = new CheckBox();
      this.CHART_MALT = new CheckBox();
      this.CHARTS_OK = new Button();
      this.CHARTS_Step = new TextBox();
      this.Label5 = new Label();
      this.CHARTS_Close = new Button();
      this.CHARTS_Unit = new ComboBox();
      this.Label64 = new Label();
      this.CHARTS_NumPeriod = new CheckBox();
      this.CHART_TAB.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      this.SuspendLayout();
      this.CHART_TAB.Controls.Add((Control) this.CHART_SMATab);
      this.CHART_TAB.Controls.Add((Control) this.CHART_ECCTab);
      this.CHART_TAB.Controls.Add((Control) this.CHART_INCTab);
      this.CHART_TAB.Controls.Add((Control) this.CHART_MALTTab);
      this.CHART_TAB.Controls.Add((Control) this.CHART_APATab);
      this.CHART_TAB.Controls.Add((Control) this.CHART_PEATab);
      this.CHART_TAB.Controls.Add((Control) this.CHART_LNGTab);
      TabControl chartTab1 = this.CHART_TAB;
      Point point1 = new Point(169, 12);
      Point point2 = point1;
      chartTab1.Location = point2;
      this.CHART_TAB.Name = "CHART_TAB";
      this.CHART_TAB.SelectedIndex = 0;
      TabControl chartTab2 = this.CHART_TAB;
      Size size1 = new Size(633, 450);
      Size size2 = size1;
      chartTab2.Size = size2;
      this.CHART_TAB.TabIndex = 0;
      this.CHART_SMATab.BackColor = SystemColors.Control;
      TabPage chartSmaTab1 = this.CHART_SMATab;
      point1 = new Point(4, 22);
      Point point3 = point1;
      chartSmaTab1.Location = point3;
      this.CHART_SMATab.Name = "CHART_SMATab";
      TabPage chartSmaTab2 = this.CHART_SMATab;
      Padding padding1 = new Padding(3);
      Padding padding2 = padding1;
      chartSmaTab2.Padding = padding2;
      TabPage chartSmaTab3 = this.CHART_SMATab;
      size1 = new Size(625, 424);
      Size size3 = size1;
      chartSmaTab3.Size = size3;
      this.CHART_SMATab.TabIndex = 0;
      this.CHART_SMATab.Text = "SMA";
      this.CHART_ECCTab.BackColor = SystemColors.Control;
      TabPage chartEccTab1 = this.CHART_ECCTab;
      point1 = new Point(4, 22);
      Point point4 = point1;
      chartEccTab1.Location = point4;
      this.CHART_ECCTab.Name = "CHART_ECCTab";
      TabPage chartEccTab2 = this.CHART_ECCTab;
      padding1 = new Padding(3);
      Padding padding3 = padding1;
      chartEccTab2.Padding = padding3;
      TabPage chartEccTab3 = this.CHART_ECCTab;
      size1 = new Size(625, 424);
      Size size4 = size1;
      chartEccTab3.Size = size4;
      this.CHART_ECCTab.TabIndex = 1;
      this.CHART_ECCTab.Text = "ECC";
      this.CHART_INCTab.BackColor = SystemColors.Control;
      TabPage chartIncTab1 = this.CHART_INCTab;
      point1 = new Point(4, 22);
      Point point5 = point1;
      chartIncTab1.Location = point5;
      this.CHART_INCTab.Name = "CHART_INCTab";
      TabPage chartIncTab2 = this.CHART_INCTab;
      padding1 = new Padding(3);
      Padding padding4 = padding1;
      chartIncTab2.Padding = padding4;
      TabPage chartIncTab3 = this.CHART_INCTab;
      size1 = new Size(625, 424);
      Size size5 = size1;
      chartIncTab3.Size = size5;
      this.CHART_INCTab.TabIndex = 2;
      this.CHART_INCTab.Text = "INC";
      this.CHART_MALTTab.BackColor = SystemColors.Control;
      TabPage chartMaltTab1 = this.CHART_MALTTab;
      point1 = new Point(4, 22);
      Point point6 = point1;
      chartMaltTab1.Location = point6;
      this.CHART_MALTTab.Name = "CHART_MALTTab";
      TabPage chartMaltTab2 = this.CHART_MALTTab;
      padding1 = new Padding(3);
      Padding padding5 = padding1;
      chartMaltTab2.Padding = padding5;
      TabPage chartMaltTab3 = this.CHART_MALTTab;
      size1 = new Size(625, 424);
      Size size6 = size1;
      chartMaltTab3.Size = size6;
      this.CHART_MALTTab.TabIndex = 4;
      this.CHART_MALTTab.Text = "ALT";
      this.CHART_APATab.BackColor = SystemColors.Control;
      TabPage chartApaTab1 = this.CHART_APATab;
      point1 = new Point(4, 22);
      Point point7 = point1;
      chartApaTab1.Location = point7;
      this.CHART_APATab.Name = "CHART_APATab";
      TabPage chartApaTab2 = this.CHART_APATab;
      padding1 = new Padding(3);
      Padding padding6 = padding1;
      chartApaTab2.Padding = padding6;
      TabPage chartApaTab3 = this.CHART_APATab;
      size1 = new Size(625, 424);
      Size size7 = size1;
      chartApaTab3.Size = size7;
      this.CHART_APATab.TabIndex = 5;
      this.CHART_APATab.Text = "APA";
      this.CHART_PEATab.BackColor = SystemColors.Control;
      TabPage chartPeaTab1 = this.CHART_PEATab;
      point1 = new Point(4, 22);
      Point point8 = point1;
      chartPeaTab1.Location = point8;
      this.CHART_PEATab.Name = "CHART_PEATab";
      TabPage chartPeaTab2 = this.CHART_PEATab;
      padding1 = new Padding(3);
      Padding padding7 = padding1;
      chartPeaTab2.Padding = padding7;
      TabPage chartPeaTab3 = this.CHART_PEATab;
      size1 = new Size(625, 424);
      Size size8 = size1;
      chartPeaTab3.Size = size8;
      this.CHART_PEATab.TabIndex = 6;
      this.CHART_PEATab.Text = "PEA";
      this.CHART_LNGTab.BackColor = SystemColors.Control;
      TabPage chartLngTab1 = this.CHART_LNGTab;
      point1 = new Point(4, 22);
      Point point9 = point1;
      chartLngTab1.Location = point9;
      this.CHART_LNGTab.Name = "CHART_LNGTab";
      TabPage chartLngTab2 = this.CHART_LNGTab;
      padding1 = new Padding(3);
      Padding padding8 = padding1;
      chartLngTab2.Padding = padding8;
      TabPage chartLngTab3 = this.CHART_LNGTab;
      size1 = new Size(625, 424);
      Size size9 = size1;
      chartLngTab3.Size = size9;
      this.CHART_LNGTab.TabIndex = 3;
      this.CHART_LNGTab.Text = "LNG";
      this.GroupBox7.Controls.Add((Control) this.CHART_APA);
      this.GroupBox7.Controls.Add((Control) this.CHART_PEA);
      this.GroupBox7.Controls.Add((Control) this.CHART_LNG);
      this.GroupBox7.Controls.Add((Control) this.CHART_SMA);
      this.GroupBox7.Controls.Add((Control) this.CHART_ECC);
      this.GroupBox7.Controls.Add((Control) this.CHART_INC);
      this.GroupBox7.Controls.Add((Control) this.CHART_MALT);
      GroupBox groupBox7_1 = this.GroupBox7;
      point1 = new Point(12, 12);
      Point point10 = point1;
      groupBox7_1.Location = point10;
      this.GroupBox7.Name = "GroupBox7";
      GroupBox groupBox7_2 = this.GroupBox7;
      size1 = new Size(151, 200);
      Size size10 = size1;
      groupBox7_2.Size = size10;
      this.GroupBox7.TabIndex = 1;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "Datas Vs Elapsed Time";
      this.CHART_APA.AutoSize = true;
      this.CHART_APA.Checked = true;
      this.CHART_APA.CheckState = CheckState.Checked;
      CheckBox chartApa1 = this.CHART_APA;
      point1 = new Point(35, 120);
      Point point11 = point1;
      chartApa1.Location = point11;
      this.CHART_APA.Name = "CHART_APA";
      CheckBox chartApa2 = this.CHART_APA;
      size1 = new Size(47, 17);
      Size size11 = size1;
      chartApa2.Size = size11;
      this.CHART_APA.TabIndex = 5;
      this.CHART_APA.Text = "APA";
      this.CHART_APA.UseVisualStyleBackColor = true;
      this.CHART_PEA.AutoSize = true;
      this.CHART_PEA.Checked = true;
      this.CHART_PEA.CheckState = CheckState.Checked;
      CheckBox chartPea1 = this.CHART_PEA;
      point1 = new Point(35, 143);
      Point point12 = point1;
      chartPea1.Location = point12;
      this.CHART_PEA.Name = "CHART_PEA";
      CheckBox chartPea2 = this.CHART_PEA;
      size1 = new Size(47, 17);
      Size size12 = size1;
      chartPea2.Size = size12;
      this.CHART_PEA.TabIndex = 6;
      this.CHART_PEA.Text = "PEA";
      this.CHART_PEA.UseVisualStyleBackColor = true;
      this.CHART_LNG.AutoSize = true;
      CheckBox chartLng1 = this.CHART_LNG;
      point1 = new Point(35, 166);
      Point point13 = point1;
      chartLng1.Location = point13;
      this.CHART_LNG.Name = "CHART_LNG";
      CheckBox chartLng2 = this.CHART_LNG;
      size1 = new Size(48, 17);
      Size size13 = size1;
      chartLng2.Size = size13;
      this.CHART_LNG.TabIndex = 4;
      this.CHART_LNG.Text = "LNG";
      this.CHART_LNG.UseVisualStyleBackColor = true;
      this.CHART_SMA.AutoSize = true;
      this.CHART_SMA.Checked = true;
      this.CHART_SMA.CheckState = CheckState.Checked;
      CheckBox chartSma1 = this.CHART_SMA;
      point1 = new Point(35, 28);
      Point point14 = point1;
      chartSma1.Location = point14;
      this.CHART_SMA.Name = "CHART_SMA";
      CheckBox chartSma2 = this.CHART_SMA;
      size1 = new Size(49, 17);
      Size size14 = size1;
      chartSma2.Size = size14;
      this.CHART_SMA.TabIndex = 0;
      this.CHART_SMA.Text = "SMA";
      this.CHART_SMA.UseVisualStyleBackColor = true;
      this.CHART_ECC.AutoSize = true;
      this.CHART_ECC.Checked = true;
      this.CHART_ECC.CheckState = CheckState.Checked;
      CheckBox chartEcc1 = this.CHART_ECC;
      point1 = new Point(35, 51);
      Point point15 = point1;
      chartEcc1.Location = point15;
      this.CHART_ECC.Name = "CHART_ECC";
      CheckBox chartEcc2 = this.CHART_ECC;
      size1 = new Size(47, 17);
      Size size15 = size1;
      chartEcc2.Size = size15;
      this.CHART_ECC.TabIndex = 1;
      this.CHART_ECC.Text = "ECC";
      this.CHART_ECC.UseVisualStyleBackColor = true;
      this.CHART_INC.AutoSize = true;
      this.CHART_INC.Checked = true;
      this.CHART_INC.CheckState = CheckState.Checked;
      CheckBox chartInc1 = this.CHART_INC;
      point1 = new Point(35, 74);
      Point point16 = point1;
      chartInc1.Location = point16;
      this.CHART_INC.Name = "CHART_INC";
      CheckBox chartInc2 = this.CHART_INC;
      size1 = new Size(44, 17);
      Size size16 = size1;
      chartInc2.Size = size16;
      this.CHART_INC.TabIndex = 2;
      this.CHART_INC.Text = "INC";
      this.CHART_INC.UseVisualStyleBackColor = true;
      this.CHART_MALT.AutoSize = true;
      this.CHART_MALT.Checked = true;
      this.CHART_MALT.CheckState = CheckState.Checked;
      CheckBox chartMalt1 = this.CHART_MALT;
      point1 = new Point(35, 97);
      Point point17 = point1;
      chartMalt1.Location = point17;
      this.CHART_MALT.Name = "CHART_MALT";
      CheckBox chartMalt2 = this.CHART_MALT;
      size1 = new Size(46, 17);
      Size size17 = size1;
      chartMalt2.Size = size17;
      this.CHART_MALT.TabIndex = 3;
      this.CHART_MALT.Text = "ALT";
      this.CHART_MALT.UseVisualStyleBackColor = true;
      this.CHARTS_OK.BackColor = SystemColors.Control;
      this.CHARTS_OK.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CHARTS_OK.ImeMode = ImeMode.NoControl;
      Button chartsOk1 = this.CHARTS_OK;
      point1 = new Point(49, 310);
      Point point18 = point1;
      chartsOk1.Location = point18;
      this.CHARTS_OK.Name = "CHARTS_OK";
      Button chartsOk2 = this.CHARTS_OK;
      size1 = new Size(75, 23);
      Size size18 = size1;
      chartsOk2.Size = size18;
      this.CHARTS_OK.TabIndex = 100;
      this.CHARTS_OK.Text = "OK";
      this.CHARTS_OK.UseVisualStyleBackColor = true;
      TextBox chartsStep1 = this.CHARTS_Step;
      point1 = new Point(22, 246);
      Point point19 = point1;
      chartsStep1.Location = point19;
      this.CHARTS_Step.MaxLength = 4;
      this.CHARTS_Step.Name = "CHARTS_Step";
      TextBox chartsStep2 = this.CHARTS_Step;
      size1 = new Size(38, 20);
      Size size19 = size1;
      chartsStep2.Size = size19;
      this.CHARTS_Step.TabIndex = 7;
      this.CHARTS_Step.Text = "24";
      this.CHARTS_Step.TextAlign = HorizontalAlignment.Center;
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(55, 229);
      Point point20 = point1;
      label5_1.Location = point20;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(69, 13);
      Size size20 = size1;
      label5_2.Size = size20;
      this.Label5.TabIndex = 4;
      this.Label5.Text = "Generate on ";
      this.CHARTS_Close.BackColor = SystemColors.Control;
      this.CHARTS_Close.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CHARTS_Close.ImeMode = ImeMode.NoControl;
      Button chartsClose1 = this.CHARTS_Close;
      point1 = new Point(49, 435);
      Point point21 = point1;
      chartsClose1.Location = point21;
      this.CHARTS_Close.Name = "CHARTS_Close";
      Button chartsClose2 = this.CHARTS_Close;
      size1 = new Size(75, 23);
      Size size21 = size1;
      chartsClose2.Size = size21;
      this.CHARTS_Close.TabIndex = 101;
      this.CHARTS_Close.Text = "Close";
      this.CHARTS_Close.UseVisualStyleBackColor = false;
      this.CHARTS_Unit.FormattingEnabled = true;
      this.CHARTS_Unit.Items.AddRange(new object[5]
      {
        (object) "min",
        (object) "hrs",
        (object) "periods",
        (object) "days",
        (object) "years"
      });
      ComboBox chartsUnit1 = this.CHARTS_Unit;
      point1 = new Point(66, 245);
      Point point22 = point1;
      chartsUnit1.Location = point22;
      this.CHARTS_Unit.Name = "CHARTS_Unit";
      ComboBox chartsUnit2 = this.CHARTS_Unit;
      size1 = new Size(87, 21);
      Size size22 = size1;
      chartsUnit2.Size = size22;
      this.CHARTS_Unit.TabIndex = 102;
      this.Label64.AutoSize = true;
      this.Label64.ForeColor = Color.Red;
      this.Label64.ImeMode = ImeMode.NoControl;
      Label label64_1 = this.Label64;
      point1 = new Point(19, 350);
      Point point23 = point1;
      label64_1.Location = point23;
      this.Label64.Name = "Label64";
      Label label64_2 = this.Label64;
      size1 = new Size(136, 65);
      Size size23 = size1;
      label64_2.Size = size23;
      this.Label64.TabIndex = 119;
      this.Label64.Text = "- Propagation estimation \r\n   is ~ realistic until 10 days.\r\n\r\n- The plots start at current\r\n   ascending node.";
      this.CHARTS_NumPeriod.AutoSize = true;
      this.CHARTS_NumPeriod.Enabled = false;
      CheckBox chartsNumPeriod1 = this.CHARTS_NumPeriod;
      point1 = new Point(39, 272);
      Point point24 = point1;
      chartsNumPeriod1.Location = point24;
      this.CHARTS_NumPeriod.Name = "CHARTS_NumPeriod";
      CheckBox chartsNumPeriod2 = this.CHARTS_NumPeriod;
      size1 = new Size(108, 17);
      Size size24 = size1;
      chartsNumPeriod2.Size = size24;
      this.CHARTS_NumPeriod.TabIndex = 120;
      this.CHARTS_NumPeriod.Text = "Number of Period";
      this.CHARTS_NumPeriod.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(814, 474);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.CHARTS_NumPeriod);
      this.Controls.Add((Control) this.Label64);
      this.Controls.Add((Control) this.CHARTS_Unit);
      this.Controls.Add((Control) this.CHARTS_Close);
      this.Controls.Add((Control) this.GroupBox7);
      this.Controls.Add((Control) this.CHARTS_OK);
      this.Controls.Add((Control) this.CHART_TAB);
      this.Controls.Add((Control) this.CHARTS_Step);
      this.Controls.Add((Control) this.Label5);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (ChartForm);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "XY Plots";
      this.TopMost = true;
      this.CHART_TAB.ResumeLayout(false);
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TabControl CHART_TAB
    {
      [DebuggerNonUserCode] get => this._CHART_TAB;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_TAB = value;
    }

    internal virtual TabPage CHART_SMATab
    {
      [DebuggerNonUserCode] get => this._CHART_SMATab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_SMATab = value;
    }

    internal virtual TabPage CHART_ECCTab
    {
      [DebuggerNonUserCode] get => this._CHART_ECCTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_ECCTab = value;
    }

    internal virtual TabPage CHART_INCTab
    {
      [DebuggerNonUserCode] get => this._CHART_INCTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_INCTab = value;
    }

    internal virtual GroupBox GroupBox7
    {
      [DebuggerNonUserCode] get => this._GroupBox7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox7 = value;
    }

    internal virtual CheckBox CHART_SMA
    {
      [DebuggerNonUserCode] get => this._CHART_SMA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_SMA = value;
    }

    internal virtual CheckBox CHART_ECC
    {
      [DebuggerNonUserCode] get => this._CHART_ECC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_ECC = value;
    }

    internal virtual CheckBox CHART_INC
    {
      [DebuggerNonUserCode] get => this._CHART_INC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_INC = value;
    }

    internal virtual Button CHARTS_OK
    {
      [DebuggerNonUserCode] get => this._CHARTS_OK;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChartButton_Click);
        if (this._CHARTS_OK != null)
          this._CHARTS_OK.Click -= eventHandler;
        this._CHARTS_OK = value;
        if (this._CHARTS_OK == null)
          return;
        this._CHARTS_OK.Click += eventHandler;
      }
    }

    internal virtual TextBox CHARTS_Step
    {
      [DebuggerNonUserCode] get => this._CHARTS_Step;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.Chart_Days_KeyPress);
        if (this._CHARTS_Step != null)
          this._CHARTS_Step.KeyPress -= pressEventHandler;
        this._CHARTS_Step = value;
        if (this._CHARTS_Step == null)
          return;
        this._CHARTS_Step.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual CheckBox CHART_MALT
    {
      [DebuggerNonUserCode] get => this._CHART_MALT;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_MALT = value;
    }

    internal virtual TabPage CHART_LNGTab
    {
      [DebuggerNonUserCode] get => this._CHART_LNGTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_LNGTab = value;
    }

    internal virtual TabPage CHART_MALTTab
    {
      [DebuggerNonUserCode] get => this._CHART_MALTTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_MALTTab = value;
    }

    internal virtual CheckBox CHART_LNG
    {
      [DebuggerNonUserCode] get => this._CHART_LNG;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_LNG = value;
    }

    internal virtual Button CHARTS_Close
    {
      [DebuggerNonUserCode] get => this._CHARTS_Close;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CloseButton_Click);
        if (this._CHARTS_Close != null)
          this._CHARTS_Close.Click -= eventHandler;
        this._CHARTS_Close = value;
        if (this._CHARTS_Close == null)
          return;
        this._CHARTS_Close.Click += eventHandler;
      }
    }

    internal virtual ComboBox CHARTS_Unit
    {
      [DebuggerNonUserCode] get => this._CHARTS_Unit;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ChartXvalue_SelectedIndexChanged);
        if (this._CHARTS_Unit != null)
          this._CHARTS_Unit.SelectedIndexChanged -= eventHandler;
        this._CHARTS_Unit = value;
        if (this._CHARTS_Unit == null)
          return;
        this._CHARTS_Unit.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual TabPage CHART_APATab
    {
      [DebuggerNonUserCode] get => this._CHART_APATab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_APATab = value;
    }

    internal virtual TabPage CHART_PEATab
    {
      [DebuggerNonUserCode] get => this._CHART_PEATab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_PEATab = value;
    }

    internal virtual CheckBox CHART_APA
    {
      [DebuggerNonUserCode] get => this._CHART_APA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_APA = value;
    }

    internal virtual CheckBox CHART_PEA
    {
      [DebuggerNonUserCode] get => this._CHART_PEA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHART_PEA = value;
    }

    internal virtual Label Label64
    {
      [DebuggerNonUserCode] get => this._Label64;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label64 = value;
    }

    internal virtual CheckBox CHARTS_NumPeriod
    {
      [DebuggerNonUserCode] get => this._CHARTS_NumPeriod;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CHARTS_NumPeriod = value;
    }

    public void SGP4Chart(double EPOCH_NEW, double TLEPOCH)
    {
      Satellite satellite = new Satellite(new TLE(MyProject.Forms.Home.LIGNE1, MyProject.Forms.Home.LIGNE2));
      satellite.CalculPosVit(Functions.MJD2JJ(EPOCH_NEW), TLEPOCH);
      MyProject.Forms.Home.XC = satellite.Position.X;
      MyProject.Forms.Home.YC = satellite.Position.Y;
      MyProject.Forms.Home.ZC = satellite.Position.Z;
      MyProject.Forms.Home.VXC = satellite.Vitesse.X;
      MyProject.Forms.Home.VYC = satellite.Vitesse.Y;
      MyProject.Forms.Home.VZC = satellite.Vitesse.Z;
      Functions.CartesianToKeplerianChart(MyProject.Forms.Home.XC, MyProject.Forms.Home.YC, MyProject.Forms.Home.ZC, MyProject.Forms.Home.VXC, MyProject.Forms.Home.VYC, MyProject.Forms.Home.VZC);
    }

    private void ChartButton_Click(object sender, EventArgs e)
    {
      Chart chart1 = new Chart();
      Chart chart2 = new Chart();
      Chart chart3 = new Chart();
      Chart chart4 = new Chart();
      Chart chart5 = new Chart();
      Chart chart6 = new Chart();
      Chart chart7 = new Chart();
      this.Cursor = Cursors.WaitCursor;
      try
      {
        if (MyProject.Forms.Home.MM > 0.99 && MyProject.Forms.Home.MM < 1.01 && MyProject.Forms.Home.ECC < 0.01 && MyProject.Forms.Home.INC < 1.0)
        {
          this.CHART_LNG.Checked = true;
          this.CHART_LNG.Enabled = true;
        }
        else
        {
          this.CHART_LNG.Checked = false;
          this.CHART_LNG.Enabled = false;
        }
        if (!this.CHART_SMA.Checked & !this.CHART_ECC.Checked & !this.CHART_INC.Checked & !this.CHART_MALT.Checked & !this.CHART_APA.Checked & !this.CHART_PEA.Checked & !this.CHART_LNG.Checked)
          return;
        double anepoch = MyProject.Forms.Home.ANEPOCH;
        float a = Conversions.ToSingle(this.CHARTS_Step.Text);
        object Right1;
        object obj1;
        if (this.CHARTS_Unit.SelectedIndex == 0)
        {
          Right1 = (object) 0.000694444444444444;
          obj1 = (object) "Minutes";
        }
        else if (this.CHARTS_Unit.SelectedIndex == 1)
        {
          Right1 = (object) (1.0 / 24.0);
          obj1 = (object) "Hours";
        }
        else if (this.CHARTS_Unit.SelectedIndex == 2)
        {
          if (this.CHARTS_NumPeriod.Checked)
          {
            Right1 = (object) (MyProject.Forms.Home.DPER / 1440.0);
            obj1 = (object) "Periods";
          }
          else
          {
            Right1 = (object) 0.000694444444444444;
            a = (float) checked ((int) Math.Round(unchecked (Conversions.ToDouble(this.CHARTS_Step.Text) * MyProject.Forms.Home.DPER)));
            obj1 = (object) "Periods (min)";
          }
        }
        else if (this.CHARTS_Unit.SelectedIndex == 3)
        {
          Right1 = (object) 1;
          obj1 = (object) "Days";
        }
        else if (this.CHARTS_Unit.SelectedIndex == 4)
        {
          Right1 = (object) 365.25;
          obj1 = (object) "Years";
        }
        double[] array1 = new double[checked ((int) Math.Round((double) a) + 1)];
        double[] array2 = new double[checked ((int) Math.Round((double) a) + 1)];
        double[] array3 = new double[checked ((int) Math.Round((double) a) + 1)];
        double[] array4 = new double[checked ((int) Math.Round((double) a) + 1)];
        double[] array5 = new double[checked ((int) Math.Round((double) a) + 1)];
        double[] array6 = new double[checked ((int) Math.Round((double) a) + 1)];
        double[] array7 = new double[checked ((int) Math.Round((double) a) + 1)];
        object[,] objArray = new object[checked ((int) Math.Round((double) a) + 1), 2];
        ChartArea chartArea1 = new ChartArea();
        ChartArea chartArea2 = new ChartArea();
        ChartArea chartArea3 = new ChartArea();
        ChartArea chartArea4 = new ChartArea();
        ChartArea chartArea5 = new ChartArea();
        ChartArea chartArea6 = new ChartArea();
        ChartArea chartArea7 = new ChartArea();
        chart1.ChartAreas.Add(chartArea1);
        chart2.ChartAreas.Add(chartArea2);
        chart3.ChartAreas.Add(chartArea3);
        chart4.ChartAreas.Add(chartArea4);
        chart5.ChartAreas.Add(chartArea5);
        chart6.ChartAreas.Add(chartArea6);
        chart7.ChartAreas.Add(chartArea7);
        Series series1 = new Series();
        Series series2 = new Series();
        Series series3 = new Series();
        Series series4 = new Series();
        Series series5 = new Series();
        Series series6 = new Series();
        Series series7 = new Series();
        this.CHART_SMATab.Controls.Clear();
        this.CHART_ECCTab.Controls.Clear();
        this.CHART_INCTab.Controls.Clear();
        this.CHART_MALTTab.Controls.Clear();
        this.CHART_LNGTab.Controls.Clear();
        this.CHART_APATab.Controls.Clear();
        this.CHART_PEATab.Controls.Clear();
        float num1 = a;
        double yValue1;
        double yValue2;
        for (float num2 = 0.0f; (double) num2 <= (double) num1; ++num2)
        {
          this.SGP4Chart(anepoch, MyProject.Forms.Home.TLEPOCH);
          double num3 = Functions.GSTCalc((object) anepoch);
          object Right2 = (object) Math.Sqrt(MyProject.Forms.Home.XC * MyProject.Forms.Home.XC + MyProject.Forms.Home.YC * MyProject.Forms.Home.YC);
          object obj2 = (object) Math.Atan(Conversions.ToDouble(Operators.DivideObject((object) MyProject.Forms.Home.ZC, Right2)));
          object Right3 = (object) 7.0;
          while (true)
          {
            if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
            {
              Operators.SubtractObject(obj2, Right3)
            }, (string[]) null, (Type[]) null, (bool[]) null), (object) 1E-07, false))
            {
              Right3 = RuntimeHelpers.GetObjectValue(obj2);
              object Right4 = (object) Math.Sin(Conversions.ToDouble(Right3));
              obj2 = (object) Math.Atan(Conversions.ToDouble(Operators.DivideObject(Operators.AddObject((object) MyProject.Forms.Home.ZC, Operators.MultiplyObject(Operators.MultiplyObject(Operators.MultiplyObject((object) 6378.136658, (object) (1.0 / Math.Sqrt(Conversions.ToDouble(Operators.SubtractObject((object) 1.0, Operators.MultiplyObject(Operators.MultiplyObject((object) 0.00669431777826672, Right4), Right4)))))), (object) 0.00669431777826672), Right4)), Right2)));
            }
            else
              break;
          }
          object Right5 = Operators.MultiplyObject((object) (180.0 / Math.PI), obj2);
          object Left1 = (object) Functions.Norme((object) MyProject.Forms.Home.XC, (object) MyProject.Forms.Home.YC, (object) MyProject.Forms.Home.ZC);
          object Right6 = (object) (6378.136658 / Math.Sqrt(Math.Pow(Math.Cos(Conversions.ToDouble(Operators.MultiplyObject((object) (Math.PI / 180.0), Right5))), 2.0) + Math.Pow(Math.Sin(Conversions.ToDouble(Operators.MultiplyObject((object) (Math.PI / 180.0), Right5))), 2.0) / 0.993305682221733));
          MyProject.Forms.Home.MALTC = Conversions.ToDouble(Operators.SubtractObject(Left1, Right6));
          object Left2 = (object) (180.0 / Math.PI * ((Math.Atan2(MyProject.Forms.Home.YC, MyProject.Forms.Home.XC) - Math.PI / 180.0 * num3) % (2.0 * Math.PI)));
          if (Operators.ConditionalCompareObjectGreater(Left2, (object) 180, false))
            Left2 = Operators.SubtractObject(Left2, (object) 360);
          if (Operators.ConditionalCompareObjectLess(Left2, (object) -180, false))
            Left2 = Operators.AddObject(Left2, (object) 360);
          if (this.CHART_SMA.Checked)
          {
            series1.Points.AddXY((double) num2, MyProject.Forms.Home.SMAC);
            array1[checked ((int) Math.Round((double) num2))] = MyProject.Forms.Home.SMAC;
          }
          if (this.CHART_ECC.Checked)
          {
            series2.Points.AddXY((double) num2, MyProject.Forms.Home.ECCC);
            array2[checked ((int) Math.Round((double) num2))] = MyProject.Forms.Home.ECCC;
          }
          if (this.CHART_INC.Checked)
          {
            series3.Points.AddXY((double) num2, MyProject.Forms.Home.INCC);
            array3[checked ((int) Math.Round((double) num2))] = MyProject.Forms.Home.INCC;
          }
          if (this.CHART_MALT.Checked)
          {
            series4.Points.AddXY((double) num2, MyProject.Forms.Home.MALTC);
            array4[checked ((int) Math.Round((double) num2))] = MyProject.Forms.Home.MALTC;
          }
          if (this.CHART_LNG.Checked)
          {
            series5.Points.AddXY((object) num2, RuntimeHelpers.GetObjectValue(Left2));
            array5[checked ((int) Math.Round((double) num2))] = Conversions.ToDouble(Left2);
          }
          if (this.CHART_APA.Checked)
          {
            yValue1 = Conversions.ToDouble(Operators.SubtractObject((object) (MyProject.Forms.Home.SMAC * (1.0 + MyProject.Forms.Home.ECCC)), Right6));
            series6.Points.AddXY((double) num2, yValue1);
            array6[checked ((int) Math.Round((double) num2))] = yValue1;
          }
          if (this.CHART_PEA.Checked)
          {
            yValue2 = Conversions.ToDouble(Operators.SubtractObject((object) (MyProject.Forms.Home.SMAC * (1.0 - MyProject.Forms.Home.ECCC)), Right6));
            series7.Points.AddXY((double) num2, yValue2);
            array7[checked ((int) Math.Round((double) num2))] = yValue2;
          }
          anepoch = Conversions.ToDouble(Operators.AddObject((object) anepoch, Right1));
        }
        Array.Sort<double>(array1);
        Array.Sort<double>(array2);
        Array.Sort<double>(array3);
        Array.Sort<double>(array4);
        Array.Sort<double>(array5);
        Array.Sort<double>(array6);
        Array.Sort<double>(array7);
        series1.ChartArea = "ChartArea1";
        series2.ChartArea = "ChartArea1";
        series3.ChartArea = "ChartArea1";
        series4.ChartArea = "ChartArea1";
        series5.ChartArea = "ChartArea1";
        series6.ChartArea = "ChartArea1";
        series7.ChartArea = "ChartArea1";
        chart1.Series.Add(series1);
        chart2.Series.Add(series2);
        chart3.Series.Add(series3);
        chart4.Series.Add(series4);
        chart5.Series.Add(series5);
        chart6.Series.Add(series6);
        chart7.Series.Add(series7);
        Point point1;
        Size size1;
        if (this.CHART_SMA.Checked)
        {
          double Left3 = Math.Min(array1[0], array1[checked ((int) Math.Round((double) a))]);
          if (Left3 < 6378.136658)
            Left3 = 6378.136658;
          double Left4 = Math.Max(array1[0], array1[checked ((int) Math.Round((double) a))]);
          object Left5 = Left3 != Left4 ? (object) (Left4 - Left3) : (object) (MyProject.Forms.Home.SMAC / 10.0);
          Chart chart8 = chart1;
          chart8.ChartAreas["ChartArea1"].BackColor = Color.DarkGray;
          chart8.ChartAreas["ChartArea1"].BackSecondaryColor = Color.White;
          chart8.ChartAreas["ChartArea1"].BackGradientStyle = GradientStyle.TopBottom;
          chart8.ChartAreas[0].AxisX.Title = Conversions.ToString(obj1);
          chart8.ChartAreas[0].AxisX.Minimum = 0.0;
          chart8.ChartAreas[0].AxisX.RoundAxisValues();
          chart8.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          chart8.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) Left3, Operators.DivideObject(Left5, (object) 4)), (object) 6378.136658, false))
            chart8.ChartAreas[0].AxisY.Minimum = 6378.136658;
          else
            chart8.ChartAreas[0].AxisY.Minimum = Conversions.ToDouble(Operators.SubtractObject((object) Left3, Operators.DivideObject(Left5, (object) 4)));
          chart8.ChartAreas[0].AxisY.Maximum = Conversions.ToDouble(Operators.AddObject((object) Left4, Operators.DivideObject(Left5, (object) 4)));
          chart8.ChartAreas[0].AxisY.Interval = Conversions.ToDouble(Operators.DivideObject(Left5, (object) 10));
          chart8.Series[0].ChartType = SeriesChartType.Spline;
          chart8.Series[0].BorderWidth = 2;
          Chart chart9 = chart8;
          point1 = new Point(0, 0);
          Point point2 = point1;
          chart9.Location = point2;
          Chart chart10 = chart8;
          size1 = new Size(625, 424);
          Size size2 = size1;
          chart10.Size = size2;
          this.CHART_SMATab.Controls.Add((Control) chart1);
        }
        if (this.CHART_ECC.Checked)
        {
          double Left6 = Math.Min(array2[0], array2[checked ((int) Math.Round((double) a))]);
          double Left7 = Math.Max(array2[0], array2[checked ((int) Math.Round((double) a))]);
          object Left8 = Left6 != Left7 ? (object) (Left7 - Left6) : (object) (MyProject.Forms.Home.ECCC / 10.0);
          Chart chart11 = chart2;
          chart11.ChartAreas["ChartArea1"].BackColor = Color.DarkGray;
          chart11.ChartAreas["ChartArea1"].BackSecondaryColor = Color.White;
          chart11.ChartAreas["ChartArea1"].BackGradientStyle = GradientStyle.TopBottom;
          chart11.ChartAreas[0].AxisX.Title = Conversions.ToString(obj1);
          chart11.ChartAreas[0].AxisX.Minimum = 0.0;
          chart11.ChartAreas[0].AxisX.RoundAxisValues();
          chart11.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          chart11.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) Left6, Operators.DivideObject(Left8, (object) 4)), (object) 0, false))
            chart11.ChartAreas[0].AxisY.Minimum = 0.0;
          else
            chart11.ChartAreas[0].AxisY.Minimum = Conversions.ToDouble(Operators.SubtractObject((object) Left6, Operators.DivideObject(Left8, (object) 4)));
          chart11.ChartAreas[0].AxisY.Maximum = Conversions.ToDouble(Operators.AddObject((object) Left7, Operators.DivideObject(Left8, (object) 4)));
          chart11.ChartAreas[0].AxisY.Interval = Conversions.ToDouble(Operators.DivideObject(Left8, (object) 5));
          chart11.ChartAreas[0].AxisY.RoundAxisValues();
          chart11.Series["Series1"].ChartType = SeriesChartType.Spline;
          chart11.Series[0].BorderWidth = 2;
          Chart chart12 = chart11;
          point1 = new Point(0, 0);
          Point point3 = point1;
          chart12.Location = point3;
          Chart chart13 = chart11;
          size1 = new Size(625, 424);
          Size size3 = size1;
          chart13.Size = size3;
          this.CHART_ECCTab.Controls.Add((Control) chart2);
        }
        if (this.CHART_INC.Checked)
        {
          double Left9 = Math.Min(array3[0], array3[checked ((int) Math.Round((double) a))]);
          double Left10 = Math.Max(array3[0], array3[checked ((int) Math.Round((double) a))]);
          object Left11 = Left9 != Left10 ? (object) (Left10 - Left9) : (object) (MyProject.Forms.Home.INCC / 10.0);
          Chart chart14 = chart3;
          chart14.ChartAreas["ChartArea1"].BackColor = Color.DarkGray;
          chart14.ChartAreas["ChartArea1"].BackSecondaryColor = Color.White;
          chart14.ChartAreas["ChartArea1"].BackGradientStyle = GradientStyle.TopBottom;
          chart14.ChartAreas[0].AxisX.Title = Conversions.ToString(obj1);
          chart14.ChartAreas[0].AxisX.Minimum = 0.0;
          chart14.ChartAreas[0].AxisX.RoundAxisValues();
          chart14.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          chart14.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) Left9, Operators.DivideObject(Left11, (object) 4)), (object) 0, false))
            chart14.ChartAreas[0].AxisY.Minimum = 0.0;
          else
            chart14.ChartAreas[0].AxisY.Minimum = Conversions.ToDouble(Operators.SubtractObject((object) Left9, Operators.DivideObject(Left11, (object) 4)));
          chart14.ChartAreas[0].AxisY.Maximum = Conversions.ToDouble(Operators.AddObject((object) Left10, Operators.DivideObject(Left11, (object) 4)));
          chart14.ChartAreas[0].AxisY.Interval = Conversions.ToDouble(Operators.DivideObject(Left11, (object) 5));
          chart14.ChartAreas[0].AxisY.RoundAxisValues();
          chart14.Series["Series1"].ChartType = SeriesChartType.Spline;
          chart14.Series[0].BorderWidth = 2;
          Chart chart15 = chart14;
          point1 = new Point(0, 0);
          Point point4 = point1;
          chart15.Location = point4;
          Chart chart16 = chart14;
          size1 = new Size(625, 424);
          Size size4 = size1;
          chart16.Size = size4;
          this.CHART_INCTab.Controls.Add((Control) chart3);
        }
        if (this.CHART_MALT.Checked)
        {
          double Left12 = Math.Min(array4[0], array4[checked ((int) Math.Round((double) a))]);
          if (Left12 < 0.0)
            Left12 = 0.0;
          double Left13 = Math.Max(array4[0], array4[checked ((int) Math.Round((double) a))]);
          object Left14 = Left12 != Left13 ? (object) (Left13 - Left12) : (object) (MyProject.Forms.Home.MALTC / 10.0);
          Chart chart17 = chart4;
          chart17.ChartAreas["ChartArea1"].BackColor = Color.DarkGray;
          chart17.ChartAreas["ChartArea1"].BackSecondaryColor = Color.White;
          chart17.ChartAreas["ChartArea1"].BackGradientStyle = GradientStyle.TopBottom;
          chart17.ChartAreas[0].AxisX.Title = Conversions.ToString(obj1);
          chart17.ChartAreas[0].AxisX.Minimum = 0.0;
          chart17.ChartAreas[0].AxisX.RoundAxisValues();
          chart17.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          chart17.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) Left12, Operators.DivideObject(Left14, (object) 4)), (object) 0, false))
            chart17.ChartAreas[0].AxisY.Minimum = 0.0;
          else
            chart17.ChartAreas[0].AxisY.Minimum = Conversions.ToDouble(Operators.SubtractObject((object) Left12, Operators.DivideObject(Left14, (object) 4)));
          chart17.ChartAreas[0].AxisY.Maximum = Conversions.ToDouble(Operators.AddObject((object) Left13, Operators.DivideObject(Left14, (object) 4)));
          chart17.ChartAreas[0].AxisY.Interval = Conversions.ToDouble(Operators.DivideObject(Left14, (object) 10));
          chart17.ChartAreas[0].AxisY.RoundAxisValues();
          chart17.Series["Series1"].ChartType = SeriesChartType.Spline;
          chart17.Series[0].BorderWidth = 2;
          Chart chart18 = chart17;
          point1 = new Point(0, 0);
          Point point5 = point1;
          chart18.Location = point5;
          Chart chart19 = chart17;
          size1 = new Size(625, 424);
          Size size5 = size1;
          chart19.Size = size5;
          this.CHART_MALTTab.Controls.Add((Control) chart4);
        }
        if (MyProject.Forms.Home.MM > 0.99 && MyProject.Forms.Home.MM < 1.01 && MyProject.Forms.Home.ECC < 0.01 && MyProject.Forms.Home.INC < 1.0 && this.CHART_LNG.Checked)
        {
          double Left15 = Math.Min(array5[0], array5[checked ((int) Math.Round((double) a))]);
          double Left16 = Math.Max(array5[0], array5[checked ((int) Math.Round((double) a))]);
          object Left17 = Left15 != Left16 ? (object) (Left16 - Left15) : (object) (MyProject.Forms.Home.LNGC / 10.0);
          Chart chart20 = chart5;
          chart20.ChartAreas["ChartArea1"].BackColor = Color.DarkGray;
          chart20.ChartAreas["ChartArea1"].BackSecondaryColor = Color.White;
          chart20.ChartAreas["ChartArea1"].BackGradientStyle = GradientStyle.TopBottom;
          chart20.ChartAreas[0].AxisX.Title = Conversions.ToString(obj1);
          chart20.ChartAreas[0].AxisX.Minimum = 0.0;
          chart20.ChartAreas[0].AxisX.RoundAxisValues();
          chart20.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          chart20.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) Left15, Operators.DivideObject(Left17, (object) 4)), (object) -180, false))
            chart20.ChartAreas[0].AxisY.Minimum = -180.0;
          else
            chart20.ChartAreas[0].AxisY.Minimum = Conversions.ToDouble(Operators.SubtractObject((object) Left15, Operators.DivideObject(Left17, (object) 4)));
          if (Operators.ConditionalCompareObjectGreater(Operators.AddObject((object) Left16, Operators.DivideObject(Left17, (object) 4)), (object) 180, false))
            chart20.ChartAreas[0].AxisY.Maximum = 180.0;
          else
            chart20.ChartAreas[0].AxisY.Maximum = Conversions.ToDouble(Operators.AddObject((object) Left16, Operators.DivideObject(Left17, (object) 4)));
          chart20.ChartAreas[0].AxisY.Interval = Conversions.ToDouble(Operators.DivideObject(Left17, (object) 5));
          chart20.ChartAreas[0].AxisY.RoundAxisValues();
          chart20.Series["Series1"].ChartType = SeriesChartType.Spline;
          chart20.Series[0].BorderWidth = 2;
          Chart chart21 = chart20;
          point1 = new Point(0, 0);
          Point point6 = point1;
          chart21.Location = point6;
          Chart chart22 = chart20;
          size1 = new Size(625, 424);
          Size size6 = size1;
          chart22.Size = size6;
          this.CHART_LNGTab.Controls.Add((Control) chart5);
        }
        if (this.CHART_APA.Checked)
        {
          double Left18 = Math.Min(array6[0], array6[checked ((int) Math.Round((double) a))]);
          if (Left18 < 0.0)
            Left18 = 0.0;
          double Left19 = Math.Max(array6[0], array6[checked ((int) Math.Round((double) a))]);
          object Left20 = Left18 != Left19 ? (object) (Left19 - Left18) : (object) (yValue1 / 10.0);
          Chart chart23 = chart6;
          chart23.ChartAreas["ChartArea1"].BackColor = Color.DarkGray;
          chart23.ChartAreas["ChartArea1"].BackSecondaryColor = Color.White;
          chart23.ChartAreas["ChartArea1"].BackGradientStyle = GradientStyle.TopBottom;
          chart23.ChartAreas[0].AxisX.Title = Conversions.ToString(obj1);
          chart23.ChartAreas[0].AxisX.Minimum = 0.0;
          chart23.ChartAreas[0].AxisX.RoundAxisValues();
          chart23.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          chart23.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) Left18, Operators.DivideObject(Left20, (object) 4)), (object) 0, false))
            chart23.ChartAreas[0].AxisY.Minimum = 0.0;
          else
            chart23.ChartAreas[0].AxisY.Minimum = Conversions.ToDouble(Operators.SubtractObject((object) Left18, Operators.DivideObject(Left20, (object) 4)));
          chart23.ChartAreas[0].AxisY.Maximum = Conversions.ToDouble(Operators.AddObject((object) Left19, Operators.DivideObject(Left20, (object) 4)));
          chart23.ChartAreas[0].AxisY.Interval = Conversions.ToDouble(Operators.DivideObject(Left20, (object) 10));
          chart23.ChartAreas[0].AxisY.RoundAxisValues();
          chart23.Series["Series1"].ChartType = SeriesChartType.Spline;
          chart23.Series[0].BorderWidth = 2;
          Chart chart24 = chart23;
          point1 = new Point(0, 0);
          Point point7 = point1;
          chart24.Location = point7;
          Chart chart25 = chart23;
          size1 = new Size(625, 424);
          Size size7 = size1;
          chart25.Size = size7;
          this.CHART_APATab.Controls.Add((Control) chart6);
        }
        if (this.CHART_PEA.Checked)
        {
          double Left21 = Math.Min(array7[0], array7[checked ((int) Math.Round((double) a))]);
          if (Left21 < 0.0)
            Left21 = 0.0;
          double Left22 = Math.Max(array7[0], array7[checked ((int) Math.Round((double) a))]);
          object Left23 = Left21 != Left22 ? (object) (Left22 - Left21) : (object) (yValue2 / 10.0);
          Chart chart26 = chart7;
          chart26.ChartAreas["ChartArea1"].BackColor = Color.DarkGray;
          chart26.ChartAreas["ChartArea1"].BackSecondaryColor = Color.White;
          chart26.ChartAreas["ChartArea1"].BackGradientStyle = GradientStyle.TopBottom;
          chart26.ChartAreas[0].AxisX.Title = Conversions.ToString(obj1);
          chart26.ChartAreas[0].AxisX.Minimum = 0.0;
          chart26.ChartAreas[0].AxisX.RoundAxisValues();
          chart26.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          chart26.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
          if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) Left21, Operators.DivideObject(Left23, (object) 4)), (object) 0, false))
            chart26.ChartAreas[0].AxisY.Minimum = 0.0;
          else
            chart26.ChartAreas[0].AxisY.Minimum = Conversions.ToDouble(Operators.SubtractObject((object) Left21, Operators.DivideObject(Left23, (object) 4)));
          chart26.ChartAreas[0].AxisY.Maximum = Conversions.ToDouble(Operators.AddObject((object) Left22, Operators.DivideObject(Left23, (object) 4)));
          chart26.ChartAreas[0].AxisY.Interval = Conversions.ToDouble(Operators.DivideObject(Left23, (object) 10));
          chart26.ChartAreas[0].AxisY.RoundAxisValues();
          chart26.Series["Series1"].ChartType = SeriesChartType.Spline;
          chart26.Series[0].BorderWidth = 2;
          Chart chart27 = chart26;
          point1 = new Point(0, 0);
          Point point8 = point1;
          chart27.Location = point8;
          Chart chart28 = chart26;
          size1 = new Size(625, 424);
          Size size8 = size1;
          chart28.Size = size8;
          this.CHART_PEATab.Controls.Add((Control) chart7);
        }
        this.Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) TopMostMessageBox.Show("An error as occured during Chart generation.\r\n\r\n" + ex.Message, "TLE ANALYSER - Error");
        this.Cursor = Cursors.Default;
        ProjectData.ClearProjectError();
      }
    }

    private void Chart_Days_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar))
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CloseButton_Click(object sender, EventArgs e) => this.Close();

    private void ChartXvalue_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Operators.ConditionalCompareObjectEqual(this.CHARTS_Unit.SelectedItem, (object) "periods", false))
        this.CHARTS_NumPeriod.Enabled = true;
      else
        this.CHARTS_NumPeriod.Enabled = false;
    }
  }
}
