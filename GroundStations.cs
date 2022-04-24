// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.GroundStations
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
  public class GroundStations : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("GS_Range_Day")]
    private RadioButton _GS_Range_Day;
    [AccessedThroughProperty("GS_Range_Period")]
    private RadioButton _GS_Range_Period;
    [AccessedThroughProperty("GS_ProgressBar")]
    private ProgressBar _GS_ProgressBar;
    [AccessedThroughProperty("GS_VisibilityGroup")]
    private GroupBox _GS_VisibilityGroup;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("GS_Antenna_Limit")]
    private ComboBox _GS_Antenna_Limit;
    [AccessedThroughProperty("GS_Grid")]
    private DataGridView _GS_Grid;
    [AccessedThroughProperty("GS_EditorGroup")]
    private GroupBox _GS_EditorGroup;
    [AccessedThroughProperty("StationsInit")]
    private Button _StationsInit;
    [AccessedThroughProperty("StationsSave")]
    private Button _StationsSave;
    [AccessedThroughProperty("StationEditionGrid")]
    private DataGridView _StationEditionGrid;
    [AccessedThroughProperty("FullName")]
    private DataGridViewTextBoxColumn _FullName;
    [AccessedThroughProperty("ShortName")]
    private DataGridViewTextBoxColumn _ShortName;
    [AccessedThroughProperty("Latitude")]
    private DataGridViewTextBoxColumn _Latitude;
    [AccessedThroughProperty("Longitude")]
    private DataGridViewTextBoxColumn _Longitude;
    [AccessedThroughProperty("Altitude")]
    private DataGridViewTextBoxColumn _Altitude;
    [AccessedThroughProperty("GS_Visibility")]
    private Button _GS_Visibility;
    [AccessedThroughProperty("Station")]
    private DataGridViewTextBoxColumn _Station;
    [AccessedThroughProperty("AcquisitionNumber")]
    private DataGridViewTextBoxColumn _AcquisitionNumber;
    [AccessedThroughProperty("VisStart")]
    private DataGridViewTextBoxColumn _VisStart;
    [AccessedThroughProperty("VisDuration")]
    private DataGridViewTextBoxColumn _VisDuration;
    [AccessedThroughProperty("azimut")]
    private DataGridViewTextBoxColumn _azimut;
    [AccessedThroughProperty("elevation")]
    private DataGridViewTextBoxColumn _elevation;
    [AccessedThroughProperty("visDist")]
    private DataGridViewTextBoxColumn _visDist;
    [AccessedThroughProperty("remTime")]
    private DataGridViewTextBoxColumn _remTime;
    [AccessedThroughProperty("VisWay")]
    private DataGridViewTextBoxColumn _VisWay;
    [AccessedThroughProperty("GS_Range_Ranging")]
    private CheckBox _GS_Range_Ranging;
    [AccessedThroughProperty("GS_Export2CSV")]
    private Button _GS_Export2CSV;
    [AccessedThroughProperty("GS_Range_EpochStart")]
    private CheckBox _GS_Range_EpochStart;

    [DebuggerNonUserCode]
    static GroundStations()
    {
    }

    [DebuggerNonUserCode]
    public GroundStations()
    {
      this.Load += new EventHandler(this.GroundStations_Load);
      GroundStations.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (GroundStations.__ENCList)
      {
        if (GroundStations.__ENCList.Count == GroundStations.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (GroundStations.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (GroundStations.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                GroundStations.__ENCList[index1] = GroundStations.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          GroundStations.__ENCList.RemoveRange(index1, checked (GroundStations.__ENCList.Count - index1));
          GroundStations.__ENCList.Capacity = GroundStations.__ENCList.Count;
        }
        GroundStations.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle13 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle14 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle15 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle16 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (GroundStations));
      this.GS_Range_Day = new RadioButton();
      this.GS_Range_Period = new RadioButton();
      this.GS_ProgressBar = new ProgressBar();
      this.GS_VisibilityGroup = new GroupBox();
      this.GS_Export2CSV = new Button();
      this.GS_Range_Ranging = new CheckBox();
      this.GS_Visibility = new Button();
      this.Label21 = new Label();
      this.Label18 = new Label();
      this.GS_Antenna_Limit = new ComboBox();
      this.GS_Grid = new DataGridView();
      this.Station = new DataGridViewTextBoxColumn();
      this.AcquisitionNumber = new DataGridViewTextBoxColumn();
      this.VisStart = new DataGridViewTextBoxColumn();
      this.VisDuration = new DataGridViewTextBoxColumn();
      this.azimut = new DataGridViewTextBoxColumn();
      this.elevation = new DataGridViewTextBoxColumn();
      this.visDist = new DataGridViewTextBoxColumn();
      this.remTime = new DataGridViewTextBoxColumn();
      this.VisWay = new DataGridViewTextBoxColumn();
      this.GS_EditorGroup = new GroupBox();
      this.StationsInit = new Button();
      this.StationsSave = new Button();
      this.StationEditionGrid = new DataGridView();
      this.FullName = new DataGridViewTextBoxColumn();
      this.ShortName = new DataGridViewTextBoxColumn();
      this.Latitude = new DataGridViewTextBoxColumn();
      this.Longitude = new DataGridViewTextBoxColumn();
      this.Altitude = new DataGridViewTextBoxColumn();
      this.GS_Range_EpochStart = new CheckBox();
      this.GS_VisibilityGroup.SuspendLayout();
      ((ISupportInitialize) this.GS_Grid).BeginInit();
      this.GS_EditorGroup.SuspendLayout();
      ((ISupportInitialize) this.StationEditionGrid).BeginInit();
      this.SuspendLayout();
      this.GS_Range_Day.Anchor = AnchorStyles.Left;
      this.GS_Range_Day.AutoSize = true;
      RadioButton gsRangeDay1 = this.GS_Range_Day;
      Point point1 = new Point(5, 525);
      Point point2 = point1;
      gsRangeDay1.Location = point2;
      this.GS_Range_Day.Name = "GS_Range_Day";
      RadioButton gsRangeDay2 = this.GS_Range_Day;
      Size size1 = new Size(104, 17);
      Size size2 = size1;
      gsRangeDay2.Size = size2;
      this.GS_Range_Day.TabIndex = 1;
      this.GS_Range_Day.TabStop = true;
      this.GS_Range_Day.Text = "Day (acc. +/- 5'')";
      this.GS_Range_Day.UseVisualStyleBackColor = true;
      this.GS_Range_Period.Anchor = AnchorStyles.Left;
      this.GS_Range_Period.AutoSize = true;
      this.GS_Range_Period.Checked = true;
      RadioButton gsRangePeriod1 = this.GS_Range_Period;
      point1 = new Point(5, 502);
      Point point3 = point1;
      gsRangePeriod1.Location = point3;
      this.GS_Range_Period.Name = "GS_Range_Period";
      RadioButton gsRangePeriod2 = this.GS_Range_Period;
      size1 = new Size(115, 17);
      Size size3 = size1;
      gsRangePeriod2.Size = size3;
      this.GS_Range_Period.TabIndex = 0;
      this.GS_Range_Period.TabStop = true;
      this.GS_Range_Period.Text = "Period (acc. +/- 1'')";
      this.GS_Range_Period.UseVisualStyleBackColor = true;
      this.GS_ProgressBar.Anchor = AnchorStyles.None;
      this.GS_ProgressBar.ImeMode = ImeMode.NoControl;
      ProgressBar gsProgressBar1 = this.GS_ProgressBar;
      point1 = new Point(517, 549);
      Point point4 = point1;
      gsProgressBar1.Location = point4;
      this.GS_ProgressBar.Name = "GS_ProgressBar";
      ProgressBar gsProgressBar2 = this.GS_ProgressBar;
      size1 = new Size(141, 19);
      Size size4 = size1;
      gsProgressBar2.Size = size4;
      this.GS_ProgressBar.TabIndex = 105;
      this.GS_ProgressBar.Visible = false;
      this.GS_VisibilityGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_Range_EpochStart);
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_Export2CSV);
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_Range_Ranging);
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_Range_Day);
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_Visibility);
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_Range_Period);
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_ProgressBar);
      this.GS_VisibilityGroup.Controls.Add((Control) this.Label21);
      this.GS_VisibilityGroup.Controls.Add((Control) this.Label18);
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_Antenna_Limit);
      this.GS_VisibilityGroup.Controls.Add((Control) this.GS_Grid);
      GroupBox gsVisibilityGroup1 = this.GS_VisibilityGroup;
      point1 = new Point(461, 12);
      Point point5 = point1;
      gsVisibilityGroup1.Location = point5;
      this.GS_VisibilityGroup.Name = "GS_VisibilityGroup";
      GroupBox gsVisibilityGroup2 = this.GS_VisibilityGroup;
      size1 = new Size(761, 575);
      Size size5 = size1;
      gsVisibilityGroup2.Size = size5;
      this.GS_VisibilityGroup.TabIndex = 103;
      this.GS_VisibilityGroup.TabStop = false;
      this.GS_VisibilityGroup.Text = "Ground Stations Bulletin";
      this.GS_Export2CSV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button gsExport2Csv1 = this.GS_Export2CSV;
      point1 = new Point(664, 541);
      Point point6 = point1;
      gsExport2Csv1.Location = point6;
      this.GS_Export2CSV.Name = "GS_Export2CSV";
      Button gsExport2Csv2 = this.GS_Export2CSV;
      size1 = new Size(91, 23);
      Size size6 = size1;
      gsExport2Csv2.Size = size6;
      this.GS_Export2CSV.TabIndex = 107;
      this.GS_Export2CSV.Text = "Export to .csv";
      this.GS_Export2CSV.UseVisualStyleBackColor = true;
      this.GS_Range_Ranging.Anchor = AnchorStyles.None;
      this.GS_Range_Ranging.AutoSize = true;
      CheckBox gsRangeRanging1 = this.GS_Range_Ranging;
      point1 = new Point((int) sbyte.MaxValue, 502);
      Point point7 = point1;
      gsRangeRanging1.Location = point7;
      this.GS_Range_Ranging.Name = "GS_Range_Ranging";
      CheckBox gsRangeRanging2 = this.GS_Range_Ranging;
      size1 = new Size(66, 17);
      Size size7 = size1;
      gsRangeRanging2.Size = size7;
      this.GS_Range_Ranging.TabIndex = 106;
      this.GS_Range_Ranging.Text = "Ranging";
      this.GS_Range_Ranging.UseVisualStyleBackColor = true;
      this.GS_Visibility.Anchor = AnchorStyles.Left;
      Button gsVisibility1 = this.GS_Visibility;
      point1 = new Point(517, 541);
      Point point8 = point1;
      gsVisibility1.Location = point8;
      this.GS_Visibility.Name = "GS_Visibility";
      Button gsVisibility2 = this.GS_Visibility;
      size1 = new Size(141, 23);
      Size size8 = size1;
      gsVisibility2.Size = size8;
      this.GS_Visibility.TabIndex = 78;
      this.GS_Visibility.Text = "Update Visibility Bulletin";
      this.GS_Visibility.UseVisualStyleBackColor = true;
      this.Label21.Anchor = AnchorStyles.Bottom;
      this.Label21.AutoSize = true;
      this.Label21.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label21.ImeMode = ImeMode.NoControl;
      Label label21_1 = this.Label21;
      point1 = new Point(84, 551);
      Point point9 = point1;
      label21_1.Location = point9;
      this.Label21.Name = "Label21";
      Label label21_2 = this.Label21;
      size1 = new Size(25, 13);
      Size size9 = size1;
      label21_2.Size = size9;
      this.Label21.TabIndex = 77;
      this.Label21.Text = "deg";
      this.Label18.Anchor = AnchorStyles.None;
      this.Label18.AutoSize = true;
      this.Label18.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label18.ImeMode = ImeMode.NoControl;
      Label label18_1 = this.Label18;
      point1 = new Point(6, 551);
      Point point10 = point1;
      label18_1.Location = point10;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(30, 13);
      Size size10 = size1;
      label18_2.Size = size10;
      this.Label18.TabIndex = 76;
      this.Label18.Text = "AEL:";
      this.GS_Antenna_Limit.Anchor = AnchorStyles.Bottom;
      this.GS_Antenna_Limit.BackColor = SystemColors.Window;
      this.GS_Antenna_Limit.Cursor = Cursors.Default;
      this.GS_Antenna_Limit.DropDownStyle = ComboBoxStyle.DropDownList;
      this.GS_Antenna_Limit.FormattingEnabled = true;
      this.GS_Antenna_Limit.Items.AddRange(new object[6]
      {
        (object) "0",
        (object) "5",
        (object) "10",
        (object) "15",
        (object) "20",
        (object) "25"
      });
      ComboBox gsAntennaLimit1 = this.GS_Antenna_Limit;
      point1 = new Point(42, 548);
      Point point11 = point1;
      gsAntennaLimit1.Location = point11;
      this.GS_Antenna_Limit.Name = "GS_Antenna_Limit";
      ComboBox gsAntennaLimit2 = this.GS_Antenna_Limit;
      size1 = new Size(36, 21);
      Size size11 = size1;
      gsAntennaLimit2.Size = size11;
      this.GS_Antenna_Limit.TabIndex = 75;
      this.GS_Grid.AllowUserToAddRows = false;
      this.GS_Grid.AllowUserToDeleteRows = false;
      this.GS_Grid.AllowUserToResizeColumns = false;
      this.GS_Grid.AllowUserToResizeRows = false;
      this.GS_Grid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.GS_Grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = SystemColors.Control;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle1.ForeColor = SystemColors.WindowText;
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.GS_Grid.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.GS_Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GS_Grid.Columns.AddRange((DataGridViewColumn) this.Station, (DataGridViewColumn) this.AcquisitionNumber, (DataGridViewColumn) this.VisStart, (DataGridViewColumn) this.VisDuration, (DataGridViewColumn) this.azimut, (DataGridViewColumn) this.elevation, (DataGridViewColumn) this.visDist, (DataGridViewColumn) this.remTime, (DataGridViewColumn) this.VisWay);
      this.GS_Grid.EditMode = DataGridViewEditMode.EditOnKeystroke;
      DataGridView gsGrid1 = this.GS_Grid;
      point1 = new Point(6, 19);
      Point point12 = point1;
      gsGrid1.Location = point12;
      this.GS_Grid.Name = "GS_Grid";
      this.GS_Grid.ReadOnly = true;
      this.GS_Grid.RowHeadersVisible = false;
      this.GS_Grid.ShowCellErrors = false;
      this.GS_Grid.ShowCellToolTips = false;
      this.GS_Grid.ShowEditingIcon = false;
      this.GS_Grid.ShowRowErrors = false;
      DataGridView gsGrid2 = this.GS_Grid;
      size1 = new Size(749, 471);
      Size size12 = size1;
      gsGrid2.Size = size12;
      this.GS_Grid.TabIndex = 8;
      this.Station.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.Station.DefaultCellStyle = gridViewCellStyle2;
      this.Station.FillWeight = 45f;
      this.Station.HeaderText = "Station";
      this.Station.MinimumWidth = 45;
      this.Station.Name = "Station";
      this.Station.ReadOnly = true;
      this.Station.Resizable = DataGridViewTriState.False;
      this.AcquisitionNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.AcquisitionNumber.DefaultCellStyle = gridViewCellStyle3;
      this.AcquisitionNumber.FillWeight = 57f;
      this.AcquisitionNumber.HeaderText = "Acquisition";
      this.AcquisitionNumber.MinimumWidth = 57;
      this.AcquisitionNumber.Name = "AcquisitionNumber";
      this.AcquisitionNumber.ReadOnly = true;
      this.AcquisitionNumber.Resizable = DataGridViewTriState.False;
      this.VisStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.VisStart.DefaultCellStyle = gridViewCellStyle4;
      this.VisStart.FillWeight = 57f;
      this.VisStart.HeaderText = "Date/Time";
      this.VisStart.MinimumWidth = 120;
      this.VisStart.Name = "VisStart";
      this.VisStart.ReadOnly = true;
      this.VisStart.Resizable = DataGridViewTriState.False;
      this.VisDuration.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.VisDuration.DefaultCellStyle = gridViewCellStyle5;
      this.VisDuration.FillWeight = 15f;
      this.VisDuration.HeaderText = "Duration";
      this.VisDuration.MinimumWidth = 72;
      this.VisDuration.Name = "VisDuration";
      this.VisDuration.ReadOnly = true;
      this.VisDuration.Resizable = DataGridViewTriState.False;
      this.azimut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.azimut.DefaultCellStyle = gridViewCellStyle6;
      this.azimut.FillWeight = 75f;
      this.azimut.HeaderText = "Azimut";
      this.azimut.MinimumWidth = 75;
      this.azimut.Name = "azimut";
      this.azimut.ReadOnly = true;
      this.azimut.Resizable = DataGridViewTriState.False;
      this.elevation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.elevation.DefaultCellStyle = gridViewCellStyle7;
      this.elevation.FillWeight = 75f;
      this.elevation.HeaderText = "Elevation";
      this.elevation.MinimumWidth = 75;
      this.elevation.Name = "elevation";
      this.elevation.ReadOnly = true;
      this.elevation.Resizable = DataGridViewTriState.False;
      this.visDist.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.visDist.DefaultCellStyle = gridViewCellStyle8;
      this.visDist.FillWeight = 75f;
      this.visDist.HeaderText = "Distance";
      this.visDist.MinimumWidth = 75;
      this.visDist.Name = "visDist";
      this.visDist.ReadOnly = true;
      this.visDist.Resizable = DataGridViewTriState.False;
      this.remTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.remTime.DefaultCellStyle = gridViewCellStyle9;
      this.remTime.FillWeight = 57f;
      this.remTime.HeaderText = "Rem. Time";
      this.remTime.MinimumWidth = 72;
      this.remTime.Name = "remTime";
      this.remTime.ReadOnly = true;
      this.remTime.Resizable = DataGridViewTriState.False;
      this.VisWay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.VisWay.DefaultCellStyle = gridViewCellStyle10;
      this.VisWay.FillWeight = 50f;
      this.VisWay.HeaderText = "Direction";
      this.VisWay.MinimumWidth = 50;
      this.VisWay.Name = "VisWay";
      this.VisWay.ReadOnly = true;
      this.VisWay.Resizable = DataGridViewTriState.False;
      this.GS_EditorGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.GS_EditorGroup.Controls.Add((Control) this.StationsInit);
      this.GS_EditorGroup.Controls.Add((Control) this.StationsSave);
      this.GS_EditorGroup.Controls.Add((Control) this.StationEditionGrid);
      GroupBox gsEditorGroup1 = this.GS_EditorGroup;
      point1 = new Point(12, 12);
      Point point13 = point1;
      gsEditorGroup1.Location = point13;
      this.GS_EditorGroup.Name = "GS_EditorGroup";
      GroupBox gsEditorGroup2 = this.GS_EditorGroup;
      size1 = new Size(443, 575);
      Size size13 = size1;
      gsEditorGroup2.Size = size13;
      this.GS_EditorGroup.TabIndex = 104;
      this.GS_EditorGroup.TabStop = false;
      this.GS_EditorGroup.Text = "Ground Stations Editor";
      this.StationsInit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.StationsInit.ImeMode = ImeMode.NoControl;
      Button stationsInit1 = this.StationsInit;
      point1 = new Point(6, 546);
      Point point14 = point1;
      stationsInit1.Location = point14;
      this.StationsInit.Name = "StationsInit";
      Button stationsInit2 = this.StationsInit;
      size1 = new Size(120, 23);
      Size size14 = size1;
      stationsInit2.Size = size14;
      this.StationsInit.TabIndex = 6;
      this.StationsInit.Text = "Load Default Stations";
      this.StationsInit.UseVisualStyleBackColor = true;
      this.StationsSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.StationsSave.ImeMode = ImeMode.NoControl;
      Button stationsSave1 = this.StationsSave;
      point1 = new Point(362, 546);
      Point point15 = point1;
      stationsSave1.Location = point15;
      this.StationsSave.Name = "StationsSave";
      Button stationsSave2 = this.StationsSave;
      size1 = new Size(75, 23);
      Size size15 = size1;
      stationsSave2.Size = size15;
      this.StationsSave.TabIndex = 5;
      this.StationsSave.Text = "Update";
      this.StationsSave.UseVisualStyleBackColor = true;
      this.StationEditionGrid.AllowUserToResizeColumns = false;
      this.StationEditionGrid.AllowUserToResizeRows = false;
      this.StationEditionGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle11.BackColor = SystemColors.Control;
      gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      gridViewCellStyle11.ForeColor = SystemColors.WindowText;
      gridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle11.WrapMode = DataGridViewTriState.True;
      this.StationEditionGrid.ColumnHeadersDefaultCellStyle = gridViewCellStyle11;
      this.StationEditionGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.StationEditionGrid.Columns.AddRange((DataGridViewColumn) this.FullName, (DataGridViewColumn) this.ShortName, (DataGridViewColumn) this.Latitude, (DataGridViewColumn) this.Longitude, (DataGridViewColumn) this.Altitude);
      this.StationEditionGrid.EditMode = DataGridViewEditMode.EditOnKeystroke;
      DataGridView stationEditionGrid1 = this.StationEditionGrid;
      point1 = new Point(6, 19);
      Point point16 = point1;
      stationEditionGrid1.Location = point16;
      this.StationEditionGrid.Name = "StationEditionGrid";
      this.StationEditionGrid.ShowCellErrors = false;
      this.StationEditionGrid.ShowCellToolTips = false;
      this.StationEditionGrid.ShowEditingIcon = false;
      this.StationEditionGrid.ShowRowErrors = false;
      DataGridView stationEditionGrid2 = this.StationEditionGrid;
      size1 = new Size(431, 520);
      Size size16 = size1;
      stationEditionGrid2.Size = size16;
      this.StationEditionGrid.TabIndex = 2;
      this.FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
      this.FullName.DefaultCellStyle = gridViewCellStyle12;
      this.FullName.FillWeight = 70f;
      this.FullName.HeaderText = "Full Name";
      this.FullName.Name = "FullName";
      this.ShortName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.ShortName.DefaultCellStyle = gridViewCellStyle13;
      this.ShortName.FillWeight = 57f;
      this.ShortName.HeaderText = "Short Name";
      this.ShortName.Name = "ShortName";
      this.Latitude.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle14.Format = "N2";
      gridViewCellStyle14.NullValue = (object) null;
      this.Latitude.DefaultCellStyle = gridViewCellStyle14;
      this.Latitude.FillWeight = 57f;
      this.Latitude.HeaderText = "Latitude";
      this.Latitude.Name = "Latitude";
      this.Longitude.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle15.Format = "N2";
      this.Longitude.DefaultCellStyle = gridViewCellStyle15;
      this.Longitude.FillWeight = 57f;
      this.Longitude.HeaderText = "Longitude";
      this.Longitude.Name = "Longitude";
      this.Altitude.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      gridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle16.Format = "N2";
      this.Altitude.DefaultCellStyle = gridViewCellStyle16;
      this.Altitude.FillWeight = 57f;
      this.Altitude.HeaderText = "Altitude (m)";
      this.Altitude.Name = "Altitude";
      this.GS_Range_EpochStart.Anchor = AnchorStyles.None;
      this.GS_Range_EpochStart.AutoSize = true;
      this.GS_Range_EpochStart.Enabled = false;
      CheckBox gsRangeEpochStart1 = this.GS_Range_EpochStart;
      point1 = new Point(199, 502);
      Point point17 = point1;
      gsRangeEpochStart1.Location = point17;
      this.GS_Range_EpochStart.Name = "GS_Range_EpochStart";
      CheckBox gsRangeEpochStart2 = this.GS_Range_EpochStart;
      size1 = new Size(117, 17);
      Size size17 = size1;
      gsRangeEpochStart2.Size = size17;
      this.GS_Range_EpochStart.TabIndex = 108;
      this.GS_Range_EpochStart.Text = "Start at TLE Epoch";
      this.GS_Range_EpochStart.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(1234, 599);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GS_VisibilityGroup);
      this.Controls.Add((Control) this.GS_EditorGroup);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (GroundStations);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ground Stations";
      this.GS_VisibilityGroup.ResumeLayout(false);
      this.GS_VisibilityGroup.PerformLayout();
      ((ISupportInitialize) this.GS_Grid).EndInit();
      this.GS_EditorGroup.ResumeLayout(false);
      ((ISupportInitialize) this.StationEditionGrid).EndInit();
      this.ResumeLayout(false);
    }

    internal virtual RadioButton GS_Range_Day
    {
      [DebuggerNonUserCode] get => this._GS_Range_Day;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_Range_Day_CheckedChanged);
        if (this._GS_Range_Day != null)
          this._GS_Range_Day.CheckedChanged -= eventHandler;
        this._GS_Range_Day = value;
        if (this._GS_Range_Day == null)
          return;
        this._GS_Range_Day.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton GS_Range_Period
    {
      [DebuggerNonUserCode] get => this._GS_Range_Period;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_Range_Period_CheckedChanged);
        if (this._GS_Range_Period != null)
          this._GS_Range_Period.CheckedChanged -= eventHandler;
        this._GS_Range_Period = value;
        if (this._GS_Range_Period == null)
          return;
        this._GS_Range_Period.CheckedChanged += eventHandler;
      }
    }

    internal virtual ProgressBar GS_ProgressBar
    {
      [DebuggerNonUserCode] get => this._GS_ProgressBar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GS_ProgressBar = value;
    }

    internal virtual GroupBox GS_VisibilityGroup
    {
      [DebuggerNonUserCode] get => this._GS_VisibilityGroup;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GS_VisibilityGroup = value;
    }

    internal virtual Label Label21
    {
      [DebuggerNonUserCode] get => this._Label21;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
    }

    internal virtual Label Label18
    {
      [DebuggerNonUserCode] get => this._Label18;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
    }

    internal virtual ComboBox GS_Antenna_Limit
    {
      [DebuggerNonUserCode] get => this._GS_Antenna_Limit;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_Antenna_Limit_SelectedIndexChanged);
        if (this._GS_Antenna_Limit != null)
          this._GS_Antenna_Limit.SelectedIndexChanged -= eventHandler;
        this._GS_Antenna_Limit = value;
        if (this._GS_Antenna_Limit == null)
          return;
        this._GS_Antenna_Limit.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual DataGridView GS_Grid
    {
      [DebuggerNonUserCode] get => this._GS_Grid;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.GS_Grid_CellDoubleClick);
        if (this._GS_Grid != null)
          this._GS_Grid.CellDoubleClick -= cellEventHandler;
        this._GS_Grid = value;
        if (this._GS_Grid == null)
          return;
        this._GS_Grid.CellDoubleClick += cellEventHandler;
      }
    }

    internal virtual GroupBox GS_EditorGroup
    {
      [DebuggerNonUserCode] get => this._GS_EditorGroup;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GS_EditorGroup = value;
    }

    internal virtual Button StationsInit
    {
      [DebuggerNonUserCode] get => this._StationsInit;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.StationsInit_Click);
        if (this._StationsInit != null)
          this._StationsInit.Click -= eventHandler;
        this._StationsInit = value;
        if (this._StationsInit == null)
          return;
        this._StationsInit.Click += eventHandler;
      }
    }

    internal virtual Button StationsSave
    {
      [DebuggerNonUserCode] get => this._StationsSave;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.StationsSave_Click);
        if (this._StationsSave != null)
          this._StationsSave.Click -= eventHandler;
        this._StationsSave = value;
        if (this._StationsSave == null)
          return;
        this._StationsSave.Click += eventHandler;
      }
    }

    internal virtual DataGridView StationEditionGrid
    {
      [DebuggerNonUserCode] get => this._StationEditionGrid;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._StationEditionGrid = value;
    }

    internal virtual DataGridViewTextBoxColumn FullName
    {
      [DebuggerNonUserCode] get => this._FullName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._FullName = value;
    }

    internal virtual DataGridViewTextBoxColumn ShortName
    {
      [DebuggerNonUserCode] get => this._ShortName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ShortName = value;
    }

    internal virtual DataGridViewTextBoxColumn Latitude
    {
      [DebuggerNonUserCode] get => this._Latitude;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Latitude = value;
    }

    internal virtual DataGridViewTextBoxColumn Longitude
    {
      [DebuggerNonUserCode] get => this._Longitude;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Longitude = value;
    }

    internal virtual DataGridViewTextBoxColumn Altitude
    {
      [DebuggerNonUserCode] get => this._Altitude;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Altitude = value;
    }

    internal virtual Button GS_Visibility
    {
      [DebuggerNonUserCode] get => this._GS_Visibility;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_Visibility_But_Click);
        if (this._GS_Visibility != null)
          this._GS_Visibility.Click -= eventHandler;
        this._GS_Visibility = value;
        if (this._GS_Visibility == null)
          return;
        this._GS_Visibility.Click += eventHandler;
      }
    }

    internal virtual DataGridViewTextBoxColumn Station
    {
      [DebuggerNonUserCode] get => this._Station;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Station = value;
    }

    internal virtual DataGridViewTextBoxColumn AcquisitionNumber
    {
      [DebuggerNonUserCode] get => this._AcquisitionNumber;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AcquisitionNumber = value;
    }

    internal virtual DataGridViewTextBoxColumn VisStart
    {
      [DebuggerNonUserCode] get => this._VisStart;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VisStart = value;
    }

    internal virtual DataGridViewTextBoxColumn VisDuration
    {
      [DebuggerNonUserCode] get => this._VisDuration;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VisDuration = value;
    }

    internal virtual DataGridViewTextBoxColumn azimut
    {
      [DebuggerNonUserCode] get => this._azimut;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._azimut = value;
    }

    internal virtual DataGridViewTextBoxColumn elevation
    {
      [DebuggerNonUserCode] get => this._elevation;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._elevation = value;
    }

    internal virtual DataGridViewTextBoxColumn visDist
    {
      [DebuggerNonUserCode] get => this._visDist;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._visDist = value;
    }

    internal virtual DataGridViewTextBoxColumn remTime
    {
      [DebuggerNonUserCode] get => this._remTime;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._remTime = value;
    }

    internal virtual DataGridViewTextBoxColumn VisWay
    {
      [DebuggerNonUserCode] get => this._VisWay;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VisWay = value;
    }

    internal virtual CheckBox GS_Range_Ranging
    {
      [DebuggerNonUserCode] get => this._GS_Range_Ranging;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_Range_Ranging_CheckedChanged);
        if (this._GS_Range_Ranging != null)
          this._GS_Range_Ranging.CheckedChanged -= eventHandler;
        this._GS_Range_Ranging = value;
        if (this._GS_Range_Ranging == null)
          return;
        this._GS_Range_Ranging.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button GS_Export2CSV
    {
      [DebuggerNonUserCode] get => this._GS_Export2CSV;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_Export2CSV_Click);
        if (this._GS_Export2CSV != null)
          this._GS_Export2CSV.Click -= eventHandler;
        this._GS_Export2CSV = value;
        if (this._GS_Export2CSV == null)
          return;
        this._GS_Export2CSV.Click += eventHandler;
      }
    }

    internal virtual CheckBox GS_Range_EpochStart
    {
      [DebuggerNonUserCode] get => this._GS_Range_EpochStart;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GS_Range_EpochStart = value;
    }

    private void GroundStations_Load(object sender, EventArgs e) => this.LoadStations();

    public void LoadStations()
    {
      object[] objArray = new object[5];
      this.StationEditionGrid.Rows.Clear();
      int num = checked (MyProject.Forms.Home.StatNum - 1);
      int index = 0;
      while (index <= num)
      {
        objArray[0] = (object) MyProject.Forms.Home.Stations[index, 0];
        objArray[1] = (object) MyProject.Forms.Home.Stations[index, 1];
        objArray[2] = (object) MyProject.Forms.Home.Stations[index, 2];
        objArray[3] = (object) MyProject.Forms.Home.Stations[index, 3];
        objArray[4] = (object) MyProject.Forms.Home.Stations[index, 4];
        this.StationEditionGrid.Rows.Add(objArray);
        if (Operators.ConditionalCompareObjectEqual(objArray[0], MyProject.Forms.Home.Stations_list.SelectedItem, false))
        {
          this.StationEditionGrid.Rows[index].Cells[0].Style.BackColor = Color.YellowGreen;
          this.StationEditionGrid.Rows[index].Cells[1].Style.BackColor = Color.YellowGreen;
          this.StationEditionGrid.Rows[index].Cells[2].Style.BackColor = Color.YellowGreen;
          this.StationEditionGrid.Rows[index].Cells[3].Style.BackColor = Color.YellowGreen;
          this.StationEditionGrid.Rows[index].Cells[4].Style.BackColor = Color.YellowGreen;
        }
        checked { ++index; }
      }
    }

    private void StationsSave_Click(object sender, EventArgs e)
    {
      int num1 = checked (this.StationEditionGrid.Rows.Count - 2);
      int index1 = 0;
      while (index1 <= num1)
      {
        if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(this.StationEditionGrid.Rows[index1].Cells[0].Value, (object) "", false), Operators.CompareObjectEqual(this.StationEditionGrid.Rows[index1].Cells[1].Value, (object) "", false)), Operators.CompareObjectEqual(this.StationEditionGrid.Rows[index1].Cells[2].Value, (object) "", false)), Operators.CompareObjectEqual(this.StationEditionGrid.Rows[index1].Cells[3].Value, (object) "", false)), Operators.CompareObjectEqual(this.StationEditionGrid.Rows[index1].Cells[4].Value, (object) "", false))))
        {
          int num2 = (int) Interaction.MsgBox((object) "A value is missing. Check it before save.", MsgBoxStyle.Exclamation, (object) "TLE ANALYSER");
          return;
        }
        if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(this.StationEditionGrid.Rows[index1].Cells[2].Value, (object) -90, false), Operators.CompareObjectGreater(this.StationEditionGrid.Rows[index1].Cells[2].Value, (object) 90, false))))
        {
          int num3 = (int) Interaction.MsgBox((object) "Latitudes values must be -90 < lat < +90", MsgBoxStyle.Exclamation, (object) "TLE ANALYSER");
          this.StationEditionGrid.Rows[index1].Cells[2].Selected = true;
          return;
        }
        if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLess(this.StationEditionGrid.Rows[index1].Cells[3].Value, (object) -180, false), Operators.CompareObjectGreater(this.StationEditionGrid.Rows[index1].Cells[3].Value, (object) 180, false))))
        {
          int num4 = (int) Interaction.MsgBox((object) "Longitudes values must be -180 < lat < +180", MsgBoxStyle.Exclamation, (object) "TLE ANALYSER");
          this.StationEditionGrid.Rows[index1].Cells[3].Selected = true;
          return;
        }
        checked { ++index1; }
      }
      MyProject.Computer.FileSystem.DeleteFile(MyProject.Forms.Home.StationsFile);
      int num5 = checked (this.StationEditionGrid.Rows.Count - 1);
      int index2 = 0;
      while (index2 <= num5)
      {
        string contents;
        if (index2 == this.StationEditionGrid.Rows.Count)
        {
          object Left = Operators.ConcatenateObject(this.StationEditionGrid.Rows[index2].Cells[0].Value, (object) ";");
          Type Type = typeof (Strings);
          object[] objArray1 = new object[1];
          object[] objArray2 = objArray1;
          DataGridViewCell cell = this.StationEditionGrid.Rows[index2].Cells[1];
          object objectValue = RuntimeHelpers.GetObjectValue(cell.Value);
          objArray2[0] = objectValue;
          object[] objArray3 = objArray1;
          object[] Arguments = objArray3;
          bool[] flagArray = new bool[1]{ true };
          bool[] CopyBack = flagArray;
          object Right = NewLateBinding.LateGet((object) null, Type, "UCase", Arguments, (string[]) null, (Type[]) null, CopyBack);
          if (flagArray[0])
            cell.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
          contents = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Left, Right), (object) ";"), this.StationEditionGrid.Rows[index2].Cells[2].Value), (object) ";"), this.StationEditionGrid.Rows[index2].Cells[3].Value), (object) ";"), this.StationEditionGrid.Rows[index2].Cells[4].Value));
        }
        else if (index2 != checked (this.StationEditionGrid.Rows.Count - 1))
          contents = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(this.StationEditionGrid.Rows[index2].Cells[0].Value, (object) ";"), this.StationEditionGrid.Rows[index2].Cells[1].Value), (object) ";"), this.StationEditionGrid.Rows[index2].Cells[2].Value), (object) ";"), this.StationEditionGrid.Rows[index2].Cells[3].Value), (object) ";"), this.StationEditionGrid.Rows[index2].Cells[4].Value), (object) "\r\n"));
        else
          break;
        File.AppendAllText(MyProject.Forms.Home.StationsFile, contents);
        checked { ++index2; }
      }
      MyProject.Forms.Home.Stations_Load();
    }

    private void StationsInit_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Are you sure you want to load default stations ?", MsgBoxStyle.YesNo, (object) "Ground Station Edition") != MsgBoxResult.Yes)
        return;
      MyProject.Computer.FileSystem.DeleteFile(MyProject.Forms.Home.StationsFile);
      File.AppendAllText(MyProject.Forms.Home.StationsFile, TLE_Analyser.My.Resources.Resources.GroundStations);
      this.StationEditionGrid.Rows.Clear();
      MyProject.Forms.Home.Stations_Load();
      this.LoadStations();
    }

    private void GS_Visibility_But_Click(object sender, EventArgs e)
    {
      bool flag = false;
      if (MyProject.Forms.Home.GS_ListBox.CheckedItems.Count == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Select a station in main window.", MsgBoxStyle.Information, (object) "TLE ANALYSER - Ground Stations");
      }
      else
      {
        object[] objArray1 = new object[9];
        object[,] objArray2 = new object[checked (MyProject.Forms.Home.StatNum - 1 + 1), 4];
        double Left1;
        object Right1;
        double num2;
        if (this.GS_Range_Period.Checked)
        {
          Left1 = !(this.GS_Range_EpochStart.Checked & this.GS_Range_Ranging.Checked) ? MyProject.Forms.Home.ANEPOCH : MyProject.Forms.Home.TLEPOCH;
          Right1 = (object) 1.15740740740741E-05;
          num2 = Conversions.ToDouble(Operators.AddObject((object) Left1, Operators.MultiplyObject((object) (MyProject.Forms.Home.DPER / 1440.0), MyProject.Forms.Home.MAP_Num_Period.SelectedItem)));
        }
        else if (this.GS_Range_Day.Checked)
        {
          Left1 = Math.Truncate(MyProject.Forms.Home.EPOCH) + 0.5000115741;
          Right1 = (object) 5.78703703703704E-05;
          num2 = Left1 + 1.0;
        }
        if (MyProject.Forms.Home.MM > 0.99 & MyProject.Forms.Home.MM < 1.01)
        {
          Left1 = MyProject.Forms.Home.ANEPOCH;
          Right1 = (object) 0.5;
          num2 = Conversions.ToDouble(Operators.AddObject((object) Left1, Right1));
        }
        this.GS_Grid.Rows.Clear();
        this.GS_ProgressBar.Visible = true;
        this.GS_ProgressBar.Value = 0;
        double num3 = num2 - Left1;
        double Left2 = Conversions.ToDouble(Right1);
        double num4 = Left1;
        double num5 = num2;
        double StepValue = Conversions.ToDouble(Right1);
        double limit = num5;
        for (double num6 = num4; ObjectFlowControl.ForLoopControl.ForNextCheckR8(num6, limit, StepValue); num6 += StepValue)
        {
          Dates dat = Functions.MJD2JJ(num6);
          MyProject.Forms.Home.SGP4_Trace(num6, MyProject.Forms.Home.TLEPOCH);
          Functions.GSTCalc((object) Conversion.Val((object) num6));
          double num7 = Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "latitude", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
          double num8 = Conversions.ToDouble(Operators.MultiplyObject((object) (-180.0 / Math.PI), NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "longitude", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
          double num9 = Conversions.ToDouble(NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "altitude", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
          double[] numArray1 = new double[3];
          double[] v1 = new double[3];
          double[] v2 = new double[3];
          double[] numArray2 = new double[3];
          double[] v3 = new double[3];
          int num10 = checked (MyProject.Forms.Home.StatNum - 1);
          int index1 = 0;
          while (index1 <= num10)
          {
            if (Conversions.ToBoolean(MyProject.Forms.Home.Stations[index1, 5]))
            {
              numArray1[0] = (6378.136658 + num9) * (Math.Cos(Math.PI / 180.0 * num7) * Math.Cos(Math.PI / 180.0 * num8));
              numArray1[1] = (6378.136658 + num9) * (Math.Cos(Math.PI / 180.0 * num7) * Math.Sin(Math.PI / 180.0 * num8));
              numArray1[2] = (6378.136658 + num9) * Math.Sin(Math.PI / 180.0 * num7);
              numArray2[0] = Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 2])) * Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 3]));
              numArray2[1] = Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 2])) * Math.Sin(Math.PI / 180.0 * Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 3]));
              numArray2[2] = Math.Sin(Math.PI / 180.0 * Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 2]));
              v1[0] = 6378.136658 * numArray2[0];
              v1[1] = 6378.136658 * numArray2[1];
              v1[2] = 6378.136658 * numArray2[2];
              double num11 = MyProject.Forms.Home.Math_norm(ref v1);
              int index2 = 0;
              do
              {
                v2[index2] = v1[index2] / num11;
                checked { ++index2; }
              }
              while (index2 <= 2);
              int index3 = 0;
              do
              {
                v3[index3] = numArray1[index3] - v1[index3];
                checked { ++index3; }
              }
              while (index3 <= 2);
              double num12 = MyProject.Forms.Home.Math_norm(ref v3);
              int index4 = 0;
              do
              {
                v3[index4] = v3[index4] / num12;
                checked { ++index4; }
              }
              while (index4 <= 2);
              double num13 = 180.0 / Math.PI * MyProject.Forms.Home.Math_acose(MyProject.Forms.Home.Math_dot(v3, v2));
              if (Operators.CompareString(MyProject.Forms.Home.LimitAngle, (string) null, false) == 0 | Operators.CompareString(MyProject.Forms.Home.LimitAngle, "", false) == 0 | Operators.CompareString(MyProject.Forms.Home.LimitAngle, " ", false) == 0)
                MyProject.Forms.Home.LimitAngle = "0";
              int deg;
              int min;
              int sec;
              if (num13 < (double) checked ((int) Math.Round(unchecked (90.0 - Conversions.ToDouble(MyProject.Forms.Home.LimitAngle)))))
              {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(objArray2[index1, 0], (object) null, false), Operators.AndObject(Operators.CompareObjectEqual(objArray2[index1, 0], (object) true, false), (object) this.GS_Range_Ranging.Checked))))
                {
                  Observateur observateur1 = new Observateur(MyProject.Forms.Home.Stations[index1, 0], -Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 3]), Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 2]), Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 4]));
                  observateur1.CalculPosVit(dat);
                  object satTrack = MyProject.Forms.Home.SatTrack;
                  object[] objArray3 = new object[1]
                  {
                    (object) observateur1
                  };
                  object[] Arguments = objArray3;
                  bool[] flagArray = new bool[1]{ true };
                  bool[] CopyBack = flagArray;
                  NewLateBinding.LateCall(satTrack, (Type) null, "CalculCoordHoriz", Arguments, (string[]) null, (Type[]) null, CopyBack, true);
                  if (flagArray[0])
                  {
                    Observateur observateur2 = (Observateur) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof (Observateur));
                  }
                  double xdec1 = Conversions.ToDouble(Functions.Round4(Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "Azimut", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
                  double xdec2 = Conversions.ToDouble(Functions.Round4(Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "Hauteur", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
                  Maths.Deg2DMS(xdec1, ref deg, ref min, ref sec);
                  Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
                  Maths.Deg2DMS(xdec2, ref deg, ref min, ref sec);
                  Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
                  double num14 = Conversions.ToDouble(NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "Distance", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
                  objArray2[index1, 3] = MyProject.Forms.Home.VZN <= 0.01 ? (MyProject.Forms.Home.VZN >= 0.01 ? (object) "N/A" : (object) "DESC") : (object) "ASC";
                  objArray1[0] = (object) MyProject.Forms.Home.Stations[index1, 1];
                  objArray1[1] = !Operators.ConditionalCompareObjectEqual(objArray2[index1, 0], (object) null, false) ? (object) "-" : (object) "Start";
                  objArray2[index1, 0] = (object) true;
                  objArray2[index1, 1] = (object) num6;
                  objArray1[2] = (object) Functions.MJDtoGreg(Conversions.ToString(objArray2[index1, 1]));
                  objArray1[3] = (object) "-";
                  objArray1[4] = (object) xdec1;
                  objArray1[5] = (object) xdec2;
                  objArray1[6] = RuntimeHelpers.GetObjectValue(Functions.Round4(num14));
                  objArray1[8] = RuntimeHelpers.GetObjectValue(objArray2[index1, 3]);
                  this.GS_Grid.Rows.Add(objArray1);
                  flag = true;
                  if (this.GS_Range_Ranging.Checked)
                    num6 = num6 + 0.000694444444444444 - 1.15740740740741E-05;
                }
              }
              else if (Operators.ConditionalCompareObjectEqual(objArray2[index1, 0], (object) true, false))
              {
                objArray2[index1, 2] = (object) (num6 - 1.15740740740741E-05);
                object Left3 = Operators.MultiplyObject(Operators.DivideObject(Operators.SubtractObject(objArray2[index1, 2], objArray2[index1, 1]), (object) 60), (object) 1440);
                double Expression1 = Conversions.ToDouble(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
                {
                  Operators.DivideObject(Left3, (object) 60)
                }, (string[]) null, (Type[]) null, (bool[]) null));
                Type Type1 = typeof (Math);
                object[] objArray4 = new object[1];
                object[] objArray5 = objArray4;
                object Left4 = Left3;
                Type Type2 = typeof (Math);
                object[] objArray6 = new object[1]
                {
                  RuntimeHelpers.GetObjectValue(Left3)
                };
                object[] Arguments1 = objArray6;
                bool[] flagArray1 = new bool[1]{ true };
                bool[] CopyBack1 = flagArray1;
                object Right2 = NewLateBinding.LateGet((object) null, Type2, "Truncate", Arguments1, (string[]) null, (Type[]) null, CopyBack1);
                if (flagArray1[0])
                  Left3 = RuntimeHelpers.GetObjectValue(objArray6[0]);
                object obj1 = Operators.MultiplyObject(Operators.SubtractObject(Left4, Right2), (object) 60);
                objArray5[0] = obj1;
                object[] Arguments2 = objArray4;
                double Expression2 = Conversions.ToDouble(NewLateBinding.LateGet((object) null, Type1, "Truncate", Arguments2, (string[]) null, (Type[]) null, (bool[]) null));
                Type Type3 = typeof (Math);
                object[] objArray7 = new object[1];
                object[] objArray8 = objArray7;
                object Left5 = Left3;
                Type Type4 = typeof (Math);
                object[] objArray9 = new object[1]
                {
                  RuntimeHelpers.GetObjectValue(Left3)
                };
                object[] Arguments3 = objArray9;
                bool[] flagArray2 = new bool[1]{ true };
                bool[] CopyBack2 = flagArray2;
                object Right3 = NewLateBinding.LateGet((object) null, Type4, "Truncate", Arguments3, (string[]) null, (Type[]) null, CopyBack2);
                if (flagArray2[0])
                  Left3 = RuntimeHelpers.GetObjectValue(objArray9[0]);
                object Left6 = Operators.MultiplyObject(Operators.SubtractObject(Left5, Right3), (object) 60);
                Type Type5 = typeof (Math);
                object[] objArray10 = new object[1];
                object[] objArray11 = objArray10;
                object Left7 = Left3;
                Type Type6 = typeof (Math);
                object[] objArray12 = new object[1]
                {
                  RuntimeHelpers.GetObjectValue(Left3)
                };
                object[] Arguments4 = objArray12;
                bool[] flagArray3 = new bool[1]{ true };
                bool[] CopyBack3 = flagArray3;
                object Right4 = NewLateBinding.LateGet((object) null, Type6, "Truncate", Arguments4, (string[]) null, (Type[]) null, CopyBack3);
                if (flagArray3[0])
                  RuntimeHelpers.GetObjectValue(objArray12[0]);
                object obj2 = Operators.MultiplyObject(Operators.SubtractObject(Left7, Right4), (object) 60);
                objArray11[0] = obj2;
                object[] Arguments5 = objArray10;
                object Right5 = NewLateBinding.LateGet((object) null, Type5, "Truncate", Arguments5, (string[]) null, (Type[]) null, (bool[]) null);
                object obj3 = Operators.MultiplyObject(Operators.SubtractObject(Left6, Right5), (object) 60);
                objArray8[0] = obj3;
                object[] Arguments6 = objArray7;
                double Expression3 = Conversions.ToDouble(NewLateBinding.LateGet((object) null, Type3, "Truncate", Arguments6, (string[]) null, (Type[]) null, (bool[]) null));
                Observateur observateur3 = new Observateur(MyProject.Forms.Home.Stations[index1, 0], -Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 3]), Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 2]), Conversions.ToDouble(MyProject.Forms.Home.Stations[index1, 4]));
                observateur3.CalculPosVit(dat);
                object satTrack = MyProject.Forms.Home.SatTrack;
                object[] objArray13 = new object[1]
                {
                  (object) observateur3
                };
                object[] Arguments7 = objArray13;
                bool[] flagArray4 = new bool[1]{ true };
                bool[] CopyBack4 = flagArray4;
                NewLateBinding.LateCall(satTrack, (Type) null, "CalculCoordHoriz", Arguments7, (string[]) null, (Type[]) null, CopyBack4, true);
                if (flagArray4[0])
                {
                  Observateur observateur4 = (Observateur) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray13[0]), typeof (Observateur));
                }
                double xdec3 = Conversions.ToDouble(Functions.Round4(Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "Azimut", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
                double xdec4 = Conversions.ToDouble(Functions.Round4(Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "Hauteur", new object[0], (string[]) null, (Type[]) null, (bool[]) null)))));
                Maths.Deg2DMS(xdec3, ref deg, ref min, ref sec);
                string str1 = Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
                Maths.Deg2DMS(xdec4, ref deg, ref min, ref sec);
                string str2 = Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
                double num15 = Conversions.ToDouble(NewLateBinding.LateGet(MyProject.Forms.Home.SatTrack, (Type) null, "Distance", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
                string str3 = MyProject.Forms.Home.VZN <= 0.01 ? (MyProject.Forms.Home.VZN >= 0.01 ? "N/A" : "DESC") : "ASC";
                double num16;
                if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater((object) MyProject.Forms.Home.EPOCH, objArray2[index1, 1], false), Operators.CompareObjectLess((object) MyProject.Forms.Home.EPOCH, objArray2[index1, 2], false))))
                  num16 = Conversions.ToDouble(Operators.SubtractObject(objArray2[index1, 2], (object) MyProject.Forms.Home.EPOCH));
                string str4 = num16 == Conversions.ToDouble("0.0") ? "-" : Conversions.ToString(Functions.HtoHMS(Conversions.ToString(num16 * 24.0)));
                num16 = 0.0;
                objArray1[0] = (object) MyProject.Forms.Home.Stations[index1, 1];
                objArray1[1] = (object) "End";
                objArray1[2] = (object) Functions.MJDtoGreg(Conversions.ToString(objArray2[index1, 2]));
                if (this.GS_Range_Ranging.Checked)
                  objArray1[3] = (object) "-";
                else
                  objArray1[3] = (object) (Strings.Format((object) Expression1, "00") + ":" + Strings.Format((object) Expression2, "00") + ":" + Strings.Format((object) Expression3, "00"));
                objArray1[4] = (object) str1;
                objArray1[5] = (object) str2;
                objArray1[6] = RuntimeHelpers.GetObjectValue(Functions.Round4(num15));
                this.GS_Grid[7, checked (this.GS_Grid.Rows.Count - 1)].Value = (object) str4;
                objArray1[8] = (object) str3;
                this.GS_Grid.Rows.Add(objArray1);
                objArray2[index1, 0] = (object) null;
              }
            }
            checked { ++index1; }
          }
          Left2 = Conversions.ToDouble(Operators.AddObject((object) Left2, Right1));
          this.GS_ProgressBar.Value = Left2 * 100.0 / num3 <= 100.0 ? checked ((int) Math.Round(unchecked (Left2 * 100.0 / num3))) : 100;
        }
        this.GS_ProgressBar.Value = 0;
        this.GS_ProgressBar.Visible = false;
      }
    }

    private void GS_Antenna_Limit_SelectedIndexChanged(object sender, EventArgs e)
    {
      MyProject.Forms.Home.LimitAngle = Conversions.ToString(this.GS_Antenna_Limit.SelectedItem);
      MyProject.Forms.Home.GS_Antenna_Limit.SelectedItem = (object) MyProject.Forms.Home.LimitAngle;
    }

    private void GS_Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      MyProject.Forms.Home.TrackingOptions.Enabled = true;
      MyProject.Forms.Home.Epoch_SetDate(Functions.GregtoMJD(Conversions.ToString(this.GS_Grid.CurrentCell.Value)));
      MyProject.Forms.Home.TLE_Prediction();
      MyProject.Forms.Home.TimeVisibility();
      MyProject.Forms.Home.Graph_Actualise(true);
    }

    private void GS_Range_Day_CheckedChanged(object sender, EventArgs e)
    {
      this.GS_Range_Ranging.Enabled = false;
      this.GS_Range_EpochStart.Enabled = false;
    }

    private void GS_Range_Period_CheckedChanged(object sender, EventArgs e)
    {
      this.GS_Range_Ranging.Enabled = true;
      this.GS_Range_EpochStart.Enabled = true;
      this.GS_Range_Ranging.Checked = false;
      this.GS_Range_EpochStart.Checked = false;
    }

    private void GS_Range_Ranging_CheckedChanged(object sender, EventArgs e)
    {
      if (this.GS_Range_Ranging.Checked)
      {
        if (MyProject.Forms.Home.GS_ListBox.CheckedItems.Count > 1)
        {
          int num = (int) Interaction.MsgBox((object) "Ranging is only available for 1 active station", MsgBoxStyle.Information, (object) "TLE ANALYSER - Ground Stations");
          this.GS_Range_Ranging.Checked = false;
          this.GS_Range_EpochStart.Checked = false;
        }
        this.GS_Range_EpochStart.Enabled = true;
      }
      else
        this.GS_Range_EpochStart.Enabled = false;
    }

    private void GS_Export2CSV_Click(object sender, EventArgs e)
    {
      string fName = MyProject.Forms.Home.EXPORTPath + MyProject.Forms.Home.SATNAME + ".csv";
      this.SaveGridDataInFile(ref fName, this.GS_Grid);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SaveGridDataInFile(ref string fName, DataGridView dataGridView1)
    {
      string str1 = "";
      try
      {
        FileSystem.FileOpen(1, fName, OpenMode.Output);
        int num1 = checked (dataGridView1.Rows.Count - 1);
        int rowIndex = 0;
        while (rowIndex <= num1)
        {
          int num2 = checked (dataGridView1.Columns.Count - 1);
          int columnIndex = 0;
          while (columnIndex <= num2)
          {
            string str2 = dataGridView1[columnIndex, rowIndex].Value is DBNull ? "" : Conversions.ToString(dataGridView1[columnIndex, rowIndex].Value);
            str1 = str1 + "\"" + str2 + "\",";
            checked { ++columnIndex; }
          }
          FileSystem.WriteLine(1, (object) str1.Remove(checked (str1.Length - 1), 1));
          str1 = "";
          checked { ++rowIndex; }
        }
        FileSystem.FileClose(1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) ("Error occured while writing to the file." + ex.ToString()));
        ProjectData.ClearProjectError();
      }
      finally
      {
        FileSystem.FileClose(1);
      }
    }
  }
}
