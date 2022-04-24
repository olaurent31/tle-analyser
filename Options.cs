// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Options
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  [DesignerGenerated]
  public class Options : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("TLE_Download")]
    private Button _TLE_Download;
    [AccessedThroughProperty("TLE_ProgressBar")]
    private ProgressBar _TLE_ProgressBar;
    [AccessedThroughProperty("LinkLabel3")]
    private LinkLabel _LinkLabel3;
    [AccessedThroughProperty("GroupBox12")]
    private GroupBox _GroupBox12;
    [AccessedThroughProperty("Label59")]
    private Label _Label59;
    [AccessedThroughProperty("Label58")]
    private Label _Label58;
    [AccessedThroughProperty("GMAT_FullModel")]
    private RadioButton _GMAT_FullModel;
    [AccessedThroughProperty("GMAT_PartialModel")]
    private RadioButton _GMAT_PartialModel;
    [AccessedThroughProperty("Label56")]
    private Label _Label56;
    [AccessedThroughProperty("LinkLabel2")]
    private LinkLabel _LinkLabel2;
    [AccessedThroughProperty("Label55")]
    private Label _Label55;
    [AccessedThroughProperty("GMAT_Period")]
    private ComboBox _GMAT_Period;
    [AccessedThroughProperty("GMAT_ShowTrack")]
    private CheckBox _GMAT_ShowTrack;
    [AccessedThroughProperty("SatPictOp2")]
    private PictureBox _SatPictOp2;
    [AccessedThroughProperty("SatPictOp1")]
    private PictureBox _SatPictOp1;
    [AccessedThroughProperty("MAP_SatIcon3")]
    private RadioButton _MAP_SatIcon3;
    [AccessedThroughProperty("MAP_SatIcon1")]
    private RadioButton _MAP_SatIcon1;
    [AccessedThroughProperty("GroupBox19")]
    private GroupBox _GroupBox19;
    [AccessedThroughProperty("TRACK_Speed")]
    private ComboBox _TRACK_Speed;
    [AccessedThroughProperty("Label143")]
    private Label _Label143;
    [AccessedThroughProperty("LinkLabel4")]
    private LinkLabel _LinkLabel4;
    [AccessedThroughProperty("LinkLabel1")]
    private LinkLabel _LinkLabel1;
    [AccessedThroughProperty("RTST_Link")]
    private LinkLabel _RTST_Link;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("GroupBox13")]
    private GroupBox _GroupBox13;
    [AccessedThroughProperty("OffsetUTCBox")]
    private TextBox _OffsetUTCBox;
    [AccessedThroughProperty("CurrentDateUTCBox")]
    private TextBox _CurrentDateUTCBox;
    [AccessedThroughProperty("CurrentDateBox")]
    private TextBox _CurrentDateBox;
    [AccessedThroughProperty("TimeZoneBox")]
    private TextBox _TimeZoneBox;
    [AccessedThroughProperty("Label148")]
    private Label _Label148;
    [AccessedThroughProperty("Label146")]
    private Label _Label146;
    [AccessedThroughProperty("Label145")]
    private Label _Label145;
    [AccessedThroughProperty("Label144")]
    private Label _Label144;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("Label61")]
    private Label _Label61;
    [AccessedThroughProperty("Label60")]
    private Label _Label60;
    [AccessedThroughProperty("OPTIONS_Save")]
    private Button _OPTIONS_Save;
    [AccessedThroughProperty("OPTIONS_LoadDefault")]
    private Button _OPTIONS_LoadDefault;
    [AccessedThroughProperty("OPTIONS_Close")]
    private Button _OPTIONS_Close;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    [AccessedThroughProperty("TleLastUpdate")]
    private Label _TleLastUpdate;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("TRACK_RTMStart")]
    private CheckBox _TRACK_RTMStart;
    [AccessedThroughProperty("GroupBox6")]
    private GroupBox _GroupBox6;
    [AccessedThroughProperty("TLE_LoadTLEepoch")]
    private RadioButton _TLE_LoadTLEepoch;
    [AccessedThroughProperty("TLE_LoadCurrentEpoch")]
    private RadioButton _TLE_LoadCurrentEpoch;
    [AccessedThroughProperty("Label27")]
    private Label _Label27;
    [AccessedThroughProperty("Label41")]
    private Label _Label41;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label64")]
    private Label _Label64;
    [AccessedThroughProperty("GroupBox7")]
    private GroupBox _GroupBox7;
    [AccessedThroughProperty("GroupBox8")]
    private GroupBox _GroupBox8;
    [AccessedThroughProperty("GS_ShortName")]
    private RadioButton _GS_ShortName;
    [AccessedThroughProperty("GS_FullName")]
    private RadioButton _GS_FullName;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("GS_LimitAngle")]
    private ComboBox _GS_LimitAngle;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("SatPictOp3")]
    private PictureBox _SatPictOp3;
    [AccessedThroughProperty("MAP_SatIcon2")]
    private RadioButton _MAP_SatIcon2;
    [AccessedThroughProperty("GroupBox4")]
    private GroupBox _GroupBox4;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("TRACK_RTMStep")]
    private ComboBox _TRACK_RTMStep;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("GroupBox5")]
    private GroupBox _GroupBox5;
    [AccessedThroughProperty("AltMeanRadius")]
    private CheckBox _AltMeanRadius;
    [AccessedThroughProperty("GroupBox9")]
    private GroupBox _GroupBox9;
    [AccessedThroughProperty("CAT_Download")]
    private Button _CAT_Download;
    public bool TLEDownloaded;

    [DebuggerNonUserCode]
    static Options()
    {
    }

    [DebuggerNonUserCode]
    public Options()
    {
      this.Load += new EventHandler(this.Load_App_1);
      this.FormClosing += new FormClosingEventHandler(this.Load_App_2);
      Options.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (Options.__ENCList)
      {
        if (Options.__ENCList.Count == Options.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (Options.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (Options.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                Options.__ENCList[index1] = Options.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          Options.__ENCList.RemoveRange(index1, checked (Options.__ENCList.Count - index1));
          Options.__ENCList.Capacity = Options.__ENCList.Count;
        }
        Options.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Options));
      this.TleLastUpdate = new Label();
      this.Label1 = new Label();
      this.GroupBox1 = new GroupBox();
      this.TLE_ProgressBar = new ProgressBar();
      this.TLE_Download = new Button();
      this.SatPictOp2 = new PictureBox();
      this.SatPictOp1 = new PictureBox();
      this.MAP_SatIcon3 = new RadioButton();
      this.MAP_SatIcon1 = new RadioButton();
      this.GroupBox19 = new GroupBox();
      this.SatPictOp3 = new PictureBox();
      this.GroupBox4 = new GroupBox();
      this.Label143 = new Label();
      this.TRACK_Speed = new ComboBox();
      this.MAP_SatIcon2 = new RadioButton();
      this.GroupBox3 = new GroupBox();
      this.Label6 = new Label();
      this.TRACK_RTMStep = new ComboBox();
      this.Label4 = new Label();
      this.TRACK_RTMStart = new CheckBox();
      this.Label3 = new Label();
      this.Label61 = new Label();
      this.Label60 = new Label();
      this.GroupBox12 = new GroupBox();
      this.Label59 = new Label();
      this.Label58 = new Label();
      this.GMAT_FullModel = new RadioButton();
      this.GMAT_PartialModel = new RadioButton();
      this.Label56 = new Label();
      this.LinkLabel2 = new LinkLabel();
      this.Label55 = new Label();
      this.GMAT_Period = new ComboBox();
      this.GMAT_ShowTrack = new CheckBox();
      this.GroupBox13 = new GroupBox();
      this.OffsetUTCBox = new TextBox();
      this.CurrentDateUTCBox = new TextBox();
      this.CurrentDateBox = new TextBox();
      this.TimeZoneBox = new TextBox();
      this.Label148 = new Label();
      this.Label146 = new Label();
      this.Label145 = new Label();
      this.Label144 = new Label();
      this.GroupBox2 = new GroupBox();
      this.LinkLabel4 = new LinkLabel();
      this.LinkLabel3 = new LinkLabel();
      this.LinkLabel1 = new LinkLabel();
      this.RTST_Link = new LinkLabel();
      this.OPTIONS_Save = new Button();
      this.OPTIONS_LoadDefault = new Button();
      this.OPTIONS_Close = new Button();
      this.Timer1 = new Timer(this.components);
      this.GroupBox6 = new GroupBox();
      this.TLE_LoadTLEepoch = new RadioButton();
      this.TLE_LoadCurrentEpoch = new RadioButton();
      this.Label27 = new Label();
      this.Label41 = new Label();
      this.Label2 = new Label();
      this.Label64 = new Label();
      this.GroupBox7 = new GroupBox();
      this.GroupBox8 = new GroupBox();
      this.Label5 = new Label();
      this.GS_LimitAngle = new ComboBox();
      this.GS_ShortName = new RadioButton();
      this.GS_FullName = new RadioButton();
      this.GroupBox5 = new GroupBox();
      this.AltMeanRadius = new CheckBox();
      this.GroupBox9 = new GroupBox();
      this.CAT_Download = new Button();
      this.GroupBox1.SuspendLayout();
      ((ISupportInitialize) this.SatPictOp2).BeginInit();
      ((ISupportInitialize) this.SatPictOp1).BeginInit();
      this.GroupBox19.SuspendLayout();
      ((ISupportInitialize) this.SatPictOp3).BeginInit();
      this.GroupBox4.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox12.SuspendLayout();
      this.GroupBox13.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      this.GroupBox8.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.GroupBox9.SuspendLayout();
      this.SuspendLayout();
      this.TleLastUpdate.AutoSize = true;
      Label tleLastUpdate1 = this.TleLastUpdate;
      Point point1 = new Point(98, 62);
      Point point2 = point1;
      tleLastUpdate1.Location = point2;
      this.TleLastUpdate.Name = "TleLastUpdate";
      Label tleLastUpdate2 = this.TleLastUpdate;
      Size size1 = new Size(13, 13);
      Size size2 = size1;
      tleLastUpdate2.Size = size2;
      this.TleLastUpdate.TabIndex = 91;
      this.TleLastUpdate.Text = "  ";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(22, 62);
      Point point3 = point1;
      label1_1.Location = point3;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(71, 13);
      Size size3 = size1;
      label1_2.Size = size3;
      this.Label1.TabIndex = 90;
      this.Label1.Text = "Last Update: ";
      this.GroupBox1.Controls.Add((Control) this.TleLastUpdate);
      this.GroupBox1.Controls.Add((Control) this.TLE_ProgressBar);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.TLE_Download);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(266, 12);
      Point point4 = point1;
      groupBox1_1.Location = point4;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(248, 85);
      Size size4 = size1;
      groupBox1_2.Size = size4;
      this.GroupBox1.TabIndex = 89;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "TLE Updater";
      this.TLE_ProgressBar.ImeMode = ImeMode.NoControl;
      ProgressBar tleProgressBar1 = this.TLE_ProgressBar;
      point1 = new Point(130, 29);
      Point point5 = point1;
      tleProgressBar1.Location = point5;
      this.TLE_ProgressBar.Name = "TLE_ProgressBar";
      ProgressBar tleProgressBar2 = this.TLE_ProgressBar;
      size1 = new Size(112, 20);
      Size size5 = size1;
      tleProgressBar2.Size = size5;
      this.TLE_ProgressBar.TabIndex = 88;
      this.TLE_ProgressBar.Visible = false;
      this.TLE_Download.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.TLE_Download.ImeMode = ImeMode.NoControl;
      Button tleDownload1 = this.TLE_Download;
      point1 = new Point(6, 29);
      Point point6 = point1;
      tleDownload1.Location = point6;
      this.TLE_Download.Name = "TLE_Download";
      Button tleDownload2 = this.TLE_Download;
      size1 = new Size(118, 23);
      Size size6 = size1;
      tleDownload2.Size = size6;
      this.TLE_Download.TabIndex = 87;
      this.TLE_Download.Text = "Update TLE";
      this.TLE_Download.UseVisualStyleBackColor = false;
      this.SatPictOp2.BackColor = Color.Transparent;
      this.SatPictOp2.Cursor = Cursors.Default;
      this.SatPictOp2.ImeMode = ImeMode.NoControl;
      this.SatPictOp2.InitialImage = (Image) null;
      PictureBox satPictOp2_1 = this.SatPictOp2;
      point1 = new Point(172, 211);
      Point point7 = point1;
      satPictOp2_1.Location = point7;
      this.SatPictOp2.Name = "SatPictOp2";
      PictureBox satPictOp2_2 = this.SatPictOp2;
      size1 = new Size(16, 16);
      Size size7 = size1;
      satPictOp2_2.Size = size7;
      this.SatPictOp2.TabIndex = 97;
      this.SatPictOp2.TabStop = false;
      this.SatPictOp1.BackColor = Color.Transparent;
      this.SatPictOp1.Cursor = Cursors.Default;
      this.SatPictOp1.ImeMode = ImeMode.NoControl;
      this.SatPictOp1.InitialImage = (Image) null;
      PictureBox satPictOp1_1 = this.SatPictOp1;
      point1 = new Point(174, 171);
      Point point8 = point1;
      satPictOp1_1.Location = point8;
      this.SatPictOp1.Name = "SatPictOp1";
      PictureBox satPictOp1_2 = this.SatPictOp1;
      size1 = new Size(13, 12);
      Size size8 = size1;
      satPictOp1_2.Size = size8;
      this.SatPictOp1.TabIndex = 96;
      this.SatPictOp1.TabStop = false;
      this.MAP_SatIcon3.AutoSize = true;
      this.MAP_SatIcon3.Checked = true;
      this.MAP_SatIcon3.ImeMode = ImeMode.NoControl;
      RadioButton mapSatIcon3_1 = this.MAP_SatIcon3;
      point1 = new Point(137, 211);
      Point point9 = point1;
      mapSatIcon3_1.Location = point9;
      this.MAP_SatIcon3.Name = "MAP_SatIcon3";
      RadioButton mapSatIcon3_2 = this.MAP_SatIcon3;
      size1 = new Size(14, 13);
      Size size9 = size1;
      mapSatIcon3_2.Size = size9;
      this.MAP_SatIcon3.TabIndex = 95;
      this.MAP_SatIcon3.TabStop = true;
      this.MAP_SatIcon3.UseVisualStyleBackColor = true;
      this.MAP_SatIcon1.AutoSize = true;
      this.MAP_SatIcon1.ImeMode = ImeMode.NoControl;
      RadioButton mapSatIcon1_1 = this.MAP_SatIcon1;
      point1 = new Point(137, 171);
      Point point10 = point1;
      mapSatIcon1_1.Location = point10;
      this.MAP_SatIcon1.Name = "MAP_SatIcon1";
      RadioButton mapSatIcon1_2 = this.MAP_SatIcon1;
      size1 = new Size(14, 13);
      Size size10 = size1;
      mapSatIcon1_2.Size = size10;
      this.MAP_SatIcon1.TabIndex = 94;
      this.MAP_SatIcon1.UseVisualStyleBackColor = true;
      this.GroupBox19.Controls.Add((Control) this.SatPictOp3);
      this.GroupBox19.Controls.Add((Control) this.GroupBox4);
      this.GroupBox19.Controls.Add((Control) this.MAP_SatIcon2);
      this.GroupBox19.Controls.Add((Control) this.GroupBox3);
      this.GroupBox19.Controls.Add((Control) this.Label3);
      this.GroupBox19.Controls.Add((Control) this.MAP_SatIcon1);
      this.GroupBox19.Controls.Add((Control) this.SatPictOp2);
      this.GroupBox19.Controls.Add((Control) this.MAP_SatIcon3);
      this.GroupBox19.Controls.Add((Control) this.SatPictOp1);
      GroupBox groupBox19_1 = this.GroupBox19;
      point1 = new Point(12, 12);
      Point point11 = point1;
      groupBox19_1.Location = point11;
      this.GroupBox19.Name = "GroupBox19";
      GroupBox groupBox19_2 = this.GroupBox19;
      size1 = new Size(248, 235);
      Size size11 = size1;
      groupBox19_2.Size = size11;
      this.GroupBox19.TabIndex = 98;
      this.GroupBox19.TabStop = false;
      this.GroupBox19.Text = "Tracking Options";
      this.SatPictOp3.BackColor = Color.Transparent;
      this.SatPictOp3.Cursor = Cursors.Default;
      this.SatPictOp3.ImeMode = ImeMode.NoControl;
      this.SatPictOp3.InitialImage = (Image) null;
      PictureBox satPictOp3_1 = this.SatPictOp3;
      point1 = new Point(175, 191);
      Point point12 = point1;
      satPictOp3_1.Location = point12;
      this.SatPictOp3.Name = "SatPictOp3";
      PictureBox satPictOp3_2 = this.SatPictOp3;
      size1 = new Size(10, 10);
      Size size12 = size1;
      satPictOp3_2.Size = size12;
      this.SatPictOp3.TabIndex = 103;
      this.SatPictOp3.TabStop = false;
      this.GroupBox4.Controls.Add((Control) this.Label143);
      this.GroupBox4.Controls.Add((Control) this.TRACK_Speed);
      GroupBox groupBox4_1 = this.GroupBox4;
      point1 = new Point(6, 19);
      Point point13 = point1;
      groupBox4_1.Location = point13;
      this.GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = this.GroupBox4;
      size1 = new Size(236, 57);
      Size size13 = size1;
      groupBox4_2.Size = size13;
      this.GroupBox4.TabIndex = 99;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Manual Mode";
      this.Label143.AutoSize = true;
      this.Label143.ImeMode = ImeMode.NoControl;
      Label label143_1 = this.Label143;
      point1 = new Point(6, 25);
      Point point14 = point1;
      label143_1.Location = point14;
      this.Label143.Name = "Label143";
      Label label143_2 = this.Label143;
      size1 = new Size(112, 13);
      Size size14 = size1;
      label143_2.Size = size14;
      this.Label143.TabIndex = 98;
      this.Label143.Text = "Simulation speed:     X";
      this.TRACK_Speed.BackColor = SystemColors.Window;
      this.TRACK_Speed.DropDownStyle = ComboBoxStyle.DropDownList;
      this.TRACK_Speed.FormattingEnabled = true;
      this.TRACK_Speed.Items.AddRange(new object[3]
      {
        (object) "1",
        (object) "10",
        (object) "100"
      });
      ComboBox trackSpeed1 = this.TRACK_Speed;
      point1 = new Point(119, 22);
      Point point15 = point1;
      trackSpeed1.Location = point15;
      this.TRACK_Speed.Name = "TRACK_Speed";
      ComboBox trackSpeed2 = this.TRACK_Speed;
      size1 = new Size(50, 21);
      Size size15 = size1;
      trackSpeed2.Size = size15;
      this.TRACK_Speed.TabIndex = 97;
      this.MAP_SatIcon2.AutoSize = true;
      this.MAP_SatIcon2.ImeMode = ImeMode.NoControl;
      RadioButton mapSatIcon2_1 = this.MAP_SatIcon2;
      point1 = new Point(137, 190);
      Point point16 = point1;
      mapSatIcon2_1.Location = point16;
      this.MAP_SatIcon2.Name = "MAP_SatIcon2";
      RadioButton mapSatIcon2_2 = this.MAP_SatIcon2;
      size1 = new Size(14, 13);
      Size size16 = size1;
      mapSatIcon2_2.Size = size16;
      this.MAP_SatIcon2.TabIndex = 102;
      this.MAP_SatIcon2.UseVisualStyleBackColor = true;
      this.GroupBox3.Controls.Add((Control) this.Label6);
      this.GroupBox3.Controls.Add((Control) this.TRACK_RTMStep);
      this.GroupBox3.Controls.Add((Control) this.Label4);
      this.GroupBox3.Controls.Add((Control) this.TRACK_RTMStart);
      GroupBox groupBox3_1 = this.GroupBox3;
      point1 = new Point(6, 82);
      Point point17 = point1;
      groupBox3_1.Location = point17;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      size1 = new Size(236, 75);
      Size size17 = size1;
      groupBox3_2.Size = size17;
      this.GroupBox3.TabIndex = 123;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Real Time Mode";
      this.Label6.AutoSize = true;
      this.Label6.ImeMode = ImeMode.NoControl;
      Label label6_1 = this.Label6;
      point1 = new Point(147, 42);
      Point point18 = point1;
      label6_1.Location = point18;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(47, 13);
      Size size18 = size1;
      label6_2.Size = size18;
      this.Label6.TabIndex = 106;
      this.Label6.Text = "seconds";
      this.TRACK_RTMStep.BackColor = SystemColors.Window;
      this.TRACK_RTMStep.DropDownStyle = ComboBoxStyle.DropDownList;
      this.TRACK_RTMStep.FormattingEnabled = true;
      this.TRACK_RTMStep.Items.AddRange(new object[6]
      {
        (object) "1",
        (object) "5",
        (object) "10",
        (object) "20",
        (object) "30",
        (object) "60"
      });
      ComboBox trackRtmStep1 = this.TRACK_RTMStep;
      point1 = new Point(91, 39);
      Point point19 = point1;
      trackRtmStep1.Location = point19;
      this.TRACK_RTMStep.Name = "TRACK_RTMStep";
      ComboBox trackRtmStep2 = this.TRACK_RTMStep;
      size1 = new Size(50, 21);
      Size size19 = size1;
      trackRtmStep2.Size = size19;
      this.TRACK_RTMStep.TabIndex = 105;
      this.Label4.AutoSize = true;
      this.Label4.ImeMode = ImeMode.NoControl;
      Label label4_1 = this.Label4;
      point1 = new Point(6, 42);
      Point point20 = point1;
      label4_1.Location = point20;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(79, 13);
      Size size20 = size1;
      label4_2.Size = size20;
      this.Label4.TabIndex = 104;
      this.Label4.Text = "Actualise every";
      this.TRACK_RTMStart.AutoSize = true;
      CheckBox trackRtmStart1 = this.TRACK_RTMStart;
      point1 = new Point(9, 19);
      Point point21 = point1;
      trackRtmStart1.Location = point21;
      this.TRACK_RTMStart.Name = "TRACK_RTMStart";
      CheckBox trackRtmStart2 = this.TRACK_RTMStart;
      size1 = new Size(191, 17);
      Size size21 = size1;
      trackRtmStart2.Size = size21;
      this.TRACK_RTMStart.TabIndex = 100;
      this.TRACK_RTMStart.Text = "Start real time mode at TLE loading";
      this.TRACK_RTMStart.UseVisualStyleBackColor = true;
      this.Label3.AutoSize = true;
      this.Label3.ImeMode = ImeMode.NoControl;
      Label label3_1 = this.Label3;
      point1 = new Point(12, 171);
      Point point22 = point1;
      label3_1.Location = point22;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(119, 13);
      Size size22 = size1;
      label3_2.Size = size22;
      this.Label3.TabIndex = 101;
      this.Label3.Text = "Satellite Icon on 2 Map:";
      this.Label61.AutoSize = true;
      this.Label61.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.Label61.ImeMode = ImeMode.NoControl;
      Label label61_1 = this.Label61;
      point1 = new Point(10, 429);
      Point point23 = point1;
      label61_1.Location = point23;
      this.Label61.Name = "Label61";
      Label label61_2 = this.Label61;
      size1 = new Size(184, 48);
      Size size23 = size1;
      label61_2.Size = size23;
      this.Label61.TabIndex = 95;
      this.Label61.Text = "(2) - Gravity Field: JGM-3 Degree 4, Order 4\r\n      - Drag Model : MSISE-90\r\n      - Moon and Sun point masses\r\n      - Solar Radiation Pressure";
      this.Label60.AutoSize = true;
      this.Label60.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.Label60.ImeMode = ImeMode.NoControl;
      Label label60_1 = this.Label60;
      point1 = new Point(10, 415);
      Point point24 = point1;
      label60_1.Location = point24;
      this.Label60.Name = "Label60";
      Label label60_2 = this.Label60;
      size1 = new Size(203, 12);
      Size size24 = size1;
      label60_2.Size = size24;
      this.Label60.TabIndex = 94;
      this.Label60.Text = "(1) - Gravity Field only: JGM-3 Degree 2, Order 0";
      this.GroupBox12.Controls.Add((Control) this.Label59);
      this.GroupBox12.Controls.Add((Control) this.Label58);
      this.GroupBox12.Controls.Add((Control) this.GMAT_FullModel);
      this.GroupBox12.Controls.Add((Control) this.GMAT_PartialModel);
      this.GroupBox12.Controls.Add((Control) this.Label56);
      this.GroupBox12.Controls.Add((Control) this.LinkLabel2);
      this.GroupBox12.Controls.Add((Control) this.Label55);
      this.GroupBox12.Controls.Add((Control) this.GMAT_Period);
      this.GroupBox12.Controls.Add((Control) this.GMAT_ShowTrack);
      GroupBox groupBox12_1 = this.GroupBox12;
      point1 = new Point(12, 253);
      Point point25 = point1;
      groupBox12_1.Location = point25;
      this.GroupBox12.Name = "GroupBox12";
      GroupBox groupBox12_2 = this.GroupBox12;
      size1 = new Size(248, 159);
      Size size25 = size1;
      groupBox12_2.Size = size25;
      this.GroupBox12.TabIndex = 87;
      this.GroupBox12.TabStop = false;
      this.GroupBox12.Text = "GMAT Script (R2013a Version)";
      this.Label59.AutoSize = true;
      this.Label59.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.Label59.ImeMode = ImeMode.NoControl;
      Label label59_1 = this.Label59;
      point1 = new Point(86, 66);
      Point point26 = point1;
      label59_1.Location = point26;
      this.Label59.Name = "Label59";
      Label label59_2 = this.Label59;
      size1 = new Size(16, 12);
      Size size26 = size1;
      label59_2.Size = size26;
      this.Label59.TabIndex = 95;
      this.Label59.Text = "(2)";
      this.Label58.AutoSize = true;
      this.Label58.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.Label58.ImeMode = ImeMode.NoControl;
      Label label58_1 = this.Label58;
      point1 = new Point(86, 44);
      Point point27 = point1;
      label58_1.Location = point27;
      this.Label58.Name = "Label58";
      Label label58_2 = this.Label58;
      size1 = new Size(16, 12);
      Size size27 = size1;
      label58_2.Size = size27;
      this.Label58.TabIndex = 91;
      this.Label58.Text = "(1)";
      this.GMAT_FullModel.AutoSize = true;
      this.GMAT_FullModel.Checked = true;
      this.GMAT_FullModel.ImeMode = ImeMode.NoControl;
      RadioButton gmatFullModel1 = this.GMAT_FullModel;
      point1 = new Point(6, 69);
      Point point28 = point1;
      gmatFullModel1.Location = point28;
      this.GMAT_FullModel.Name = "GMAT_FullModel";
      RadioButton gmatFullModel2 = this.GMAT_FullModel;
      size1 = new Size(73, 17);
      Size size28 = size1;
      gmatFullModel2.Size = size28;
      this.GMAT_FullModel.TabIndex = 94;
      this.GMAT_FullModel.TabStop = true;
      this.GMAT_FullModel.Text = "Full Model";
      this.GMAT_FullModel.UseVisualStyleBackColor = true;
      this.GMAT_PartialModel.AutoSize = true;
      this.GMAT_PartialModel.ImeMode = ImeMode.NoControl;
      RadioButton gmatPartialModel1 = this.GMAT_PartialModel;
      point1 = new Point(6, 46);
      Point point29 = point1;
      gmatPartialModel1.Location = point29;
      this.GMAT_PartialModel.Name = "GMAT_PartialModel";
      RadioButton gmatPartialModel2 = this.GMAT_PartialModel;
      size1 = new Size(86, 17);
      Size size29 = size1;
      gmatPartialModel2.Size = size29;
      this.GMAT_PartialModel.TabIndex = 93;
      this.GMAT_PartialModel.Text = "Partial Model";
      this.GMAT_PartialModel.UseVisualStyleBackColor = true;
      this.Label56.AutoSize = true;
      this.Label56.ImeMode = ImeMode.NoControl;
      Label label56_1 = this.Label56;
      point1 = new Point(3, 106);
      Point point30 = point1;
      label56_1.Location = point30;
      this.Label56.Name = "Label56";
      Label label56_2 = this.Label56;
      size1 = new Size(71, 13);
      Size size30 = size1;
      label56_2.Size = size30;
      this.Label56.TabIndex = 92;
      this.Label56.Text = "Propagate on";
      this.LinkLabel2.AutoSize = true;
      this.LinkLabel2.ImeMode = ImeMode.NoControl;
      this.LinkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel linkLabel2_1 = this.LinkLabel2;
      point1 = new Point(35, 135);
      Point point31 = point1;
      linkLabel2_1.Location = point31;
      this.LinkLabel2.Name = "LinkLabel2";
      LinkLabel linkLabel2_2 = this.LinkLabel2;
      size1 = new Size(119, 13);
      Size size31 = size1;
      linkLabel2_2.Size = size31;
      this.LinkLabel2.TabIndex = 82;
      this.LinkLabel2.TabStop = true;
      this.LinkLabel2.Text = "> About NASA GMAT <";
      this.Label55.AutoSize = true;
      this.Label55.ImeMode = ImeMode.NoControl;
      Label label55_1 = this.Label55;
      point1 = new Point(122, 106);
      Point point32 = point1;
      label55_1.Location = point32;
      this.Label55.Name = "Label55";
      Label label55_2 = this.Label55;
      size1 = new Size(48, 13);
      Size size32 = size1;
      label55_2.Size = size32;
      this.Label55.TabIndex = 79;
      this.Label55.Text = "Period(s)";
      this.GMAT_Period.BackColor = SystemColors.Window;
      this.GMAT_Period.Cursor = Cursors.Default;
      this.GMAT_Period.DropDownStyle = ComboBoxStyle.DropDownList;
      this.GMAT_Period.FormattingEnabled = true;
      this.GMAT_Period.Items.AddRange(new object[5]
      {
        (object) "1",
        (object) "2",
        (object) "5",
        (object) "10",
        (object) "15"
      });
      ComboBox gmatPeriod1 = this.GMAT_Period;
      point1 = new Point(76, 101);
      Point point33 = point1;
      gmatPeriod1.Location = point33;
      this.GMAT_Period.Name = "GMAT_Period";
      ComboBox gmatPeriod2 = this.GMAT_Period;
      size1 = new Size(43, 21);
      Size size33 = size1;
      gmatPeriod2.Size = size33;
      this.GMAT_Period.TabIndex = 78;
      this.GMAT_ShowTrack.AutoSize = true;
      this.GMAT_ShowTrack.Checked = true;
      this.GMAT_ShowTrack.CheckState = CheckState.Checked;
      this.GMAT_ShowTrack.ImeMode = ImeMode.NoControl;
      CheckBox gmatShowTrack1 = this.GMAT_ShowTrack;
      point1 = new Point(6, 23);
      Point point34 = point1;
      gmatShowTrack1.Location = point34;
      this.GMAT_ShowTrack.Name = "GMAT_ShowTrack";
      CheckBox gmatShowTrack2 = this.GMAT_ShowTrack;
      size1 = new Size(105, 17);
      Size size34 = size1;
      gmatShowTrack2.Size = size34;
      this.GMAT_ShowTrack.TabIndex = 73;
      this.GMAT_ShowTrack.Text = "Show Track Plot";
      this.GMAT_ShowTrack.UseVisualStyleBackColor = true;
      this.GroupBox13.Controls.Add((Control) this.OffsetUTCBox);
      this.GroupBox13.Controls.Add((Control) this.CurrentDateUTCBox);
      this.GroupBox13.Controls.Add((Control) this.CurrentDateBox);
      this.GroupBox13.Controls.Add((Control) this.TimeZoneBox);
      this.GroupBox13.Controls.Add((Control) this.Label148);
      this.GroupBox13.Controls.Add((Control) this.Label146);
      this.GroupBox13.Controls.Add((Control) this.Label145);
      this.GroupBox13.Controls.Add((Control) this.Label144);
      GroupBox groupBox13_1 = this.GroupBox13;
      point1 = new Point(266, 261);
      Point point35 = point1;
      groupBox13_1.Location = point35;
      this.GroupBox13.Name = "GroupBox13";
      GroupBox groupBox13_2 = this.GroupBox13;
      size1 = new Size(248, 85);
      Size size35 = size1;
      groupBox13_2.Size = size35;
      this.GroupBox13.TabIndex = 100;
      this.GroupBox13.TabStop = false;
      this.GroupBox13.Text = "TimeZone";
      this.OffsetUTCBox.BackColor = SystemColors.Control;
      this.OffsetUTCBox.BorderStyle = BorderStyle.None;
      this.OffsetUTCBox.Font = new Font("Microsoft Sans Serif", 8.25f);
      TextBox offsetUtcBox1 = this.OffsetUTCBox;
      point1 = new Point((int) sbyte.MaxValue, 60);
      Point point36 = point1;
      offsetUtcBox1.Location = point36;
      this.OffsetUTCBox.Name = "OffsetUTCBox";
      this.OffsetUTCBox.ReadOnly = true;
      TextBox offsetUtcBox2 = this.OffsetUTCBox;
      size1 = new Size(115, 13);
      Size size36 = size1;
      offsetUtcBox2.Size = size36;
      this.OffsetUTCBox.TabIndex = 97;
      this.OffsetUTCBox.TextAlign = HorizontalAlignment.Right;
      this.CurrentDateUTCBox.BackColor = SystemColors.Control;
      this.CurrentDateUTCBox.BorderStyle = BorderStyle.None;
      this.CurrentDateUTCBox.Font = new Font("Microsoft Sans Serif", 8.25f);
      TextBox currentDateUtcBox1 = this.CurrentDateUTCBox;
      point1 = new Point((int) sbyte.MaxValue, 47);
      Point point37 = point1;
      currentDateUtcBox1.Location = point37;
      this.CurrentDateUTCBox.Name = "CurrentDateUTCBox";
      this.CurrentDateUTCBox.ReadOnly = true;
      TextBox currentDateUtcBox2 = this.CurrentDateUTCBox;
      size1 = new Size(115, 13);
      Size size37 = size1;
      currentDateUtcBox2.Size = size37;
      this.CurrentDateUTCBox.TabIndex = 96;
      this.CurrentDateUTCBox.TextAlign = HorizontalAlignment.Right;
      this.CurrentDateBox.BackColor = SystemColors.Control;
      this.CurrentDateBox.BorderStyle = BorderStyle.None;
      this.CurrentDateBox.Font = new Font("Microsoft Sans Serif", 8.25f);
      TextBox currentDateBox1 = this.CurrentDateBox;
      point1 = new Point((int) sbyte.MaxValue, 34);
      Point point38 = point1;
      currentDateBox1.Location = point38;
      this.CurrentDateBox.Name = "CurrentDateBox";
      this.CurrentDateBox.ReadOnly = true;
      TextBox currentDateBox2 = this.CurrentDateBox;
      size1 = new Size(115, 13);
      Size size38 = size1;
      currentDateBox2.Size = size38;
      this.CurrentDateBox.TabIndex = 95;
      this.CurrentDateBox.TextAlign = HorizontalAlignment.Right;
      this.TimeZoneBox.BackColor = SystemColors.Control;
      this.TimeZoneBox.BorderStyle = BorderStyle.None;
      this.TimeZoneBox.Font = new Font("Microsoft Sans Serif", 8.25f);
      TextBox timeZoneBox1 = this.TimeZoneBox;
      point1 = new Point((int) sbyte.MaxValue, 21);
      Point point39 = point1;
      timeZoneBox1.Location = point39;
      this.TimeZoneBox.Name = "TimeZoneBox";
      this.TimeZoneBox.ReadOnly = true;
      TextBox timeZoneBox2 = this.TimeZoneBox;
      size1 = new Size(115, 13);
      Size size39 = size1;
      timeZoneBox2.Size = size39;
      this.TimeZoneBox.TabIndex = 94;
      this.TimeZoneBox.TextAlign = HorizontalAlignment.Right;
      this.Label148.AutoSize = true;
      this.Label148.ImeMode = ImeMode.NoControl;
      Label label148_1 = this.Label148;
      point1 = new Point(6, 60);
      Point point40 = point1;
      label148_1.Location = point40;
      this.Label148.Name = "Label148";
      Label label148_2 = this.Label148;
      size1 = new Size(60, 13);
      Size size40 = size1;
      label148_2.Size = size40;
      this.Label148.TabIndex = 93;
      this.Label148.Text = "Offset UTC";
      this.Label146.AutoSize = true;
      this.Label146.ImeMode = ImeMode.NoControl;
      Label label146_1 = this.Label146;
      point1 = new Point(6, 47);
      Point point41 = point1;
      label146_1.Location = point41;
      this.Label146.Name = "Label146";
      Label label146_2 = this.Label146;
      size1 = new Size(95, 13);
      Size size41 = size1;
      label146_2.Size = size41;
      this.Label146.TabIndex = 91;
      this.Label146.Text = "Curent Date (UTC)";
      this.Label145.AutoSize = true;
      this.Label145.ImeMode = ImeMode.NoControl;
      Label label145_1 = this.Label145;
      point1 = new Point(6, 34);
      Point point42 = point1;
      label145_1.Location = point42;
      this.Label145.Name = "Label145";
      Label label145_2 = this.Label145;
      size1 = new Size(99, 13);
      Size size42 = size1;
      label145_2.Size = size42;
      this.Label145.TabIndex = 90;
      this.Label145.Text = "Curent Date (Local)";
      this.Label144.AutoSize = true;
      this.Label144.ImeMode = ImeMode.NoControl;
      Label label144_1 = this.Label144;
      point1 = new Point(6, 21);
      Point point43 = point1;
      label144_1.Location = point43;
      this.Label144.Name = "Label144";
      Label label144_2 = this.Label144;
      size1 = new Size(32, 13);
      Size size43 = size1;
      label144_2.Size = size43;
      this.Label144.TabIndex = 89;
      this.Label144.Text = "Zone";
      this.GroupBox2.Controls.Add((Control) this.LinkLabel4);
      this.GroupBox2.Controls.Add((Control) this.LinkLabel3);
      this.GroupBox2.Controls.Add((Control) this.LinkLabel1);
      this.GroupBox2.Controls.Add((Control) this.RTST_Link);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(520, 12);
      Point point44 = point1;
      groupBox2_1.Location = point44;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(449, 106);
      Size size44 = size1;
      groupBox2_2.Size = size44;
      this.GroupBox2.TabIndex = 81;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Web links";
      this.LinkLabel4.AutoSize = true;
      this.LinkLabel4.ImeMode = ImeMode.NoControl;
      this.LinkLabel4.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel linkLabel4_1 = this.LinkLabel4;
      point1 = new Point(256, 55);
      Point point45 = point1;
      linkLabel4_1.Location = point45;
      this.LinkLabel4.Name = "LinkLabel4";
      LinkLabel linkLabel4_2 = this.LinkLabel4;
      size1 = new Size(124, 13);
      Size size45 = size1;
      linkLabel4_2.Size = size45;
      this.LinkLabel4.TabIndex = 80;
      this.LinkLabel4.TabStop = true;
      this.LinkLabel4.Text = "TLE Analyser Web Page";
      this.LinkLabel3.AutoSize = true;
      this.LinkLabel3.ImeMode = ImeMode.NoControl;
      this.LinkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel linkLabel3_1 = this.LinkLabel3;
      point1 = new Point(59, 29);
      Point point46 = point1;
      linkLabel3_1.Location = point46;
      this.LinkLabel3.Name = "LinkLabel3";
      LinkLabel linkLabel3_2 = this.LinkLabel3;
      size1 = new Size(126, 13);
      Size size46 = size1;
      linkLabel3_2.Size = size46;
      this.LinkLabel3.TabIndex = 70;
      this.LinkLabel3.TabStop = true;
      this.LinkLabel3.Text = "Celes Track TLE Catalog";
      this.LinkLabel1.AutoSize = true;
      this.LinkLabel1.ImeMode = ImeMode.NoControl;
      this.LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel linkLabel1_1 = this.LinkLabel1;
      point1 = new Point(260, 29);
      Point point47 = point1;
      linkLabel1_1.Location = point47;
      this.LinkLabel1.Name = "LinkLabel1";
      LinkLabel linkLabel1_2 = this.LinkLabel1;
      size1 = new Size(118, 13);
      Size size47 = size1;
      linkLabel1_2.Size = size47;
      this.LinkLabel1.TabIndex = 79;
      this.LinkLabel1.TabStop = true;
      this.LinkLabel1.Text = "NSSDC Master Catalog";
      this.RTST_Link.AutoSize = true;
      this.RTST_Link.ImeMode = ImeMode.NoControl;
      this.RTST_Link.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel rtstLink1 = this.RTST_Link;
      point1 = new Point(53, 55);
      Point point48 = point1;
      rtstLink1.Location = point48;
      this.RTST_Link.Name = "RTST_Link";
      LinkLabel rtstLink2 = this.RTST_Link;
      size1 = new Size(140, 13);
      Size size48 = size1;
      rtstLink2.Size = size48;
      this.RTST_Link.TabIndex = 78;
      this.RTST_Link.TabStop = true;
      this.RTST_Link.Text = "Real Time Satellite Tracking";
      this.OPTIONS_Save.BackColor = SystemColors.Control;
      this.OPTIONS_Save.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.OPTIONS_Save.ImeMode = ImeMode.NoControl;
      Button optionsSave1 = this.OPTIONS_Save;
      point1 = new Point(520, 453);
      Point point49 = point1;
      optionsSave1.Location = point49;
      this.OPTIONS_Save.Name = "OPTIONS_Save";
      Button optionsSave2 = this.OPTIONS_Save;
      size1 = new Size(77, 23);
      Size size49 = size1;
      optionsSave2.Size = size49;
      this.OPTIONS_Save.TabIndex = 97;
      this.OPTIONS_Save.Text = "Save";
      this.OPTIONS_Save.UseVisualStyleBackColor = true;
      this.OPTIONS_LoadDefault.BackColor = SystemColors.Control;
      this.OPTIONS_LoadDefault.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.OPTIONS_LoadDefault.ImeMode = ImeMode.NoControl;
      Button optionsLoadDefault1 = this.OPTIONS_LoadDefault;
      point1 = new Point(666, 453);
      Point point50 = point1;
      optionsLoadDefault1.Location = point50;
      this.OPTIONS_LoadDefault.Name = "OPTIONS_LoadDefault";
      Button optionsLoadDefault2 = this.OPTIONS_LoadDefault;
      size1 = new Size(168, 23);
      Size size50 = size1;
      optionsLoadDefault2.Size = size50;
      this.OPTIONS_LoadDefault.TabIndex = 98;
      this.OPTIONS_LoadDefault.Text = "Load and Save Default Options";
      this.OPTIONS_LoadDefault.UseVisualStyleBackColor = true;
      this.OPTIONS_Close.BackColor = SystemColors.Control;
      this.OPTIONS_Close.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.OPTIONS_Close.ImeMode = ImeMode.NoControl;
      Button optionsClose1 = this.OPTIONS_Close;
      point1 = new Point(896, 453);
      Point point51 = point1;
      optionsClose1.Location = point51;
      this.OPTIONS_Close.Name = "OPTIONS_Close";
      Button optionsClose2 = this.OPTIONS_Close;
      size1 = new Size(73, 23);
      Size size51 = size1;
      optionsClose2.Size = size51;
      this.OPTIONS_Close.TabIndex = 99;
      this.OPTIONS_Close.Text = "Close";
      this.OPTIONS_Close.UseVisualStyleBackColor = true;
      this.Timer1.Interval = 1000;
      this.GroupBox6.Controls.Add((Control) this.TLE_LoadTLEepoch);
      this.GroupBox6.Controls.Add((Control) this.TLE_LoadCurrentEpoch);
      GroupBox groupBox6_1 = this.GroupBox6;
      point1 = new Point(266, 183);
      Point point52 = point1;
      groupBox6_1.Location = point52;
      this.GroupBox6.Name = "GroupBox6";
      GroupBox groupBox6_2 = this.GroupBox6;
      size1 = new Size(248, 72);
      Size size52 = size1;
      groupBox6_2.Size = size52;
      this.GroupBox6.TabIndex = 90;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "TLE Options";
      this.TLE_LoadTLEepoch.AutoSize = true;
      this.TLE_LoadTLEepoch.ImeMode = ImeMode.NoControl;
      RadioButton tleLoadTlEepoch1 = this.TLE_LoadTLEepoch;
      point1 = new Point(9, 42);
      Point point53 = point1;
      tleLoadTlEepoch1.Location = point53;
      this.TLE_LoadTLEepoch.Name = "TLE_LoadTLEepoch";
      RadioButton tleLoadTlEepoch2 = this.TLE_LoadTLEepoch;
      size1 = new Size(140, 17);
      Size size53 = size1;
      tleLoadTlEepoch2.Size = size53;
      this.TLE_LoadTLEepoch.TabIndex = 97;
      this.TLE_LoadTLEepoch.Text = "Load TLE at TLE epoch";
      this.TLE_LoadTLEepoch.UseVisualStyleBackColor = true;
      this.TLE_LoadCurrentEpoch.AutoSize = true;
      this.TLE_LoadCurrentEpoch.Checked = true;
      this.TLE_LoadCurrentEpoch.ImeMode = ImeMode.NoControl;
      RadioButton loadCurrentEpoch1 = this.TLE_LoadCurrentEpoch;
      point1 = new Point(9, 19);
      Point point54 = point1;
      loadCurrentEpoch1.Location = point54;
      this.TLE_LoadCurrentEpoch.Name = "TLE_LoadCurrentEpoch";
      RadioButton loadCurrentEpoch2 = this.TLE_LoadCurrentEpoch;
      size1 = new Size(153, 17);
      Size size54 = size1;
      loadCurrentEpoch2.Size = size54;
      this.TLE_LoadCurrentEpoch.TabIndex = 96;
      this.TLE_LoadCurrentEpoch.TabStop = true;
      this.TLE_LoadCurrentEpoch.Text = "Load TLE at current epoch";
      this.TLE_LoadCurrentEpoch.UseVisualStyleBackColor = true;
      this.Label27.AutoSize = true;
      this.Label27.ImeMode = ImeMode.NoControl;
      Label label27_1 = this.Label27;
      point1 = new Point(259, 16);
      Point point55 = point1;
      label27_1.Location = point55;
      this.Label27.Name = "Label27";
      Label label27_2 = this.Label27;
      size1 = new Size(187, 286);
      Size size55 = size1;
      label27_2.Size = size55;
      this.Label27.TabIndex = 120;
      this.Label27.Text = componentResourceManager.GetString("Label27.Text");
      this.Label41.AutoSize = true;
      this.Label41.ImeMode = ImeMode.NoControl;
      Label label41_1 = this.Label41;
      point1 = new Point(6, 16);
      Point point56 = point1;
      label41_1.Location = point56;
      this.Label41.Name = "Label41";
      Label label41_2 = this.Label41;
      size1 = new Size(34, 299);
      Size size56 = size1;
      label41_2.Size = size56;
      this.Label41.TabIndex = 117;
      this.Label41.Text = "AEL\r\nALT\r\nAN\r\nAOL\r\nAOP\r\nAP\r\nApA\r\nApR\r\nApV\r\nDL\r\nEA\r\nECC\r\nETFP\r\nETFE\r\nex\r\ney\r\nGST\r\nINC\r\nix\r\niy\r\nLAcc\r\nLAN\r\nLAT";
      this.Label41.TextAlign = ContentAlignment.TopRight;
      this.Label2.AutoSize = true;
      this.Label2.ImeMode = ImeMode.NoControl;
      Label label2_1 = this.Label2;
      point1 = new Point(216, 16);
      Point point57 = point1;
      label2_1.Location = point57;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(38, 286);
      Size size57 = size1;
      label2_2.Size = size57;
      this.Label2.TabIndex = 119;
      this.Label2.Text = "LNG\r\nLTAN\r\nLST\r\nML\r\nMA\r\nMALT\r\nMM\r\nNP\r\nONAE\r\nPeA\r\nPeR\r\nPeV\r\nRAAN\r\nDREL\r\nVEL\r\nSDOO\r\nSMA\r\nTA\r\nTa\r\nTd\r\nTLE\r\nω'";
      this.Label2.TextAlign = ContentAlignment.TopRight;
      this.Label64.AutoSize = true;
      this.Label64.ImeMode = ImeMode.NoControl;
      Label label64_1 = this.Label64;
      point1 = new Point(39, 16);
      Point point58 = point1;
      label64_1.Location = point58;
      this.Label64.Name = "Label64";
      Label label64_2 = this.Label64;
      size1 = new Size(154, 299);
      Size size58 = size1;
      label64_2.Size = size58;
      this.Label64.TabIndex = 118;
      this.Label64.Text = componentResourceManager.GetString("Label64.Text");
      this.GroupBox7.Controls.Add((Control) this.Label41);
      this.GroupBox7.Controls.Add((Control) this.Label27);
      this.GroupBox7.Controls.Add((Control) this.Label64);
      this.GroupBox7.Controls.Add((Control) this.Label2);
      GroupBox groupBox7_1 = this.GroupBox7;
      point1 = new Point(520, 124);
      Point point59 = point1;
      groupBox7_1.Location = point59;
      this.GroupBox7.Name = "GroupBox7";
      GroupBox groupBox7_2 = this.GroupBox7;
      size1 = new Size(449, 323);
      Size size59 = size1;
      groupBox7_2.Size = size59;
      this.GroupBox7.TabIndex = 121;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "Glossary";
      this.GroupBox8.Controls.Add((Control) this.Label5);
      this.GroupBox8.Controls.Add((Control) this.GS_LimitAngle);
      this.GroupBox8.Controls.Add((Control) this.GS_ShortName);
      this.GroupBox8.Controls.Add((Control) this.GS_FullName);
      GroupBox groupBox8_1 = this.GroupBox8;
      point1 = new Point(266, 352);
      Point point60 = point1;
      groupBox8_1.Location = point60;
      this.GroupBox8.Name = "GroupBox8";
      GroupBox groupBox8_2 = this.GroupBox8;
      size1 = new Size(248, 68);
      Size size60 = size1;
      groupBox8_2.Size = size60;
      this.GroupBox8.TabIndex = 122;
      this.GroupBox8.TabStop = false;
      this.GroupBox8.Text = "Ground Stations";
      this.Label5.AutoSize = true;
      this.Label5.ImeMode = ImeMode.NoControl;
      Label label5_1 = this.Label5;
      point1 = new Point(159, 26);
      Point point61 = point1;
      label5_1.Location = point61;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(27, 13);
      Size size61 = size1;
      label5_2.Size = size61;
      this.Label5.TabIndex = 101;
      this.Label5.Text = "AEL";
      this.GS_LimitAngle.BackColor = SystemColors.Window;
      this.GS_LimitAngle.DropDownStyle = ComboBoxStyle.DropDownList;
      this.GS_LimitAngle.FormattingEnabled = true;
      this.GS_LimitAngle.Items.AddRange(new object[5]
      {
        (object) "0",
        (object) "5",
        (object) "10",
        (object) "15",
        (object) "20"
      });
      ComboBox gsLimitAngle1 = this.GS_LimitAngle;
      point1 = new Point(192, 23);
      Point point62 = point1;
      gsLimitAngle1.Location = point62;
      this.GS_LimitAngle.Name = "GS_LimitAngle";
      ComboBox gsLimitAngle2 = this.GS_LimitAngle;
      size1 = new Size(50, 21);
      Size size62 = size1;
      gsLimitAngle2.Size = size62;
      this.GS_LimitAngle.TabIndex = 100;
      this.GS_ShortName.AutoSize = true;
      this.GS_ShortName.Checked = true;
      this.GS_ShortName.ImeMode = ImeMode.NoControl;
      RadioButton gsShortName1 = this.GS_ShortName;
      point1 = new Point(9, 46);
      Point point63 = point1;
      gsShortName1.Location = point63;
      this.GS_ShortName.Name = "GS_ShortName";
      RadioButton gsShortName2 = this.GS_ShortName;
      size1 = new Size(84, 17);
      Size size63 = size1;
      gsShortName2.Size = size63;
      this.GS_ShortName.TabIndex = 99;
      this.GS_ShortName.TabStop = true;
      this.GS_ShortName.Text = "Short names";
      this.GS_ShortName.UseVisualStyleBackColor = true;
      this.GS_FullName.AutoSize = true;
      this.GS_FullName.ImeMode = ImeMode.NoControl;
      RadioButton gsFullName1 = this.GS_FullName;
      point1 = new Point(9, 23);
      Point point64 = point1;
      gsFullName1.Location = point64;
      this.GS_FullName.Name = "GS_FullName";
      RadioButton gsFullName2 = this.GS_FullName;
      size1 = new Size(75, 17);
      Size size64 = size1;
      gsFullName2.Size = size64;
      this.GS_FullName.TabIndex = 98;
      this.GS_FullName.Text = "Full names";
      this.GS_FullName.UseVisualStyleBackColor = true;
      this.GroupBox5.Controls.Add((Control) this.AltMeanRadius);
      GroupBox groupBox5_1 = this.GroupBox5;
      point1 = new Point(266, 426);
      Point point65 = point1;
      groupBox5_1.Location = point65;
      this.GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = this.GroupBox5;
      size1 = new Size(248, 48);
      Size size65 = size1;
      groupBox5_2.Size = size65;
      this.GroupBox5.TabIndex = 123;
      this.GroupBox5.TabStop = false;
      this.GroupBox5.Text = "Elements Options";
      this.AltMeanRadius.AutoSize = true;
      CheckBox altMeanRadius1 = this.AltMeanRadius;
      point1 = new Point(6, 19);
      Point point66 = point1;
      altMeanRadius1.Location = point66;
      this.AltMeanRadius.Name = "AltMeanRadius";
      CheckBox altMeanRadius2 = this.AltMeanRadius;
      size1 = new Size(166, 17);
      Size size66 = size1;
      altMeanRadius2.Size = size66;
      this.AltMeanRadius.TabIndex = 101;
      this.AltMeanRadius.Text = "Altitudes wrt equatorial radius ";
      this.AltMeanRadius.UseVisualStyleBackColor = true;
      this.GroupBox9.Controls.Add((Control) this.CAT_Download);
      GroupBox groupBox9_1 = this.GroupBox9;
      point1 = new Point(266, 103);
      Point point67 = point1;
      groupBox9_1.Location = point67;
      this.GroupBox9.Name = "GroupBox9";
      GroupBox groupBox9_2 = this.GroupBox9;
      size1 = new Size(248, 74);
      Size size67 = size1;
      groupBox9_2.Size = size67;
      this.GroupBox9.TabIndex = 124;
      this.GroupBox9.TabStop = false;
      this.GroupBox9.Text = "Catalog Updater";
      this.CAT_Download.BackColor = Color.FromArgb(128, (int) byte.MaxValue, 128);
      this.CAT_Download.ImeMode = ImeMode.NoControl;
      Button catDownload1 = this.CAT_Download;
      point1 = new Point(68, 28);
      Point point68 = point1;
      catDownload1.Location = point68;
      this.CAT_Download.Name = "CAT_Download";
      Button catDownload2 = this.CAT_Download;
      size1 = new Size(118, 23);
      Size size68 = size1;
      catDownload2.Size = size68;
      this.CAT_Download.TabIndex = 87;
      this.CAT_Download.Text = "Update Catalog";
      this.CAT_Download.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      size1 = new Size(975, 488);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GroupBox9);
      this.Controls.Add((Control) this.GroupBox5);
      this.Controls.Add((Control) this.GroupBox8);
      this.Controls.Add((Control) this.GroupBox7);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox13);
      this.Controls.Add((Control) this.Label61);
      this.Controls.Add((Control) this.Label60);
      this.Controls.Add((Control) this.GroupBox12);
      this.Controls.Add((Control) this.GroupBox6);
      this.Controls.Add((Control) this.GroupBox19);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.OPTIONS_Close);
      this.Controls.Add((Control) this.OPTIONS_Save);
      this.Controls.Add((Control) this.OPTIONS_LoadDefault);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      size1 = new Size(991, 578);
      this.MaximumSize = size1;
      this.MinimizeBox = false;
      this.Name = nameof (Options);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (Options);
      this.TopMost = true;
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      ((ISupportInitialize) this.SatPictOp2).EndInit();
      ((ISupportInitialize) this.SatPictOp1).EndInit();
      this.GroupBox19.ResumeLayout(false);
      this.GroupBox19.PerformLayout();
      ((ISupportInitialize) this.SatPictOp3).EndInit();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.GroupBox12.ResumeLayout(false);
      this.GroupBox12.PerformLayout();
      this.GroupBox13.ResumeLayout(false);
      this.GroupBox13.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      this.GroupBox8.ResumeLayout(false);
      this.GroupBox8.PerformLayout();
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.GroupBox9.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual Button TLE_Download
    {
      [DebuggerNonUserCode] get => this._TLE_Download;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DownloadTLE_Click);
        if (this._TLE_Download != null)
          this._TLE_Download.Click -= eventHandler;
        this._TLE_Download = value;
        if (this._TLE_Download == null)
          return;
        this._TLE_Download.Click += eventHandler;
      }
    }

    internal virtual ProgressBar TLE_ProgressBar
    {
      [DebuggerNonUserCode] get => this._TLE_ProgressBar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TLE_ProgressBar = value;
    }

    internal virtual LinkLabel LinkLabel3
    {
      [DebuggerNonUserCode] get => this._LinkLabel3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
        if (this._LinkLabel3 != null)
          this._LinkLabel3.LinkClicked -= clickedEventHandler;
        this._LinkLabel3 = value;
        if (this._LinkLabel3 == null)
          return;
        this._LinkLabel3.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual GroupBox GroupBox12
    {
      [DebuggerNonUserCode] get => this._GroupBox12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox12 = value;
    }

    internal virtual Label Label59
    {
      [DebuggerNonUserCode] get => this._Label59;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label59 = value;
    }

    internal virtual Label Label58
    {
      [DebuggerNonUserCode] get => this._Label58;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label58 = value;
    }

    internal virtual RadioButton GMAT_FullModel
    {
      [DebuggerNonUserCode] get => this._GMAT_FullModel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GMAT_FullModel_CheckedChanged);
        if (this._GMAT_FullModel != null)
          this._GMAT_FullModel.Click -= eventHandler;
        this._GMAT_FullModel = value;
        if (this._GMAT_FullModel == null)
          return;
        this._GMAT_FullModel.Click += eventHandler;
      }
    }

    internal virtual RadioButton GMAT_PartialModel
    {
      [DebuggerNonUserCode] get => this._GMAT_PartialModel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GMAT_PartialModel_CheckedChanged);
        if (this._GMAT_PartialModel != null)
          this._GMAT_PartialModel.Click -= eventHandler;
        this._GMAT_PartialModel = value;
        if (this._GMAT_PartialModel == null)
          return;
        this._GMAT_PartialModel.Click += eventHandler;
      }
    }

    internal virtual Label Label56
    {
      [DebuggerNonUserCode] get => this._Label56;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label56 = value;
    }

    internal virtual LinkLabel LinkLabel2
    {
      [DebuggerNonUserCode] get => this._LinkLabel2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
        if (this._LinkLabel2 != null)
          this._LinkLabel2.LinkClicked -= clickedEventHandler;
        this._LinkLabel2 = value;
        if (this._LinkLabel2 == null)
          return;
        this._LinkLabel2.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Label Label55
    {
      [DebuggerNonUserCode] get => this._Label55;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label55 = value;
    }

    internal virtual ComboBox GMAT_Period
    {
      [DebuggerNonUserCode] get => this._GMAT_Period;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GMAT_Period_SelectedIndexChanged);
        if (this._GMAT_Period != null)
          this._GMAT_Period.Click -= eventHandler;
        this._GMAT_Period = value;
        if (this._GMAT_Period == null)
          return;
        this._GMAT_Period.Click += eventHandler;
      }
    }

    internal virtual CheckBox GMAT_ShowTrack
    {
      [DebuggerNonUserCode] get => this._GMAT_ShowTrack;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GMAT_ShowTrack_CheckedChanged);
        if (this._GMAT_ShowTrack != null)
          this._GMAT_ShowTrack.Click -= eventHandler;
        this._GMAT_ShowTrack = value;
        if (this._GMAT_ShowTrack == null)
          return;
        this._GMAT_ShowTrack.Click += eventHandler;
      }
    }

    internal virtual PictureBox SatPictOp2
    {
      [DebuggerNonUserCode] get => this._SatPictOp2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SatPictOp2 = value;
    }

    internal virtual PictureBox SatPictOp1
    {
      [DebuggerNonUserCode] get => this._SatPictOp1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SatPictOp1 = value;
    }

    internal virtual RadioButton MAP_SatIcon3
    {
      [DebuggerNonUserCode] get => this._MAP_SatIcon3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MAP_SatIcon3_CheckedChanged);
        if (this._MAP_SatIcon3 != null)
          this._MAP_SatIcon3.Click -= eventHandler;
        this._MAP_SatIcon3 = value;
        if (this._MAP_SatIcon3 == null)
          return;
        this._MAP_SatIcon3.Click += eventHandler;
      }
    }

    internal virtual RadioButton MAP_SatIcon1
    {
      [DebuggerNonUserCode] get => this._MAP_SatIcon1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MAP_SatIcon1_CheckedChanged);
        if (this._MAP_SatIcon1 != null)
          this._MAP_SatIcon1.Click -= eventHandler;
        this._MAP_SatIcon1 = value;
        if (this._MAP_SatIcon1 == null)
          return;
        this._MAP_SatIcon1.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox19
    {
      [DebuggerNonUserCode] get => this._GroupBox19;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox19 = value;
    }

    internal virtual ComboBox TRACK_Speed
    {
      [DebuggerNonUserCode] get => this._TRACK_Speed;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TRACK_Speed_SelectedIndexChanged);
        if (this._TRACK_Speed != null)
          this._TRACK_Speed.Click -= eventHandler;
        this._TRACK_Speed = value;
        if (this._TRACK_Speed == null)
          return;
        this._TRACK_Speed.Click += eventHandler;
      }
    }

    internal virtual Label Label143
    {
      [DebuggerNonUserCode] get => this._Label143;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label143 = value;
    }

    internal virtual LinkLabel LinkLabel4
    {
      [DebuggerNonUserCode] get => this._LinkLabel4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
        if (this._LinkLabel4 != null)
          this._LinkLabel4.LinkClicked -= clickedEventHandler;
        this._LinkLabel4 = value;
        if (this._LinkLabel4 == null)
          return;
        this._LinkLabel4.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel LinkLabel1
    {
      [DebuggerNonUserCode] get => this._LinkLabel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
        if (this._LinkLabel1 != null)
          this._LinkLabel1.LinkClicked -= clickedEventHandler;
        this._LinkLabel1 = value;
        if (this._LinkLabel1 == null)
          return;
        this._LinkLabel1.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel RTST_Link
    {
      [DebuggerNonUserCode] get => this._RTST_Link;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.RTST_Link_LinkClicked);
        if (this._RTST_Link != null)
          this._RTST_Link.LinkClicked -= clickedEventHandler;
        this._RTST_Link = value;
        if (this._RTST_Link == null)
          return;
        this._RTST_Link.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      [DebuggerNonUserCode] get => this._GroupBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox1 = value;
    }

    internal virtual GroupBox GroupBox13
    {
      [DebuggerNonUserCode] get => this._GroupBox13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox13 = value;
    }

    internal virtual TextBox OffsetUTCBox
    {
      [DebuggerNonUserCode] get => this._OffsetUTCBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._OffsetUTCBox = value;
    }

    internal virtual TextBox CurrentDateUTCBox
    {
      [DebuggerNonUserCode] get => this._CurrentDateUTCBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CurrentDateUTCBox = value;
    }

    internal virtual TextBox CurrentDateBox
    {
      [DebuggerNonUserCode] get => this._CurrentDateBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CurrentDateBox = value;
    }

    internal virtual TextBox TimeZoneBox
    {
      [DebuggerNonUserCode] get => this._TimeZoneBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TimeZoneBox = value;
    }

    internal virtual Label Label148
    {
      [DebuggerNonUserCode] get => this._Label148;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label148 = value;
    }

    internal virtual Label Label146
    {
      [DebuggerNonUserCode] get => this._Label146;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label146 = value;
    }

    internal virtual Label Label145
    {
      [DebuggerNonUserCode] get => this._Label145;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label145 = value;
    }

    internal virtual Label Label144
    {
      [DebuggerNonUserCode] get => this._Label144;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label144 = value;
    }

    internal virtual GroupBox GroupBox2
    {
      [DebuggerNonUserCode] get => this._GroupBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox2 = value;
    }

    internal virtual Label Label61
    {
      [DebuggerNonUserCode] get => this._Label61;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label61 = value;
    }

    internal virtual Label Label60
    {
      [DebuggerNonUserCode] get => this._Label60;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label60 = value;
    }

    internal virtual Button OPTIONS_Save
    {
      [DebuggerNonUserCode] get => this._OPTIONS_Save;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OPTIONS_Save_Click);
        if (this._OPTIONS_Save != null)
          this._OPTIONS_Save.Click -= eventHandler;
        this._OPTIONS_Save = value;
        if (this._OPTIONS_Save == null)
          return;
        this._OPTIONS_Save.Click += eventHandler;
      }
    }

    internal virtual Button OPTIONS_LoadDefault
    {
      [DebuggerNonUserCode] get => this._OPTIONS_LoadDefault;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.DefOptButt_Click);
        if (this._OPTIONS_LoadDefault != null)
          this._OPTIONS_LoadDefault.Click -= eventHandler;
        this._OPTIONS_LoadDefault = value;
        if (this._OPTIONS_LoadDefault == null)
          return;
        this._OPTIONS_LoadDefault.Click += eventHandler;
      }
    }

    internal virtual Button OPTIONS_Close
    {
      [DebuggerNonUserCode] get => this._OPTIONS_Close;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CloseButt_Click);
        if (this._OPTIONS_Close != null)
          this._OPTIONS_Close.Click -= eventHandler;
        this._OPTIONS_Close = value;
        if (this._OPTIONS_Close == null)
          return;
        this._OPTIONS_Close.Click += eventHandler;
      }
    }

    internal virtual Timer Timer1
    {
      [DebuggerNonUserCode] get => this._Timer1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
        if (this._Timer1 != null)
          this._Timer1.Tick -= eventHandler;
        this._Timer1 = value;
        if (this._Timer1 == null)
          return;
        this._Timer1.Tick += eventHandler;
      }
    }

    internal virtual Label TleLastUpdate
    {
      [DebuggerNonUserCode] get => this._TleLastUpdate;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TleLastUpdate = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual CheckBox TRACK_RTMStart
    {
      [DebuggerNonUserCode] get => this._TRACK_RTMStart;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TRACK_RTMStart_CheckedChanged);
        if (this._TRACK_RTMStart != null)
          this._TRACK_RTMStart.Click -= eventHandler;
        this._TRACK_RTMStart = value;
        if (this._TRACK_RTMStart == null)
          return;
        this._TRACK_RTMStart.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox6
    {
      [DebuggerNonUserCode] get => this._GroupBox6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox6 = value;
    }

    internal virtual RadioButton TLE_LoadTLEepoch
    {
      [DebuggerNonUserCode] get => this._TLE_LoadTLEepoch;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TLE_LoadTLEepoch_CheckedChanged);
        if (this._TLE_LoadTLEepoch != null)
          this._TLE_LoadTLEepoch.Click -= eventHandler;
        this._TLE_LoadTLEepoch = value;
        if (this._TLE_LoadTLEepoch == null)
          return;
        this._TLE_LoadTLEepoch.Click += eventHandler;
      }
    }

    internal virtual RadioButton TLE_LoadCurrentEpoch
    {
      [DebuggerNonUserCode] get => this._TLE_LoadCurrentEpoch;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TLE_LoadCurrentEpoch_CheckedChanged);
        if (this._TLE_LoadCurrentEpoch != null)
          this._TLE_LoadCurrentEpoch.Click -= eventHandler;
        this._TLE_LoadCurrentEpoch = value;
        if (this._TLE_LoadCurrentEpoch == null)
          return;
        this._TLE_LoadCurrentEpoch.Click += eventHandler;
      }
    }

    internal virtual Label Label27
    {
      [DebuggerNonUserCode] get => this._Label27;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
    }

    internal virtual Label Label41
    {
      [DebuggerNonUserCode] get => this._Label41;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label41 = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Label Label64
    {
      [DebuggerNonUserCode] get => this._Label64;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label64 = value;
    }

    internal virtual GroupBox GroupBox7
    {
      [DebuggerNonUserCode] get => this._GroupBox7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox7 = value;
    }

    internal virtual GroupBox GroupBox8
    {
      [DebuggerNonUserCode] get => this._GroupBox8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox8 = value;
    }

    internal virtual RadioButton GS_ShortName
    {
      [DebuggerNonUserCode] get => this._GS_ShortName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_ShortName_CheckedChanged);
        if (this._GS_ShortName != null)
          this._GS_ShortName.Click -= eventHandler;
        this._GS_ShortName = value;
        if (this._GS_ShortName == null)
          return;
        this._GS_ShortName.Click += eventHandler;
      }
    }

    internal virtual RadioButton GS_FullName
    {
      [DebuggerNonUserCode] get => this._GS_FullName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_FullName_CheckedChanged);
        if (this._GS_FullName != null)
          this._GS_FullName.Click -= eventHandler;
        this._GS_FullName = value;
        if (this._GS_FullName == null)
          return;
        this._GS_FullName.Click += eventHandler;
      }
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual ComboBox GS_LimitAngle
    {
      [DebuggerNonUserCode] get => this._GS_LimitAngle;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_LimitAngle_SelectedIndexChanged);
        if (this._GS_LimitAngle != null)
          this._GS_LimitAngle.Click -= eventHandler;
        this._GS_LimitAngle = value;
        if (this._GS_LimitAngle == null)
          return;
        this._GS_LimitAngle.Click += eventHandler;
      }
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual PictureBox SatPictOp3
    {
      [DebuggerNonUserCode] get => this._SatPictOp3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SatPictOp3 = value;
    }

    internal virtual RadioButton MAP_SatIcon2
    {
      [DebuggerNonUserCode] get => this._MAP_SatIcon2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MAP_SatIcon2_CheckedChanged);
        if (this._MAP_SatIcon2 != null)
          this._MAP_SatIcon2.Click -= eventHandler;
        this._MAP_SatIcon2 = value;
        if (this._MAP_SatIcon2 == null)
          return;
        this._MAP_SatIcon2.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox4
    {
      [DebuggerNonUserCode] get => this._GroupBox4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox4 = value;
    }

    internal virtual GroupBox GroupBox3
    {
      [DebuggerNonUserCode] get => this._GroupBox3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox3 = value;
    }

    internal virtual Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal virtual ComboBox TRACK_RTMStep
    {
      [DebuggerNonUserCode] get => this._TRACK_RTMStep;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TRACK_RTMStep_SelectedIndexChanged);
        if (this._TRACK_RTMStep != null)
          this._TRACK_RTMStep.Click -= eventHandler;
        this._TRACK_RTMStep = value;
        if (this._TRACK_RTMStep == null)
          return;
        this._TRACK_RTMStep.Click += eventHandler;
      }
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual GroupBox GroupBox5
    {
      [DebuggerNonUserCode] get => this._GroupBox5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox5 = value;
    }

    internal virtual CheckBox AltMeanRadius
    {
      [DebuggerNonUserCode] get => this._AltMeanRadius;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AltMeanRadius = value;
    }

    internal virtual GroupBox GroupBox9
    {
      [DebuggerNonUserCode] get => this._GroupBox9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox9 = value;
    }

    internal virtual Button CAT_Download
    {
      [DebuggerNonUserCode] get => this._CAT_Download;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CAT_Download_Click);
        if (this._CAT_Download != null)
          this._CAT_Download.Click -= eventHandler;
        this._CAT_Download = value;
        if (this._CAT_Download == null)
          return;
        this._CAT_Download.Click += eventHandler;
      }
    }

    private void Load_App_1(object sender, EventArgs e)
    {
      MyProject.Forms.Home.OptionsSaved = true;
      Functions.ReadInit();
      this.CheckTLEDate();
      Functions.TimeZoneDef();
      this.Timer1.Enabled = true;
    }

    private void Load_App_2(object sender, CancelEventArgs e)
    {
      if (!MyProject.Forms.Home.OptionsSaved && TopMostMessageBox.Show("Quit Options without saving ?", "TLE Analyser", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.No)
        e.Cancel = true;
      this.Timer1.Enabled = false;
    }

    private void OPTIONS_Save_Click(object sender, EventArgs e)
    {
      MyProject.Forms.Home.OptionsSaved = true;
      if (!MyProject.Forms.Home.TLELoaded)
      {
        Functions.SaveInit();
      }
      else
      {
        Functions.SaveInit();
        MyProject.Forms.Home.TLE_Prediction();
        MyProject.Forms.Home.Graph_Actualise(true);
      }
    }

    private void DefOptButt_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Are you sure ?", MsgBoxStyle.YesNo, (object) nameof (Options)) != MsgBoxResult.Yes)
        return;
      this.GMAT_ShowTrack.Checked = true;
      this.GMAT_FullModel.Checked = true;
      this.GMAT_Period.SelectedItem = (object) "1";
      this.TRACK_RTMStart.Checked = false;
      this.TRACK_Speed.SelectedItem = (object) "1";
      this.TRACK_RTMStep.SelectedItem = (object) "1";
      this.MAP_SatIcon3.Checked = true;
      this.TLE_LoadCurrentEpoch.Checked = true;
      this.TLE_LoadTLEepoch.Checked = false;
      this.GS_FullName.Checked = false;
      this.GS_ShortName.Checked = true;
      this.GS_LimitAngle.SelectedItem = (object) "90";
      this.AltMeanRadius.Checked = false;
      Functions.SaveInit();
      MyProject.Forms.Home.OptionsSaved = true;
    }

    private void CloseButt_Click(object sender, EventArgs e) => this.Close();

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void DownloadTLE_Click(object sender, EventArgs e)
    {
      string Left1 = "http://www.celestrak.com/NORAD/elements/";
      string Left2 = "http://www.celestrak.com/NORAD/elements/supplemental/";
      if (!MyProject.Forms.Home.CheckNW)
      {
        int num1 = (int) TopMostMessageBox.Show("You must be connected to upload TLE lists", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        try
        {
          FileSystem.FileOpen(1, "C:\\TLEAnalyser\\TLE\\TLEList.txt", OpenMode.Input);
          this.TLE_ProgressBar.Visible = true;
          this.TLE_ProgressBar.Value = 0;
          while (!FileSystem.EOF(1))
          {
            object obj = (object) (FileSystem.LineInput(1) + ".txt");
            if (Operators.ConditionalCompareObjectNotEqual(obj, (object) "personal", false))
              NewLateBinding.LateCall((object) MyProject.Computer.Network, (Type) null, "DownloadFile", new object[7]
              {
                Operators.ConcatenateObject((object) Left1, obj),
                Operators.ConcatenateObject((object) MyProject.Forms.Home.TLEPath, obj),
                (object) "",
                (object) "",
                (object) false,
                (object) 100000,
                (object) true
              }, (string[]) null, (Type[]) null, (bool[]) null, true);
            checked { this.TLE_ProgressBar.Value += 2; }
          }
          FileSystem.FileClose(1);
          FileSystem.FileOpen(1, "C:\\TLEAnalyser\\TLE\\SuppList.txt", OpenMode.Input);
          while (!FileSystem.EOF(1))
          {
            object Right = (object) (FileSystem.LineInput(1) + ".txt");
            NewLateBinding.LateCall((object) MyProject.Computer.Network, (Type) null, "DownloadFile", new object[7]
            {
              Operators.ConcatenateObject((object) Left2, Right),
              Operators.ConcatenateObject((object) MyProject.Forms.Home.TLEPath, Right),
              (object) "",
              (object) "",
              (object) false,
              (object) 100000,
              (object) true
            }, (string[]) null, (Type[]) null, (bool[]) null, true);
            checked { this.TLE_ProgressBar.Value += 2; }
          }
          FileSystem.FileClose(1);
          this.TLE_ProgressBar.Value = 0;
          this.TLE_ProgressBar.Visible = false;
          MyProject.Forms.Home.TleUpdateDate = Conversions.ToString(DateTime.Now);
          Functions.SaveInit();
          Functions.ReadInit();
          MyProject.Forms.Home.TLE_ListBox.Items.Clear();
          FileSystem.FileOpen(1, "C:\\TLEAnalyser\\TLE\\TLEList.txt", OpenMode.Input);
          while (!FileSystem.EOF(1))
            MyProject.Forms.Home.TLE_ListBox.Items.Add(Operators.ConcatenateObject((object) FileSystem.LineInput(1), (object) ".txt"));
          FileSystem.FileClose(1);
          FileSystem.FileOpen(1, "C:\\TLEAnalyser\\TLE\\SuppList.txt", OpenMode.Input);
          while (!FileSystem.EOF(1))
            MyProject.Forms.Home.TLE_ListBox.Items.Add(Operators.ConcatenateObject((object) FileSystem.LineInput(1), (object) ".txt"));
          FileSystem.FileClose(1);
          string favPath = MyProject.Forms.Home.FavPath;
          string[] files = Directory.GetFiles(favPath);
          int num2 = checked (Directory.GetFiles(favPath).Length - 1);
          int index = 0;
          while (index <= num2)
          {
            string StringCheck = files[index];
            string str = StringCheck.Remove(0, Strings.InStrRev(StringCheck, "\\"));
            if (str.StartsWith("fleet_"))
              MyProject.Forms.Home.TLE_ListBox.Items.Add((object) str);
            checked { ++index; }
          }
          int num3 = (int) TopMostMessageBox.Show("Update Successfull", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num4 = (int) TopMostMessageBox.Show("Your Network seems to be restricted:\r\nTLE ANALYSER can't dowload updated TLE.\r\n\r\n" + ex.Message, "TLE ANALYSER - Error");
          FileSystem.FileClose(1);
          ProjectData.ClearProjectError();
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void CAT_Download_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      if (!Functions.CheckNetwork())
      {
        int num = (int) Interaction.MsgBox((object) "You must be connected to download the catalogue.", MsgBoxStyle.Information, (object) "TLE Analyser");
        this.Cursor = Cursors.Default;
      }
      else if (!MyProject.Forms.Home.CheckNW)
      {
        int num1 = (int) TopMostMessageBox.Show("You must be connected to download the catalogue.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        try
        {
          MyProject.Computer.Network.DownloadFile("http://www.celestrak.com/pub/satcat.txt", MyProject.Forms.Home.SatCat, "", "", false, 10000, true);
          MyProject.Computer.Network.DownloadFile("http://www.celestrak.com/pub/satcat-annex.txt", MyProject.Forms.Home.SatCatAnn, "", "", false, 10000, true);
          this.Cursor = Cursors.Default;
          int num2 = (int) TopMostMessageBox.Show("Dowload Successfull", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num3 = (int) TopMostMessageBox.Show("Your Network seems to be restricted:\r\nTLE ANALYSER can't dowload the Catalog.\r\n\r\n" + ex.Message, "TLE ANALYSER - Error");
          FileSystem.FileClose(1);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void CheckTLEDate()
    {
      if (!MyProject.Forms.Home.CheckNW)
        return;
      string tleUpdateDate = MyProject.Forms.Home.TleUpdateDate;
      DateTime date = DateAndTime.Now.Date;
      if (Operators.CompareString(tleUpdateDate, (string) null, false) == 0 | Operators.CompareString(tleUpdateDate, "", false) == 0 | Operators.CompareString(tleUpdateDate, " ", false) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "TLE have not been updated for 10 days or more.", MsgBoxStyle.Information, (object) "TLE ANALYSER");
      }
      else if (DateAndTime.DateDiff("d", (object) Conversions.ToString(Conversions.ToDate(MyProject.Forms.Home.TleUpdateDate)), (object) date) > 10L)
      {
        int num2 = (int) Interaction.MsgBox((object) "TLE have not been updated for 10 days or more.", MsgBoxStyle.Information, (object) "TLE ANALYSER");
      }
    }

    private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://nssdc.gsfc.nasa.gov/nmc/masterCatalog.do?sc=" + MyProject.Forms.Home.CATNUMB);

    private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://gmat.gsfc.nasa.gov/");

    private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://www.celestrak.com/NORAD/elements/");

    private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://tleanalyser.blogspot.fr");

    private void RTST_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("http://www.n2yo.com/?s=" + MyProject.Forms.Home.Spacecraft.Text);

    private void TimeZone_Timer(object sender, EventArgs e) => this.Timer1.Enabled = true;

    private void Timer1_Tick(object sender, EventArgs e) => Functions.TimeZoneDef();

    private void TRACK_Speed_SelectedIndexChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void TRACK_RTMStart_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void TRACK_RTMStep_SelectedIndexChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void MAP_SatIcon1_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void MAP_SatIcon2_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void MAP_SatIcon3_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void GMAT_ShowTrack_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void GMAT_PartialModel_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void GMAT_FullModel_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void GMAT_Period_SelectedIndexChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void TLE_LoadCurrentEpoch_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void TLE_LoadTLEepoch_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void GS_FullName_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void GS_ShortName_CheckedChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;

    private void GS_LimitAngle_SelectedIndexChanged(object sender, EventArgs e) => MyProject.Forms.Home.OptionsSaved = false;
  }
}
