// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Home
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
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  [DesignerGenerated]
  public class Home : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("MenuStrip")]
    private MenuStrip _MenuStrip;
    [AccessedThroughProperty("ExitToolStripMenuItem")]
    private ToolStripMenuItem _ExitToolStripMenuItem;
    [AccessedThroughProperty("AboutToolStripMenuItem")]
    private ToolStripMenuItem _AboutToolStripMenuItem;
    [AccessedThroughProperty("Timer1")]
    private Timer _Timer1;
    [AccessedThroughProperty("Timer2")]
    private Timer _Timer2;
    [AccessedThroughProperty("TrackingOptions")]
    private GroupBox _TrackingOptions;
    [AccessedThroughProperty("SIM_Forward")]
    private Button _SIM_Forward;
    [AccessedThroughProperty("SIM_Unit")]
    private ComboBox _SIM_Unit;
    [AccessedThroughProperty("SIM_Step")]
    private ComboBox _SIM_Step;
    [AccessedThroughProperty("SIM_Backward")]
    private Button _SIM_Backward;
    [AccessedThroughProperty("SIM_Pause")]
    private Button _SIM_Pause;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("NowDate")]
    private LinkLabel _NowDate;
    [AccessedThroughProperty("Label133")]
    private Label _Label133;
    [AccessedThroughProperty("GSTBox")]
    private TextBox _GSTBox;
    [AccessedThroughProperty("Label134")]
    private Label _Label134;
    [AccessedThroughProperty("EPOCH_Format")]
    private ComboBox _EPOCH_Format;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("EPOCH_Current")]
    private TextBox _EPOCH_Current;
    [AccessedThroughProperty("MapOptions")]
    private GroupBox _MapOptions;
    [AccessedThroughProperty("MAP_FullGrid")]
    private CheckBox _MAP_FullGrid;
    [AccessedThroughProperty("MAP_ShowTrack")]
    private CheckBox _MAP_ShowTrack;
    [AccessedThroughProperty("Label25")]
    private Label _Label25;
    [AccessedThroughProperty("MAP_Num_Period")]
    private ComboBox _MAP_Num_Period;
    [AccessedThroughProperty("GroupBox3")]
    private GroupBox _GroupBox3;
    [AccessedThroughProperty("ETFP_Label")]
    private LinkLabel _ETFP_Label;
    [AccessedThroughProperty("Label138")]
    private Label _Label138;
    [AccessedThroughProperty("Label137")]
    private Label _Label137;
    [AccessedThroughProperty("Label136")]
    private Label _Label136;
    [AccessedThroughProperty("Label135")]
    private Label _Label135;
    [AccessedThroughProperty("LONGBox")]
    private TextBox _LONGBox;
    [AccessedThroughProperty("LATBox")]
    private TextBox _LATBox;
    [AccessedThroughProperty("ETFPBox")]
    private TextBox _ETFPBox;
    [AccessedThroughProperty("Label119")]
    private Label _Label119;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("MABox")]
    private TextBox _MABox;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("ALPHABox")]
    private TextBox _ALPHABox;
    [AccessedThroughProperty("TABox")]
    private TextBox _TABox;
    [AccessedThroughProperty("Label70")]
    private Label _Label70;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("Label69")]
    private Label _Label69;
    [AccessedThroughProperty("EABox")]
    private TextBox _EABox;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("GroupBox6")]
    private GroupBox _GroupBox6;
    [AccessedThroughProperty("APVBox")]
    private TextBox _APVBox;
    [AccessedThroughProperty("PEVBox")]
    private TextBox _PEVBox;
    [AccessedThroughProperty("Label77")]
    private Label _Label77;
    [AccessedThroughProperty("Label40")]
    private Label _Label40;
    [AccessedThroughProperty("Label78")]
    private Label _Label78;
    [AccessedThroughProperty("Label39")]
    private Label _Label39;
    [AccessedThroughProperty("VELBox")]
    private TextBox _VELBox;
    [AccessedThroughProperty("Label37")]
    private Label _Label37;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("GroupBox8")]
    private GroupBox _GroupBox8;
    [AccessedThroughProperty("DracoPeriod_Label")]
    private LinkLabel _DracoPeriod_Label;
    [AccessedThroughProperty("AnoPeriod_Label")]
    private LinkLabel _AnoPeriod_Label;
    [AccessedThroughProperty("APERBox")]
    private TextBox _APERBox;
    [AccessedThroughProperty("DPERBox")]
    private TextBox _DPERBox;
    [AccessedThroughProperty("Label28")]
    private Label _Label28;
    [AccessedThroughProperty("Label30")]
    private Label _Label30;
    [AccessedThroughProperty("GroupBox7")]
    private GroupBox _GroupBox7;
    [AccessedThroughProperty("Label141")]
    private Label _Label141;
    [AccessedThroughProperty("Label118")]
    private Label _Label118;
    [AccessedThroughProperty("MALTBox")]
    private TextBox _MALTBox;
    [AccessedThroughProperty("PERBox")]
    private TextBox _PERBox;
    [AccessedThroughProperty("PEABox")]
    private TextBox _PEABox;
    [AccessedThroughProperty("APRBox")]
    private TextBox _APRBox;
    [AccessedThroughProperty("APABox")]
    private TextBox _APABox;
    [AccessedThroughProperty("ApALabel")]
    private Label _ApALabel;
    [AccessedThroughProperty("PeALabel")]
    private Label _PeALabel;
    [AccessedThroughProperty("Label140")]
    private Label _Label140;
    [AccessedThroughProperty("Label22")]
    private Label _Label22;
    [AccessedThroughProperty("ALTLabel")]
    private Label _ALTLabel;
    [AccessedThroughProperty("Label23")]
    private Label _Label23;
    [AccessedThroughProperty("ALTBox")]
    private TextBox _ALTBox;
    [AccessedThroughProperty("Label139")]
    private Label _Label139;
    [AccessedThroughProperty("Label121")]
    private Label _Label121;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("KeplerElementsFrame")]
    private GroupBox _KeplerElementsFrame;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("AOPBox")]
    private TextBox _AOPBox;
    [AccessedThroughProperty("SMABox")]
    private TextBox _SMABox;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("RAANBox")]
    private TextBox _RAANBox;
    [AccessedThroughProperty("INCBox")]
    private TextBox _INCBox;
    [AccessedThroughProperty("ECCBox")]
    private TextBox _ECCBox;
    [AccessedThroughProperty("AOP_Label")]
    private Label _AOP_Label;
    [AccessedThroughProperty("RAAN_Label")]
    private Label _RAAN_Label;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("MAP_MainTab")]
    private TabControl _MAP_MainTab;
    [AccessedThroughProperty("MAP_2DMapTab")]
    private TabPage _MAP_2DMapTab;
    [AccessedThroughProperty("MapPanel")]
    private Panel _MapPanel;
    [AccessedThroughProperty("TracePicture")]
    private PictureBox _TracePicture;
    [AccessedThroughProperty("SatPicture")]
    private PictureBox _SatPicture;
    [AccessedThroughProperty("GroupBox9")]
    private GroupBox _GroupBox9;
    [AccessedThroughProperty("DLong_Label")]
    private LinkLabel _DLong_Label;
    [AccessedThroughProperty("DLBox")]
    private TextBox _DLBox;
    [AccessedThroughProperty("Label31")]
    private Label _Label31;
    [AccessedThroughProperty("Label73")]
    private Label _Label73;
    [AccessedThroughProperty("Label67")]
    private Label _Label67;
    [AccessedThroughProperty("MMBox")]
    private TextBox _MMBox;
    [AccessedThroughProperty("APBox")]
    private TextBox _APBox;
    [AccessedThroughProperty("Label74")]
    private Label _Label74;
    [AccessedThroughProperty("Label65")]
    private Label _Label65;
    [AccessedThroughProperty("Label72")]
    private Label _Label72;
    [AccessedThroughProperty("Label71")]
    private Label _Label71;
    [AccessedThroughProperty("NPBox")]
    private TextBox _NPBox;
    [AccessedThroughProperty("AP_GroupBox")]
    private GroupBox _AP_GroupBox;
    [AccessedThroughProperty("EquPanel")]
    private Panel _EquPanel;
    [AccessedThroughProperty("Label100")]
    private Label _Label100;
    [AccessedThroughProperty("iy")]
    private TextBox _iy;
    [AccessedThroughProperty("Label101")]
    private Label _Label101;
    [AccessedThroughProperty("Label88")]
    private Label _Label88;
    [AccessedThroughProperty("Label99")]
    private Label _Label99;
    [AccessedThroughProperty("SMA_AP_INC")]
    private TextBox _SMA_AP_INC;
    [AccessedThroughProperty("ix")]
    private TextBox _ix;
    [AccessedThroughProperty("Label98")]
    private Label _Label98;
    [AccessedThroughProperty("Label89")]
    private Label _Label89;
    [AccessedThroughProperty("Label102")]
    private Label _Label102;
    [AccessedThroughProperty("AOP_AP_INC")]
    private TextBox _AOP_AP_INC;
    [AccessedThroughProperty("Label87")]
    private Label _Label87;
    [AccessedThroughProperty("MA_AP")]
    private TextBox _MA_AP;
    [AccessedThroughProperty("ECC_AP_INC")]
    private TextBox _ECC_AP_INC;
    [AccessedThroughProperty("Label84")]
    private Label _Label84;
    [AccessedThroughProperty("CircularPanel")]
    private Panel _CircularPanel;
    [AccessedThroughProperty("Label82")]
    private Label _Label82;
    [AccessedThroughProperty("ey")]
    private TextBox _ey;
    [AccessedThroughProperty("Label97")]
    private Label _Label97;
    [AccessedThroughProperty("Label96")]
    private Label _Label96;
    [AccessedThroughProperty("Label83")]
    private Label _Label83;
    [AccessedThroughProperty("SMA_AP_ECC")]
    private TextBox _SMA_AP_ECC;
    [AccessedThroughProperty("Label80")]
    private Label _Label80;
    [AccessedThroughProperty("Label81")]
    private Label _Label81;
    [AccessedThroughProperty("Label95")]
    private Label _Label95;
    [AccessedThroughProperty("INC_AP_ECC")]
    private TextBox _INC_AP_ECC;
    [AccessedThroughProperty("label110")]
    private Label _label110;
    [AccessedThroughProperty("Label79")]
    private Label _Label79;
    [AccessedThroughProperty("ex")]
    private TextBox _ex;
    [AccessedThroughProperty("AlphaPrime")]
    private TextBox _AlphaPrime;
    [AccessedThroughProperty("RAAN_AP_ECC")]
    private TextBox _RAAN_AP_ECC;
    [AccessedThroughProperty("CircEquPanel")]
    private Panel _CircEquPanel;
    [AccessedThroughProperty("Label104")]
    private Label _Label104;
    [AccessedThroughProperty("Label103")]
    private Label _Label103;
    [AccessedThroughProperty("Label85")]
    private Label _Label85;
    [AccessedThroughProperty("MeanL_ECCINC")]
    private TextBox _MeanL_ECCINC;
    [AccessedThroughProperty("SMA_AP_ECCINC")]
    private TextBox _SMA_AP_ECCINC;
    [AccessedThroughProperty("Label93")]
    private Label _Label93;
    [AccessedThroughProperty("Label86")]
    private Label _Label86;
    [AccessedThroughProperty("Label91")]
    private Label _Label91;
    [AccessedThroughProperty("ex_ECCINC")]
    private TextBox _ex_ECCINC;
    [AccessedThroughProperty("iy_ECCINC")]
    private TextBox _iy_ECCINC;
    [AccessedThroughProperty("Label92")]
    private Label _Label92;
    [AccessedThroughProperty("ix_ECCINC")]
    private TextBox _ix_ECCINC;
    [AccessedThroughProperty("Label90")]
    private Label _Label90;
    [AccessedThroughProperty("ey_ECCINC")]
    private TextBox _ey_ECCINC;
    [AccessedThroughProperty("Label124")]
    private Label _Label124;
    [AccessedThroughProperty("CartesianElementsFrame")]
    private GroupBox _CartesianElementsFrame;
    [AccessedThroughProperty("Label34")]
    private Label _Label34;
    [AccessedThroughProperty("Label35")]
    private Label _Label35;
    [AccessedThroughProperty("Label36")]
    private Label _Label36;
    [AccessedThroughProperty("Label33")]
    private Label _Label33;
    [AccessedThroughProperty("Label32")]
    private Label _Label32;
    [AccessedThroughProperty("XBox")]
    private TextBox _XBox;
    [AccessedThroughProperty("Label38")]
    private Label _Label38;
    [AccessedThroughProperty("VZBox")]
    private TextBox _VZBox;
    [AccessedThroughProperty("VYBox")]
    private TextBox _VYBox;
    [AccessedThroughProperty("VXBox")]
    private TextBox _VXBox;
    [AccessedThroughProperty("ZBox")]
    private TextBox _ZBox;
    [AccessedThroughProperty("YBox")]
    private TextBox _YBox;
    [AccessedThroughProperty("Label42")]
    private Label _Label42;
    [AccessedThroughProperty("Label43")]
    private Label _Label43;
    [AccessedThroughProperty("Label44")]
    private Label _Label44;
    [AccessedThroughProperty("Label45")]
    private Label _Label45;
    [AccessedThroughProperty("Label46")]
    private Label _Label46;
    [AccessedThroughProperty("Label47")]
    private Label _Label47;
    [AccessedThroughProperty("HelpToolStripMenuItem")]
    private ToolStripMenuItem _HelpToolStripMenuItem;
    [AccessedThroughProperty("AboutToolStripMenuItem1")]
    private ToolStripMenuItem _AboutToolStripMenuItem1;
    [AccessedThroughProperty("HelpToolStripMenuItem1")]
    private ToolStripMenuItem _HelpToolStripMenuItem1;
    [AccessedThroughProperty("ExitToolStripMenuItem1")]
    private ToolStripMenuItem _ExitToolStripMenuItem1;
    [AccessedThroughProperty("Label107")]
    private Label _Label107;
    [AccessedThroughProperty("Label94")]
    private Label _Label94;
    [AccessedThroughProperty("TLE_Search_But")]
    private Button _TLE_Search_But;
    [AccessedThroughProperty("TLE_ListBox")]
    private ListBox _TLE_ListBox;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("TLETextBox")]
    private TextBox _TLETextBox;
    [AccessedThroughProperty("phase")]
    private TextBox _phase;
    [AccessedThroughProperty("LNGLATBOX")]
    private TextBox _LNGLATBOX;
    [AccessedThroughProperty("LNGLATSUNBOX")]
    private TextBox _LNGLATSUNBOX;
    [AccessedThroughProperty("LONGACCLab")]
    private Label _LONGACCLab;
    [AccessedThroughProperty("LONGACCBox")]
    private TextBox _LONGACCBox;
    [AccessedThroughProperty("Label130")]
    private Label _Label130;
    [AccessedThroughProperty("SIM_Foreward_SbS")]
    private Button _SIM_Foreward_SbS;
    [AccessedThroughProperty("SIM_Backward_SbS")]
    private Button _SIM_Backward_SbS;
    [AccessedThroughProperty("MenuToolStripMenuItem")]
    private ToolStripMenuItem _MenuToolStripMenuItem;
    [AccessedThroughProperty("ToolsMenuStrip")]
    private ToolStripMenuItem _ToolsMenuStrip;
    [AccessedThroughProperty("AboutMenuStrip")]
    private ToolStripMenuItem _AboutMenuStrip;
    [AccessedThroughProperty("HelpMenuStrip")]
    private ToolStripMenuItem _HelpMenuStrip;
    [AccessedThroughProperty("ExitMenuStrip")]
    private ToolStripMenuItem _ExitMenuStrip;
    [AccessedThroughProperty("TLEToolStripMenuItem1")]
    private ToolStripMenuItem _TLEToolStripMenuItem1;
    [AccessedThroughProperty("Label125")]
    private Label _Label125;
    [AccessedThroughProperty("CATNbre")]
    private TextBox _CATNbre;
    [AccessedThroughProperty("Label112")]
    private Label _Label112;
    [AccessedThroughProperty("Spacecraft")]
    private TextBox _Spacecraft;
    [AccessedThroughProperty("SCName")]
    private TextBox _SCName;
    [AccessedThroughProperty("RelDist")]
    private TextBox _RelDist;
    [AccessedThroughProperty("Label154")]
    private Label _Label154;
    [AccessedThroughProperty("EclipseBox")]
    private TextBox _EclipseBox;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("ETFEBox")]
    private TextBox _ETFEBox;
    [AccessedThroughProperty("Label153")]
    private Label _Label153;
    [AccessedThroughProperty("ToolsToolStripMenuItem")]
    private ToolStripMenuItem _ToolsToolStripMenuItem;
    [AccessedThroughProperty("TLEToolStripMenuItem")]
    private ToolStripMenuItem _TLEToolStripMenuItem;
    [AccessedThroughProperty("ReloadTLEToolStripMenuItem")]
    private ToolStripMenuItem _ReloadTLEToolStripMenuItem;
    [AccessedThroughProperty("OpenFavouritesToolStripMenuItem")]
    private ToolStripMenuItem _OpenFavouritesToolStripMenuItem;
    [AccessedThroughProperty("SaveToFavouritesToolStripMenuItem")]
    private ToolStripMenuItem _SaveToFavouritesToolStripMenuItem;
    [AccessedThroughProperty("ExportToGMATToolStripMenuItem")]
    private ToolStripMenuItem _ExportToGMATToolStripMenuItem;
    [AccessedThroughProperty("SummaryToolStripMenuItem")]
    private ToolStripMenuItem _SummaryToolStripMenuItem;
    [AccessedThroughProperty("AboutToolStripMenuItem2")]
    private ToolStripMenuItem _AboutToolStripMenuItem2;
    [AccessedThroughProperty("HelpToolStripMenuItem2")]
    private ToolStripMenuItem _HelpToolStripMenuItem2;
    [AccessedThroughProperty("ExitToolStripMenuItem2")]
    private ToolStripMenuItem _ExitToolStripMenuItem2;
    [AccessedThroughProperty("Label155")]
    private Label _Label155;
    [AccessedThroughProperty("LSTBox")]
    private TextBox _LSTBox;
    [AccessedThroughProperty("Label156")]
    private Label _Label156;
    [AccessedThroughProperty("ToolStripMenuItem3")]
    private ToolStripMenuItem _ToolStripMenuItem3;
    [AccessedThroughProperty("GoogleEarthMenu")]
    private ToolStripMenuItem _GoogleEarthMenu;
    [AccessedThroughProperty("ToolStrip1")]
    private ToolStrip _ToolStrip1;
    [AccessedThroughProperty("ButtonMenu_GMAT")]
    private ToolStripButton _ButtonMenu_GMAT;
    [AccessedThroughProperty("ButtonMenu_Report")]
    private ToolStripButton _ButtonMenu_Report;
    [AccessedThroughProperty("ToolStripSeparator4")]
    private ToolStripSeparator _ToolStripSeparator4;
    [AccessedThroughProperty("ButtonMenu_About")]
    private ToolStripButton _ButtonMenu_About;
    [AccessedThroughProperty("ButtonMenu_Help")]
    private ToolStripButton _ButtonMenu_Help;
    [AccessedThroughProperty("ButtonMenu_Exit")]
    private ToolStripButton _ButtonMenu_Exit;
    [AccessedThroughProperty("ToolStripSeparator5")]
    private ToolStripSeparator _ToolStripSeparator5;
    [AccessedThroughProperty("MAP_3DMapTab")]
    private TabPage _MAP_3DMapTab;
    [AccessedThroughProperty("ButtonMenu_Options")]
    private ToolStripButton _ButtonMenu_Options;
    [AccessedThroughProperty("AN_Group")]
    private GroupBox _AN_Group;
    [AccessedThroughProperty("LAN_Label")]
    private LinkLabel _LAN_Label;
    [AccessedThroughProperty("LANType")]
    private Label _LANType;
    [AccessedThroughProperty("LANBox")]
    private TextBox _LANBox;
    [AccessedThroughProperty("LNLabel")]
    private Label _LNLabel;
    [AccessedThroughProperty("LTANBox")]
    private TextBox _LTANBox;
    [AccessedThroughProperty("LTLabel")]
    private Label _LTLabel;
    [AccessedThroughProperty("MAP_NightShadow")]
    private CheckBox _MAP_NightShadow;
    [AccessedThroughProperty("OrbNumBox")]
    private TextBox _OrbNumBox;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label24")]
    private Label _Label24;
    [AccessedThroughProperty("MapSatPict")]
    private PictureBox _MapSatPict;
    [AccessedThroughProperty("MapSunPict")]
    private PictureBox _MapSunPict;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("ButtonMenu_OpenF")]
    private ToolStripButton _ButtonMenu_OpenF;
    [AccessedThroughProperty("ToolStripSeparator3")]
    private ToolStripSeparator _ToolStripSeparator3;
    [AccessedThroughProperty("ButtonMenu_Charts")]
    private ToolStripButton _ButtonMenu_Charts;
    [AccessedThroughProperty("EPOCH_TLE")]
    private TextBox _EPOCH_TLE;
    [AccessedThroughProperty("Fleet_Add")]
    private Button _Fleet_Add;
    [AccessedThroughProperty("ButtonMenu_GMAT_M")]
    private ToolStripButton _ButtonMenu_GMAT_M;
    [AccessedThroughProperty("Fleet_Remove")]
    private Button _Fleet_Remove;
    [AccessedThroughProperty("ToolStripSeparator6")]
    private ToolStripSeparator _ToolStripSeparator6;
    [AccessedThroughProperty("MAP_PtsOnOrbit")]
    private CheckBox _MAP_PtsOnOrbit;
    [AccessedThroughProperty("DNButton")]
    private RadioButton _DNButton;
    [AccessedThroughProperty("ANButton")]
    private RadioButton _ANButton;
    [AccessedThroughProperty("TLE_MainPage")]
    private TabControl _TLE_MainPage;
    [AccessedThroughProperty("TLE_ElementsTab")]
    private TabPage _TLE_ElementsTab;
    [AccessedThroughProperty("SatellitesLabel")]
    private Label _SatellitesLabel;
    [AccessedThroughProperty("CollectionLabel")]
    private Label _CollectionLabel;
    [AccessedThroughProperty("ProgressBar")]
    private ProgressBar _ProgressBar;
    [AccessedThroughProperty("TLEDate")]
    private LinkLabel _TLEDate;
    [AccessedThroughProperty("ODBox")]
    private TextBox _ODBox;
    [AccessedThroughProperty("Label27")]
    private Label _Label27;
    [AccessedThroughProperty("MAP_Show_FullTrack")]
    private CheckBox _MAP_Show_FullTrack;
    [AccessedThroughProperty("SIM_Actu_Track")]
    private Button _SIM_Actu_Track;
    [AccessedThroughProperty("SIM_RealTime")]
    private RadioButton _SIM_RealTime;
    [AccessedThroughProperty("SIM_Manual")]
    private RadioButton _SIM_Manual;
    [AccessedThroughProperty("MousePict")]
    private PictureBox _MousePict;
    [AccessedThroughProperty("LNGLATMouseBOX")]
    private TextBox _LNGLATMouseBOX;
    [AccessedThroughProperty("KepPeriod_Label")]
    private LinkLabel _KepPeriod_Label;
    [AccessedThroughProperty("KPERBox")]
    private TextBox _KPERBox;
    [AccessedThroughProperty("Label26")]
    private Label _Label26;
    [AccessedThroughProperty("ButtonMenu_Paste")]
    private ToolStripButton _ButtonMenu_Paste;
    [AccessedThroughProperty("ButtonMenu_Modify")]
    private ToolStripButton _ButtonMenu_Modify;
    [AccessedThroughProperty("ButtonMenu_Import")]
    private ToolStripButton _ButtonMenu_Import;
    [AccessedThroughProperty("ToolStripSeparator7")]
    private ToolStripSeparator _ToolStripSeparator7;
    [AccessedThroughProperty("TLE_DetailsTab")]
    private TabPage _TLE_DetailsTab;
    [AccessedThroughProperty("Sat_CheckListBox")]
    private CheckedListBox _Sat_CheckListBox;
    [AccessedThroughProperty("TLE_StationsTab")]
    private TabPage _TLE_StationsTab;
    [AccessedThroughProperty("PictureBox1")]
    private PictureBox _PictureBox1;
    [AccessedThroughProperty("ButtonMenu_Personal")]
    private ToolStripButton _ButtonMenu_Personal;
    [AccessedThroughProperty("OpenFileDialog1")]
    private OpenFileDialog _OpenFileDialog1;
    [AccessedThroughProperty("Fleet_Create")]
    private Button _Fleet_Create;
    [AccessedThroughProperty("Fleet_Delete")]
    private Button _Fleet_Delete;
    [AccessedThroughProperty("MAP_SatName")]
    private CheckBox _MAP_SatName;
    [AccessedThroughProperty("Sat_SelectAll")]
    private LinkLabel _Sat_SelectAll;
    [AccessedThroughProperty("MAP_VisibilityZone")]
    private CheckBox _MAP_VisibilityZone;
    [AccessedThroughProperty("SAT_CollectionLabel")]
    private Label _SAT_CollectionLabel;
    [AccessedThroughProperty("ButtonMenu_Stations")]
    private ToolStripButton _ButtonMenu_Stations;
    [AccessedThroughProperty("Label57")]
    private Label _Label57;
    [AccessedThroughProperty("Label56")]
    private Label _Label56;
    [AccessedThroughProperty("Label55")]
    private Label _Label55;
    [AccessedThroughProperty("Stations_alt")]
    private TextBox _Stations_alt;
    [AccessedThroughProperty("Label41")]
    private Label _Label41;
    [AccessedThroughProperty("Stations_lat")]
    private TextBox _Stations_lat;
    [AccessedThroughProperty("Label29")]
    private Label _Label29;
    [AccessedThroughProperty("Stations_lng")]
    private TextBox _Stations_lng;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("Stations_list")]
    private ComboBox _Stations_list;
    [AccessedThroughProperty("Stations_datas_2")]
    private GroupBox _Stations_datas_2;
    [AccessedThroughProperty("Stations_end")]
    private TextBox _Stations_end;
    [AccessedThroughProperty("Label60")]
    private Label _Label60;
    [AccessedThroughProperty("Stations_remTime")]
    private TextBox _Stations_remTime;
    [AccessedThroughProperty("Label59")]
    private Label _Label59;
    [AccessedThroughProperty("Stations_start")]
    private TextBox _Stations_start;
    [AccessedThroughProperty("Label58")]
    private Label _Label58;
    [AccessedThroughProperty("Stations_datas_1")]
    private GroupBox _Stations_datas_1;
    [AccessedThroughProperty("Stations_duration")]
    private TextBox _Stations_duration;
    [AccessedThroughProperty("Label61")]
    private Label _Label61;
    [AccessedThroughProperty("GroupBox4")]
    private GroupBox _GroupBox4;
    [AccessedThroughProperty("GS_ListBox")]
    private CheckedListBox _GS_ListBox;
    [AccessedThroughProperty("GS_CheckAll_CB")]
    private CheckBox _GS_CheckAll_CB;
    [AccessedThroughProperty("Stations_Off")]
    private PictureBox _Stations_Off;
    [AccessedThroughProperty("Stations_On")]
    private PictureBox _Stations_On;
    [AccessedThroughProperty("Label106")]
    private Label _Label106;
    [AccessedThroughProperty("Label108")]
    private Label _Label108;
    [AccessedThroughProperty("GS_Antenna_Limit")]
    private ComboBox _GS_Antenna_Limit;
    [AccessedThroughProperty("GroupBox5")]
    private GroupBox _GroupBox5;
    [AccessedThroughProperty("Label105")]
    private Label _Label105;
    [AccessedThroughProperty("Stations_dist")]
    private TextBox _Stations_dist;
    [AccessedThroughProperty("Label64")]
    private Label _Label64;
    [AccessedThroughProperty("Stations_el")]
    private TextBox _Stations_el;
    [AccessedThroughProperty("Label63")]
    private Label _Label63;
    [AccessedThroughProperty("Stations_az")]
    private TextBox _Stations_az;
    [AccessedThroughProperty("Label62")]
    private Label _Label62;
    [AccessedThroughProperty("GS_El_Link")]
    private LinkLabel _GS_El_Link;
    [AccessedThroughProperty("GS_Az_Link")]
    private LinkLabel _GS_Az_Link;
    [AccessedThroughProperty("radarPicture")]
    private PictureBox _radarPicture;
    [AccessedThroughProperty("GS_ProgressBar")]
    private ProgressBar _GS_ProgressBar;
    [AccessedThroughProperty("OrbitWizardTab")]
    private TabPage _OrbitWizardTab;
    [AccessedThroughProperty("CREATE_Entry")]
    private GroupBox _CREATE_Entry;
    [AccessedThroughProperty("Label66")]
    private Label _Label66;
    [AccessedThroughProperty("CREATE_Collection")]
    private TextBox _CREATE_Collection;
    [AccessedThroughProperty("Label75")]
    private Label _Label75;
    [AccessedThroughProperty("CREATE_Refresh")]
    private Button _CREATE_Refresh;
    [AccessedThroughProperty("CREATE_SatNumb")]
    private TextBox _CREATE_SatNumb;
    [AccessedThroughProperty("Label76")]
    private Label _Label76;
    [AccessedThroughProperty("CREATE_ScName")]
    private TextBox _CREATE_ScName;
    [AccessedThroughProperty("CREATE_Default")]
    private ComboBox _CREATE_Default;
    [AccessedThroughProperty("Label109")]
    private Label _Label109;
    [AccessedThroughProperty("CREATE_EPOCH_Current")]
    private TextBox _CREATE_EPOCH_Current;
    [AccessedThroughProperty("CREATE_EPOCH_Format")]
    private ComboBox _CREATE_EPOCH_Format;
    [AccessedThroughProperty("Label111")]
    private Label _Label111;
    [AccessedThroughProperty("Label113")]
    private Label _Label113;
    [AccessedThroughProperty("CREATE_Elements")]
    private GroupBox _CREATE_Elements;
    [AccessedThroughProperty("CREATE_Panel_Kepler")]
    private Panel _CREATE_Panel_Kepler;
    [AccessedThroughProperty("Label114")]
    private Label _Label114;
    [AccessedThroughProperty("Create_Defil_TA")]
    private HScrollBar _Create_Defil_TA;
    [AccessedThroughProperty("Label115")]
    private Label _Label115;
    [AccessedThroughProperty("Create_Defil_AOP")]
    private HScrollBar _Create_Defil_AOP;
    [AccessedThroughProperty("CREATE_Bstar")]
    private TextBox _CREATE_Bstar;
    [AccessedThroughProperty("Label116")]
    private Label _Label116;
    [AccessedThroughProperty("Create_Defil_RAAN")]
    private HScrollBar _Create_Defil_RAAN;
    [AccessedThroughProperty("Create_Defil_INC")]
    private HScrollBar _Create_Defil_INC;
    [AccessedThroughProperty("Create_Defil_ECC")]
    private HScrollBar _Create_Defil_ECC;
    [AccessedThroughProperty("Create_Defil_SMA")]
    private HScrollBar _Create_Defil_SMA;
    [AccessedThroughProperty("Label117")]
    private Label _Label117;
    [AccessedThroughProperty("CREATE_LNG")]
    private TextBox _CREATE_LNG;
    [AccessedThroughProperty("Label120")]
    private Label _Label120;
    [AccessedThroughProperty("Label122")]
    private Label _Label122;
    [AccessedThroughProperty("Label123")]
    private Label _Label123;
    [AccessedThroughProperty("Label126")]
    private Label _Label126;
    [AccessedThroughProperty("Label127")]
    private Label _Label127;
    [AccessedThroughProperty("Label128")]
    private Label _Label128;
    [AccessedThroughProperty("CREATE_TA")]
    private TextBox _CREATE_TA;
    [AccessedThroughProperty("CREATE_AOP")]
    private TextBox _CREATE_AOP;
    [AccessedThroughProperty("CREATE_RAAN")]
    private TextBox _CREATE_RAAN;
    [AccessedThroughProperty("CREATE_INC")]
    private TextBox _CREATE_INC;
    [AccessedThroughProperty("CREATE_ECC")]
    private TextBox _CREATE_ECC;
    [AccessedThroughProperty("CREATE_SMA")]
    private TextBox _CREATE_SMA;
    [AccessedThroughProperty("Label129")]
    private Label _Label129;
    [AccessedThroughProperty("Label131")]
    private Label _Label131;
    [AccessedThroughProperty("Label132")]
    private Label _Label132;
    [AccessedThroughProperty("Label142")]
    private Label _Label142;
    [AccessedThroughProperty("Label143")]
    private Label _Label143;
    [AccessedThroughProperty("Label144")]
    private Label _Label144;
    [AccessedThroughProperty("CREATE_Panel_Cartesian")]
    private Panel _CREATE_Panel_Cartesian;
    [AccessedThroughProperty("Label145")]
    private Label _Label145;
    [AccessedThroughProperty("Label146")]
    private Label _Label146;
    [AccessedThroughProperty("Label147")]
    private Label _Label147;
    [AccessedThroughProperty("Label148")]
    private Label _Label148;
    [AccessedThroughProperty("Label149")]
    private Label _Label149;
    [AccessedThroughProperty("Label150")]
    private Label _Label150;
    [AccessedThroughProperty("Label151")]
    private Label _Label151;
    [AccessedThroughProperty("Label152")]
    private Label _Label152;
    [AccessedThroughProperty("Label157")]
    private Label _Label157;
    [AccessedThroughProperty("Label158")]
    private Label _Label158;
    [AccessedThroughProperty("Label159")]
    private Label _Label159;
    [AccessedThroughProperty("Label160")]
    private Label _Label160;
    [AccessedThroughProperty("CREATE_VZ")]
    private TextBox _CREATE_VZ;
    [AccessedThroughProperty("CREATE_VY")]
    private TextBox _CREATE_VY;
    [AccessedThroughProperty("CREATE_VX")]
    private TextBox _CREATE_VX;
    [AccessedThroughProperty("CREATE_Z")]
    private TextBox _CREATE_Z;
    [AccessedThroughProperty("CREATE_Y")]
    private TextBox _CREATE_Y;
    [AccessedThroughProperty("CREATE_X")]
    private TextBox _CREATE_X;
    [AccessedThroughProperty("CREATE_Save")]
    private Button _CREATE_Save;
    [AccessedThroughProperty("SaveFileDialog1")]
    private SaveFileDialog _SaveFileDialog1;
    [AccessedThroughProperty("OpenOrbitWizard")]
    private Button _OpenOrbitWizard;
    [AccessedThroughProperty("GS_Actualise")]
    private Button _GS_Actualise;
    [AccessedThroughProperty("orbit3dWeb")]
    private PictureBox _orbit3dWeb;
    [AccessedThroughProperty("GroupBox10")]
    private GroupBox _GroupBox10;
    [AccessedThroughProperty("Raw_Data_GridView")]
    private DataGridView _Raw_Data_GridView;
    [AccessedThroughProperty("Line")]
    private DataGridViewTextBoxColumn _Line;
    [AccessedThroughProperty("Column")]
    private DataGridViewTextBoxColumn _Column;
    [AccessedThroughProperty("Value")]
    private DataGridViewTextBoxColumn _Value;
    [AccessedThroughProperty("Description")]
    private DataGridViewTextBoxColumn _Description;
    public double SMA;
    public double ECC;
    public double INC;
    public double RAAN;
    public double AOP;
    public double MA;
    public double TA;
    public double EA;
    public double ETFP;
    public double AOL;
    public double LAT;
    public double LONGI;
    public double APA;
    public double PEA;
    public double APR;
    public double PER;
    public double ALT;
    public double MALT;
    public double APV;
    public double PEV;
    public double VEL;
    public double BSTAR;
    public double LATS;
    public double LONGIS;
    public double LATTLE;
    public double LONGITLE;
    public double LATXP;
    public double LONGIXP;
    public double DREL;
    public double ETFE;
    public double ETFXP;
    public double LNG_RAD;
    public double LAT_RAD;
    public double X;
    public double Y;
    public double Z;
    public double VX;
    public double VY;
    public double VZ;
    public double XS;
    public double YS;
    public double ZS;
    public double XN;
    public double YN;
    public double ZN;
    public double VXN;
    public double VYN;
    public double VZN;
    public double XTLE;
    public double YTLE;
    public double ZTLE;
    public double VXTLE;
    public double VYTLE;
    public double VZTLE;
    public double lsol;
    public double bsol;
    public double AZ;
    public double EL;
    public double DIST;
    public string AZ_dms;
    public string EL_dms;
    public double XXP;
    public double YXP;
    public double ZXP;
    public double VXXP;
    public double VYXP;
    public double VZXP;
    public double XAN;
    public double YAN;
    public double ZAN;
    public double LATAN;
    public double LONGIAN;
    public double XC;
    public double YC;
    public double ZC;
    public double VXC;
    public double VYC;
    public double VZC;
    public double SMAC;
    public double ECCC;
    public double INCC;
    public double RAANC;
    public double AOPC;
    public double MALTC;
    public double XSC;
    public double YSC;
    public double ZSC;
    public double LNGC;
    public double TAC;
    public double APER;
    public double DPER;
    public double KPER;
    public double LANO;
    public double LAN;
    public double LDN;
    public double MM;
    public double NP;
    public double AP;
    public double DL;
    public double N0;
    public double DN;
    public string LIGNE1;
    public string LIGNE2;
    public string CATNUMB;
    public string TLEFILE;
    public string SATNAME;
    public string TLETXT;
    public string DELTAD;
    public string LTAN;
    public string LTDN;
    public string TLEONAE;
    public string ONAE;
    public string SDOO;
    public string OffsetUTC;
    public bool DeleteFavMode;
    public bool TLELoaded;
    public bool TLETime;
    public bool CheckNW;
    public bool OptionsSaved;
    public bool GEart2Actualise;
    public bool TrackModeActive;
    public string LIGNE1_temp;
    public string LIGNE2_temp;
    public double LAT_temp;
    public double LNG_temp;
    public double ALT_temp;
    public bool AppLoaded;
    public string FleetManagerMode;
    public string FleetFile;
    public string CollectionType;
    public bool FirstTLELoaded;
    public bool CreateFirstOpen;
    public double EPOCH;
    public double EPOCH0;
    public double CREATEPOCH;
    public double GST;
    public double GSTXP;
    public double GSTTLE;
    public double LST;
    public double TLEPOCH;
    public double NT0;
    public double XPEPOCH;
    public double ANEPOCH;
    public double DNEPOCH;
    public double APOEPOCH;
    public double PEREPOCH;
    public string AppPath;
    public string FavPath;
    public string TLEPath;
    public string CATPath;
    public string PersonalTLEPath;
    public string PlotPath;
    public string GMATPath;
    public string CELESTIAPath;
    public string GOOGLEPath;
    public string Orbit3DPath;
    public string EXPORTPath;
    public string FavAdress;
    public string SearchAdress;
    public string StationsFile;
    public string UMFile;
    public string InitFile;
    public string SatCat;
    public string SatCatAnn;
    public string SatCatSources;
    public string SatCatSites;
    public object CheckVersionFile;
    public GoogleEarthControl GoogleEarthControl1;
    public Orbit3DControl Orbit3DControl_;
    public int MapW;
    public int MapH;
    public int MapW1;
    public int MapH1;
    public int MapW2;
    public int MapH2;
    public int radarW;
    public int radarH;
    public Bitmap Trace;
    public Graphics g;
    public Bitmap radarTrace;
    public Graphics radarGraph;
    public PointF[] radarTraceLine;
    public PointF[] SunZone;
    public object[,] SatTrace;
    public PointF[] VisibiltyZone;
    public bool MouseOnSat;
    public int ActiveSatId;
    public string[,] Stations;
    public int StatNum;
    public int SelectedStation;
    public string[,] Satellites;
    public string[,] SatLatLng;
    public object SatActive;
    public object SatTrack;
    public object SatSearch;
    public object SatTleEpoch;
    public object SatXpEpoch;
    public object TleActive;
    public object[] TleList;
    public object listeSatellites;
    private Soleil Soleil;
    public string TLEAIniVersion;
    public string TleUpdateDate;
    public string Speed;
    public string SatVisual1;
    public string SatVisual2;
    public string SatVisual3;
    public string ShowTrack;
    public string OptionGmatModel1;
    public string OptionGmatModel2;
    public string Propagate;
    public string SimulOn;
    public string RealTimeStep;
    public string LoadTleNow;
    public string LoadTleEpoch;
    public string GSFullName;
    public string GSShortName;
    public string LimitAngle;
    public string EquRadius;
    public object TLEAVersionMajor;
    public object TLEAVersionMinor;
    public object TLEAVersion;
    public double SMAs;
    public double ECCs;
    public double INCs;
    public double RAANs;
    public double AOPs;
    public double MAs;
    public double MMs;
    public double EPOCHs;
    public double XCr;
    public double YCr;
    public double ZCr;
    public double VXCr;
    public double VYCr;
    public double VZCr;
    public double SMACr;
    public double ECCCr;
    public double INCCr;
    public double RAANCr;
    public double AOPCr;
    public double MALTCr;
    public double XSCr;
    public double YSCr;
    public double ZSCr;
    public double LNGCr;
    public double TACr;
    public double bstarcr;
    public double lat_;
    public double lng_;
    public double GST_;
    public string TLELine1;
    public string TLELine2;
    private string chemin_fichier;
    private string Collection;
    private string ScNumb;
    public double selectDefault;
    public bool actuTrack;
    private double SATLAT;
    private double SATLNG;

    [DebuggerNonUserCode]
    static Home()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (Home.__ENCList)
      {
        if (Home.__ENCList.Count == Home.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (Home.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (Home.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                Home.__ENCList[index1] = Home.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          Home.__ENCList.RemoveRange(index1, checked (Home.__ENCList.Count - index1));
          Home.__ENCList.Capacity = Home.__ENCList.Count;
        }
        Home.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Home));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      this.OrbNumBox = new TextBox();
      this.Label2 = new Label();
      this.ETFEBox = new TextBox();
      this.Label153 = new Label();
      this.EclipseBox = new TextBox();
      this.Label1 = new Label();
      this.phase = new TextBox();
      this.Label94 = new Label();
      this.RelDist = new TextBox();
      this.Label154 = new Label();
      this.GroupBox1 = new GroupBox();
      this.Label125 = new Label();
      this.CATNbre = new TextBox();
      this.Label112 = new Label();
      this.Spacecraft = new TextBox();
      this.SCName = new TextBox();
      this.TLETextBox = new TextBox();
      this.ProgressBar = new ProgressBar();
      this.Fleet_Remove = new Button();
      this.Fleet_Add = new Button();
      this.TLE_Search_But = new Button();
      this.TLE_ListBox = new ListBox();
      this.GroupBox9 = new GroupBox();
      this.DLong_Label = new LinkLabel();
      this.DLBox = new TextBox();
      this.LONGACCLab = new Label();
      this.Label31 = new Label();
      this.LONGACCBox = new TextBox();
      this.Label73 = new Label();
      this.Label67 = new Label();
      this.Label130 = new Label();
      this.MMBox = new TextBox();
      this.APBox = new TextBox();
      this.Label74 = new Label();
      this.Label65 = new Label();
      this.Label72 = new Label();
      this.Label71 = new Label();
      this.NPBox = new TextBox();
      this.AP_GroupBox = new GroupBox();
      this.EquPanel = new Panel();
      this.Label100 = new Label();
      this.iy = new TextBox();
      this.Label101 = new Label();
      this.Label88 = new Label();
      this.Label99 = new Label();
      this.SMA_AP_INC = new TextBox();
      this.ix = new TextBox();
      this.Label98 = new Label();
      this.Label89 = new Label();
      this.Label102 = new Label();
      this.AOP_AP_INC = new TextBox();
      this.Label87 = new Label();
      this.MA_AP = new TextBox();
      this.ECC_AP_INC = new TextBox();
      this.Label84 = new Label();
      this.CircEquPanel = new Panel();
      this.Label104 = new Label();
      this.Label103 = new Label();
      this.Label85 = new Label();
      this.MeanL_ECCINC = new TextBox();
      this.SMA_AP_ECCINC = new TextBox();
      this.Label93 = new Label();
      this.Label86 = new Label();
      this.Label91 = new Label();
      this.ex_ECCINC = new TextBox();
      this.iy_ECCINC = new TextBox();
      this.Label92 = new Label();
      this.ix_ECCINC = new TextBox();
      this.Label90 = new Label();
      this.ey_ECCINC = new TextBox();
      this.CircularPanel = new Panel();
      this.Label82 = new Label();
      this.ey = new TextBox();
      this.Label97 = new Label();
      this.Label107 = new Label();
      this.Label96 = new Label();
      this.Label83 = new Label();
      this.SMA_AP_ECC = new TextBox();
      this.Label80 = new Label();
      this.Label81 = new Label();
      this.Label95 = new Label();
      this.INC_AP_ECC = new TextBox();
      this.label110 = new Label();
      this.Label79 = new Label();
      this.ex = new TextBox();
      this.AlphaPrime = new TextBox();
      this.RAAN_AP_ECC = new TextBox();
      this.Label124 = new Label();
      this.CartesianElementsFrame = new GroupBox();
      this.XBox = new TextBox();
      this.Label34 = new Label();
      this.Label35 = new Label();
      this.Label36 = new Label();
      this.Label33 = new Label();
      this.Label32 = new Label();
      this.Label38 = new Label();
      this.VZBox = new TextBox();
      this.VYBox = new TextBox();
      this.VXBox = new TextBox();
      this.ZBox = new TextBox();
      this.YBox = new TextBox();
      this.Label42 = new Label();
      this.Label43 = new Label();
      this.Label44 = new Label();
      this.Label45 = new Label();
      this.Label46 = new Label();
      this.Label47 = new Label();
      this.GroupBox2 = new GroupBox();
      this.TLEDate = new LinkLabel();
      this.EPOCH_TLE = new TextBox();
      this.NowDate = new LinkLabel();
      this.EPOCH_Format = new ComboBox();
      this.Label19 = new Label();
      this.EPOCH_Current = new TextBox();
      this.Label155 = new Label();
      this.LSTBox = new TextBox();
      this.Label156 = new Label();
      this.Label133 = new Label();
      this.GSTBox = new TextBox();
      this.Label134 = new Label();
      this.MAP_MainTab = new TabControl();
      this.MAP_2DMapTab = new TabPage();
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.MousePict = new PictureBox();
      this.MapSatPict = new PictureBox();
      this.LNGLATSUNBOX = new TextBox();
      this.MapSunPict = new PictureBox();
      this.LNGLATBOX = new TextBox();
      this.LNGLATMouseBOX = new TextBox();
      this.MapPanel = new Panel();
      this.SatPicture = new PictureBox();
      this.TracePicture = new PictureBox();
      this.MAP_3DMapTab = new TabPage();
      this.orbit3dWeb = new PictureBox();
      this.TrackingOptions = new GroupBox();
      this.SIM_Actu_Track = new Button();
      this.SIM_Backward_SbS = new Button();
      this.SIM_Backward = new Button();
      this.SIM_Forward = new Button();
      this.SIM_Step = new ComboBox();
      this.SIM_Pause = new Button();
      this.SIM_Foreward_SbS = new Button();
      this.SIM_Unit = new ComboBox();
      this.GroupBox3 = new GroupBox();
      this.ODBox = new TextBox();
      this.Label27 = new Label();
      this.Label135 = new Label();
      this.Label24 = new Label();
      this.LATBox = new TextBox();
      this.Label136 = new Label();
      this.ETFP_Label = new LinkLabel();
      this.Label138 = new Label();
      this.Label137 = new Label();
      this.LONGBox = new TextBox();
      this.ETFPBox = new TextBox();
      this.Label119 = new Label();
      this.ALPHABox = new TextBox();
      this.TABox = new TextBox();
      this.Label70 = new Label();
      this.Label17 = new Label();
      this.Label10 = new Label();
      this.Label16 = new Label();
      this.Label69 = new Label();
      this.EABox = new TextBox();
      this.Label9 = new Label();
      this.GroupBox6 = new GroupBox();
      this.APVBox = new TextBox();
      this.PEVBox = new TextBox();
      this.Label77 = new Label();
      this.Label40 = new Label();
      this.Label78 = new Label();
      this.Label39 = new Label();
      this.VELBox = new TextBox();
      this.Label37 = new Label();
      this.Label20 = new Label();
      this.GroupBox8 = new GroupBox();
      this.KepPeriod_Label = new LinkLabel();
      this.KPERBox = new TextBox();
      this.Label26 = new Label();
      this.DracoPeriod_Label = new LinkLabel();
      this.AnoPeriod_Label = new LinkLabel();
      this.APERBox = new TextBox();
      this.DPERBox = new TextBox();
      this.Label28 = new Label();
      this.Label30 = new Label();
      this.GroupBox7 = new GroupBox();
      this.Label141 = new Label();
      this.Label118 = new Label();
      this.MALTBox = new TextBox();
      this.PERBox = new TextBox();
      this.PEABox = new TextBox();
      this.APRBox = new TextBox();
      this.APABox = new TextBox();
      this.ApALabel = new Label();
      this.PeALabel = new Label();
      this.Label140 = new Label();
      this.Label22 = new Label();
      this.ALTLabel = new Label();
      this.Label23 = new Label();
      this.ALTBox = new TextBox();
      this.Label139 = new Label();
      this.Label121 = new Label();
      this.Label7 = new Label();
      this.Label6 = new Label();
      this.MapOptions = new GroupBox();
      this.MAP_VisibilityZone = new CheckBox();
      this.MAP_SatName = new CheckBox();
      this.MAP_Show_FullTrack = new CheckBox();
      this.MAP_PtsOnOrbit = new CheckBox();
      this.MAP_NightShadow = new CheckBox();
      this.MAP_FullGrid = new CheckBox();
      this.MAP_ShowTrack = new CheckBox();
      this.Label25 = new Label();
      this.MAP_Num_Period = new ComboBox();
      this.KeplerElementsFrame = new GroupBox();
      this.Label14 = new Label();
      this.Label13 = new Label();
      this.Label12 = new Label();
      this.Label11 = new Label();
      this.AOPBox = new TextBox();
      this.SMABox = new TextBox();
      this.Label3 = new Label();
      this.RAANBox = new TextBox();
      this.INCBox = new TextBox();
      this.Label15 = new Label();
      this.ECCBox = new TextBox();
      this.MABox = new TextBox();
      this.Label8 = new Label();
      this.AOP_Label = new Label();
      this.RAAN_Label = new Label();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.Timer1 = new Timer(this.components);
      this.Timer2 = new Timer(this.components);
      this.ToolStripMenuItem3 = new ToolStripMenuItem();
      this.GoogleEarthMenu = new ToolStripMenuItem();
      this.ToolStrip1 = new ToolStrip();
      this.ButtonMenu_Personal = new ToolStripButton();
      this.ButtonMenu_Paste = new ToolStripButton();
      this.ButtonMenu_Modify = new ToolStripButton();
      this.ButtonMenu_Import = new ToolStripButton();
      this.ToolStripSeparator7 = new ToolStripSeparator();
      this.ButtonMenu_Report = new ToolStripButton();
      this.ToolStripSeparator5 = new ToolStripSeparator();
      this.ButtonMenu_GMAT = new ToolStripButton();
      this.ButtonMenu_GMAT_M = new ToolStripButton();
      this.ToolStripSeparator6 = new ToolStripSeparator();
      this.ButtonMenu_OpenF = new ToolStripButton();
      this.ToolStripSeparator3 = new ToolStripSeparator();
      this.ButtonMenu_Stations = new ToolStripButton();
      this.ButtonMenu_Charts = new ToolStripButton();
      this.ToolStripSeparator4 = new ToolStripSeparator();
      this.ButtonMenu_Options = new ToolStripButton();
      this.ButtonMenu_About = new ToolStripButton();
      this.ButtonMenu_Help = new ToolStripButton();
      this.ButtonMenu_Exit = new ToolStripButton();
      this.AN_Group = new GroupBox();
      this.DNButton = new RadioButton();
      this.ANButton = new RadioButton();
      this.LAN_Label = new LinkLabel();
      this.LANType = new Label();
      this.LANBox = new TextBox();
      this.LNLabel = new Label();
      this.LTANBox = new TextBox();
      this.LTLabel = new Label();
      this.TLE_MainPage = new TabControl();
      this.TLE_ElementsTab = new TabPage();
      this.GroupBox10 = new GroupBox();
      this.TLE_DetailsTab = new TabPage();
      this.Raw_Data_GridView = new DataGridView();
      this.Line = new DataGridViewTextBoxColumn();
      this.Column = new DataGridViewTextBoxColumn();
      this.Value = new DataGridViewTextBoxColumn();
      this.Description = new DataGridViewTextBoxColumn();
      this.TLE_StationsTab = new TabPage();
      this.GroupBox5 = new GroupBox();
      this.GS_El_Link = new LinkLabel();
      this.GS_Az_Link = new LinkLabel();
      this.Label105 = new Label();
      this.Stations_dist = new TextBox();
      this.Label64 = new Label();
      this.Stations_el = new TextBox();
      this.Label63 = new Label();
      this.Stations_az = new TextBox();
      this.Label62 = new Label();
      this.GroupBox4 = new GroupBox();
      this.radarPicture = new PictureBox();
      this.GS_CheckAll_CB = new CheckBox();
      this.GS_ListBox = new CheckedListBox();
      this.Stations_datas_2 = new GroupBox();
      this.GS_Actualise = new Button();
      this.GS_ProgressBar = new ProgressBar();
      this.Stations_Off = new PictureBox();
      this.Stations_On = new PictureBox();
      this.Stations_duration = new TextBox();
      this.Label61 = new Label();
      this.Stations_end = new TextBox();
      this.Label60 = new Label();
      this.Stations_remTime = new TextBox();
      this.Label59 = new Label();
      this.Stations_start = new TextBox();
      this.Label58 = new Label();
      this.Stations_datas_1 = new GroupBox();
      this.Label106 = new Label();
      this.Label108 = new Label();
      this.GS_Antenna_Limit = new ComboBox();
      this.Label18 = new Label();
      this.Stations_list = new ComboBox();
      this.Label21 = new Label();
      this.Label57 = new Label();
      this.Stations_lng = new TextBox();
      this.Label56 = new Label();
      this.Label29 = new Label();
      this.Label55 = new Label();
      this.Stations_lat = new TextBox();
      this.Stations_alt = new TextBox();
      this.Label41 = new Label();
      this.OrbitWizardTab = new TabPage();
      this.CREATE_Save = new Button();
      this.CREATE_Elements = new GroupBox();
      this.CREATE_Panel_Kepler = new Panel();
      this.Label114 = new Label();
      this.Create_Defil_TA = new HScrollBar();
      this.Label115 = new Label();
      this.Create_Defil_AOP = new HScrollBar();
      this.CREATE_Bstar = new TextBox();
      this.Label116 = new Label();
      this.Create_Defil_RAAN = new HScrollBar();
      this.Create_Defil_INC = new HScrollBar();
      this.Create_Defil_ECC = new HScrollBar();
      this.Create_Defil_SMA = new HScrollBar();
      this.Label117 = new Label();
      this.CREATE_LNG = new TextBox();
      this.Label120 = new Label();
      this.Label122 = new Label();
      this.Label123 = new Label();
      this.Label126 = new Label();
      this.Label127 = new Label();
      this.Label128 = new Label();
      this.CREATE_TA = new TextBox();
      this.CREATE_AOP = new TextBox();
      this.CREATE_RAAN = new TextBox();
      this.CREATE_INC = new TextBox();
      this.CREATE_ECC = new TextBox();
      this.CREATE_SMA = new TextBox();
      this.Label129 = new Label();
      this.Label131 = new Label();
      this.Label132 = new Label();
      this.Label142 = new Label();
      this.Label143 = new Label();
      this.Label144 = new Label();
      this.CREATE_Refresh = new Button();
      this.CREATE_Panel_Cartesian = new Panel();
      this.Label145 = new Label();
      this.Label146 = new Label();
      this.Label147 = new Label();
      this.Label148 = new Label();
      this.Label149 = new Label();
      this.Label150 = new Label();
      this.Label151 = new Label();
      this.Label152 = new Label();
      this.Label157 = new Label();
      this.Label158 = new Label();
      this.Label159 = new Label();
      this.Label160 = new Label();
      this.CREATE_VZ = new TextBox();
      this.CREATE_VY = new TextBox();
      this.CREATE_VX = new TextBox();
      this.CREATE_Z = new TextBox();
      this.CREATE_Y = new TextBox();
      this.CREATE_X = new TextBox();
      this.CREATE_Entry = new GroupBox();
      this.Label66 = new Label();
      this.CREATE_Collection = new TextBox();
      this.Label75 = new Label();
      this.CREATE_SatNumb = new TextBox();
      this.Label76 = new Label();
      this.CREATE_ScName = new TextBox();
      this.CREATE_Default = new ComboBox();
      this.Label109 = new Label();
      this.CREATE_EPOCH_Current = new TextBox();
      this.CREATE_EPOCH_Format = new ComboBox();
      this.Label111 = new Label();
      this.Label113 = new Label();
      this.Sat_CheckListBox = new CheckedListBox();
      this.SatellitesLabel = new Label();
      this.CollectionLabel = new Label();
      this.SIM_Manual = new RadioButton();
      this.SIM_RealTime = new RadioButton();
      this.PictureBox1 = new PictureBox();
      this.OpenFileDialog1 = new OpenFileDialog();
      this.Fleet_Create = new Button();
      this.Fleet_Delete = new Button();
      this.Sat_SelectAll = new LinkLabel();
      this.SAT_CollectionLabel = new Label();
      this.SaveFileDialog1 = new SaveFileDialog();
      this.OpenOrbitWizard = new Button();
      this.GroupBox1.SuspendLayout();
      this.GroupBox9.SuspendLayout();
      this.AP_GroupBox.SuspendLayout();
      this.EquPanel.SuspendLayout();
      this.CircEquPanel.SuspendLayout();
      this.CircularPanel.SuspendLayout();
      this.CartesianElementsFrame.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.MAP_MainTab.SuspendLayout();
      this.MAP_2DMapTab.SuspendLayout();
      this.TableLayoutPanel1.SuspendLayout();
      ((ISupportInitialize) this.MousePict).BeginInit();
      ((ISupportInitialize) this.MapSatPict).BeginInit();
      ((ISupportInitialize) this.MapSunPict).BeginInit();
      this.MapPanel.SuspendLayout();
      ((ISupportInitialize) this.SatPicture).BeginInit();
      ((ISupportInitialize) this.TracePicture).BeginInit();
      this.MAP_3DMapTab.SuspendLayout();
      ((ISupportInitialize) this.orbit3dWeb).BeginInit();
      this.TrackingOptions.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox6.SuspendLayout();
      this.GroupBox8.SuspendLayout();
      this.GroupBox7.SuspendLayout();
      this.MapOptions.SuspendLayout();
      this.KeplerElementsFrame.SuspendLayout();
      this.ToolStrip1.SuspendLayout();
      this.AN_Group.SuspendLayout();
      this.TLE_MainPage.SuspendLayout();
      this.TLE_ElementsTab.SuspendLayout();
      this.GroupBox10.SuspendLayout();
      this.TLE_DetailsTab.SuspendLayout();
      ((ISupportInitialize) this.Raw_Data_GridView).BeginInit();
      this.TLE_StationsTab.SuspendLayout();
      this.GroupBox5.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      ((ISupportInitialize) this.radarPicture).BeginInit();
      this.Stations_datas_2.SuspendLayout();
      ((ISupportInitialize) this.Stations_Off).BeginInit();
      ((ISupportInitialize) this.Stations_On).BeginInit();
      this.Stations_datas_1.SuspendLayout();
      this.OrbitWizardTab.SuspendLayout();
      this.CREATE_Elements.SuspendLayout();
      this.CREATE_Panel_Kepler.SuspendLayout();
      this.CREATE_Panel_Cartesian.SuspendLayout();
      this.CREATE_Entry.SuspendLayout();
      ((ISupportInitialize) this.PictureBox1).BeginInit();
      this.SuspendLayout();
      this.OrbNumBox.BackColor = SystemColors.Control;
      this.OrbNumBox.BorderStyle = BorderStyle.None;
      TextBox orbNumBox1 = this.OrbNumBox;
      Point point1 = new Point(49, 67);
      Point point2 = point1;
      orbNumBox1.Location = point2;
      this.OrbNumBox.Name = "OrbNumBox";
      this.OrbNumBox.ReadOnly = true;
      TextBox orbNumBox2 = this.OrbNumBox;
      Size size1 = new Size(55, 13);
      Size size2 = size1;
      orbNumBox2.Size = size2;
      this.OrbNumBox.TabIndex = 84;
      this.OrbNumBox.TextAlign = HorizontalAlignment.Right;
      this.Label2.AutoSize = true;
      this.Label2.ImeMode = ImeMode.NoControl;
      Label label2_1 = this.Label2;
      point1 = new Point(6, 67);
      Point point3 = point1;
      label2_1.Location = point3;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(37, 13);
      Size size3 = size1;
      label2_2.Size = size3;
      this.Label2.TabIndex = 83;
      this.Label2.Text = "ONAE";
      this.ETFEBox.BackColor = SystemColors.Control;
      this.ETFEBox.BorderStyle = BorderStyle.None;
      TextBox etfeBox1 = this.ETFEBox;
      point1 = new Point(50, 136);
      Point point4 = point1;
      etfeBox1.Location = point4;
      this.ETFEBox.Name = "ETFEBox";
      this.ETFEBox.ReadOnly = true;
      TextBox etfeBox2 = this.ETFEBox;
      size1 = new Size(65, 13);
      Size size4 = size1;
      etfeBox2.Size = size4;
      this.ETFEBox.TabIndex = 82;
      this.ETFEBox.TextAlign = HorizontalAlignment.Right;
      this.Label153.AutoSize = true;
      this.Label153.ImeMode = ImeMode.NoControl;
      Label label153_1 = this.Label153;
      point1 = new Point(6, 136);
      Point point5 = point1;
      label153_1.Location = point5;
      this.Label153.Name = "Label153";
      Label label153_2 = this.Label153;
      size1 = new Size(34, 13);
      Size size5 = size1;
      label153_2.Size = size5;
      this.Label153.TabIndex = 81;
      this.Label153.Text = "ETFE";
      this.EclipseBox.BackColor = SystemColors.Control;
      this.EclipseBox.BorderStyle = BorderStyle.None;
      TextBox eclipseBox1 = this.EclipseBox;
      point1 = new Point(49, 87);
      Point point6 = point1;
      eclipseBox1.Location = point6;
      this.EclipseBox.Name = "EclipseBox";
      this.EclipseBox.ReadOnly = true;
      TextBox eclipseBox2 = this.EclipseBox;
      size1 = new Size(76, 13);
      Size size6 = size1;
      eclipseBox2.Size = size6;
      this.EclipseBox.TabIndex = 80;
      this.EclipseBox.TextAlign = HorizontalAlignment.Right;
      this.Label1.AutoSize = true;
      this.Label1.ImeMode = ImeMode.NoControl;
      Label label1_1 = this.Label1;
      point1 = new Point(6, 87);
      Point point7 = point1;
      label1_1.Location = point7;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(41, 13);
      Size size7 = size1;
      label1_2.Size = size7;
      this.Label1.TabIndex = 79;
      this.Label1.Text = "Eclipse";
      this.phase.BackColor = SystemColors.Control;
      this.phase.BorderStyle = BorderStyle.None;
      TextBox phase1 = this.phase;
      point1 = new Point(54, 76);
      Point point8 = point1;
      phase1.Location = point8;
      this.phase.Name = "phase";
      this.phase.ReadOnly = true;
      TextBox phase2 = this.phase;
      size1 = new Size(94, 13);
      Size size8 = size1;
      phase2.Size = size8;
      this.phase.TabIndex = 78;
      this.phase.TextAlign = HorizontalAlignment.Right;
      this.Label94.AutoSize = true;
      this.Label94.ImeMode = ImeMode.NoControl;
      Label label94_1 = this.Label94;
      point1 = new Point(6, 76);
      Point point9 = point1;
      label94_1.Location = point9;
      this.Label94.Name = "Label94";
      Label label94_2 = this.Label94;
      size1 = new Size(45, 13);
      Size size9 = size1;
      label94_2.Size = size9;
      this.Label94.TabIndex = 77;
      this.Label94.Text = "Phasing";
      this.RelDist.BackColor = SystemColors.Control;
      this.RelDist.BorderStyle = BorderStyle.None;
      TextBox relDist1 = this.RelDist;
      point1 = new Point(47, 134);
      Point point10 = point1;
      relDist1.Location = point10;
      this.RelDist.Name = "RelDist";
      this.RelDist.ReadOnly = true;
      TextBox relDist2 = this.RelDist;
      size1 = new Size(67, 13);
      Size size10 = size1;
      relDist2.Size = size10;
      this.RelDist.TabIndex = 44;
      this.RelDist.TextAlign = HorizontalAlignment.Right;
      this.Label154.AutoSize = true;
      this.Label154.ImeMode = ImeMode.NoControl;
      Label label154_1 = this.Label154;
      point1 = new Point(6, 134);
      Point point11 = point1;
      label154_1.Location = point11;
      this.Label154.Name = "Label154";
      Label label154_2 = this.Label154;
      size1 = new Size(36, 13);
      Size size11 = size1;
      label154_2.Size = size11;
      this.Label154.TabIndex = 46;
      this.Label154.Text = "DREL";
      this.GroupBox1.Controls.Add((Control) this.Label125);
      this.GroupBox1.Controls.Add((Control) this.CATNbre);
      this.GroupBox1.Controls.Add((Control) this.Label112);
      this.GroupBox1.Controls.Add((Control) this.Spacecraft);
      this.GroupBox1.Controls.Add((Control) this.SCName);
      this.GroupBox1.Controls.Add((Control) this.TLETextBox);
      this.GroupBox1.Controls.Add((Control) this.ProgressBar);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(9, 37);
      Point point12 = point1;
      groupBox1_1.Location = point12;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(497, 81);
      Size size12 = size1;
      groupBox1_2.Size = size12;
      this.GroupBox1.TabIndex = 78;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Two Line Elements";
      this.Label125.AutoSize = true;
      this.Label125.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label125.ImeMode = ImeMode.NoControl;
      Label label125_1 = this.Label125;
      point1 = new Point(353, 16);
      Point point13 = point1;
      label125_1.Location = point13;
      this.Label125.Name = "Label125";
      Label label125_2 = this.Label125;
      size1 = new Size(35, 13);
      Size size13 = size1;
      label125_2.Size = size13;
      this.Label125.TabIndex = 80;
      this.Label125.Text = "CAT#";
      this.CATNbre.BackColor = SystemColors.Control;
      this.CATNbre.BorderStyle = BorderStyle.None;
      this.CATNbre.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
      this.CATNbre.ForeColor = Color.RoyalBlue;
      TextBox catNbre1 = this.CATNbre;
      point1 = new Point(394, 16);
      Point point14 = point1;
      catNbre1.Location = point14;
      this.CATNbre.Name = "CATNbre";
      TextBox catNbre2 = this.CATNbre;
      size1 = new Size(92, 13);
      Size size14 = size1;
      catNbre2.Size = size14;
      this.CATNbre.TabIndex = 79;
      this.Label112.AutoSize = true;
      this.Label112.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label112.ImeMode = ImeMode.NoControl;
      Label label112_1 = this.Label112;
      point1 = new Point(246, 16);
      Point point15 = point1;
      label112_1.Location = point15;
      this.Label112.Name = "Label112";
      Label label112_2 = this.Label112;
      size1 = new Size(35, 13);
      Size size15 = size1;
      label112_2.Size = size15;
      this.Label112.TabIndex = 78;
      this.Label112.Text = "SAT#";
      this.Spacecraft.BackColor = SystemColors.Control;
      this.Spacecraft.BorderStyle = BorderStyle.None;
      this.Spacecraft.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
      this.Spacecraft.ForeColor = Color.RoyalBlue;
      TextBox spacecraft1 = this.Spacecraft;
      point1 = new Point(287, 16);
      Point point16 = point1;
      spacecraft1.Location = point16;
      this.Spacecraft.Name = "Spacecraft";
      TextBox spacecraft2 = this.Spacecraft;
      size1 = new Size(60, 13);
      Size size16 = size1;
      spacecraft2.Size = size16;
      this.Spacecraft.TabIndex = 77;
      this.SCName.BackColor = SystemColors.Control;
      this.SCName.BorderStyle = BorderStyle.None;
      this.SCName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
      this.SCName.ForeColor = Color.RoyalBlue;
      TextBox scName1 = this.SCName;
      point1 = new Point(6, 16);
      Point point17 = point1;
      scName1.Location = point17;
      this.SCName.Name = "SCName";
      this.SCName.ReadOnly = true;
      TextBox scName2 = this.SCName;
      size1 = new Size(234, 13);
      Size size17 = size1;
      scName2.Size = size17;
      this.SCName.TabIndex = 76;
      this.TLETextBox.BackColor = SystemColors.Menu;
      this.TLETextBox.BorderStyle = BorderStyle.None;
      this.TLETextBox.Font = new Font("Lucida Console", 8.25f);
      TextBox tleTextBox1 = this.TLETextBox;
      point1 = new Point(3, 35);
      Point point18 = point1;
      tleTextBox1.Location = point18;
      this.TLETextBox.MaxLength = 140;
      this.TLETextBox.Multiline = true;
      this.TLETextBox.Name = "TLETextBox";
      TextBox tleTextBox2 = this.TLETextBox;
      size1 = new Size(489, 27);
      Size size18 = size1;
      tleTextBox2.Size = size18;
      this.TLETextBox.TabIndex = 2;
      ProgressBar progressBar1 = this.ProgressBar;
      point1 = new Point(428, 35);
      Point point19 = point1;
      progressBar1.Location = point19;
      this.ProgressBar.Name = "ProgressBar";
      ProgressBar progressBar2 = this.ProgressBar;
      size1 = new Size(58, 20);
      Size size19 = size1;
      progressBar2.Size = size19;
      this.ProgressBar.TabIndex = 72;
      this.ProgressBar.Visible = false;
      this.Fleet_Remove.BackColor = Color.Transparent;
      this.Fleet_Remove.Enabled = false;
      this.Fleet_Remove.Image = (Image) componentResourceManager.GetObject("Fleet_Remove.Image");
      this.Fleet_Remove.ImeMode = ImeMode.NoControl;
      Button fleetRemove1 = this.Fleet_Remove;
      point1 = new Point(858, 168);
      Point point20 = point1;
      fleetRemove1.Location = point20;
      this.Fleet_Remove.Name = "Fleet_Remove";
      Button fleetRemove2 = this.Fleet_Remove;
      size1 = new Size(24, 24);
      Size size20 = size1;
      fleetRemove2.Size = size20;
      this.Fleet_Remove.TabIndex = 74;
      this.Fleet_Remove.UseVisualStyleBackColor = false;
      this.Fleet_Add.BackColor = Color.Transparent;
      this.Fleet_Add.Enabled = false;
      this.Fleet_Add.Image = (Image) componentResourceManager.GetObject("Fleet_Add.Image");
      this.Fleet_Add.ImeMode = ImeMode.NoControl;
      Button fleetAdd1 = this.Fleet_Add;
      point1 = new Point(858, 138);
      Point point21 = point1;
      fleetAdd1.Location = point21;
      this.Fleet_Add.Name = "Fleet_Add";
      Button fleetAdd2 = this.Fleet_Add;
      size1 = new Size(24, 24);
      Size size21 = size1;
      fleetAdd2.Size = size21;
      this.Fleet_Add.TabIndex = 73;
      this.Fleet_Add.UseVisualStyleBackColor = false;
      this.TLE_Search_But.BackColor = Color.Transparent;
      this.TLE_Search_But.Image = (Image) componentResourceManager.GetObject("TLE_Search_But.Image");
      this.TLE_Search_But.ImeMode = ImeMode.NoControl;
      Button tleSearchBut1 = this.TLE_Search_But;
      point1 = new Point(858, 25);
      Point point22 = point1;
      tleSearchBut1.Location = point22;
      this.TLE_Search_But.Name = "TLE_Search_But";
      Button tleSearchBut2 = this.TLE_Search_But;
      size1 = new Size(24, 24);
      Size size22 = size1;
      tleSearchBut2.Size = size22;
      this.TLE_Search_But.TabIndex = 72;
      this.TLE_Search_But.UseVisualStyleBackColor = false;
      this.TLE_ListBox.FormattingEnabled = true;
      ListBox tleListBox1 = this.TLE_ListBox;
      point1 = new Point(514, 25);
      Point point23 = point1;
      tleListBox1.Location = point23;
      this.TLE_ListBox.Name = "TLE_ListBox";
      ListBox tleListBox2 = this.TLE_ListBox;
      size1 = new Size(162, 199);
      Size size23 = size1;
      tleListBox2.Size = size23;
      this.TLE_ListBox.Sorted = true;
      this.TLE_ListBox.TabIndex = 0;
      this.GroupBox9.Controls.Add((Control) this.DLong_Label);
      this.GroupBox9.Controls.Add((Control) this.DLBox);
      this.GroupBox9.Controls.Add((Control) this.LONGACCLab);
      this.GroupBox9.Controls.Add((Control) this.Label31);
      this.GroupBox9.Controls.Add((Control) this.LONGACCBox);
      this.GroupBox9.Controls.Add((Control) this.Label73);
      this.GroupBox9.Controls.Add((Control) this.Label67);
      this.GroupBox9.Controls.Add((Control) this.Label130);
      this.GroupBox9.Controls.Add((Control) this.MMBox);
      this.GroupBox9.Controls.Add((Control) this.APBox);
      this.GroupBox9.Controls.Add((Control) this.Label74);
      this.GroupBox9.Controls.Add((Control) this.Label65);
      this.GroupBox9.Controls.Add((Control) this.Label72);
      this.GroupBox9.Controls.Add((Control) this.Label71);
      this.GroupBox9.Controls.Add((Control) this.NPBox);
      GroupBox groupBox9_1 = this.GroupBox9;
      point1 = new Point(167, 463);
      Point point24 = point1;
      groupBox9_1.Location = point24;
      this.GroupBox9.Name = "GroupBox9";
      GroupBox groupBox9_2 = this.GroupBox9;
      size1 = new Size(178, 116);
      Size size24 = size1;
      groupBox9_2.Size = size24;
      this.GroupBox9.TabIndex = 77;
      this.GroupBox9.TabStop = false;
      this.GroupBox9.Text = "Mvmt - Precession";
      this.DLong_Label.AutoSize = true;
      this.DLong_Label.ImeMode = ImeMode.NoControl;
      this.DLong_Label.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel dlongLabel1 = this.DLong_Label;
      point1 = new Point(129, 76);
      Point point25 = point1;
      dlongLabel1.Location = point25;
      this.DLong_Label.Name = "DLong_Label";
      LinkLabel dlongLabel2 = this.DLong_Label;
      size1 = new Size(25, 13);
      Size size25 = size1;
      dlongLabel2.Size = size25;
      this.DLong_Label.TabIndex = 73;
      this.DLong_Label.TabStop = true;
      this.DLong_Label.Text = "deg";
      this.DLBox.BackColor = SystemColors.Control;
      this.DLBox.BorderStyle = BorderStyle.None;
      TextBox dlBox1 = this.DLBox;
      point1 = new Point(56, 76);
      Point point26 = point1;
      dlBox1.Location = point26;
      this.DLBox.Name = "DLBox";
      this.DLBox.ReadOnly = true;
      TextBox dlBox2 = this.DLBox;
      size1 = new Size(65, 13);
      Size size26 = size1;
      dlBox2.Size = size26;
      this.DLBox.TabIndex = 62;
      this.DLBox.TextAlign = HorizontalAlignment.Right;
      this.LONGACCLab.AutoSize = true;
      this.LONGACCLab.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.LONGACCLab.ImeMode = ImeMode.NoControl;
      Label longaccLab1 = this.LONGACCLab;
      point1 = new Point(6, 96);
      Point point27 = point1;
      longaccLab1.Location = point27;
      this.LONGACCLab.Name = "LONGACCLab";
      Label longaccLab2 = this.LONGACCLab;
      size1 = new Size(32, 13);
      Size size27 = size1;
      longaccLab2.Size = size27;
      this.LONGACCLab.TabIndex = 84;
      this.LONGACCLab.Text = "LAcc";
      this.Label31.AutoSize = true;
      this.Label31.ImeMode = ImeMode.NoControl;
      Label label31_1 = this.Label31;
      point1 = new Point(6, 76);
      Point point28 = point1;
      label31_1.Location = point28;
      this.Label31.Name = "Label31";
      Label label31_2 = this.Label31;
      size1 = new Size(21, 13);
      Size size28 = size1;
      label31_2.Size = size28;
      this.Label31.TabIndex = 63;
      this.Label31.Text = "DL";
      this.LONGACCBox.BackColor = SystemColors.Control;
      this.LONGACCBox.BorderStyle = BorderStyle.None;
      this.LONGACCBox.Font = new Font("Microsoft Sans Serif", 8.25f);
      TextBox longaccBox1 = this.LONGACCBox;
      point1 = new Point(56, 96);
      Point point29 = point1;
      longaccBox1.Location = point29;
      this.LONGACCBox.Name = "LONGACCBox";
      this.LONGACCBox.ReadOnly = true;
      TextBox longaccBox2 = this.LONGACCBox;
      size1 = new Size(63, 13);
      Size size29 = size1;
      longaccBox2.Size = size29;
      this.LONGACCBox.TabIndex = 83;
      this.LONGACCBox.TextAlign = HorizontalAlignment.Right;
      this.Label73.AutoSize = true;
      this.Label73.ImeMode = ImeMode.NoControl;
      Label label73_1 = this.Label73;
      point1 = new Point(129, 38);
      Point point30 = point1;
      label73_1.Location = point30;
      this.Label73.Name = "Label73";
      Label label73_2 = this.Label73;
      size1 = new Size(47, 13);
      Size size30 = size1;
      label73_2.Size = size30;
      this.Label73.TabIndex = 58;
      this.Label73.Text = "deg/day";
      this.Label67.AutoSize = true;
      this.Label67.ImeMode = ImeMode.NoControl;
      Label label67_1 = this.Label67;
      point1 = new Point(6, 19);
      Point point31 = point1;
      label67_1.Location = point31;
      this.Label67.Name = "Label67";
      Label label67_2 = this.Label67;
      size1 = new Size(25, 13);
      Size size31 = size1;
      label67_2.Size = size31;
      this.Label67.TabIndex = 51;
      this.Label67.Text = "MM";
      this.Label130.AutoSize = true;
      this.Label130.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label130.ImeMode = ImeMode.NoControl;
      Label label130_1 = this.Label130;
      point1 = new Point(130, 96);
      Point point32 = point1;
      label130_1.Location = point32;
      this.Label130.Name = "Label130";
      Label label130_2 = this.Label130;
      size1 = new Size(39, 13);
      Size size32 = size1;
      label130_2.Size = size32;
      this.Label130.TabIndex = 85;
      this.Label130.Text = "deg.j-2";
      this.MMBox.BackColor = SystemColors.Control;
      this.MMBox.BorderStyle = BorderStyle.None;
      TextBox mmBox1 = this.MMBox;
      point1 = new Point(56, 19);
      Point point33 = point1;
      mmBox1.Location = point33;
      this.MMBox.Name = "MMBox";
      this.MMBox.ReadOnly = true;
      TextBox mmBox2 = this.MMBox;
      size1 = new Size(65, 13);
      Size size33 = size1;
      mmBox2.Size = size33;
      this.MMBox.TabIndex = 50;
      this.MMBox.TextAlign = HorizontalAlignment.Right;
      this.APBox.BackColor = SystemColors.Control;
      this.APBox.BorderStyle = BorderStyle.None;
      TextBox apBox1 = this.APBox;
      point1 = new Point(56, 57);
      Point point34 = point1;
      apBox1.Location = point34;
      this.APBox.Name = "APBox";
      this.APBox.ReadOnly = true;
      TextBox apBox2 = this.APBox;
      size1 = new Size(65, 13);
      Size size34 = size1;
      apBox2.Size = size34;
      this.APBox.TabIndex = 59;
      this.APBox.TextAlign = HorizontalAlignment.Right;
      this.Label74.AutoSize = true;
      this.Label74.ImeMode = ImeMode.NoControl;
      Label label74_1 = this.Label74;
      point1 = new Point(6, 38);
      Point point35 = point1;
      label74_1.Location = point35;
      this.Label74.Name = "Label74";
      Label label74_2 = this.Label74;
      size1 = new Size(22, 13);
      Size size35 = size1;
      label74_2.Size = size35;
      this.Label74.TabIndex = 57;
      this.Label74.Text = "NP";
      this.Label65.AutoSize = true;
      this.Label65.ImeMode = ImeMode.NoControl;
      Label label65_1 = this.Label65;
      point1 = new Point(129, 19);
      Point point36 = point1;
      label65_1.Location = point36;
      this.Label65.Name = "Label65";
      Label label65_2 = this.Label65;
      size1 = new Size(44, 13);
      Size size36 = size1;
      label65_2.Size = size36;
      this.Label65.TabIndex = 52;
      this.Label65.Text = "rev/day";
      this.Label72.AutoSize = true;
      this.Label72.ImeMode = ImeMode.NoControl;
      Label label72_1 = this.Label72;
      point1 = new Point(6, 57);
      Point point37 = point1;
      label72_1.Location = point37;
      this.Label72.Name = "Label72";
      Label label72_2 = this.Label72;
      size1 = new Size(21, 13);
      Size size37 = size1;
      label72_2.Size = size37;
      this.Label72.TabIndex = 60;
      this.Label72.Text = "AP";
      this.Label71.AutoSize = true;
      this.Label71.ImeMode = ImeMode.NoControl;
      Label label71_1 = this.Label71;
      point1 = new Point(129, 57);
      Point point38 = point1;
      label71_1.Location = point38;
      this.Label71.Name = "Label71";
      Label label71_2 = this.Label71;
      size1 = new Size(47, 13);
      Size size38 = size1;
      label71_2.Size = size38;
      this.Label71.TabIndex = 61;
      this.Label71.Text = "deg/day";
      this.NPBox.BackColor = SystemColors.Control;
      this.NPBox.BorderStyle = BorderStyle.None;
      TextBox npBox1 = this.NPBox;
      point1 = new Point(56, 38);
      Point point39 = point1;
      npBox1.Location = point39;
      this.NPBox.Name = "NPBox";
      this.NPBox.ReadOnly = true;
      TextBox npBox2 = this.NPBox;
      size1 = new Size(65, 13);
      Size size39 = size1;
      npBox2.Size = size39;
      this.NPBox.TabIndex = 56;
      this.NPBox.TextAlign = HorizontalAlignment.Right;
      this.AP_GroupBox.Controls.Add((Control) this.EquPanel);
      this.AP_GroupBox.Controls.Add((Control) this.CircEquPanel);
      this.AP_GroupBox.Controls.Add((Control) this.CircularPanel);
      this.AP_GroupBox.Controls.Add((Control) this.Label124);
      GroupBox apGroupBox1 = this.AP_GroupBox;
      point1 = new Point(167, 145);
      Point point40 = point1;
      apGroupBox1.Location = point40;
      this.AP_GroupBox.Name = "AP_GroupBox";
      GroupBox apGroupBox2 = this.AP_GroupBox;
      size1 = new Size(178, 137);
      Size size40 = size1;
      apGroupBox2.Size = size40;
      this.AP_GroupBox.TabIndex = 76;
      this.AP_GroupBox.TabStop = false;
      this.AP_GroupBox.Text = "Adapted Parameter";
      this.EquPanel.Controls.Add((Control) this.Label100);
      this.EquPanel.Controls.Add((Control) this.iy);
      this.EquPanel.Controls.Add((Control) this.Label101);
      this.EquPanel.Controls.Add((Control) this.Label88);
      this.EquPanel.Controls.Add((Control) this.Label99);
      this.EquPanel.Controls.Add((Control) this.SMA_AP_INC);
      this.EquPanel.Controls.Add((Control) this.ix);
      this.EquPanel.Controls.Add((Control) this.Label98);
      this.EquPanel.Controls.Add((Control) this.Label89);
      this.EquPanel.Controls.Add((Control) this.Label102);
      this.EquPanel.Controls.Add((Control) this.AOP_AP_INC);
      this.EquPanel.Controls.Add((Control) this.Label87);
      this.EquPanel.Controls.Add((Control) this.MA_AP);
      this.EquPanel.Controls.Add((Control) this.ECC_AP_INC);
      this.EquPanel.Controls.Add((Control) this.Label84);
      Panel equPanel1 = this.EquPanel;
      point1 = new Point(6, 14);
      Point point41 = point1;
      equPanel1.Location = point41;
      this.EquPanel.Name = "EquPanel";
      Panel equPanel2 = this.EquPanel;
      size1 = new Size(154, 118);
      Size size41 = size1;
      equPanel2.Size = size41;
      this.EquPanel.TabIndex = 1;
      this.EquPanel.Visible = false;
      this.Label100.AutoSize = true;
      this.Label100.ImeMode = ImeMode.NoControl;
      Label label100_1 = this.Label100;
      point1 = new Point(5, 3);
      Point point42 = point1;
      label100_1.Location = point42;
      this.Label100.Name = "Label100";
      Label label100_2 = this.Label100;
      size1 = new Size(30, 13);
      Size size42 = size1;
      label100_2.Size = size42;
      this.Label100.TabIndex = 65;
      this.Label100.Text = "SMA";
      this.iy.BackColor = SystemColors.Control;
      this.iy.BorderStyle = BorderStyle.None;
      TextBox iy1 = this.iy;
      point1 = new Point(50, 61);
      Point point43 = point1;
      iy1.Location = point43;
      this.iy.Name = "iy";
      this.iy.ReadOnly = true;
      TextBox iy2 = this.iy;
      size1 = new Size(65, 13);
      Size size43 = size1;
      iy2.Size = size43;
      this.iy.TabIndex = 57;
      this.iy.TextAlign = HorizontalAlignment.Right;
      this.Label101.AutoSize = true;
      this.Label101.ImeMode = ImeMode.NoControl;
      Label label101_1 = this.Label101;
      point1 = new Point(123, 98);
      Point point44 = point1;
      label101_1.Location = point44;
      this.Label101.Name = "Label101";
      Label label101_2 = this.Label101;
      size1 = new Size(25, 13);
      Size size44 = size1;
      label101_2.Size = size44;
      this.Label101.TabIndex = 72;
      this.Label101.Text = "deg";
      this.Label88.AutoSize = true;
      this.Label88.ImeMode = ImeMode.NoControl;
      Label label88_1 = this.Label88;
      point1 = new Point(6, 60);
      Point point45 = point1;
      label88_1.Location = point45;
      this.Label88.Name = "Label88";
      Label label88_2 = this.Label88;
      size1 = new Size(14, 13);
      Size size45 = size1;
      label88_2.Size = size45;
      this.Label88.TabIndex = 58;
      this.Label88.Text = "iy";
      this.Label99.AutoSize = true;
      this.Label99.ImeMode = ImeMode.NoControl;
      Label label99_1 = this.Label99;
      point1 = new Point(5, 21);
      Point point46 = point1;
      label99_1.Location = point46;
      this.Label99.Name = "Label99";
      Label label99_2 = this.Label99;
      size1 = new Size(28, 13);
      Size size46 = size1;
      label99_2.Size = size46;
      this.Label99.TabIndex = 66;
      this.Label99.Text = "ECC";
      this.SMA_AP_INC.BackColor = SystemColors.Control;
      this.SMA_AP_INC.BorderStyle = BorderStyle.None;
      TextBox smaApInc1 = this.SMA_AP_INC;
      point1 = new Point(50, 3);
      Point point47 = point1;
      smaApInc1.Location = point47;
      this.SMA_AP_INC.Name = "SMA_AP_INC";
      this.SMA_AP_INC.ReadOnly = true;
      TextBox smaApInc2 = this.SMA_AP_INC;
      size1 = new Size(65, 13);
      Size size47 = size1;
      smaApInc2.Size = size47;
      this.SMA_AP_INC.TabIndex = 67;
      this.SMA_AP_INC.TextAlign = HorizontalAlignment.Right;
      this.ix.BackColor = SystemColors.Control;
      this.ix.BorderStyle = BorderStyle.None;
      TextBox ix1 = this.ix;
      point1 = new Point(50, 42);
      Point point48 = point1;
      ix1.Location = point48;
      this.ix.Name = "ix";
      this.ix.ReadOnly = true;
      TextBox ix2 = this.ix;
      size1 = new Size(65, 13);
      Size size48 = size1;
      ix2.Size = size48;
      this.ix.TabIndex = 55;
      this.ix.TextAlign = HorizontalAlignment.Right;
      this.Label98.AutoSize = true;
      this.Label98.ImeMode = ImeMode.NoControl;
      Label label98_1 = this.Label98;
      point1 = new Point(123, 2);
      Point point49 = point1;
      label98_1.Location = point49;
      this.Label98.Name = "Label98";
      Label label98_2 = this.Label98;
      size1 = new Size(21, 13);
      Size size49 = size1;
      label98_2.Size = size49;
      this.Label98.TabIndex = 69;
      this.Label98.Text = "km";
      this.Label89.AutoSize = true;
      this.Label89.ImeMode = ImeMode.NoControl;
      Label label89_1 = this.Label89;
      point1 = new Point(6, 41);
      Point point50 = point1;
      label89_1.Location = point50;
      this.Label89.Name = "Label89";
      Label label89_2 = this.Label89;
      size1 = new Size(14, 13);
      Size size50 = size1;
      label89_2.Size = size50;
      this.Label89.TabIndex = 56;
      this.Label89.Text = "ix";
      this.Label102.AutoSize = true;
      this.Label102.ImeMode = ImeMode.NoControl;
      Label label102_1 = this.Label102;
      point1 = new Point(3, 98);
      Point point51 = point1;
      label102_1.Location = point51;
      this.Label102.Name = "Label102";
      Label label102_2 = this.Label102;
      size1 = new Size(23, 13);
      Size size51 = size1;
      label102_2.Size = size51;
      this.Label102.TabIndex = 70;
      this.Label102.Text = "MA";
      this.AOP_AP_INC.BackColor = SystemColors.Control;
      this.AOP_AP_INC.BorderStyle = BorderStyle.None;
      TextBox aopApInc1 = this.AOP_AP_INC;
      point1 = new Point(50, 80);
      Point point52 = point1;
      aopApInc1.Location = point52;
      this.AOP_AP_INC.Name = "AOP_AP_INC";
      this.AOP_AP_INC.ReadOnly = true;
      TextBox aopApInc2 = this.AOP_AP_INC;
      size1 = new Size(65, 13);
      Size size52 = size1;
      aopApInc2.Size = size52;
      this.AOP_AP_INC.TabIndex = 59;
      this.AOP_AP_INC.TextAlign = HorizontalAlignment.Right;
      this.Label87.AutoSize = true;
      this.Label87.ImeMode = ImeMode.NoControl;
      Label label87_1 = this.Label87;
      point1 = new Point(5, 79);
      Point point53 = point1;
      label87_1.Location = point53;
      this.Label87.Name = "Label87";
      Label label87_2 = this.Label87;
      size1 = new Size(17, 13);
      Size size53 = size1;
      label87_2.Size = size53;
      this.Label87.TabIndex = 60;
      this.Label87.Text = "ω'";
      this.MA_AP.BackColor = SystemColors.Control;
      this.MA_AP.BorderStyle = BorderStyle.None;
      TextBox maAp1 = this.MA_AP;
      point1 = new Point(50, 99);
      Point point54 = point1;
      maAp1.Location = point54;
      this.MA_AP.Name = "MA_AP";
      this.MA_AP.ReadOnly = true;
      TextBox maAp2 = this.MA_AP;
      size1 = new Size(65, 13);
      Size size54 = size1;
      maAp2.Size = size54;
      this.MA_AP.TabIndex = 71;
      this.MA_AP.TextAlign = HorizontalAlignment.Right;
      this.ECC_AP_INC.BackColor = SystemColors.Control;
      this.ECC_AP_INC.BorderStyle = BorderStyle.None;
      TextBox eccApInc1 = this.ECC_AP_INC;
      point1 = new Point(50, 22);
      Point point55 = point1;
      eccApInc1.Location = point55;
      this.ECC_AP_INC.Name = "ECC_AP_INC";
      this.ECC_AP_INC.ReadOnly = true;
      TextBox eccApInc2 = this.ECC_AP_INC;
      size1 = new Size(65, 13);
      Size size55 = size1;
      eccApInc2.Size = size55;
      this.ECC_AP_INC.TabIndex = 68;
      this.ECC_AP_INC.TextAlign = HorizontalAlignment.Right;
      this.Label84.AutoSize = true;
      this.Label84.ImeMode = ImeMode.NoControl;
      Label label84_1 = this.Label84;
      point1 = new Point(123, 78);
      Point point56 = point1;
      label84_1.Location = point56;
      this.Label84.Name = "Label84";
      Label label84_2 = this.Label84;
      size1 = new Size(25, 13);
      Size size56 = size1;
      label84_2.Size = size56;
      this.Label84.TabIndex = 64;
      this.Label84.Text = "deg";
      this.CircEquPanel.Controls.Add((Control) this.Label104);
      this.CircEquPanel.Controls.Add((Control) this.Label103);
      this.CircEquPanel.Controls.Add((Control) this.Label85);
      this.CircEquPanel.Controls.Add((Control) this.MeanL_ECCINC);
      this.CircEquPanel.Controls.Add((Control) this.SMA_AP_ECCINC);
      this.CircEquPanel.Controls.Add((Control) this.Label93);
      this.CircEquPanel.Controls.Add((Control) this.Label86);
      this.CircEquPanel.Controls.Add((Control) this.Label91);
      this.CircEquPanel.Controls.Add((Control) this.ex_ECCINC);
      this.CircEquPanel.Controls.Add((Control) this.iy_ECCINC);
      this.CircEquPanel.Controls.Add((Control) this.Label92);
      this.CircEquPanel.Controls.Add((Control) this.ix_ECCINC);
      this.CircEquPanel.Controls.Add((Control) this.Label90);
      this.CircEquPanel.Controls.Add((Control) this.ey_ECCINC);
      Panel circEquPanel1 = this.CircEquPanel;
      point1 = new Point(6, 14);
      Point point57 = point1;
      circEquPanel1.Location = point57;
      this.CircEquPanel.Name = "CircEquPanel";
      Panel circEquPanel2 = this.CircEquPanel;
      size1 = new Size(154, 119);
      Size size57 = size1;
      circEquPanel2.Size = size57;
      this.CircEquPanel.TabIndex = 2;
      this.CircEquPanel.Visible = false;
      this.Label104.AutoSize = true;
      this.Label104.ImeMode = ImeMode.NoControl;
      Label label104_1 = this.Label104;
      point1 = new Point(5, 3);
      Point point58 = point1;
      label104_1.Location = point58;
      this.Label104.Name = "Label104";
      Label label104_2 = this.Label104;
      size1 = new Size(30, 13);
      Size size58 = size1;
      label104_2.Size = size58;
      this.Label104.TabIndex = 69;
      this.Label104.Text = "SMA";
      this.Label103.AutoSize = true;
      this.Label103.ImeMode = ImeMode.NoControl;
      Label label103_1 = this.Label103;
      point1 = new Point(124, 2);
      Point point59 = point1;
      label103_1.Location = point59;
      this.Label103.Name = "Label103";
      Label label103_2 = this.Label103;
      size1 = new Size(21, 13);
      Size size59 = size1;
      label103_2.Size = size59;
      this.Label103.TabIndex = 71;
      this.Label103.Text = "km";
      this.Label85.AutoSize = true;
      this.Label85.ImeMode = ImeMode.NoControl;
      Label label85_1 = this.Label85;
      point1 = new Point(123, 96);
      Point point60 = point1;
      label85_1.Location = point60;
      this.Label85.Name = "Label85";
      Label label85_2 = this.Label85;
      size1 = new Size(25, 13);
      Size size60 = size1;
      label85_2.Size = size60;
      this.Label85.TabIndex = 64;
      this.Label85.Text = "deg";
      this.MeanL_ECCINC.BackColor = SystemColors.Control;
      this.MeanL_ECCINC.BorderStyle = BorderStyle.None;
      TextBox meanLEccinc1 = this.MeanL_ECCINC;
      point1 = new Point(50, 98);
      Point point61 = point1;
      meanLEccinc1.Location = point61;
      this.MeanL_ECCINC.Name = "MeanL_ECCINC";
      this.MeanL_ECCINC.ReadOnly = true;
      TextBox meanLEccinc2 = this.MeanL_ECCINC;
      size1 = new Size(65, 13);
      Size size61 = size1;
      meanLEccinc2.Size = size61;
      this.MeanL_ECCINC.TabIndex = 59;
      this.MeanL_ECCINC.TextAlign = HorizontalAlignment.Right;
      this.SMA_AP_ECCINC.BackColor = SystemColors.Control;
      this.SMA_AP_ECCINC.BorderStyle = BorderStyle.None;
      TextBox smaApEccinc1 = this.SMA_AP_ECCINC;
      point1 = new Point(50, 3);
      Point point62 = point1;
      smaApEccinc1.Location = point62;
      this.SMA_AP_ECCINC.Name = "SMA_AP_ECCINC";
      this.SMA_AP_ECCINC.ReadOnly = true;
      TextBox smaApEccinc2 = this.SMA_AP_ECCINC;
      size1 = new Size(65, 13);
      Size size62 = size1;
      smaApEccinc2.Size = size62;
      this.SMA_AP_ECCINC.TabIndex = 70;
      this.SMA_AP_ECCINC.TextAlign = HorizontalAlignment.Right;
      this.Label93.AutoSize = true;
      this.Label93.ImeMode = ImeMode.NoControl;
      Label label93_1 = this.Label93;
      point1 = new Point(5, 21);
      Point point63 = point1;
      label93_1.Location = point63;
      this.Label93.Name = "Label93";
      Label label93_2 = this.Label93;
      size1 = new Size(18, 13);
      Size size63 = size1;
      label93_2.Size = size63;
      this.Label93.TabIndex = 66;
      this.Label93.Text = "ex";
      this.Label86.AutoSize = true;
      this.Label86.ImeMode = ImeMode.NoControl;
      Label label86_1 = this.Label86;
      point1 = new Point(5, 97);
      Point point64 = point1;
      label86_1.Location = point64;
      this.Label86.Name = "Label86";
      Label label86_2 = this.Label86;
      size1 = new Size(22, 13);
      Size size64 = size1;
      label86_2.Size = size64;
      this.Label86.TabIndex = 60;
      this.Label86.Text = "ML";
      this.Label91.AutoSize = true;
      this.Label91.ImeMode = ImeMode.NoControl;
      Label label91_1 = this.Label91;
      point1 = new Point(5, 59);
      Point point65 = point1;
      label91_1.Location = point65;
      this.Label91.Name = "Label91";
      Label label91_2 = this.Label91;
      size1 = new Size(14, 13);
      Size size65 = size1;
      label91_2.Size = size65;
      this.Label91.TabIndex = 56;
      this.Label91.Text = "ix";
      this.ex_ECCINC.BackColor = SystemColors.Control;
      this.ex_ECCINC.BorderStyle = BorderStyle.None;
      TextBox exEccinc1 = this.ex_ECCINC;
      point1 = new Point(50, 22);
      Point point66 = point1;
      exEccinc1.Location = point66;
      this.ex_ECCINC.Name = "ex_ECCINC";
      this.ex_ECCINC.ReadOnly = true;
      TextBox exEccinc2 = this.ex_ECCINC;
      size1 = new Size(65, 13);
      Size size66 = size1;
      exEccinc2.Size = size66;
      this.ex_ECCINC.TabIndex = 65;
      this.ex_ECCINC.TextAlign = HorizontalAlignment.Right;
      this.iy_ECCINC.BackColor = SystemColors.Control;
      this.iy_ECCINC.BorderStyle = BorderStyle.None;
      TextBox iyEccinc1 = this.iy_ECCINC;
      point1 = new Point(50, 79);
      Point point67 = point1;
      iyEccinc1.Location = point67;
      this.iy_ECCINC.Name = "iy_ECCINC";
      this.iy_ECCINC.ReadOnly = true;
      TextBox iyEccinc2 = this.iy_ECCINC;
      size1 = new Size(65, 13);
      Size size67 = size1;
      iyEccinc2.Size = size67;
      this.iy_ECCINC.TabIndex = 57;
      this.iy_ECCINC.TextAlign = HorizontalAlignment.Right;
      this.Label92.AutoSize = true;
      this.Label92.ImeMode = ImeMode.NoControl;
      Label label92_1 = this.Label92;
      point1 = new Point(5, 40);
      Point point68 = point1;
      label92_1.Location = point68;
      this.Label92.Name = "Label92";
      Label label92_2 = this.Label92;
      size1 = new Size(18, 13);
      Size size68 = size1;
      label92_2.Size = size68;
      this.Label92.TabIndex = 68;
      this.Label92.Text = "ey";
      this.ix_ECCINC.BackColor = SystemColors.Control;
      this.ix_ECCINC.BorderStyle = BorderStyle.None;
      TextBox ixEccinc1 = this.ix_ECCINC;
      point1 = new Point(50, 60);
      Point point69 = point1;
      ixEccinc1.Location = point69;
      this.ix_ECCINC.Name = "ix_ECCINC";
      this.ix_ECCINC.ReadOnly = true;
      TextBox ixEccinc2 = this.ix_ECCINC;
      size1 = new Size(65, 13);
      Size size69 = size1;
      ixEccinc2.Size = size69;
      this.ix_ECCINC.TabIndex = 55;
      this.ix_ECCINC.TextAlign = HorizontalAlignment.Right;
      this.Label90.AutoSize = true;
      this.Label90.ImeMode = ImeMode.NoControl;
      Label label90_1 = this.Label90;
      point1 = new Point(5, 78);
      Point point70 = point1;
      label90_1.Location = point70;
      this.Label90.Name = "Label90";
      Label label90_2 = this.Label90;
      size1 = new Size(14, 13);
      Size size70 = size1;
      label90_2.Size = size70;
      this.Label90.TabIndex = 58;
      this.Label90.Text = "iy";
      this.ey_ECCINC.BackColor = SystemColors.Control;
      this.ey_ECCINC.BorderStyle = BorderStyle.None;
      TextBox eyEccinc1 = this.ey_ECCINC;
      point1 = new Point(50, 41);
      Point point71 = point1;
      eyEccinc1.Location = point71;
      this.ey_ECCINC.Name = "ey_ECCINC";
      this.ey_ECCINC.ReadOnly = true;
      TextBox eyEccinc2 = this.ey_ECCINC;
      size1 = new Size(65, 13);
      Size size71 = size1;
      eyEccinc2.Size = size71;
      this.ey_ECCINC.TabIndex = 67;
      this.ey_ECCINC.TextAlign = HorizontalAlignment.Right;
      this.CircularPanel.Controls.Add((Control) this.Label82);
      this.CircularPanel.Controls.Add((Control) this.ey);
      this.CircularPanel.Controls.Add((Control) this.Label97);
      this.CircularPanel.Controls.Add((Control) this.Label107);
      this.CircularPanel.Controls.Add((Control) this.Label96);
      this.CircularPanel.Controls.Add((Control) this.Label83);
      this.CircularPanel.Controls.Add((Control) this.SMA_AP_ECC);
      this.CircularPanel.Controls.Add((Control) this.Label80);
      this.CircularPanel.Controls.Add((Control) this.Label81);
      this.CircularPanel.Controls.Add((Control) this.Label95);
      this.CircularPanel.Controls.Add((Control) this.INC_AP_ECC);
      this.CircularPanel.Controls.Add((Control) this.label110);
      this.CircularPanel.Controls.Add((Control) this.Label79);
      this.CircularPanel.Controls.Add((Control) this.ex);
      this.CircularPanel.Controls.Add((Control) this.AlphaPrime);
      this.CircularPanel.Controls.Add((Control) this.RAAN_AP_ECC);
      Panel circularPanel1 = this.CircularPanel;
      point1 = new Point(6, 14);
      Point point72 = point1;
      circularPanel1.Location = point72;
      this.CircularPanel.Name = "CircularPanel";
      Panel circularPanel2 = this.CircularPanel;
      size1 = new Size(154, 119);
      Size size72 = size1;
      circularPanel2.Size = size72;
      this.CircularPanel.TabIndex = 0;
      this.CircularPanel.Visible = false;
      this.Label82.AutoSize = true;
      this.Label82.ImeMode = ImeMode.NoControl;
      Label label82_1 = this.Label82;
      point1 = new Point(5, 3);
      Point point73 = point1;
      label82_1.Location = point73;
      this.Label82.Name = "Label82";
      Label label82_2 = this.Label82;
      size1 = new Size(30, 13);
      Size size73 = size1;
      label82_2.Size = size73;
      this.Label82.TabIndex = 64;
      this.Label82.Text = "SMA";
      this.ey.BackColor = SystemColors.Control;
      this.ey.BorderStyle = BorderStyle.None;
      TextBox ey1 = this.ey;
      point1 = new Point(50, 41);
      Point point74 = point1;
      ey1.Location = point74;
      this.ey.Name = "ey";
      this.ey.ReadOnly = true;
      TextBox ey2 = this.ey;
      size1 = new Size(65, 13);
      Size size74 = size1;
      ey2.Size = size74;
      this.ey.TabIndex = 57;
      this.ey.TextAlign = HorizontalAlignment.Right;
      this.Label97.AutoSize = true;
      this.Label97.ImeMode = ImeMode.NoControl;
      Label label97_1 = this.Label97;
      point1 = new Point(5, 59);
      Point point75 = point1;
      label97_1.Location = point75;
      this.Label97.Name = "Label97";
      Label label97_2 = this.Label97;
      size1 = new Size(25, 13);
      Size size75 = size1;
      label97_2.Size = size75;
      this.Label97.TabIndex = 67;
      this.Label97.Text = "INC";
      this.Label107.AutoSize = true;
      this.Label107.ImeMode = ImeMode.NoControl;
      Label label107_1 = this.Label107;
      point1 = new Point(123, 78);
      Point point76 = point1;
      label107_1.Location = point76;
      this.Label107.Name = "Label107";
      Label label107_2 = this.Label107;
      size1 = new Size(25, 13);
      Size size76 = size1;
      label107_2.Size = size76;
      this.Label107.TabIndex = 72;
      this.Label107.Text = "deg";
      this.Label96.AutoSize = true;
      this.Label96.ImeMode = ImeMode.NoControl;
      Label label96_1 = this.Label96;
      point1 = new Point(5, 78);
      Point point77 = point1;
      label96_1.Location = point77;
      this.Label96.Name = "Label96";
      Label label96_2 = this.Label96;
      size1 = new Size(37, 13);
      Size size77 = size1;
      label96_2.Size = size77;
      this.Label96.TabIndex = 68;
      this.Label96.Text = "RAAN";
      this.Label83.AutoSize = true;
      this.Label83.ImeMode = ImeMode.NoControl;
      Label label83_1 = this.Label83;
      point1 = new Point(123, 97);
      Point point78 = point1;
      label83_1.Location = point78;
      this.Label83.Name = "Label83";
      Label label83_2 = this.Label83;
      size1 = new Size(25, 13);
      Size size78 = size1;
      label83_2.Size = size78;
      this.Label83.TabIndex = 63;
      this.Label83.Text = "deg";
      this.SMA_AP_ECC.BackColor = SystemColors.Control;
      this.SMA_AP_ECC.BorderStyle = BorderStyle.None;
      TextBox smaApEcc1 = this.SMA_AP_ECC;
      point1 = new Point(50, 3);
      Point point79 = point1;
      smaApEcc1.Location = point79;
      this.SMA_AP_ECC.Name = "SMA_AP_ECC";
      this.SMA_AP_ECC.ReadOnly = true;
      TextBox smaApEcc2 = this.SMA_AP_ECC;
      size1 = new Size(65, 13);
      Size size79 = size1;
      smaApEcc2.Size = size79;
      this.SMA_AP_ECC.TabIndex = 65;
      this.SMA_AP_ECC.TextAlign = HorizontalAlignment.Right;
      this.Label80.AutoSize = true;
      this.Label80.ImeMode = ImeMode.NoControl;
      Label label80_1 = this.Label80;
      point1 = new Point(5, 40);
      Point point80 = point1;
      label80_1.Location = point80;
      this.Label80.Name = "Label80";
      Label label80_2 = this.Label80;
      size1 = new Size(18, 13);
      Size size80 = size1;
      label80_2.Size = size80;
      this.Label80.TabIndex = 58;
      this.Label80.Text = "ey";
      this.Label81.AutoSize = true;
      this.Label81.ImeMode = ImeMode.NoControl;
      Label label81_1 = this.Label81;
      point1 = new Point(124, 3);
      Point point81 = point1;
      label81_1.Location = point81;
      this.Label81.Name = "Label81";
      Label label81_2 = this.Label81;
      size1 = new Size(21, 13);
      Size size81 = size1;
      label81_2.Size = size81;
      this.Label81.TabIndex = 66;
      this.Label81.Text = "km";
      this.Label95.AutoSize = true;
      this.Label95.ImeMode = ImeMode.NoControl;
      Label label95_1 = this.Label95;
      point1 = new Point(123, 59);
      Point point82 = point1;
      label95_1.Location = point82;
      this.Label95.Name = "Label95";
      Label label95_2 = this.Label95;
      size1 = new Size(25, 13);
      Size size82 = size1;
      label95_2.Size = size82;
      this.Label95.TabIndex = 71;
      this.Label95.Text = "deg";
      this.INC_AP_ECC.BackColor = SystemColors.Control;
      this.INC_AP_ECC.BorderStyle = BorderStyle.None;
      TextBox incApEcc1 = this.INC_AP_ECC;
      point1 = new Point(50, 60);
      Point point83 = point1;
      incApEcc1.Location = point83;
      this.INC_AP_ECC.Name = "INC_AP_ECC";
      this.INC_AP_ECC.ReadOnly = true;
      TextBox incApEcc2 = this.INC_AP_ECC;
      size1 = new Size(65, 13);
      Size size83 = size1;
      incApEcc2.Size = size83;
      this.INC_AP_ECC.TabIndex = 69;
      this.INC_AP_ECC.TextAlign = HorizontalAlignment.Right;
      this.label110.AutoSize = true;
      this.label110.ImeMode = ImeMode.NoControl;
      Label label110_1 = this.label110;
      point1 = new Point(5, 97);
      Point point84 = point1;
      label110_1.Location = point84;
      this.label110.Name = "label110";
      Label label110_2 = this.label110;
      size1 = new Size(28, 13);
      Size size84 = size1;
      label110_2.Size = size84;
      this.label110.TabIndex = 62;
      this.label110.Text = "AOL";
      this.Label79.AutoSize = true;
      this.Label79.ImeMode = ImeMode.NoControl;
      Label label79_1 = this.Label79;
      point1 = new Point(5, 21);
      Point point85 = point1;
      label79_1.Location = point85;
      this.Label79.Name = "Label79";
      Label label79_2 = this.Label79;
      size1 = new Size(18, 13);
      Size size85 = size1;
      label79_2.Size = size85;
      this.Label79.TabIndex = 56;
      this.Label79.Text = "ex";
      this.ex.BackColor = SystemColors.Control;
      this.ex.BorderStyle = BorderStyle.None;
      TextBox ex1 = this.ex;
      point1 = new Point(50, 22);
      Point point86 = point1;
      ex1.Location = point86;
      this.ex.Name = "ex";
      this.ex.ReadOnly = true;
      TextBox ex2 = this.ex;
      size1 = new Size(65, 13);
      Size size86 = size1;
      ex2.Size = size86;
      this.ex.TabIndex = 55;
      this.ex.TextAlign = HorizontalAlignment.Right;
      this.AlphaPrime.BackColor = SystemColors.Control;
      this.AlphaPrime.BorderStyle = BorderStyle.None;
      TextBox alphaPrime1 = this.AlphaPrime;
      point1 = new Point(50, 98);
      Point point87 = point1;
      alphaPrime1.Location = point87;
      this.AlphaPrime.Name = "AlphaPrime";
      this.AlphaPrime.ReadOnly = true;
      TextBox alphaPrime2 = this.AlphaPrime;
      size1 = new Size(65, 13);
      Size size87 = size1;
      alphaPrime2.Size = size87;
      this.AlphaPrime.TabIndex = 61;
      this.AlphaPrime.TextAlign = HorizontalAlignment.Right;
      this.RAAN_AP_ECC.BackColor = SystemColors.Control;
      this.RAAN_AP_ECC.BorderStyle = BorderStyle.None;
      TextBox raanApEcc1 = this.RAAN_AP_ECC;
      point1 = new Point(50, 79);
      Point point88 = point1;
      raanApEcc1.Location = point88;
      this.RAAN_AP_ECC.Name = "RAAN_AP_ECC";
      this.RAAN_AP_ECC.ReadOnly = true;
      TextBox raanApEcc2 = this.RAAN_AP_ECC;
      size1 = new Size(65, 13);
      Size size88 = size1;
      raanApEcc2.Size = size88;
      this.RAAN_AP_ECC.TabIndex = 70;
      this.RAAN_AP_ECC.TextAlign = HorizontalAlignment.Right;
      this.Label124.AutoSize = true;
      this.Label124.ForeColor = Color.Red;
      this.Label124.ImeMode = ImeMode.NoControl;
      Label label124_1 = this.Label124;
      point1 = new Point(34, 31);
      Point point89 = point1;
      label124_1.Location = point89;
      this.Label124.Name = "Label124";
      Label label124_2 = this.Label124;
      size1 = new Size(114, 52);
      Size size89 = size1;
      label124_2.Size = size89;
      this.Label124.TabIndex = 38;
      this.Label124.Text = "Only for:\r\n- Circular Orbit\r\n- Equatorial Orbit\r\n- Geostationnary Orbits";
      this.CartesianElementsFrame.Controls.Add((Control) this.XBox);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label34);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label35);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label36);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label33);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label32);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label38);
      this.CartesianElementsFrame.Controls.Add((Control) this.VZBox);
      this.CartesianElementsFrame.Controls.Add((Control) this.VYBox);
      this.CartesianElementsFrame.Controls.Add((Control) this.VXBox);
      this.CartesianElementsFrame.Controls.Add((Control) this.ZBox);
      this.CartesianElementsFrame.Controls.Add((Control) this.YBox);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label42);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label43);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label44);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label45);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label46);
      this.CartesianElementsFrame.Controls.Add((Control) this.Label47);
      GroupBox cartesianElementsFrame1 = this.CartesianElementsFrame;
      point1 = new Point(167, 6);
      Point point90 = point1;
      cartesianElementsFrame1.Location = point90;
      this.CartesianElementsFrame.Name = "CartesianElementsFrame";
      GroupBox cartesianElementsFrame2 = this.CartesianElementsFrame;
      size1 = new Size(178, 135);
      Size size90 = size1;
      cartesianElementsFrame2.Size = size90;
      this.CartesianElementsFrame.TabIndex = 75;
      this.CartesianElementsFrame.TabStop = false;
      this.CartesianElementsFrame.Text = "Cartesian State (TEME)";
      this.XBox.BackColor = SystemColors.Control;
      this.XBox.BorderStyle = BorderStyle.None;
      TextBox xbox1 = this.XBox;
      point1 = new Point(56, 19);
      Point point91 = point1;
      xbox1.Location = point91;
      this.XBox.Name = "XBox";
      this.XBox.ReadOnly = true;
      TextBox xbox2 = this.XBox;
      size1 = new Size(65, 13);
      Size size91 = size1;
      xbox2.Size = size91;
      this.XBox.TabIndex = 26;
      this.XBox.TextAlign = HorizontalAlignment.Right;
      this.Label34.AutoSize = true;
      this.Label34.ImeMode = ImeMode.NoControl;
      Label label34_1 = this.Label34;
      point1 = new Point((int) sbyte.MaxValue, 115);
      Point point92 = point1;
      label34_1.Location = point92;
      this.Label34.Name = "Label34";
      Label label34_2 = this.Label34;
      size1 = new Size(31, 13);
      Size size92 = size1;
      label34_2.Size = size92;
      this.Label34.TabIndex = 35;
      this.Label34.Text = "km/s";
      this.Label35.AutoSize = true;
      this.Label35.ImeMode = ImeMode.NoControl;
      Label label35_1 = this.Label35;
      point1 = new Point((int) sbyte.MaxValue, 76);
      Point point93 = point1;
      label35_1.Location = point93;
      this.Label35.Name = "Label35";
      Label label35_2 = this.Label35;
      size1 = new Size(31, 13);
      Size size93 = size1;
      label35_2.Size = size93;
      this.Label35.TabIndex = 34;
      this.Label35.Text = "km/s";
      this.Label36.AutoSize = true;
      this.Label36.ImeMode = ImeMode.NoControl;
      Label label36_1 = this.Label36;
      point1 = new Point((int) sbyte.MaxValue, 97);
      Point point94 = point1;
      label36_1.Location = point94;
      this.Label36.Name = "Label36";
      Label label36_2 = this.Label36;
      size1 = new Size(31, 13);
      Size size94 = size1;
      label36_2.Size = size94;
      this.Label36.TabIndex = 33;
      this.Label36.Text = "km/s";
      this.Label33.AutoSize = true;
      this.Label33.ImeMode = ImeMode.NoControl;
      Label label33_1 = this.Label33;
      point1 = new Point((int) sbyte.MaxValue, 57);
      Point point95 = point1;
      label33_1.Location = point95;
      this.Label33.Name = "Label33";
      Label label33_2 = this.Label33;
      size1 = new Size(21, 13);
      Size size95 = size1;
      label33_2.Size = size95;
      this.Label33.TabIndex = 32;
      this.Label33.Text = "km";
      this.Label32.AutoSize = true;
      this.Label32.ImeMode = ImeMode.NoControl;
      Label label32_1 = this.Label32;
      point1 = new Point((int) sbyte.MaxValue, 19);
      Point point96 = point1;
      label32_1.Location = point96;
      this.Label32.Name = "Label32";
      Label label32_2 = this.Label32;
      size1 = new Size(21, 13);
      Size size96 = size1;
      label32_2.Size = size96;
      this.Label32.TabIndex = 31;
      this.Label32.Text = "km";
      this.Label38.AutoSize = true;
      this.Label38.ImeMode = ImeMode.NoControl;
      Label label38_1 = this.Label38;
      point1 = new Point((int) sbyte.MaxValue, 39);
      Point point97 = point1;
      label38_1.Location = point97;
      this.Label38.Name = "Label38";
      Label label38_2 = this.Label38;
      size1 = new Size(21, 13);
      Size size97 = size1;
      label38_2.Size = size97;
      this.Label38.TabIndex = 19;
      this.Label38.Text = "km";
      this.VZBox.BackColor = SystemColors.Control;
      this.VZBox.BorderStyle = BorderStyle.None;
      TextBox vzBox1 = this.VZBox;
      point1 = new Point(56, 114);
      Point point98 = point1;
      vzBox1.Location = point98;
      this.VZBox.Name = "VZBox";
      this.VZBox.ReadOnly = true;
      TextBox vzBox2 = this.VZBox;
      size1 = new Size(65, 13);
      Size size98 = size1;
      vzBox2.Size = size98;
      this.VZBox.TabIndex = 15;
      this.VZBox.TextAlign = HorizontalAlignment.Right;
      this.VYBox.BackColor = SystemColors.Control;
      this.VYBox.BorderStyle = BorderStyle.None;
      TextBox vyBox1 = this.VYBox;
      point1 = new Point(56, 95);
      Point point99 = point1;
      vyBox1.Location = point99;
      this.VYBox.Name = "VYBox";
      this.VYBox.ReadOnly = true;
      TextBox vyBox2 = this.VYBox;
      size1 = new Size(65, 13);
      Size size99 = size1;
      vyBox2.Size = size99;
      this.VYBox.TabIndex = 14;
      this.VYBox.TextAlign = HorizontalAlignment.Right;
      this.VXBox.BackColor = SystemColors.Control;
      this.VXBox.BorderStyle = BorderStyle.None;
      TextBox vxBox1 = this.VXBox;
      point1 = new Point(56, 76);
      Point point100 = point1;
      vxBox1.Location = point100;
      this.VXBox.Name = "VXBox";
      this.VXBox.ReadOnly = true;
      TextBox vxBox2 = this.VXBox;
      size1 = new Size(65, 13);
      Size size100 = size1;
      vxBox2.Size = size100;
      this.VXBox.TabIndex = 13;
      this.VXBox.TextAlign = HorizontalAlignment.Right;
      this.ZBox.BackColor = SystemColors.Control;
      this.ZBox.BorderStyle = BorderStyle.None;
      TextBox zbox1 = this.ZBox;
      point1 = new Point(56, 57);
      Point point101 = point1;
      zbox1.Location = point101;
      this.ZBox.Name = "ZBox";
      this.ZBox.ReadOnly = true;
      TextBox zbox2 = this.ZBox;
      size1 = new Size(65, 13);
      Size size101 = size1;
      zbox2.Size = size101;
      this.ZBox.TabIndex = 12;
      this.ZBox.TextAlign = HorizontalAlignment.Right;
      this.YBox.BackColor = SystemColors.Control;
      this.YBox.BorderStyle = BorderStyle.None;
      TextBox ybox1 = this.YBox;
      point1 = new Point(56, 38);
      Point point102 = point1;
      ybox1.Location = point102;
      this.YBox.Name = "YBox";
      this.YBox.ReadOnly = true;
      TextBox ybox2 = this.YBox;
      size1 = new Size(65, 13);
      Size size102 = size1;
      ybox2.Size = size102;
      this.YBox.TabIndex = 11;
      this.YBox.TextAlign = HorizontalAlignment.Right;
      this.Label42.AutoSize = true;
      this.Label42.ImeMode = ImeMode.NoControl;
      Label label42_1 = this.Label42;
      point1 = new Point(11, 114);
      Point point103 = point1;
      label42_1.Location = point103;
      this.Label42.Name = "Label42";
      Label label42_2 = this.Label42;
      size1 = new Size(21, 13);
      Size size103 = size1;
      label42_2.Size = size103;
      this.Label42.TabIndex = 7;
      this.Label42.Text = "VZ";
      this.Label43.AutoSize = true;
      this.Label43.ImeMode = ImeMode.NoControl;
      Label label43_1 = this.Label43;
      point1 = new Point(11, 97);
      Point point104 = point1;
      label43_1.Location = point104;
      this.Label43.Name = "Label43";
      Label label43_2 = this.Label43;
      size1 = new Size(21, 13);
      Size size104 = size1;
      label43_2.Size = size104;
      this.Label43.TabIndex = 6;
      this.Label43.Text = "VY";
      this.Label44.AutoSize = true;
      this.Label44.ImeMode = ImeMode.NoControl;
      Label label44_1 = this.Label44;
      point1 = new Point(11, 76);
      Point point105 = point1;
      label44_1.Location = point105;
      this.Label44.Name = "Label44";
      Label label44_2 = this.Label44;
      size1 = new Size(21, 13);
      Size size105 = size1;
      label44_2.Size = size105;
      this.Label44.TabIndex = 5;
      this.Label44.Text = "VX";
      this.Label45.AutoSize = true;
      this.Label45.ImeMode = ImeMode.NoControl;
      Label label45_1 = this.Label45;
      point1 = new Point(11, 57);
      Point point106 = point1;
      label45_1.Location = point106;
      this.Label45.Name = "Label45";
      Label label45_2 = this.Label45;
      size1 = new Size(14, 13);
      Size size106 = size1;
      label45_2.Size = size106;
      this.Label45.TabIndex = 4;
      this.Label45.Text = "Z";
      this.Label46.AutoSize = true;
      this.Label46.ImeMode = ImeMode.NoControl;
      Label label46_1 = this.Label46;
      point1 = new Point(11, 19);
      Point point107 = point1;
      label46_1.Location = point107;
      this.Label46.Name = "Label46";
      Label label46_2 = this.Label46;
      size1 = new Size(14, 13);
      Size size107 = size1;
      label46_2.Size = size107;
      this.Label46.TabIndex = 1;
      this.Label46.Text = "X";
      this.Label47.AutoSize = true;
      this.Label47.ImeMode = ImeMode.NoControl;
      Label label47_1 = this.Label47;
      point1 = new Point(11, 38);
      Point point108 = point1;
      label47_1.Location = point108;
      this.Label47.Name = "Label47";
      Label label47_2 = this.Label47;
      size1 = new Size(14, 13);
      Size size108 = size1;
      label47_2.Size = size108;
      this.Label47.TabIndex = 3;
      this.Label47.Text = "Y";
      this.GroupBox2.Controls.Add((Control) this.TLEDate);
      this.GroupBox2.Controls.Add((Control) this.EPOCH_TLE);
      this.GroupBox2.Controls.Add((Control) this.NowDate);
      this.GroupBox2.Controls.Add((Control) this.EPOCH_Format);
      this.GroupBox2.Controls.Add((Control) this.Label19);
      this.GroupBox2.Controls.Add((Control) this.EPOCH_Current);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(9, 124);
      Point point109 = point1;
      groupBox2_1.Location = point109;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(244, 100);
      Size size109 = size1;
      groupBox2_2.Size = size109;
      this.GroupBox2.TabIndex = 54;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Epoch (UTC)";
      this.TLEDate.AutoSize = true;
      this.TLEDate.Enabled = false;
      this.TLEDate.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.TLEDate.ImeMode = ImeMode.NoControl;
      this.TLEDate.LinkBehavior = LinkBehavior.NeverUnderline;
      this.TLEDate.LinkColor = Color.Blue;
      LinkLabel tleDate1 = this.TLEDate;
      point1 = new Point(6, 74);
      Point point110 = point1;
      tleDate1.Location = point110;
      this.TLEDate.Name = "TLEDate";
      LinkLabel tleDate2 = this.TLEDate;
      size1 = new Size(61, 13);
      Size size110 = size1;
      tleDate2.Size = size110;
      this.TLEDate.TabIndex = 87;
      this.TLEDate.TabStop = true;
      this.TLEDate.Text = "TLE Epoch";
      this.EPOCH_TLE.BorderStyle = BorderStyle.None;
      TextBox epochTle1 = this.EPOCH_TLE;
      point1 = new Point(98, 74);
      Point point111 = point1;
      epochTle1.Location = point111;
      this.EPOCH_TLE.Name = "EPOCH_TLE";
      this.EPOCH_TLE.ReadOnly = true;
      TextBox epochTle2 = this.EPOCH_TLE;
      size1 = new Size(136, 13);
      Size size111 = size1;
      epochTle2.Size = size111;
      this.EPOCH_TLE.TabIndex = 86;
      this.NowDate.AutoSize = true;
      this.NowDate.Enabled = false;
      this.NowDate.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.NowDate.ImeMode = ImeMode.NoControl;
      this.NowDate.LinkBehavior = LinkBehavior.NeverUnderline;
      this.NowDate.LinkColor = Color.Blue;
      LinkLabel nowDate1 = this.NowDate;
      point1 = new Point(6, 49);
      Point point112 = point1;
      nowDate1.Location = point112;
      this.NowDate.Name = "NowDate";
      LinkLabel nowDate2 = this.NowDate;
      size1 = new Size(75, 13);
      Size size112 = size1;
      nowDate2.Size = size112;
      this.NowDate.TabIndex = 76;
      this.NowDate.TabStop = true;
      this.NowDate.Text = "Current Epoch";
      this.EPOCH_Format.BackColor = SystemColors.Window;
      this.EPOCH_Format.DropDownStyle = ComboBoxStyle.DropDownList;
      this.EPOCH_Format.Enabled = false;
      this.EPOCH_Format.FormattingEnabled = true;
      this.EPOCH_Format.Items.AddRange(new object[3]
      {
        (object) "ModJulian",
        (object) "Gregorian",
        (object) "TLEFormat"
      });
      ComboBox epochFormat1 = this.EPOCH_Format;
      point1 = new Point(93, 20);
      Point point113 = point1;
      epochFormat1.Location = point113;
      this.EPOCH_Format.Name = "EPOCH_Format";
      ComboBox epochFormat2 = this.EPOCH_Format;
      size1 = new Size(141, 21);
      Size size113 = size1;
      epochFormat2.Size = size113;
      this.EPOCH_Format.TabIndex = 32;
      this.Label19.AutoSize = true;
      this.Label19.ImeMode = ImeMode.NoControl;
      Label label19_1 = this.Label19;
      point1 = new Point(6, 23);
      Point point114 = point1;
      label19_1.Location = point114;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(39, 13);
      Size size114 = size1;
      label19_2.Size = size114;
      this.Label19.TabIndex = 30;
      this.Label19.Text = "Format";
      this.EPOCH_Current.Enabled = false;
      this.EPOCH_Current.ForeColor = SystemColors.WindowText;
      TextBox epochCurrent1 = this.EPOCH_Current;
      point1 = new Point(93, 45);
      Point point115 = point1;
      epochCurrent1.Location = point115;
      this.EPOCH_Current.Name = "EPOCH_Current";
      TextBox epochCurrent2 = this.EPOCH_Current;
      size1 = new Size(141, 20);
      Size size115 = size1;
      epochCurrent2.Size = size115;
      this.EPOCH_Current.TabIndex = 27;
      this.EPOCH_Current.TabStop = false;
      this.Label155.AutoSize = true;
      this.Label155.ImeMode = ImeMode.NoControl;
      Label label155_1 = this.Label155;
      point1 = new Point(105, 47);
      Point point116 = point1;
      label155_1.Location = point116;
      this.Label155.Name = "Label155";
      Label label155_2 = this.Label155;
      size1 = new Size(25, 13);
      Size size116 = size1;
      label155_2.Size = size116;
      this.Label155.TabIndex = 79;
      this.Label155.Text = "deg";
      this.LSTBox.BorderStyle = BorderStyle.None;
      TextBox lstBox1 = this.LSTBox;
      point1 = new Point(41, 48);
      Point point117 = point1;
      lstBox1.Location = point117;
      this.LSTBox.Name = "LSTBox";
      this.LSTBox.ReadOnly = true;
      TextBox lstBox2 = this.LSTBox;
      size1 = new Size(58, 13);
      Size size117 = size1;
      lstBox2.Size = size117;
      this.LSTBox.TabIndex = 78;
      this.LSTBox.TextAlign = HorizontalAlignment.Right;
      this.Label156.AutoSize = true;
      this.Label156.ImeMode = ImeMode.NoControl;
      Label label156_1 = this.Label156;
      point1 = new Point(6, 47);
      Point point118 = point1;
      label156_1.Location = point118;
      this.Label156.Name = "Label156";
      Label label156_2 = this.Label156;
      size1 = new Size(27, 13);
      Size size118 = size1;
      label156_2.Size = size118;
      this.Label156.TabIndex = 77;
      this.Label156.Text = "LST";
      this.Label133.AutoSize = true;
      this.Label133.ImeMode = ImeMode.NoControl;
      Label label133_1 = this.Label133;
      point1 = new Point(105, 26);
      Point point119 = point1;
      label133_1.Location = point119;
      this.Label133.Name = "Label133";
      Label label133_2 = this.Label133;
      size1 = new Size(25, 13);
      Size size119 = size1;
      label133_2.Size = size119;
      this.Label133.TabIndex = 64;
      this.Label133.Text = "deg";
      this.GSTBox.BorderStyle = BorderStyle.None;
      TextBox gstBox1 = this.GSTBox;
      point1 = new Point(41, 27);
      Point point120 = point1;
      gstBox1.Location = point120;
      this.GSTBox.Name = "GSTBox";
      this.GSTBox.ReadOnly = true;
      TextBox gstBox2 = this.GSTBox;
      size1 = new Size(58, 13);
      Size size120 = size1;
      gstBox2.Size = size120;
      this.GSTBox.TabIndex = 63;
      this.GSTBox.TextAlign = HorizontalAlignment.Right;
      this.Label134.AutoSize = true;
      this.Label134.ImeMode = ImeMode.NoControl;
      Label label134_1 = this.Label134;
      point1 = new Point(6, 26);
      Point point121 = point1;
      label134_1.Location = point121;
      this.Label134.Name = "Label134";
      Label label134_2 = this.Label134;
      size1 = new Size(29, 13);
      Size size121 = size1;
      label134_2.Size = size121;
      this.Label134.TabIndex = 62;
      this.Label134.Text = "GST";
      this.MAP_MainTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.MAP_MainTab.Controls.Add((Control) this.MAP_2DMapTab);
      this.MAP_MainTab.Controls.Add((Control) this.MAP_3DMapTab);
      TabControl mapMainTab1 = this.MAP_MainTab;
      size1 = new Size(96, 15);
      Size size122 = size1;
      mapMainTab1.ItemSize = size122;
      TabControl mapMainTab2 = this.MAP_MainTab;
      point1 = new Point(10, 230);
      Point point122 = point1;
      mapMainTab2.Location = point122;
      TabControl mapMainTab3 = this.MAP_MainTab;
      Padding padding1 = new Padding(0);
      Padding padding2 = padding1;
      mapMainTab3.Margin = padding2;
      this.MAP_MainTab.Name = "MAP_MainTab";
      this.MAP_MainTab.SelectedIndex = 0;
      TabControl mapMainTab4 = this.MAP_MainTab;
      size1 = new Size(927, 517);
      Size size123 = size1;
      mapMainTab4.Size = size123;
      this.MAP_MainTab.SizeMode = TabSizeMode.Fixed;
      this.MAP_MainTab.TabIndex = 74;
      this.MAP_2DMapTab.BackColor = SystemColors.Control;
      this.MAP_2DMapTab.Controls.Add((Control) this.TableLayoutPanel1);
      this.MAP_2DMapTab.Controls.Add((Control) this.MapPanel);
      TabPage map2DmapTab1 = this.MAP_2DMapTab;
      point1 = new Point(4, 19);
      Point point123 = point1;
      map2DmapTab1.Location = point123;
      TabPage map2DmapTab2 = this.MAP_2DMapTab;
      padding1 = new Padding(0);
      Padding padding3 = padding1;
      map2DmapTab2.Margin = padding3;
      this.MAP_2DMapTab.Name = "MAP_2DMapTab";
      TabPage map2DmapTab3 = this.MAP_2DMapTab;
      size1 = new Size(919, 494);
      Size size124 = size1;
      map2DmapTab3.Size = size124;
      this.MAP_2DMapTab.TabIndex = 0;
      this.MAP_2DMapTab.Text = "2D Graphics";
      this.TableLayoutPanel1.ColumnCount = 6;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 22f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 592f));
      this.TableLayoutPanel1.Controls.Add((Control) this.MousePict, 4, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.MapSatPict, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.LNGLATSUNBOX, 3, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.MapSunPict, 2, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.LNGLATBOX, 1, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.LNGLATMouseBOX, 5, 0);
      this.TableLayoutPanel1.Dock = DockStyle.Bottom;
      this.TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      point1 = new Point(0, 470);
      Point point124 = point1;
      tableLayoutPanel1_1.Location = point124;
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      padding1 = new Padding(0);
      Padding padding4 = padding1;
      tableLayoutPanel1_2.Margin = padding4;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 1;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 139f));
      TableLayoutPanel tableLayoutPanel1_3 = this.TableLayoutPanel1;
      size1 = new Size(919, 24);
      Size size125 = size1;
      tableLayoutPanel1_3.Size = size125;
      this.TableLayoutPanel1.TabIndex = 100;
      this.MousePict.BackColor = Color.Transparent;
      this.MousePict.BackgroundImage = (Image) componentResourceManager.GetObject("MousePict.BackgroundImage");
      this.MousePict.BackgroundImageLayout = ImageLayout.Stretch;
      this.MousePict.Cursor = Cursors.Default;
      this.MousePict.ImeMode = ImeMode.NoControl;
      this.MousePict.InitialImage = (Image) null;
      PictureBox mousePict1 = this.MousePict;
      point1 = new Point(308, 3);
      Point point125 = point1;
      mousePict1.Location = point125;
      this.MousePict.Name = "MousePict";
      PictureBox mousePict2 = this.MousePict;
      size1 = new Size(16, 16);
      Size size126 = size1;
      mousePict2.Size = size126;
      this.MousePict.TabIndex = 101;
      this.MousePict.TabStop = false;
      this.MapSatPict.BackColor = Color.Transparent;
      this.MapSatPict.BackgroundImage = (Image) componentResourceManager.GetObject("MapSatPict.BackgroundImage");
      this.MapSatPict.Cursor = Cursors.Default;
      this.MapSatPict.ImeMode = ImeMode.NoControl;
      this.MapSatPict.InitialImage = (Image) null;
      PictureBox mapSatPict1 = this.MapSatPict;
      point1 = new Point(3, 3);
      Point point126 = point1;
      mapSatPict1.Location = point126;
      this.MapSatPict.Name = "MapSatPict";
      PictureBox mapSatPict2 = this.MapSatPict;
      size1 = new Size(16, 16);
      Size size127 = size1;
      mapSatPict2.Size = size127;
      this.MapSatPict.TabIndex = 98;
      this.MapSatPict.TabStop = false;
      this.LNGLATSUNBOX.BackColor = SystemColors.Control;
      this.LNGLATSUNBOX.BorderStyle = BorderStyle.None;
      this.LNGLATSUNBOX.Font = new Font("Microsoft Sans Serif", 6.75f);
      TextBox lnglatsunbox1 = this.LNGLATSUNBOX;
      point1 = new Point(160, 3);
      Point point127 = point1;
      lnglatsunbox1.Location = point127;
      this.LNGLATSUNBOX.Name = "LNGLATSUNBOX";
      this.LNGLATSUNBOX.ReadOnly = true;
      TextBox lnglatsunbox2 = this.LNGLATSUNBOX;
      size1 = new Size(142, 11);
      Size size128 = size1;
      lnglatsunbox2.Size = size128;
      this.LNGLATSUNBOX.TabIndex = 79;
      this.MapSunPict.BackColor = Color.Transparent;
      this.MapSunPict.BackgroundImageLayout = ImageLayout.Stretch;
      this.MapSunPict.Cursor = Cursors.Default;
      this.MapSunPict.Image = (Image) componentResourceManager.GetObject("MapSunPict.Image");
      this.MapSunPict.ImeMode = ImeMode.NoControl;
      this.MapSunPict.InitialImage = (Image) null;
      PictureBox mapSunPict1 = this.MapSunPict;
      point1 = new Point(138, 3);
      Point point128 = point1;
      mapSunPict1.Location = point128;
      this.MapSunPict.Name = "MapSunPict";
      PictureBox mapSunPict2 = this.MapSunPict;
      size1 = new Size(16, 16);
      Size size129 = size1;
      mapSunPict2.Size = size129;
      this.MapSunPict.TabIndex = 99;
      this.MapSunPict.TabStop = false;
      this.LNGLATBOX.BackColor = SystemColors.Control;
      this.LNGLATBOX.BorderStyle = BorderStyle.None;
      this.LNGLATBOX.Font = new Font("Microsoft Sans Serif", 6.75f);
      TextBox lnglatbox1 = this.LNGLATBOX;
      point1 = new Point(25, 3);
      Point point129 = point1;
      lnglatbox1.Location = point129;
      this.LNGLATBOX.Name = "LNGLATBOX";
      this.LNGLATBOX.ReadOnly = true;
      TextBox lnglatbox2 = this.LNGLATBOX;
      size1 = new Size(107, 11);
      Size size130 = size1;
      lnglatbox2.Size = size130;
      this.LNGLATBOX.TabIndex = 75;
      this.LNGLATMouseBOX.BackColor = SystemColors.Control;
      this.LNGLATMouseBOX.BorderStyle = BorderStyle.None;
      this.LNGLATMouseBOX.Font = new Font("Microsoft Sans Serif", 6.75f);
      TextBox lnglatMouseBox1 = this.LNGLATMouseBOX;
      point1 = new Point(330, 3);
      Point point130 = point1;
      lnglatMouseBox1.Location = point130;
      this.LNGLATMouseBOX.Name = "LNGLATMouseBOX";
      this.LNGLATMouseBOX.ReadOnly = true;
      TextBox lnglatMouseBox2 = this.LNGLATMouseBOX;
      size1 = new Size(107, 11);
      Size size131 = size1;
      lnglatMouseBox2.Size = size131;
      this.LNGLATMouseBOX.TabIndex = 100;
      this.MapPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.MapPanel.BackgroundImage = (Image) componentResourceManager.GetObject("MapPanel.BackgroundImage");
      this.MapPanel.BackgroundImageLayout = ImageLayout.Stretch;
      this.MapPanel.BorderStyle = BorderStyle.FixedSingle;
      this.MapPanel.Controls.Add((Control) this.SatPicture);
      this.MapPanel.Controls.Add((Control) this.TracePicture);
      Panel mapPanel1 = this.MapPanel;
      point1 = new Point(0, 0);
      Point point131 = point1;
      mapPanel1.Location = point131;
      Panel mapPanel2 = this.MapPanel;
      padding1 = new Padding(0);
      Padding padding5 = padding1;
      mapPanel2.Margin = padding5;
      this.MapPanel.Name = "MapPanel";
      Panel mapPanel3 = this.MapPanel;
      size1 = new Size(916, 458);
      Size size132 = size1;
      mapPanel3.Size = size132;
      this.MapPanel.TabIndex = 71;
      this.SatPicture.BackColor = Color.Transparent;
      this.SatPicture.Cursor = Cursors.Hand;
      this.SatPicture.ImeMode = ImeMode.NoControl;
      this.SatPicture.InitialImage = (Image) null;
      PictureBox satPicture1 = this.SatPicture;
      point1 = new Point(3, 28);
      Point point132 = point1;
      satPicture1.Location = point132;
      this.SatPicture.Name = "SatPicture";
      PictureBox satPicture2 = this.SatPicture;
      size1 = new Size(13, 11);
      Size size133 = size1;
      satPicture2.Size = size133;
      this.SatPicture.TabIndex = 46;
      this.SatPicture.TabStop = false;
      this.SatPicture.Visible = false;
      this.TracePicture.BackColor = Color.Transparent;
      this.TracePicture.Dock = DockStyle.Fill;
      this.TracePicture.ImeMode = ImeMode.NoControl;
      PictureBox tracePicture1 = this.TracePicture;
      point1 = new Point(0, 0);
      Point point133 = point1;
      tracePicture1.Location = point133;
      PictureBox tracePicture2 = this.TracePicture;
      padding1 = new Padding(0);
      Padding padding6 = padding1;
      tracePicture2.Margin = padding6;
      this.TracePicture.Name = "TracePicture";
      PictureBox tracePicture3 = this.TracePicture;
      size1 = new Size(914, 456);
      Size size134 = size1;
      tracePicture3.Size = size134;
      this.TracePicture.TabIndex = 69;
      this.TracePicture.TabStop = false;
      this.MAP_3DMapTab.BackColor = SystemColors.Control;
      this.MAP_3DMapTab.Controls.Add((Control) this.orbit3dWeb);
      TabPage map3DmapTab1 = this.MAP_3DMapTab;
      point1 = new Point(4, 19);
      Point point134 = point1;
      map3DmapTab1.Location = point134;
      this.MAP_3DMapTab.Name = "MAP_3DMapTab";
      TabPage map3DmapTab2 = this.MAP_3DMapTab;
      padding1 = new Padding(3);
      Padding padding7 = padding1;
      map3DmapTab2.Padding = padding7;
      TabPage map3DmapTab3 = this.MAP_3DMapTab;
      size1 = new Size(919, 494);
      Size size135 = size1;
      map3DmapTab3.Size = size135;
      this.MAP_3DMapTab.TabIndex = 4;
      this.MAP_3DMapTab.Text = "3D Graphics";
      this.orbit3dWeb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      PictureBox orbit3dWeb1 = this.orbit3dWeb;
      point1 = new Point(0, 0);
      Point point135 = point1;
      orbit3dWeb1.Location = point135;
      this.orbit3dWeb.Name = "orbit3dWeb";
      PictureBox orbit3dWeb2 = this.orbit3dWeb;
      size1 = new Size(877, 478);
      Size size136 = size1;
      orbit3dWeb2.Size = size136;
      this.orbit3dWeb.TabIndex = 0;
      this.orbit3dWeb.TabStop = false;
      this.TrackingOptions.Controls.Add((Control) this.SIM_Actu_Track);
      this.TrackingOptions.Controls.Add((Control) this.SIM_Backward_SbS);
      this.TrackingOptions.Controls.Add((Control) this.SIM_Backward);
      this.TrackingOptions.Controls.Add((Control) this.SIM_Forward);
      this.TrackingOptions.Controls.Add((Control) this.SIM_Step);
      this.TrackingOptions.Controls.Add((Control) this.SIM_Pause);
      this.TrackingOptions.Controls.Add((Control) this.SIM_Foreward_SbS);
      this.TrackingOptions.Controls.Add((Control) this.SIM_Unit);
      this.TrackingOptions.Enabled = false;
      GroupBox trackingOptions1 = this.TrackingOptions;
      point1 = new Point(259, 125);
      Point point136 = point1;
      trackingOptions1.Location = point136;
      this.TrackingOptions.Name = "TrackingOptions";
      GroupBox trackingOptions2 = this.TrackingOptions;
      size1 = new Size(169, 81);
      Size size137 = size1;
      trackingOptions2.Size = size137;
      this.TrackingOptions.TabIndex = 71;
      this.TrackingOptions.TabStop = false;
      this.TrackingOptions.Text = "Simulation";
      this.SIM_Actu_Track.BackColor = Color.Transparent;
      this.SIM_Actu_Track.Image = (Image) componentResourceManager.GetObject("SIM_Actu_Track.Image");
      this.SIM_Actu_Track.ImeMode = ImeMode.NoControl;
      Button simActuTrack1 = this.SIM_Actu_Track;
      point1 = new Point(135, 19);
      Point point137 = point1;
      simActuTrack1.Location = point137;
      this.SIM_Actu_Track.Name = "SIM_Actu_Track";
      Button simActuTrack2 = this.SIM_Actu_Track;
      size1 = new Size(24, 24);
      Size size138 = size1;
      simActuTrack2.Size = size138;
      this.SIM_Actu_Track.TabIndex = 78;
      this.SIM_Actu_Track.UseVisualStyleBackColor = false;
      this.SIM_Backward_SbS.BackColor = Color.Transparent;
      this.SIM_Backward_SbS.Image = (Image) componentResourceManager.GetObject("SIM_Backward_SbS.Image");
      this.SIM_Backward_SbS.ImeMode = ImeMode.NoControl;
      Button simBackwardSbS1 = this.SIM_Backward_SbS;
      point1 = new Point(41, 51);
      Point point138 = point1;
      simBackwardSbS1.Location = point138;
      this.SIM_Backward_SbS.Name = "SIM_Backward_SbS";
      Button simBackwardSbS2 = this.SIM_Backward_SbS;
      size1 = new Size(24, 24);
      Size size139 = size1;
      simBackwardSbS2.Size = size139;
      this.SIM_Backward_SbS.TabIndex = 77;
      this.SIM_Backward_SbS.UseVisualStyleBackColor = false;
      this.SIM_Backward.BackColor = Color.Transparent;
      this.SIM_Backward.Image = (Image) componentResourceManager.GetObject("SIM_Backward.Image");
      this.SIM_Backward.ImeMode = ImeMode.NoControl;
      Button simBackward1 = this.SIM_Backward;
      point1 = new Point(9, 51);
      Point point139 = point1;
      simBackward1.Location = point139;
      this.SIM_Backward.Name = "SIM_Backward";
      Button simBackward2 = this.SIM_Backward;
      size1 = new Size(24, 24);
      Size size140 = size1;
      simBackward2.Size = size140;
      this.SIM_Backward.TabIndex = 73;
      this.SIM_Backward.UseVisualStyleBackColor = false;
      this.SIM_Forward.BackColor = Color.Transparent;
      this.SIM_Forward.Image = (Image) componentResourceManager.GetObject("SIM_Forward.Image");
      this.SIM_Forward.ImeMode = ImeMode.NoControl;
      Button simForward1 = this.SIM_Forward;
      point1 = new Point(134, 51);
      Point point140 = point1;
      simForward1.Location = point140;
      this.SIM_Forward.Name = "SIM_Forward";
      Button simForward2 = this.SIM_Forward;
      size1 = new Size(24, 24);
      Size size141 = size1;
      simForward2.Size = size141;
      this.SIM_Forward.TabIndex = 72;
      this.SIM_Forward.UseVisualStyleBackColor = false;
      this.SIM_Step.BackColor = SystemColors.Window;
      this.SIM_Step.DropDownStyle = ComboBoxStyle.DropDownList;
      this.SIM_Step.FormattingEnabled = true;
      this.SIM_Step.Items.AddRange(new object[8]
      {
        (object) "0.25",
        (object) "0.50",
        (object) "1",
        (object) "5",
        (object) "10",
        (object) "20",
        (object) "30",
        (object) "60"
      });
      ComboBox simStep1 = this.SIM_Step;
      point1 = new Point(12, 19);
      Point point141 = point1;
      simStep1.Location = point141;
      this.SIM_Step.Name = "SIM_Step";
      ComboBox simStep2 = this.SIM_Step;
      size1 = new Size(55, 21);
      Size size142 = size1;
      simStep2.Size = size142;
      this.SIM_Step.TabIndex = 70;
      this.SIM_Pause.BackColor = Color.Transparent;
      this.SIM_Pause.Image = (Image) componentResourceManager.GetObject("SIM_Pause.Image");
      this.SIM_Pause.ImeMode = ImeMode.NoControl;
      Button simPause1 = this.SIM_Pause;
      point1 = new Point(72, 51);
      Point point142 = point1;
      simPause1.Location = point142;
      this.SIM_Pause.Name = "SIM_Pause";
      Button simPause2 = this.SIM_Pause;
      size1 = new Size(24, 24);
      Size size143 = size1;
      simPause2.Size = size143;
      this.SIM_Pause.TabIndex = 74;
      this.SIM_Pause.UseVisualStyleBackColor = false;
      this.SIM_Foreward_SbS.BackColor = Color.Transparent;
      this.SIM_Foreward_SbS.Image = (Image) componentResourceManager.GetObject("SIM_Foreward_SbS.Image");
      this.SIM_Foreward_SbS.ImeMode = ImeMode.NoControl;
      Button simForewardSbS1 = this.SIM_Foreward_SbS;
      point1 = new Point(103, 51);
      Point point143 = point1;
      simForewardSbS1.Location = point143;
      this.SIM_Foreward_SbS.Name = "SIM_Foreward_SbS";
      Button simForewardSbS2 = this.SIM_Foreward_SbS;
      size1 = new Size(24, 24);
      Size size144 = size1;
      simForewardSbS2.Size = size144;
      this.SIM_Foreward_SbS.TabIndex = 76;
      this.SIM_Foreward_SbS.UseVisualStyleBackColor = false;
      this.SIM_Unit.BackColor = SystemColors.Window;
      this.SIM_Unit.DropDownStyle = ComboBoxStyle.DropDownList;
      this.SIM_Unit.FormattingEnabled = true;
      this.SIM_Unit.Items.AddRange(new object[5]
      {
        (object) "sec",
        (object) "min",
        (object) "hr",
        (object) "day",
        (object) "period"
      });
      ComboBox simUnit1 = this.SIM_Unit;
      point1 = new Point(74, 19);
      Point point144 = point1;
      simUnit1.Location = point144;
      this.SIM_Unit.Name = "SIM_Unit";
      ComboBox simUnit2 = this.SIM_Unit;
      size1 = new Size(55, 21);
      Size size145 = size1;
      simUnit2.Size = size145;
      this.SIM_Unit.TabIndex = 71;
      this.GroupBox3.Controls.Add((Control) this.ODBox);
      this.GroupBox3.Controls.Add((Control) this.Label27);
      this.GroupBox3.Controls.Add((Control) this.Label135);
      this.GroupBox3.Controls.Add((Control) this.Label24);
      this.GroupBox3.Controls.Add((Control) this.LATBox);
      this.GroupBox3.Controls.Add((Control) this.Label136);
      this.GroupBox3.Controls.Add((Control) this.ETFP_Label);
      this.GroupBox3.Controls.Add((Control) this.Label138);
      this.GroupBox3.Controls.Add((Control) this.ETFEBox);
      this.GroupBox3.Controls.Add((Control) this.Label137);
      this.GroupBox3.Controls.Add((Control) this.Label153);
      this.GroupBox3.Controls.Add((Control) this.LONGBox);
      this.GroupBox3.Controls.Add((Control) this.ETFPBox);
      this.GroupBox3.Controls.Add((Control) this.Label119);
      this.GroupBox3.Controls.Add((Control) this.ALPHABox);
      this.GroupBox3.Controls.Add((Control) this.TABox);
      this.GroupBox3.Controls.Add((Control) this.Label70);
      this.GroupBox3.Controls.Add((Control) this.Label17);
      this.GroupBox3.Controls.Add((Control) this.Label10);
      this.GroupBox3.Controls.Add((Control) this.Label16);
      this.GroupBox3.Controls.Add((Control) this.Label69);
      this.GroupBox3.Controls.Add((Control) this.EABox);
      this.GroupBox3.Controls.Add((Control) this.Label9);
      GroupBox groupBox3_1 = this.GroupBox3;
      point1 = new Point(8, 145);
      Point point145 = point1;
      groupBox3_1.Location = point145;
      this.GroupBox3.Name = "GroupBox3";
      GroupBox groupBox3_2 = this.GroupBox3;
      size1 = new Size(153, 176);
      Size size146 = size1;
      groupBox3_2.Size = size146;
      this.GroupBox3.TabIndex = 62;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Position";
      this.ODBox.BackColor = SystemColors.Control;
      this.ODBox.BorderStyle = BorderStyle.None;
      TextBox odBox1 = this.ODBox;
      point1 = new Point(50, 153);
      Point point146 = point1;
      odBox1.Location = point146;
      this.ODBox.Name = "ODBox";
      this.ODBox.ReadOnly = true;
      TextBox odBox2 = this.ODBox;
      size1 = new Size(65, 13);
      Size size147 = size1;
      odBox2.Size = size147;
      this.ODBox.TabIndex = 85;
      this.ODBox.TextAlign = HorizontalAlignment.Right;
      this.Label27.AutoSize = true;
      this.Label27.ImeMode = ImeMode.NoControl;
      Label label27_1 = this.Label27;
      point1 = new Point(6, 153);
      Point point147 = point1;
      label27_1.Location = point147;
      this.Label27.Name = "Label27";
      Label label27_2 = this.Label27;
      size1 = new Size(38, 13);
      Size size148 = size1;
      label27_2.Size = size148;
      this.Label27.TabIndex = 84;
      this.Label27.Text = "SDOO";
      this.Label135.AutoSize = true;
      this.Label135.ImeMode = ImeMode.NoControl;
      Label label135_1 = this.Label135;
      point1 = new Point(6, 96);
      Point point148 = point1;
      label135_1.Location = point148;
      this.Label135.Name = "Label135";
      Label label135_2 = this.Label135;
      size1 = new Size(27, 13);
      Size size149 = size1;
      label135_2.Size = size149;
      this.Label135.TabIndex = 65;
      this.Label135.Text = "LAT";
      this.Label24.AutoSize = true;
      this.Label24.ImeMode = ImeMode.NoControl;
      Label label24_1 = this.Label24;
      point1 = new Point(122, 136);
      Point point149 = point1;
      label24_1.Location = point149;
      this.Label24.Name = "Label24";
      Label label24_2 = this.Label24;
      size1 = new Size(24, 13);
      Size size150 = size1;
      label24_2.Size = size150;
      this.Label24.TabIndex = 83;
      this.Label24.Text = "day";
      this.LATBox.BackColor = SystemColors.Control;
      this.LATBox.BorderStyle = BorderStyle.None;
      TextBox latBox1 = this.LATBox;
      point1 = new Point(51, 96);
      Point point150 = point1;
      latBox1.Location = point150;
      this.LATBox.Name = "LATBox";
      this.LATBox.ReadOnly = true;
      TextBox latBox2 = this.LATBox;
      size1 = new Size(65, 13);
      Size size151 = size1;
      latBox2.Size = size151;
      this.LATBox.TabIndex = 17;
      this.LATBox.TextAlign = HorizontalAlignment.Right;
      this.Label136.AutoSize = true;
      this.Label136.ImeMode = ImeMode.NoControl;
      Label label136_1 = this.Label136;
      point1 = new Point(123, 96);
      Point point151 = point1;
      label136_1.Location = point151;
      this.Label136.Name = "Label136";
      Label label136_2 = this.Label136;
      size1 = new Size(25, 13);
      Size size152 = size1;
      label136_2.Size = size152;
      this.Label136.TabIndex = 66;
      this.Label136.Text = "deg";
      this.ETFP_Label.AutoSize = true;
      this.ETFP_Label.ImeMode = ImeMode.NoControl;
      this.ETFP_Label.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel etfpLabel1 = this.ETFP_Label;
      point1 = new Point(123, 116);
      Point point152 = point1;
      etfpLabel1.Location = point152;
      this.ETFP_Label.Name = "ETFP_Label";
      LinkLabel etfpLabel2 = this.ETFP_Label;
      size1 = new Size(23, 13);
      Size size153 = size1;
      etfpLabel2.Size = size153;
      this.ETFP_Label.TabIndex = 70;
      this.ETFP_Label.TabStop = true;
      this.ETFP_Label.Text = "min";
      this.Label138.AutoSize = true;
      this.Label138.ImeMode = ImeMode.NoControl;
      Label label138_1 = this.Label138;
      point1 = new Point(6, 77);
      Point point153 = point1;
      label138_1.Location = point153;
      this.Label138.Name = "Label138";
      Label label138_2 = this.Label138;
      size1 = new Size(29, 13);
      Size size154 = size1;
      label138_2.Size = size154;
      this.Label138.TabIndex = 68;
      this.Label138.Text = "LNG";
      this.Label137.AutoSize = true;
      this.Label137.ImeMode = ImeMode.NoControl;
      Label label137_1 = this.Label137;
      point1 = new Point(123, 77);
      Point point154 = point1;
      label137_1.Location = point154;
      this.Label137.Name = "Label137";
      Label label137_2 = this.Label137;
      size1 = new Size(25, 13);
      Size size155 = size1;
      label137_2.Size = size155;
      this.Label137.TabIndex = 67;
      this.Label137.Text = "deg";
      this.LONGBox.BackColor = SystemColors.Control;
      this.LONGBox.BorderStyle = BorderStyle.None;
      TextBox longBox1 = this.LONGBox;
      point1 = new Point(51, 77);
      Point point155 = point1;
      longBox1.Location = point155;
      this.LONGBox.Name = "LONGBox";
      this.LONGBox.ReadOnly = true;
      TextBox longBox2 = this.LONGBox;
      size1 = new Size(65, 13);
      Size size156 = size1;
      longBox2.Size = size156;
      this.LONGBox.TabIndex = 19;
      this.LONGBox.TextAlign = HorizontalAlignment.Right;
      this.ETFPBox.BackColor = SystemColors.Control;
      this.ETFPBox.BorderStyle = BorderStyle.None;
      TextBox etfpBox1 = this.ETFPBox;
      point1 = new Point(51, 116);
      Point point156 = point1;
      etfpBox1.Location = point156;
      this.ETFPBox.Name = "ETFPBox";
      this.ETFPBox.ReadOnly = true;
      TextBox etfpBox2 = this.ETFPBox;
      size1 = new Size(65, 13);
      Size size157 = size1;
      etfpBox2.Size = size157;
      this.ETFPBox.TabIndex = 63;
      this.ETFPBox.TextAlign = HorizontalAlignment.Right;
      this.Label119.AutoSize = true;
      this.Label119.ImeMode = ImeMode.NoControl;
      Label label119_1 = this.Label119;
      point1 = new Point(6, 116);
      Point point157 = point1;
      label119_1.Location = point157;
      this.Label119.Name = "Label119";
      Label label119_2 = this.Label119;
      size1 = new Size(34, 13);
      Size size158 = size1;
      label119_2.Size = size158;
      this.Label119.TabIndex = 62;
      this.Label119.Text = "ETFP";
      this.ALPHABox.BackColor = SystemColors.Control;
      this.ALPHABox.BorderStyle = BorderStyle.None;
      TextBox alphaBox1 = this.ALPHABox;
      point1 = new Point(51, 58);
      Point point158 = point1;
      alphaBox1.Location = point158;
      this.ALPHABox.Name = "ALPHABox";
      this.ALPHABox.ReadOnly = true;
      TextBox alphaBox2 = this.ALPHABox;
      size1 = new Size(65, 13);
      Size size159 = size1;
      alphaBox2.Size = size159;
      this.ALPHABox.TabIndex = 53;
      this.ALPHABox.TextAlign = HorizontalAlignment.Right;
      this.TABox.BackColor = SystemColors.Control;
      this.TABox.BorderStyle = BorderStyle.None;
      TextBox taBox1 = this.TABox;
      point1 = new Point(51, 17);
      Point point159 = point1;
      taBox1.Location = point159;
      this.TABox.Name = "TABox";
      this.TABox.ReadOnly = true;
      TextBox taBox2 = this.TABox;
      size1 = new Size(65, 13);
      Size size160 = size1;
      taBox2.Size = size160;
      this.TABox.TabIndex = 17;
      this.TABox.TextAlign = HorizontalAlignment.Right;
      this.Label70.AutoSize = true;
      this.Label70.ImeMode = ImeMode.NoControl;
      Label label70_1 = this.Label70;
      point1 = new Point(6, 58);
      Point point160 = point1;
      label70_1.Location = point160;
      this.Label70.Name = "Label70";
      Label label70_2 = this.Label70;
      size1 = new Size(28, 13);
      Size size161 = size1;
      label70_2.Size = size161;
      this.Label70.TabIndex = 54;
      this.Label70.Text = "AOL";
      this.Label17.AutoSize = true;
      this.Label17.ImeMode = ImeMode.NoControl;
      Label label17_1 = this.Label17;
      point1 = new Point(123, 38);
      Point point161 = point1;
      label17_1.Location = point161;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(25, 13);
      Size size162 = size1;
      label17_2.Size = size162;
      this.Label17.TabIndex = 25;
      this.Label17.Text = "deg";
      this.Label10.AutoSize = true;
      this.Label10.ImeMode = ImeMode.NoControl;
      Label label10_1 = this.Label10;
      point1 = new Point(6, 38);
      Point point162 = point1;
      label10_1.Location = point162;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(21, 13);
      Size size163 = size1;
      label10_2.Size = size163;
      this.Label10.TabIndex = 10;
      this.Label10.Text = "EA";
      this.Label16.AutoSize = true;
      this.Label16.ImeMode = ImeMode.NoControl;
      Label label16_1 = this.Label16;
      point1 = new Point(123, 17);
      Point point163 = point1;
      label16_1.Location = point163;
      this.Label16.Name = "Label16";
      Label label16_2 = this.Label16;
      size1 = new Size(25, 13);
      Size size164 = size1;
      label16_2.Size = size164;
      this.Label16.TabIndex = 24;
      this.Label16.Text = "deg";
      this.Label69.AutoSize = true;
      this.Label69.ImeMode = ImeMode.NoControl;
      Label label69_1 = this.Label69;
      point1 = new Point(123, 58);
      Point point164 = point1;
      label69_1.Location = point164;
      this.Label69.Name = "Label69";
      Label label69_2 = this.Label69;
      size1 = new Size(25, 13);
      Size size165 = size1;
      label69_2.Size = size165;
      this.Label69.TabIndex = 55;
      this.Label69.Text = "deg";
      this.EABox.BackColor = SystemColors.Control;
      this.EABox.BorderStyle = BorderStyle.None;
      TextBox eaBox1 = this.EABox;
      point1 = new Point(51, 36);
      Point point165 = point1;
      eaBox1.Location = point165;
      this.EABox.Name = "EABox";
      this.EABox.ReadOnly = true;
      TextBox eaBox2 = this.EABox;
      size1 = new Size(65, 13);
      Size size166 = size1;
      eaBox2.Size = size166;
      this.EABox.TabIndex = 18;
      this.EABox.TextAlign = HorizontalAlignment.Right;
      this.Label9.AutoSize = true;
      this.Label9.ImeMode = ImeMode.NoControl;
      Label label9_1 = this.Label9;
      point1 = new Point(6, 17);
      Point point166 = point1;
      label9_1.Location = point166;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(21, 13);
      Size size167 = size1;
      label9_2.Size = size167;
      this.Label9.TabIndex = 9;
      this.Label9.Text = "TA";
      this.GroupBox6.Controls.Add((Control) this.APVBox);
      this.GroupBox6.Controls.Add((Control) this.PEVBox);
      this.GroupBox6.Controls.Add((Control) this.Label77);
      this.GroupBox6.Controls.Add((Control) this.Label40);
      this.GroupBox6.Controls.Add((Control) this.Label78);
      this.GroupBox6.Controls.Add((Control) this.Label39);
      this.GroupBox6.Controls.Add((Control) this.VELBox);
      this.GroupBox6.Controls.Add((Control) this.Label37);
      this.GroupBox6.Controls.Add((Control) this.Label20);
      GroupBox groupBox6_1 = this.GroupBox6;
      point1 = new Point(167, 288);
      Point point167 = point1;
      groupBox6_1.Location = point167;
      this.GroupBox6.Name = "GroupBox6";
      GroupBox groupBox6_2 = this.GroupBox6;
      size1 = new Size(178, 78);
      Size size168 = size1;
      groupBox6_2.Size = size168;
      this.GroupBox6.TabIndex = 58;
      this.GroupBox6.TabStop = false;
      this.GroupBox6.Text = "Velocities";
      this.APVBox.BackColor = SystemColors.Control;
      this.APVBox.BorderStyle = BorderStyle.None;
      TextBox apvBox1 = this.APVBox;
      point1 = new Point(56, 22);
      Point point168 = point1;
      apvBox1.Location = point168;
      this.APVBox.Name = "APVBox";
      this.APVBox.ReadOnly = true;
      TextBox apvBox2 = this.APVBox;
      size1 = new Size(65, 13);
      Size size169 = size1;
      apvBox2.Size = size169;
      this.APVBox.TabIndex = 44;
      this.APVBox.TextAlign = HorizontalAlignment.Right;
      this.PEVBox.BackColor = SystemColors.Control;
      this.PEVBox.BorderStyle = BorderStyle.None;
      TextBox pevBox1 = this.PEVBox;
      point1 = new Point(56, 41);
      Point point169 = point1;
      pevBox1.Location = point169;
      this.PEVBox.Name = "PEVBox";
      this.PEVBox.ReadOnly = true;
      TextBox pevBox2 = this.PEVBox;
      size1 = new Size(65, 13);
      Size size170 = size1;
      pevBox2.Size = size170;
      this.PEVBox.TabIndex = 45;
      this.PEVBox.TextAlign = HorizontalAlignment.Right;
      this.Label77.AutoSize = true;
      this.Label77.ImeMode = ImeMode.NoControl;
      Label label77_1 = this.Label77;
      point1 = new Point(129, 60);
      Point point170 = point1;
      label77_1.Location = point170;
      this.Label77.Name = "Label77";
      Label label77_2 = this.Label77;
      size1 = new Size(31, 13);
      Size size171 = size1;
      label77_2.Size = size171;
      this.Label77.TabIndex = 67;
      this.Label77.Text = "km/s";
      this.Label40.AutoSize = true;
      this.Label40.ImeMode = ImeMode.NoControl;
      Label label40_1 = this.Label40;
      point1 = new Point(6, 22);
      Point point171 = point1;
      label40_1.Location = point171;
      this.Label40.Name = "Label40";
      Label label40_2 = this.Label40;
      size1 = new Size(27, 13);
      Size size172 = size1;
      label40_2.Size = size172;
      this.Label40.TabIndex = 46;
      this.Label40.Text = "ApV";
      this.Label78.AutoSize = true;
      this.Label78.ImeMode = ImeMode.NoControl;
      Label label78_1 = this.Label78;
      point1 = new Point(6, 60);
      Point point172 = point1;
      label78_1.Location = point172;
      this.Label78.Name = "Label78";
      Label label78_2 = this.Label78;
      size1 = new Size(27, 13);
      Size size173 = size1;
      label78_2.Size = size173;
      this.Label78.TabIndex = 66;
      this.Label78.Text = "VEL";
      this.Label39.AutoSize = true;
      this.Label39.ImeMode = ImeMode.NoControl;
      Label label39_1 = this.Label39;
      point1 = new Point(129, 22);
      Point point173 = point1;
      label39_1.Location = point173;
      this.Label39.Name = "Label39";
      Label label39_2 = this.Label39;
      size1 = new Size(31, 13);
      Size size174 = size1;
      label39_2.Size = size174;
      this.Label39.TabIndex = 47;
      this.Label39.Text = "km/s";
      this.VELBox.BackColor = SystemColors.Control;
      this.VELBox.BorderStyle = BorderStyle.None;
      TextBox velBox1 = this.VELBox;
      point1 = new Point(56, 60);
      Point point174 = point1;
      velBox1.Location = point174;
      this.VELBox.Name = "VELBox";
      this.VELBox.ReadOnly = true;
      TextBox velBox2 = this.VELBox;
      size1 = new Size(65, 13);
      Size size175 = size1;
      velBox2.Size = size175;
      this.VELBox.TabIndex = 65;
      this.VELBox.TextAlign = HorizontalAlignment.Right;
      this.Label37.AutoSize = true;
      this.Label37.ImeMode = ImeMode.NoControl;
      Label label37_1 = this.Label37;
      point1 = new Point(6, 41);
      Point point175 = point1;
      label37_1.Location = point175;
      this.Label37.Name = "Label37";
      Label label37_2 = this.Label37;
      size1 = new Size(27, 13);
      Size size176 = size1;
      label37_2.Size = size176;
      this.Label37.TabIndex = 48;
      this.Label37.Text = "PeV";
      this.Label20.AutoSize = true;
      this.Label20.ImeMode = ImeMode.NoControl;
      Label label20_1 = this.Label20;
      point1 = new Point(129, 41);
      Point point176 = point1;
      label20_1.Location = point176;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(31, 13);
      Size size177 = size1;
      label20_2.Size = size177;
      this.Label20.TabIndex = 49;
      this.Label20.Text = "km/s";
      this.GroupBox8.Controls.Add((Control) this.KepPeriod_Label);
      this.GroupBox8.Controls.Add((Control) this.KPERBox);
      this.GroupBox8.Controls.Add((Control) this.Label26);
      this.GroupBox8.Controls.Add((Control) this.DracoPeriod_Label);
      this.GroupBox8.Controls.Add((Control) this.AnoPeriod_Label);
      this.GroupBox8.Controls.Add((Control) this.APERBox);
      this.GroupBox8.Controls.Add((Control) this.DPERBox);
      this.GroupBox8.Controls.Add((Control) this.Label28);
      this.GroupBox8.Controls.Add((Control) this.Label30);
      this.GroupBox8.Controls.Add((Control) this.phase);
      this.GroupBox8.Controls.Add((Control) this.Label94);
      GroupBox groupBox8_1 = this.GroupBox8;
      point1 = new Point(8, 485);
      Point point177 = point1;
      groupBox8_1.Location = point177;
      this.GroupBox8.Name = "GroupBox8";
      GroupBox groupBox8_2 = this.GroupBox8;
      size1 = new Size(153, 94);
      Size size178 = size1;
      groupBox8_2.Size = size178;
      this.GroupBox8.TabIndex = 61;
      this.GroupBox8.TabStop = false;
      this.GroupBox8.Text = "Periods";
      this.KepPeriod_Label.AutoSize = true;
      this.KepPeriod_Label.ImeMode = ImeMode.NoControl;
      this.KepPeriod_Label.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel kepPeriodLabel1 = this.KepPeriod_Label;
      point1 = new Point(122, 16);
      Point point178 = point1;
      kepPeriodLabel1.Location = point178;
      this.KepPeriod_Label.Name = "KepPeriod_Label";
      LinkLabel kepPeriodLabel2 = this.KepPeriod_Label;
      size1 = new Size(23, 13);
      Size size179 = size1;
      kepPeriodLabel2.Size = size179;
      this.KepPeriod_Label.TabIndex = 81;
      this.KepPeriod_Label.TabStop = true;
      this.KepPeriod_Label.Text = "min";
      this.KPERBox.BackColor = SystemColors.Control;
      this.KPERBox.BorderStyle = BorderStyle.None;
      TextBox kperBox1 = this.KPERBox;
      point1 = new Point(51, 16);
      Point point179 = point1;
      kperBox1.Location = point179;
      this.KPERBox.Name = "KPERBox";
      this.KPERBox.ReadOnly = true;
      TextBox kperBox2 = this.KPERBox;
      size1 = new Size(65, 13);
      Size size180 = size1;
      kperBox2.Size = size180;
      this.KPERBox.TabIndex = 79;
      this.KPERBox.TextAlign = HorizontalAlignment.Right;
      this.Label26.AutoSize = true;
      this.Label26.ImeMode = ImeMode.NoControl;
      Label label26_1 = this.Label26;
      point1 = new Point(6, 16);
      Point point180 = point1;
      label26_1.Location = point180;
      this.Label26.Name = "Label26";
      Label label26_2 = this.Label26;
      size1 = new Size(20, 13);
      Size size181 = size1;
      label26_2.Size = size181;
      this.Label26.TabIndex = 80;
      this.Label26.Text = "Tk";
      this.DracoPeriod_Label.AutoSize = true;
      this.DracoPeriod_Label.ImeMode = ImeMode.NoControl;
      this.DracoPeriod_Label.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel dracoPeriodLabel1 = this.DracoPeriod_Label;
      point1 = new Point(122, 55);
      Point point181 = point1;
      dracoPeriodLabel1.Location = point181;
      this.DracoPeriod_Label.Name = "DracoPeriod_Label";
      LinkLabel dracoPeriodLabel2 = this.DracoPeriod_Label;
      size1 = new Size(23, 13);
      Size size182 = size1;
      dracoPeriodLabel2.Size = size182;
      this.DracoPeriod_Label.TabIndex = 72;
      this.DracoPeriod_Label.TabStop = true;
      this.DracoPeriod_Label.Text = "min";
      this.AnoPeriod_Label.AutoSize = true;
      this.AnoPeriod_Label.ImeMode = ImeMode.NoControl;
      this.AnoPeriod_Label.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel anoPeriodLabel1 = this.AnoPeriod_Label;
      point1 = new Point(122, 36);
      Point point182 = point1;
      anoPeriodLabel1.Location = point182;
      this.AnoPeriod_Label.Name = "AnoPeriod_Label";
      LinkLabel anoPeriodLabel2 = this.AnoPeriod_Label;
      size1 = new Size(23, 13);
      Size size183 = size1;
      anoPeriodLabel2.Size = size183;
      this.AnoPeriod_Label.TabIndex = 71;
      this.AnoPeriod_Label.TabStop = true;
      this.AnoPeriod_Label.Text = "min";
      this.APERBox.BackColor = SystemColors.Control;
      this.APERBox.BorderStyle = BorderStyle.None;
      TextBox aperBox1 = this.APERBox;
      point1 = new Point(51, 36);
      Point point183 = point1;
      aperBox1.Location = point183;
      this.APERBox.Name = "APERBox";
      this.APERBox.ReadOnly = true;
      TextBox aperBox2 = this.APERBox;
      size1 = new Size(65, 13);
      Size size184 = size1;
      aperBox2.Size = size184;
      this.APERBox.TabIndex = 31;
      this.APERBox.TextAlign = HorizontalAlignment.Right;
      this.DPERBox.BackColor = SystemColors.Control;
      this.DPERBox.BorderStyle = BorderStyle.None;
      TextBox dperBox1 = this.DPERBox;
      point1 = new Point(51, 55);
      Point point184 = point1;
      dperBox1.Location = point184;
      this.DPERBox.Name = "DPERBox";
      this.DPERBox.ReadOnly = true;
      TextBox dperBox2 = this.DPERBox;
      size1 = new Size(65, 13);
      Size size185 = size1;
      dperBox2.Size = size185;
      this.DPERBox.TabIndex = 32;
      this.DPERBox.TextAlign = HorizontalAlignment.Right;
      this.Label28.AutoSize = true;
      this.Label28.ImeMode = ImeMode.NoControl;
      Label label28_1 = this.Label28;
      point1 = new Point(6, 36);
      Point point185 = point1;
      label28_1.Location = point185;
      this.Label28.Name = "Label28";
      Label label28_2 = this.Label28;
      size1 = new Size(20, 13);
      Size size186 = size1;
      label28_2.Size = size186;
      this.Label28.TabIndex = 40;
      this.Label28.Text = "Ta";
      this.Label30.AutoSize = true;
      this.Label30.ImeMode = ImeMode.NoControl;
      Label label30_1 = this.Label30;
      point1 = new Point(6, 55);
      Point point186 = point1;
      label30_1.Location = point186;
      this.Label30.Name = "Label30";
      Label label30_2 = this.Label30;
      size1 = new Size(20, 13);
      Size size187 = size1;
      label30_2.Size = size187;
      this.Label30.TabIndex = 42;
      this.Label30.Text = "Td";
      this.GroupBox7.Controls.Add((Control) this.Label141);
      this.GroupBox7.Controls.Add((Control) this.Label118);
      this.GroupBox7.Controls.Add((Control) this.MALTBox);
      this.GroupBox7.Controls.Add((Control) this.PERBox);
      this.GroupBox7.Controls.Add((Control) this.PEABox);
      this.GroupBox7.Controls.Add((Control) this.APRBox);
      this.GroupBox7.Controls.Add((Control) this.RelDist);
      this.GroupBox7.Controls.Add((Control) this.Label154);
      this.GroupBox7.Controls.Add((Control) this.APABox);
      this.GroupBox7.Controls.Add((Control) this.ApALabel);
      this.GroupBox7.Controls.Add((Control) this.PeALabel);
      this.GroupBox7.Controls.Add((Control) this.Label140);
      this.GroupBox7.Controls.Add((Control) this.Label22);
      this.GroupBox7.Controls.Add((Control) this.ALTLabel);
      this.GroupBox7.Controls.Add((Control) this.Label23);
      this.GroupBox7.Controls.Add((Control) this.ALTBox);
      this.GroupBox7.Controls.Add((Control) this.Label139);
      this.GroupBox7.Controls.Add((Control) this.Label121);
      this.GroupBox7.Controls.Add((Control) this.Label7);
      this.GroupBox7.Controls.Add((Control) this.Label6);
      GroupBox groupBox7_1 = this.GroupBox7;
      point1 = new Point(8, 327);
      Point point187 = point1;
      groupBox7_1.Location = point187;
      this.GroupBox7.Name = "GroupBox7";
      GroupBox groupBox7_2 = this.GroupBox7;
      size1 = new Size(153, 152);
      Size size188 = size1;
      groupBox7_2.Size = size188;
      this.GroupBox7.TabIndex = 60;
      this.GroupBox7.TabStop = false;
      this.GroupBox7.Text = "Altitudes";
      this.Label141.AutoSize = true;
      this.Label141.ImeMode = ImeMode.NoControl;
      Label label141_1 = this.Label141;
      point1 = new Point(122, 120);
      Point point188 = point1;
      label141_1.Location = point188;
      this.Label141.Name = "Label141";
      Label label141_2 = this.Label141;
      size1 = new Size(21, 13);
      Size size189 = size1;
      label141_2.Size = size189;
      this.Label141.TabIndex = 67;
      this.Label141.Text = "km";
      this.Label118.AutoSize = true;
      this.Label118.ImeMode = ImeMode.NoControl;
      Label label118_1 = this.Label118;
      point1 = new Point(6, 117);
      Point point189 = point1;
      label118_1.Location = point189;
      this.Label118.Name = "Label118";
      Label label118_2 = this.Label118;
      size1 = new Size(36, 13);
      Size size190 = size1;
      label118_2.Size = size190;
      this.Label118.TabIndex = 66;
      this.Label118.Text = "MALT";
      this.MALTBox.BackColor = SystemColors.Control;
      this.MALTBox.BorderStyle = BorderStyle.None;
      TextBox maltBox1 = this.MALTBox;
      point1 = new Point(49, 117);
      Point point190 = point1;
      maltBox1.Location = point190;
      this.MALTBox.Name = "MALTBox";
      this.MALTBox.ReadOnly = true;
      TextBox maltBox2 = this.MALTBox;
      size1 = new Size(65, 13);
      Size size191 = size1;
      maltBox2.Size = size191;
      this.MALTBox.TabIndex = 65;
      this.MALTBox.TextAlign = HorizontalAlignment.Right;
      this.PERBox.BackColor = SystemColors.Control;
      this.PERBox.BorderStyle = BorderStyle.None;
      TextBox perBox1 = this.PERBox;
      point1 = new Point(49, 79);
      Point point191 = point1;
      perBox1.Location = point191;
      this.PERBox.Name = "PERBox";
      this.PERBox.ReadOnly = true;
      TextBox perBox2 = this.PERBox;
      size1 = new Size(65, 13);
      Size size192 = size1;
      perBox2.Size = size192;
      this.PERBox.TabIndex = 29;
      this.PERBox.TextAlign = HorizontalAlignment.Right;
      this.PEABox.BackColor = SystemColors.Control;
      this.PEABox.BorderStyle = BorderStyle.None;
      TextBox peaBox1 = this.PEABox;
      point1 = new Point(49, 41);
      Point point192 = point1;
      peaBox1.Location = point192;
      this.PEABox.Name = "PEABox";
      this.PEABox.ReadOnly = true;
      TextBox peaBox2 = this.PEABox;
      size1 = new Size(65, 13);
      Size size193 = size1;
      peaBox2.Size = size193;
      this.PEABox.TabIndex = 27;
      this.PEABox.TextAlign = HorizontalAlignment.Right;
      this.APRBox.BackColor = SystemColors.Control;
      this.APRBox.BorderStyle = BorderStyle.None;
      TextBox aprBox1 = this.APRBox;
      point1 = new Point(49, 60);
      Point point193 = point1;
      aprBox1.Location = point193;
      this.APRBox.Name = "APRBox";
      this.APRBox.ReadOnly = true;
      TextBox aprBox2 = this.APRBox;
      size1 = new Size(65, 13);
      Size size194 = size1;
      aprBox2.Size = size194;
      this.APRBox.TabIndex = 28;
      this.APRBox.TextAlign = HorizontalAlignment.Right;
      this.APABox.BackColor = SystemColors.Control;
      this.APABox.BorderStyle = BorderStyle.None;
      TextBox apaBox1 = this.APABox;
      point1 = new Point(49, 22);
      Point point194 = point1;
      apaBox1.Location = point194;
      this.APABox.Name = "APABox";
      this.APABox.ReadOnly = true;
      TextBox apaBox2 = this.APABox;
      size1 = new Size(65, 13);
      Size size195 = size1;
      apaBox2.Size = size195;
      this.APABox.TabIndex = 30;
      this.APABox.TextAlign = HorizontalAlignment.Right;
      this.ApALabel.AutoSize = true;
      this.ApALabel.ImeMode = ImeMode.NoControl;
      Label apAlabel1 = this.ApALabel;
      point1 = new Point(6, 22);
      Point point195 = point1;
      apAlabel1.Location = point195;
      this.ApALabel.Name = "ApALabel";
      Label apAlabel2 = this.ApALabel;
      size1 = new Size(27, 13);
      Size size196 = size1;
      apAlabel2.Size = size196;
      this.ApALabel.TabIndex = 33;
      this.ApALabel.Text = "ApA";
      this.PeALabel.AutoSize = true;
      this.PeALabel.ImeMode = ImeMode.NoControl;
      Label peAlabel1 = this.PeALabel;
      point1 = new Point(6, 41);
      Point point196 = point1;
      peAlabel1.Location = point196;
      this.PeALabel.Name = "PeALabel";
      Label peAlabel2 = this.PeALabel;
      size1 = new Size(27, 13);
      Size size197 = size1;
      peAlabel2.Size = size197;
      this.PeALabel.TabIndex = 34;
      this.PeALabel.Text = "PeA";
      this.Label140.AutoSize = true;
      this.Label140.ImeMode = ImeMode.NoControl;
      Label label140_1 = this.Label140;
      point1 = new Point(122, 101);
      Point point197 = point1;
      label140_1.Location = point197;
      this.Label140.Name = "Label140";
      Label label140_2 = this.Label140;
      size1 = new Size(21, 13);
      Size size198 = size1;
      label140_2.Size = size198;
      this.Label140.TabIndex = 64;
      this.Label140.Text = "km";
      this.Label22.AutoSize = true;
      this.Label22.ImeMode = ImeMode.NoControl;
      Label label22_1 = this.Label22;
      point1 = new Point(6, 60);
      Point point198 = point1;
      label22_1.Location = point198;
      this.Label22.Name = "Label22";
      Label label22_2 = this.Label22;
      size1 = new Size(28, 13);
      Size size199 = size1;
      label22_2.Size = size199;
      this.Label22.TabIndex = 35;
      this.Label22.Text = "ApR";
      this.ALTLabel.AutoSize = true;
      this.ALTLabel.ImeMode = ImeMode.NoControl;
      Label altLabel1 = this.ALTLabel;
      point1 = new Point(6, 98);
      Point point199 = point1;
      altLabel1.Location = point199;
      this.ALTLabel.Name = "ALTLabel";
      Label altLabel2 = this.ALTLabel;
      size1 = new Size(27, 13);
      Size size200 = size1;
      altLabel2.Size = size200;
      this.ALTLabel.TabIndex = 63;
      this.ALTLabel.Text = "ALT";
      this.Label23.AutoSize = true;
      this.Label23.ImeMode = ImeMode.NoControl;
      Label label23_1 = this.Label23;
      point1 = new Point(6, 79);
      Point point200 = point1;
      label23_1.Location = point200;
      this.Label23.Name = "Label23";
      Label label23_2 = this.Label23;
      size1 = new Size(28, 13);
      Size size201 = size1;
      label23_2.Size = size201;
      this.Label23.TabIndex = 36;
      this.Label23.Text = "PeR";
      this.ALTBox.BackColor = SystemColors.Control;
      this.ALTBox.BorderStyle = BorderStyle.None;
      TextBox altBox1 = this.ALTBox;
      point1 = new Point(49, 98);
      Point point201 = point1;
      altBox1.Location = point201;
      this.ALTBox.Name = "ALTBox";
      this.ALTBox.ReadOnly = true;
      TextBox altBox2 = this.ALTBox;
      size1 = new Size(65, 13);
      Size size202 = size1;
      altBox2.Size = size202;
      this.ALTBox.TabIndex = 62;
      this.ALTBox.TextAlign = HorizontalAlignment.Right;
      this.Label139.AutoSize = true;
      this.Label139.ImeMode = ImeMode.NoControl;
      Label label139_1 = this.Label139;
      point1 = new Point(122, 25);
      Point point202 = point1;
      label139_1.Location = point202;
      this.Label139.Name = "Label139";
      Label label139_2 = this.Label139;
      size1 = new Size(21, 13);
      Size size203 = size1;
      label139_2.Size = size203;
      this.Label139.TabIndex = 31;
      this.Label139.Text = "km";
      this.Label121.AutoSize = true;
      this.Label121.ImeMode = ImeMode.NoControl;
      Label label121_1 = this.Label121;
      point1 = new Point(122, 44);
      Point point203 = point1;
      label121_1.Location = point203;
      this.Label121.Name = "Label121";
      Label label121_2 = this.Label121;
      size1 = new Size(21, 13);
      Size size204 = size1;
      label121_2.Size = size204;
      this.Label121.TabIndex = 37;
      this.Label121.Text = "km";
      this.Label7.AutoSize = true;
      this.Label7.ImeMode = ImeMode.NoControl;
      Label label7_1 = this.Label7;
      point1 = new Point(122, 63);
      Point point204 = point1;
      label7_1.Location = point204;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(21, 13);
      Size size205 = size1;
      label7_2.Size = size205;
      this.Label7.TabIndex = 38;
      this.Label7.Text = "km";
      this.Label6.AutoSize = true;
      this.Label6.ImeMode = ImeMode.NoControl;
      Label label6_1 = this.Label6;
      point1 = new Point(122, 82);
      Point point205 = point1;
      label6_1.Location = point205;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(21, 13);
      Size size206 = size1;
      label6_2.Size = size206;
      this.Label6.TabIndex = 39;
      this.Label6.Text = "km";
      this.MapOptions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.MapOptions.Controls.Add((Control) this.MAP_VisibilityZone);
      this.MapOptions.Controls.Add((Control) this.MAP_SatName);
      this.MapOptions.Controls.Add((Control) this.MAP_Show_FullTrack);
      this.MapOptions.Controls.Add((Control) this.MAP_PtsOnOrbit);
      this.MapOptions.Controls.Add((Control) this.MAP_NightShadow);
      this.MapOptions.Controls.Add((Control) this.MAP_FullGrid);
      this.MapOptions.Controls.Add((Control) this.MAP_ShowTrack);
      this.MapOptions.Controls.Add((Control) this.Label25);
      this.MapOptions.Controls.Add((Control) this.MAP_Num_Period);
      this.MapOptions.Enabled = false;
      GroupBox mapOptions1 = this.MapOptions;
      point1 = new Point(9, 750);
      Point point206 = point1;
      mapOptions1.Location = point206;
      this.MapOptions.Name = "MapOptions";
      GroupBox mapOptions2 = this.MapOptions;
      size1 = new Size(893, 68);
      Size size207 = size1;
      mapOptions2.Size = size207;
      this.MapOptions.TabIndex = 67;
      this.MapOptions.TabStop = false;
      this.MapOptions.Text = "Track/Map Options";
      this.MAP_VisibilityZone.AutoSize = true;
      this.MAP_VisibilityZone.Checked = true;
      this.MAP_VisibilityZone.CheckState = CheckState.Checked;
      this.MAP_VisibilityZone.ImeMode = ImeMode.NoControl;
      CheckBox mapVisibilityZone1 = this.MAP_VisibilityZone;
      point1 = new Point(265, 22);
      Point point207 = point1;
      mapVisibilityZone1.Location = point207;
      this.MAP_VisibilityZone.Name = "MAP_VisibilityZone";
      CheckBox mapVisibilityZone2 = this.MAP_VisibilityZone;
      size1 = new Size(90, 17);
      Size size208 = size1;
      mapVisibilityZone2.Size = size208;
      this.MAP_VisibilityZone.TabIndex = 90;
      this.MAP_VisibilityZone.Text = "Visibility Zone";
      this.MAP_VisibilityZone.UseVisualStyleBackColor = true;
      this.MAP_SatName.AutoSize = true;
      this.MAP_SatName.Checked = true;
      this.MAP_SatName.CheckState = CheckState.Checked;
      this.MAP_SatName.ImeMode = ImeMode.NoControl;
      CheckBox mapSatName1 = this.MAP_SatName;
      point1 = new Point(364, 42);
      Point point208 = point1;
      mapSatName1.Location = point208;
      this.MAP_SatName.Name = "MAP_SatName";
      CheckBox mapSatName2 = this.MAP_SatName;
      size1 = new Size(73, 17);
      Size size209 = size1;
      mapSatName2.Size = size209;
      this.MAP_SatName.TabIndex = 89;
      this.MAP_SatName.Text = "Sat Name";
      this.MAP_SatName.UseVisualStyleBackColor = true;
      this.MAP_Show_FullTrack.AutoSize = true;
      this.MAP_Show_FullTrack.ImeMode = ImeMode.NoControl;
      CheckBox mapShowFullTrack1 = this.MAP_Show_FullTrack;
      point1 = new Point(13, 43);
      Point point209 = point1;
      mapShowFullTrack1.Location = point209;
      CheckBox mapShowFullTrack2 = this.MAP_Show_FullTrack;
      padding1 = new Padding(0);
      Padding padding8 = padding1;
      mapShowFullTrack2.Margin = padding8;
      this.MAP_Show_FullTrack.Name = "MAP_Show_FullTrack";
      CheckBox mapShowFullTrack3 = this.MAP_Show_FullTrack;
      size1 = new Size(73, 17);
      Size size210 = size1;
      mapShowFullTrack3.Size = size210;
      this.MAP_Show_FullTrack.TabIndex = 88;
      this.MAP_Show_FullTrack.Text = "Full Track";
      this.MAP_Show_FullTrack.UseVisualStyleBackColor = true;
      this.MAP_PtsOnOrbit.AutoSize = true;
      this.MAP_PtsOnOrbit.Checked = true;
      this.MAP_PtsOnOrbit.CheckState = CheckState.Checked;
      this.MAP_PtsOnOrbit.ImeMode = ImeMode.NoControl;
      CheckBox mapPtsOnOrbit1 = this.MAP_PtsOnOrbit;
      point1 = new Point(89, 43);
      Point point210 = point1;
      mapPtsOnOrbit1.Location = point210;
      this.MAP_PtsOnOrbit.Name = "MAP_PtsOnOrbit";
      CheckBox mapPtsOnOrbit2 = this.MAP_PtsOnOrbit;
      size1 = new Size(96, 17);
      Size size211 = size1;
      mapPtsOnOrbit2.Size = size211;
      this.MAP_PtsOnOrbit.TabIndex = 87;
      this.MAP_PtsOnOrbit.Text = "Specific Points";
      this.MAP_PtsOnOrbit.UseVisualStyleBackColor = true;
      this.MAP_NightShadow.AutoSize = true;
      this.MAP_NightShadow.Checked = true;
      this.MAP_NightShadow.CheckState = CheckState.Checked;
      this.MAP_NightShadow.ImeMode = ImeMode.NoControl;
      CheckBox mapNightShadow1 = this.MAP_NightShadow;
      point1 = new Point(265, 42);
      Point point211 = point1;
      mapNightShadow1.Location = point211;
      this.MAP_NightShadow.Name = "MAP_NightShadow";
      CheckBox mapNightShadow2 = this.MAP_NightShadow;
      size1 = new Size(93, 17);
      Size size212 = size1;
      mapNightShadow2.Size = size212;
      this.MAP_NightShadow.TabIndex = 83;
      this.MAP_NightShadow.Text = "Night Shadow";
      this.MAP_NightShadow.UseVisualStyleBackColor = true;
      this.MAP_FullGrid.AutoSize = true;
      this.MAP_FullGrid.ImeMode = ImeMode.NoControl;
      CheckBox mapFullGrid1 = this.MAP_FullGrid;
      point1 = new Point(364, 22);
      Point point212 = point1;
      mapFullGrid1.Location = point212;
      this.MAP_FullGrid.Name = "MAP_FullGrid";
      CheckBox mapFullGrid2 = this.MAP_FullGrid;
      size1 = new Size(64, 17);
      Size size213 = size1;
      mapFullGrid2.Size = size213;
      this.MAP_FullGrid.TabIndex = 78;
      this.MAP_FullGrid.Text = "Full Grid";
      this.MAP_FullGrid.UseVisualStyleBackColor = true;
      this.MAP_ShowTrack.AutoSize = true;
      this.MAP_ShowTrack.Checked = true;
      this.MAP_ShowTrack.CheckState = CheckState.Checked;
      this.MAP_ShowTrack.ImeMode = ImeMode.NoControl;
      CheckBox mapShowTrack1 = this.MAP_ShowTrack;
      point1 = new Point(13, 22);
      Point point213 = point1;
      mapShowTrack1.Location = point213;
      CheckBox mapShowTrack2 = this.MAP_ShowTrack;
      padding1 = new Padding(0);
      Padding padding9 = padding1;
      mapShowTrack2.Margin = padding9;
      this.MAP_ShowTrack.Name = "MAP_ShowTrack";
      CheckBox mapShowTrack3 = this.MAP_ShowTrack;
      size1 = new Size(69, 17);
      Size size214 = size1;
      mapShowTrack3.Size = size214;
      this.MAP_ShowTrack.TabIndex = 77;
      this.MAP_ShowTrack.Text = "Track on";
      this.MAP_ShowTrack.UseVisualStyleBackColor = true;
      this.Label25.AutoSize = true;
      this.Label25.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label25.ImeMode = ImeMode.NoControl;
      Label label25_1 = this.Label25;
      point1 = new Point(133, 24);
      Point point214 = point1;
      label25_1.Location = point214;
      this.Label25.Name = "Label25";
      Label label25_2 = this.Label25;
      size1 = new Size(42, 13);
      Size size215 = size1;
      label25_2.Size = size215;
      this.Label25.TabIndex = 74;
      this.Label25.Text = "Periods";
      this.MAP_Num_Period.BackColor = SystemColors.Window;
      this.MAP_Num_Period.Cursor = Cursors.Default;
      this.MAP_Num_Period.DropDownStyle = ComboBoxStyle.DropDownList;
      this.MAP_Num_Period.Enabled = false;
      this.MAP_Num_Period.FormattingEnabled = true;
      this.MAP_Num_Period.Items.AddRange(new object[19]
      {
        (object) "1",
        (object) "2",
        (object) "3",
        (object) "4",
        (object) "5",
        (object) "10",
        (object) "15",
        (object) "20",
        (object) "25",
        (object) "30",
        (object) "35",
        (object) "40",
        (object) "45",
        (object) "50",
        (object) "60",
        (object) "70",
        (object) "80",
        (object) "90",
        (object) "100"
      });
      ComboBox mapNumPeriod1 = this.MAP_Num_Period;
      point1 = new Point(89, 20);
      Point point215 = point1;
      mapNumPeriod1.Location = point215;
      this.MAP_Num_Period.Name = "MAP_Num_Period";
      ComboBox mapNumPeriod2 = this.MAP_Num_Period;
      size1 = new Size(43, 21);
      Size size216 = size1;
      mapNumPeriod2.Size = size216;
      this.MAP_Num_Period.TabIndex = 72;
      this.KeplerElementsFrame.BackColor = SystemColors.Control;
      this.KeplerElementsFrame.Controls.Add((Control) this.Label14);
      this.KeplerElementsFrame.Controls.Add((Control) this.Label13);
      this.KeplerElementsFrame.Controls.Add((Control) this.Label12);
      this.KeplerElementsFrame.Controls.Add((Control) this.Label11);
      this.KeplerElementsFrame.Controls.Add((Control) this.AOPBox);
      this.KeplerElementsFrame.Controls.Add((Control) this.SMABox);
      this.KeplerElementsFrame.Controls.Add((Control) this.Label3);
      this.KeplerElementsFrame.Controls.Add((Control) this.RAANBox);
      this.KeplerElementsFrame.Controls.Add((Control) this.INCBox);
      this.KeplerElementsFrame.Controls.Add((Control) this.Label15);
      this.KeplerElementsFrame.Controls.Add((Control) this.ECCBox);
      this.KeplerElementsFrame.Controls.Add((Control) this.MABox);
      this.KeplerElementsFrame.Controls.Add((Control) this.Label8);
      this.KeplerElementsFrame.Controls.Add((Control) this.AOP_Label);
      this.KeplerElementsFrame.Controls.Add((Control) this.RAAN_Label);
      this.KeplerElementsFrame.Controls.Add((Control) this.Label5);
      this.KeplerElementsFrame.Controls.Add((Control) this.Label4);
      this.KeplerElementsFrame.ForeColor = Color.Black;
      GroupBox keplerElementsFrame1 = this.KeplerElementsFrame;
      point1 = new Point(8, 6);
      Point point216 = point1;
      keplerElementsFrame1.Location = point216;
      this.KeplerElementsFrame.Name = "KeplerElementsFrame";
      GroupBox keplerElementsFrame2 = this.KeplerElementsFrame;
      size1 = new Size(153, 135);
      Size size217 = size1;
      keplerElementsFrame2.Size = size217;
      this.KeplerElementsFrame.TabIndex = 53;
      this.KeplerElementsFrame.TabStop = false;
      this.KeplerElementsFrame.Text = "Keplerian Parameters";
      this.Label14.AutoSize = true;
      this.Label14.BackColor = SystemColors.Control;
      this.Label14.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label14.ForeColor = Color.Black;
      this.Label14.ImeMode = ImeMode.NoControl;
      Label label14_1 = this.Label14;
      point1 = new Point(122, 95);
      Point point217 = point1;
      label14_1.Location = point217;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(25, 13);
      Size size218 = size1;
      label14_2.Size = size218;
      this.Label14.TabIndex = 22;
      this.Label14.Text = "deg";
      this.Label13.AutoSize = true;
      this.Label13.BackColor = SystemColors.Control;
      this.Label13.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label13.ForeColor = Color.Black;
      this.Label13.ImeMode = ImeMode.NoControl;
      Label label13_1 = this.Label13;
      point1 = new Point(122, 76);
      Point point218 = point1;
      label13_1.Location = point218;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(25, 13);
      Size size219 = size1;
      label13_2.Size = size219;
      this.Label13.TabIndex = 21;
      this.Label13.Text = "deg";
      this.Label12.AutoSize = true;
      this.Label12.BackColor = SystemColors.Control;
      this.Label12.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label12.ForeColor = Color.Black;
      this.Label12.ImeMode = ImeMode.NoControl;
      Label label12_1 = this.Label12;
      point1 = new Point(122, 57);
      Point point219 = point1;
      label12_1.Location = point219;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(25, 13);
      Size size220 = size1;
      label12_2.Size = size220;
      this.Label12.TabIndex = 20;
      this.Label12.Text = "deg";
      this.Label11.AutoSize = true;
      this.Label11.BackColor = SystemColors.Control;
      this.Label11.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label11.ForeColor = Color.Black;
      this.Label11.ImeMode = ImeMode.NoControl;
      Label label11_1 = this.Label11;
      point1 = new Point(122, 19);
      Point point220 = point1;
      label11_1.Location = point220;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(21, 13);
      Size size221 = size1;
      label11_2.Size = size221;
      this.Label11.TabIndex = 19;
      this.Label11.Text = "km";
      this.AOPBox.BackColor = SystemColors.Control;
      this.AOPBox.BorderStyle = BorderStyle.None;
      this.AOPBox.ForeColor = Color.Black;
      TextBox aopBox1 = this.AOPBox;
      point1 = new Point(51, 95);
      Point point221 = point1;
      aopBox1.Location = point221;
      this.AOPBox.Name = "AOPBox";
      this.AOPBox.ReadOnly = true;
      TextBox aopBox2 = this.AOPBox;
      size1 = new Size(65, 13);
      Size size222 = size1;
      aopBox2.Size = size222;
      this.AOPBox.TabIndex = 15;
      this.AOPBox.TabStop = false;
      this.AOPBox.TextAlign = HorizontalAlignment.Right;
      this.SMABox.BackColor = SystemColors.Control;
      this.SMABox.BorderStyle = BorderStyle.None;
      this.SMABox.ForeColor = Color.Black;
      TextBox smaBox1 = this.SMABox;
      point1 = new Point(51, 19);
      Point point222 = point1;
      smaBox1.Location = point222;
      this.SMABox.Name = "SMABox";
      this.SMABox.ReadOnly = true;
      TextBox smaBox2 = this.SMABox;
      size1 = new Size(65, 13);
      Size size223 = size1;
      smaBox2.Size = size223;
      this.SMABox.TabIndex = 11;
      this.SMABox.TabStop = false;
      this.SMABox.TextAlign = HorizontalAlignment.Right;
      this.Label3.AutoSize = true;
      this.Label3.BackColor = SystemColors.Control;
      this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label3.ForeColor = Color.Black;
      this.Label3.ImeMode = ImeMode.NoControl;
      Label label3_1 = this.Label3;
      point1 = new Point(6, 19);
      Point point223 = point1;
      label3_1.Location = point223;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(30, 13);
      Size size224 = size1;
      label3_2.Size = size224;
      this.Label3.TabIndex = 3;
      this.Label3.Text = "SMA";
      this.RAANBox.BackColor = SystemColors.Control;
      this.RAANBox.BorderStyle = BorderStyle.None;
      this.RAANBox.ForeColor = Color.Black;
      TextBox raanBox1 = this.RAANBox;
      point1 = new Point(51, 76);
      Point point224 = point1;
      raanBox1.Location = point224;
      this.RAANBox.Name = "RAANBox";
      this.RAANBox.ReadOnly = true;
      TextBox raanBox2 = this.RAANBox;
      size1 = new Size(65, 13);
      Size size225 = size1;
      raanBox2.Size = size225;
      this.RAANBox.TabIndex = 14;
      this.RAANBox.TabStop = false;
      this.RAANBox.TextAlign = HorizontalAlignment.Right;
      this.INCBox.BackColor = SystemColors.Control;
      this.INCBox.BorderStyle = BorderStyle.None;
      this.INCBox.ForeColor = Color.Black;
      TextBox incBox1 = this.INCBox;
      point1 = new Point(51, 57);
      Point point225 = point1;
      incBox1.Location = point225;
      this.INCBox.Name = "INCBox";
      this.INCBox.ReadOnly = true;
      TextBox incBox2 = this.INCBox;
      size1 = new Size(65, 13);
      Size size226 = size1;
      incBox2.Size = size226;
      this.INCBox.TabIndex = 13;
      this.INCBox.TabStop = false;
      this.INCBox.TextAlign = HorizontalAlignment.Right;
      this.Label15.AutoSize = true;
      this.Label15.BackColor = SystemColors.Control;
      this.Label15.ForeColor = Color.Black;
      this.Label15.ImeMode = ImeMode.NoControl;
      Label label15_1 = this.Label15;
      point1 = new Point(122, 114);
      Point point226 = point1;
      label15_1.Location = point226;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(25, 13);
      Size size227 = size1;
      label15_2.Size = size227;
      this.Label15.TabIndex = 58;
      this.Label15.Text = "deg";
      this.ECCBox.BackColor = SystemColors.Control;
      this.ECCBox.BorderStyle = BorderStyle.None;
      this.ECCBox.ForeColor = Color.Black;
      TextBox eccBox1 = this.ECCBox;
      point1 = new Point(51, 38);
      Point point227 = point1;
      eccBox1.Location = point227;
      this.ECCBox.Name = "ECCBox";
      this.ECCBox.ReadOnly = true;
      TextBox eccBox2 = this.ECCBox;
      size1 = new Size(65, 13);
      Size size228 = size1;
      eccBox2.Size = size228;
      this.ECCBox.TabIndex = 12;
      this.ECCBox.TabStop = false;
      this.ECCBox.TextAlign = HorizontalAlignment.Right;
      this.MABox.BackColor = SystemColors.Control;
      this.MABox.BorderStyle = BorderStyle.None;
      this.MABox.ForeColor = Color.Black;
      TextBox maBox1 = this.MABox;
      point1 = new Point(51, 113);
      Point point228 = point1;
      maBox1.Location = point228;
      this.MABox.Name = "MABox";
      this.MABox.ReadOnly = true;
      TextBox maBox2 = this.MABox;
      size1 = new Size(65, 13);
      Size size229 = size1;
      maBox2.Size = size229;
      this.MABox.TabIndex = 57;
      this.MABox.TabStop = false;
      this.MABox.TextAlign = HorizontalAlignment.Right;
      this.Label8.AutoSize = true;
      this.Label8.BackColor = SystemColors.Control;
      this.Label8.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label8.ForeColor = Color.Black;
      this.Label8.ImeMode = ImeMode.NoControl;
      Label label8_1 = this.Label8;
      point1 = new Point(6, 114);
      Point point229 = point1;
      label8_1.Location = point229;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(23, 13);
      Size size230 = size1;
      label8_2.Size = size230;
      this.Label8.TabIndex = 56;
      this.Label8.Text = "MA";
      this.AOP_Label.AutoSize = true;
      this.AOP_Label.BackColor = SystemColors.Control;
      this.AOP_Label.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.AOP_Label.ForeColor = Color.Black;
      this.AOP_Label.ImeMode = ImeMode.NoControl;
      Label aopLabel1 = this.AOP_Label;
      point1 = new Point(6, 95);
      Point point230 = point1;
      aopLabel1.Location = point230;
      this.AOP_Label.Name = "AOP_Label";
      Label aopLabel2 = this.AOP_Label;
      size1 = new Size(29, 13);
      Size size231 = size1;
      aopLabel2.Size = size231;
      this.AOP_Label.TabIndex = 7;
      this.AOP_Label.Text = "AOP";
      this.RAAN_Label.AutoSize = true;
      this.RAAN_Label.BackColor = SystemColors.Control;
      this.RAAN_Label.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.RAAN_Label.ForeColor = Color.Black;
      this.RAAN_Label.ImeMode = ImeMode.NoControl;
      Label raanLabel1 = this.RAAN_Label;
      point1 = new Point(6, 76);
      Point point231 = point1;
      raanLabel1.Location = point231;
      this.RAAN_Label.Name = "RAAN_Label";
      Label raanLabel2 = this.RAAN_Label;
      size1 = new Size(37, 13);
      Size size232 = size1;
      raanLabel2.Size = size232;
      this.RAAN_Label.TabIndex = 6;
      this.RAAN_Label.Text = "RAAN";
      this.Label5.AutoSize = true;
      this.Label5.BackColor = SystemColors.Control;
      this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label5.ForeColor = Color.Black;
      this.Label5.ImeMode = ImeMode.NoControl;
      Label label5_1 = this.Label5;
      point1 = new Point(6, 57);
      Point point232 = point1;
      label5_1.Location = point232;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(25, 13);
      Size size233 = size1;
      label5_2.Size = size233;
      this.Label5.TabIndex = 5;
      this.Label5.Text = "INC";
      this.Label4.AutoSize = true;
      this.Label4.BackColor = SystemColors.Control;
      this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label4.ForeColor = Color.Black;
      this.Label4.ImeMode = ImeMode.NoControl;
      Label label4_1 = this.Label4;
      point1 = new Point(6, 38);
      Point point233 = point1;
      label4_1.Location = point233;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(28, 13);
      Size size234 = size1;
      label4_2.Size = size234;
      this.Label4.TabIndex = 4;
      this.Label4.Text = "ECC";
      this.Timer1.Interval = 1000;
      this.Timer2.Interval = 1000;
      this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
      ToolStripMenuItem toolStripMenuItem3 = this.ToolStripMenuItem3;
      size1 = new Size(170, 22);
      Size size235 = size1;
      toolStripMenuItem3.Size = size235;
      this.ToolStripMenuItem3.Text = "Export";
      this.GoogleEarthMenu.Enabled = false;
      this.GoogleEarthMenu.Name = "GoogleEarthMenu";
      ToolStripMenuItem googleEarthMenu = this.GoogleEarthMenu;
      size1 = new Size(193, 22);
      Size size236 = size1;
      googleEarthMenu.Size = size236;
      this.GoogleEarthMenu.Text = "Google Earth (.kml)";
      this.ToolStrip1.Dock = DockStyle.None;
      this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      this.ToolStrip1.Items.AddRange(new ToolStripItem[19]
      {
        (ToolStripItem) this.ButtonMenu_Personal,
        (ToolStripItem) this.ButtonMenu_Paste,
        (ToolStripItem) this.ButtonMenu_Modify,
        (ToolStripItem) this.ButtonMenu_Import,
        (ToolStripItem) this.ToolStripSeparator7,
        (ToolStripItem) this.ButtonMenu_Report,
        (ToolStripItem) this.ToolStripSeparator5,
        (ToolStripItem) this.ButtonMenu_GMAT,
        (ToolStripItem) this.ButtonMenu_GMAT_M,
        (ToolStripItem) this.ToolStripSeparator6,
        (ToolStripItem) this.ButtonMenu_OpenF,
        (ToolStripItem) this.ToolStripSeparator3,
        (ToolStripItem) this.ButtonMenu_Stations,
        (ToolStripItem) this.ButtonMenu_Charts,
        (ToolStripItem) this.ToolStripSeparator4,
        (ToolStripItem) this.ButtonMenu_Options,
        (ToolStripItem) this.ButtonMenu_About,
        (ToolStripItem) this.ButtonMenu_Help,
        (ToolStripItem) this.ButtonMenu_Exit
      });
      ToolStrip toolStrip1_1 = this.ToolStrip1;
      point1 = new Point(9, 7);
      Point point234 = point1;
      toolStrip1_1.Location = point234;
      this.ToolStrip1.Name = "ToolStrip1";
      ToolStrip toolStrip1_2 = this.ToolStrip1;
      size1 = new Size(355, 25);
      Size size237 = size1;
      toolStrip1_2.Size = size237;
      this.ToolStrip1.TabIndex = 38;
      this.ToolStrip1.Text = "ToolStrip1";
      this.ButtonMenu_Personal.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Personal.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Personal.Image");
      this.ButtonMenu_Personal.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Personal.Name = "ButtonMenu_Personal";
      ToolStripButton buttonMenuPersonal = this.ButtonMenu_Personal;
      size1 = new Size(23, 22);
      Size size238 = size1;
      buttonMenuPersonal.Size = size238;
      this.ButtonMenu_Personal.Text = "Open Personal TLE File";
      this.ButtonMenu_Paste.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Paste.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Paste.Image");
      this.ButtonMenu_Paste.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Paste.Name = "ButtonMenu_Paste";
      ToolStripButton buttonMenuPaste = this.ButtonMenu_Paste;
      size1 = new Size(23, 22);
      Size size239 = size1;
      buttonMenuPaste.Size = size239;
      this.ButtonMenu_Paste.Text = "Paste a TLE";
      this.ButtonMenu_Modify.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Modify.Enabled = false;
      this.ButtonMenu_Modify.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Modify.Image");
      this.ButtonMenu_Modify.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Modify.Name = "ButtonMenu_Modify";
      ToolStripButton buttonMenuModify = this.ButtonMenu_Modify;
      size1 = new Size(23, 22);
      Size size240 = size1;
      buttonMenuModify.Size = size240;
      this.ButtonMenu_Modify.Text = "Modify a TLE";
      this.ButtonMenu_Import.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Import.Enabled = false;
      this.ButtonMenu_Import.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Import.Image");
      this.ButtonMenu_Import.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Import.Name = "ButtonMenu_Import";
      ToolStripButton buttonMenuImport = this.ButtonMenu_Import;
      size1 = new Size(23, 22);
      Size size241 = size1;
      buttonMenuImport.Size = size241;
      this.ButtonMenu_Import.Text = "Import a TLE";
      this.ToolStripSeparator7.Name = "ToolStripSeparator7";
      ToolStripSeparator toolStripSeparator7 = this.ToolStripSeparator7;
      size1 = new Size(6, 25);
      Size size242 = size1;
      toolStripSeparator7.Size = size242;
      this.ButtonMenu_Report.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Report.Enabled = false;
      this.ButtonMenu_Report.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Report.Image");
      this.ButtonMenu_Report.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Report.Name = "ButtonMenu_Report";
      ToolStripButton buttonMenuReport = this.ButtonMenu_Report;
      size1 = new Size(23, 22);
      Size size243 = size1;
      buttonMenuReport.Size = size243;
      this.ButtonMenu_Report.Text = "Report";
      this.ToolStripSeparator5.Name = "ToolStripSeparator5";
      ToolStripSeparator toolStripSeparator5 = this.ToolStripSeparator5;
      size1 = new Size(6, 25);
      Size size244 = size1;
      toolStripSeparator5.Size = size244;
      this.ButtonMenu_GMAT.BackColor = Color.Transparent;
      this.ButtonMenu_GMAT.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_GMAT.Enabled = false;
      this.ButtonMenu_GMAT.Image = (Image) componentResourceManager.GetObject("ButtonMenu_GMAT.Image");
      this.ButtonMenu_GMAT.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_GMAT.Name = "ButtonMenu_GMAT";
      ToolStripButton buttonMenuGmat = this.ButtonMenu_GMAT;
      size1 = new Size(23, 22);
      Size size245 = size1;
      buttonMenuGmat.Size = size245;
      this.ButtonMenu_GMAT.Text = "Export to GMAT";
      this.ButtonMenu_GMAT_M.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_GMAT_M.Enabled = false;
      this.ButtonMenu_GMAT_M.Image = (Image) componentResourceManager.GetObject("ButtonMenu_GMAT_M.Image");
      this.ButtonMenu_GMAT_M.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_GMAT_M.Name = "ButtonMenu_GMAT_M";
      ToolStripButton buttonMenuGmatM = this.ButtonMenu_GMAT_M;
      size1 = new Size(23, 22);
      Size size246 = size1;
      buttonMenuGmatM.Size = size246;
      this.ButtonMenu_GMAT_M.Text = "Export a Fleet to GMAT";
      this.ToolStripSeparator6.Name = "ToolStripSeparator6";
      ToolStripSeparator toolStripSeparator6 = this.ToolStripSeparator6;
      size1 = new Size(6, 25);
      Size size247 = size1;
      toolStripSeparator6.Size = size247;
      this.ButtonMenu_OpenF.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_OpenF.Image = (Image) componentResourceManager.GetObject("ButtonMenu_OpenF.Image");
      this.ButtonMenu_OpenF.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_OpenF.Name = "ButtonMenu_OpenF";
      ToolStripButton buttonMenuOpenF = this.ButtonMenu_OpenF;
      size1 = new Size(23, 22);
      Size size248 = size1;
      buttonMenuOpenF.Size = size248;
      this.ButtonMenu_OpenF.Text = "Open TLEA Folders";
      this.ToolStripSeparator3.Name = "ToolStripSeparator3";
      ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
      size1 = new Size(6, 25);
      Size size249 = size1;
      toolStripSeparator3.Size = size249;
      this.ButtonMenu_Stations.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Stations.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Stations.Image");
      this.ButtonMenu_Stations.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Stations.Name = "ButtonMenu_Stations";
      ToolStripButton buttonMenuStations = this.ButtonMenu_Stations;
      size1 = new Size(23, 22);
      Size size250 = size1;
      buttonMenuStations.Size = size250;
      this.ButtonMenu_Stations.Text = "Ground Stations Management";
      this.ButtonMenu_Charts.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Charts.Enabled = false;
      this.ButtonMenu_Charts.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Charts.Image");
      this.ButtonMenu_Charts.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Charts.Name = "ButtonMenu_Charts";
      ToolStripButton buttonMenuCharts = this.ButtonMenu_Charts;
      size1 = new Size(23, 22);
      Size size251 = size1;
      buttonMenuCharts.Size = size251;
      this.ButtonMenu_Charts.Text = "XY Plots";
      this.ToolStripSeparator4.Name = "ToolStripSeparator4";
      ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator4;
      size1 = new Size(6, 25);
      Size size252 = size1;
      toolStripSeparator4.Size = size252;
      this.ButtonMenu_Options.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Options.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Options.Image");
      this.ButtonMenu_Options.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Options.Name = "ButtonMenu_Options";
      ToolStripButton buttonMenuOptions = this.ButtonMenu_Options;
      size1 = new Size(23, 22);
      Size size253 = size1;
      buttonMenuOptions.Size = size253;
      this.ButtonMenu_Options.Text = "Options";
      this.ButtonMenu_About.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_About.Image = (Image) componentResourceManager.GetObject("ButtonMenu_About.Image");
      this.ButtonMenu_About.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_About.Name = "ButtonMenu_About";
      ToolStripButton buttonMenuAbout = this.ButtonMenu_About;
      size1 = new Size(23, 22);
      Size size254 = size1;
      buttonMenuAbout.Size = size254;
      this.ButtonMenu_About.Text = "About TLE Analyser";
      this.ButtonMenu_Help.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Help.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Help.Image");
      this.ButtonMenu_Help.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Help.Name = "ButtonMenu_Help";
      ToolStripButton buttonMenuHelp = this.ButtonMenu_Help;
      size1 = new Size(23, 22);
      Size size255 = size1;
      buttonMenuHelp.Size = size255;
      this.ButtonMenu_Help.Text = "User Manual";
      this.ButtonMenu_Exit.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ButtonMenu_Exit.Image = (Image) componentResourceManager.GetObject("ButtonMenu_Exit.Image");
      this.ButtonMenu_Exit.ImageTransparentColor = Color.Magenta;
      this.ButtonMenu_Exit.Name = "ButtonMenu_Exit";
      ToolStripButton buttonMenuExit = this.ButtonMenu_Exit;
      size1 = new Size(23, 22);
      Size size256 = size1;
      buttonMenuExit.Size = size256;
      this.ButtonMenu_Exit.Text = "Exit";
      this.AN_Group.Controls.Add((Control) this.DNButton);
      this.AN_Group.Controls.Add((Control) this.ANButton);
      this.AN_Group.Controls.Add((Control) this.LAN_Label);
      this.AN_Group.Controls.Add((Control) this.LANType);
      this.AN_Group.Controls.Add((Control) this.LANBox);
      this.AN_Group.Controls.Add((Control) this.LNLabel);
      this.AN_Group.Controls.Add((Control) this.LTANBox);
      this.AN_Group.Controls.Add((Control) this.LTLabel);
      GroupBox anGroup1 = this.AN_Group;
      point1 = new Point(167, 372);
      Point point235 = point1;
      anGroup1.Location = point235;
      this.AN_Group.Name = "AN_Group";
      GroupBox anGroup2 = this.AN_Group;
      size1 = new Size(178, 85);
      Size size257 = size1;
      anGroup2.Size = size257;
      this.AN_Group.TabIndex = 64;
      this.AN_Group.TabStop = false;
      this.AN_Group.Text = "Line of Nodes";
      this.DNButton.AutoSize = true;
      RadioButton dnButton1 = this.DNButton;
      point1 = new Point(91, 63);
      Point point236 = point1;
      dnButton1.Location = point236;
      this.DNButton.Name = "DNButton";
      RadioButton dnButton2 = this.DNButton;
      size1 = new Size(41, 17);
      Size size258 = size1;
      dnButton2.Size = size258;
      this.DNButton.TabIndex = 76;
      this.DNButton.Text = "DN";
      this.DNButton.UseVisualStyleBackColor = true;
      this.ANButton.AutoSize = true;
      this.ANButton.Checked = true;
      RadioButton anButton1 = this.ANButton;
      point1 = new Point(45, 63);
      Point point237 = point1;
      anButton1.Location = point237;
      this.ANButton.Name = "ANButton";
      RadioButton anButton2 = this.ANButton;
      size1 = new Size(40, 17);
      Size size259 = size1;
      anButton2.Size = size259;
      this.ANButton.TabIndex = 75;
      this.ANButton.TabStop = true;
      this.ANButton.Text = "AN";
      this.ANButton.UseVisualStyleBackColor = true;
      this.LAN_Label.AutoSize = true;
      this.LAN_Label.ImeMode = ImeMode.NoControl;
      this.LAN_Label.LinkBehavior = LinkBehavior.NeverUnderline;
      LinkLabel lanLabel1 = this.LAN_Label;
      point1 = new Point(130, 23);
      Point point238 = point1;
      lanLabel1.Location = point238;
      this.LAN_Label.Name = "LAN_Label";
      LinkLabel lanLabel2 = this.LAN_Label;
      size1 = new Size(25, 13);
      Size size260 = size1;
      lanLabel2.Size = size260;
      this.LAN_Label.TabIndex = 74;
      this.LAN_Label.TabStop = true;
      this.LAN_Label.Text = "deg";
      this.LANType.AutoSize = true;
      this.LANType.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.LANType.ImeMode = ImeMode.NoControl;
      Label lanType1 = this.LANType;
      point1 = new Point(131, -3);
      Point point239 = point1;
      lanType1.Location = point239;
      this.LANType.Name = "LANType";
      Label lanType2 = this.LANType;
      size1 = new Size(47, 12);
      Size size261 = size1;
      lanType2.Size = size261;
      this.LANType.TabIndex = 66;
      this.LANType.Text = "[-180;180]";
      this.LANType.Visible = false;
      this.LANBox.BackColor = SystemColors.Control;
      this.LANBox.BorderStyle = BorderStyle.None;
      TextBox lanBox1 = this.LANBox;
      point1 = new Point(56, 23);
      Point point240 = point1;
      lanBox1.Location = point240;
      this.LANBox.Name = "LANBox";
      this.LANBox.ReadOnly = true;
      TextBox lanBox2 = this.LANBox;
      size1 = new Size(65, 13);
      Size size262 = size1;
      lanBox2.Size = size262;
      this.LANBox.TabIndex = 35;
      this.LANBox.TextAlign = HorizontalAlignment.Right;
      this.LNLabel.AutoSize = true;
      this.LNLabel.ImeMode = ImeMode.NoControl;
      Label lnLabel1 = this.LNLabel;
      point1 = new Point(6, 23);
      Point point241 = point1;
      lnLabel1.Location = point241;
      this.LNLabel.Name = "LNLabel";
      Label lnLabel2 = this.LNLabel;
      size1 = new Size(28, 13);
      Size size263 = size1;
      lnLabel2.Size = size263;
      this.LNLabel.TabIndex = 36;
      this.LNLabel.Text = "LAN";
      this.LTANBox.BackColor = SystemColors.Control;
      this.LTANBox.BorderStyle = BorderStyle.None;
      TextBox ltanBox1 = this.LTANBox;
      point1 = new Point(54, 42);
      Point point242 = point1;
      ltanBox1.Location = point242;
      this.LTANBox.Name = "LTANBox";
      this.LTANBox.ReadOnly = true;
      TextBox ltanBox2 = this.LTANBox;
      size1 = new Size(94, 13);
      Size size264 = size1;
      ltanBox2.Size = size264;
      this.LTANBox.TabIndex = 33;
      this.LTANBox.TextAlign = HorizontalAlignment.Right;
      this.LTLabel.AutoSize = true;
      this.LTLabel.ImeMode = ImeMode.NoControl;
      Label ltLabel1 = this.LTLabel;
      point1 = new Point(6, 44);
      Point point243 = point1;
      ltLabel1.Location = point243;
      this.LTLabel.Name = "LTLabel";
      Label ltLabel2 = this.LTLabel;
      size1 = new Size(35, 13);
      Size size265 = size1;
      ltLabel2.Size = size265;
      this.LTLabel.TabIndex = 34;
      this.LTLabel.Text = "LTAN";
      this.TLE_MainPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
      this.TLE_MainPage.Controls.Add((Control) this.TLE_ElementsTab);
      this.TLE_MainPage.Controls.Add((Control) this.TLE_DetailsTab);
      this.TLE_MainPage.Controls.Add((Control) this.TLE_StationsTab);
      this.TLE_MainPage.Controls.Add((Control) this.OrbitWizardTab);
      TabControl tleMainPage1 = this.TLE_MainPage;
      size1 = new Size(90, 15);
      Size size266 = size1;
      tleMainPage1.ItemSize = size266;
      TabControl tleMainPage2 = this.TLE_MainPage;
      point1 = new Point(940, 25);
      Point point244 = point1;
      tleMainPage2.Location = point244;
      this.TLE_MainPage.Name = "TLE_MainPage";
      this.TLE_MainPage.SelectedIndex = 0;
      TabControl tleMainPage3 = this.TLE_MainPage;
      size1 = new Size(386, 793);
      Size size267 = size1;
      tleMainPage3.Size = size267;
      this.TLE_MainPage.SizeMode = TabSizeMode.Fixed;
      this.TLE_MainPage.TabIndex = 101;
      this.TLE_ElementsTab.BackColor = SystemColors.Control;
      this.TLE_ElementsTab.Controls.Add((Control) this.GroupBox10);
      this.TLE_ElementsTab.Controls.Add((Control) this.KeplerElementsFrame);
      this.TLE_ElementsTab.Controls.Add((Control) this.GroupBox8);
      this.TLE_ElementsTab.Controls.Add((Control) this.GroupBox6);
      this.TLE_ElementsTab.Controls.Add((Control) this.AN_Group);
      this.TLE_ElementsTab.Controls.Add((Control) this.GroupBox9);
      this.TLE_ElementsTab.Controls.Add((Control) this.CartesianElementsFrame);
      this.TLE_ElementsTab.Controls.Add((Control) this.GroupBox3);
      this.TLE_ElementsTab.Controls.Add((Control) this.AP_GroupBox);
      this.TLE_ElementsTab.Controls.Add((Control) this.GroupBox7);
      TabPage tleElementsTab1 = this.TLE_ElementsTab;
      point1 = new Point(4, 19);
      Point point245 = point1;
      tleElementsTab1.Location = point245;
      this.TLE_ElementsTab.Name = "TLE_ElementsTab";
      TabPage tleElementsTab2 = this.TLE_ElementsTab;
      padding1 = new Padding(3);
      Padding padding10 = padding1;
      tleElementsTab2.Padding = padding10;
      TabPage tleElementsTab3 = this.TLE_ElementsTab;
      size1 = new Size(378, 770);
      Size size268 = size1;
      tleElementsTab3.Size = size268;
      this.TLE_ElementsTab.TabIndex = 1;
      this.TLE_ElementsTab.Text = "Elements";
      this.GroupBox10.Controls.Add((Control) this.Label134);
      this.GroupBox10.Controls.Add((Control) this.GSTBox);
      this.GroupBox10.Controls.Add((Control) this.OrbNumBox);
      this.GroupBox10.Controls.Add((Control) this.Label133);
      this.GroupBox10.Controls.Add((Control) this.Label155);
      this.GroupBox10.Controls.Add((Control) this.Label1);
      this.GroupBox10.Controls.Add((Control) this.Label2);
      this.GroupBox10.Controls.Add((Control) this.EclipseBox);
      this.GroupBox10.Controls.Add((Control) this.LSTBox);
      this.GroupBox10.Controls.Add((Control) this.Label156);
      GroupBox groupBox10_1 = this.GroupBox10;
      point1 = new Point(8, 585);
      Point point246 = point1;
      groupBox10_1.Location = point246;
      this.GroupBox10.Name = "GroupBox10";
      GroupBox groupBox10_2 = this.GroupBox10;
      size1 = new Size(153, 123);
      Size size269 = size1;
      groupBox10_2.Size = size269;
      this.GroupBox10.TabIndex = 78;
      this.GroupBox10.TabStop = false;
      this.GroupBox10.Text = "Miscellaneous";
      this.TLE_DetailsTab.BackColor = SystemColors.Control;
      this.TLE_DetailsTab.Controls.Add((Control) this.Raw_Data_GridView);
      TabPage tleDetailsTab1 = this.TLE_DetailsTab;
      point1 = new Point(4, 19);
      Point point247 = point1;
      tleDetailsTab1.Location = point247;
      this.TLE_DetailsTab.Name = "TLE_DetailsTab";
      TabPage tleDetailsTab2 = this.TLE_DetailsTab;
      padding1 = new Padding(3);
      Padding padding11 = padding1;
      tleDetailsTab2.Padding = padding11;
      TabPage tleDetailsTab3 = this.TLE_DetailsTab;
      size1 = new Size(378, 770);
      Size size270 = size1;
      tleDetailsTab3.Size = size270;
      this.TLE_DetailsTab.TabIndex = 2;
      this.TLE_DetailsTab.Text = "Raw Datas";
      this.Raw_Data_GridView.AllowUserToAddRows = false;
      this.Raw_Data_GridView.AllowUserToDeleteRows = false;
      this.Raw_Data_GridView.BackgroundColor = SystemColors.Control;
      this.Raw_Data_GridView.BorderStyle = BorderStyle.None;
      this.Raw_Data_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.Raw_Data_GridView.Columns.AddRange((DataGridViewColumn) this.Line, (DataGridViewColumn) this.Column, (DataGridViewColumn) this.Value, (DataGridViewColumn) this.Description);
      this.Raw_Data_GridView.EditMode = DataGridViewEditMode.EditProgrammatically;
      DataGridView rawDataGridView1 = this.Raw_Data_GridView;
      point1 = new Point(6, 6);
      Point point248 = point1;
      rawDataGridView1.Location = point248;
      this.Raw_Data_GridView.Name = "Raw_Data_GridView";
      this.Raw_Data_GridView.ReadOnly = true;
      this.Raw_Data_GridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Raw_Data_GridView.RowsDefaultCellStyle = gridViewCellStyle1;
      DataGridView rawDataGridView2 = this.Raw_Data_GridView;
      size1 = new Size(366, 565);
      Size size271 = size1;
      rawDataGridView2.Size = size271;
      this.Raw_Data_GridView.TabIndex = 100;
      this.Line.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Line.DefaultCellStyle = gridViewCellStyle2;
      this.Line.HeaderText = "Line";
      this.Line.Name = "Line";
      this.Line.ReadOnly = true;
      this.Line.Width = 52;
      this.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.Column.DefaultCellStyle = gridViewCellStyle3;
      this.Column.HeaderText = "Column";
      this.Column.Name = "Column";
      this.Column.ReadOnly = true;
      this.Column.Width = 67;
      this.Value.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.Value.DefaultCellStyle = gridViewCellStyle4;
      this.Value.HeaderText = "Value";
      this.Value.Name = "Value";
      this.Value.ReadOnly = true;
      this.Value.Width = 59;
      this.Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 6.75f);
      this.Description.DefaultCellStyle = gridViewCellStyle5;
      this.Description.HeaderText = "Description";
      this.Description.Name = "Description";
      this.Description.ReadOnly = true;
      this.Description.Width = 85;
      this.TLE_StationsTab.BackColor = SystemColors.Control;
      this.TLE_StationsTab.Controls.Add((Control) this.GroupBox5);
      this.TLE_StationsTab.Controls.Add((Control) this.GroupBox4);
      this.TLE_StationsTab.Controls.Add((Control) this.Stations_datas_2);
      this.TLE_StationsTab.Controls.Add((Control) this.Stations_datas_1);
      TabPage tleStationsTab1 = this.TLE_StationsTab;
      point1 = new Point(4, 19);
      Point point249 = point1;
      tleStationsTab1.Location = point249;
      this.TLE_StationsTab.Name = "TLE_StationsTab";
      TabPage tleStationsTab2 = this.TLE_StationsTab;
      padding1 = new Padding(3);
      Padding padding12 = padding1;
      tleStationsTab2.Padding = padding12;
      TabPage tleStationsTab3 = this.TLE_StationsTab;
      size1 = new Size(378, 770);
      Size size272 = size1;
      tleStationsTab3.Size = size272;
      this.TLE_StationsTab.TabIndex = 3;
      this.TLE_StationsTab.Text = "Ground Stations";
      this.GroupBox5.Controls.Add((Control) this.GS_El_Link);
      this.GroupBox5.Controls.Add((Control) this.GS_Az_Link);
      this.GroupBox5.Controls.Add((Control) this.Label105);
      this.GroupBox5.Controls.Add((Control) this.Stations_dist);
      this.GroupBox5.Controls.Add((Control) this.Label64);
      this.GroupBox5.Controls.Add((Control) this.Stations_el);
      this.GroupBox5.Controls.Add((Control) this.Label63);
      this.GroupBox5.Controls.Add((Control) this.Stations_az);
      this.GroupBox5.Controls.Add((Control) this.Label62);
      GroupBox groupBox5_1 = this.GroupBox5;
      point1 = new Point(6, 120);
      Point point250 = point1;
      groupBox5_1.Location = point250;
      this.GroupBox5.Name = "GroupBox5";
      GroupBox groupBox5_2 = this.GroupBox5;
      size1 = new Size(342, 76);
      Size size273 = size1;
      groupBox5_2.Size = size273;
      this.GroupBox5.TabIndex = 78;
      this.GroupBox5.TabStop = false;
      this.GS_El_Link.AutoSize = true;
      this.GS_El_Link.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.GS_El_Link.ImeMode = ImeMode.NoControl;
      this.GS_El_Link.LinkBehavior = LinkBehavior.NeverUnderline;
      this.GS_El_Link.LinkColor = Color.Blue;
      LinkLabel gsElLink1 = this.GS_El_Link;
      point1 = new Point(161, 34);
      Point point251 = point1;
      gsElLink1.Location = point251;
      this.GS_El_Link.Name = "GS_El_Link";
      LinkLabel gsElLink2 = this.GS_El_Link;
      size1 = new Size(26, 13);
      Size size274 = size1;
      gsElLink2.Size = size274;
      this.GS_El_Link.TabIndex = 105;
      this.GS_El_Link.TabStop = true;
      this.GS_El_Link.Text = "dms";
      this.GS_Az_Link.AutoSize = true;
      this.GS_Az_Link.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.GS_Az_Link.ImeMode = ImeMode.NoControl;
      this.GS_Az_Link.LinkBehavior = LinkBehavior.NeverUnderline;
      this.GS_Az_Link.LinkColor = Color.Blue;
      LinkLabel gsAzLink1 = this.GS_Az_Link;
      point1 = new Point(161, 16);
      Point point252 = point1;
      gsAzLink1.Location = point252;
      this.GS_Az_Link.Name = "GS_Az_Link";
      LinkLabel gsAzLink2 = this.GS_Az_Link;
      size1 = new Size(26, 13);
      Size size275 = size1;
      gsAzLink2.Size = size275;
      this.GS_Az_Link.TabIndex = 104;
      this.GS_Az_Link.TabStop = true;
      this.GS_Az_Link.Text = "dms";
      this.Label105.AutoSize = true;
      this.Label105.BackColor = SystemColors.Control;
      this.Label105.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label105.ForeColor = Color.Black;
      this.Label105.ImeMode = ImeMode.NoControl;
      Label label105_1 = this.Label105;
      point1 = new Point(161, 54);
      Point point253 = point1;
      label105_1.Location = point253;
      this.Label105.Name = "Label105";
      Label label105_2 = this.Label105;
      size1 = new Size(26, 13);
      Size size276 = size1;
      label105_2.Size = size276;
      this.Label105.TabIndex = 103;
      this.Label105.Text = "kms";
      this.Stations_dist.BackColor = SystemColors.Control;
      this.Stations_dist.BorderStyle = BorderStyle.None;
      this.Stations_dist.ForeColor = Color.Black;
      TextBox stationsDist1 = this.Stations_dist;
      point1 = new Point(90, 53);
      Point point254 = point1;
      stationsDist1.Location = point254;
      this.Stations_dist.Name = "Stations_dist";
      this.Stations_dist.ReadOnly = true;
      TextBox stationsDist2 = this.Stations_dist;
      size1 = new Size(65, 13);
      Size size277 = size1;
      stationsDist2.Size = size277;
      this.Stations_dist.TabIndex = 100;
      this.Stations_dist.TabStop = false;
      this.Stations_dist.TextAlign = HorizontalAlignment.Right;
      this.Label64.AutoSize = true;
      this.Label64.BackColor = SystemColors.Control;
      this.Label64.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label64.ForeColor = Color.Black;
      this.Label64.ImeMode = ImeMode.NoControl;
      Label label64_1 = this.Label64;
      point1 = new Point(6, 54);
      Point point255 = point1;
      label64_1.Location = point255;
      this.Label64.Name = "Label64";
      Label label64_2 = this.Label64;
      size1 = new Size(49, 13);
      Size size278 = size1;
      label64_2.Size = size278;
      this.Label64.TabIndex = 99;
      this.Label64.Text = "Distance";
      this.Stations_el.BackColor = SystemColors.Control;
      this.Stations_el.BorderStyle = BorderStyle.None;
      this.Stations_el.ForeColor = Color.Black;
      TextBox stationsEl1 = this.Stations_el;
      point1 = new Point(90, 34);
      Point point256 = point1;
      stationsEl1.Location = point256;
      this.Stations_el.Name = "Stations_el";
      this.Stations_el.ReadOnly = true;
      TextBox stationsEl2 = this.Stations_el;
      size1 = new Size(65, 13);
      Size size279 = size1;
      stationsEl2.Size = size279;
      this.Stations_el.TabIndex = 98;
      this.Stations_el.TabStop = false;
      this.Stations_el.TextAlign = HorizontalAlignment.Right;
      this.Label63.AutoSize = true;
      this.Label63.BackColor = SystemColors.Control;
      this.Label63.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label63.ForeColor = Color.Black;
      this.Label63.ImeMode = ImeMode.NoControl;
      Label label63_1 = this.Label63;
      point1 = new Point(6, 35);
      Point point257 = point1;
      label63_1.Location = point257;
      this.Label63.Name = "Label63";
      Label label63_2 = this.Label63;
      size1 = new Size(51, 13);
      Size size280 = size1;
      label63_2.Size = size280;
      this.Label63.TabIndex = 97;
      this.Label63.Text = "Elevation";
      this.Stations_az.BackColor = SystemColors.Control;
      this.Stations_az.BorderStyle = BorderStyle.None;
      this.Stations_az.ForeColor = Color.Black;
      TextBox stationsAz1 = this.Stations_az;
      point1 = new Point(90, 15);
      Point point258 = point1;
      stationsAz1.Location = point258;
      this.Stations_az.Name = "Stations_az";
      this.Stations_az.ReadOnly = true;
      TextBox stationsAz2 = this.Stations_az;
      size1 = new Size(65, 13);
      Size size281 = size1;
      stationsAz2.Size = size281;
      this.Stations_az.TabIndex = 96;
      this.Stations_az.TabStop = false;
      this.Stations_az.TextAlign = HorizontalAlignment.Right;
      this.Label62.AutoSize = true;
      this.Label62.BackColor = SystemColors.Control;
      this.Label62.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label62.ForeColor = Color.Black;
      this.Label62.ImeMode = ImeMode.NoControl;
      Label label62_1 = this.Label62;
      point1 = new Point(6, 16);
      Point point259 = point1;
      label62_1.Location = point259;
      this.Label62.Name = "Label62";
      Label label62_2 = this.Label62;
      size1 = new Size(38, 13);
      Size size282 = size1;
      label62_2.Size = size282;
      this.Label62.TabIndex = 95;
      this.Label62.Text = "Azimut";
      this.GroupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.GroupBox4.Controls.Add((Control) this.radarPicture);
      this.GroupBox4.Controls.Add((Control) this.GS_CheckAll_CB);
      this.GroupBox4.Controls.Add((Control) this.GS_ListBox);
      GroupBox groupBox4_1 = this.GroupBox4;
      point1 = new Point(6, 303);
      Point point260 = point1;
      groupBox4_1.Location = point260;
      this.GroupBox4.Name = "GroupBox4";
      GroupBox groupBox4_2 = this.GroupBox4;
      size1 = new Size(343, 397);
      Size size283 = size1;
      groupBox4_2.Size = size283;
      this.GroupBox4.TabIndex = 77;
      this.GroupBox4.TabStop = false;
      PictureBox radarPicture1 = this.radarPicture;
      point1 = new Point(182, 19);
      Point point261 = point1;
      radarPicture1.Location = point261;
      this.radarPicture.Name = "radarPicture";
      PictureBox radarPicture2 = this.radarPicture;
      size1 = new Size(153, 153);
      Size size284 = size1;
      radarPicture2.Size = size284;
      this.radarPicture.TabIndex = 0;
      this.radarPicture.TabStop = false;
      this.GS_CheckAll_CB.AutoSize = true;
      this.GS_CheckAll_CB.ImeMode = ImeMode.NoControl;
      CheckBox gsCheckAllCb1 = this.GS_CheckAll_CB;
      point1 = new Point(182, 367);
      Point point262 = point1;
      gsCheckAllCb1.Location = point262;
      this.GS_CheckAll_CB.Name = "GS_CheckAll_CB";
      CheckBox gsCheckAllCb2 = this.GS_CheckAll_CB;
      size1 = new Size(120, 17);
      Size size285 = size1;
      gsCheckAllCb2.Size = size285;
      this.GS_CheckAll_CB.TabIndex = 105;
      this.GS_CheckAll_CB.Text = "Check/Uncheck All";
      this.GS_CheckAll_CB.UseVisualStyleBackColor = true;
      this.GS_ListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.GS_ListBox.BackColor = SystemColors.Window;
      this.GS_ListBox.CheckOnClick = true;
      this.GS_ListBox.Enabled = false;
      this.GS_ListBox.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.GS_ListBox.FormattingEnabled = true;
      CheckedListBox gsListBox1 = this.GS_ListBox;
      point1 = new Point(6, 20);
      Point point263 = point1;
      gsListBox1.Location = point263;
      this.GS_ListBox.Name = "GS_ListBox";
      CheckedListBox gsListBox2 = this.GS_ListBox;
      size1 = new Size(170, 364);
      Size size286 = size1;
      gsListBox2.Size = size286;
      this.GS_ListBox.TabIndex = 103;
      this.Stations_datas_2.Controls.Add((Control) this.GS_Actualise);
      this.Stations_datas_2.Controls.Add((Control) this.GS_ProgressBar);
      this.Stations_datas_2.Controls.Add((Control) this.Stations_Off);
      this.Stations_datas_2.Controls.Add((Control) this.Stations_On);
      this.Stations_datas_2.Controls.Add((Control) this.Stations_duration);
      this.Stations_datas_2.Controls.Add((Control) this.Label61);
      this.Stations_datas_2.Controls.Add((Control) this.Stations_end);
      this.Stations_datas_2.Controls.Add((Control) this.Label60);
      this.Stations_datas_2.Controls.Add((Control) this.Stations_remTime);
      this.Stations_datas_2.Controls.Add((Control) this.Label59);
      this.Stations_datas_2.Controls.Add((Control) this.Stations_start);
      this.Stations_datas_2.Controls.Add((Control) this.Label58);
      GroupBox stationsDatas2_1 = this.Stations_datas_2;
      point1 = new Point(6, 202);
      Point point264 = point1;
      stationsDatas2_1.Location = point264;
      this.Stations_datas_2.Name = "Stations_datas_2";
      GroupBox stationsDatas2_2 = this.Stations_datas_2;
      size1 = new Size(343, 95);
      Size size287 = size1;
      stationsDatas2_2.Size = size287;
      this.Stations_datas_2.TabIndex = 76;
      this.Stations_datas_2.TabStop = false;
      this.GS_Actualise.BackColor = Color.Transparent;
      this.GS_Actualise.Image = (Image) componentResourceManager.GetObject("GS_Actualise.Image");
      this.GS_Actualise.ImeMode = ImeMode.NoControl;
      Button gsActualise1 = this.GS_Actualise;
      point1 = new Point(311, 60);
      Point point265 = point1;
      gsActualise1.Location = point265;
      this.GS_Actualise.Name = "GS_Actualise";
      Button gsActualise2 = this.GS_Actualise;
      size1 = new Size(24, 24);
      Size size288 = size1;
      gsActualise2.Size = size288;
      this.GS_Actualise.TabIndex = 105;
      this.GS_Actualise.UseVisualStyleBackColor = false;
      ProgressBar gsProgressBar1 = this.GS_ProgressBar;
      point1 = new Point(204, 71);
      Point point266 = point1;
      gsProgressBar1.Location = point266;
      this.GS_ProgressBar.Name = "GS_ProgressBar";
      ProgressBar gsProgressBar2 = this.GS_ProgressBar;
      size1 = new Size(102, 13);
      Size size289 = size1;
      gsProgressBar2.Size = size289;
      this.GS_ProgressBar.TabIndex = 91;
      this.GS_ProgressBar.Visible = false;
      this.Stations_Off.Image = (Image) componentResourceManager.GetObject("Stations_Off.Image");
      PictureBox stationsOff1 = this.Stations_Off;
      point1 = new Point(320, 16);
      Point point267 = point1;
      stationsOff1.Location = point267;
      this.Stations_Off.Name = "Stations_Off";
      PictureBox stationsOff2 = this.Stations_Off;
      size1 = new Size(16, 16);
      Size size290 = size1;
      stationsOff2.Size = size290;
      this.Stations_Off.TabIndex = 90;
      this.Stations_Off.TabStop = false;
      this.Stations_On.Image = (Image) componentResourceManager.GetObject("Stations_On.Image");
      PictureBox stationsOn1 = this.Stations_On;
      point1 = new Point(320, 16);
      Point point268 = point1;
      stationsOn1.Location = point268;
      this.Stations_On.Name = "Stations_On";
      PictureBox stationsOn2 = this.Stations_On;
      size1 = new Size(16, 16);
      Size size291 = size1;
      stationsOn2.Size = size291;
      this.Stations_On.TabIndex = 89;
      this.Stations_On.TabStop = false;
      this.Stations_duration.BackColor = SystemColors.Control;
      this.Stations_duration.BorderStyle = BorderStyle.None;
      this.Stations_duration.ForeColor = Color.Black;
      TextBox stationsDuration1 = this.Stations_duration;
      point1 = new Point(90, 52);
      Point point269 = point1;
      stationsDuration1.Location = point269;
      this.Stations_duration.Name = "Stations_duration";
      this.Stations_duration.ReadOnly = true;
      TextBox stationsDuration2 = this.Stations_duration;
      size1 = new Size(65, 13);
      Size size292 = size1;
      stationsDuration2.Size = size292;
      this.Stations_duration.TabIndex = 80;
      this.Stations_duration.TabStop = false;
      this.Label61.AutoSize = true;
      this.Label61.BackColor = SystemColors.Control;
      this.Label61.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label61.ForeColor = Color.Black;
      this.Label61.ImeMode = ImeMode.NoControl;
      Label label61_1 = this.Label61;
      point1 = new Point(6, 53);
      Point point270 = point1;
      label61_1.Location = point270;
      this.Label61.Name = "Label61";
      Label label61_2 = this.Label61;
      size1 = new Size(47, 13);
      Size size293 = size1;
      label61_2.Size = size293;
      this.Label61.TabIndex = 79;
      this.Label61.Text = "Duration";
      this.Stations_end.BackColor = SystemColors.Control;
      this.Stations_end.BorderStyle = BorderStyle.None;
      this.Stations_end.ForeColor = Color.Black;
      TextBox stationsEnd1 = this.Stations_end;
      point1 = new Point(90, 33);
      Point point271 = point1;
      stationsEnd1.Location = point271;
      this.Stations_end.Name = "Stations_end";
      this.Stations_end.ReadOnly = true;
      TextBox stationsEnd2 = this.Stations_end;
      size1 = new Size(140, 13);
      Size size294 = size1;
      stationsEnd2.Size = size294;
      this.Stations_end.TabIndex = 78;
      this.Stations_end.TabStop = false;
      this.Label60.AutoSize = true;
      this.Label60.BackColor = SystemColors.Control;
      this.Label60.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label60.ForeColor = Color.Black;
      this.Label60.ImeMode = ImeMode.NoControl;
      Label label60_1 = this.Label60;
      point1 = new Point(6, 34);
      Point point272 = point1;
      label60_1.Location = point272;
      this.Label60.Name = "Label60";
      Label label60_2 = this.Label60;
      size1 = new Size(26, 13);
      Size size295 = size1;
      label60_2.Size = size295;
      this.Label60.TabIndex = 77;
      this.Label60.Text = "End";
      this.Stations_remTime.BackColor = SystemColors.Control;
      this.Stations_remTime.BorderStyle = BorderStyle.None;
      this.Stations_remTime.ForeColor = Color.Black;
      TextBox stationsRemTime1 = this.Stations_remTime;
      point1 = new Point(90, 71);
      Point point273 = point1;
      stationsRemTime1.Location = point273;
      this.Stations_remTime.Name = "Stations_remTime";
      this.Stations_remTime.ReadOnly = true;
      TextBox stationsRemTime2 = this.Stations_remTime;
      size1 = new Size(65, 13);
      Size size296 = size1;
      stationsRemTime2.Size = size296;
      this.Stations_remTime.TabIndex = 76;
      this.Stations_remTime.TabStop = false;
      this.Label59.AutoSize = true;
      this.Label59.BackColor = SystemColors.Control;
      this.Label59.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label59.ForeColor = Color.Black;
      this.Label59.ImeMode = ImeMode.NoControl;
      Label label59_1 = this.Label59;
      point1 = new Point(6, 72);
      Point point274 = point1;
      label59_1.Location = point274;
      this.Label59.Name = "Label59";
      Label label59_2 = this.Label59;
      size1 = new Size(83, 13);
      Size size297 = size1;
      label59_2.Size = size297;
      this.Label59.TabIndex = 75;
      this.Label59.Text = "Remaining Time";
      this.Stations_start.BackColor = SystemColors.Control;
      this.Stations_start.BorderStyle = BorderStyle.None;
      this.Stations_start.ForeColor = Color.Black;
      TextBox stationsStart1 = this.Stations_start;
      point1 = new Point(90, 14);
      Point point275 = point1;
      stationsStart1.Location = point275;
      this.Stations_start.Name = "Stations_start";
      this.Stations_start.ReadOnly = true;
      TextBox stationsStart2 = this.Stations_start;
      size1 = new Size(140, 13);
      Size size298 = size1;
      stationsStart2.Size = size298;
      this.Stations_start.TabIndex = 74;
      this.Stations_start.TabStop = false;
      this.Label58.AutoSize = true;
      this.Label58.BackColor = SystemColors.Control;
      this.Label58.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label58.ForeColor = Color.Black;
      this.Label58.ImeMode = ImeMode.NoControl;
      Label label58_1 = this.Label58;
      point1 = new Point(6, 15);
      Point point276 = point1;
      label58_1.Location = point276;
      this.Label58.Name = "Label58";
      Label label58_2 = this.Label58;
      size1 = new Size(29, 13);
      Size size299 = size1;
      label58_2.Size = size299;
      this.Label58.TabIndex = 73;
      this.Label58.Text = "Start";
      this.Stations_datas_1.Controls.Add((Control) this.Label106);
      this.Stations_datas_1.Controls.Add((Control) this.Label108);
      this.Stations_datas_1.Controls.Add((Control) this.GS_Antenna_Limit);
      this.Stations_datas_1.Controls.Add((Control) this.Label18);
      this.Stations_datas_1.Controls.Add((Control) this.Stations_list);
      this.Stations_datas_1.Controls.Add((Control) this.Label21);
      this.Stations_datas_1.Controls.Add((Control) this.Label57);
      this.Stations_datas_1.Controls.Add((Control) this.Stations_lng);
      this.Stations_datas_1.Controls.Add((Control) this.Label56);
      this.Stations_datas_1.Controls.Add((Control) this.Label29);
      this.Stations_datas_1.Controls.Add((Control) this.Label55);
      this.Stations_datas_1.Controls.Add((Control) this.Stations_lat);
      this.Stations_datas_1.Controls.Add((Control) this.Stations_alt);
      this.Stations_datas_1.Controls.Add((Control) this.Label41);
      GroupBox stationsDatas1_1 = this.Stations_datas_1;
      point1 = new Point(6, 6);
      Point point277 = point1;
      stationsDatas1_1.Location = point277;
      this.Stations_datas_1.Name = "Stations_datas_1";
      GroupBox stationsDatas1_2 = this.Stations_datas_1;
      size1 = new Size(343, 108);
      Size size300 = size1;
      stationsDatas1_2.Size = size300;
      this.Stations_datas_1.TabIndex = 75;
      this.Stations_datas_1.TabStop = false;
      this.Label106.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Label106.AutoSize = true;
      this.Label106.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label106.ImeMode = ImeMode.NoControl;
      Label label106_1 = this.Label106;
      point1 = new Point(312, 16);
      Point point278 = point1;
      label106_1.Location = point278;
      this.Label106.Name = "Label106";
      Label label106_2 = this.Label106;
      size1 = new Size(25, 13);
      Size size301 = size1;
      label106_2.Size = size301;
      this.Label106.TabIndex = 80;
      this.Label106.Text = "deg";
      this.Label108.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.Label108.AutoSize = true;
      this.Label108.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label108.ImeMode = ImeMode.NoControl;
      Label label108_1 = this.Label108;
      point1 = new Point(234, 16);
      Point point279 = point1;
      label108_1.Location = point279;
      this.Label108.Name = "Label108";
      Label label108_2 = this.Label108;
      size1 = new Size(30, 13);
      Size size302 = size1;
      label108_2.Size = size302;
      this.Label108.TabIndex = 79;
      this.Label108.Text = "AEL:";
      this.GS_Antenna_Limit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
      point1 = new Point(270, 13);
      Point point280 = point1;
      gsAntennaLimit1.Location = point280;
      this.GS_Antenna_Limit.Name = "GS_Antenna_Limit";
      ComboBox gsAntennaLimit2 = this.GS_Antenna_Limit;
      size1 = new Size(36, 21);
      Size size303 = size1;
      gsAntennaLimit2.Size = size303;
      this.GS_Antenna_Limit.TabIndex = 78;
      this.Label18.AutoSize = true;
      this.Label18.ImeMode = ImeMode.NoControl;
      Label label18_1 = this.Label18;
      point1 = new Point(6, 16);
      Point point281 = point1;
      label18_1.Location = point281;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(78, 13);
      Size size304 = size1;
      label18_2.Size = size304;
      this.Label18.TabIndex = 63;
      this.Label18.Text = "Ground Station";
      this.Stations_list.BackColor = SystemColors.Window;
      this.Stations_list.DropDownStyle = ComboBoxStyle.DropDownList;
      this.Stations_list.FormattingEnabled = true;
      ComboBox stationsList1 = this.Stations_list;
      point1 = new Point(90, 13);
      Point point282 = point1;
      stationsList1.Location = point282;
      this.Stations_list.Name = "Stations_list";
      ComboBox stationsList2 = this.Stations_list;
      size1 = new Size(141, 21);
      Size size305 = size1;
      stationsList2.Size = size305;
      this.Stations_list.TabIndex = 33;
      this.Label21.AutoSize = true;
      this.Label21.BackColor = SystemColors.Control;
      this.Label21.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label21.ForeColor = Color.Black;
      this.Label21.ImeMode = ImeMode.NoControl;
      Label label21_1 = this.Label21;
      point1 = new Point(6, 41);
      Point point283 = point1;
      label21_1.Location = point283;
      this.Label21.Name = "Label21";
      Label label21_2 = this.Label21;
      size1 = new Size(54, 13);
      Size size306 = size1;
      label21_2.Size = size306;
      this.Label21.TabIndex = 64;
      this.Label21.Text = "Longitude";
      this.Label57.AutoSize = true;
      this.Label57.BackColor = SystemColors.Control;
      this.Label57.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label57.ForeColor = Color.Black;
      this.Label57.ImeMode = ImeMode.NoControl;
      Label label57_1 = this.Label57;
      point1 = new Point(161, 78);
      Point point284 = point1;
      label57_1.Location = point284;
      this.Label57.Name = "Label57";
      Label label57_2 = this.Label57;
      size1 = new Size(15, 13);
      Size size307 = size1;
      label57_2.Size = size307;
      this.Label57.TabIndex = 72;
      this.Label57.Text = "m";
      this.Stations_lng.BackColor = SystemColors.Control;
      this.Stations_lng.BorderStyle = BorderStyle.None;
      this.Stations_lng.ForeColor = Color.Black;
      TextBox stationsLng1 = this.Stations_lng;
      point1 = new Point(90, 40);
      Point point285 = point1;
      stationsLng1.Location = point285;
      this.Stations_lng.Name = "Stations_lng";
      this.Stations_lng.ReadOnly = true;
      TextBox stationsLng2 = this.Stations_lng;
      size1 = new Size(65, 13);
      Size size308 = size1;
      stationsLng2.Size = size308;
      this.Stations_lng.TabIndex = 65;
      this.Stations_lng.TabStop = false;
      this.Stations_lng.TextAlign = HorizontalAlignment.Right;
      this.Label56.AutoSize = true;
      this.Label56.BackColor = SystemColors.Control;
      this.Label56.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label56.ForeColor = Color.Black;
      this.Label56.ImeMode = ImeMode.NoControl;
      Label label56_1 = this.Label56;
      point1 = new Point(161, 59);
      Point point286 = point1;
      label56_1.Location = point286;
      this.Label56.Name = "Label56";
      Label label56_2 = this.Label56;
      size1 = new Size(25, 13);
      Size size309 = size1;
      label56_2.Size = size309;
      this.Label56.TabIndex = 71;
      this.Label56.Text = "deg";
      this.Label29.AutoSize = true;
      this.Label29.BackColor = SystemColors.Control;
      this.Label29.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label29.ForeColor = Color.Black;
      this.Label29.ImeMode = ImeMode.NoControl;
      Label label29_1 = this.Label29;
      point1 = new Point(6, 60);
      Point point287 = point1;
      label29_1.Location = point287;
      this.Label29.Name = "Label29";
      Label label29_2 = this.Label29;
      size1 = new Size(45, 13);
      Size size310 = size1;
      label29_2.Size = size310;
      this.Label29.TabIndex = 66;
      this.Label29.Text = "Latitude";
      this.Label55.AutoSize = true;
      this.Label55.BackColor = SystemColors.Control;
      this.Label55.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label55.ForeColor = Color.Black;
      this.Label55.ImeMode = ImeMode.NoControl;
      Label label55_1 = this.Label55;
      point1 = new Point(161, 40);
      Point point288 = point1;
      label55_1.Location = point288;
      this.Label55.Name = "Label55";
      Label label55_2 = this.Label55;
      size1 = new Size(25, 13);
      Size size311 = size1;
      label55_2.Size = size311;
      this.Label55.TabIndex = 70;
      this.Label55.Text = "deg";
      this.Stations_lat.BackColor = SystemColors.Control;
      this.Stations_lat.BorderStyle = BorderStyle.None;
      this.Stations_lat.ForeColor = Color.Black;
      TextBox stationsLat1 = this.Stations_lat;
      point1 = new Point(90, 59);
      Point point289 = point1;
      stationsLat1.Location = point289;
      this.Stations_lat.Name = "Stations_lat";
      this.Stations_lat.ReadOnly = true;
      TextBox stationsLat2 = this.Stations_lat;
      size1 = new Size(65, 13);
      Size size312 = size1;
      stationsLat2.Size = size312;
      this.Stations_lat.TabIndex = 67;
      this.Stations_lat.TabStop = false;
      this.Stations_lat.TextAlign = HorizontalAlignment.Right;
      this.Stations_alt.BackColor = SystemColors.Control;
      this.Stations_alt.BorderStyle = BorderStyle.None;
      this.Stations_alt.ForeColor = Color.Black;
      TextBox stationsAlt1 = this.Stations_alt;
      point1 = new Point(90, 78);
      Point point290 = point1;
      stationsAlt1.Location = point290;
      this.Stations_alt.Name = "Stations_alt";
      this.Stations_alt.ReadOnly = true;
      TextBox stationsAlt2 = this.Stations_alt;
      size1 = new Size(65, 13);
      Size size313 = size1;
      stationsAlt2.Size = size313;
      this.Stations_alt.TabIndex = 69;
      this.Stations_alt.TabStop = false;
      this.Stations_alt.TextAlign = HorizontalAlignment.Right;
      this.Label41.AutoSize = true;
      this.Label41.BackColor = SystemColors.Control;
      this.Label41.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label41.ForeColor = Color.Black;
      this.Label41.ImeMode = ImeMode.NoControl;
      Label label41_1 = this.Label41;
      point1 = new Point(6, 79);
      Point point291 = point1;
      label41_1.Location = point291;
      this.Label41.Name = "Label41";
      Label label41_2 = this.Label41;
      size1 = new Size(42, 13);
      Size size314 = size1;
      label41_2.Size = size314;
      this.Label41.TabIndex = 68;
      this.Label41.Text = "Altitude";
      this.OrbitWizardTab.BackColor = SystemColors.Control;
      this.OrbitWizardTab.Controls.Add((Control) this.CREATE_Save);
      this.OrbitWizardTab.Controls.Add((Control) this.CREATE_Elements);
      this.OrbitWizardTab.Controls.Add((Control) this.CREATE_Entry);
      TabPage orbitWizardTab1 = this.OrbitWizardTab;
      point1 = new Point(4, 19);
      Point point292 = point1;
      orbitWizardTab1.Location = point292;
      this.OrbitWizardTab.Name = "OrbitWizardTab";
      TabPage orbitWizardTab2 = this.OrbitWizardTab;
      padding1 = new Padding(3);
      Padding padding13 = padding1;
      orbitWizardTab2.Padding = padding13;
      TabPage orbitWizardTab3 = this.OrbitWizardTab;
      size1 = new Size(378, 770);
      Size size315 = size1;
      orbitWizardTab3.Size = size315;
      this.OrbitWizardTab.TabIndex = 4;
      this.OrbitWizardTab.Text = "Orbit Wizard";
      this.CREATE_Save.BackColor = SystemColors.Control;
      this.CREATE_Save.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CREATE_Save.ImeMode = ImeMode.NoControl;
      Button createSave1 = this.CREATE_Save;
      point1 = new Point(145, 524);
      Point point293 = point1;
      createSave1.Location = point293;
      this.CREATE_Save.Name = "CREATE_Save";
      Button createSave2 = this.CREATE_Save;
      size1 = new Size(81, 23);
      Size size316 = size1;
      createSave2.Size = size316;
      this.CREATE_Save.TabIndex = 105;
      this.CREATE_Save.Text = "Save TLE";
      this.CREATE_Save.UseVisualStyleBackColor = true;
      this.CREATE_Elements.Controls.Add((Control) this.CREATE_Panel_Kepler);
      this.CREATE_Elements.Controls.Add((Control) this.CREATE_Refresh);
      this.CREATE_Elements.Controls.Add((Control) this.CREATE_Panel_Cartesian);
      GroupBox createElements1 = this.CREATE_Elements;
      point1 = new Point(6, 230);
      Point point294 = point1;
      createElements1.Location = point294;
      this.CREATE_Elements.Name = "CREATE_Elements";
      GroupBox createElements2 = this.CREATE_Elements;
      size1 = new Size(343, 279);
      Size size317 = size1;
      createElements2.Size = size317;
      this.CREATE_Elements.TabIndex = 2;
      this.CREATE_Elements.TabStop = false;
      this.CREATE_Elements.Text = "Elements *";
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label114);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Create_Defil_TA);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label115);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Create_Defil_AOP);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.CREATE_Bstar);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label116);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Create_Defil_RAAN);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Create_Defil_INC);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Create_Defil_ECC);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Create_Defil_SMA);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label117);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.CREATE_LNG);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label120);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label122);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label123);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label126);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label127);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label128);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.CREATE_TA);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.CREATE_AOP);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.CREATE_RAAN);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.CREATE_INC);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.CREATE_ECC);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.CREATE_SMA);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label129);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label131);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label132);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label142);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label143);
      this.CREATE_Panel_Kepler.Controls.Add((Control) this.Label144);
      Panel createPanelKepler1 = this.CREATE_Panel_Kepler;
      point1 = new Point(6, 19);
      Point point295 = point1;
      createPanelKepler1.Location = point295;
      this.CREATE_Panel_Kepler.Name = "CREATE_Panel_Kepler";
      Panel createPanelKepler2 = this.CREATE_Panel_Kepler;
      size1 = new Size(263, 250);
      Size size318 = size1;
      createPanelKepler2.Size = size318;
      this.CREATE_Panel_Kepler.TabIndex = 0;
      this.Label114.AutoSize = true;
      this.Label114.BackColor = SystemColors.Control;
      this.Label114.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label114.ForeColor = Color.Black;
      this.Label114.ImeMode = ImeMode.NoControl;
      Label label114_1 = this.Label114;
      point1 = new Point(243, 218);
      Point point296 = point1;
      label114_1.Location = point296;
      this.Label114.Name = "Label114";
      Label label114_2 = this.Label114;
      size1 = new Size(13, 12);
      Size size319 = size1;
      label114_2.Size = size319;
      this.Label114.TabIndex = 75;
      this.Label114.Text = "-1";
      HScrollBar createDefilTa1 = this.Create_Defil_TA;
      point1 = new Point(77, 179);
      Point point297 = point1;
      createDefilTa1.Location = point297;
      this.Create_Defil_TA.Name = "Create_Defil_TA";
      HScrollBar createDefilTa2 = this.Create_Defil_TA;
      size1 = new Size(141, 10);
      Size size320 = size1;
      createDefilTa2.Size = size320;
      this.Create_Defil_TA.TabIndex = 86;
      this.Label115.AutoSize = true;
      this.Label115.BackColor = SystemColors.Control;
      this.Label115.ForeColor = Color.Black;
      this.Label115.ImeMode = ImeMode.NoControl;
      Label label115_1 = this.Label115;
      point1 = new Point(224, 221);
      Point point298 = point1;
      label115_1.Location = point298;
      this.Label115.Name = "Label115";
      Label label115_2 = this.Label115;
      size1 = new Size(22, 13);
      Size size321 = size1;
      label115_2.Size = size321;
      this.Label115.TabIndex = 74;
      this.Label115.Text = "(er)";
      HScrollBar createDefilAop1 = this.Create_Defil_AOP;
      point1 = new Point(77, 145);
      Point point299 = point1;
      createDefilAop1.Location = point299;
      this.Create_Defil_AOP.Name = "Create_Defil_AOP";
      HScrollBar createDefilAop2 = this.Create_Defil_AOP;
      size1 = new Size(141, 10);
      Size size322 = size1;
      createDefilAop2.Size = size322;
      this.Create_Defil_AOP.TabIndex = 85;
      this.CREATE_Bstar.ForeColor = SystemColors.WindowText;
      TextBox createBstar1 = this.CREATE_Bstar;
      point1 = new Point(77, 218);
      Point point300 = point1;
      createBstar1.Location = point300;
      this.CREATE_Bstar.Name = "CREATE_Bstar";
      TextBox createBstar2 = this.CREATE_Bstar;
      size1 = new Size(141, 20);
      Size size323 = size1;
      createBstar2.Size = size323;
      this.CREATE_Bstar.TabIndex = 70;
      this.CREATE_Bstar.TabStop = false;
      this.CREATE_Bstar.Text = "0.001";
      this.CREATE_Bstar.TextAlign = HorizontalAlignment.Right;
      this.Label116.AutoSize = true;
      this.Label116.BackColor = SystemColors.Control;
      this.Label116.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label116.ForeColor = Color.Black;
      this.Label116.ImeMode = ImeMode.NoControl;
      Label label116_1 = this.Label116;
      point1 = new Point(1, 221);
      Point point301 = point1;
      label116_1.Location = point301;
      this.Label116.Name = "Label116";
      Label label116_2 = this.Label116;
      size1 = new Size(61, 13);
      Size size324 = size1;
      label116_2.Size = size324;
      this.Label116.TabIndex = 69;
      this.Label116.Text = "Drag Coeff.";
      HScrollBar createDefilRaan1 = this.Create_Defil_RAAN;
      point1 = new Point(77, 115);
      Point point302 = point1;
      createDefilRaan1.Location = point302;
      this.Create_Defil_RAAN.Name = "Create_Defil_RAAN";
      HScrollBar createDefilRaan2 = this.Create_Defil_RAAN;
      size1 = new Size(141, 10);
      Size size325 = size1;
      createDefilRaan2.Size = size325;
      this.Create_Defil_RAAN.TabIndex = 84;
      HScrollBar createDefilInc1 = this.Create_Defil_INC;
      point1 = new Point(77, 83);
      Point point303 = point1;
      createDefilInc1.Location = point303;
      this.Create_Defil_INC.Name = "Create_Defil_INC";
      HScrollBar createDefilInc2 = this.Create_Defil_INC;
      size1 = new Size(141, 10);
      Size size326 = size1;
      createDefilInc2.Size = size326;
      this.Create_Defil_INC.TabIndex = 83;
      HScrollBar createDefilEcc1 = this.Create_Defil_ECC;
      point1 = new Point(77, 52);
      Point point304 = point1;
      createDefilEcc1.Location = point304;
      this.Create_Defil_ECC.Name = "Create_Defil_ECC";
      HScrollBar createDefilEcc2 = this.Create_Defil_ECC;
      size1 = new Size(141, 10);
      Size size327 = size1;
      createDefilEcc2.Size = size327;
      this.Create_Defil_ECC.TabIndex = 82;
      HScrollBar createDefilSma1 = this.Create_Defil_SMA;
      point1 = new Point(78, 24);
      Point point305 = point1;
      createDefilSma1.Location = point305;
      this.Create_Defil_SMA.Name = "Create_Defil_SMA";
      HScrollBar createDefilSma2 = this.Create_Defil_SMA;
      size1 = new Size(140, 10);
      Size size328 = size1;
      createDefilSma2.Size = size328;
      this.Create_Defil_SMA.TabIndex = 81;
      this.Label117.AutoSize = true;
      this.Label117.BackColor = SystemColors.Control;
      this.Label117.ForeColor = Color.Black;
      this.Label117.ImeMode = ImeMode.NoControl;
      Label label117_1 = this.Label117;
      point1 = new Point(225, 195);
      Point point306 = point1;
      label117_1.Location = point306;
      this.Label117.Name = "Label117";
      Label label117_2 = this.Label117;
      size1 = new Size(25, 13);
      Size size329 = size1;
      label117_2.Size = size329;
      this.Label117.TabIndex = 80;
      this.Label117.Text = "deg";
      this.CREATE_LNG.ForeColor = SystemColors.WindowText;
      TextBox createLng1 = this.CREATE_LNG;
      point1 = new Point(78, 192);
      Point point307 = point1;
      createLng1.Location = point307;
      this.CREATE_LNG.Name = "CREATE_LNG";
      this.CREATE_LNG.ReadOnly = true;
      TextBox createLng2 = this.CREATE_LNG;
      size1 = new Size(141, 20);
      Size size330 = size1;
      createLng2.Size = size330;
      this.CREATE_LNG.TabIndex = 77;
      this.CREATE_LNG.TabStop = false;
      this.CREATE_LNG.TextAlign = HorizontalAlignment.Right;
      this.Label120.AutoSize = true;
      this.Label120.BackColor = SystemColors.Control;
      this.Label120.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label120.ForeColor = Color.Black;
      this.Label120.ImeMode = ImeMode.NoControl;
      Label label120_1 = this.Label120;
      point1 = new Point(2, 195);
      Point point308 = point1;
      label120_1.Location = point308;
      this.Label120.Name = "Label120";
      Label label120_2 = this.Label120;
      size1 = new Size(29, 13);
      Size size331 = size1;
      label120_2.Size = size331;
      this.Label120.TabIndex = 76;
      this.Label120.Text = "LNG";
      this.Label122.AutoSize = true;
      this.Label122.BackColor = SystemColors.Control;
      this.Label122.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label122.ForeColor = Color.Black;
      this.Label122.ImeMode = ImeMode.NoControl;
      Label label122_1 = this.Label122;
      point1 = new Point(224, 131);
      Point point309 = point1;
      label122_1.Location = point309;
      this.Label122.Name = "Label122";
      Label label122_2 = this.Label122;
      size1 = new Size(25, 13);
      Size size332 = size1;
      label122_2.Size = size332;
      this.Label122.TabIndex = 72;
      this.Label122.Text = "deg";
      this.Label123.AutoSize = true;
      this.Label123.BackColor = SystemColors.Control;
      this.Label123.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label123.ForeColor = Color.Black;
      this.Label123.ImeMode = ImeMode.NoControl;
      Label label123_1 = this.Label123;
      point1 = new Point(224, 99);
      Point point310 = point1;
      label123_1.Location = point310;
      this.Label123.Name = "Label123";
      Label label123_2 = this.Label123;
      size1 = new Size(25, 13);
      Size size333 = size1;
      label123_2.Size = size333;
      this.Label123.TabIndex = 71;
      this.Label123.Text = "deg";
      this.Label126.AutoSize = true;
      this.Label126.BackColor = SystemColors.Control;
      this.Label126.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label126.ForeColor = Color.Black;
      this.Label126.ImeMode = ImeMode.NoControl;
      Label label126_1 = this.Label126;
      point1 = new Point(225, 66);
      Point point311 = point1;
      label126_1.Location = point311;
      this.Label126.Name = "Label126";
      Label label126_2 = this.Label126;
      size1 = new Size(25, 13);
      Size size334 = size1;
      label126_2.Size = size334;
      this.Label126.TabIndex = 70;
      this.Label126.Text = "deg";
      this.Label127.AutoSize = true;
      this.Label127.BackColor = SystemColors.Control;
      this.Label127.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label127.ForeColor = Color.Black;
      this.Label127.ImeMode = ImeMode.NoControl;
      Label label127_1 = this.Label127;
      point1 = new Point(224, 8);
      Point point312 = point1;
      label127_1.Location = point312;
      this.Label127.Name = "Label127";
      Label label127_2 = this.Label127;
      size1 = new Size(21, 13);
      Size size335 = size1;
      label127_2.Size = size335;
      this.Label127.TabIndex = 69;
      this.Label127.Text = "km";
      this.Label128.AutoSize = true;
      this.Label128.BackColor = SystemColors.Control;
      this.Label128.ForeColor = Color.Black;
      this.Label128.ImeMode = ImeMode.NoControl;
      Label label128_1 = this.Label128;
      point1 = new Point(225, 161);
      Point point313 = point1;
      label128_1.Location = point313;
      this.Label128.Name = "Label128";
      Label label128_2 = this.Label128;
      size1 = new Size(25, 13);
      Size size336 = size1;
      label128_2.Size = size336;
      this.Label128.TabIndex = 73;
      this.Label128.Text = "deg";
      this.CREATE_TA.ForeColor = SystemColors.WindowText;
      TextBox createTa1 = this.CREATE_TA;
      point1 = new Point(78, 158);
      Point point314 = point1;
      createTa1.Location = point314;
      this.CREATE_TA.Name = "CREATE_TA";
      TextBox createTa2 = this.CREATE_TA;
      size1 = new Size(141, 20);
      Size size337 = size1;
      createTa2.Size = size337;
      this.CREATE_TA.TabIndex = 68;
      this.CREATE_TA.TabStop = false;
      this.CREATE_TA.TextAlign = HorizontalAlignment.Right;
      this.CREATE_AOP.ForeColor = SystemColors.WindowText;
      TextBox createAop1 = this.CREATE_AOP;
      point1 = new Point(77, 128);
      Point point315 = point1;
      createAop1.Location = point315;
      this.CREATE_AOP.Name = "CREATE_AOP";
      TextBox createAop2 = this.CREATE_AOP;
      size1 = new Size(141, 20);
      Size size338 = size1;
      createAop2.Size = size338;
      this.CREATE_AOP.TabIndex = 67;
      this.CREATE_AOP.TabStop = false;
      this.CREATE_AOP.TextAlign = HorizontalAlignment.Right;
      this.CREATE_RAAN.ForeColor = SystemColors.WindowText;
      TextBox createRaan1 = this.CREATE_RAAN;
      point1 = new Point(77, 96);
      Point point316 = point1;
      createRaan1.Location = point316;
      this.CREATE_RAAN.Name = "CREATE_RAAN";
      TextBox createRaan2 = this.CREATE_RAAN;
      size1 = new Size(141, 20);
      Size size339 = size1;
      createRaan2.Size = size339;
      this.CREATE_RAAN.TabIndex = 66;
      this.CREATE_RAAN.TabStop = false;
      this.CREATE_RAAN.TextAlign = HorizontalAlignment.Right;
      this.CREATE_INC.ForeColor = SystemColors.WindowText;
      TextBox createInc1 = this.CREATE_INC;
      point1 = new Point(78, 63);
      Point point317 = point1;
      createInc1.Location = point317;
      this.CREATE_INC.Name = "CREATE_INC";
      TextBox createInc2 = this.CREATE_INC;
      size1 = new Size(141, 20);
      Size size340 = size1;
      createInc2.Size = size340;
      this.CREATE_INC.TabIndex = 65;
      this.CREATE_INC.TabStop = false;
      this.CREATE_INC.TextAlign = HorizontalAlignment.Right;
      this.CREATE_ECC.ForeColor = SystemColors.WindowText;
      TextBox createEcc1 = this.CREATE_ECC;
      point1 = new Point(77, 34);
      Point point318 = point1;
      createEcc1.Location = point318;
      this.CREATE_ECC.Name = "CREATE_ECC";
      TextBox createEcc2 = this.CREATE_ECC;
      size1 = new Size(141, 20);
      Size size341 = size1;
      createEcc2.Size = size341;
      this.CREATE_ECC.TabIndex = 64;
      this.CREATE_ECC.TabStop = false;
      this.CREATE_ECC.TextAlign = HorizontalAlignment.Right;
      this.CREATE_SMA.BackColor = SystemColors.Window;
      this.CREATE_SMA.ForeColor = SystemColors.WindowText;
      TextBox createSma1 = this.CREATE_SMA;
      point1 = new Point(77, 5);
      Point point319 = point1;
      createSma1.Location = point319;
      this.CREATE_SMA.Name = "CREATE_SMA";
      TextBox createSma2 = this.CREATE_SMA;
      size1 = new Size(141, 20);
      Size size342 = size1;
      createSma2.Size = size342;
      this.CREATE_SMA.TabIndex = 63;
      this.CREATE_SMA.TabStop = false;
      this.CREATE_SMA.TextAlign = HorizontalAlignment.Right;
      this.Label129.AutoSize = true;
      this.Label129.BackColor = SystemColors.Control;
      this.Label129.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label129.ForeColor = Color.Black;
      this.Label129.ImeMode = ImeMode.NoControl;
      Label label129_1 = this.Label129;
      point1 = new Point(1, 8);
      Point point320 = point1;
      label129_1.Location = point320;
      this.Label129.Name = "Label129";
      Label label129_2 = this.Label129;
      size1 = new Size(30, 13);
      Size size343 = size1;
      label129_2.Size = size343;
      this.Label129.TabIndex = 57;
      this.Label129.Text = "SMA";
      this.Label131.AutoSize = true;
      this.Label131.BackColor = SystemColors.Control;
      this.Label131.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label131.ForeColor = Color.Black;
      this.Label131.ImeMode = ImeMode.NoControl;
      Label label131_1 = this.Label131;
      point1 = new Point(2, 161);
      Point point321 = point1;
      label131_1.Location = point321;
      this.Label131.Name = "Label131";
      Label label131_2 = this.Label131;
      size1 = new Size(21, 13);
      Size size344 = size1;
      label131_2.Size = size344;
      this.Label131.TabIndex = 62;
      this.Label131.Text = "TA";
      this.Label132.AutoSize = true;
      this.Label132.BackColor = SystemColors.Control;
      this.Label132.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label132.ForeColor = Color.Black;
      this.Label132.ImeMode = ImeMode.NoControl;
      Label label132_1 = this.Label132;
      point1 = new Point(1, 131);
      Point point322 = point1;
      label132_1.Location = point322;
      this.Label132.Name = "Label132";
      Label label132_2 = this.Label132;
      size1 = new Size(29, 13);
      Size size345 = size1;
      label132_2.Size = size345;
      this.Label132.TabIndex = 61;
      this.Label132.Text = "AOP";
      this.Label142.AutoSize = true;
      this.Label142.BackColor = SystemColors.Control;
      this.Label142.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label142.ForeColor = Color.Black;
      this.Label142.ImeMode = ImeMode.NoControl;
      Label label142_1 = this.Label142;
      point1 = new Point(1, 99);
      Point point323 = point1;
      label142_1.Location = point323;
      this.Label142.Name = "Label142";
      Label label142_2 = this.Label142;
      size1 = new Size(37, 13);
      Size size346 = size1;
      label142_2.Size = size346;
      this.Label142.TabIndex = 60;
      this.Label142.Text = "RAAN";
      this.Label143.AutoSize = true;
      this.Label143.BackColor = SystemColors.Control;
      this.Label143.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label143.ForeColor = Color.Black;
      this.Label143.ImeMode = ImeMode.NoControl;
      Label label143_1 = this.Label143;
      point1 = new Point(2, 66);
      Point point324 = point1;
      label143_1.Location = point324;
      this.Label143.Name = "Label143";
      Label label143_2 = this.Label143;
      size1 = new Size(25, 13);
      Size size347 = size1;
      label143_2.Size = size347;
      this.Label143.TabIndex = 59;
      this.Label143.Text = "INC";
      this.Label144.AutoSize = true;
      this.Label144.BackColor = SystemColors.Control;
      this.Label144.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label144.ForeColor = Color.Black;
      this.Label144.ImeMode = ImeMode.NoControl;
      Label label144_1 = this.Label144;
      point1 = new Point(1, 37);
      Point point325 = point1;
      label144_1.Location = point325;
      this.Label144.Name = "Label144";
      Label label144_2 = this.Label144;
      size1 = new Size(28, 13);
      Size size348 = size1;
      label144_2.Size = size348;
      this.Label144.TabIndex = 58;
      this.Label144.Text = "ECC";
      this.CREATE_Refresh.BackColor = Color.Transparent;
      this.CREATE_Refresh.Image = (Image) componentResourceManager.GetObject("CREATE_Refresh.Image");
      this.CREATE_Refresh.ImeMode = ImeMode.NoControl;
      Button createRefresh1 = this.CREATE_Refresh;
      point1 = new Point(311, 246);
      Point point326 = point1;
      createRefresh1.Location = point326;
      this.CREATE_Refresh.Name = "CREATE_Refresh";
      Button createRefresh2 = this.CREATE_Refresh;
      size1 = new Size(26, 23);
      Size size349 = size1;
      createRefresh2.Size = size349;
      this.CREATE_Refresh.TabIndex = 102;
      this.CREATE_Refresh.UseVisualStyleBackColor = false;
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label145);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label146);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label147);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label148);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label149);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label150);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label151);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label152);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label157);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label158);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label159);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.Label160);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.CREATE_VZ);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.CREATE_VY);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.CREATE_VX);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.CREATE_Z);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.CREATE_Y);
      this.CREATE_Panel_Cartesian.Controls.Add((Control) this.CREATE_X);
      Panel createPanelCartesian1 = this.CREATE_Panel_Cartesian;
      point1 = new Point(6, 19);
      Point point327 = point1;
      createPanelCartesian1.Location = point327;
      this.CREATE_Panel_Cartesian.Name = "CREATE_Panel_Cartesian";
      Panel createPanelCartesian2 = this.CREATE_Panel_Cartesian;
      size1 = new Size(263, 160);
      Size size350 = size1;
      createPanelCartesian2.Size = size350;
      this.CREATE_Panel_Cartesian.TabIndex = 2;
      this.CREATE_Panel_Cartesian.Visible = false;
      this.Label145.AutoSize = true;
      this.Label145.ImeMode = ImeMode.NoControl;
      Label label145_1 = this.Label145;
      point1 = new Point(224, 138);
      Point point328 = point1;
      label145_1.Location = point328;
      this.Label145.Name = "Label145";
      Label label145_2 = this.Label145;
      size1 = new Size(31, 13);
      Size size351 = size1;
      label145_2.Size = size351;
      this.Label145.TabIndex = 86;
      this.Label145.Text = "km/s";
      this.Label146.AutoSize = true;
      this.Label146.ImeMode = ImeMode.NoControl;
      Label label146_1 = this.Label146;
      point1 = new Point(224, 86);
      Point point329 = point1;
      label146_1.Location = point329;
      this.Label146.Name = "Label146";
      Label label146_2 = this.Label146;
      size1 = new Size(31, 13);
      Size size352 = size1;
      label146_2.Size = size352;
      this.Label146.TabIndex = 85;
      this.Label146.Text = "km/s";
      this.Label147.AutoSize = true;
      this.Label147.ImeMode = ImeMode.NoControl;
      Label label147_1 = this.Label147;
      point1 = new Point(224, 112);
      Point point330 = point1;
      label147_1.Location = point330;
      this.Label147.Name = "Label147";
      Label label147_2 = this.Label147;
      size1 = new Size(31, 13);
      Size size353 = size1;
      label147_2.Size = size353;
      this.Label147.TabIndex = 84;
      this.Label147.Text = "km/s";
      this.Label148.AutoSize = true;
      this.Label148.ImeMode = ImeMode.NoControl;
      Label label148_1 = this.Label148;
      point1 = new Point(224, 60);
      Point point331 = point1;
      label148_1.Location = point331;
      this.Label148.Name = "Label148";
      Label label148_2 = this.Label148;
      size1 = new Size(21, 13);
      Size size354 = size1;
      label148_2.Size = size354;
      this.Label148.TabIndex = 83;
      this.Label148.Text = "km";
      this.Label149.AutoSize = true;
      this.Label149.ImeMode = ImeMode.NoControl;
      Label label149_1 = this.Label149;
      point1 = new Point(224, 8);
      Point point332 = point1;
      label149_1.Location = point332;
      this.Label149.Name = "Label149";
      Label label149_2 = this.Label149;
      size1 = new Size(21, 13);
      Size size355 = size1;
      label149_2.Size = size355;
      this.Label149.TabIndex = 82;
      this.Label149.Text = "km";
      this.Label150.AutoSize = true;
      this.Label150.ImeMode = ImeMode.NoControl;
      Label label150_1 = this.Label150;
      point1 = new Point(224, 34);
      Point point333 = point1;
      label150_1.Location = point333;
      this.Label150.Name = "Label150";
      Label label150_2 = this.Label150;
      size1 = new Size(21, 13);
      Size size356 = size1;
      label150_2.Size = size356;
      this.Label150.TabIndex = 81;
      this.Label150.Text = "km";
      this.Label151.AutoSize = true;
      this.Label151.ImeMode = ImeMode.NoControl;
      Label label151_1 = this.Label151;
      point1 = new Point(1, 138);
      Point point334 = point1;
      label151_1.Location = point334;
      this.Label151.Name = "Label151";
      Label label151_2 = this.Label151;
      size1 = new Size(21, 13);
      Size size357 = size1;
      label151_2.Size = size357;
      this.Label151.TabIndex = 80;
      this.Label151.Text = "VZ";
      this.Label152.AutoSize = true;
      this.Label152.ImeMode = ImeMode.NoControl;
      Label label152_1 = this.Label152;
      point1 = new Point(1, 112);
      Point point335 = point1;
      label152_1.Location = point335;
      this.Label152.Name = "Label152";
      Label label152_2 = this.Label152;
      size1 = new Size(21, 13);
      Size size358 = size1;
      label152_2.Size = size358;
      this.Label152.TabIndex = 79;
      this.Label152.Text = "VY";
      this.Label157.AutoSize = true;
      this.Label157.ImeMode = ImeMode.NoControl;
      Label label157_1 = this.Label157;
      point1 = new Point(1, 86);
      Point point336 = point1;
      label157_1.Location = point336;
      this.Label157.Name = "Label157";
      Label label157_2 = this.Label157;
      size1 = new Size(21, 13);
      Size size359 = size1;
      label157_2.Size = size359;
      this.Label157.TabIndex = 78;
      this.Label157.Text = "VX";
      this.Label158.AutoSize = true;
      this.Label158.ImeMode = ImeMode.NoControl;
      Label label158_1 = this.Label158;
      point1 = new Point(1, 60);
      Point point337 = point1;
      label158_1.Location = point337;
      this.Label158.Name = "Label158";
      Label label158_2 = this.Label158;
      size1 = new Size(14, 13);
      Size size360 = size1;
      label158_2.Size = size360;
      this.Label158.TabIndex = 77;
      this.Label158.Text = "Z";
      this.Label159.AutoSize = true;
      this.Label159.ImeMode = ImeMode.NoControl;
      Label label159_1 = this.Label159;
      point1 = new Point(1, 8);
      Point point338 = point1;
      label159_1.Location = point338;
      this.Label159.Name = "Label159";
      Label label159_2 = this.Label159;
      size1 = new Size(14, 13);
      Size size361 = size1;
      label159_2.Size = size361;
      this.Label159.TabIndex = 75;
      this.Label159.Text = "X";
      this.Label160.AutoSize = true;
      this.Label160.ImeMode = ImeMode.NoControl;
      Label label160_1 = this.Label160;
      point1 = new Point(1, 34);
      Point point339 = point1;
      label160_1.Location = point339;
      this.Label160.Name = "Label160";
      Label label160_2 = this.Label160;
      size1 = new Size(14, 13);
      Size size362 = size1;
      label160_2.Size = size362;
      this.Label160.TabIndex = 76;
      this.Label160.Text = "Y";
      this.CREATE_VZ.ForeColor = SystemColors.WindowText;
      TextBox createVz1 = this.CREATE_VZ;
      point1 = new Point(77, 135);
      Point point340 = point1;
      createVz1.Location = point340;
      this.CREATE_VZ.Name = "CREATE_VZ";
      TextBox createVz2 = this.CREATE_VZ;
      size1 = new Size(141, 20);
      Size size363 = size1;
      createVz2.Size = size363;
      this.CREATE_VZ.TabIndex = 74;
      this.CREATE_VZ.TabStop = false;
      this.CREATE_VZ.TextAlign = HorizontalAlignment.Right;
      this.CREATE_VY.ForeColor = SystemColors.WindowText;
      TextBox createVy1 = this.CREATE_VY;
      point1 = new Point(77, 109);
      Point point341 = point1;
      createVy1.Location = point341;
      this.CREATE_VY.Name = "CREATE_VY";
      TextBox createVy2 = this.CREATE_VY;
      size1 = new Size(141, 20);
      Size size364 = size1;
      createVy2.Size = size364;
      this.CREATE_VY.TabIndex = 73;
      this.CREATE_VY.TabStop = false;
      this.CREATE_VY.TextAlign = HorizontalAlignment.Right;
      this.CREATE_VX.ForeColor = SystemColors.WindowText;
      TextBox createVx1 = this.CREATE_VX;
      point1 = new Point(77, 83);
      Point point342 = point1;
      createVx1.Location = point342;
      this.CREATE_VX.Name = "CREATE_VX";
      TextBox createVx2 = this.CREATE_VX;
      size1 = new Size(141, 20);
      Size size365 = size1;
      createVx2.Size = size365;
      this.CREATE_VX.TabIndex = 72;
      this.CREATE_VX.TabStop = false;
      this.CREATE_VX.TextAlign = HorizontalAlignment.Right;
      this.CREATE_Z.ForeColor = SystemColors.WindowText;
      TextBox createZ1 = this.CREATE_Z;
      point1 = new Point(77, 57);
      Point point343 = point1;
      createZ1.Location = point343;
      this.CREATE_Z.Name = "CREATE_Z";
      TextBox createZ2 = this.CREATE_Z;
      size1 = new Size(141, 20);
      Size size366 = size1;
      createZ2.Size = size366;
      this.CREATE_Z.TabIndex = 71;
      this.CREATE_Z.TabStop = false;
      this.CREATE_Z.TextAlign = HorizontalAlignment.Right;
      this.CREATE_Y.ForeColor = SystemColors.WindowText;
      TextBox createY1 = this.CREATE_Y;
      point1 = new Point(77, 31);
      Point point344 = point1;
      createY1.Location = point344;
      this.CREATE_Y.Name = "CREATE_Y";
      TextBox createY2 = this.CREATE_Y;
      size1 = new Size(141, 20);
      Size size367 = size1;
      createY2.Size = size367;
      this.CREATE_Y.TabIndex = 70;
      this.CREATE_Y.TabStop = false;
      this.CREATE_Y.TextAlign = HorizontalAlignment.Right;
      this.CREATE_X.ForeColor = SystemColors.WindowText;
      TextBox createX1 = this.CREATE_X;
      point1 = new Point(77, 5);
      Point point345 = point1;
      createX1.Location = point345;
      this.CREATE_X.Name = "CREATE_X";
      TextBox createX2 = this.CREATE_X;
      size1 = new Size(141, 20);
      Size size368 = size1;
      createX2.Size = size368;
      this.CREATE_X.TabIndex = 69;
      this.CREATE_X.TabStop = false;
      this.CREATE_X.TextAlign = HorizontalAlignment.Right;
      this.CREATE_Entry.Controls.Add((Control) this.Label66);
      this.CREATE_Entry.Controls.Add((Control) this.CREATE_Collection);
      this.CREATE_Entry.Controls.Add((Control) this.Label75);
      this.CREATE_Entry.Controls.Add((Control) this.CREATE_SatNumb);
      this.CREATE_Entry.Controls.Add((Control) this.Label76);
      this.CREATE_Entry.Controls.Add((Control) this.CREATE_ScName);
      this.CREATE_Entry.Controls.Add((Control) this.CREATE_Default);
      this.CREATE_Entry.Controls.Add((Control) this.Label109);
      this.CREATE_Entry.Controls.Add((Control) this.CREATE_EPOCH_Current);
      this.CREATE_Entry.Controls.Add((Control) this.CREATE_EPOCH_Format);
      this.CREATE_Entry.Controls.Add((Control) this.Label111);
      this.CREATE_Entry.Controls.Add((Control) this.Label113);
      GroupBox createEntry1 = this.CREATE_Entry;
      point1 = new Point(6, 6);
      Point point346 = point1;
      createEntry1.Location = point346;
      this.CREATE_Entry.Name = "CREATE_Entry";
      GroupBox createEntry2 = this.CREATE_Entry;
      size1 = new Size(343, 218);
      Size size369 = size1;
      createEntry2.Size = size369;
      this.CREATE_Entry.TabIndex = 1;
      this.CREATE_Entry.TabStop = false;
      this.Label66.AutoSize = true;
      Label label66_1 = this.Label66;
      point1 = new Point(6, 131);
      Point point347 = point1;
      label66_1.Location = point347;
      this.Label66.Name = "Label66";
      Label label66_2 = this.Label66;
      size1 = new Size(53, 13);
      Size size370 = size1;
      label66_2.Size = size370;
      this.Label66.TabIndex = 108;
      this.Label66.Text = "Collection";
      this.CREATE_Collection.ForeColor = SystemColors.WindowText;
      TextBox createCollection1 = this.CREATE_Collection;
      point1 = new Point(83, 128);
      Point point348 = point1;
      createCollection1.Location = point348;
      this.CREATE_Collection.MaxLength = 8;
      this.CREATE_Collection.Name = "CREATE_Collection";
      TextBox createCollection2 = this.CREATE_Collection;
      size1 = new Size(141, 20);
      Size size371 = size1;
      createCollection2.Size = size371;
      this.CREATE_Collection.TabIndex = 107;
      this.CREATE_Collection.TabStop = false;
      this.CREATE_Collection.Text = "NewCollection";
      this.Label75.AutoSize = true;
      Label label75_1 = this.Label75;
      point1 = new Point(6, 183);
      Point point349 = point1;
      label75_1.Location = point349;
      this.Label75.Name = "Label75";
      Label label75_2 = this.Label75;
      size1 = new Size(66, 13);
      Size size372 = size1;
      label75_2.Size = size372;
      this.Label75.TabIndex = 103;
      this.Label75.Text = "Sat. Number";
      this.CREATE_SatNumb.CharacterCasing = CharacterCasing.Upper;
      this.CREATE_SatNumb.ForeColor = SystemColors.WindowText;
      TextBox createSatNumb1 = this.CREATE_SatNumb;
      point1 = new Point(83, 180);
      Point point350 = point1;
      createSatNumb1.Location = point350;
      this.CREATE_SatNumb.MaxLength = 5;
      this.CREATE_SatNumb.Name = "CREATE_SatNumb";
      TextBox createSatNumb2 = this.CREATE_SatNumb;
      size1 = new Size(141, 20);
      Size size373 = size1;
      createSatNumb2.Size = size373;
      this.CREATE_SatNumb.TabIndex = 102;
      this.CREATE_SatNumb.TabStop = false;
      this.CREATE_SatNumb.Text = "12345";
      this.Label76.AutoSize = true;
      Label label76_1 = this.Label76;
      point1 = new Point(6, 157);
      Point point351 = point1;
      label76_1.Location = point351;
      this.Label76.Name = "Label76";
      Label label76_2 = this.Label76;
      size1 = new Size(75, 13);
      Size size374 = size1;
      label76_2.Size = size374;
      this.Label76.TabIndex = 101;
      this.Label76.Text = "Satellite Name";
      this.CREATE_ScName.CharacterCasing = CharacterCasing.Upper;
      this.CREATE_ScName.ForeColor = SystemColors.WindowText;
      TextBox createScName1 = this.CREATE_ScName;
      point1 = new Point(83, 154);
      Point point352 = point1;
      createScName1.Location = point352;
      this.CREATE_ScName.MaxLength = 8;
      this.CREATE_ScName.Name = "CREATE_ScName";
      TextBox createScName2 = this.CREATE_ScName;
      size1 = new Size(141, 20);
      Size size375 = size1;
      createScName2.Size = size375;
      this.CREATE_ScName.TabIndex = 81;
      this.CREATE_ScName.TabStop = false;
      this.CREATE_ScName.Text = "NEWSAT";
      this.CREATE_Default.BackColor = SystemColors.Window;
      this.CREATE_Default.DropDownStyle = ComboBoxStyle.DropDownList;
      this.CREATE_Default.FormattingEnabled = true;
      this.CREATE_Default.Items.AddRange(new object[7]
      {
        (object) "Orbit Wizard",
        (object) "Geosynchronous",
        (object) "Sun Synchronous",
        (object) "Circular",
        (object) "Molniya",
        (object) "GPS",
        (object) "Cartesian Elements"
      });
      ComboBox createDefault1 = this.CREATE_Default;
      point1 = new Point(83, 71);
      Point point353 = point1;
      createDefault1.Location = point353;
      this.CREATE_Default.Name = "CREATE_Default";
      ComboBox createDefault2 = this.CREATE_Default;
      size1 = new Size(141, 21);
      Size size376 = size1;
      createDefault2.Size = size376;
      this.CREATE_Default.TabIndex = 100;
      this.Label109.AutoSize = true;
      Label label109_1 = this.Label109;
      point1 = new Point(6, 74);
      Point point354 = point1;
      label109_1.Location = point354;
      this.Label109.Name = "Label109";
      Label label109_2 = this.Label109;
      size1 = new Size(66, 13);
      Size size377 = size1;
      label109_2.Size = size377;
      this.Label109.TabIndex = 99;
      this.Label109.Text = "Load default";
      this.CREATE_EPOCH_Current.ForeColor = SystemColors.WindowText;
      TextBox createEpochCurrent1 = this.CREATE_EPOCH_Current;
      point1 = new Point(83, 45);
      Point point355 = point1;
      createEpochCurrent1.Location = point355;
      this.CREATE_EPOCH_Current.Name = "CREATE_EPOCH_Current";
      TextBox createEpochCurrent2 = this.CREATE_EPOCH_Current;
      size1 = new Size(141, 20);
      Size size378 = size1;
      createEpochCurrent2.Size = size378;
      this.CREATE_EPOCH_Current.TabIndex = 34;
      this.CREATE_EPOCH_Current.TabStop = false;
      this.CREATE_EPOCH_Current.TextAlign = HorizontalAlignment.Right;
      this.CREATE_EPOCH_Format.BackColor = SystemColors.Window;
      this.CREATE_EPOCH_Format.DropDownStyle = ComboBoxStyle.DropDownList;
      this.CREATE_EPOCH_Format.FormattingEnabled = true;
      this.CREATE_EPOCH_Format.Items.AddRange(new object[3]
      {
        (object) "ModJulian",
        (object) "Gregorian",
        (object) "TLEFormat"
      });
      ComboBox createEpochFormat1 = this.CREATE_EPOCH_Format;
      point1 = new Point(83, 19);
      Point point356 = point1;
      createEpochFormat1.Location = point356;
      this.CREATE_EPOCH_Format.Name = "CREATE_EPOCH_Format";
      ComboBox createEpochFormat2 = this.CREATE_EPOCH_Format;
      size1 = new Size(141, 21);
      Size size379 = size1;
      createEpochFormat2.Size = size379;
      this.CREATE_EPOCH_Format.TabIndex = 33;
      this.Label111.AutoSize = true;
      Label label111_1 = this.Label111;
      point1 = new Point(6, 48);
      Point point357 = point1;
      label111_1.Location = point357;
      this.Label111.Name = "Label111";
      Label label111_2 = this.Label111;
      size1 = new Size(61, 13);
      Size size380 = size1;
      label111_2.Size = size380;
      this.Label111.TabIndex = 1;
      this.Label111.Text = "TLE Epoch";
      this.Label113.AutoSize = true;
      Label label113_1 = this.Label113;
      point1 = new Point(6, 22);
      Point point358 = point1;
      label113_1.Location = point358;
      this.Label113.Name = "Label113";
      Label label113_2 = this.Label113;
      size1 = new Size(70, 13);
      Size size381 = size1;
      label113_2.Size = size381;
      this.Label113.TabIndex = 0;
      this.Label113.Text = "Epoch format";
      this.Sat_CheckListBox.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Sat_CheckListBox.FormattingEnabled = true;
      CheckedListBox satCheckListBox1 = this.Sat_CheckListBox;
      point1 = new Point(682, 25);
      Point point359 = point1;
      satCheckListBox1.Location = point359;
      this.Sat_CheckListBox.Name = "Sat_CheckListBox";
      CheckedListBox satCheckListBox2 = this.Sat_CheckListBox;
      size1 = new Size(170, 199);
      Size size382 = size1;
      satCheckListBox2.Size = size382;
      this.Sat_CheckListBox.TabIndex = 91;
      this.SatellitesLabel.AutoSize = true;
      this.SatellitesLabel.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.SatellitesLabel.ImeMode = ImeMode.NoControl;
      Label satellitesLabel1 = this.SatellitesLabel;
      point1 = new Point(679, 9);
      Point point360 = point1;
      satellitesLabel1.Location = point360;
      this.SatellitesLabel.Name = "SatellitesLabel";
      Label satellitesLabel2 = this.SatellitesLabel;
      size1 = new Size(49, 13);
      Size size383 = size1;
      satellitesLabel2.Size = size383;
      this.SatellitesLabel.TabIndex = 83;
      this.SatellitesLabel.Text = "Satellites";
      this.CollectionLabel.AutoSize = true;
      this.CollectionLabel.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.CollectionLabel.ImeMode = ImeMode.NoControl;
      Label collectionLabel1 = this.CollectionLabel;
      point1 = new Point(514, 9);
      Point point361 = point1;
      collectionLabel1.Location = point361;
      this.CollectionLabel.Name = "CollectionLabel";
      Label collectionLabel2 = this.CollectionLabel;
      size1 = new Size(58, 13);
      Size size384 = size1;
      collectionLabel2.Size = size384;
      this.CollectionLabel.TabIndex = 82;
      this.CollectionLabel.Text = "Collections";
      this.SIM_Manual.AutoSize = true;
      this.SIM_Manual.Checked = true;
      this.SIM_Manual.Enabled = false;
      RadioButton simManual1 = this.SIM_Manual;
      point1 = new Point(271, 210);
      Point point362 = point1;
      simManual1.Location = point362;
      this.SIM_Manual.Name = "SIM_Manual";
      RadioButton simManual2 = this.SIM_Manual;
      size1 = new Size(60, 17);
      Size size385 = size1;
      simManual2.Size = size385;
      this.SIM_Manual.TabIndex = 79;
      this.SIM_Manual.TabStop = true;
      this.SIM_Manual.Text = "Manual";
      this.SIM_Manual.UseVisualStyleBackColor = true;
      this.SIM_RealTime.AutoSize = true;
      this.SIM_RealTime.Enabled = false;
      RadioButton simRealTime1 = this.SIM_RealTime;
      point1 = new Point(337, 210);
      Point point363 = point1;
      simRealTime1.Location = point363;
      this.SIM_RealTime.Name = "SIM_RealTime";
      RadioButton simRealTime2 = this.SIM_RealTime;
      size1 = new Size(73, 17);
      Size size386 = size1;
      simRealTime2.Size = size386;
      this.SIM_RealTime.TabIndex = 80;
      this.SIM_RealTime.Text = "Real Time";
      this.SIM_RealTime.UseVisualStyleBackColor = true;
      this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
      PictureBox pictureBox1_1 = this.PictureBox1;
      point1 = new Point(437, 135);
      Point point364 = point1;
      pictureBox1_1.Location = point364;
      this.PictureBox1.Name = "PictureBox1";
      PictureBox pictureBox1_2 = this.PictureBox1;
      size1 = new Size(67, 68);
      Size size387 = size1;
      pictureBox1_2.Size = size387;
      this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox1.TabIndex = 102;
      this.PictureBox1.TabStop = false;
      this.OpenFileDialog1.FileName = "OpenFileDialog1";
      this.Fleet_Create.BackColor = Color.Transparent;
      this.Fleet_Create.Image = (Image) componentResourceManager.GetObject("Fleet_Create.Image");
      this.Fleet_Create.ImeMode = ImeMode.NoControl;
      Button fleetCreate1 = this.Fleet_Create;
      point1 = new Point(858, 108);
      Point point365 = point1;
      fleetCreate1.Location = point365;
      this.Fleet_Create.Name = "Fleet_Create";
      Button fleetCreate2 = this.Fleet_Create;
      size1 = new Size(24, 24);
      Size size388 = size1;
      fleetCreate2.Size = size388;
      this.Fleet_Create.TabIndex = 104;
      this.Fleet_Create.UseVisualStyleBackColor = false;
      this.Fleet_Delete.BackColor = Color.Transparent;
      this.Fleet_Delete.Image = (Image) componentResourceManager.GetObject("Fleet_Delete.Image");
      this.Fleet_Delete.ImeMode = ImeMode.NoControl;
      Button fleetDelete1 = this.Fleet_Delete;
      point1 = new Point(858, 198);
      Point point366 = point1;
      fleetDelete1.Location = point366;
      this.Fleet_Delete.Name = "Fleet_Delete";
      Button fleetDelete2 = this.Fleet_Delete;
      size1 = new Size(24, 24);
      Size size389 = size1;
      fleetDelete2.Size = size389;
      this.Fleet_Delete.TabIndex = 106;
      this.Fleet_Delete.UseVisualStyleBackColor = false;
      this.Sat_SelectAll.AutoSize = true;
      this.Sat_SelectAll.Enabled = false;
      this.Sat_SelectAll.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Sat_SelectAll.ImeMode = ImeMode.NoControl;
      this.Sat_SelectAll.LinkBehavior = LinkBehavior.NeverUnderline;
      this.Sat_SelectAll.LinkColor = Color.Blue;
      LinkLabel satSelectAll1 = this.Sat_SelectAll;
      point1 = new Point(801, 9);
      Point point367 = point1;
      satSelectAll1.Location = point367;
      this.Sat_SelectAll.Name = "Sat_SelectAll";
      LinkLabel satSelectAll2 = this.Sat_SelectAll;
      size1 = new Size(51, 13);
      Size size390 = size1;
      satSelectAll2.Size = size390;
      this.Sat_SelectAll.TabIndex = 108;
      this.Sat_SelectAll.TabStop = true;
      this.Sat_SelectAll.Text = "Select All";
      this.SAT_CollectionLabel.AutoSize = true;
      this.SAT_CollectionLabel.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.SAT_CollectionLabel.ImeMode = ImeMode.NoControl;
      Label satCollectionLabel1 = this.SAT_CollectionLabel;
      point1 = new Point(677, 225);
      Point point368 = point1;
      satCollectionLabel1.Location = point368;
      this.SAT_CollectionLabel.Name = "SAT_CollectionLabel";
      Label satCollectionLabel2 = this.SAT_CollectionLabel;
      size1 = new Size(0, 13);
      Size size391 = size1;
      satCollectionLabel2.Size = size391;
      this.SAT_CollectionLabel.TabIndex = 109;
      this.OpenOrbitWizard.BackColor = Color.Transparent;
      this.OpenOrbitWizard.Image = (Image) componentResourceManager.GetObject("OpenOrbitWizard.Image");
      this.OpenOrbitWizard.ImeMode = ImeMode.NoControl;
      Button openOrbitWizard1 = this.OpenOrbitWizard;
      point1 = new Point(858, 78);
      Point point369 = point1;
      openOrbitWizard1.Location = point369;
      this.OpenOrbitWizard.Name = "OpenOrbitWizard";
      Button openOrbitWizard2 = this.OpenOrbitWizard;
      size1 = new Size(24, 24);
      Size size392 = size1;
      openOrbitWizard2.Size = size392;
      this.OpenOrbitWizard.TabIndex = 110;
      this.OpenOrbitWizard.UseVisualStyleBackColor = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(1334, 822);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.OpenOrbitWizard);
      this.Controls.Add((Control) this.SAT_CollectionLabel);
      this.Controls.Add((Control) this.Sat_SelectAll);
      this.Controls.Add((Control) this.Fleet_Delete);
      this.Controls.Add((Control) this.Fleet_Create);
      this.Controls.Add((Control) this.PictureBox1);
      this.Controls.Add((Control) this.Fleet_Remove);
      this.Controls.Add((Control) this.TLE_Search_But);
      this.Controls.Add((Control) this.Sat_CheckListBox);
      this.Controls.Add((Control) this.SIM_RealTime);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.SIM_Manual);
      this.Controls.Add((Control) this.ToolStrip1);
      this.Controls.Add((Control) this.Fleet_Add);
      this.Controls.Add((Control) this.TLE_MainPage);
      this.Controls.Add((Control) this.TLE_ListBox);
      this.Controls.Add((Control) this.SatellitesLabel);
      this.Controls.Add((Control) this.TrackingOptions);
      this.Controls.Add((Control) this.MapOptions);
      this.Controls.Add((Control) this.CollectionLabel);
      this.Controls.Add((Control) this.MAP_MainTab);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      size1 = new Size(1300, 860);
      this.MinimumSize = size1;
      this.Name = nameof (Home);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "TLE ANALYSER";
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox9.ResumeLayout(false);
      this.GroupBox9.PerformLayout();
      this.AP_GroupBox.ResumeLayout(false);
      this.AP_GroupBox.PerformLayout();
      this.EquPanel.ResumeLayout(false);
      this.EquPanel.PerformLayout();
      this.CircEquPanel.ResumeLayout(false);
      this.CircEquPanel.PerformLayout();
      this.CircularPanel.ResumeLayout(false);
      this.CircularPanel.PerformLayout();
      this.CartesianElementsFrame.ResumeLayout(false);
      this.CartesianElementsFrame.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.MAP_MainTab.ResumeLayout(false);
      this.MAP_2DMapTab.ResumeLayout(false);
      this.TableLayoutPanel1.ResumeLayout(false);
      this.TableLayoutPanel1.PerformLayout();
      ((ISupportInitialize) this.MousePict).EndInit();
      ((ISupportInitialize) this.MapSatPict).EndInit();
      ((ISupportInitialize) this.MapSunPict).EndInit();
      this.MapPanel.ResumeLayout(false);
      ((ISupportInitialize) this.SatPicture).EndInit();
      ((ISupportInitialize) this.TracePicture).EndInit();
      this.MAP_3DMapTab.ResumeLayout(false);
      ((ISupportInitialize) this.orbit3dWeb).EndInit();
      this.TrackingOptions.ResumeLayout(false);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.GroupBox6.ResumeLayout(false);
      this.GroupBox6.PerformLayout();
      this.GroupBox8.ResumeLayout(false);
      this.GroupBox8.PerformLayout();
      this.GroupBox7.ResumeLayout(false);
      this.GroupBox7.PerformLayout();
      this.MapOptions.ResumeLayout(false);
      this.MapOptions.PerformLayout();
      this.KeplerElementsFrame.ResumeLayout(false);
      this.KeplerElementsFrame.PerformLayout();
      this.ToolStrip1.ResumeLayout(false);
      this.ToolStrip1.PerformLayout();
      this.AN_Group.ResumeLayout(false);
      this.AN_Group.PerformLayout();
      this.TLE_MainPage.ResumeLayout(false);
      this.TLE_ElementsTab.ResumeLayout(false);
      this.GroupBox10.ResumeLayout(false);
      this.GroupBox10.PerformLayout();
      this.TLE_DetailsTab.ResumeLayout(false);
      ((ISupportInitialize) this.Raw_Data_GridView).EndInit();
      this.TLE_StationsTab.ResumeLayout(false);
      this.GroupBox5.ResumeLayout(false);
      this.GroupBox5.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      ((ISupportInitialize) this.radarPicture).EndInit();
      this.Stations_datas_2.ResumeLayout(false);
      this.Stations_datas_2.PerformLayout();
      ((ISupportInitialize) this.Stations_Off).EndInit();
      ((ISupportInitialize) this.Stations_On).EndInit();
      this.Stations_datas_1.ResumeLayout(false);
      this.Stations_datas_1.PerformLayout();
      this.OrbitWizardTab.ResumeLayout(false);
      this.CREATE_Elements.ResumeLayout(false);
      this.CREATE_Panel_Kepler.ResumeLayout(false);
      this.CREATE_Panel_Kepler.PerformLayout();
      this.CREATE_Panel_Cartesian.ResumeLayout(false);
      this.CREATE_Panel_Cartesian.PerformLayout();
      this.CREATE_Entry.ResumeLayout(false);
      this.CREATE_Entry.PerformLayout();
      ((ISupportInitialize) this.PictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual MenuStrip MenuStrip
    {
      [DebuggerNonUserCode] get => this._MenuStrip;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MenuStrip = value;
    }

    internal virtual ToolStripMenuItem ExitToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._ExitToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ExitToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem AboutToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._AboutToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AboutToolStripMenuItem = value;
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

    internal virtual Timer Timer2
    {
      [DebuggerNonUserCode] get => this._Timer2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Timer2_Tick);
        if (this._Timer2 != null)
          this._Timer2.Tick -= eventHandler;
        this._Timer2 = value;
        if (this._Timer2 == null)
          return;
        this._Timer2.Tick += eventHandler;
      }
    }

    internal virtual GroupBox TrackingOptions
    {
      [DebuggerNonUserCode] get => this._TrackingOptions;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TrackingOptions = value;
    }

    internal virtual Button SIM_Forward
    {
      [DebuggerNonUserCode] get => this._SIM_Forward;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SiMuAfter_Click);
        if (this._SIM_Forward != null)
          this._SIM_Forward.Click -= eventHandler;
        this._SIM_Forward = value;
        if (this._SIM_Forward == null)
          return;
        this._SIM_Forward.Click += eventHandler;
      }
    }

    internal virtual ComboBox SIM_Unit
    {
      [DebuggerNonUserCode] get => this._SIM_Unit;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SIM_Unit = value;
    }

    internal virtual ComboBox SIM_Step
    {
      [DebuggerNonUserCode] get => this._SIM_Step;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SIM_Step = value;
    }

    internal virtual Button SIM_Backward
    {
      [DebuggerNonUserCode] get => this._SIM_Backward;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SiMuBefore_Click);
        if (this._SIM_Backward != null)
          this._SIM_Backward.Click -= eventHandler;
        this._SIM_Backward = value;
        if (this._SIM_Backward == null)
          return;
        this._SIM_Backward.Click += eventHandler;
      }
    }

    internal virtual Button SIM_Pause
    {
      [DebuggerNonUserCode] get => this._SIM_Pause;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SimuPause_Click);
        if (this._SIM_Pause != null)
          this._SIM_Pause.Click -= eventHandler;
        this._SIM_Pause = value;
        if (this._SIM_Pause == null)
          return;
        this._SIM_Pause.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      [DebuggerNonUserCode] get => this._GroupBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox2 = value;
    }

    internal virtual LinkLabel NowDate
    {
      [DebuggerNonUserCode] get => this._NowDate;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.NowDate_LinkClicked);
        if (this._NowDate != null)
          this._NowDate.LinkClicked -= clickedEventHandler;
        this._NowDate = value;
        if (this._NowDate == null)
          return;
        this._NowDate.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Label Label133
    {
      [DebuggerNonUserCode] get => this._Label133;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label133 = value;
    }

    internal virtual TextBox GSTBox
    {
      [DebuggerNonUserCode] get => this._GSTBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GSTBox = value;
    }

    internal virtual Label Label134
    {
      [DebuggerNonUserCode] get => this._Label134;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label134 = value;
    }

    internal virtual ComboBox EPOCH_Format
    {
      [DebuggerNonUserCode] get => this._EPOCH_Format;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.EpochFormat_SelectedIndexChanged);
        if (this._EPOCH_Format != null)
          this._EPOCH_Format.SelectedIndexChanged -= eventHandler;
        this._EPOCH_Format = value;
        if (this._EPOCH_Format == null)
          return;
        this._EPOCH_Format.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label19
    {
      [DebuggerNonUserCode] get => this._Label19;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
    }

    internal virtual TextBox EPOCH_Current
    {
      [DebuggerNonUserCode] get => this._EPOCH_Current;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.EPOCH_Current_KeyPress);
        EventHandler eventHandler1 = new EventHandler(this.Epoch_TextChanged_1);
        EventHandler eventHandler2 = new EventHandler(this.Epoch_TextChanged);
        if (this._EPOCH_Current != null)
        {
          this._EPOCH_Current.KeyPress -= pressEventHandler;
          this._EPOCH_Current.LostFocus -= eventHandler1;
          this._EPOCH_Current.GotFocus -= eventHandler2;
        }
        this._EPOCH_Current = value;
        if (this._EPOCH_Current == null)
          return;
        this._EPOCH_Current.KeyPress += pressEventHandler;
        this._EPOCH_Current.LostFocus += eventHandler1;
        this._EPOCH_Current.GotFocus += eventHandler2;
      }
    }

    internal virtual GroupBox MapOptions
    {
      [DebuggerNonUserCode] get => this._MapOptions;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MapOptions = value;
    }

    internal virtual CheckBox MAP_FullGrid
    {
      [DebuggerNonUserCode] get => this._MAP_FullGrid;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MapShowGrid_CheckedChanged);
        if (this._MAP_FullGrid != null)
          this._MAP_FullGrid.CheckedChanged -= eventHandler;
        this._MAP_FullGrid = value;
        if (this._MAP_FullGrid == null)
          return;
        this._MAP_FullGrid.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox MAP_ShowTrack
    {
      [DebuggerNonUserCode] get => this._MAP_ShowTrack;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MapShowTrack_CheckedChanged);
        if (this._MAP_ShowTrack != null)
          this._MAP_ShowTrack.Click -= eventHandler;
        this._MAP_ShowTrack = value;
        if (this._MAP_ShowTrack == null)
          return;
        this._MAP_ShowTrack.Click += eventHandler;
      }
    }

    internal virtual Label Label25
    {
      [DebuggerNonUserCode] get => this._Label25;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
    }

    internal virtual ComboBox MAP_Num_Period
    {
      [DebuggerNonUserCode] get => this._MAP_Num_Period;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MapPeriodNbr_SelectedIndexChanged);
        if (this._MAP_Num_Period != null)
          this._MAP_Num_Period.SelectedIndexChanged -= eventHandler;
        this._MAP_Num_Period = value;
        if (this._MAP_Num_Period == null)
          return;
        this._MAP_Num_Period.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox3
    {
      [DebuggerNonUserCode] get => this._GroupBox3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox3 = value;
    }

    internal virtual LinkLabel ETFP_Label
    {
      [DebuggerNonUserCode] get => this._ETFP_Label;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.ETFP_Label_LinkClicked);
        if (this._ETFP_Label != null)
          this._ETFP_Label.LinkClicked -= clickedEventHandler;
        this._ETFP_Label = value;
        if (this._ETFP_Label == null)
          return;
        this._ETFP_Label.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Label Label138
    {
      [DebuggerNonUserCode] get => this._Label138;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label138 = value;
    }

    internal virtual Label Label137
    {
      [DebuggerNonUserCode] get => this._Label137;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label137 = value;
    }

    internal virtual Label Label136
    {
      [DebuggerNonUserCode] get => this._Label136;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label136 = value;
    }

    internal virtual Label Label135
    {
      [DebuggerNonUserCode] get => this._Label135;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label135 = value;
    }

    internal virtual TextBox LONGBox
    {
      [DebuggerNonUserCode] get => this._LONGBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LONGBox = value;
    }

    internal virtual TextBox LATBox
    {
      [DebuggerNonUserCode] get => this._LATBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LATBox = value;
    }

    internal virtual TextBox ETFPBox
    {
      [DebuggerNonUserCode] get => this._ETFPBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ETFPBox = value;
    }

    internal virtual Label Label119
    {
      [DebuggerNonUserCode] get => this._Label119;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label119 = value;
    }

    internal virtual Label Label15
    {
      [DebuggerNonUserCode] get => this._Label15;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
    }

    internal virtual TextBox MABox
    {
      [DebuggerNonUserCode] get => this._MABox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MABox = value;
    }

    internal virtual Label Label8
    {
      [DebuggerNonUserCode] get => this._Label8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
    }

    internal virtual TextBox ALPHABox
    {
      [DebuggerNonUserCode] get => this._ALPHABox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ALPHABox = value;
    }

    internal virtual TextBox TABox
    {
      [DebuggerNonUserCode] get => this._TABox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TABox = value;
    }

    internal virtual Label Label70
    {
      [DebuggerNonUserCode] get => this._Label70;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label70 = value;
    }

    internal virtual Label Label17
    {
      [DebuggerNonUserCode] get => this._Label17;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
    }

    internal virtual Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal virtual Label Label16
    {
      [DebuggerNonUserCode] get => this._Label16;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
    }

    internal virtual Label Label69
    {
      [DebuggerNonUserCode] get => this._Label69;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label69 = value;
    }

    internal virtual TextBox EABox
    {
      [DebuggerNonUserCode] get => this._EABox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EABox = value;
    }

    internal virtual Label Label9
    {
      [DebuggerNonUserCode] get => this._Label9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
    }

    internal virtual GroupBox GroupBox6
    {
      [DebuggerNonUserCode] get => this._GroupBox6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox6 = value;
    }

    internal virtual TextBox APVBox
    {
      [DebuggerNonUserCode] get => this._APVBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._APVBox = value;
    }

    internal virtual TextBox PEVBox
    {
      [DebuggerNonUserCode] get => this._PEVBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PEVBox = value;
    }

    internal virtual Label Label77
    {
      [DebuggerNonUserCode] get => this._Label77;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label77 = value;
    }

    internal virtual Label Label40
    {
      [DebuggerNonUserCode] get => this._Label40;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label40 = value;
    }

    internal virtual Label Label78
    {
      [DebuggerNonUserCode] get => this._Label78;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label78 = value;
    }

    internal virtual Label Label39
    {
      [DebuggerNonUserCode] get => this._Label39;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label39 = value;
    }

    internal virtual TextBox VELBox
    {
      [DebuggerNonUserCode] get => this._VELBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VELBox = value;
    }

    internal virtual Label Label37
    {
      [DebuggerNonUserCode] get => this._Label37;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label37 = value;
    }

    internal virtual Label Label20
    {
      [DebuggerNonUserCode] get => this._Label20;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
    }

    internal virtual GroupBox GroupBox8
    {
      [DebuggerNonUserCode] get => this._GroupBox8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox8 = value;
    }

    internal virtual LinkLabel DracoPeriod_Label
    {
      [DebuggerNonUserCode] get => this._DracoPeriod_Label;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.DracoPeriod_Label_LinkClicked);
        if (this._DracoPeriod_Label != null)
          this._DracoPeriod_Label.LinkClicked -= clickedEventHandler;
        this._DracoPeriod_Label = value;
        if (this._DracoPeriod_Label == null)
          return;
        this._DracoPeriod_Label.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel AnoPeriod_Label
    {
      [DebuggerNonUserCode] get => this._AnoPeriod_Label;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.AnoPeriod_Label_LinkClicked);
        if (this._AnoPeriod_Label != null)
          this._AnoPeriod_Label.LinkClicked -= clickedEventHandler;
        this._AnoPeriod_Label = value;
        if (this._AnoPeriod_Label == null)
          return;
        this._AnoPeriod_Label.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual TextBox APERBox
    {
      [DebuggerNonUserCode] get => this._APERBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._APERBox = value;
    }

    internal virtual TextBox DPERBox
    {
      [DebuggerNonUserCode] get => this._DPERBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._DPERBox = value;
    }

    internal virtual Label Label28
    {
      [DebuggerNonUserCode] get => this._Label28;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label28 = value;
    }

    internal virtual Label Label30
    {
      [DebuggerNonUserCode] get => this._Label30;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label30 = value;
    }

    internal virtual GroupBox GroupBox7
    {
      [DebuggerNonUserCode] get => this._GroupBox7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox7 = value;
    }

    internal virtual Label Label141
    {
      [DebuggerNonUserCode] get => this._Label141;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label141 = value;
    }

    internal virtual Label Label118
    {
      [DebuggerNonUserCode] get => this._Label118;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label118 = value;
    }

    internal virtual TextBox MALTBox
    {
      [DebuggerNonUserCode] get => this._MALTBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MALTBox = value;
    }

    internal virtual TextBox PERBox
    {
      [DebuggerNonUserCode] get => this._PERBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PERBox = value;
    }

    internal virtual TextBox PEABox
    {
      [DebuggerNonUserCode] get => this._PEABox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PEABox = value;
    }

    internal virtual TextBox APRBox
    {
      [DebuggerNonUserCode] get => this._APRBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._APRBox = value;
    }

    internal virtual TextBox APABox
    {
      [DebuggerNonUserCode] get => this._APABox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._APABox = value;
    }

    internal virtual Label ApALabel
    {
      [DebuggerNonUserCode] get => this._ApALabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ApALabel = value;
    }

    internal virtual Label PeALabel
    {
      [DebuggerNonUserCode] get => this._PeALabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PeALabel = value;
    }

    internal virtual Label Label140
    {
      [DebuggerNonUserCode] get => this._Label140;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label140 = value;
    }

    internal virtual Label Label22
    {
      [DebuggerNonUserCode] get => this._Label22;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
    }

    internal virtual Label ALTLabel
    {
      [DebuggerNonUserCode] get => this._ALTLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ALTLabel = value;
    }

    internal virtual Label Label23
    {
      [DebuggerNonUserCode] get => this._Label23;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
    }

    internal virtual TextBox ALTBox
    {
      [DebuggerNonUserCode] get => this._ALTBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ALTBox = value;
    }

    internal virtual Label Label139
    {
      [DebuggerNonUserCode] get => this._Label139;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label139 = value;
    }

    internal virtual Label Label121
    {
      [DebuggerNonUserCode] get => this._Label121;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label121 = value;
    }

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal virtual Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal virtual GroupBox KeplerElementsFrame
    {
      [DebuggerNonUserCode] get => this._KeplerElementsFrame;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._KeplerElementsFrame = value;
    }

    internal virtual Label Label14
    {
      [DebuggerNonUserCode] get => this._Label14;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
    }

    internal virtual Label Label13
    {
      [DebuggerNonUserCode] get => this._Label13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
    }

    internal virtual Label Label12
    {
      [DebuggerNonUserCode] get => this._Label12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
    }

    internal virtual Label Label11
    {
      [DebuggerNonUserCode] get => this._Label11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
    }

    internal virtual TextBox AOPBox
    {
      [DebuggerNonUserCode] get => this._AOPBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AOPBox = value;
    }

    internal virtual TextBox SMABox
    {
      [DebuggerNonUserCode] get => this._SMABox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SMABox = value;
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual TextBox RAANBox
    {
      [DebuggerNonUserCode] get => this._RAANBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._RAANBox = value;
    }

    internal virtual TextBox INCBox
    {
      [DebuggerNonUserCode] get => this._INCBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._INCBox = value;
    }

    internal virtual TextBox ECCBox
    {
      [DebuggerNonUserCode] get => this._ECCBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ECCBox = value;
    }

    internal virtual Label AOP_Label
    {
      [DebuggerNonUserCode] get => this._AOP_Label;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AOP_Label = value;
    }

    internal virtual Label RAAN_Label
    {
      [DebuggerNonUserCode] get => this._RAAN_Label;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._RAAN_Label = value;
    }

    internal virtual Label Label5
    {
      [DebuggerNonUserCode] get => this._Label5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual Label Label4
    {
      [DebuggerNonUserCode] get => this._Label4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual TabControl MAP_MainTab
    {
      [DebuggerNonUserCode] get => this._MAP_MainTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GoogleMapTab_Selected_1);
        TabControlCancelEventHandler cancelEventHandler = new TabControlCancelEventHandler(this.GoogleMapTab_Selected_2);
        if (this._MAP_MainTab != null)
        {
          this._MAP_MainTab.Click -= eventHandler;
          this._MAP_MainTab.Selecting -= cancelEventHandler;
        }
        this._MAP_MainTab = value;
        if (this._MAP_MainTab == null)
          return;
        this._MAP_MainTab.Click += eventHandler;
        this._MAP_MainTab.Selecting += cancelEventHandler;
      }
    }

    internal virtual TabPage MAP_2DMapTab
    {
      [DebuggerNonUserCode] get => this._MAP_2DMapTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MAP_2DMapTab = value;
    }

    internal virtual Panel MapPanel
    {
      [DebuggerNonUserCode] get => this._MapPanel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MapPanel = value;
    }

    internal virtual PictureBox TracePicture
    {
      [DebuggerNonUserCode] get => this._TracePicture;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ActiveSatOnMap);
        MouseEventHandler mouseEventHandler = new MouseEventHandler(this.DisplayLatLng);
        if (this._TracePicture != null)
        {
          this._TracePicture.DoubleClick -= eventHandler;
          this._TracePicture.MouseMove -= mouseEventHandler;
        }
        this._TracePicture = value;
        if (this._TracePicture == null)
          return;
        this._TracePicture.DoubleClick += eventHandler;
        this._TracePicture.MouseMove += mouseEventHandler;
      }
    }

    internal virtual PictureBox SatPicture
    {
      [DebuggerNonUserCode] get => this._SatPicture;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SatPicture = value;
    }

    internal virtual GroupBox GroupBox9
    {
      [DebuggerNonUserCode] get => this._GroupBox9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox9 = value;
    }

    internal virtual LinkLabel DLong_Label
    {
      [DebuggerNonUserCode] get => this._DLong_Label;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.DLong_Label_LinkClicked);
        if (this._DLong_Label != null)
          this._DLong_Label.LinkClicked -= clickedEventHandler;
        this._DLong_Label = value;
        if (this._DLong_Label == null)
          return;
        this._DLong_Label.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual TextBox DLBox
    {
      [DebuggerNonUserCode] get => this._DLBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._DLBox = value;
    }

    internal virtual Label Label31
    {
      [DebuggerNonUserCode] get => this._Label31;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label31 = value;
    }

    internal virtual Label Label73
    {
      [DebuggerNonUserCode] get => this._Label73;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label73 = value;
    }

    internal virtual Label Label67
    {
      [DebuggerNonUserCode] get => this._Label67;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label67 = value;
    }

    internal virtual TextBox MMBox
    {
      [DebuggerNonUserCode] get => this._MMBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MMBox = value;
    }

    internal virtual TextBox APBox
    {
      [DebuggerNonUserCode] get => this._APBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._APBox = value;
    }

    internal virtual Label Label74
    {
      [DebuggerNonUserCode] get => this._Label74;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label74 = value;
    }

    internal virtual Label Label65
    {
      [DebuggerNonUserCode] get => this._Label65;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label65 = value;
    }

    internal virtual Label Label72
    {
      [DebuggerNonUserCode] get => this._Label72;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label72 = value;
    }

    internal virtual Label Label71
    {
      [DebuggerNonUserCode] get => this._Label71;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label71 = value;
    }

    internal virtual TextBox NPBox
    {
      [DebuggerNonUserCode] get => this._NPBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._NPBox = value;
    }

    internal virtual GroupBox AP_GroupBox
    {
      [DebuggerNonUserCode] get => this._AP_GroupBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AP_GroupBox = value;
    }

    internal virtual Panel EquPanel
    {
      [DebuggerNonUserCode] get => this._EquPanel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EquPanel = value;
    }

    internal virtual Label Label100
    {
      [DebuggerNonUserCode] get => this._Label100;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label100 = value;
    }

    internal virtual TextBox iy
    {
      [DebuggerNonUserCode] get => this._iy;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._iy = value;
    }

    internal virtual Label Label101
    {
      [DebuggerNonUserCode] get => this._Label101;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label101 = value;
    }

    internal virtual Label Label88
    {
      [DebuggerNonUserCode] get => this._Label88;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label88 = value;
    }

    internal virtual Label Label99
    {
      [DebuggerNonUserCode] get => this._Label99;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label99 = value;
    }

    internal virtual TextBox SMA_AP_INC
    {
      [DebuggerNonUserCode] get => this._SMA_AP_INC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SMA_AP_INC = value;
    }

    internal virtual TextBox ix
    {
      [DebuggerNonUserCode] get => this._ix;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ix = value;
    }

    internal virtual Label Label98
    {
      [DebuggerNonUserCode] get => this._Label98;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label98 = value;
    }

    internal virtual Label Label89
    {
      [DebuggerNonUserCode] get => this._Label89;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label89 = value;
    }

    internal virtual Label Label102
    {
      [DebuggerNonUserCode] get => this._Label102;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label102 = value;
    }

    internal virtual TextBox AOP_AP_INC
    {
      [DebuggerNonUserCode] get => this._AOP_AP_INC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AOP_AP_INC = value;
    }

    internal virtual Label Label87
    {
      [DebuggerNonUserCode] get => this._Label87;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label87 = value;
    }

    internal virtual TextBox MA_AP
    {
      [DebuggerNonUserCode] get => this._MA_AP;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MA_AP = value;
    }

    internal virtual TextBox ECC_AP_INC
    {
      [DebuggerNonUserCode] get => this._ECC_AP_INC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ECC_AP_INC = value;
    }

    internal virtual Label Label84
    {
      [DebuggerNonUserCode] get => this._Label84;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label84 = value;
    }

    internal virtual Panel CircularPanel
    {
      [DebuggerNonUserCode] get => this._CircularPanel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CircularPanel = value;
    }

    internal virtual Label Label82
    {
      [DebuggerNonUserCode] get => this._Label82;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label82 = value;
    }

    internal virtual TextBox ey
    {
      [DebuggerNonUserCode] get => this._ey;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ey = value;
    }

    internal virtual Label Label97
    {
      [DebuggerNonUserCode] get => this._Label97;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label97 = value;
    }

    internal virtual Label Label96
    {
      [DebuggerNonUserCode] get => this._Label96;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label96 = value;
    }

    internal virtual Label Label83
    {
      [DebuggerNonUserCode] get => this._Label83;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label83 = value;
    }

    internal virtual TextBox SMA_AP_ECC
    {
      [DebuggerNonUserCode] get => this._SMA_AP_ECC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SMA_AP_ECC = value;
    }

    internal virtual Label Label80
    {
      [DebuggerNonUserCode] get => this._Label80;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label80 = value;
    }

    internal virtual Label Label81
    {
      [DebuggerNonUserCode] get => this._Label81;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label81 = value;
    }

    internal virtual Label Label95
    {
      [DebuggerNonUserCode] get => this._Label95;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label95 = value;
    }

    internal virtual TextBox INC_AP_ECC
    {
      [DebuggerNonUserCode] get => this._INC_AP_ECC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._INC_AP_ECC = value;
    }

    internal virtual Label label110
    {
      [DebuggerNonUserCode] get => this._label110;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._label110 = value;
    }

    internal virtual Label Label79
    {
      [DebuggerNonUserCode] get => this._Label79;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label79 = value;
    }

    internal virtual TextBox ex
    {
      [DebuggerNonUserCode] get => this._ex;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ex = value;
    }

    internal virtual TextBox AlphaPrime
    {
      [DebuggerNonUserCode] get => this._AlphaPrime;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AlphaPrime = value;
    }

    internal virtual TextBox RAAN_AP_ECC
    {
      [DebuggerNonUserCode] get => this._RAAN_AP_ECC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._RAAN_AP_ECC = value;
    }

    internal virtual Panel CircEquPanel
    {
      [DebuggerNonUserCode] get => this._CircEquPanel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CircEquPanel = value;
    }

    internal virtual Label Label104
    {
      [DebuggerNonUserCode] get => this._Label104;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label104 = value;
    }

    internal virtual Label Label103
    {
      [DebuggerNonUserCode] get => this._Label103;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label103 = value;
    }

    internal virtual Label Label85
    {
      [DebuggerNonUserCode] get => this._Label85;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label85 = value;
    }

    internal virtual TextBox MeanL_ECCINC
    {
      [DebuggerNonUserCode] get => this._MeanL_ECCINC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MeanL_ECCINC = value;
    }

    internal virtual TextBox SMA_AP_ECCINC
    {
      [DebuggerNonUserCode] get => this._SMA_AP_ECCINC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SMA_AP_ECCINC = value;
    }

    internal virtual Label Label93
    {
      [DebuggerNonUserCode] get => this._Label93;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label93 = value;
    }

    internal virtual Label Label86
    {
      [DebuggerNonUserCode] get => this._Label86;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label86 = value;
    }

    internal virtual Label Label91
    {
      [DebuggerNonUserCode] get => this._Label91;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label91 = value;
    }

    internal virtual TextBox ex_ECCINC
    {
      [DebuggerNonUserCode] get => this._ex_ECCINC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ex_ECCINC = value;
    }

    internal virtual TextBox iy_ECCINC
    {
      [DebuggerNonUserCode] get => this._iy_ECCINC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._iy_ECCINC = value;
    }

    internal virtual Label Label92
    {
      [DebuggerNonUserCode] get => this._Label92;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label92 = value;
    }

    internal virtual TextBox ix_ECCINC
    {
      [DebuggerNonUserCode] get => this._ix_ECCINC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ix_ECCINC = value;
    }

    internal virtual Label Label90
    {
      [DebuggerNonUserCode] get => this._Label90;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label90 = value;
    }

    internal virtual TextBox ey_ECCINC
    {
      [DebuggerNonUserCode] get => this._ey_ECCINC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ey_ECCINC = value;
    }

    internal virtual Label Label124
    {
      [DebuggerNonUserCode] get => this._Label124;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label124 = value;
    }

    internal virtual GroupBox CartesianElementsFrame
    {
      [DebuggerNonUserCode] get => this._CartesianElementsFrame;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CartesianElementsFrame = value;
    }

    internal virtual Label Label34
    {
      [DebuggerNonUserCode] get => this._Label34;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label34 = value;
    }

    internal virtual Label Label35
    {
      [DebuggerNonUserCode] get => this._Label35;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label35 = value;
    }

    internal virtual Label Label36
    {
      [DebuggerNonUserCode] get => this._Label36;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label36 = value;
    }

    internal virtual Label Label33
    {
      [DebuggerNonUserCode] get => this._Label33;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label33 = value;
    }

    internal virtual Label Label32
    {
      [DebuggerNonUserCode] get => this._Label32;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label32 = value;
    }

    internal virtual TextBox XBox
    {
      [DebuggerNonUserCode] get => this._XBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._XBox = value;
    }

    internal virtual Label Label38
    {
      [DebuggerNonUserCode] get => this._Label38;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label38 = value;
    }

    internal virtual TextBox VZBox
    {
      [DebuggerNonUserCode] get => this._VZBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VZBox = value;
    }

    internal virtual TextBox VYBox
    {
      [DebuggerNonUserCode] get => this._VYBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VYBox = value;
    }

    internal virtual TextBox VXBox
    {
      [DebuggerNonUserCode] get => this._VXBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._VXBox = value;
    }

    internal virtual TextBox ZBox
    {
      [DebuggerNonUserCode] get => this._ZBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ZBox = value;
    }

    internal virtual TextBox YBox
    {
      [DebuggerNonUserCode] get => this._YBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._YBox = value;
    }

    internal virtual Label Label42
    {
      [DebuggerNonUserCode] get => this._Label42;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label42 = value;
    }

    internal virtual Label Label43
    {
      [DebuggerNonUserCode] get => this._Label43;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label43 = value;
    }

    internal virtual Label Label44
    {
      [DebuggerNonUserCode] get => this._Label44;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label44 = value;
    }

    internal virtual Label Label45
    {
      [DebuggerNonUserCode] get => this._Label45;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label45 = value;
    }

    internal virtual Label Label46
    {
      [DebuggerNonUserCode] get => this._Label46;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label46 = value;
    }

    internal virtual Label Label47
    {
      [DebuggerNonUserCode] get => this._Label47;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label47 = value;
    }

    internal virtual ToolStripMenuItem HelpToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._HelpToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HelpToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem AboutToolStripMenuItem1
    {
      [DebuggerNonUserCode] get => this._AboutToolStripMenuItem1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AboutToolStripMenuItem1 = value;
    }

    internal virtual ToolStripMenuItem HelpToolStripMenuItem1
    {
      [DebuggerNonUserCode] get => this._HelpToolStripMenuItem1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HelpToolStripMenuItem1 = value;
    }

    internal virtual ToolStripMenuItem ExitToolStripMenuItem1
    {
      [DebuggerNonUserCode] get => this._ExitToolStripMenuItem1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ExitToolStripMenuItem1 = value;
    }

    internal virtual Label Label107
    {
      [DebuggerNonUserCode] get => this._Label107;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label107 = value;
    }

    internal virtual Label Label94
    {
      [DebuggerNonUserCode] get => this._Label94;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label94 = value;
    }

    internal virtual Button TLE_Search_But
    {
      [DebuggerNonUserCode] get => this._TLE_Search_But;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SATCHECK_Click);
        if (this._TLE_Search_But != null)
          this._TLE_Search_But.Click -= eventHandler;
        this._TLE_Search_But = value;
        if (this._TLE_Search_But == null)
          return;
        this._TLE_Search_But.Click += eventHandler;
      }
    }

    internal virtual ListBox TLE_ListBox
    {
      [DebuggerNonUserCode] get => this._TLE_ListBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TLE_ListBox_SelectedIndexChanged);
        if (this._TLE_ListBox != null)
          this._TLE_ListBox.SelectedIndexChanged -= eventHandler;
        this._TLE_ListBox = value;
        if (this._TLE_ListBox == null)
          return;
        this._TLE_ListBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      [DebuggerNonUserCode] get => this._GroupBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox1 = value;
    }

    internal virtual TextBox TLETextBox
    {
      [DebuggerNonUserCode] get => this._TLETextBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.TLETextBox_TextChanged);
        if (this._TLETextBox != null)
          this._TLETextBox.TextChanged -= eventHandler;
        this._TLETextBox = value;
        if (this._TLETextBox == null)
          return;
        this._TLETextBox.TextChanged += eventHandler;
      }
    }

    internal virtual TextBox phase
    {
      [DebuggerNonUserCode] get => this._phase;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._phase = value;
    }

    internal virtual TextBox LNGLATBOX
    {
      [DebuggerNonUserCode] get => this._LNGLATBOX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LNGLATBOX = value;
    }

    internal virtual TextBox LNGLATSUNBOX
    {
      [DebuggerNonUserCode] get => this._LNGLATSUNBOX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LNGLATSUNBOX = value;
    }

    internal virtual Label LONGACCLab
    {
      [DebuggerNonUserCode] get => this._LONGACCLab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LONGACCLab = value;
    }

    internal virtual TextBox LONGACCBox
    {
      [DebuggerNonUserCode] get => this._LONGACCBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LONGACCBox = value;
    }

    internal virtual Label Label130
    {
      [DebuggerNonUserCode] get => this._Label130;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label130 = value;
    }

    internal virtual Button SIM_Foreward_SbS
    {
      [DebuggerNonUserCode] get => this._SIM_Foreward_SbS;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SimuSBSP_Click);
        if (this._SIM_Foreward_SbS != null)
          this._SIM_Foreward_SbS.Click -= eventHandler;
        this._SIM_Foreward_SbS = value;
        if (this._SIM_Foreward_SbS == null)
          return;
        this._SIM_Foreward_SbS.Click += eventHandler;
      }
    }

    internal virtual Button SIM_Backward_SbS
    {
      [DebuggerNonUserCode] get => this._SIM_Backward_SbS;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SimuSBSM_Click);
        if (this._SIM_Backward_SbS != null)
          this._SIM_Backward_SbS.Click -= eventHandler;
        this._SIM_Backward_SbS = value;
        if (this._SIM_Backward_SbS == null)
          return;
        this._SIM_Backward_SbS.Click += eventHandler;
      }
    }

    internal virtual ToolStripMenuItem MenuToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._MenuToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MenuToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem ToolsMenuStrip
    {
      [DebuggerNonUserCode] get => this._ToolsMenuStrip;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolsMenuStrip = value;
    }

    internal virtual ToolStripMenuItem AboutMenuStrip
    {
      [DebuggerNonUserCode] get => this._AboutMenuStrip;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AboutMenuStrip = value;
    }

    internal virtual ToolStripMenuItem HelpMenuStrip
    {
      [DebuggerNonUserCode] get => this._HelpMenuStrip;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HelpMenuStrip = value;
    }

    internal virtual ToolStripMenuItem ExitMenuStrip
    {
      [DebuggerNonUserCode] get => this._ExitMenuStrip;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ExitMenuStrip = value;
    }

    internal virtual ToolStripMenuItem TLEToolStripMenuItem1
    {
      [DebuggerNonUserCode] get => this._TLEToolStripMenuItem1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TLEToolStripMenuItem1 = value;
    }

    internal virtual Label Label125
    {
      [DebuggerNonUserCode] get => this._Label125;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label125 = value;
    }

    internal virtual TextBox CATNbre
    {
      [DebuggerNonUserCode] get => this._CATNbre;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CATNbre = value;
    }

    internal virtual Label Label112
    {
      [DebuggerNonUserCode] get => this._Label112;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label112 = value;
    }

    internal virtual TextBox Spacecraft
    {
      [DebuggerNonUserCode] get => this._Spacecraft;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Spacecraft = value;
    }

    internal virtual TextBox SCName
    {
      [DebuggerNonUserCode] get => this._SCName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SCName = value;
    }

    internal virtual TextBox RelDist
    {
      [DebuggerNonUserCode] get => this._RelDist;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._RelDist = value;
    }

    internal virtual Label Label154
    {
      [DebuggerNonUserCode] get => this._Label154;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label154 = value;
    }

    internal virtual TextBox EclipseBox
    {
      [DebuggerNonUserCode] get => this._EclipseBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EclipseBox = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual TextBox ETFEBox
    {
      [DebuggerNonUserCode] get => this._ETFEBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ETFEBox = value;
    }

    internal virtual Label Label153
    {
      [DebuggerNonUserCode] get => this._Label153;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label153 = value;
    }

    internal virtual ToolStripMenuItem ToolsToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._ToolsToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolsToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem TLEToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._TLEToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TLEToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem ReloadTLEToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._ReloadTLEToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ReloadTLEToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem OpenFavouritesToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._OpenFavouritesToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._OpenFavouritesToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem SaveToFavouritesToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._SaveToFavouritesToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SaveToFavouritesToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem ExportToGMATToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._ExportToGMATToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ExportToGMATToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem SummaryToolStripMenuItem
    {
      [DebuggerNonUserCode] get => this._SummaryToolStripMenuItem;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SummaryToolStripMenuItem = value;
    }

    internal virtual ToolStripMenuItem AboutToolStripMenuItem2
    {
      [DebuggerNonUserCode] get => this._AboutToolStripMenuItem2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AboutToolStripMenuItem2 = value;
    }

    internal virtual ToolStripMenuItem HelpToolStripMenuItem2
    {
      [DebuggerNonUserCode] get => this._HelpToolStripMenuItem2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._HelpToolStripMenuItem2 = value;
    }

    internal virtual ToolStripMenuItem ExitToolStripMenuItem2
    {
      [DebuggerNonUserCode] get => this._ExitToolStripMenuItem2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ExitToolStripMenuItem2 = value;
    }

    internal virtual Label Label155
    {
      [DebuggerNonUserCode] get => this._Label155;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label155 = value;
    }

    internal virtual TextBox LSTBox
    {
      [DebuggerNonUserCode] get => this._LSTBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LSTBox = value;
    }

    internal virtual Label Label156
    {
      [DebuggerNonUserCode] get => this._Label156;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label156 = value;
    }

    internal virtual ToolStripMenuItem ToolStripMenuItem3
    {
      [DebuggerNonUserCode] get => this._ToolStripMenuItem3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripMenuItem3 = value;
    }

    internal virtual ToolStripMenuItem GoogleEarthMenu
    {
      [DebuggerNonUserCode] get => this._GoogleEarthMenu;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GoogleEarthMenu = value;
    }

    internal virtual ToolStrip ToolStrip1
    {
      [DebuggerNonUserCode] get => this._ToolStrip1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStrip1 = value;
    }

    internal virtual ToolStripButton ButtonMenu_GMAT
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_GMAT;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_GMAT_Click);
        if (this._ButtonMenu_GMAT != null)
          this._ButtonMenu_GMAT.Click -= eventHandler;
        this._ButtonMenu_GMAT = value;
        if (this._ButtonMenu_GMAT == null)
          return;
        this._ButtonMenu_GMAT.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ButtonMenu_Report
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Report;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Summ_Click);
        if (this._ButtonMenu_Report != null)
          this._ButtonMenu_Report.Click -= eventHandler;
        this._ButtonMenu_Report = value;
        if (this._ButtonMenu_Report == null)
          return;
        this._ButtonMenu_Report.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator4
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator4 = value;
    }

    internal virtual ToolStripButton ButtonMenu_About
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_About;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_About_Click);
        if (this._ButtonMenu_About != null)
          this._ButtonMenu_About.Click -= eventHandler;
        this._ButtonMenu_About = value;
        if (this._ButtonMenu_About == null)
          return;
        this._ButtonMenu_About.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ButtonMenu_Help
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Help;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Help_Click);
        if (this._ButtonMenu_Help != null)
          this._ButtonMenu_Help.Click -= eventHandler;
        this._ButtonMenu_Help = value;
        if (this._ButtonMenu_Help == null)
          return;
        this._ButtonMenu_Help.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ButtonMenu_Exit
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Exit;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Exit_Click);
        if (this._ButtonMenu_Exit != null)
          this._ButtonMenu_Exit.Click -= eventHandler;
        this._ButtonMenu_Exit = value;
        if (this._ButtonMenu_Exit == null)
          return;
        this._ButtonMenu_Exit.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator5
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator5 = value;
    }

    internal virtual TabPage MAP_3DMapTab
    {
      [DebuggerNonUserCode] get => this._MAP_3DMapTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MAP_3DMapTab = value;
    }

    internal virtual ToolStripButton ButtonMenu_Options
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Options;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Options_Click);
        if (this._ButtonMenu_Options != null)
          this._ButtonMenu_Options.Click -= eventHandler;
        this._ButtonMenu_Options = value;
        if (this._ButtonMenu_Options == null)
          return;
        this._ButtonMenu_Options.Click += eventHandler;
      }
    }

    internal virtual GroupBox AN_Group
    {
      [DebuggerNonUserCode] get => this._AN_Group;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._AN_Group = value;
    }

    internal virtual LinkLabel LAN_Label
    {
      [DebuggerNonUserCode] get => this._LAN_Label;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LAN_Label_LinkClicked);
        if (this._LAN_Label != null)
          this._LAN_Label.LinkClicked -= clickedEventHandler;
        this._LAN_Label = value;
        if (this._LAN_Label == null)
          return;
        this._LAN_Label.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual Label LANType
    {
      [DebuggerNonUserCode] get => this._LANType;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LANType = value;
    }

    internal virtual TextBox LANBox
    {
      [DebuggerNonUserCode] get => this._LANBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LANBox = value;
    }

    internal virtual Label LNLabel
    {
      [DebuggerNonUserCode] get => this._LNLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LNLabel = value;
    }

    internal virtual TextBox LTANBox
    {
      [DebuggerNonUserCode] get => this._LTANBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LTANBox = value;
    }

    internal virtual Label LTLabel
    {
      [DebuggerNonUserCode] get => this._LTLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LTLabel = value;
    }

    internal virtual CheckBox MAP_NightShadow
    {
      [DebuggerNonUserCode] get => this._MAP_NightShadow;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SunShadowCB_CheckedChanged);
        if (this._MAP_NightShadow != null)
          this._MAP_NightShadow.Click -= eventHandler;
        this._MAP_NightShadow = value;
        if (this._MAP_NightShadow == null)
          return;
        this._MAP_NightShadow.Click += eventHandler;
      }
    }

    internal virtual TextBox OrbNumBox
    {
      [DebuggerNonUserCode] get => this._OrbNumBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._OrbNumBox = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Label Label24
    {
      [DebuggerNonUserCode] get => this._Label24;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
    }

    internal virtual PictureBox MapSatPict
    {
      [DebuggerNonUserCode] get => this._MapSatPict;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MapSatPict = value;
    }

    internal virtual PictureBox MapSunPict
    {
      [DebuggerNonUserCode] get => this._MapSunPict;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MapSunPict = value;
    }

    internal virtual TableLayoutPanel TableLayoutPanel1
    {
      [DebuggerNonUserCode] get => this._TableLayoutPanel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TableLayoutPanel1 = value;
    }

    internal virtual ToolStripButton ButtonMenu_OpenF
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_OpenF;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_OpenF_Click);
        if (this._ButtonMenu_OpenF != null)
          this._ButtonMenu_OpenF.Click -= eventHandler;
        this._ButtonMenu_OpenF = value;
        if (this._ButtonMenu_OpenF == null)
          return;
        this._ButtonMenu_OpenF.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator3
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator3 = value;
    }

    internal virtual ToolStripButton ButtonMenu_Charts
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Charts;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Charts_Click);
        if (this._ButtonMenu_Charts != null)
          this._ButtonMenu_Charts.Click -= eventHandler;
        this._ButtonMenu_Charts = value;
        if (this._ButtonMenu_Charts == null)
          return;
        this._ButtonMenu_Charts.Click += eventHandler;
      }
    }

    internal virtual TextBox EPOCH_TLE
    {
      [DebuggerNonUserCode] get => this._EPOCH_TLE;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._EPOCH_TLE = value;
    }

    internal virtual Button Fleet_Add
    {
      [DebuggerNonUserCode] get => this._Fleet_Add;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Fleet_Add_Click);
        if (this._Fleet_Add != null)
          this._Fleet_Add.Click -= eventHandler;
        this._Fleet_Add = value;
        if (this._Fleet_Add == null)
          return;
        this._Fleet_Add.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ButtonMenu_GMAT_M
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_GMAT_M;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_GMAT_M_Click);
        if (this._ButtonMenu_GMAT_M != null)
          this._ButtonMenu_GMAT_M.Click -= eventHandler;
        this._ButtonMenu_GMAT_M = value;
        if (this._ButtonMenu_GMAT_M == null)
          return;
        this._ButtonMenu_GMAT_M.Click += eventHandler;
      }
    }

    internal virtual Button Fleet_Remove
    {
      [DebuggerNonUserCode] get => this._Fleet_Remove;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Fleet_Remove_Click);
        if (this._Fleet_Remove != null)
          this._Fleet_Remove.Click -= eventHandler;
        this._Fleet_Remove = value;
        if (this._Fleet_Remove == null)
          return;
        this._Fleet_Remove.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator6
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator6 = value;
    }

    internal virtual CheckBox MAP_PtsOnOrbit
    {
      [DebuggerNonUserCode] get => this._MAP_PtsOnOrbit;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PtsOnOrbit_CB_CheckedChanged);
        if (this._MAP_PtsOnOrbit != null)
          this._MAP_PtsOnOrbit.CheckedChanged -= eventHandler;
        this._MAP_PtsOnOrbit = value;
        if (this._MAP_PtsOnOrbit == null)
          return;
        this._MAP_PtsOnOrbit.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton DNButton
    {
      [DebuggerNonUserCode] get => this._DNButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._DNButton = value;
    }

    internal virtual RadioButton ANButton
    {
      [DebuggerNonUserCode] get => this._ANButton;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ANButton_CheckedChanged);
        if (this._ANButton != null)
          this._ANButton.CheckedChanged -= eventHandler;
        this._ANButton = value;
        if (this._ANButton == null)
          return;
        this._ANButton.CheckedChanged += eventHandler;
      }
    }

    internal virtual TabControl TLE_MainPage
    {
      [DebuggerNonUserCode] get => this._TLE_MainPage;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        TabControlCancelEventHandler cancelEventHandler = new TabControlCancelEventHandler(this.OrbitWizardTab_Selected);
        if (this._TLE_MainPage != null)
          this._TLE_MainPage.Selecting -= cancelEventHandler;
        this._TLE_MainPage = value;
        if (this._TLE_MainPage == null)
          return;
        this._TLE_MainPage.Selecting += cancelEventHandler;
      }
    }

    internal virtual TabPage TLE_ElementsTab
    {
      [DebuggerNonUserCode] get => this._TLE_ElementsTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TLE_ElementsTab = value;
    }

    internal virtual Label SatellitesLabel
    {
      [DebuggerNonUserCode] get => this._SatellitesLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SatellitesLabel = value;
    }

    internal virtual Label CollectionLabel
    {
      [DebuggerNonUserCode] get => this._CollectionLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CollectionLabel = value;
    }

    internal virtual ProgressBar ProgressBar
    {
      [DebuggerNonUserCode] get => this._ProgressBar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ProgressBar = value;
    }

    internal virtual LinkLabel TLEDate
    {
      [DebuggerNonUserCode] get => this._TLEDate;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.TLEDate_LinkClicked);
        if (this._TLEDate != null)
          this._TLEDate.LinkClicked -= clickedEventHandler;
        this._TLEDate = value;
        if (this._TLEDate == null)
          return;
        this._TLEDate.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual TextBox ODBox
    {
      [DebuggerNonUserCode] get => this._ODBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ODBox = value;
    }

    internal virtual Label Label27
    {
      [DebuggerNonUserCode] get => this._Label27;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label27 = value;
    }

    internal virtual CheckBox MAP_Show_FullTrack
    {
      [DebuggerNonUserCode] get => this._MAP_Show_FullTrack;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.FullTrackCB_CheckedChanged);
        if (this._MAP_Show_FullTrack != null)
          this._MAP_Show_FullTrack.CheckedChanged -= eventHandler;
        this._MAP_Show_FullTrack = value;
        if (this._MAP_Show_FullTrack == null)
          return;
        this._MAP_Show_FullTrack.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button SIM_Actu_Track
    {
      [DebuggerNonUserCode] get => this._SIM_Actu_Track;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ActuTrack_Click);
        if (this._SIM_Actu_Track != null)
          this._SIM_Actu_Track.Click -= eventHandler;
        this._SIM_Actu_Track = value;
        if (this._SIM_Actu_Track == null)
          return;
        this._SIM_Actu_Track.Click += eventHandler;
      }
    }

    internal virtual RadioButton SIM_RealTime
    {
      [DebuggerNonUserCode] get => this._SIM_RealTime;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.RealTimeMode_CheckedChanged);
        if (this._SIM_RealTime != null)
          this._SIM_RealTime.CheckedChanged -= eventHandler;
        this._SIM_RealTime = value;
        if (this._SIM_RealTime == null)
          return;
        this._SIM_RealTime.CheckedChanged += eventHandler;
      }
    }

    internal virtual RadioButton SIM_Manual
    {
      [DebuggerNonUserCode] get => this._SIM_Manual;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ManualMode_CheckedChanged);
        if (this._SIM_Manual != null)
          this._SIM_Manual.CheckedChanged -= eventHandler;
        this._SIM_Manual = value;
        if (this._SIM_Manual == null)
          return;
        this._SIM_Manual.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox MousePict
    {
      [DebuggerNonUserCode] get => this._MousePict;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._MousePict = value;
    }

    internal virtual TextBox LNGLATMouseBOX
    {
      [DebuggerNonUserCode] get => this._LNGLATMouseBOX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._LNGLATMouseBOX = value;
    }

    internal virtual LinkLabel KepPeriod_Label
    {
      [DebuggerNonUserCode] get => this._KepPeriod_Label;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.KepPeriod_Label_LinkClicked);
        if (this._KepPeriod_Label != null)
          this._KepPeriod_Label.LinkClicked -= clickedEventHandler;
        this._KepPeriod_Label = value;
        if (this._KepPeriod_Label == null)
          return;
        this._KepPeriod_Label.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual TextBox KPERBox
    {
      [DebuggerNonUserCode] get => this._KPERBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._KPERBox = value;
    }

    internal virtual Label Label26
    {
      [DebuggerNonUserCode] get => this._Label26;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
    }

    internal virtual ToolStripButton ButtonMenu_Paste
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Paste;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_New_Click);
        if (this._ButtonMenu_Paste != null)
          this._ButtonMenu_Paste.Click -= eventHandler;
        this._ButtonMenu_Paste = value;
        if (this._ButtonMenu_Paste == null)
          return;
        this._ButtonMenu_Paste.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ButtonMenu_Modify
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Modify;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Modify_Click);
        if (this._ButtonMenu_Modify != null)
          this._ButtonMenu_Modify.Click -= eventHandler;
        this._ButtonMenu_Modify = value;
        if (this._ButtonMenu_Modify == null)
          return;
        this._ButtonMenu_Modify.Click += eventHandler;
      }
    }

    internal virtual ToolStripButton ButtonMenu_Import
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Import;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Import_Click);
        if (this._ButtonMenu_Import != null)
          this._ButtonMenu_Import.Click -= eventHandler;
        this._ButtonMenu_Import = value;
        if (this._ButtonMenu_Import == null)
          return;
        this._ButtonMenu_Import.Click += eventHandler;
      }
    }

    internal virtual ToolStripSeparator ToolStripSeparator7
    {
      [DebuggerNonUserCode] get => this._ToolStripSeparator7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._ToolStripSeparator7 = value;
    }

    internal virtual TabPage TLE_DetailsTab
    {
      [DebuggerNonUserCode] get => this._TLE_DetailsTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TLE_DetailsTab = value;
    }

    internal virtual CheckedListBox Sat_CheckListBox
    {
      [DebuggerNonUserCode] get => this._Sat_CheckListBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Sat_CheckListBox_SelectedIndexChanged);
        if (this._Sat_CheckListBox != null)
          this._Sat_CheckListBox.SelectedIndexChanged -= eventHandler;
        this._Sat_CheckListBox = value;
        if (this._Sat_CheckListBox == null)
          return;
        this._Sat_CheckListBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual TabPage TLE_StationsTab
    {
      [DebuggerNonUserCode] get => this._TLE_StationsTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TLE_StationsTab = value;
    }

    internal virtual PictureBox PictureBox1
    {
      [DebuggerNonUserCode] get => this._PictureBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._PictureBox1 = value;
    }

    internal virtual ToolStripButton ButtonMenu_Personal
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Personal;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Personal_Click);
        if (this._ButtonMenu_Personal != null)
          this._ButtonMenu_Personal.Click -= eventHandler;
        this._ButtonMenu_Personal = value;
        if (this._ButtonMenu_Personal == null)
          return;
        this._ButtonMenu_Personal.Click += eventHandler;
      }
    }

    internal virtual OpenFileDialog OpenFileDialog1
    {
      [DebuggerNonUserCode] get => this._OpenFileDialog1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._OpenFileDialog1 = value;
    }

    internal virtual Button Fleet_Create
    {
      [DebuggerNonUserCode] get => this._Fleet_Create;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Fleet_Create_Click);
        if (this._Fleet_Create != null)
          this._Fleet_Create.Click -= eventHandler;
        this._Fleet_Create = value;
        if (this._Fleet_Create == null)
          return;
        this._Fleet_Create.Click += eventHandler;
      }
    }

    internal virtual Button Fleet_Delete
    {
      [DebuggerNonUserCode] get => this._Fleet_Delete;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Fleet_Delete_Click);
        if (this._Fleet_Delete != null)
          this._Fleet_Delete.Click -= eventHandler;
        this._Fleet_Delete = value;
        if (this._Fleet_Delete == null)
          return;
        this._Fleet_Delete.Click += eventHandler;
      }
    }

    internal virtual CheckBox MAP_SatName
    {
      [DebuggerNonUserCode] get => this._MAP_SatName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MAP_SatName_CheckedChanged);
        if (this._MAP_SatName != null)
          this._MAP_SatName.CheckedChanged -= eventHandler;
        this._MAP_SatName = value;
        if (this._MAP_SatName == null)
          return;
        this._MAP_SatName.CheckedChanged += eventHandler;
      }
    }

    internal virtual LinkLabel Sat_SelectAll
    {
      [DebuggerNonUserCode] get => this._Sat_SelectAll;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.Sat_SelectAll__LinkClicked);
        if (this._Sat_SelectAll != null)
          this._Sat_SelectAll.LinkClicked -= clickedEventHandler;
        this._Sat_SelectAll = value;
        if (this._Sat_SelectAll == null)
          return;
        this._Sat_SelectAll.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual CheckBox MAP_VisibilityZone
    {
      [DebuggerNonUserCode] get => this._MAP_VisibilityZone;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.MAP_VisibilityZone_CheckedChanged);
        if (this._MAP_VisibilityZone != null)
          this._MAP_VisibilityZone.CheckedChanged -= eventHandler;
        this._MAP_VisibilityZone = value;
        if (this._MAP_VisibilityZone == null)
          return;
        this._MAP_VisibilityZone.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label SAT_CollectionLabel
    {
      [DebuggerNonUserCode] get => this._SAT_CollectionLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SAT_CollectionLabel = value;
    }

    internal virtual ToolStripButton ButtonMenu_Stations
    {
      [DebuggerNonUserCode] get => this._ButtonMenu_Stations;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ButtonMenu_Stations_Click);
        if (this._ButtonMenu_Stations != null)
          this._ButtonMenu_Stations.Click -= eventHandler;
        this._ButtonMenu_Stations = value;
        if (this._ButtonMenu_Stations == null)
          return;
        this._ButtonMenu_Stations.Click += eventHandler;
      }
    }

    internal virtual Label Label57
    {
      [DebuggerNonUserCode] get => this._Label57;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label57 = value;
    }

    internal virtual Label Label56
    {
      [DebuggerNonUserCode] get => this._Label56;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label56 = value;
    }

    internal virtual Label Label55
    {
      [DebuggerNonUserCode] get => this._Label55;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label55 = value;
    }

    internal virtual TextBox Stations_alt
    {
      [DebuggerNonUserCode] get => this._Stations_alt;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_alt = value;
    }

    internal virtual Label Label41
    {
      [DebuggerNonUserCode] get => this._Label41;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label41 = value;
    }

    internal virtual TextBox Stations_lat
    {
      [DebuggerNonUserCode] get => this._Stations_lat;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_lat = value;
    }

    internal virtual Label Label29
    {
      [DebuggerNonUserCode] get => this._Label29;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label29 = value;
    }

    internal virtual TextBox Stations_lng
    {
      [DebuggerNonUserCode] get => this._Stations_lng;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_lng = value;
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

    internal virtual ComboBox Stations_list
    {
      [DebuggerNonUserCode] get => this._Stations_list;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Stations_list_SelectedIndexChanged);
        if (this._Stations_list != null)
          this._Stations_list.SelectedIndexChanged -= eventHandler;
        this._Stations_list = value;
        if (this._Stations_list == null)
          return;
        this._Stations_list.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual GroupBox Stations_datas_2
    {
      [DebuggerNonUserCode] get => this._Stations_datas_2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_datas_2 = value;
    }

    internal virtual TextBox Stations_end
    {
      [DebuggerNonUserCode] get => this._Stations_end;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_end = value;
    }

    internal virtual Label Label60
    {
      [DebuggerNonUserCode] get => this._Label60;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label60 = value;
    }

    internal virtual TextBox Stations_remTime
    {
      [DebuggerNonUserCode] get => this._Stations_remTime;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_remTime = value;
    }

    internal virtual Label Label59
    {
      [DebuggerNonUserCode] get => this._Label59;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label59 = value;
    }

    internal virtual TextBox Stations_start
    {
      [DebuggerNonUserCode] get => this._Stations_start;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_start = value;
    }

    internal virtual Label Label58
    {
      [DebuggerNonUserCode] get => this._Label58;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label58 = value;
    }

    internal virtual GroupBox Stations_datas_1
    {
      [DebuggerNonUserCode] get => this._Stations_datas_1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_datas_1 = value;
    }

    internal virtual TextBox Stations_duration
    {
      [DebuggerNonUserCode] get => this._Stations_duration;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_duration = value;
    }

    internal virtual Label Label61
    {
      [DebuggerNonUserCode] get => this._Label61;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label61 = value;
    }

    internal virtual GroupBox GroupBox4
    {
      [DebuggerNonUserCode] get => this._GroupBox4;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox4 = value;
    }

    internal virtual CheckedListBox GS_ListBox
    {
      [DebuggerNonUserCode] get => this._GS_ListBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_ListBox_SelectedIndexChanged);
        if (this._GS_ListBox != null)
          this._GS_ListBox.SelectedIndexChanged -= eventHandler;
        this._GS_ListBox = value;
        if (this._GS_ListBox == null)
          return;
        this._GS_ListBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual CheckBox GS_CheckAll_CB
    {
      [DebuggerNonUserCode] get => this._GS_CheckAll_CB;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_4all_CheckedChanged);
        if (this._GS_CheckAll_CB != null)
          this._GS_CheckAll_CB.CheckedChanged -= eventHandler;
        this._GS_CheckAll_CB = value;
        if (this._GS_CheckAll_CB == null)
          return;
        this._GS_CheckAll_CB.CheckedChanged += eventHandler;
      }
    }

    internal virtual PictureBox Stations_Off
    {
      [DebuggerNonUserCode] get => this._Stations_Off;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_Off = value;
    }

    internal virtual PictureBox Stations_On
    {
      [DebuggerNonUserCode] get => this._Stations_On;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_On = value;
    }

    internal virtual Label Label106
    {
      [DebuggerNonUserCode] get => this._Label106;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label106 = value;
    }

    internal virtual Label Label108
    {
      [DebuggerNonUserCode] get => this._Label108;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label108 = value;
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

    internal virtual GroupBox GroupBox5
    {
      [DebuggerNonUserCode] get => this._GroupBox5;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox5 = value;
    }

    internal virtual Label Label105
    {
      [DebuggerNonUserCode] get => this._Label105;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label105 = value;
    }

    internal virtual TextBox Stations_dist
    {
      [DebuggerNonUserCode] get => this._Stations_dist;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_dist = value;
    }

    internal virtual Label Label64
    {
      [DebuggerNonUserCode] get => this._Label64;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label64 = value;
    }

    internal virtual TextBox Stations_el
    {
      [DebuggerNonUserCode] get => this._Stations_el;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_el = value;
    }

    internal virtual Label Label63
    {
      [DebuggerNonUserCode] get => this._Label63;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label63 = value;
    }

    internal virtual TextBox Stations_az
    {
      [DebuggerNonUserCode] get => this._Stations_az;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Stations_az = value;
    }

    internal virtual Label Label62
    {
      [DebuggerNonUserCode] get => this._Label62;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label62 = value;
    }

    internal virtual LinkLabel GS_El_Link
    {
      [DebuggerNonUserCode] get => this._GS_El_Link;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.GS_El_Link_LinkClicked);
        if (this._GS_El_Link != null)
          this._GS_El_Link.LinkClicked -= clickedEventHandler;
        this._GS_El_Link = value;
        if (this._GS_El_Link == null)
          return;
        this._GS_El_Link.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual LinkLabel GS_Az_Link
    {
      [DebuggerNonUserCode] get => this._GS_Az_Link;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.GS_Az_Link_LinkClicked);
        if (this._GS_Az_Link != null)
          this._GS_Az_Link.LinkClicked -= clickedEventHandler;
        this._GS_Az_Link = value;
        if (this._GS_Az_Link == null)
          return;
        this._GS_Az_Link.LinkClicked += clickedEventHandler;
      }
    }

    internal virtual PictureBox radarPicture
    {
      [DebuggerNonUserCode] get => this._radarPicture;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._radarPicture = value;
    }

    internal virtual ProgressBar GS_ProgressBar
    {
      [DebuggerNonUserCode] get => this._GS_ProgressBar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GS_ProgressBar = value;
    }

    internal virtual TabPage OrbitWizardTab
    {
      [DebuggerNonUserCode] get => this._OrbitWizardTab;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._OrbitWizardTab = value;
    }

    internal virtual GroupBox CREATE_Entry
    {
      [DebuggerNonUserCode] get => this._CREATE_Entry;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CREATE_Entry = value;
    }

    internal virtual Label Label66
    {
      [DebuggerNonUserCode] get => this._Label66;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label66 = value;
    }

    internal virtual TextBox CREATE_Collection
    {
      [DebuggerNonUserCode] get => this._CREATE_Collection;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_Collection_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_Collection_KeyPress);
        if (this._CREATE_Collection != null)
        {
          this._CREATE_Collection.TextChanged -= eventHandler;
          this._CREATE_Collection.KeyPress -= pressEventHandler;
        }
        this._CREATE_Collection = value;
        if (this._CREATE_Collection == null)
          return;
        this._CREATE_Collection.TextChanged += eventHandler;
        this._CREATE_Collection.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label75
    {
      [DebuggerNonUserCode] get => this._Label75;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label75 = value;
    }

    internal virtual Button CREATE_Refresh
    {
      [DebuggerNonUserCode] get => this._CREATE_Refresh;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_Refresh_Click);
        if (this._CREATE_Refresh != null)
          this._CREATE_Refresh.Click -= eventHandler;
        this._CREATE_Refresh = value;
        if (this._CREATE_Refresh == null)
          return;
        this._CREATE_Refresh.Click += eventHandler;
      }
    }

    internal virtual TextBox CREATE_SatNumb
    {
      [DebuggerNonUserCode] get => this._CREATE_SatNumb;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_SatNumb_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_SatNumb_KeyPress);
        if (this._CREATE_SatNumb != null)
        {
          this._CREATE_SatNumb.TextChanged -= eventHandler;
          this._CREATE_SatNumb.KeyPress -= pressEventHandler;
        }
        this._CREATE_SatNumb = value;
        if (this._CREATE_SatNumb == null)
          return;
        this._CREATE_SatNumb.TextChanged += eventHandler;
        this._CREATE_SatNumb.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label76
    {
      [DebuggerNonUserCode] get => this._Label76;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label76 = value;
    }

    internal virtual TextBox CREATE_ScName
    {
      [DebuggerNonUserCode] get => this._CREATE_ScName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_ScName_TextChanged);
        if (this._CREATE_ScName != null)
          this._CREATE_ScName.TextChanged -= eventHandler;
        this._CREATE_ScName = value;
        if (this._CREATE_ScName == null)
          return;
        this._CREATE_ScName.TextChanged += eventHandler;
      }
    }

    internal virtual ComboBox CREATE_Default
    {
      [DebuggerNonUserCode] get => this._CREATE_Default;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_Default_SelectedIndexChanged);
        if (this._CREATE_Default != null)
          this._CREATE_Default.SelectedIndexChanged -= eventHandler;
        this._CREATE_Default = value;
        if (this._CREATE_Default == null)
          return;
        this._CREATE_Default.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label109
    {
      [DebuggerNonUserCode] get => this._Label109;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label109 = value;
    }

    internal virtual TextBox CREATE_EPOCH_Current
    {
      [DebuggerNonUserCode] get => this._CREATE_EPOCH_Current;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_Epoch_TextChanged_2);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_EPOCH_Current_KeyPress);
        if (this._CREATE_EPOCH_Current != null)
        {
          this._CREATE_EPOCH_Current.TextChanged -= eventHandler;
          this._CREATE_EPOCH_Current.KeyPress -= pressEventHandler;
        }
        this._CREATE_EPOCH_Current = value;
        if (this._CREATE_EPOCH_Current == null)
          return;
        this._CREATE_EPOCH_Current.TextChanged += eventHandler;
        this._CREATE_EPOCH_Current.KeyPress += pressEventHandler;
      }
    }

    internal virtual ComboBox CREATE_EPOCH_Format
    {
      [DebuggerNonUserCode] get => this._CREATE_EPOCH_Format;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_EPOCH_Format_SelectedIndexChanged);
        if (this._CREATE_EPOCH_Format != null)
          this._CREATE_EPOCH_Format.SelectedIndexChanged -= eventHandler;
        this._CREATE_EPOCH_Format = value;
        if (this._CREATE_EPOCH_Format == null)
          return;
        this._CREATE_EPOCH_Format.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label111
    {
      [DebuggerNonUserCode] get => this._Label111;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label111 = value;
    }

    internal virtual Label Label113
    {
      [DebuggerNonUserCode] get => this._Label113;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label113 = value;
    }

    internal virtual GroupBox CREATE_Elements
    {
      [DebuggerNonUserCode] get => this._CREATE_Elements;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CREATE_Elements = value;
    }

    internal virtual Panel CREATE_Panel_Kepler
    {
      [DebuggerNonUserCode] get => this._CREATE_Panel_Kepler;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CREATE_Panel_Kepler = value;
    }

    internal virtual Label Label114
    {
      [DebuggerNonUserCode] get => this._Label114;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label114 = value;
    }

    internal virtual HScrollBar Create_Defil_TA
    {
      [DebuggerNonUserCode] get => this._Create_Defil_TA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Create_Defil_TA_Scroll);
        if (this._Create_Defil_TA != null)
          this._Create_Defil_TA.Scroll -= scrollEventHandler;
        this._Create_Defil_TA = value;
        if (this._Create_Defil_TA == null)
          return;
        this._Create_Defil_TA.Scroll += scrollEventHandler;
      }
    }

    internal virtual Label Label115
    {
      [DebuggerNonUserCode] get => this._Label115;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label115 = value;
    }

    internal virtual HScrollBar Create_Defil_AOP
    {
      [DebuggerNonUserCode] get => this._Create_Defil_AOP;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Create_Defil_AOP_Scroll);
        if (this._Create_Defil_AOP != null)
          this._Create_Defil_AOP.Scroll -= scrollEventHandler;
        this._Create_Defil_AOP = value;
        if (this._Create_Defil_AOP == null)
          return;
        this._Create_Defil_AOP.Scroll += scrollEventHandler;
      }
    }

    internal virtual TextBox CREATE_Bstar
    {
      [DebuggerNonUserCode] get => this._CREATE_Bstar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_Bstar_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_Bstar_KeyPress);
        if (this._CREATE_Bstar != null)
        {
          this._CREATE_Bstar.TextChanged -= eventHandler;
          this._CREATE_Bstar.KeyPress -= pressEventHandler;
        }
        this._CREATE_Bstar = value;
        if (this._CREATE_Bstar == null)
          return;
        this._CREATE_Bstar.TextChanged += eventHandler;
        this._CREATE_Bstar.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label116
    {
      [DebuggerNonUserCode] get => this._Label116;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label116 = value;
    }

    internal virtual HScrollBar Create_Defil_RAAN
    {
      [DebuggerNonUserCode] get => this._Create_Defil_RAAN;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Create_Defil_RAAN_Scroll);
        if (this._Create_Defil_RAAN != null)
          this._Create_Defil_RAAN.Scroll -= scrollEventHandler;
        this._Create_Defil_RAAN = value;
        if (this._Create_Defil_RAAN == null)
          return;
        this._Create_Defil_RAAN.Scroll += scrollEventHandler;
      }
    }

    internal virtual HScrollBar Create_Defil_INC
    {
      [DebuggerNonUserCode] get => this._Create_Defil_INC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Create_Defil_INC_Scroll);
        if (this._Create_Defil_INC != null)
          this._Create_Defil_INC.Scroll -= scrollEventHandler;
        this._Create_Defil_INC = value;
        if (this._Create_Defil_INC == null)
          return;
        this._Create_Defil_INC.Scroll += scrollEventHandler;
      }
    }

    internal virtual HScrollBar Create_Defil_ECC
    {
      [DebuggerNonUserCode] get => this._Create_Defil_ECC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Create_Defil_ECC_Scroll);
        if (this._Create_Defil_ECC != null)
          this._Create_Defil_ECC.Scroll -= scrollEventHandler;
        this._Create_Defil_ECC = value;
        if (this._Create_Defil_ECC == null)
          return;
        this._Create_Defil_ECC.Scroll += scrollEventHandler;
      }
    }

    internal virtual HScrollBar Create_Defil_SMA
    {
      [DebuggerNonUserCode] get => this._Create_Defil_SMA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        ScrollEventHandler scrollEventHandler = new ScrollEventHandler(this.Create_Defil_SMA_Scroll);
        if (this._Create_Defil_SMA != null)
          this._Create_Defil_SMA.Scroll -= scrollEventHandler;
        this._Create_Defil_SMA = value;
        if (this._Create_Defil_SMA == null)
          return;
        this._Create_Defil_SMA.Scroll += scrollEventHandler;
      }
    }

    internal virtual Label Label117
    {
      [DebuggerNonUserCode] get => this._Label117;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label117 = value;
    }

    internal virtual TextBox CREATE_LNG
    {
      [DebuggerNonUserCode] get => this._CREATE_LNG;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CREATE_LNG = value;
    }

    internal virtual Label Label120
    {
      [DebuggerNonUserCode] get => this._Label120;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label120 = value;
    }

    internal virtual Label Label122
    {
      [DebuggerNonUserCode] get => this._Label122;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label122 = value;
    }

    internal virtual Label Label123
    {
      [DebuggerNonUserCode] get => this._Label123;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label123 = value;
    }

    internal virtual Label Label126
    {
      [DebuggerNonUserCode] get => this._Label126;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label126 = value;
    }

    internal virtual Label Label127
    {
      [DebuggerNonUserCode] get => this._Label127;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label127 = value;
    }

    internal virtual Label Label128
    {
      [DebuggerNonUserCode] get => this._Label128;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label128 = value;
    }

    internal virtual TextBox CREATE_TA
    {
      [DebuggerNonUserCode] get => this._CREATE_TA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_TA_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_TA_KeyPress);
        if (this._CREATE_TA != null)
        {
          this._CREATE_TA.TextChanged -= eventHandler;
          this._CREATE_TA.KeyPress -= pressEventHandler;
        }
        this._CREATE_TA = value;
        if (this._CREATE_TA == null)
          return;
        this._CREATE_TA.TextChanged += eventHandler;
        this._CREATE_TA.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_AOP
    {
      [DebuggerNonUserCode] get => this._CREATE_AOP;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_AOP_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_AOP_KeyPress);
        if (this._CREATE_AOP != null)
        {
          this._CREATE_AOP.TextChanged -= eventHandler;
          this._CREATE_AOP.KeyPress -= pressEventHandler;
        }
        this._CREATE_AOP = value;
        if (this._CREATE_AOP == null)
          return;
        this._CREATE_AOP.TextChanged += eventHandler;
        this._CREATE_AOP.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_RAAN
    {
      [DebuggerNonUserCode] get => this._CREATE_RAAN;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_RAAN_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_RAAN_KeyPress);
        if (this._CREATE_RAAN != null)
        {
          this._CREATE_RAAN.TextChanged -= eventHandler;
          this._CREATE_RAAN.KeyPress -= pressEventHandler;
        }
        this._CREATE_RAAN = value;
        if (this._CREATE_RAAN == null)
          return;
        this._CREATE_RAAN.TextChanged += eventHandler;
        this._CREATE_RAAN.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_INC
    {
      [DebuggerNonUserCode] get => this._CREATE_INC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_INC_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_INC_KeyPress);
        if (this._CREATE_INC != null)
        {
          this._CREATE_INC.TextChanged -= eventHandler;
          this._CREATE_INC.KeyPress -= pressEventHandler;
        }
        this._CREATE_INC = value;
        if (this._CREATE_INC == null)
          return;
        this._CREATE_INC.TextChanged += eventHandler;
        this._CREATE_INC.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_ECC
    {
      [DebuggerNonUserCode] get => this._CREATE_ECC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_ECC_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_ECC_KeyPress);
        if (this._CREATE_ECC != null)
        {
          this._CREATE_ECC.TextChanged -= eventHandler;
          this._CREATE_ECC.KeyPress -= pressEventHandler;
        }
        this._CREATE_ECC = value;
        if (this._CREATE_ECC == null)
          return;
        this._CREATE_ECC.TextChanged += eventHandler;
        this._CREATE_ECC.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_SMA
    {
      [DebuggerNonUserCode] get => this._CREATE_SMA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_SMA_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_SMA_KeyPress);
        if (this._CREATE_SMA != null)
        {
          this._CREATE_SMA.TextChanged -= eventHandler;
          this._CREATE_SMA.KeyPress -= pressEventHandler;
        }
        this._CREATE_SMA = value;
        if (this._CREATE_SMA == null)
          return;
        this._CREATE_SMA.TextChanged += eventHandler;
        this._CREATE_SMA.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label129
    {
      [DebuggerNonUserCode] get => this._Label129;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label129 = value;
    }

    internal virtual Label Label131
    {
      [DebuggerNonUserCode] get => this._Label131;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label131 = value;
    }

    internal virtual Label Label132
    {
      [DebuggerNonUserCode] get => this._Label132;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label132 = value;
    }

    internal virtual Label Label142
    {
      [DebuggerNonUserCode] get => this._Label142;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label142 = value;
    }

    internal virtual Label Label143
    {
      [DebuggerNonUserCode] get => this._Label143;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label143 = value;
    }

    internal virtual Label Label144
    {
      [DebuggerNonUserCode] get => this._Label144;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label144 = value;
    }

    internal virtual Panel CREATE_Panel_Cartesian
    {
      [DebuggerNonUserCode] get => this._CREATE_Panel_Cartesian;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._CREATE_Panel_Cartesian = value;
    }

    internal virtual Label Label145
    {
      [DebuggerNonUserCode] get => this._Label145;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label145 = value;
    }

    internal virtual Label Label146
    {
      [DebuggerNonUserCode] get => this._Label146;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label146 = value;
    }

    internal virtual Label Label147
    {
      [DebuggerNonUserCode] get => this._Label147;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label147 = value;
    }

    internal virtual Label Label148
    {
      [DebuggerNonUserCode] get => this._Label148;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label148 = value;
    }

    internal virtual Label Label149
    {
      [DebuggerNonUserCode] get => this._Label149;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label149 = value;
    }

    internal virtual Label Label150
    {
      [DebuggerNonUserCode] get => this._Label150;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label150 = value;
    }

    internal virtual Label Label151
    {
      [DebuggerNonUserCode] get => this._Label151;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label151 = value;
    }

    internal virtual Label Label152
    {
      [DebuggerNonUserCode] get => this._Label152;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label152 = value;
    }

    internal virtual Label Label157
    {
      [DebuggerNonUserCode] get => this._Label157;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label157 = value;
    }

    internal virtual Label Label158
    {
      [DebuggerNonUserCode] get => this._Label158;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label158 = value;
    }

    internal virtual Label Label159
    {
      [DebuggerNonUserCode] get => this._Label159;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label159 = value;
    }

    internal virtual Label Label160
    {
      [DebuggerNonUserCode] get => this._Label160;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label160 = value;
    }

    internal virtual TextBox CREATE_VZ
    {
      [DebuggerNonUserCode] get => this._CREATE_VZ;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_VZ_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_VZ_KeyPress);
        if (this._CREATE_VZ != null)
        {
          this._CREATE_VZ.TextChanged -= eventHandler;
          this._CREATE_VZ.KeyPress -= pressEventHandler;
        }
        this._CREATE_VZ = value;
        if (this._CREATE_VZ == null)
          return;
        this._CREATE_VZ.TextChanged += eventHandler;
        this._CREATE_VZ.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_VY
    {
      [DebuggerNonUserCode] get => this._CREATE_VY;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_VY_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_VY_KeyPress);
        if (this._CREATE_VY != null)
        {
          this._CREATE_VY.TextChanged -= eventHandler;
          this._CREATE_VY.KeyPress -= pressEventHandler;
        }
        this._CREATE_VY = value;
        if (this._CREATE_VY == null)
          return;
        this._CREATE_VY.TextChanged += eventHandler;
        this._CREATE_VY.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_VX
    {
      [DebuggerNonUserCode] get => this._CREATE_VX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_VX_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_VX_KeyPress);
        if (this._CREATE_VX != null)
        {
          this._CREATE_VX.TextChanged -= eventHandler;
          this._CREATE_VX.KeyPress -= pressEventHandler;
        }
        this._CREATE_VX = value;
        if (this._CREATE_VX == null)
          return;
        this._CREATE_VX.TextChanged += eventHandler;
        this._CREATE_VX.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_Z
    {
      [DebuggerNonUserCode] get => this._CREATE_Z;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_Z_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_Z_KeyPress);
        if (this._CREATE_Z != null)
        {
          this._CREATE_Z.TextChanged -= eventHandler;
          this._CREATE_Z.KeyPress -= pressEventHandler;
        }
        this._CREATE_Z = value;
        if (this._CREATE_Z == null)
          return;
        this._CREATE_Z.TextChanged += eventHandler;
        this._CREATE_Z.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_Y
    {
      [DebuggerNonUserCode] get => this._CREATE_Y;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_Y_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_Y_KeyPress);
        if (this._CREATE_Y != null)
        {
          this._CREATE_Y.TextChanged -= eventHandler;
          this._CREATE_Y.KeyPress -= pressEventHandler;
        }
        this._CREATE_Y = value;
        if (this._CREATE_Y == null)
          return;
        this._CREATE_Y.TextChanged += eventHandler;
        this._CREATE_Y.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox CREATE_X
    {
      [DebuggerNonUserCode] get => this._CREATE_X;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_X_TextChanged);
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CREATE_X_KeyPress);
        if (this._CREATE_X != null)
        {
          this._CREATE_X.TextChanged -= eventHandler;
          this._CREATE_X.KeyPress -= pressEventHandler;
        }
        this._CREATE_X = value;
        if (this._CREATE_X == null)
          return;
        this._CREATE_X.TextChanged += eventHandler;
        this._CREATE_X.KeyPress += pressEventHandler;
      }
    }

    internal virtual Button CREATE_Save
    {
      [DebuggerNonUserCode] get => this._CREATE_Save;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CREATE_Save_Click);
        if (this._CREATE_Save != null)
          this._CREATE_Save.Click -= eventHandler;
        this._CREATE_Save = value;
        if (this._CREATE_Save == null)
          return;
        this._CREATE_Save.Click += eventHandler;
      }
    }

    internal virtual SaveFileDialog SaveFileDialog1
    {
      [DebuggerNonUserCode] get => this._SaveFileDialog1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SaveFileDialog1 = value;
    }

    internal virtual Button OpenOrbitWizard
    {
      [DebuggerNonUserCode] get => this._OpenOrbitWizard;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OpenOrbitWizard_Click);
        if (this._OpenOrbitWizard != null)
          this._OpenOrbitWizard.Click -= eventHandler;
        this._OpenOrbitWizard = value;
        if (this._OpenOrbitWizard == null)
          return;
        this._OpenOrbitWizard.Click += eventHandler;
      }
    }

    internal virtual Button GS_Actualise
    {
      [DebuggerNonUserCode] get => this._GS_Actualise;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.GS_Actualise_Click);
        if (this._GS_Actualise != null)
          this._GS_Actualise.Click -= eventHandler;
        this._GS_Actualise = value;
        if (this._GS_Actualise == null)
          return;
        this._GS_Actualise.Click += eventHandler;
      }
    }

    internal virtual PictureBox orbit3dWeb
    {
      [DebuggerNonUserCode] get => this._orbit3dWeb;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._orbit3dWeb = value;
    }

    internal virtual GroupBox GroupBox10
    {
      [DebuggerNonUserCode] get => this._GroupBox10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox10 = value;
    }

    internal virtual DataGridView Raw_Data_GridView
    {
      [DebuggerNonUserCode] get => this._Raw_Data_GridView;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Raw_Data_GridView = value;
    }

    internal virtual DataGridViewTextBoxColumn Line
    {
      [DebuggerNonUserCode] get => this._Line;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Line = value;
    }

    internal virtual DataGridViewTextBoxColumn Column
    {
      [DebuggerNonUserCode] get => this._Column;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Column = value;
    }

    internal virtual DataGridViewTextBoxColumn Value
    {
      [DebuggerNonUserCode] get => this._Value;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Value = value;
    }

    internal virtual DataGridViewTextBoxColumn Description
    {
      [DebuggerNonUserCode] get => this._Description;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Description = value;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public Home()
    {
      this.Load += new EventHandler(this.Load_App_1);
      this.FormClosing += new FormClosingEventHandler(this.Load_App_2);
      this.Resize += new EventHandler(this.Home_Resize);
      Home.__ENCAddToList((object) this);
      this.AppPath = "C:\\TLEAnalyser\\";
      this.FavPath = this.AppPath + "FAV\\";
      this.TLEPath = this.AppPath + "TLE\\";
      this.CATPath = this.AppPath + "CATALOG\\";
      this.PersonalTLEPath = this.AppPath + "TLE\\PERSO\\";
      this.PlotPath = this.AppPath + "PLOT\\";
      this.GMATPath = this.AppPath + "GMAT\\";
      this.CELESTIAPath = this.AppPath + "CELESTIA\\";
      this.GOOGLEPath = this.AppPath + "GOOGLEEARTH\\";
      this.Orbit3DPath = this.AppPath + "ORBIT3D\\";
      this.EXPORTPath = this.AppPath + "EXPORT\\";
      this.FavAdress = this.FavPath + "favorites.txt";
      this.SearchAdress = this.FavPath + "search.txt";
      this.StationsFile = this.AppPath + "GroundStations.txt";
      this.UMFile = this.AppPath + "UM.pdf";
      this.InitFile = this.AppPath + "tlea.ini";
      this.SatCat = this.CATPath + "satcat.txt";
      this.SatCatAnn = this.CATPath + "satcat-annex.txt";
      this.SatCatSources = this.CATPath + "satcat_sources.txt";
      this.SatCatSites = this.CATPath + "satcat_sites.txt";
      this.CheckVersionFile = (object) "http://www.loylart.com/tleanalyser/version.txt";
      this.radarTraceLine = new PointF[10001];
      this.SunZone = new PointF[361];
      this.SatTrace = new object[361, 7];
      this.VisibiltyZone = new PointF[361];
      this.Stations = new string[7, 7];
      this.Satellites = new string[1, 6];
      this.SatLatLng = new string[1, 3];
      this.Soleil = new Soleil();
      this.TLEAVersionMajor = (object) MyProject.Application.Info.Version.Major;
      this.TLEAVersionMinor = (object) MyProject.Application.Info.Version.Minor;
      this.TLEAVersion = Operators.ConcatenateObject(Operators.ConcatenateObject(this.TLEAVersionMajor, (object) "."), this.TLEAVersionMinor);
      this.chemin_fichier = "";
      this.InitializeComponent();
      this.Orbit3DControl_ = new Orbit3DControl();
      this.Orbit3DControl_.Dock = DockStyle.Fill;
      this.MAP_MainTab.TabPages[1].Controls.Add((Control) this.Orbit3DControl_);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void Load_App_1(object sender, EventArgs e)
    {
      this.AppLoaded = false;
      Functions.CreateTLEFolder();
      Functions.CreateFolders();
      Functions.SetCulture("");
      Functions.CheckNetwork();
      Functions.ReadInit();
      Functions.SaveInit();
      if (this.CheckNW)
        Functions.CheckVersion();
      this.Text = Conversions.ToString(Operators.ConcatenateObject((object) "TLE ANALYSER V", this.TLEAVersion));
      int num1 = 0;
      this.TLE_ListBox.Items.Clear();
      FileSystem.FileOpen(1, "C:\\TLEAnalyser\\TLE\\TLEList.txt", OpenMode.Input);
      while (!FileSystem.EOF(1))
      {
        string str = FileSystem.LineInput(1) + ".txt";
        this.TLE_ListBox.Items.Add((object) str);
        int num2 = TLE.VerifieFichier(this.TLEPath + str, true);
        checked { num1 += num2; }
        if (num2 == 0)
        {
          int num3 = (int) TopMostMessageBox.Show(str + " is corrupted. Please load it again with Update tool in Options module.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
      }
      FileSystem.FileClose(1);
      FileSystem.FileOpen(1, "C:\\TLEAnalyser\\TLE\\SuppList.txt", OpenMode.Input);
      while (!FileSystem.EOF(1))
      {
        string str = FileSystem.LineInput(1) + ".txt";
        this.TLE_ListBox.Items.Add((object) str);
        TLE.VerifieFichier(this.TLEPath + str, true);
        int num4 = TLE.VerifieFichier(this.TLEPath + str, true);
        checked { num1 += num4; }
        if (num4 == 0)
        {
          int num5 = (int) TopMostMessageBox.Show(str + " is corrupted. Please load it again with Update tool in Options module.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
      }
      FileSystem.FileClose(1);
      this.CollectionLabel.Text = "Collections (" + Conversions.ToString(num1) + " TLE)";
      string favPath = this.FavPath;
      string[] files = Directory.GetFiles(favPath);
      int num6 = checked (Directory.GetFiles(favPath).Length - 1);
      int index = 0;
      while (index <= num6)
      {
        string StringCheck = files[index];
        string str = StringCheck.Remove(0, Strings.InStrRev(StringCheck, "\\"));
        if (str.StartsWith("fleet_"))
          this.TLE_ListBox.Items.Add((object) str);
        checked { ++index; }
      }
      Functions.Init_RawDataGrid();
      if (!this.CheckNW)
      {
        int num7 = (int) TopMostMessageBox.Show("You must be connected to access to Google Earth/Maps functions", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        this.MAP_MainTab.SelectTab(1);
        this.GEart2Actualise = false;
      }
      Functions.InitGraphics();
      this.Stations_Load();
      ToolTip toolTip = new ToolTip();
      toolTip.AutoPopDelay = 6000;
      toolTip.InitialDelay = 500;
      toolTip.ReshowDelay = 100;
      toolTip.ShowAlways = true;
      toolTip.IsBalloon = true;
      toolTip.SetToolTip((Control) this.TLE_Search_But, "Advanced Search");
      toolTip.SetToolTip((Control) this.Fleet_Add, "Add a satellite to a GMAT fleet");
      toolTip.SetToolTip((Control) this.Fleet_Remove, "Clear GMAT fleet");
      toolTip.SetToolTip((Control) this.SIM_Backward, "Backward");
      toolTip.SetToolTip((Control) this.SIM_Backward_SbS, "Step by step backward");
      toolTip.SetToolTip((Control) this.SIM_Pause, "Stop/Pause");
      toolTip.SetToolTip((Control) this.SIM_Foreward_SbS, "Step by step foreward");
      toolTip.SetToolTip((Control) this.SIM_Forward, "Foreward");
      toolTip.SetToolTip((Control) this.SIM_Actu_Track, "Actualise the track");
      toolTip.SetToolTip((Control) this.OpenOrbitWizard, "Send to Orbit Wizard");
      toolTip.SetToolTip((Control) this.Fleet_Create, "Create a fleet");
      toolTip.SetToolTip((Control) this.Fleet_Add, "Add a Satellite in a fleet");
      toolTip.SetToolTip((Control) this.Fleet_Remove, "Remove a Satellite from a fleet");
      toolTip.SetToolTip((Control) this.Fleet_Delete, "Delete a fleet");
      this.AppLoaded = true;
      this.FirstTLELoaded = false;
    }

    private void Load_App_2(object sender, CancelEventArgs e)
    {
      try
      {
        if (TopMostMessageBox.Show("Exit TLE Analyser ?", "TLE Analyser", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.No)
        {
          e.Cancel = true;
        }
        else
        {
          if (MyProject.Computer.FileSystem.FileExists(this.GOOGLEPath + "GoogleEarth.htm"))
            File.Delete(this.GOOGLEPath + "GoogleEarth.htm");
          if (!MyProject.Computer.FileSystem.DirectoryExists(this.Orbit3DPath))
            return;
          Directory.Delete(this.Orbit3DPath, true);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) TopMostMessageBox.Show("An error as occured at TLE Analyser closing.\r\n" + ex.Message + "\r\n\r\nDocument: 'home.vb'\r\nBloc: 'Graph_DrawSat'", "TLE ANALYSER - Error");
        this.Cursor = Cursors.Default;
        ProjectData.ClearProjectError();
      }
    }

    private void GoogleMapTab_Selected_2(object sender, TabControlCancelEventArgs e)
    {
      if (!this.CheckNW)
      {
        e.Cancel = true;
        int num = (int) TopMostMessageBox.Show("You must be connected to access to Google Earth functions", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      if (Functions.CheckNetwork() || this.MAP_MainTab.SelectedIndex != 1)
        return;
      e.Cancel = true;
    }

    private void GoogleMapTab_Selected_1(object sender, EventArgs e)
    {
      if (this.MAP_MainTab.SelectedIndex == 0)
      {
        this.MAP_FullGrid.Enabled = true;
        this.MAP_PtsOnOrbit.Enabled = true;
        this.MAP_Show_FullTrack.Enabled = true;
        this.MAP_SatName.Enabled = true;
        this.MAP_VisibilityZone.Enabled = true;
        Functions.InitGraphics();
        this.Graph_Actualise(this.TLELoaded);
      }
      else if (this.MAP_MainTab.SelectedIndex == 1 && this.TLELoaded)
      {
        this.MAP_FullGrid.Enabled = false;
        this.MAP_PtsOnOrbit.Enabled = false;
        this.MAP_Show_FullTrack.Enabled = false;
        this.MAP_SatName.Enabled = false;
        this.MAP_VisibilityZone.Enabled = false;
        if (this.GEart2Actualise)
        {
          this.GoogleEarthControl1.InitOrb();
          this.GoogleEarthControl1.CreateTrace();
          if (this.TLELoaded)
            this.GoogleEarthControl1.InitialViewF();
          this.Graph_Actualise(true);
          this.GEart2Actualise = false;
        }
      }
    }

    private void AboutMenuStrip_Click(object sender, EventArgs e) => this.Appli_About();

    private void HelpMenuStrip_Click(object sender, EventArgs e) => this.Appli_Help();

    private void ExitMenuStrip_Click(object sender, EventArgs e) => this.Appli_Exit();

    private void ButtonMenu_New_Click(object sender, EventArgs e)
    {
      this.TLETextBox.Enabled = true;
      this.TLETextBox.Text = "";
      this.TLETextBox.Focus();
      Functions.Init_RawDataGrid();
      this.Sat_CheckListBox.Items.Clear();
      this.TLETextBox.ReadOnly = false;
      this.ButtonMenu_Import.Enabled = false;
      this.GroupBox1.Height = 81;
    }

    private void ButtonMenu_Modify_Click(object sender, EventArgs e)
    {
      this.TLETextBox.ReadOnly = false;
      this.TLETextBox.ForeColor = Color.Red;
      this.ButtonMenu_Import.Enabled = true;
    }

    private void ButtonMenu_Import_Click(object sender, EventArgs e)
    {
      if (this.TLETextBox.ForeColor == Color.Black)
        this.SATNAME = Interaction.InputBox("Please enter a Satellite Name:");
      this.TLE_Import();
      this.TLE_Detail();
      this.ButtonMenu_Import.Enabled = false;
    }

    private void ButtonMenu_GMAT_Click(object sender, EventArgs e) => Functions.ExportToGMAT();

    private void ButtonMenu_GMAT_M_Click(object sender, EventArgs e)
    {
      this.FleetManagerMode = "export";
      MyProject.Forms.Dialog_Fleet.Show();
    }

    private void ButtonMenu_Summ_Click(object sender, EventArgs e) => this.TLE_Report();

    private void ButtonMenu_About_Click(object sender, EventArgs e) => this.Appli_About();

    private void ButtonMenu_Help_Click(object sender, EventArgs e) => this.Appli_Help();

    private void ButtonMenu_Exit_Click(object sender, EventArgs e) => this.Appli_Exit();

    private void ButtonMenu_Options_Click(object sender, EventArgs e) => this.Appli_Options();

    private void ButtonMenu_OpenF_Click(object sender, EventArgs e) => Process.Start(this.AppPath);

    private void ButtonMenu_Stations_Click(object sender, EventArgs e) => this.Appli_Stations();

    private void ButtonMenu_Charts_Click(object sender, EventArgs e)
    {
      if (this.APA > 400.0 && this.PEA > 400.0)
      {
        int num = (int) Interaction.MsgBox((object) "XY Plots are only available for low earth orbits (400x400 kms max)", MsgBoxStyle.Exclamation, (object) "XY Plots");
      }
      else
      {
        MyProject.Forms.ChartForm.Show();
        if (this.MM > 0.99 && this.MM < 1.01 && this.ECC < 0.01 && this.INC < 1.0)
          MyProject.Forms.ChartForm.CHART_LNG.Enabled = true;
        else
          MyProject.Forms.ChartForm.CHART_LNG.Enabled = false;
        MyProject.Forms.ChartForm.CHARTS_Unit.SelectedIndex = 0;
      }
    }

    private void OpenOrbitWizard_Click(object sender, EventArgs e)
    {
      if (!this.TLELoaded)
        return;
      this.Sat_CheckListBox.ForeColor = Color.Gray;
      if (this.Sat_CheckListBox.SelectedIndex != -1)
        this.Sat_CheckListBox.SetSelected(this.Sat_CheckListBox.SelectedIndex, false);
      this.TLE_MainPage.SelectedIndex = 3;
      this.CreateFirstOpen = true;
      this.CREATE_EPOCH_Current.Text = Functions.MJDtoGreg(Conversions.ToString(this.EPOCH));
      this.CREATE_Default.SelectedIndex = 0;
      this.CREATE_SMA.Text = Conversions.ToString(this.SMA);
      this.CREATE_ECC.Text = Conversions.ToString(this.ECC);
      this.CREATE_INC.Text = Conversions.ToString(this.INC);
      this.CREATE_RAAN.Text = Conversions.ToString(this.RAAN);
      this.CREATE_AOP.Text = Conversions.ToString(this.AOP);
      this.CREATE_TA.Text = Conversions.ToString(180.0 / Math.PI * this.TA);
      this.CREATE_Bstar.Text = Conversions.ToString(this.BSTAR);
      this.SMACr = this.SMA;
      this.ECCCr = this.ECC;
      this.INCCr = this.INC;
      this.RAANCr = this.RAAN;
      this.AOPCr = this.AOP;
      this.TACr = 180.0 / Math.PI * this.TA;
      this.CREATE_Collection.Text = Strings.Mid(Conversions.ToString(this.TLE_ListBox.SelectedItem), 1, Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(this.TLE_ListBox.SelectedItem, (Type) null, "length", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 4)));
      this.CREATE_ScName.Text = this.SATNAME;
      this.CREATE_SatNumb.Text = this.Spacecraft.Text;
      this.Refresh_TLE();
      this.CreateFirstOpen = false;
    }

    private void Fleet_Create_Click(object sender, EventArgs e)
    {
      string str1 = Interaction.InputBox("Enter a Fleet name:");
      if ((object) str1 == (object) "")
        str1 = "fleet";
      string str2 = "fleet_" + str1 + ".txt";
      File.AppendAllText(this.FavPath + str2, "");
      this.TLE_ListBox.Items.Add((object) str2);
    }

    private void Fleet_Add_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(Conversions.ToString(this.Sat_CheckListBox.SelectedItem), "", false) == 0)
      {
        int num = (int) TopMostMessageBox.Show("You must select a satellite in the list !", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        this.FleetManagerMode = "add";
        MyProject.Forms.Dialog_Fleet.Show();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public void Fleet_Add_F()
    {
      bool flag = false;
      try
      {
        if (MyProject.Computer.FileSystem.FileExists(this.FleetFile))
        {
          FileSystem.FileOpen(1, this.FleetFile, OpenMode.Input);
          while (!FileSystem.EOF(1))
          {
            FileSystem.LineInput(1);
            if (Operators.CompareString(FileSystem.LineInput(1), this.Satellites[this.Sat_CheckListBox.SelectedIndex, 2], false) == 0)
            {
              int num = (int) TopMostMessageBox.Show(Conversions.ToString(this.Sat_CheckListBox.SelectedItem) + " is already saved in " + this.FleetFile, "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
              flag = true;
            }
          }
          FileSystem.FileClose(1);
        }
        if (flag)
          return;
        File.AppendAllText(this.FleetFile, this.Satellites[this.Sat_CheckListBox.SelectedIndex, 0] + "\r\n" + this.Satellites[this.Sat_CheckListBox.SelectedIndex, 2] + "\r\n");
        int num1 = (int) TopMostMessageBox.Show(Conversions.ToString(this.Sat_CheckListBox.SelectedItem) + " has been added in " + this.FleetFile, "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) TopMostMessageBox.Show(ex.Message + "\r\n\r\nDocument: 'home.vb'\r\nBloc: 'PersonalFleet_SaveInto'", "TLE ANALYSER - Error");
        FileSystem.FileClose(1);
        ProjectData.ClearProjectError();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void Fleet_Remove_Click(object sender, EventArgs e)
    {
      string[] strArray1 = new string[2001];
      string[] strArray2 = new string[2001];
      int index = 0;
      object objectValue = RuntimeHelpers.GetObjectValue(this.TLE_ListBox.SelectedItem);
      int integer = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(objectValue, (Type) null, "Length", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 4));
      object Instance = objectValue;
      object[] objArray = new object[2]
      {
        (object) integer,
        (object) 4
      };
      object[] Arguments = objArray;
      bool[] flagArray = new bool[2]{ true, false };
      bool[] CopyBack = flagArray;
      object obj = NewLateBinding.LateGet(Instance, (Type) null, "Remove", Arguments, (string[]) null, (Type[]) null, CopyBack);
      if (flagArray[0])
      {
        int num1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (int));
      }
      string str = Conversions.ToString(obj) + "_.txt";
      File.AppendAllText(this.FavPath + str, "");
      bool flag = false;
      this.DeleteFavMode = true;
      if (Operators.CompareString(Conversions.ToString(this.Sat_CheckListBox.SelectedItem), "", false) == 0)
      {
        int num2 = (int) TopMostMessageBox.Show("You must select a satellite in the list !", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        try
        {
          string satellite;
          if (MyProject.Computer.FileSystem.FileExists(Conversions.ToString(Operators.ConcatenateObject((object) this.FavPath, objectValue))))
          {
            FileSystem.FileOpen(1, Conversions.ToString(Operators.ConcatenateObject((object) this.FavPath, objectValue)), OpenMode.Input);
            while (!FileSystem.EOF(1))
            {
              strArray1[index] = FileSystem.LineInput(1);
              strArray2[index] = FileSystem.LineInput(1);
              if (Operators.CompareString(strArray2[index], this.Satellites[this.Sat_CheckListBox.SelectedIndex, 2], false) == 0)
              {
                flag = true;
                satellite = this.Satellites[this.Sat_CheckListBox.SelectedIndex, 1];
              }
              else
                File.AppendAllText(this.FavPath + str, strArray1[index] + "\r\n" + strArray2[index] + "\r\n");
              checked { ++index; }
            }
            FileSystem.FileClose(1);
            if (!flag)
            {
              int num3 = (int) TopMostMessageBox.Show(Conversions.ToString(this.Sat_CheckListBox.SelectedItem) + " wasn't find in fleet file.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
              MyProject.Computer.FileSystem.DeleteFile(this.FavPath + "\\" + str);
            }
          }
          if (flag)
          {
            MyProject.Computer.FileSystem.DeleteFile(Conversions.ToString(Operators.ConcatenateObject((object) this.FavPath, objectValue)));
            MyProject.Computer.FileSystem.RenameFile(this.FavPath + "\\" + str, Conversions.ToString(objectValue));
            if (Operators.ConditionalCompareObjectEqual((object) Conversions.ToString(this.TLE_ListBox.SelectedItem), objectValue, false))
              this.Sat_CheckListBox.Items.Remove((object) satellite);
            this.TLE_ListBox.SelectedItem = RuntimeHelpers.GetObjectValue(objectValue);
            this.TLE_OpenFile(Conversions.ToString(Operators.ConcatenateObject((object) this.FavPath, objectValue)));
            int num4 = (int) TopMostMessageBox.Show(Conversions.ToString(Operators.ConcatenateObject((object) (satellite + " has been deleted from " + this.FavPath), objectValue)), "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
          }
          this.DeleteFavMode = false;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num5 = (int) TopMostMessageBox.Show(ex.Message + "\r\n\r\nDocument: 'home.vb'\r\nBloc: 'PersonalFleet_DeleteFrom'", "TLE ANALYSER - Error");
          ProjectData.ClearProjectError();
        }
      }
    }

    private void Fleet_Delete_Click(object sender, EventArgs e)
    {
      this.FleetManagerMode = "delete";
      MyProject.Forms.Dialog_Fleet.Show();
    }

    public void Fleet_Delete_F()
    {
label_1:
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = -2;
label_2:
        int num3 = 2;
        string str = this.FleetFile.Remove(0, Strings.InStrRev(this.FleetFile, "\\"));
label_3:
        num3 = 3;
        File.Delete(this.FleetFile);
label_4:
        num3 = 4;
        this.TLE_ListBox.Items.Remove((object) str);
        goto label_11;
label_6:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num4 = num2 + 1;
            num2 = 0;
            switch (num4)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
                goto label_11;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_6;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_11:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public void TLE_Report()
    {
label_1:
      int num1;
      int num2;
      try
      {
        int num3 = 1;
        MyProject.Forms.OrbitSummary.Show();
label_2:
        ProjectData.ClearProjectError();
        num1 = -2;
label_3:
        num3 = 3;
        if (this.EPOCH_Format.SelectedIndex != 0)
          goto label_5;
label_4:
        num3 = 4;
        string str1 = Functions.MJDtoGreg(Conversions.ToString(Conversion.Val(this.EPOCH_Current.Text)));
        goto label_7;
label_5:
        num3 = 6;
label_6:
        num3 = 7;
        str1 = this.EPOCH_Current.Text;
label_7:
label_8:
        num3 = 9;
        if (Operators.CompareString(this.LANType.Text, "[0;360]", false) != 0)
          goto label_14;
label_9:
        num3 = 10;
        if (Conversion.Val(this.LANBox.Text) >= 360.0 || Conversion.Val(this.LANBox.Text) <= 180.0)
          goto label_11;
label_10:
        num3 = 11;
        string str2 = Conversions.ToString(Math.Round(360.0 - Conversion.Val(this.LANBox.Text), 2)) + " W";
        goto label_13;
label_11:
        num3 = 13;
        if (Conversion.Val(this.LANBox.Text) >= 180.0 || Conversion.Val(this.LANBox.Text) <= 0.0)
          goto label_13;
label_12:
        num3 = 14;
        str2 = Conversions.ToString(Math.Round(Conversion.Val(this.LANBox.Text), 2)) + " E";
label_13:
        goto label_20;
label_14:
        num3 = 17;
        if (Operators.CompareString(this.LANType.Text, "[-180;180]", false) != 0)
          goto label_20;
label_15:
        num3 = 18;
        if (Conversion.Val(this.LANBox.Text) >= 0.0)
          goto label_17;
label_16:
        num3 = 19;
        str2 = Conversions.ToString(Math.Abs(Math.Round(Conversion.Val(this.LANBox.Text), 2))) + " W";
        goto label_19;
label_17:
        num3 = 21;
        if (Conversion.Val(this.LANBox.Text) <= 0.0)
          goto label_19;
label_18:
        num3 = 22;
        str2 = Conversions.ToString(Math.Round(Conversion.Val(this.LANBox.Text), 2)) + " E";
label_19:
label_20:
label_21:
        num3 = 25;
        MyProject.Forms.OrbitSummary.SUM_Summary.Clear();
label_22:
        num3 = 26;
        MyProject.Forms.OrbitSummary.SUM_Summary.Text = this.SCName.Text + "\r\n--------------------------\r\nEpoch\t" + str1 + "\r\nGST\t" + Conversions.ToString(this.GST) + "\tdeg\r\nLST\t" + Conversions.ToString(this.LST) + "\tdeg\r\nETFE\t" + Conversions.ToString(this.ETFE) + "\tday\r\nONAE\t" + this.ONAE + "\r\n--------------------------\r\nKeplerian Elements:\r\n--------------------------\r\nSMA\t" + Conversions.ToString(this.SMA) + "\tkm\r\nECC\t" + Conversions.ToString(this.ECC) + "\r\nINC\t" + Conversions.ToString(this.INC) + "\tdeg\r\nRAAN\t" + Conversions.ToString(this.RAAN) + "\tdeg\r\nAOP\t" + Conversions.ToString(this.AOP) + "\tdeg\r\n--------------------------\r\nSat. Position:\r\n--------------------------\r\nMA\t" + Conversions.ToString(this.MA) + "\tdeg\r\nTA\t" + Conversions.ToString(180.0 / Math.PI * this.TA) + "\tdeg\r\nEA\t" + Conversions.ToString(180.0 / Math.PI * this.EA) + "\tdeg\r\nETFP\t" + Conversions.ToString(this.ETFP) + "\tmin\r\nα\t" + Conversions.ToString(this.AOL) + "\tdeg\r\nLat\t" + Conversions.ToString(this.LAT) + "\tdeg\r\nLng\t" + Conversions.ToString(this.LONGI) + "\tdeg\r\nSDOO\t" + this.SDOO + "\r\n--------------------------\r\nPhasing\t" + this.phase.Text + "\r\n--------------------------\r\nAltitudes:\r\n--------------------------\r\nApA\t" + Conversions.ToString(this.APA) + "\tkm\r\nPeA\t" + Conversions.ToString(this.PEA) + "\tkm\r\nApR\t" + Conversions.ToString(this.APR) + "\tkm\r\nPeR\t" + Conversions.ToString(this.PER) + "\tkm\r\nALT\t" + Conversions.ToString(this.ALT) + "\tkm\r\nMALT\t" + Conversions.ToString(this.MALT) + "\tkm\r\nDREL\t" + Conversions.ToString(this.DREL) + "\r\n--------------------------\r\nVelocities:\r\n--------------------------\r\nApV\t" + Conversions.ToString(this.APV) + "\tkm/s\r\nPeV\t" + Conversions.ToString(this.PEV) + "\tkm/s\r\nVel\t" + Conversions.ToString(this.VEL) + "\tkm/s\r\n--------------------------\r\nPeriods:\r\n--------------------------\r\nTk\t" + Conversions.ToString(this.KPER) + "\tmin\r\nTa\t" + Conversions.ToString(this.APER) + "\tmin\r\nTd\t" + Conversions.ToString(this.DPER) + "\tmin\r\n--------------------------\r\nMvmts, Precessions:\r\n--------------------------\r\nMM\t" + Conversions.ToString(this.MM) + "\trev/day\r\nNP\t" + Conversions.ToString(this.NP) + "\tdeg/day\r\nAP\t" + Conversions.ToString(this.AP) + "\tdeg/day\r\nDL\t" + this.DLBox.Text + "\tdeg\r\nLAcc\t" + this.LONGACCBox.Text + "\tdeg.j-2\r\n-------------------\r\nCartesian State:\r\n-------------------\r\nX\t" + Conversions.ToString(this.X) + "\tkm\r\nY\t" + Conversions.ToString(this.Y) + "\tkm\r\nZ\t" + Conversions.ToString(this.Z) + "\tkm\r\nVX\t" + Conversions.ToString(this.VX) + "\tkm/s\r\nVY\t" + Conversions.ToString(this.VY) + "\tkm/s\r\nVZ\t" + Conversions.ToString(this.VZ) + "\tkm/s\r\n-------------------\r\nSUN:\r\n-------------------\r\nLat\t" + Conversions.ToString(this.LATS) + "\tdeg\r\nLong\t" + Conversions.ToString(this.LONGIS) + "\tdeg\r\nEclipse\t" + this.EclipseBox.Text;
label_23:
        num3 = 27;
        MyProject.Forms.OrbitSummary.SUM_Summary.Text = MyProject.Forms.OrbitSummary.SUM_Summary.Text + "\r\n-------------------\r\nLine of Node:\r\n-------------------\r\nLAN\t" + Conversions.ToString(this.LAN) + "\tdeg\r\nLTAN\t" + this.LTAN + "\thh:mm:ss\r\nLDN\t" + Conversions.ToString(this.LDN) + "\tdeg\r\nLTDN\t" + this.LTDN + "\thh:mm:ss";
label_24:
        num3 = 28;
        if (!this.AP_GroupBox.Visible)
          goto label_32;
label_25:
        num3 = 29;
        if (!this.CircularPanel.Visible)
          goto label_27;
label_26:
        num3 = 30;
        MyProject.Forms.OrbitSummary.SUM_Summary.Text = MyProject.Forms.OrbitSummary.SUM_Summary.Text + "\r\n-------------------\r\nAdapted Parameters:\r\n-------------------\r\nSMA\t" + this.SMA_AP_ECC.Text + "\tkm\r\nex\t" + this.ex.Text + "\r\ney\t" + this.ey.Text + "\r\nINC\t" + this.INC_AP_ECC.Text + "\tdeg\r\nRAAN\t" + this.RAAN_AP_ECC.Text + "\tdeg\r\nα'\t" + this.AlphaPrime.Text + "\tdeg";
        goto label_31;
label_27:
        num3 = 32;
        if (!this.EquPanel.Visible)
          goto label_29;
label_28:
        num3 = 33;
        MyProject.Forms.OrbitSummary.SUM_Summary.Text = MyProject.Forms.OrbitSummary.SUM_Summary.Text + "\r\n-------------------\r\nAdapted Parameters:\r\n-------------------\r\nSMA\t" + this.SMA_AP_INC.Text + "\tkm\r\nECC\t" + this.ECC_AP_INC.Text + "\r\nix\t" + this.ix.Text + "\r\niy\t" + this.iy.Text + "\r\nω'\t" + this.AOP_AP_INC.Text + "\tdeg\r\nMA\t" + this.MA_AP.Text + "\tdeg";
        goto label_31;
label_29:
        num3 = 35;
        if (!this.CircEquPanel.Visible)
          goto label_31;
label_30:
        num3 = 36;
        MyProject.Forms.OrbitSummary.SUM_Summary.Text = MyProject.Forms.OrbitSummary.SUM_Summary.Text + "\r\n-------------------\r\nAdapted Parameters:\r\n-------------------\r\nSMA\t" + this.SMA_AP_ECCINC.Text + "\tkm\r\nex\t" + this.ex_ECCINC.Text + "\r\ney\t" + this.ey_ECCINC.Text + "\r\nix\t" + this.ix_ECCINC.Text + "\r\niy\t" + this.iy_ECCINC.Text + "\r\nλ'\t" + this.MeanL_ECCINC.Text + "\tdeg";
label_31:
label_32:
        goto label_39;
label_34:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num4 = num2 + 1;
            num2 = 0;
            switch (num4)
            {
              case 1:
                goto label_1;
              case 2:
                goto label_2;
              case 3:
                goto label_3;
              case 4:
                goto label_4;
              case 5:
              case 8:
                goto label_7;
              case 6:
                goto label_5;
              case 7:
                goto label_6;
              case 9:
                goto label_8;
              case 10:
                goto label_9;
              case 11:
                goto label_10;
              case 12:
              case 15:
                goto label_13;
              case 13:
                goto label_11;
              case 14:
                goto label_12;
              case 16:
              case 24:
                goto label_20;
              case 17:
                goto label_14;
              case 18:
                goto label_15;
              case 19:
                goto label_16;
              case 20:
              case 23:
                goto label_19;
              case 21:
                goto label_17;
              case 22:
                goto label_18;
              case 25:
                goto label_21;
              case 26:
                goto label_22;
              case 27:
                goto label_23;
              case 28:
                goto label_24;
              case 29:
                goto label_25;
              case 30:
                goto label_26;
              case 31:
              case 34:
              case 37:
                goto label_31;
              case 32:
                goto label_27;
              case 33:
                goto label_28;
              case 35:
                goto label_29;
              case 36:
                goto label_30;
              case 38:
                goto label_32;
              case 39:
                goto label_39;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_34;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_39:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public void Appli_About()
    {
      string str = "C:\\TLEAnalyser\\README.txt";
      if (MyProject.Computer.FileSystem.FileExists(str))
        MyProject.Computer.FileSystem.DeleteFile(str);
      File.WriteAllText(str, TLE_Analyser.My.Resources.Resources.README);
      Process.Start(str);
    }

    public void Appli_Help() => Process.Start(this.UMFile);

    public void Appli_Exit() => this.Close();

    public void Appli_Options() => MyProject.Forms.Options.Show();

    public void Appli_Stations() => MyProject.Forms.GroundStations.Show();

    private void ImportTLEButton_Click(object sender, EventArgs e)
    {
      if (this.TLETextBox.ForeColor == Color.Black)
        this.SATNAME = Interaction.InputBox("Please enter a Satellite Name:");
      this.TLE_Import();
      this.ButtonMenu_Import.Enabled = false;
    }

    private void TLETextBox_TextChanged(object sender, EventArgs e) => this.ButtonMenu_Import.Enabled = true;

    private void NewButton_Click_(object sender, EventArgs e)
    {
      this.TLETextBox.Enabled = true;
      this.TLETextBox.Text = "";
      this.TLETextBox.Focus();
      Functions.Init_RawDataGrid();
      this.Sat_CheckListBox.Items.Clear();
      this.TLETextBox.ReadOnly = false;
      this.ButtonMenu_Import.Enabled = false;
      this.GroupBox1.Height = 81;
    }

    private void TLE_ListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Sat_SelectAll.Text = "Select All";
      int count = this.TLE_ListBox.Items.Count;
      int num = 0;
      string str;
      while (num <= count)
      {
        if (this.TLE_ListBox.SelectedIndex == num)
        {
          if (Operators.ConditionalCompareObjectEqual(this.TLE_ListBox.SelectedItem, (object) "search.txt", false))
          {
            str = this.SearchAdress;
            this.CollectionType = "fleet";
            break;
          }
          if (Operators.ConditionalCompareObjectEqual(this.TLE_ListBox.SelectedItem, (object) "favorites.txt", false))
          {
            str = this.FavAdress;
            this.CollectionType = "fleet";
            break;
          }
          if (Conversions.ToBoolean(NewLateBinding.LateGet(this.TLE_ListBox.SelectedItem, (Type) null, "startswith", new object[1]
          {
            (object) "fleet_"
          }, (string[]) null, (Type[]) null, (bool[]) null)))
          {
            str = this.FavPath + Conversions.ToString(this.TLE_ListBox.SelectedItem);
            this.CollectionType = "fleet";
            break;
          }
          str = this.TLEPath + Conversions.ToString(this.TLE_ListBox.SelectedItem);
          this.CollectionType = "std";
          break;
        }
        checked { ++num; }
      }
      if (Operators.CompareString(str, (string) null, false) == 0)
        return;
      this.TLE_OpenFile(str);
    }

    private void Sat_CheckListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Sat_CheckListBox.SelectedIndex < 0)
        return;
      this.Sat_CheckListBox.ForeColor = Color.Black;
      this.SAT_CollectionLabel.Text = Operators.CompareString(this.CollectionType, "fleet", false) != 0 ? "" : "Collection: " + Path.GetFileName(this.Satellites[this.Sat_CheckListBox.SelectedIndex, 0]);
      this.LIGNE1_temp = this.Satellites[this.Sat_CheckListBox.SelectedIndex, 3];
      this.LIGNE2_temp = this.Satellites[this.Sat_CheckListBox.SelectedIndex, 4];
      this.SATNAME = this.Satellites[this.Sat_CheckListBox.SelectedIndex, 1];
      this.TLETextBox.Text = this.LIGNE1_temp + "\r\n" + this.LIGNE2_temp;
      this.TLETextBox.ReadOnly = true;
      this.ButtonMenu_Import.Enabled = false;
      this.Fleet_Add.Enabled = true;
      this.Fleet_Remove.Enabled = true;
      this.TLE_Import();
      this.TLE_Detail();
    }

    private void SATCHECK_Click(object sender, EventArgs e) => MyProject.Forms.Search.Show();

    private void ModifTLEButton_Click(object sender, EventArgs e)
    {
      this.TLETextBox.ReadOnly = false;
      this.TLETextBox.ForeColor = Color.Red;
      this.ButtonMenu_Import.Enabled = true;
    }

    public void TLE_Import()
    {
      if (!Functions.CheckTLE(this.TLETextBox.Lines[0], this.TLETextBox.Lines[1], true))
        return;
      this.TLETextBox.ForeColor = Color.Black;
      this.TLETextBox.ReadOnly = true;
      this.TLE_Load();
      this.Graph_Actualise(true);
      this.Graph_Radar_Actualise();
      this.Fleet_Create.Enabled = true;
      this.Fleet_Delete.Enabled = true;
      this.ButtonMenu_GMAT.Enabled = true;
      this.ButtonMenu_GMAT_M.Enabled = true;
      this.ButtonMenu_Report.Enabled = true;
      this.ButtonMenu_Charts.Enabled = true;
      this.ButtonMenu_Modify.Enabled = true;
      this.GS_ListBox.Enabled = true;
      this.MAP_Show_FullTrack.Checked = false;
      this.Sat_SelectAll.Enabled = true;
      if (Conversions.ToBoolean(this.SimulOn))
        this.SIM_RealTime.Checked = true;
      else
        this.SIM_Manual.Checked = true;
      this.FirstTLELoaded = true;
    }

    public void TLE_Detail()
    {
      Functions.Init_RawDataGrid();
      if (Operators.CompareString(this.TLETextBox.Text, "", false) == 0 || this.TLETextBox.Text.Length < 69)
      {
        int num1 = (int) TopMostMessageBox.Show("Please check TLE:\nLine 1 andalso/orelse Line 2 seems to be empty orelse incorect.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else if (!this.TLETextBox.Lines[0].StartsWith("1 ") || !this.TLETextBox.Lines[1].StartsWith("2 "))
      {
        int num2 = (int) TopMostMessageBox.Show("Please check TLE:\nLine 1 functions.Must begin with '1 '\nLine 2 functions.Must begin with '2 ' ", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        int length1 = this.TLETextBox.Lines[0].Length;
        int length2 = this.TLETextBox.Lines[1].Length;
        if (length1 < 69 || length2 < 69)
        {
          int num3 = (int) TopMostMessageBox.Show("Please check TLE: each line functions.Must contain 69 characters.\n\nActually: \n" + Conversions.ToString(length1) + " characters on line 1\n" + Conversions.ToString(length2) + " characters on line 2", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }
        else
        {
          string str1 = "";
          int index1 = 0;
          do
          {
            str1 += Conversions.ToString(this.TLETextBox.Lines[0][index1]);
            checked { ++index1; }
          }
          while (index1 <= 0);
          this.Raw_Data_GridView[2, 0].Value = (object) str1;
          string str2 = "";
          int index2 = 2;
          do
          {
            str2 += Conversions.ToString(this.TLETextBox.Lines[0][index2]);
            checked { ++index2; }
          }
          while (index2 <= 6);
          this.Raw_Data_GridView[2, 1].Value = (object) str2;
          this.Raw_Data_GridView[2, 2].Value = (object) ("" + Conversions.ToString(this.TLETextBox.Lines[0][7]));
          string str3 = "";
          int index3 = 9;
          do
          {
            str3 += Conversions.ToString(this.TLETextBox.Lines[0][index3]);
            checked { ++index3; }
          }
          while (index3 <= 10);
          this.Raw_Data_GridView[2, 3].Value = (object) str3;
          string str4 = "";
          int index4 = 11;
          do
          {
            str4 += Conversions.ToString(this.TLETextBox.Lines[0][index4]);
            checked { ++index4; }
          }
          while (index4 <= 13);
          this.Raw_Data_GridView[2, 4].Value = (object) str4;
          string str5 = "";
          int index5 = 14;
          do
          {
            str5 += Conversions.ToString(this.TLETextBox.Lines[0][index5]);
            checked { ++index5; }
          }
          while (index5 <= 16);
          this.Raw_Data_GridView[2, 5].Value = (object) str5;
          string str6 = "";
          int index6 = 18;
          do
          {
            str6 += Conversions.ToString(this.TLETextBox.Lines[0][index6]);
            checked { ++index6; }
          }
          while (index6 <= 19);
          this.Raw_Data_GridView[2, 6].Value = (object) str6;
          string str7 = "";
          int index7 = 20;
          do
          {
            str7 += Conversions.ToString(this.TLETextBox.Lines[0][index7]);
            checked { ++index7; }
          }
          while (index7 <= 31);
          this.Raw_Data_GridView[2, 7].Value = (object) str7;
          string str8 = "";
          int index8 = 33;
          do
          {
            str8 += Conversions.ToString(this.TLETextBox.Lines[0][index8]);
            checked { ++index8; }
          }
          while (index8 <= 42);
          this.Raw_Data_GridView[2, 8].Value = (object) str8;
          string str9 = "";
          int index9 = 44;
          do
          {
            str9 += Conversions.ToString(this.TLETextBox.Lines[0][index9]);
            checked { ++index9; }
          }
          while (index9 <= 51);
          this.Raw_Data_GridView[2, 9].Value = (object) str9;
          string str10 = "";
          int index10 = 53;
          do
          {
            str10 += Conversions.ToString(this.TLETextBox.Lines[0][index10]);
            checked { ++index10; }
          }
          while (index10 <= 60);
          this.Raw_Data_GridView[2, 10].Value = (object) Conversions.ToString(1E-05 * double.Parse(Strings.Mid(str10, 1, 6)) * Math.Pow(10.0, double.Parse(Strings.Mid(str10, 7, 2))));
          string str11 = "";
          int index11 = 62;
          do
          {
            str11 += Conversions.ToString(this.TLETextBox.Lines[0][index11]);
            checked { ++index11; }
          }
          while (index11 <= 62);
          this.Raw_Data_GridView[2, 11].Value = (object) str11;
          string str12 = "";
          int index12 = 64;
          do
          {
            str12 += Conversions.ToString(this.TLETextBox.Lines[0][index12]);
            checked { ++index12; }
          }
          while (index12 <= 67);
          this.Raw_Data_GridView[2, 12].Value = (object) str12;
          string str13 = "";
          int index13 = 68;
          do
          {
            str13 += Conversions.ToString(this.TLETextBox.Lines[0][index13]);
            checked { ++index13; }
          }
          while (index13 <= 68);
          this.Raw_Data_GridView[2, 13].Value = (object) str13;
          string str14 = "";
          int index14 = 0;
          do
          {
            str14 += Conversions.ToString(this.TLETextBox.Lines[1][index14]);
            checked { ++index14; }
          }
          while (index14 <= 0);
          this.Raw_Data_GridView[2, 14].Value = (object) str14;
          this.Raw_Data_GridView[2, 15].Value = (object) str2;
          string str15 = "";
          int index15 = 8;
          do
          {
            str15 += Conversions.ToString(this.TLETextBox.Lines[1][index15]);
            checked { ++index15; }
          }
          while (index15 <= 15);
          this.Raw_Data_GridView[2, 16].Value = (object) str15;
          string str16 = "";
          int index16 = 17;
          do
          {
            str16 += Conversions.ToString(this.TLETextBox.Lines[1][index16]);
            checked { ++index16; }
          }
          while (index16 <= 24);
          this.Raw_Data_GridView[2, 17].Value = (object) str16;
          string str17 = "0.";
          int index17 = 26;
          do
          {
            str17 += Conversions.ToString(this.TLETextBox.Lines[1][index17]);
            checked { ++index17; }
          }
          while (index17 <= 32);
          this.Raw_Data_GridView[2, 18].Value = (object) str17;
          string str18 = "";
          int index18 = 34;
          do
          {
            str18 += Conversions.ToString(this.TLETextBox.Lines[1][index18]);
            checked { ++index18; }
          }
          while (index18 <= 41);
          this.Raw_Data_GridView[2, 19].Value = (object) str18;
          string str19 = "";
          int index19 = 43;
          do
          {
            str19 += Conversions.ToString(this.TLETextBox.Lines[1][index19]);
            checked { ++index19; }
          }
          while (index19 <= 50);
          this.Raw_Data_GridView[2, 20].Value = (object) str19;
          string str20 = "";
          int index20 = 52;
          do
          {
            str20 += Conversions.ToString(this.TLETextBox.Lines[1][index20]);
            checked { ++index20; }
          }
          while (index20 <= 62);
          this.Raw_Data_GridView[2, 21].Value = (object) str20;
          string str21 = "";
          int index21 = 63;
          do
          {
            str21 += Conversions.ToString(this.TLETextBox.Lines[1][index21]);
            checked { ++index21; }
          }
          while (index21 <= 67);
          this.Raw_Data_GridView[2, 22].Value = (object) str21;
          string str22 = "";
          int index22 = 68;
          do
          {
            str22 += Conversions.ToString(this.TLETextBox.Lines[1][index22]);
            checked { ++index22; }
          }
          while (index22 <= 68);
          this.Raw_Data_GridView[2, 23].Value = (object) str22;
        }
      }
    }

    public void TLE_Load()
    {
      this.LIGNE1 = this.TLETextBox.Lines[0];
      this.LIGNE2 = this.TLETextBox.Lines[1];
      this.TleActive = (object) new TLE(this.LIGNE1, this.LIGNE2);
      this.SatActive = (object) new Satellite((TLE) this.TleActive);
      this.SatTrack = (object) new Satellite((TLE) this.TleActive);
      this.SatSearch = (object) new Satellite((TLE) this.TleActive);
      this.SatTleEpoch = (object) new Satellite((TLE) this.TleActive);
      this.SatXpEpoch = (object) new Satellite((TLE) this.TleActive);
      this.Spacecraft.Text = Conversions.ToString(NewLateBinding.LateGet(this.TleActive, (Type) null, "norad", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      string str1 = "";
      int index1 = 9;
      do
      {
        str1 += Conversions.ToString(this.LIGNE1[index1]);
        checked { ++index1; }
      }
      while (index1 <= 10);
      string str2 = Conversions.ToDouble(str1) < 0.0 || Conversions.ToDouble(str1) >= 30.0 ? "19" + str1 : "20" + str1;
      string str3 = "";
      int index2 = 11;
      do
      {
        str3 += Conversions.ToString(this.LIGNE1[index2]);
        checked { ++index2; }
      }
      while (index2 <= 13);
      string str4 = "";
      int index3 = 14;
      do
      {
        str4 += Conversions.ToString(this.LIGNE1[index3]);
        checked { ++index3; }
      }
      while (index3 <= 16);
      this.CATNUMB = str2 + "-" + str3 + str4;
      this.CATNbre.Text = Strings.RTrim(this.CATNUMB);
      this.TLEONAE = Conversions.ToString(NewLateBinding.LateGet(this.TleActive, (Type) null, "nb0", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      string str5 = "";
      int index4 = 18;
      do
      {
        str5 += Conversions.ToString(this.LIGNE1[index4]);
        checked { ++index4; }
      }
      while (index4 <= 19);
      string str6 = Conversions.ToDouble(str5) <= 0.0 || Conversions.ToDouble(str5) >= 30.0 ? "19" + str5 : "20" + str5;
      string str7 = "";
      int index5 = 20;
      do
      {
        str7 += Conversions.ToString(this.LIGNE1[index5]);
        checked { ++index5; }
      }
      while (index5 <= 31);
      this.DELTAD = "";
      int index6 = 23;
      do
      {
        this.DELTAD += Conversions.ToString(this.LIGNE1[index6]);
        checked { ++index6; }
      }
      while (index6 <= 31);
      this.TLEPOCH = 1721424.5 - Conversion.Int((Conversions.ToDouble(str6) - 1.0) / 100.0) + Conversion.Int((Conversions.ToDouble(str6) - 1.0) / 400.0) + Conversion.Int(365.25 * (Conversions.ToDouble(str6) - 1.0)) + Conversions.ToDouble(str7) - 2430000.0;
      this.EPOCH0 = 1721424.5 - Conversion.Int((Conversions.ToDouble(str6) - 1.0) / 100.0) + Conversion.Int((Conversions.ToDouble(str6) - 1.0) / 400.0) + Conversion.Int(365.25 * (Conversions.ToDouble(str6) - 1.0)) + (Conversions.ToDouble(str7) - Conversions.ToDouble(this.DELTAD));
      this.EPOCH = this.TLEPOCH;
      if (Conversions.ToBoolean(this.LoadTleNow))
      {
        this.EPOCH = Functions.GregtoMJD(Conversions.ToString(Functions.CurrentDateToGreg()));
        this.DELTAD = Conversions.ToString(this.EPOCH + 0.5 - Math.Truncate(this.EPOCH));
        this.EPOCH0 = 2430000.0 + this.EPOCH - Conversions.ToDouble(this.DELTAD);
      }
      this.EPOCH_Format.Enabled = true;
      this.EPOCH_Format.SelectedIndex = 1;
      this.EPOCH_Current.Text = Functions.MJDtoGreg(Conversions.ToString(this.EPOCH));
      this.EPOCH_TLE.Text = Functions.MJDtoGreg(Conversions.ToString(this.TLEPOCH));
      this.CREATEPOCH = this.EPOCH;
      this.GSTTLE = Functions.GSTCalc((object) this.TLEPOCH);
      this.SGP4_TLE_EPOCH(this.TLEPOCH, this.TLEPOCH);
      Functions.LATLONG(this.XTLE, this.YTLE, this.ZTLE, this.GSTTLE);
      this.LATTLE = this.LAT;
      this.LONGITLE = this.LONGI;
      this.SGP4(this.EPOCH, this.TLEPOCH);
      this.Math_ElementSecondaires();
      this.Display_Results();
      this.SCName.Text = this.SATNAME;
      this.EPOCH_Format.SelectedIndex = 1;
      this.NowDate.Enabled = true;
      this.TLEDate.Enabled = true;
      this.EPOCH_Current.Enabled = true;
      this.SIM_Step.SelectedIndex = 2;
      this.SIM_Unit.SelectedIndex = 1;
      this.TrackingOptions.Enabled = true;
      this.SIM_Manual.Enabled = true;
      this.SIM_RealTime.Enabled = true;
      this.MAP_Num_Period.Enabled = true;
      this.MAP_Num_Period.SelectedItem = (object) "1";
      this.MAP_ShowTrack.Enabled = true;
      this.MAP_ShowTrack.Checked = true;
      if (this.MAP_MainTab.SelectedIndex == 1)
        this.MAP_FullGrid.Enabled = false;
      else if (this.MAP_MainTab.SelectedIndex == 0)
        this.MAP_FullGrid.Enabled = true;
      this.TracePicture.Visible = true;
      this.MapOptions.Enabled = true;
      this.TLELoaded = true;
    }

    public void TLE_Load_Temp(string TLELine1, string TLELine2)
    {
      string str1 = "";
      int index1 = 18;
      do
      {
        str1 += Conversions.ToString(TLELine1[index1]);
        checked { ++index1; }
      }
      while (index1 <= 19);
      string str2 = Conversions.ToDouble(str1) <= 0.0 || Conversions.ToDouble(str1) >= 30.0 ? "19" + str1 : "20" + str1;
      string str3 = "";
      int index2 = 20;
      do
      {
        str3 += Conversions.ToString(TLELine1[index2]);
        checked { ++index2; }
      }
      while (index2 <= 31);
      this.DELTAD = "";
      int index3 = 23;
      do
      {
        this.DELTAD += Conversions.ToString(TLELine1[index3]);
        checked { ++index3; }
      }
      while (index3 <= 31);
      double _TLEPOCH = 1721424.5 - Conversion.Int((Conversions.ToDouble(str2) - 1.0) / 100.0) + Conversion.Int((Conversions.ToDouble(str2) - 1.0) / 400.0) + Conversion.Int(365.25 * (Conversions.ToDouble(str2) - 1.0)) + Conversions.ToDouble(str3) - 2430000.0;
      double epoch = this.EPOCH;
      this.SGP4_SEARCH(epoch, _TLEPOCH, TLELine1, TLELine2);
      double GST = Functions.GSTCalc((object) Conversion.Val((object) epoch));
      this.LAT_temp = Conversions.ToDouble(Functions.LATCalc(this.XC, this.YC, this.ZC, GST));
      this.LNG_temp = Conversions.ToDouble(Functions.LNGCalc(this.XC, this.YC, this.ZC, GST));
      double num1 = Functions.Norme((object) this.XC, (object) this.YC, (object) this.ZC);
      double num2 = 6378.136658 / Math.Sqrt(Math.Pow(Math.Cos(Math.PI / 180.0 * this.LAT_temp), 2.0) + Math.Pow(Math.Sin(Math.PI / 180.0 * this.LAT_temp), 2.0) / 0.993305682221733);
      if (Conversions.ToBoolean(this.EquRadius))
        this.ALT_temp = num1 - 6378.136658;
      else
        this.ALT_temp = num1 - num2;
    }

    public void TLE_LoadMulti(string l1, string l2)
    {
      this.LIGNE1 = l1;
      this.LIGNE2 = l2;
      string str1 = "";
      int index1 = 18;
      do
      {
        str1 += Conversions.ToString(l1[index1]);
        checked { ++index1; }
      }
      while (index1 <= 19);
      string str2 = Conversions.ToDouble(str1) <= 0.0 || Conversions.ToDouble(str1) >= 30.0 ? "19" + str1 : "20" + str1;
      string str3 = "";
      int index2 = 20;
      do
      {
        str3 += Conversions.ToString(l1[index2]);
        checked { ++index2; }
      }
      while (index2 <= 31);
      this.DELTAD = "";
      int index3 = 23;
      do
      {
        this.DELTAD += Conversions.ToString(l1[index3]);
        checked { ++index3; }
      }
      while (index3 <= 31);
      this.TLEPOCH = 1721424.5 - Conversion.Int((Conversions.ToDouble(str2) - 1.0) / 100.0) + Conversion.Int((Conversions.ToDouble(str2) - 1.0) / 400.0) + Conversion.Int(365.25 * (Conversions.ToDouble(str2) - 1.0)) + Conversions.ToDouble(str3) - 2430000.0;
      this.EPOCH0 = 1721424.5 - Conversion.Int((Conversions.ToDouble(str2) - 1.0) / 100.0) + Conversion.Int((Conversions.ToDouble(str2) - 1.0) / 400.0) + Conversion.Int(365.25 * (Conversions.ToDouble(str2) - 1.0)) + (Conversions.ToDouble(str3) - Conversions.ToDouble(this.DELTAD));
      this.SGP4(this.EPOCH, this.TLEPOCH);
    }

    public void Math_ElementSecondaires()
    {
      this.AOL = (this.AOP + 180.0 / Math.PI * this.TA) % 360.0;
      this.SDOO = this.VZ <= 0.01 ? (this.VZ >= -0.01 ? "N/A" : "DESC") : "ASC";
      this.ETFP = Math.PI / 180.0 * this.MA / Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) / 60.0;
      this.ETFP_Label.Text = "min";
      double num1 = Math.PI / 180.0 * (360.0 - this.MA) / Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0));
      double num2 = Math.PI / 180.0 * (360.0 - this.MA + 180.0) / Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) - num1;
      this.NP = 180.0 / Math.PI * -(3.0 * Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) * 0.0010826158 * 40680627.2281234 * Math.Cos(Math.PI / 180.0 * this.INC) / (2.0 * Math.Pow(1.0 - Math.Pow(this.ECC, 2.0), 2.0) * Math.Pow(this.SMA, 2.0))) * 86400.0;
      this.AP = 180.0 / Math.PI * -(3.0 * Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) * 0.0010826158 * 40680627.2281234 * (1.0 - 5.0 * Math.Pow(Math.Cos(Math.PI / 180.0 * this.INC), 2.0)) / (4.0 * Math.Pow(1.0 - Math.Pow(this.ECC, 2.0), 2.0) * Math.Pow(this.SMA, 2.0))) * 86400.0;
      double num3 = 3.0 / (4.0 * Math.Pow(1.0 - Math.Pow(this.ECC, 2.0), 2.0)) * 0.0010826158 * Math.Pow(6378.136658 / this.SMA, 2.0) * (5.0 * Math.Pow(Math.Cos(Math.PI / 180.0 * this.INC), 2.0) - 1.0);
      this.DN = 180.0 / Math.PI * (3.0 * Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) * 0.0010826158 * 40680627.2281234 * (3.0 * Math.Pow(Math.Cos(Math.PI / 180.0 * this.INC), 2.0) - 1.0) / (4.0 * Math.Pow(1.0 - Math.Pow(this.ECC, 2.0), 1.5) * Math.Pow(this.SMA, 2.0))) * 86400.0;
      double num4 = 3.0 / (4.0 * Math.Pow(1.0 - Math.Pow(this.ECC, 2.0), 1.5)) * 0.0010826158 * Math.Pow(6378.136658 / this.SMA, 2.0) * (3.0 * Math.Pow(Math.Cos(Math.PI / 180.0 * this.INC), 2.0) - 1.0);
      this.KPER = 2.0 * Math.PI * Math.Sqrt(Math.Pow(this.SMA, 3.0) / 398600.4418) / 60.0;
      this.APER = 1440.0 / this.N0;
      this.DPER = this.APER / (1.0 + num3);
      this.MM = this.N0;
      RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "periode", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.DL = 360.0 / ((this.MM * 360.0 + this.AP) / (360.985647366286 - this.NP));
      this.DLong_Label.Text = "deg";
      this.AnoPeriod_Label.Text = "min";
      this.DracoPeriod_Label.Text = "min";
      this.DREL = Math.Sqrt(Math.Pow(this.X, 2.0) + Math.Pow(this.Y, 2.0) + Math.Pow(this.Z, 2.0)) / 6378.136658;
      this.ETFE = this.EPOCH - this.TLEPOCH;
      Functions.AdpatedParameters();
      double num5 = (360.985647366286 - this.NP) / 360.0;
      double num6 = Math.Round(Math.Round((Conversion.Val((object) this.MM) * 360.0 + this.AP) / (360.985647366286 - this.NP), 1), 0);
      double num7 = this.N0 * this.APER / this.DPER;
      bool flag = false;
      double num8 = 0.01;
      double num9;
      do
      {
        int num10 = 1;
        do
        {
          this.NT0 = (double) num10 * num7;
          if (this.NT0 - Math.Round(this.NT0, 0) < num8 && this.NT0 - Math.Round(this.NT0, 0) > -num8)
          {
            num9 = (double) num10;
            flag = true;
            break;
          }
          checked { ++num10; }
        }
        while (num10 <= 38);
        if (!flag)
          num8 += 1E-06;
        else
          break;
      }
      while (num8 <= 0.05);
      double num11;
      if (this.NP < 0.975 || this.NP > 0.995)
        num11 = Math.Round(this.NT0 - num6 * num9);
      else if (this.NP > 0.975 && this.NP < 0.995)
        num11 = Math.Round((num7 - num6) * num9, 0);
      if (!flag)
        this.phase.Text = "N/A";
      else
        this.phase.Text = "[ " + Conversions.ToString(num6) + " ; " + Conversions.ToString(num11) + " ; " + Conversions.ToString(num9) + " ] " + Conversions.ToString(Math.Round(this.NT0, 0));
      Math.Sqrt(this.X * this.X + this.Y * this.Y);
      double num12 = Functions.Norme((object) this.X, (object) this.Y, (object) this.Z);
      double num13 = 6378.136658 / Math.Sqrt(Math.Pow(Math.Cos(Math.PI / 180.0 * this.LAT), 2.0) + Math.Pow(Math.Sin(Math.PI / 180.0 * this.LAT), 2.0) / 0.993305682221733);
      this.APR = this.SMA * (1.0 + this.ECC);
      this.PER = this.SMA * (1.0 - this.ECC);
      if (Conversions.ToBoolean(this.EquRadius))
      {
        this.APA = this.APR - 6378.136658;
        this.PEA = this.PER - 6378.136658;
        this.ALT = num12 - 6378.136658;
        this.MALT = this.SMA - 6378.136658;
      }
      else
      {
        this.APA = this.APR - num13;
        this.PEA = this.PER - num13;
        this.ALT = num12 - num13;
        this.MALT = this.SMA - num13;
      }
      this.APV = Math.Sqrt(398600.4418 * (2.0 / this.APR - 1.0 / this.SMA));
      this.PEV = Math.Sqrt(398600.4418 * (2.0 / this.PER - 1.0 / this.SMA));
      this.VEL = Math.Sqrt(398600.4418 * (2.0 / num12 - 1.0 / this.SMA));
      this.LONGIS = 180.0 / Math.PI * ((Math.Atan2(this.YS, this.XS) - Math.PI / 180.0 * this.GST) % (2.0 * Math.PI));
      if (this.LONGIS > 180.0)
        this.LONGIS -= 360.0;
      if (this.LONGIS < -180.0)
        this.LONGIS += 360.0;
      double x = Math.Sqrt(this.XS * this.XS + this.YS * this.YS);
      double num14 = Math.Atan2(this.ZS, x);
      do
      {
        this.LATS = num14;
        double num15 = Math.Sin(this.LATS);
        num14 = Math.Atan((this.ZS + 6378.136658 * (1.0 / Math.Sqrt(1.0 - 0.00669431777826672 * num15 * num15)) * 0.00669431777826672 * num15) / x);
      }
      while (Math.Abs(num14 - this.LATS) > 1E-07);
      this.LATS = 180.0 / Math.PI * this.LATS;
      double num16 = (double) this.MapW / 2.0;
      int num17 = checked ((int) Math.Round(Math.Round(unchecked ((double) this.MapH / 2.0 - this.LATS * (double) this.MapH / 180.0), 0)));
      this.lsol = (double) checked ((int) Math.Round(Math.Round(unchecked (num16 + this.LONGIS * (double) this.MapW / 360.0), 0)));
      this.bsol = (double) num17;
      string str1;
      if (this.LONGI > 0.0)
      {
        str1 = " E";
        this.LONGBox.Text = Conversions.ToString(Math.Round(this.LONGI, 3)) + str1;
      }
      else if (this.LONGI < 0.0)
      {
        str1 = " W";
        this.LONGBox.Text = Conversions.ToString(Math.Round(this.LONGI, 3)) + str1;
      }
      string str2;
      if (this.LAT > 0.0)
      {
        str2 = " N";
        this.LATBox.Text = Conversions.ToString(Math.Round(this.LAT, 3)) + str2;
      }
      else if (this.LAT < 0.0)
      {
        str2 = " S";
        this.LATBox.Text = Conversions.ToString(Math.Round(this.LAT, 3)) + " S";
      }
      this.LNGLATBOX.Text = Math.Round(this.LONGI, 3).ToString("000.00") + str1 + " | " + Math.Round(this.LAT, 3).ToString("000.00") + str2;
      string str3;
      if (this.LATS < 0.0)
        str3 = " S";
      else if (this.LATS >= 0.0)
        str3 = " N";
      string str4;
      if (this.LONGIS < 0.0)
        str4 = " W";
      else if (this.LONGIS >= 0.0)
        str4 = " E";
      this.LNGLATSUNBOX.Text = Math.Round(this.LONGIS, 3).ToString("000.00") + str4 + " | " + Math.Round(this.LATS, 3).ToString("000.00") + str3;
      double num18 = Functions.LAN_F(this.ECC, this.MA, this.APER, this.RAAN, this.AOP, this.GST) % 360.0;
      this.LAN = num18 <= 180.0 ? (num18 >= -180.0 ? num18 : 360.0 + num18) : num18 - 360.0;
      double num19 = Functions.LDN_F(this.ECC, this.MA, this.APER, this.RAAN, this.AOP, this.GST) % 360.0;
      this.LDN = num19 <= 180.0 ? (num19 >= -180.0 ? num19 : 360.0 + num19) : num19 - 360.0;
      this.LANType.Text = "[-180;180]";
      this.LTAN = Conversions.ToString(Functions.LTAN_F());
      this.LTDN = Conversions.ToString(Functions.LTDN_F());
      this.LST = this.LONGI >= 0.0 ? (this.LONGI + this.GST) % 360.0 : (this.LONGI + 360.0 + this.GST) % 360.0;
      object satActive = this.SatActive;
      object[] objArray = new object[1]
      {
        (object) this.Soleil
      };
      object[] Arguments = objArray;
      bool[] flagArray = new bool[1]{ true };
      bool[] CopyBack = flagArray;
      NewLateBinding.LateCall(satActive, (Type) null, "CalculEclipse", Arguments, (string[]) null, (Type[]) null, CopyBack, true);
      if (flagArray[0])
        this.Soleil = (Soleil) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (Soleil));
      this.EclipseBox.Text = !Conversions.ToBoolean(NewLateBinding.LateGet(this.SatActive, (Type) null, "eclipse", new object[0], (string[]) null, (Type[]) null, (bool[]) null)) ? (!Conversions.ToBoolean(NewLateBinding.LateGet(this.SatActive, (Type) null, "penombre", new object[0], (string[]) null, (Type[]) null, (bool[]) null)) ? "NO" : "PENOMBRE") : "ECLIPSE";
      double num20 = 0.001561;
      double num21 = this.LONGI;
      if (this.LONGI < 0.0)
        num21 = 360.0 + this.LONGI;
      double num22 = Math.Round(num20 * (1.087 * Math.Sin(Math.PI / 90.0 * (num21 - 345.07)) - 0.05 * Math.Sin(num21 - 6.98) + 0.15 * Math.Sin(3.0 * (num21 - 20.99))), 5);
      if (this.MM > 0.99 && this.MM < 1.01 && this.ECC < 0.01 && this.INC < 1.0)
        this.LONGACCBox.Text = Conversions.ToString(num22);
      else
        this.LONGACCBox.Text = "";
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public void TLE_OpenFile(string Fichier)
    {
      int integer = Conversions.ToInteger(Functions.SatCount(Fichier));
      int index1 = 0;
      this.Sat_CheckListBox.Items.Clear();
      Array.Clear((Array) this.Satellites, 0, this.Satellites.Length);
      this.Satellites = new string[checked (integer + 1), 6];
      this.TLEFILE = Fichier;
      try
      {
        FileSystem.FileOpen(1, Fichier, OpenMode.Input);
        while (!FileSystem.EOF(1))
        {
          if (FileSystem.EOF(1))
            return;
          string StringToCheck;
          if (Operators.CompareString(this.CollectionType, "fleet", false) == 0)
          {
            string FileName = FileSystem.LineInput(1);
            string Right = FileSystem.LineInput(1);
            FileSystem.FileOpen(2, FileName, OpenMode.Input);
            while (!FileSystem.EOF(2))
            {
              StringToCheck = Strings.RTrim(FileSystem.LineInput(2));
              string str1 = Conversions.ToString(Functions.CheckCaracts(ref StringToCheck));
              string str2 = FileSystem.LineInput(2);
              string str3 = FileSystem.LineInput(2);
              string Left = "";
              int index2 = 2;
              do
              {
                Left += Conversions.ToString(str2[index2]);
                checked { ++index2; }
              }
              while (index2 <= 6);
              if (Operators.CompareString(Left, Right, false) == 0)
              {
                this.Satellites[index1, 0] = FileName;
                this.Satellites[index1, 1] = str1;
                this.Satellites[index1, 2] = Left;
                this.Satellites[index1, 3] = str2;
                this.Satellites[index1, 4] = str3;
                this.Satellites[index1, 5] = "false";
                checked { ++index1; }
                this.Sat_CheckListBox.Items.Add((object) str1);
                break;
              }
            }
            FileSystem.FileClose(2);
          }
          else if (Operators.CompareString(this.CollectionType, "std", false) == 0)
          {
            StringToCheck = Strings.RTrim(FileSystem.LineInput(1));
            string str4 = Conversions.ToString(Functions.CheckCaracts(ref StringToCheck));
            string str5 = FileSystem.LineInput(1);
            string str6 = FileSystem.LineInput(1);
            string str7 = "";
            int index3 = 2;
            do
            {
              str7 += Conversions.ToString(str5[index3]);
              checked { ++index3; }
            }
            while (index3 <= 6);
            this.Satellites[index1, 0] = Fichier;
            this.Satellites[index1, 1] = str4;
            this.Satellites[index1, 2] = str7;
            this.Satellites[index1, 3] = str5;
            this.Satellites[index1, 4] = str6;
            this.Satellites[index1, 5] = "false";
            checked { ++index1; }
            this.Sat_CheckListBox.Items.Add((object) str4);
          }
        }
        FileSystem.FileClose(1);
        string[] strArray = new string[6];
        int num1 = checked (index1 - 1);
        int index4 = 0;
        while (index4 <= num1)
        {
          int num2 = checked (index1 - 1);
          int index5 = 0;
          while (index5 <= num2)
          {
            if (Operators.CompareString(this.Satellites[index4, 1], this.Satellites[index5, 1], false) < 0)
            {
              strArray[0] = this.Satellites[index4, 0];
              strArray[1] = this.Satellites[index4, 1];
              strArray[2] = this.Satellites[index4, 2];
              strArray[3] = this.Satellites[index4, 3];
              strArray[4] = this.Satellites[index4, 4];
              strArray[5] = this.Satellites[index4, 5];
              this.Satellites[index4, 0] = this.Satellites[index5, 0];
              this.Satellites[index4, 1] = this.Satellites[index5, 1];
              this.Satellites[index4, 2] = this.Satellites[index5, 2];
              this.Satellites[index4, 3] = this.Satellites[index5, 3];
              this.Satellites[index4, 4] = this.Satellites[index5, 4];
              this.Satellites[index4, 5] = this.Satellites[index5, 5];
              this.Satellites[index5, 0] = strArray[0];
              this.Satellites[index5, 1] = strArray[1];
              this.Satellites[index5, 2] = strArray[2];
              this.Satellites[index5, 3] = strArray[3];
              this.Satellites[index5, 4] = strArray[4];
              this.Satellites[index5, 5] = strArray[5];
            }
            checked { ++index5; }
          }
          checked { ++index4; }
        }
        this.Sat_CheckListBox.Sorted = true;
        this.SatellitesLabel.Text = "Satellites (" + Conversions.ToString(integer) + ")";
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        FileSystem.FileClose(1);
        FileSystem.FileClose(2);
        int num = (int) TopMostMessageBox.Show(Fichier + " seems to be corrupted :\r\nPlease read User Manual for Help.\r\n\r\n" + exception.Message, "TLE ANALYSER - Error");
        ProjectData.ClearProjectError();
      }
    }

    public void TLE_Search()
    {
      bool flag = false;
      int num1 = 0;
      this.Cursor = Cursors.WaitCursor;
      if (MyProject.Computer.FileSystem.FileExists(this.SearchAdress))
        MyProject.Computer.FileSystem.DeleteFile(this.SearchAdress);
      string str1;
      if (MyProject.Forms.Search.SEARCH_ByName.Checked)
      {
        if (Operators.CompareString(MyProject.Forms.Search.SEARCH_Name.Text, "", false) == 0 & Operators.CompareString(MyProject.Forms.Search.SEARCH_Number.Text, "", false) == 0 & Operators.CompareString(MyProject.Forms.Search.SEARCH_Date.Text, "", false) == 0)
        {
          int num2 = (int) Interaction.MsgBox((object) "Complete at least 'Name' or 'Number' or 'Date' text box", MsgBoxStyle.Exclamation, (object) "Advanced Search");
          this.Cursor = Cursors.Default;
          return;
        }
        if (Operators.CompareString(MyProject.Forms.Search.SEARCH_Date.Text, "", false) != 0 && Operators.CompareString(MyProject.Forms.Search.SEARCH_Date.Text, "1930", false) < 0 | Conversions.ToDouble(MyProject.Forms.Search.SEARCH_Date.Text) > (double) DateTime.Now.Year)
        {
          int num3 = (int) Interaction.MsgBox((object) ("Launch Year must be > 1930 and <=" + Conversions.ToString(DateTime.Now.Year)), MsgBoxStyle.Information, (object) "Advanced Search");
          this.Cursor = Cursors.Default;
          return;
        }
        int num4 = checked (this.TLE_ListBox.Items.Count - 1);
        int index1 = 0;
        while (index1 <= num4)
        {
          if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(this.TLE_ListBox.Items[index1], (object) "favorites.txt", false), Operators.CompareObjectEqual(this.TLE_ListBox.Items[index1], (object) "search.txt", false)), NewLateBinding.LateGet(this.TLE_ListBox.Items[index1], (Type) null, "startswith", new object[1]
          {
            (object) "fleet_"
          }, (string[]) null, (Type[]) null, (bool[]) null))))
          {
            string[] strArray = File.ReadAllLines(Conversions.ToString(Operators.ConcatenateObject((object) this.TLEPath, this.TLE_ListBox.Items[index1])));
            int length = strArray.Length;
            int index2 = 0;
            while (index2 <= length && index2 < strArray.Length)
            {
              string StringToCheck = Strings.RTrim(strArray[index2]);
              str1 = Conversions.ToString(Functions.CheckCaracts(ref StringToCheck));
              string str2 = strArray[checked (index2 + 1)];
              string str3 = strArray[checked (index2 + 2)];
              string str4 = "";
              int index3 = 2;
              do
              {
                str4 += Conversions.ToString(str2[index3]);
                checked { ++index3; }
              }
              while (index3 <= 6);
              string str5 = "";
              int index4 = 9;
              do
              {
                str5 += Conversions.ToString(str2[index4]);
                checked { ++index4; }
              }
              while (index4 <= 10);
              string Left = Conversions.ToDouble(str5) < 0.0 || Conversions.ToDouble(str5) >= 30.0 ? "19" + str5 : "20" + str5;
              string str6 = "";
              int index5 = 11;
              do
              {
                str6 += Conversions.ToString(str2[index5]);
                checked { ++index5; }
              }
              while (index5 <= 13);
              string str7 = "";
              int index6 = 14;
              do
              {
                str7 += Conversions.ToString(str2[index6]);
                checked { ++index6; }
              }
              while (index6 <= 16);
              if (Operators.CompareString(MyProject.Forms.Search.SEARCH_Name.Text, "", false) != 0 & MyProject.Forms.Search.SEARCH_Name.Text.Length >= 2 && strArray[index2].Contains(MyProject.Forms.Search.SEARCH_Name.Text))
              {
                File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index1]) + "\r\n" + str4 + "\r\n");
                flag = true;
                checked { ++num1; }
              }
              if (Operators.CompareString(MyProject.Forms.Search.SEARCH_Number.Text, "", false) != 0 & MyProject.Forms.Search.SEARCH_Number.Text.Length >= 3 && str4.Contains(MyProject.Forms.Search.SEARCH_Number.Text))
              {
                File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index1]) + "\r\n" + str4 + "\r\n");
                flag = true;
                checked { ++num1; }
              }
              if (Operators.CompareString(MyProject.Forms.Search.SEARCH_Date.Text, "", false) != 0 & MyProject.Forms.Search.SEARCH_Date.Text.Length == 4 && Operators.CompareString(Left, MyProject.Forms.Search.SEARCH_Date.Text, false) == 0)
              {
                File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index1]) + "\r\n" + str4 + "\r\n");
                flag = true;
                checked { ++num1; }
              }
              checked { index2 += 3; }
            }
          }
          checked { ++index1; }
        }
      }
      else if (MyProject.Forms.Search.SEARCH_ByType.Checked | MyProject.Forms.Search.SEARCH_ByPar.Checked)
      {
        if (MyProject.Forms.Search.SEARCH_ByPar.Checked && !MyProject.Forms.Search.SEARCH_APA.Checked & !MyProject.Forms.Search.SEARCH_PEA.Checked & !MyProject.Forms.Search.SEARCH_INC.Checked & !MyProject.Forms.Search.SEARCH_ECC.Checked & !MyProject.Forms.Search.SEARCH_Period.Checked)
        {
          int num5 = (int) Interaction.MsgBox((object) "Check at least 1 parameter.", MsgBoxStyle.Exclamation, (object) "Advanced Search");
          this.Cursor = Cursors.Default;
          return;
        }
        if (MyProject.Forms.Search.SEARCH_ByType.Checked && Operators.ConditionalCompareObjectEqual(MyProject.Forms.Search.SEARCH_TypeList.SelectedItem, (object) "", false))
        {
          int num6 = (int) Interaction.MsgBox((object) "Choose a type of orbit.", MsgBoxStyle.Exclamation, (object) "Advanced Search");
          this.Cursor = Cursors.Default;
          return;
        }
        int num7 = checked (this.TLE_ListBox.Items.Count - 1);
        int index7 = 0;
        while (index7 <= num7)
        {
          if (!Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(this.TLE_ListBox.Items[index7], (object) "favorites.txt", false), Operators.CompareObjectEqual(this.TLE_ListBox.Items[index7], (object) "search.txt", false)), NewLateBinding.LateGet(this.TLE_ListBox.Items[index7], (Type) null, "startswith", new object[1]
          {
            (object) "fleet_"
          }, (string[]) null, (Type[]) null, (bool[]) null))))
          {
            string[] strArray = File.ReadAllLines(Conversions.ToString(Operators.ConcatenateObject((object) this.TLEPath, this.TLE_ListBox.Items[index7])));
            int num8 = checked (strArray.Length - 1);
            int index8 = 0;
            while (index8 <= num8 && index8 <= checked (strArray.Length - 1))
            {
              string StringToCheck = Strings.RTrim(strArray[index8]);
              str1 = Conversions.ToString(Functions.CheckCaracts(ref StringToCheck));
              string TLELine1 = strArray[checked (index8 + 1)];
              string TLELine2 = strArray[checked (index8 + 2)];
              string str8 = "";
              int index9 = 2;
              do
              {
                str8 += Conversions.ToString(TLELine1[index9]);
                checked { ++index9; }
              }
              while (index9 <= 6);
              string str9 = "";
              int index10 = 18;
              do
              {
                str9 += Conversions.ToString(TLELine1[index10]);
                checked { ++index10; }
              }
              while (index10 <= 19);
              string str10 = Conversions.ToDouble(str9) <= 0.0 || Conversions.ToDouble(str9) >= 30.0 ? "19" + str9 : "20" + str9;
              string str11 = "";
              int index11 = 20;
              do
              {
                str11 += Conversions.ToString(TLELine1[index11]);
                checked { ++index11; }
              }
              while (index11 <= 31);
              this.DELTAD = "";
              int index12 = 23;
              do
              {
                this.DELTAD += Conversions.ToString(TLELine1[index12]);
                checked { ++index12; }
              }
              while (index12 <= 31);
              double _TLEPOCH = 1721424.5 - Conversion.Int((Conversions.ToDouble(str10) - 1.0) / 100.0) + Conversion.Int((Conversions.ToDouble(str10) - 1.0) / 400.0) + Conversion.Int(365.25 * (Conversions.ToDouble(str10) - 1.0)) + Conversions.ToDouble(str11) - 2430000.0;
              double num9 = Functions.GregtoMJD(Conversions.ToString(Functions.CurrentDateToGreg()));
              this.SGP4_SEARCH(num9, _TLEPOCH, TLELine1, TLELine2);
              double num10 = 180.0 / Math.PI * -(3.0 * Math.Sqrt(398600.4418 / Math.Pow(this.SMAC, 3.0)) * 0.0010826158 * 40680627.2281234 * Math.Cos(Math.PI / 180.0 * this.INCC) / (2.0 * Math.Pow(1.0 - Math.Pow(this.ECCC, 2.0), 2.0) * Math.Pow(this.SMAC, 2.0))) * 86400.0;
              double n0 = this.N0;
              double Left = Conversions.ToDouble(Functions.LNGCalc(this.XC, this.YC, this.ZC, Functions.GSTCalc((object) Conversion.Val((object) num9))));
              double num11 = this.SMAC * (1.0 + this.ECCC) - 6378.136658;
              double num12 = this.SMAC * (1.0 - this.ECCC) - 6378.136658;
              double num13 = 2.0 * Math.PI * Math.Sqrt(Math.Pow(this.SMAC, 3.0) / 398600.4418) / 60.0;
              if (MyProject.Forms.Search.SEARCH_ByType.Checked)
              {
                if (MyProject.Forms.Search.SEARCH_TypeList.SelectedIndex == 0)
                {
                  if (MyProject.Forms.Search.SEARCH_LNGList.SelectedIndex == 0)
                  {
                    if (n0 < 1.01 & n0 > 0.99 & this.INCC < 0.1 & this.ECCC < 0.01)
                    {
                      File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index7]) + "\r\n" + str8 + "\r\n");
                      flag = true;
                      checked { ++num1; }
                    }
                  }
                  else if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject((object) (n0 < 1.01 & n0 > 0.99 & this.INCC < 0.1 & this.ECCC < 0.01), Operators.CompareObjectGreater((object) Left, MyProject.Forms.Search.SEARCH_LNGList.SelectedItem, false)), Operators.CompareObjectLess((object) Left, Operators.AddObject(MyProject.Forms.Search.SEARCH_LNGList.SelectedItem, (object) 30), false))))
                  {
                    File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index7]) + "\r\n" + str8 + "\r\n");
                    flag = true;
                    checked { ++num1; }
                  }
                }
                if (MyProject.Forms.Search.SEARCH_TypeList.SelectedIndex == 1 && num10 < 1.0 & num10 > 0.97)
                {
                  File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index7]) + "\r\n" + str8 + "\r\n");
                  flag = true;
                  checked { ++num1; }
                }
                if (MyProject.Forms.Search.SEARCH_TypeList.SelectedIndex == 2 && this.INCC < 91.0 & this.INCC > 89.0)
                {
                  File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index7]) + "\r\n" + str8 + "\r\n");
                  flag = true;
                  checked { ++num1; }
                }
                if (MyProject.Forms.Search.SEARCH_TypeList.SelectedIndex == 3 && this.INCC < 65.0 & this.INCC > 60.0 & this.ECCC > 0.5)
                {
                  File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index7]) + "\r\n" + str8 + "\r\n");
                  flag = true;
                  checked { ++num1; }
                }
                if (MyProject.Forms.Search.SEARCH_TypeList.SelectedIndex == 4 && this.ECCC < 0.01)
                {
                  File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index7]) + "\r\n" + str8 + "\r\n");
                  flag = true;
                  checked { ++num1; }
                }
                if (MyProject.Forms.Search.SEARCH_TypeList.SelectedIndex == 5 && n0 < 1.01 & n0 > 0.99)
                {
                  File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index7]) + "\r\n" + str8 + "\r\n");
                  flag = true;
                  checked { ++num1; }
                }
              }
              if (MyProject.Forms.Search.SEARCH_ByPar.Checked)
              {
                if (Conversions.ToDouble(MyProject.Forms.Search.SEARCH_APAMIN.Text) > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_APAMAX.Text))
                {
                  int num14 = (int) Interaction.MsgBox((object) "ApA Min must be < ApA Max", MsgBoxStyle.Exclamation, (object) "Advanced Search");
                  this.Cursor = Cursors.Default;
                  return;
                }
                if (Conversions.ToDouble(MyProject.Forms.Search.SEARCH_PEAMIN.Text) > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_PEAMAX.Text))
                {
                  int num15 = (int) Interaction.MsgBox((object) "PeA Min must be < PeA Max", MsgBoxStyle.Exclamation, (object) "Advanced Search");
                  this.Cursor = Cursors.Default;
                  return;
                }
                if (Conversions.ToDouble(MyProject.Forms.Search.SEARCH_INCMIN.Text) > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_INCMAX.Text))
                {
                  int num16 = (int) Interaction.MsgBox((object) "INC Min must be < INC Max", MsgBoxStyle.Exclamation, (object) "Advanced Search");
                  this.Cursor = Cursors.Default;
                  return;
                }
                if (Conversions.ToDouble(MyProject.Forms.Search.SEARCH_ECCMIN.Text) > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_ECCMAX.Text))
                {
                  int num17 = (int) Interaction.MsgBox((object) "ECC Min must be < ECC Max", MsgBoxStyle.Exclamation, (object) "Advanced Search");
                  this.Cursor = Cursors.Default;
                  return;
                }
                if (Conversions.ToDouble(MyProject.Forms.Search.SEARCH_ECCMAX.Text) > 1.0 | Conversions.ToDouble(MyProject.Forms.Search.SEARCH_ECCMIN.Text) < 0.0)
                {
                  int num18 = (int) Interaction.MsgBox((object) "ECC must be: 0 < ECC < 1", MsgBoxStyle.Exclamation, (object) "Advanced Search");
                  this.Cursor = Cursors.Default;
                  return;
                }
                if (Conversions.ToDouble(MyProject.Forms.Search.SEARCH_PERMIN.Text) > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_PERMAX.Text))
                {
                  int num19 = (int) Interaction.MsgBox((object) "Period Min must be < Period Max", MsgBoxStyle.Exclamation, (object) "Advanced Search");
                  this.Cursor = Cursors.Default;
                  return;
                }
                if (num11 < Conversions.ToDouble(MyProject.Forms.Search.SEARCH_APAMAX.Text) & num11 > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_APAMIN.Text) & num12 < Conversions.ToDouble(MyProject.Forms.Search.SEARCH_PEAMAX.Text) & num12 > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_PEAMIN.Text) & this.INCC < Conversions.ToDouble(MyProject.Forms.Search.SEARCH_INCMAX.Text) & this.INCC > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_INCMIN.Text) & this.ECCC < Conversions.ToDouble(MyProject.Forms.Search.SEARCH_ECCMAX.Text) & this.ECCC > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_ECCMIN.Text) & num13 < Conversions.ToDouble(MyProject.Forms.Search.SEARCH_PERMAX.Text) & num13 > Conversions.ToDouble(MyProject.Forms.Search.SEARCH_PERMIN.Text))
                {
                  File.AppendAllText(this.SearchAdress, this.TLEPath + Conversions.ToString(this.TLE_ListBox.Items[index7]) + "\r\n" + str8 + "\r\n");
                  flag = true;
                  checked { ++num1; }
                }
              }
              checked { index8 += 3; }
            }
          }
          checked { ++index7; }
        }
      }
      int num20 = checked (this.TLE_ListBox.Items.Count - 1);
      int index = 0;
      while (index <= num20)
      {
        if (Operators.CompareString(Conversions.ToString(this.TLE_ListBox.Items[index]), "search.txt", false) == 0)
        {
          this.TLE_ListBox.Items.Remove((object) "search.txt");
          break;
        }
        checked { ++index; }
      }
      if (flag)
      {
        this.TLE_ListBox.Items.Add((object) "search.txt");
        this.TLE_ListBox.Sorted = true;
        this.TLE_ListBox.SelectedItem = (object) "search.txt";
      }
      else
      {
        this.Sat_CheckListBox.Items.Clear();
        this.SatellitesLabel.Text = "Satellites (" + Conversions.ToString(num1) + ")";
      }
      MyProject.Forms.Search.SearchResult.Text = Conversions.ToString(num1) + " satellite(s) found.";
      this.Cursor = Cursors.Default;
    }

    public void Display_Results()
    {
      this.SMABox.Text = Conversions.ToString(Math.Round(this.SMA, 3));
      this.ECCBox.Text = Conversions.ToString(Math.Round(this.ECC, 7));
      this.INCBox.Text = Conversions.ToString(Math.Round(this.INC, 4));
      this.RAANBox.Text = Conversions.ToString(Math.Round(this.RAAN, 4));
      this.AOPBox.Text = Conversions.ToString(Math.Round(this.AOP, 4));
      this.MABox.Text = Conversions.ToString(Math.Round(this.MA, 4));
      this.TABox.Text = Conversions.ToString(Math.Round(180.0 / Math.PI * this.TA, 4));
      this.EABox.Text = Conversions.ToString(Math.Round(180.0 / Math.PI * this.EA, 4));
      this.ETFPBox.Text = Conversions.ToString(Math.Round(this.ETFP, 4));
      this.ALPHABox.Text = Conversions.ToString(Math.Round(this.AOL, 4));
      this.XBox.Text = Conversions.ToString(Math.Round(this.X, 3));
      this.YBox.Text = Conversions.ToString(Math.Round(this.Y, 3));
      this.ZBox.Text = Conversions.ToString(Math.Round(this.Z, 3));
      this.VXBox.Text = Conversions.ToString(Math.Round(this.VX, 6));
      this.VYBox.Text = Conversions.ToString(Math.Round(this.VY, 6));
      this.VZBox.Text = Conversions.ToString(Math.Round(this.VZ, 6));
      this.APABox.Text = Conversions.ToString(Math.Round(this.APA, 3));
      this.PEABox.Text = Conversions.ToString(Math.Round(this.PEA, 3));
      this.APRBox.Text = Conversions.ToString(Math.Round(this.APR, 3));
      this.PERBox.Text = Conversions.ToString(Math.Round(this.PER, 3));
      this.ALTBox.Text = Conversions.ToString(Math.Round(this.ALT, 3));
      this.MALTBox.Text = Conversions.ToString(Math.Round(this.MALT, 3));
      this.APVBox.Text = Conversions.ToString(Math.Round(this.APV, 3));
      this.PEVBox.Text = Conversions.ToString(Math.Round(this.PEV, 3));
      this.VELBox.Text = Conversions.ToString(Math.Round(this.VEL, 3));
      this.ODBox.Text = this.SDOO;
      if (this.ANButton.Checked)
      {
        this.LNLabel.Text = "LAN";
        this.LTLabel.Text = "LTAN";
        this.LANBox.Text = Conversions.ToString(Math.Round(this.LAN, 4));
        this.LTANBox.Text = this.LTAN;
      }
      else if (this.DNButton.Checked)
      {
        this.LNLabel.Text = "LDN";
        this.LTLabel.Text = "LTDN";
        this.LANBox.Text = Conversions.ToString(Math.Round(this.LDN, 4));
        this.LTANBox.Text = this.LTDN;
      }
      this.KPERBox.Text = Conversions.ToString(Math.Round(this.KPER, 4));
      this.APERBox.Text = Conversions.ToString(Math.Round(this.APER, 4));
      this.DPERBox.Text = Conversions.ToString(Math.Round(this.DPER, 4));
      this.MMBox.Text = Conversions.ToString(Math.Round(this.MM, 4));
      this.NPBox.Text = Conversions.ToString(Math.Round(this.NP, 4));
      this.APBox.Text = Conversions.ToString(Math.Round(this.AP, 4));
      this.DLBox.Text = Conversions.ToString(Math.Round(this.DL, 4));
      this.RelDist.Text = Conversions.ToString(Math.Round(this.DREL, 4));
      this.ETFEBox.Text = Conversions.ToString(Math.Round(this.ETFE, 4));
      this.OrbNumBox.Text = this.ONAE;
      this.GSTBox.Text = Conversions.ToString(Math.Round(this.GST, 4));
      this.LSTBox.Text = Conversions.ToString(Math.Round(this.LST, 4));
      if (!Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectNotEqual(this.Stations_list.SelectedItem, (object) "", false), Operators.CompareObjectNotEqual(this.Stations_list.SelectedItem, (object) null, false))))
        return;
      if (Operators.CompareString(this.GS_Az_Link.Text, "deg", false) == 0 | Operators.CompareString(this.GS_El_Link.Text, "deg", false) == 0)
      {
        this.Stations_az.Text = Conversions.ToString(Math.Round(this.AZ, 4));
        this.Stations_el.Text = Conversions.ToString(Math.Round(this.EL, 4));
      }
      else if (Operators.CompareString(this.GS_Az_Link.Text, "dms", false) == 0 | Operators.CompareString(this.GS_El_Link.Text, "dms", false) == 0)
      {
        this.Stations_az.Text = this.AZ_dms;
        this.Stations_el.Text = this.EL_dms;
      }
      this.Stations_dist.Text = Conversions.ToString(Math.Round(this.DIST, 4));
    }

    private void Sat_SelectAll_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void Sat_SelectAll__LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      bool flag;
      if (Operators.CompareString(this.Sat_SelectAll.Text, "Select All", false) == 0)
      {
        this.Sat_SelectAll.Text = "Unselect All";
        flag = true;
      }
      else if (Operators.CompareString(this.Sat_SelectAll.Text, "Unselect All", false) == 0)
      {
        this.Sat_SelectAll.Text = "Select All";
        flag = false;
      }
      int num = checked (this.Sat_CheckListBox.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.Sat_CheckListBox.SelectedIndex = index;
        this.Sat_CheckListBox.SetItemChecked(index, flag);
        checked { ++index; }
      }
    }

    private void ETFP_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (Operators.CompareString(this.ETFP_Label.Text, "min", false) == 0)
        {
          this.ETFPBox.Text = Conversions.ToString(Functions.Round4(this.ETFP * 60.0));
          this.ETFP_Label.Text = "sec";
        }
        else if (Operators.CompareString(this.ETFP_Label.Text, "sec", false) == 0)
        {
          this.ETFPBox.Text = Conversions.ToString(Functions.Round4(this.ETFP));
          this.ETFP_Label.Text = "min";
        }
        goto label_11;
label_6:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_11;
        }
      }
      catch (Exception ex) when (
      {
        // ISSUE: unable to correctly present filter
        int num3;
        if (ex is Exception & num1 != 0 & num3 == 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        ProjectData.SetProjectError(ex);
        goto label_6;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_11:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void AnoPeriod_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (Operators.CompareString(this.AnoPeriod_Label.Text, "min", false) == 0)
        {
          this.APERBox.Text = Conversions.ToString(Functions.Round4(this.APER * 60.0));
          this.AnoPeriod_Label.Text = "sec";
        }
        else if (Operators.CompareString(this.AnoPeriod_Label.Text, "sec", false) == 0)
        {
          this.APERBox.Text = Conversions.ToString(Conversion.Int(this.APER / 60.0)) + ":" + Conversions.ToString(Conversion.Int((this.APER - Conversion.Int(this.APER)) * 60.0)) + ":" + Conversions.ToString(Math.Round(((this.APER - Conversion.Int(this.APER)) * 60.0 - Conversion.Int((this.APER - Conversion.Int(this.APER)) * 60.0)) * 60.0, 0));
          this.AnoPeriod_Label.Text = "h:m:s";
        }
        else if (Operators.CompareString(this.AnoPeriod_Label.Text, "h:m:s", false) == 0)
        {
          this.APERBox.Text = Conversions.ToString(Functions.Round4(this.APER));
          this.AnoPeriod_Label.Text = "min";
        }
        goto label_13;
label_8:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_13;
        }
      }
      catch (Exception ex) when (
      {
        // ISSUE: unable to correctly present filter
        int num3;
        if (ex is Exception & num1 != 0 & num3 == 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        ProjectData.SetProjectError(ex);
        goto label_8;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_13:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void DracoPeriod_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (Operators.CompareString(this.DracoPeriod_Label.Text, "min", false) == 0)
        {
          this.DPERBox.Text = Conversions.ToString(Functions.Round4(this.DPER * 60.0));
          this.DracoPeriod_Label.Text = "sec";
        }
        else if (Operators.CompareString(this.DracoPeriod_Label.Text, "sec", false) == 0)
        {
          this.DPERBox.Text = Conversions.ToString(Conversion.Int(this.DPER / 60.0)) + ":" + Conversions.ToString(Conversion.Int((this.DPER - Conversion.Int(this.DPER)) * 60.0)) + ":" + Conversions.ToString(Math.Round(((this.DPER - Conversion.Int(this.DPER)) * 60.0 - Conversion.Int((this.DPER - Conversion.Int(this.DPER)) * 60.0)) * 60.0, 0));
          this.DracoPeriod_Label.Text = "h:m:s";
        }
        else if (Operators.CompareString(this.DracoPeriod_Label.Text, "h:m:s", false) == 0)
        {
          this.DPERBox.Text = Conversions.ToString(Functions.Round4(this.DPER));
          this.DracoPeriod_Label.Text = "min";
        }
        goto label_13;
label_8:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_13;
        }
      }
      catch (Exception ex) when (
      {
        // ISSUE: unable to correctly present filter
        int num3;
        if (ex is Exception & num1 != 0 & num3 == 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        ProjectData.SetProjectError(ex);
        goto label_8;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_13:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void KepPeriod_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (Operators.CompareString(this.KepPeriod_Label.Text, "min", false) == 0)
        {
          this.KPERBox.Text = Conversions.ToString(Functions.Round4(this.KPER * 60.0));
          this.KepPeriod_Label.Text = "sec";
        }
        else if (Operators.CompareString(this.KepPeriod_Label.Text, "sec", false) == 0)
        {
          this.KPERBox.Text = Conversions.ToString(Conversion.Int(this.KPER / 60.0)) + ":" + Conversions.ToString(Conversion.Int((this.KPER - Conversion.Int(this.KPER)) * 60.0)) + ":" + Conversions.ToString(Math.Round(((this.KPER - Conversion.Int(this.KPER)) * 60.0 - Conversion.Int((this.KPER - Conversion.Int(this.KPER)) * 60.0)) * 60.0, 0));
          this.KepPeriod_Label.Text = "h:m:s";
        }
        else if (Operators.CompareString(this.KepPeriod_Label.Text, "h:m:s", false) == 0)
        {
          this.KPERBox.Text = Conversions.ToString(Functions.Round4(this.KPER));
          this.KepPeriod_Label.Text = "min";
        }
        goto label_13;
label_8:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_13;
        }
      }
      catch (Exception ex) when (
      {
        // ISSUE: unable to correctly present filter
        int num3;
        if (ex is Exception & num1 != 0 & num3 == 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        ProjectData.SetProjectError(ex);
        goto label_8;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_13:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void DLong_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (Operators.CompareString(this.DLong_Label.Text, "deg", false) == 0)
        {
          this.DLBox.Text = Conversions.ToString(Functions.Round4(Math.PI / 180.0 * this.DL * 6378.136658));
          this.DLong_Label.Text = "km";
        }
        else if (Operators.CompareString(this.DLong_Label.Text, "km", false) == 0)
        {
          this.DLBox.Text = Conversions.ToString(Functions.Round4(this.DL));
          this.DLong_Label.Text = "deg";
        }
        goto label_11;
label_6:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_11;
        }
      }
      catch (Exception ex) when (
      {
        // ISSUE: unable to correctly present filter
        int num3;
        if (ex is Exception & num1 != 0 & num3 == 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        ProjectData.SetProjectError(ex);
        goto label_6;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_11:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void LAN_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      int num1;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (Operators.CompareString(this.LANType.Text, "[-180;180]", false) == 0)
        {
          if (Conversion.Val(this.LANBox.Text) > 0.0 && Conversion.Val(this.LANBox.Text) < 180.0)
          {
            this.LANType.Text = "[0;360]";
          }
          else
          {
            this.LANBox.Text = Conversions.ToString(360.0 + Conversion.Val(this.LANBox.Text));
            this.LANType.Text = "[0;360]";
          }
        }
        else if (Operators.CompareString(this.LANType.Text, "[0;360]", false) == 0)
        {
          if (Conversion.Val(this.LANBox.Text) > 180.0)
          {
            this.LANBox.Text = Conversions.ToString(Conversion.Val(this.LANBox.Text) - 360.0);
            this.LANType.Text = "[-180;180]";
          }
          else
            this.LANType.Text = "[-180;180]";
        }
        goto label_16;
label_11:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_16;
        }
      }
      catch (Exception ex) when (
      {
        // ISSUE: unable to correctly present filter
        int num3;
        if (ex is Exception & num1 != 0 & num3 == 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        ProjectData.SetProjectError(ex);
        goto label_11;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_16:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void ANButton_CheckedChanged(object sender, EventArgs e)
    {
      if (this.ANButton.Checked)
      {
        this.LNLabel.Text = "LAN";
        this.LTLabel.Text = "LTAN";
        this.LANBox.Text = Conversions.ToString(Math.Round(this.LAN, 4));
        this.LTANBox.Text = this.LTAN;
      }
      else
      {
        if (this.ANButton.Checked)
          return;
        this.LNLabel.Text = "LDN";
        this.LTLabel.Text = "LTDN";
        this.LANBox.Text = Conversions.ToString(Math.Round(this.LDN, 4));
        this.LTANBox.Text = this.LTDN;
      }
    }

    private void GS_Az_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (Operators.CompareString(this.GS_Az_Link.Text, "deg", false) == 0)
      {
        this.GS_Az_Link.Text = "dms";
        this.GS_El_Link.Text = "dms";
        int deg;
        int min;
        int sec;
        Maths.Deg2DMS(this.AZ, ref deg, ref min, ref sec);
        this.Stations_az.Text = Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
        Maths.Deg2DMS(this.EL, ref deg, ref min, ref sec);
        this.Stations_el.Text = Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
      }
      else
      {
        if (Operators.CompareString(this.GS_Az_Link.Text, "dms", false) != 0)
          return;
        this.GS_Az_Link.Text = "deg";
        this.GS_El_Link.Text = "deg";
        this.Stations_az.Text = Conversions.ToString(Functions.Round4(this.AZ));
        this.Stations_el.Text = Conversions.ToString(Functions.Round4(this.EL));
      }
    }

    private void GS_El_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (Operators.CompareString(this.GS_El_Link.Text, "deg", false) == 0)
      {
        this.GS_Az_Link.Text = "dms";
        this.GS_El_Link.Text = "dms";
        this.Stations_az.Text = this.AZ_dms;
        this.Stations_el.Text = this.EL_dms;
      }
      else
      {
        if (Operators.CompareString(this.GS_El_Link.Text, "dms", false) != 0)
          return;
        this.GS_Az_Link.Text = "deg";
        this.GS_El_Link.Text = "deg";
        this.Stations_az.Text = Conversions.ToString(Functions.Round4(this.AZ));
        this.Stations_el.Text = Conversions.ToString(Functions.Round4(this.EL));
      }
    }

    private void EpochFormat_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!Functions.CheckEpoch())
        return;
      if (this.EPOCH_Format.SelectedIndex == 1)
      {
        this.EPOCH_Current.Text = Functions.MJDtoGreg(Conversions.ToString(this.EPOCH));
        this.EPOCH_TLE.Text = Functions.MJDtoGreg(Conversions.ToString(this.TLEPOCH));
      }
      else if (this.EPOCH_Format.SelectedIndex == 0)
      {
        this.EPOCH_Current.Text = Conversions.ToString(this.EPOCH);
        this.EPOCH_TLE.Text = Conversions.ToString(this.TLEPOCH);
      }
      else if (this.EPOCH_Format.SelectedIndex == 2)
      {
        double num1 = Functions.GregtoTLE(Functions.MJDtoGreg(Conversions.ToString(this.EPOCH)));
        double num2 = Functions.GregtoTLE(Functions.MJDtoGreg(Conversions.ToString(this.TLEPOCH)));
        if (num1 == 0.0)
        {
          int num3 = (int) Interaction.MsgBox((object) "For TLE format conversion, Epoch must be:\r\n04/10/1957 < EPOCH < 31/12/2056", MsgBoxStyle.Exclamation, (object) "TLE ANALAYSER");
          this.EPOCH_Format.SelectedIndex = 1;
        }
        else
        {
          this.EPOCH_Current.Text = !(num1 < 9365.99998845 & num1 > 366.00952546) ? (num1 >= 366.00952546 ? Conversions.ToString(num1) : "00" + Conversions.ToString(num1)) : "0" + Conversions.ToString(num1);
          this.EPOCH_TLE.Text = !(num2 < 9000.0 & num2 > 366.00952546) ? (num2 >= 366.00952546 ? Conversions.ToString(num2) : "00" + Conversions.ToString(num2)) : "0" + Conversions.ToString(num2);
        }
      }
    }

    private void Epoch_TextChanged(object sender, EventArgs e)
    {
      this.TrackingOptions.Enabled = false;
      this.Timer1.Enabled = false;
      this.Timer2.Enabled = false;
      this.EPOCH_Format.Enabled = true;
    }

    private void Epoch_TextChanged_1(object sender, EventArgs e)
    {
      this.TrackingOptions.Enabled = true;
      if (!this.Valid_Epoch("home", this.EPOCH_Format.SelectedIndex))
        return;
      this.TLE_Prediction();
      this.Graph_Actualise(true);
      this.Graph_Radar_Actualise();
    }

    private void EPOCH_Current_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.EPOCH_Format.SelectedIndex == 0 | this.EPOCH_Format.SelectedIndex == 2)
      {
        if (Versioned.IsNumeric((object) e.KeyChar) | Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
          e.Handled = false;
        else if (e.KeyChar == '\b')
          e.KeyChar = '\b';
        else
          e.Handled = !((int) e.KeyChar == (int) Convert.ToChar(3) | (int) e.KeyChar == (int) Convert.ToChar(22) | (int) e.KeyChar == (int) Convert.ToChar(24));
      }
      else if (this.EPOCH_Format.SelectedIndex == 1)
      {
        if (Versioned.IsNumeric((object) e.KeyChar))
          e.Handled = false;
        else if (e.KeyChar == '\b')
          e.KeyChar = '\b';
        else
          e.Handled = !(Operators.CompareString(Conversions.ToString(e.KeyChar), "/", false) == 0 | Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0 | Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0 | Operators.CompareString(Conversions.ToString(e.KeyChar), ":", false) == 0 | Operators.CompareString(Conversions.ToString(e.KeyChar), " ", false) == 0) && !((int) e.KeyChar == (int) Convert.ToChar(3) | (int) e.KeyChar == (int) Convert.ToChar(22) | (int) e.KeyChar == (int) Convert.ToChar(24));
      }
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      this.TrackingOptions.Enabled = true;
      if (this.Valid_Epoch("home", this.EPOCH_Format.SelectedIndex))
      {
        this.TLE_Prediction();
        this.Graph_Actualise(true);
        this.Graph_Radar_Actualise();
      }
    }

    private void NowDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (this.SIM_RealTime.Checked)
        this.SIM_Manual.Checked = true;
      this.Epoch_SetDate(Functions.GregtoMJD(Conversions.ToString(Functions.CurrentDateToGreg())));
    }

    private void TLEDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (this.SIM_RealTime.Checked)
        this.SIM_Manual.Checked = true;
      this.Epoch_SetDate(this.TLEPOCH);
    }

    public void Epoch_SetDate(double MJDDate)
    {
      if (this.EPOCH_Format.SelectedIndex == 1)
        this.EPOCH_Current.Text = Functions.MJDtoGreg(Conversions.ToString(MJDDate));
      else if (this.EPOCH_Format.SelectedIndex == 0)
        this.EPOCH_Current.Text = Conversions.ToString(MJDDate);
      else if (this.EPOCH_Format.SelectedIndex == 2)
        this.EPOCH_Current.Text = Conversions.ToString(Functions.GregtoTLE(Functions.MJDtoGreg(Conversions.ToString(MJDDate))));
      this.EPOCH = MJDDate;
      this.TLE_Prediction();
      this.Graph_Actualise(true);
      this.Graph_Radar_Actualise();
    }

    public bool Valid_Epoch(string _epochSource, int _format)
    {
      bool flag = true;
      if (Operators.CompareString(_epochSource, "home", false) == 0)
      {
        switch (_format)
        {
          case 0:
            this.EPOCH = Conversions.ToDouble(this.EPOCH_Current.Text);
            break;
          case 1:
            this.EPOCH = Functions.GregtoMJD(this.EPOCH_Current.Text);
            if (this.EPOCH == 0.0)
            {
              this.EPOCH_Current.ForeColor = Color.Red;
              flag = false;
              break;
            }
            this.EPOCH_Current.ForeColor = Color.Black;
            break;
          case 2:
            if (Conversions.ToDouble(this.EPOCH_Current.Text) < 1.0 | Conversions.ToDouble(this.EPOCH_Current.Text) > 99366.99998843 | Conversions.ToDouble(this.EPOCH_Current.Text) > 56366.99998843 & Conversions.ToDouble(this.EPOCH_Current.Text) < 57277.0)
            {
              this.EPOCH_Current.ForeColor = Color.Red;
              flag = false;
            }
            else
            {
              this.EPOCH_Current.ForeColor = Color.Black;
              this.EPOCH = Functions.TLEtoMJD(Conversions.ToDouble(this.EPOCH_Current.Text));
            }
            break;
        }
      }
      else if (Operators.CompareString(_epochSource, "create", false) == 0)
      {
        switch (_format)
        {
          case 0:
            this.CREATEPOCH = Conversions.ToDouble(this.CREATE_EPOCH_Current.Text);
            if (this.CREATEPOCH < 6115.5 | this.CREATEPOCH > 42363.4999884259)
            {
              flag = false;
              this.CREATE_EPOCH_Current.ForeColor = Color.Red;
              break;
            }
            this.CREATE_EPOCH_Current.ForeColor = Color.Black;
            break;
          case 1:
            this.CREATEPOCH = Functions.GregtoMJD(this.CREATE_EPOCH_Current.Text);
            if (this.CREATEPOCH == 0.0)
            {
              this.CREATE_EPOCH_Current.ForeColor = Color.Red;
              flag = false;
              break;
            }
            if (this.CREATEPOCH < 6115.5 | this.CREATEPOCH > 42363.4999884259)
            {
              flag = false;
              this.CREATE_EPOCH_Current.ForeColor = Color.Red;
              break;
            }
            this.CREATE_EPOCH_Current.ForeColor = Color.Black;
            break;
          case 2:
            if (Conversions.ToDouble(this.CREATE_EPOCH_Current.Text) < 1.0 | Conversions.ToDouble(this.CREATE_EPOCH_Current.Text) > 99366.99998843 | Conversions.ToDouble(this.CREATE_EPOCH_Current.Text) > 56366.99998843 & Conversions.ToDouble(this.CREATE_EPOCH_Current.Text) < 57277.0)
            {
              this.CREATE_EPOCH_Current.ForeColor = Color.Red;
              flag = false;
            }
            else
            {
              this.CREATE_EPOCH_Current.ForeColor = Color.Black;
              this.CREATEPOCH = Functions.TLEtoMJD(Conversions.ToDouble(this.CREATE_EPOCH_Current.Text));
            }
            break;
        }
      }
      return flag;
    }

    private void SiMuBefore_Click(object sender, EventArgs e)
    {
      string Left1 = Conversions.ToString(this.SIM_Step.SelectedItem);
      string Left2 = Conversions.ToString(this.SIM_Unit.SelectedItem);
      this.Timer2.Enabled = false;
      this.EPOCH_Format.Enabled = false;
      if (Operators.CompareString(Left1, "", false) == 0 || Operators.CompareString(Left2, "", false) == 0)
      {
        int num = (int) TopMostMessageBox.Show("Please select prediction parameters.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        this.Timer1.Enabled = true;
        this.SIM_Forward.Enabled = true;
        this.SIM_Backward.Enabled = false;
      }
    }

    private void SiMuAfter_Click(object sender, EventArgs e)
    {
      string Left1 = Conversions.ToString(this.SIM_Step.SelectedItem);
      string Left2 = Conversions.ToString(this.SIM_Unit.SelectedItem);
      this.Timer1.Enabled = false;
      this.EPOCH_Format.Enabled = false;
      if (Operators.CompareString(Left1, "", false) == 0 || Operators.CompareString(Left2, "", false) == 0)
      {
        int num = (int) TopMostMessageBox.Show("Please select prediction parameters.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        this.Timer2.Enabled = true;
        this.SIM_Forward.Enabled = false;
        this.SIM_Backward.Enabled = true;
      }
    }

    private void SimuPause_Click(object sender, EventArgs e)
    {
      this.Timer1.Enabled = false;
      this.Timer2.Enabled = false;
      this.EPOCH_Format.Enabled = true;
      this.SIM_Forward.Enabled = true;
      this.SIM_Backward.Enabled = true;
    }

    private void SimuSBSP_Click(object sender, EventArgs e)
    {
      this.Timer1.Enabled = false;
      this.Timer2.Enabled = false;
      string Left1 = Conversions.ToString(this.SIM_Step.SelectedItem);
      string Left2 = Conversions.ToString(this.SIM_Unit.SelectedItem);
      this.EPOCH_Format.Enabled = false;
      if (Operators.CompareString(Left1, "", false) == 0 || Operators.CompareString(Left2, "", false) == 0)
      {
        int num = (int) TopMostMessageBox.Show("Please select prediction parameters.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        this.SIM_Foreward_SbS.Enabled = false;
        this.Timer2.Enabled = true;
        this.SIM_Forward.Enabled = true;
        this.SIM_Backward.Enabled = true;
      }
    }

    private void SimuSBSM_Click(object sender, EventArgs e)
    {
      this.Timer1.Enabled = false;
      this.Timer2.Enabled = false;
      string Left1 = Conversions.ToString(this.SIM_Step.SelectedItem);
      string Left2 = Conversions.ToString(this.SIM_Unit.SelectedItem);
      this.EPOCH_Format.Enabled = false;
      if (Operators.CompareString(Left1, "", false) == 0 || Operators.CompareString(Left2, "", false) == 0)
      {
        int num = (int) TopMostMessageBox.Show("Please select prediction parameters.", "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        this.SIM_Backward_SbS.Enabled = false;
        this.Timer1.Enabled = true;
        this.SIM_Forward.Enabled = true;
        this.SIM_Backward.Enabled = true;
      }
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      string str1 = Conversions.ToString(this.SIM_Step.SelectedItem);
      string str2 = Conversions.ToString(this.SIM_Unit.SelectedItem);
      switch (Conversions.ToInteger(this.Speed))
      {
        case 1:
          this.Timer1.Interval = 1000;
          break;
        case 10:
          this.Timer1.Interval = 100;
          break;
        case 100:
          this.Timer1.Interval = 10;
          break;
      }
      double num1;
      if (Operators.CompareString(this.DracoPeriod_Label.Text, "sec", false) == 0)
        num1 = this.DPER / 60.0;
      else if (Operators.CompareString(this.DracoPeriod_Label.Text, "min", false) == 0)
        num1 = this.DPER;
      string Left = str2;
      double num2;
      if (Operators.CompareString(Left, "sec", false) == 0)
        num2 = 86400.0;
      else if (Operators.CompareString(Left, "min", false) == 0)
        num2 = 1440.0;
      else if (Operators.CompareString(Left, "hr", false) == 0)
        num2 = 24.0;
      else if (Operators.CompareString(Left, "day", false) == 0)
        num2 = 1.0;
      else if (Operators.CompareString(Left, "period", false) == 0)
        num2 = 1440.0 / num1;
      this.EPOCH -= Conversions.ToDouble(str1) * (1.0 / num2);
      this.EPOCH_Current.Text = Conversions.ToDouble(Conversions.ToString(this.EPOCH_Format.SelectedIndex)) != 0.0 ? Functions.MJDtoGreg(Conversions.ToString(this.EPOCH)) : Conversions.ToString(this.EPOCH);
      double lat1 = this.LAT;
      this.TLE_Prediction();
      double lat2 = this.LAT;
      this.TLELoaded = false;
      if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(this.SIM_Unit.SelectedItem, (object) "period", false), (object) (lat1 > 0.0 & lat2 < 0.0)), (object) (Conversions.ToDouble(str1) * (1.0 / num2) > this.DPER / 1440.0 / 2.0))))
        this.Graph_Actualise(true);
      else
        this.Graph_Actualise(false);
      this.TLELoaded = true;
      this.Graph_Radar_Actualise();
      if (this.SIM_Backward_SbS.Enabled)
        return;
      this.SIM_Backward_SbS.Enabled = true;
      this.Timer1.Enabled = false;
      this.EPOCH_Format.Enabled = true;
    }

    private void Timer2_Tick(object sender, EventArgs e)
    {
      string str1 = Conversions.ToString(this.SIM_Step.SelectedItem);
      string str2 = Conversions.ToString(this.SIM_Unit.SelectedItem);
      if (Operators.CompareString(this.RealTimeStep, "", false) == 0 | Operators.CompareString(this.RealTimeStep, "0", false) == 0)
        this.RealTimeStep = "1";
      if (this.SIM_RealTime.Checked)
      {
        this.Timer2.Interval = checked ((int) Math.Round(unchecked (1000.0 * Conversions.ToDouble(this.RealTimeStep))));
      }
      else
      {
        switch (Conversions.ToInteger(this.Speed))
        {
          case 1:
            this.Timer2.Interval = 1000;
            break;
          case 10:
            this.Timer2.Interval = 100;
            break;
          case 100:
            this.Timer2.Interval = 10;
            break;
        }
      }
      string Left = str2;
      double num;
      if (Operators.CompareString(Left, "sec", false) == 0)
        num = 86400.0;
      else if (Operators.CompareString(Left, "min", false) == 0)
        num = 1440.0;
      else if (Operators.CompareString(Left, "hr", false) == 0)
        num = 24.0;
      else if (Operators.CompareString(Left, "day", false) == 0)
        num = 1.0;
      else if (Operators.CompareString(Left, "period", false) == 0)
        num = 1440.0 / this.DPER;
      double epoch1 = this.EPOCH;
      if (this.SIM_RealTime.Checked)
        this.EPOCH = Functions.GregtoMJD(Conversions.ToString(Functions.CurrentDateToGreg()));
      else
        this.EPOCH += Conversions.ToDouble(str1) * (1.0 / num);
      this.EPOCH_Current.Text = this.EPOCH_Format.SelectedIndex != 0 ? Functions.MJDtoGreg(Conversions.ToString(this.EPOCH)) : Conversions.ToString(this.EPOCH);
      double epoch2 = this.EPOCH;
      double lat1 = this.LAT;
      this.TLE_Prediction();
      double lat2 = this.LAT;
      this.TLELoaded = false;
      if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(this.SIM_Unit.SelectedItem, (object) "period", false), (object) (lat1 < 0.0 & lat2 > 0.0)), (object) (Conversions.ToDouble(str1) * (1.0 / num) > this.DPER / 1440.0 / 2.0)), (object) (Math.Abs(epoch2 - epoch1) > this.DPER / 1440.0 / 2.0))))
        this.Graph_Actualise(true);
      else
        this.Graph_Actualise(false);
      this.TLELoaded = true;
      this.Graph_Radar_Actualise();
      if (this.SIM_RealTime.Checked || this.SIM_Foreward_SbS.Enabled)
        return;
      this.SIM_Foreward_SbS.Enabled = true;
      this.Timer2.Enabled = false;
      this.EPOCH_Format.Enabled = true;
    }

    private void ActuTrack_Click(object sender, EventArgs e) => this.Track_Actualise();

    private void MapPeriodNbr_SelectedIndexChanged(object sender, EventArgs e) => this.Graph_Actualise(true);

    private void MapShowTrack_CheckedChanged(object sender, EventArgs e)
    {
      if (this.MAP_ShowTrack.Enabled && this.MAP_ShowTrack.Checked)
        this.MAP_Num_Period.Enabled = true;
      else if (this.MAP_ShowTrack.Enabled && !this.MAP_ShowTrack.Checked)
        this.MAP_Num_Period.Enabled = false;
      this.Graph_Actualise(false);
    }

    private void MapShowGrid_CheckedChanged(object sender, EventArgs e) => this.Graph_Actualise(false);

    private void MAP_SatName_CheckedChanged(object sender, EventArgs e) => this.Graph_Actualise(false);

    private void SunShadowCB_CheckedChanged(object sender, EventArgs e) => this.Graph_Actualise(false);

    private void DisplayLatLng(object sender, EventArgs e)
    {
      int width = this.MapPanel.Width;
      double num1 = (double) width / 2.0;
      int height = this.MapPanel.Height;
      double num2 = (double) height / 2.0;
      Point client = this.PointToClient(Control.MousePosition);
      double num3 = 20.0;
      double num4 = (double) checked (client.X - this.MAP_MainTab.Location.X - this.MapPanel.Location.X - this.TracePicture.Location.X - 5);
      double num5 = (double) checked (client.Y - this.MAP_MainTab.Location.Y - this.MapPanel.Location.Y - this.TracePicture.Location.Y) - num3;
      double num6 = num4 * 360.0 / (double) width;
      string str1;
      if (num4 < num1)
      {
        num6 = -(180.0 - num6);
        str1 = " W";
      }
      else if (num4 >= num1)
      {
        num6 -= 180.0;
        str1 = " E";
      }
      double num7 = num5 * 180.0 / (double) height;
      string str2;
      if (num5 < num2)
      {
        num7 = 90.0 - num7;
        str2 = " N";
      }
      else if (num5 >= num2)
      {
        num7 = -(num7 - 90.0);
        str2 = " S";
      }
      int num8;
      if (Operators.CompareString(this.GSFullName, "True", false) == 0)
        num8 = 0;
      if (Operators.CompareString(this.GSShortName, "True", false) == 0)
        num8 = 1;
      this.LNGLATMouseBOX.Text = Math.Round(num6, 3).ToString("000.00") + str1 + " | " + Math.Round(num7, 3).ToString("000.00") + str2;
      double num9 = (double) this.SatLatLng.Length / 3.0 - 1.0;
      for (double a = 0.0; a <= num9; ++a)
      {
        float num10 = (float) Math.Round(num2 - Conversions.ToDouble(this.SatLatLng[checked ((int) Math.Round(a)), 1]) * (double) checked (height - 1) / 180.0, 0);
        float num11 = (float) Math.Round(num1 + Conversions.ToDouble(this.SatLatLng[checked ((int) Math.Round(a)), 2]) * (double) checked (width - 1) / 360.0, 0);
        if (num4 > (double) num11 - 5.0 & num4 < (double) num11 + 5.0 & num5 > (double) num10 - 5.0 & num5 < (double) num10 + 5.0)
        {
          int num12 = checked (this.Sat_CheckListBox.Items.Count - 1);
          int index = 0;
          while (index <= num12)
          {
            if (Operators.CompareString(this.Satellites[index, 2], this.SatLatLng[checked ((int) Math.Round(a)), 0], false) == 0)
            {
              this.MouseOnSat = true;
              break;
            }
            checked { ++index; }
          }
          if (this.MouseOnSat)
            break;
        }
        else
          this.MouseOnSat = false;
      }
      this.Graph_Actualise(false);
    }

    private void ActiveSatOnMap(object sender, EventArgs e)
    {
      int width = this.MapPanel.Width;
      double num1 = (double) width / 2.0;
      int height = this.MapPanel.Height;
      double num2 = (double) height / 2.0;
      Point client = this.PointToClient(Control.MousePosition);
      double num3 = 20.0;
      double num4 = (double) checked (client.X - this.MAP_MainTab.Location.X - this.MapPanel.Location.X - this.TracePicture.Location.X - 5);
      double num5 = (double) checked (client.Y - this.MAP_MainTab.Location.Y - this.MapPanel.Location.Y - this.TracePicture.Location.Y) - num3;
      double num6 = (double) this.SatLatLng.Length / 3.0 - 1.0;
      for (double a = 0.0; a <= num6; ++a)
      {
        float num7 = (float) Math.Round(num2 - Conversions.ToDouble(this.SatLatLng[checked ((int) Math.Round(a)), 1]) * (double) checked (height - 1) / 180.0, 0);
        float num8 = (float) Math.Round(num1 + Conversions.ToDouble(this.SatLatLng[checked ((int) Math.Round(a)), 2]) * (double) checked (width - 1) / 360.0, 0);
        if (num4 > (double) num8 - 5.0 & num4 < (double) num8 + 5.0 & num5 > (double) num7 - 5.0 & num5 < (double) num7 + 5.0)
        {
          int num9 = checked (this.Sat_CheckListBox.Items.Count - 1);
          int index = 0;
          while (index <= num9)
          {
            if (Operators.CompareString(this.Satellites[index, 2], this.SatLatLng[checked ((int) Math.Round(a)), 0], false) == 0)
            {
              this.Sat_CheckListBox.SelectedIndex = index;
              break;
            }
            checked { ++index; }
          }
        }
      }
    }

    public void Track_Actualise()
    {
      this.Timer1.Enabled = false;
      this.Timer2.Enabled = false;
      this.EPOCH_Format.Enabled = true;
      this.MAP_Num_Period.SelectedIndex = 0;
      this.Graph_Actualise(true);
    }

    private void PtsOnOrbit_CB_CheckedChanged(object sender, EventArgs e) => this.Graph_Actualise(false);

    private void FullTrackCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.MAP_Show_FullTrack.Checked)
        this.MAP_Num_Period.Enabled = false;
      else
        this.MAP_Num_Period.Enabled = true;
      this.Graph_Actualise(true);
    }

    private void ManualMode_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SIM_Manual.Checked)
        return;
      this.Timer1.Enabled = false;
      this.Timer2.Enabled = false;
      this.EPOCH_Format.Enabled = true;
      this.EPOCH_Current.Enabled = true;
      this.SIM_Unit.SelectedIndex = 1;
      if (!this.TLELoaded)
        return;
      this.TrackingOptions.Enabled = true;
    }

    private void RealTimeMode_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SIM_RealTime.Checked)
        return;
      this.Timer1.Enabled = false;
      this.EPOCH_Format.Enabled = false;
      this.TrackingOptions.Enabled = false;
      this.EPOCH_Current.Enabled = false;
      this.SIM_Unit.SelectedIndex = 0;
      this.Timer2.Enabled = true;
    }

    private void MAP_VisibilityZone_CheckedChanged(object sender, EventArgs e) => this.Graph_Actualise(false);

    public void SGP4(double _EPOCH, double _TLEPOCH)
    {
      this.SatActive = (object) new Satellite((TLE) this.TleActive);
      Dates dat = Functions.MJD2JJ(_EPOCH);
      object satActive1 = this.SatActive;
      object[] objArray1 = new object[2]
      {
        (object) dat,
        (object) _TLEPOCH
      };
      object[] Arguments1 = objArray1;
      bool[] flagArray1 = new bool[2]{ true, true };
      bool[] CopyBack1 = flagArray1;
      NewLateBinding.LateCall(satActive1, (Type) null, "CalculPosVit", Arguments1, (string[]) null, (Type[]) null, CopyBack1, true);
      if (flagArray1[0])
        dat = (Dates) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (Dates));
      if (flagArray1[1])
        _TLEPOCH = (double) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[1]), typeof (double));
      object satActive2 = this.SatActive;
      object[] objArray2 = new object[2]
      {
        (object) dat,
        RuntimeHelpers.GetObjectValue(this.TleActive)
      };
      object[] Arguments2 = objArray2;
      bool[] flagArray2 = new bool[2]{ true, true };
      bool[] CopyBack2 = flagArray2;
      NewLateBinding.LateCall(satActive2, (Type) null, "CalculElementsOsculateurs", Arguments2, (string[]) null, (Type[]) null, CopyBack2, true);
      if (flagArray2[0])
        dat = (Dates) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (Dates));
      if (flagArray2[1])
        this.TleActive = RuntimeHelpers.GetObjectValue(objArray2[1]);
      object satActive3 = this.SatActive;
      object[] objArray3 = new object[1]{ (object) dat };
      object[] Arguments3 = objArray3;
      bool[] flagArray3 = new bool[1]{ true };
      bool[] CopyBack3 = flagArray3;
      NewLateBinding.LateCall(satActive3, (Type) null, "CalculCoordTerrestres", Arguments3, (string[]) null, (Type[]) null, CopyBack3, true);
      if (flagArray3[0])
        dat = (Dates) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof (Dates));
      NewLateBinding.LateCall(this.SatActive, (Type) null, "CalculZoneVisibilite", new object[0], (string[]) null, (Type[]) null, (bool[]) null, true);
      Dates epochDat = dat;
      Satellite satActive4 = (Satellite) this.SatActive;
      ref Satellite local = ref satActive4;
      this.Math_AzElDist(epochDat, ref local);
      this.SatActive = (object) satActive4;
      this.Soleil.CalculPosition(dat);
      this.X = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Position", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "X", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.Y = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Position", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Y", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.Z = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Position", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Z", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.VX = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Vitesse", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "X", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.VY = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Vitesse", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Y", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.VZ = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Vitesse", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Z", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.XS = this.Soleil.Position.X;
      this.YS = this.Soleil.Position.Y;
      this.ZS = this.Soleil.Position.Z;
      this.SMA = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "DemiGrandAxe", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.ECC = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Excentricite", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.INC = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Inclinaison", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.RAAN = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "AscDroiteNA", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.AOP = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "ArgumentPerigee", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.MA = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "AnomalieMoyenne", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.TA = Conversions.ToDouble(Operators.MultiplyObject((object) (Math.PI / 180.0), NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "AnomalieVraie", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.EA = Conversions.ToDouble(Operators.MultiplyObject((object) (Math.PI / 180.0), NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "Elements", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "AnomalieExcentrique", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.LAT = Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(this.SatActive, (Type) null, "Latitude", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.LONGI = Conversions.ToDouble(Operators.MultiplyObject((object) (-180.0 / Math.PI), NewLateBinding.LateGet(this.SatActive, (Type) null, "Longitude", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.GST = 180.0 / Math.PI * Observateur.TempsSideralDeGreenwich(dat);
      this.ONAE = Conversions.ToString(NewLateBinding.LateGet(this.SatActive, (Type) null, "NbOrbites", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.AZ = Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(this.SatActive, (Type) null, "Azimut", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.EL = Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(this.SatActive, (Type) null, "Hauteur", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.DIST = Conversions.ToDouble(NewLateBinding.LateGet(this.SatActive, (Type) null, "Distance", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      int deg;
      int min;
      int sec;
      Maths.Deg2DMS(this.AZ, ref deg, ref min, ref sec);
      this.AZ_dms = Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
      Maths.Deg2DMS(this.EL, ref deg, ref min, ref sec);
      this.EL_dms = Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
    }

    public void SGP4_Trace(double _EPOCH, double _TLEPOCH)
    {
      Dates dates = Functions.MJD2JJ(_EPOCH);
      object satTrack1 = this.SatTrack;
      object[] objArray1 = new object[2]
      {
        (object) dates,
        (object) _TLEPOCH
      };
      object[] Arguments1 = objArray1;
      bool[] flagArray1 = new bool[2]{ true, true };
      bool[] CopyBack1 = flagArray1;
      NewLateBinding.LateCall(satTrack1, (Type) null, "CalculPosVit", Arguments1, (string[]) null, (Type[]) null, CopyBack1, true);
      if (flagArray1[0])
        dates = (Dates) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (Dates));
      if (flagArray1[1])
        _TLEPOCH = (double) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[1]), typeof (double));
      object satTrack2 = this.SatTrack;
      object[] objArray2 = new object[1]{ (object) dates };
      object[] Arguments2 = objArray2;
      bool[] flagArray2 = new bool[1]{ true };
      bool[] CopyBack2 = flagArray2;
      NewLateBinding.LateCall(satTrack2, (Type) null, "CalculCoordTerrestres", Arguments2, (string[]) null, (Type[]) null, CopyBack2, true);
      if (flagArray2[0])
        dates = (Dates) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (Dates));
      Dates epochDat = dates;
      Satellite satTrack3 = (Satellite) this.SatTrack;
      ref Satellite local = ref satTrack3;
      this.Math_AzElDist(epochDat, ref local);
      this.SatTrack = (object) satTrack3;
      this.XN = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatTrack, (Type) null, "Position", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "X", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.YN = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatTrack, (Type) null, "Position", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Y", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.ZN = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatTrack, (Type) null, "Position", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Z", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.VXN = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatTrack, (Type) null, "Vitesse", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "X", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.VYN = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatTrack, (Type) null, "Vitesse", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Y", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      this.VZN = Conversions.ToDouble(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatTrack, (Type) null, "Vitesse", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Z", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
    }

    public void SGP4_TLE_EPOCH(double _EPOCH, double _TLEPOCH)
    {
      Satellite satellite = new Satellite(new TLE(this.LIGNE1, this.LIGNE2));
      satellite.CalculPosVit(Functions.MJD2JJ(_EPOCH), _TLEPOCH);
      this.XTLE = satellite.Position.X;
      this.YTLE = satellite.Position.Y;
      this.ZTLE = satellite.Position.Z;
      this.VXTLE = satellite.Vitesse.X;
      this.VYTLE = satellite.Vitesse.Y;
      this.VZTLE = satellite.Vitesse.Z;
    }

    public void SGP4_XP_EPOCH(double _EPOCH, double _TLEPOCH)
    {
      Satellite satellite = new Satellite(new TLE(this.LIGNE1, this.LIGNE2));
      satellite.CalculPosVit(Functions.MJD2JJ(_EPOCH), _TLEPOCH);
      this.XXP = satellite.Position.X;
      this.YXP = satellite.Position.Y;
      this.ZXP = satellite.Position.Z;
      this.VXXP = satellite.Vitesse.X;
      this.VYXP = satellite.Vitesse.Y;
      this.VZXP = satellite.Vitesse.Z;
    }

    public void SGP4_SEARCH(double _EPOCH, double _TLEPOCH, string TLELine1, string TLELine2)
    {
      TLE tle = new TLE(TLELine1, TLELine2);
      Satellite satellite = new Satellite(tle);
      Dates dat = Functions.MJD2JJ(_EPOCH);
      satellite.CalculPosVit(Functions.MJD2JJ(_EPOCH), _TLEPOCH);
      satellite.CalculElementsOsculateurs(dat, tle);
      this.XC = satellite.Position.X;
      this.YC = satellite.Position.Y;
      this.ZC = satellite.Position.Z;
      this.VXC = satellite.Vitesse.X;
      this.VYC = satellite.Vitesse.Y;
      this.VZC = satellite.Vitesse.Z;
      this.SMAC = satellite.Elements.DemiGrandAxe;
      this.ECCC = satellite.Elements.Excentricite;
      this.INCC = satellite.Elements.Inclinaison;
      this.RAANC = satellite.Elements.AscDroiteNA;
      this.AOPC = satellite.Elements.ArgumentPerigee;
      this.TAC = Math.PI / 180.0 * satellite.Elements.AnomalieVraie;
    }

    public void Graph_Actualise(bool ActuTrack)
    {
      int num1;
      int num2;
      try
      {
        double a = !this.MAP_Show_FullTrack.Checked ? Conversions.ToDouble(this.MAP_Num_Period.SelectedItem) : this.NT0;
        ProjectData.ClearProjectError();
        num1 = 2;
        this.g.Clear(this.TracePicture.BackColor);
        this.Graph_DrawSunShadow();
        this.Graph_DrawGrid();
        if (this.MAP_VisibilityZone.Checked)
          this.Graph_DrawVisibiltyZone();
        if (ActuTrack | (double) this.SatTrace.Length / 5.0 < (double) checked (360 * (int) Math.Round(a)))
        {
          this.Track_TrackCalc(checked ((int) Math.Round(a)));
          this.Track_TrackDisp(checked ((int) Math.Round(a)));
          if (!this.TrackModeActive)
          {
            if (this.MAP_MainTab.SelectedIndex == 1)
            {
              this.GoogleEarthControl1.DeleteTrace();
              this.GoogleEarthControl1.addTrace();
              if (this.Sat_CheckListBox.CheckedItems.Count < 1 && this.TLELoaded)
                this.GoogleEarthControl1.InitialViewF();
            }
          }
          else
            this.TrackModeActive = false;
        }
        else if (this.MAP_MainTab.SelectedIndex == 0)
          this.Track_TrackDisp(checked ((int) Math.Round(a)));
        int num3 = checked (this.StatNum - 1);
        int Stat = 0;
        while (Stat <= num3)
        {
          this.Station_Check(Stat);
          checked { ++Stat; }
        }
        this.Graph_DrawStation();
        this.Graph_DrawLinkStaSat();
        this.Graph_DrawSun();
        if (this.MAP_PtsOnOrbit.Checked)
          this.Graph_DrawPointsOnTrack();
        this.Graph_DrawSat();
        this.TracePicture.Image = (Image) this.Trace;
        goto label_23;
label_18:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_23;
        }
      }
      catch (Exception ex) when (
      {
        // ISSUE: unable to correctly present filter
        int num4;
        if (ex is Exception & num1 != 0 & num4 == 0)
        {
          SuccessfulFiltering;
        }
        else
          throw;
      }
      )
      {
        ProjectData.SetProjectError(ex);
        goto label_18;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_23:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public void Graph_Radar_Actualise()
    {
      this.radarGraph.Clear(this.radarPicture.BackColor);
      this.Graph_DrawRadar();
      this.Graph_DrawSatOnRadar();
      this.radarPicture.Image = (Image) this.radarTrace;
      this.Icon_Stations_Detect();
    }

    public void TLE_Prediction()
    {
      this.DELTAD = Conversions.ToString(this.EPOCH + 0.5 - Math.Truncate(this.EPOCH));
      this.EPOCH0 = 2430000.0 + this.EPOCH - Conversions.ToDouble(this.DELTAD);
      this.SGP4(this.EPOCH, this.TLEPOCH);
      this.Math_ElementSecondaires();
      this.Display_Results();
    }

    public void Graph_DrawSat()
    {
      Font font1 = new Font("Courier New", 10f, FontStyle.Regular);
      Font font2 = new Font("Courier New", 10f, FontStyle.Bold);
      double num1 = (double) this.MapW / 2.0;
      double num2 = (double) this.MapH / 2.0;
      StringFormat format = new StringFormat();
      format.FormatFlags = !(this.MM < 1.1 & this.MM > 0.9) ? StringFormatFlags.FitBlackBox : StringFormatFlags.DirectionVertical;
      Bitmap bitmap;
      if (Conversions.ToBoolean(this.SatVisual1))
      {
        bitmap = TLE_Analyser.My.Resources.Resources.Sat;
        this.SatPicture.Width = 13;
        this.SatPicture.Height = 11;
      }
      else if (Conversions.ToBoolean(this.SatVisual2))
      {
        bitmap = TLE_Analyser.My.Resources.Resources.sat2;
        this.SatPicture.Width = 16;
        this.SatPicture.Height = 16;
      }
      else if (Conversions.ToBoolean(this.SatVisual3))
      {
        bitmap = TLE_Analyser.My.Resources.Resources.Sat3;
        this.SatPicture.Width = 10;
        this.SatPicture.Height = 10;
      }
      double num3 = (double) this.SatPicture.Height / 2.0;
      double num4 = (double) this.SatPicture.Width / 2.0;
      bitmap.MakeTransparent(bitmap.GetPixel(0, 0));
      if (this.Sat_CheckListBox.CheckedItems.Count != 0)
      {
        this.SatLatLng = new string[checked (this.Sat_CheckListBox.CheckedItems.Count - 1 + 1), 3];
        try
        {
          int index1 = 0;
          int num5 = checked (this.Sat_CheckListBox.Items.Count - 1);
          int index2 = 0;
          while (index2 <= num5)
          {
            if (this.Sat_CheckListBox.GetItemChecked(index2) && this.Sat_CheckListBox.SelectedIndex != index2)
            {
              this.TLE_Load_Temp(this.Satellites[index2, 3], this.Satellites[index2, 4]);
              double a1 = Math.Round(num2 - this.LAT_temp * (double) checked (this.MapH - 1) / 180.0, 0);
              double a2 = Math.Round(num1 + this.LNG_temp * (double) checked (this.MapW - 1) / 360.0, 0);
              this.g.DrawImage((Image) bitmap, checked ((int) Math.Round(unchecked (a2 - num4))), checked ((int) Math.Round(unchecked (a1 - num3)) - 2));
              if (this.MAP_SatName.Checked)
              {
                if (this.MM < 1.1 & this.MM > 0.9)
                  this.g.DrawString(this.Satellites[index2, 1], font1, Brushes.Yellow, (float) checked ((int) Math.Round(a2) - 10), (float) checked ((int) Math.Round(a1) + 5), format);
                else if (a2 < (double) checked (this.MapW * 2) / 3.0 & a2 > 0.0)
                  this.g.DrawString(this.Satellites[index2, 1], font1, Brushes.Yellow, (float) checked ((int) Math.Round(a2) + 5), (float) checked ((int) Math.Round(a1)), format);
                else
                  this.g.DrawString(this.Satellites[index2, 1], font1, Brushes.Yellow, (float) checked ((int) Math.Round(a2) - 30), (float) checked ((int) Math.Round(a1)), format);
              }
              if (this.MAP_MainTab.SelectedIndex == 1)
              {
                this.GoogleEarthControl1.delSat(this.Satellites[index2, 1]);
                this.GoogleEarthControl1.addMoreSat(this.Satellites[index2, 1], this.LAT_temp, this.LNG_temp, this.ALT_temp * 1000.0);
              }
              this.SatLatLng[index1, 0] = this.Satellites[index2, 2];
              this.SatLatLng[index1, 1] = Conversions.ToString(this.LAT_temp);
              this.SatLatLng[index1, 2] = Conversions.ToString(this.LNG_temp);
              checked { ++index1; }
            }
            checked { ++index2; }
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num6 = (int) TopMostMessageBox.Show(ex.Message + "\r\n\r\nDocument: 'home.vb'\r\nBloc: 'Graph_DrawSat'", "TLE ANALYSER - Error");
          this.Cursor = Cursors.Default;
          ProjectData.ClearProjectError();
        }
      }
      double a3 = Math.Round(num2 - this.LAT * (double) checked (this.MapH - 1) / 180.0, 0);
      double a4 = Math.Round(num1 + this.LONGI * (double) checked (this.MapW - 1) / 360.0, 0);
      this.g.DrawImage((Image) bitmap, checked ((int) Math.Round(unchecked (a4 - num4))), checked ((int) Math.Round(unchecked (a3 - num3)) - 2));
      if (this.MM < 1.1 & this.MM > 0.9)
        this.g.DrawString(this.SATNAME, font2, Brushes.Red, (float) checked ((int) Math.Round(a4) - 10), (float) checked ((int) Math.Round(a3) + 5), format);
      else if (a4 < (double) checked (this.MapW * 2) / 3.0 & a4 > 0.0)
        this.g.DrawString(this.SATNAME, font2, Brushes.Red, (float) checked ((int) Math.Round(a4) + 5), (float) checked ((int) Math.Round(a3)), format);
      else
        this.g.DrawString(this.SATNAME, font2, Brushes.Red, (float) checked ((int) Math.Round(a4) - 30), (float) checked ((int) Math.Round(a3)), format);
      if (this.MAP_MainTab.SelectedIndex != 1)
        return;
      this.GoogleEarthControl1.addSat();
    }

    public void Graph_DrawSun()
    {
      Bitmap sun = TLE_Analyser.My.Resources.Resources.sun;
      double num = (double) this.MapW / 2.0;
      this.bsol = Math.Round((double) this.MapH / 2.0 - this.LATS * (double) this.MapH / 180.0, 0);
      this.lsol = Math.Round(num + this.LONGIS * (double) this.MapW / 360.0, 0);
      sun.MakeTransparent(sun.GetPixel(0, 0));
      this.g.DrawImage((Image) sun, checked ((int) Math.Round(unchecked (this.lsol - 11.0))), checked ((int) Math.Round(unchecked (this.bsol - 11.0))));
    }

    public void Graph_DrawStation()
    {
      Bitmap groundStation = TLE_Analyser.My.Resources.Resources.GroundStation;
      Font font = new Font("Courier New", 8f, FontStyle.Italic);
      double num1 = (double) this.MapW / 2.0;
      double num2 = (double) this.MapH / 2.0;
      groundStation.MakeTransparent(groundStation.GetPixel(0, 0));
      int index1;
      if (Conversions.ToBoolean(this.GSFullName))
        index1 = 0;
      if (Conversions.ToBoolean(this.GSShortName))
        index1 = 1;
      int num3 = checked (this.StatNum - 1);
      int index2 = 0;
      while (index2 <= num3)
      {
        double num4 = Math.Round(num2 - Conversions.ToDouble(this.Stations[index2, 2]) * (double) this.MapH / 180.0, 0);
        double a = Math.Round(num1 + Conversions.ToDouble(this.Stations[index2, 3]) * (double) this.MapW / 360.0, 0);
        if (this.GS_ListBox.GetItemChecked(index2))
        {
          this.Stations[index2, 5] = Conversions.ToString(true);
          this.g.DrawImage((Image) groundStation, checked ((int) Math.Round(unchecked (a - 11.0))), checked ((int) Math.Round(unchecked (num4 - 11.0))));
          this.g.DrawString(this.Stations[index2, index1], font, Brushes.White, (float) checked ((int) Math.Round(a)), (float) checked ((int) Math.Round(unchecked (num4 - 11.0))));
          if (this.MAP_MainTab.SelectedIndex == 1)
            this.GoogleEarthControl1.addStations(this.Stations[index2, 0], Conversions.ToDouble(this.Stations[index2, 2]), Conversions.ToDouble(this.Stations[index2, 3]), Conversions.ToDouble(this.Stations[index2, 4]));
        }
        else
        {
          this.Stations[index2, 5] = Conversions.ToString(false);
          if (this.MAP_MainTab.SelectedIndex == 1)
            this.GoogleEarthControl1.delStations((object) index2);
        }
        checked { ++index2; }
      }
    }

    public void Graph_DrawLinkStaSat()
    {
      Pen pen = new Pen(Color.Yellow, 1f);
      double num1 = (double) this.MapW / 2.0;
      double num2 = (double) this.MapH / 2.0;
      double a1 = Math.Round(num2 - this.LAT * (double) this.MapH / 180.0, 0);
      double a2 = Math.Round(num1 + this.LONGI * (double) this.MapW / 360.0, 0);
      int num3 = checked (this.StatNum - 1);
      int i = 0;
      while (i <= num3)
      {
        if (Conversions.ToBoolean(this.Stations[i, 6]))
        {
          double a3 = Math.Round(num2 - Conversions.ToDouble(this.Stations[i, 2]) * (double) this.MapH / 180.0, 0);
          double a4 = Math.Round(num1 + Conversions.ToDouble(this.Stations[i, 3]) * (double) this.MapW / 360.0, 0);
          this.g.DrawLine(pen, checked ((int) Math.Round(a4)), checked ((int) Math.Round(a3)), checked ((int) Math.Round(a2)), checked ((int) Math.Round(a1)));
          if (this.MAP_MainTab.SelectedIndex == 1)
            this.GoogleEarthControl1.AddLineToStation(i, this.LAT, this.LONGI, this.ALT, Conversions.ToDouble(this.Stations[i, 2]), Conversions.ToDouble(this.Stations[i, 3]), Conversions.ToDouble(this.Stations[i, 4]));
        }
        else if (this.MAP_MainTab.SelectedIndex == 1)
          this.GoogleEarthControl1.delLineToStation(i);
        checked { ++i; }
      }
    }

    public void Graph_DrawVisibiltyZone()
    {
      double Right = (double) this.MapW / 2.0;
      double num1 = (double) this.MapH / 2.0;
      Pen pen = new Pen(Brushes.Yellow, 1f);
      Point[] pointArray1 = new Point[361];
      SolidBrush solidBrush = new SolidBrush(Color.FromArgb(38, (int) byte.MaxValue, (int) byte.MaxValue, 0));
      this.VisibiltyZone[0].X = (float) Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "zone", new object[1]
      {
        (object) 0
      }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "X", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapW), (object) 360));
      this.VisibiltyZone[0].Y = (float) Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "zone", new object[1]
      {
        (object) 0
      }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Y", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapH), (object) 180));
      int index1 = 1;
      do
      {
        ref PointF local1 = ref this.VisibiltyZone[index1];
        object satActive1 = this.SatActive;
        object[] objArray1 = new object[1]
        {
          (object) index1
        };
        object[] Arguments1 = objArray1;
        bool[] flagArray1 = new bool[1]{ true };
        bool[] CopyBack1 = flagArray1;
        object Instance1 = NewLateBinding.LateGet(satActive1, (Type) null, "zone", Arguments1, (string[]) null, (Type[]) null, CopyBack1);
        if (flagArray1[0])
          index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray1[0]), typeof (int));
        object[] Arguments2 = new object[0];
        double integer1 = (double) Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance1, (Type) null, "X", Arguments2, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapW), (object) 360));
        local1.X = (float) integer1;
        ref PointF local2 = ref this.VisibiltyZone[index1];
        object satActive2 = this.SatActive;
        object[] objArray2 = new object[1]
        {
          (object) index1
        };
        object[] Arguments3 = objArray2;
        bool[] flagArray2 = new bool[1]{ true };
        bool[] CopyBack2 = flagArray2;
        object Instance2 = NewLateBinding.LateGet(satActive2, (Type) null, "zone", Arguments3, (string[]) null, (Type[]) null, CopyBack2);
        if (flagArray2[0])
          index1 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray2[0]), typeof (int));
        object[] Arguments4 = new object[0];
        double integer2 = (double) Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance2, (Type) null, "Y", Arguments4, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapH), (object) 180));
        local2.Y = (float) integer2;
        object x1 = (object) this.VisibiltyZone[checked (index1 - 1)].X;
        object x2 = (object) this.VisibiltyZone[index1].X;
        object y1 = (object) this.VisibiltyZone[checked (index1 - 1)].Y;
        object y2 = (object) this.VisibiltyZone[index1].Y;
        if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet((object) null, typeof (Math), "Abs", new object[1]
        {
          Operators.SubtractObject(x1, x2)
        }, (string[]) null, (Type[]) null, (bool[]) null), (object) Right, false))
        {
          Graphics g = this.g;
          object[] objArray3 = new object[5]
          {
            (object) pen,
            RuntimeHelpers.GetObjectValue(x1),
            RuntimeHelpers.GetObjectValue(y1),
            RuntimeHelpers.GetObjectValue(x2),
            RuntimeHelpers.GetObjectValue(y2)
          };
          object[] Arguments5 = objArray3;
          bool[] flagArray3 = new bool[5]
          {
            true,
            true,
            true,
            true,
            true
          };
          bool[] CopyBack3 = flagArray3;
          NewLateBinding.LateCall((object) g, (Type) null, "DrawLine", Arguments5, (string[]) null, (Type[]) null, CopyBack3, true);
          if (flagArray3[0])
            pen = (Pen) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof (Pen));
          if (flagArray3[1])
            RuntimeHelpers.GetObjectValue(objArray3[1]);
          if (flagArray3[2])
            RuntimeHelpers.GetObjectValue(objArray3[2]);
          if (flagArray3[3])
            RuntimeHelpers.GetObjectValue(objArray3[3]);
          if (flagArray3[4])
            RuntimeHelpers.GetObjectValue(objArray3[4]);
        }
        checked { ++index1; }
      }
      while (index1 <= 360);
      if ((double) this.VisibiltyZone[360].X < (double) this.VisibiltyZone[0].X)
      {
        if (!((double) this.VisibiltyZone[0].X > Right & (double) this.VisibiltyZone[360].X < Right))
          this.g.DrawLine(pen, this.VisibiltyZone[360].X, this.VisibiltyZone[360].Y, this.VisibiltyZone[0].X, this.VisibiltyZone[0].Y);
      }
      else if ((double) this.VisibiltyZone[360].X > (double) this.VisibiltyZone[0].X)
        this.g.DrawLine(pen, this.VisibiltyZone[360].X, this.VisibiltyZone[360].Y, this.VisibiltyZone[0].X, this.VisibiltyZone[0].Y);
      Point[] pointArray2 = new Point[361];
      int num2 = checked (this.MapW - 3);
      int index2 = 0;
      int num3;
      do
      {
        ref Point local3 = ref pointArray2[index2];
        object satActive3 = this.SatActive;
        object[] objArray4 = new object[1]
        {
          (object) index2
        };
        object[] Arguments6 = objArray4;
        bool[] flagArray4 = new bool[1]{ true };
        bool[] CopyBack4 = flagArray4;
        object Instance3 = NewLateBinding.LateGet(satActive3, (Type) null, "zone", Arguments6, (string[]) null, (Type[]) null, CopyBack4);
        if (flagArray4[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray4[0]), typeof (int));
        object[] Arguments7 = new object[0];
        int integer3 = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance3, (Type) null, "X", Arguments7, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapW), (object) 360));
        local3.X = integer3;
        ref Point local4 = ref pointArray2[index2];
        object satActive4 = this.SatActive;
        object[] objArray5 = new object[1]
        {
          (object) index2
        };
        object[] Arguments8 = objArray5;
        bool[] flagArray5 = new bool[1]{ true };
        bool[] CopyBack5 = flagArray5;
        object Instance4 = NewLateBinding.LateGet(satActive4, (Type) null, "zone", Arguments8, (string[]) null, (Type[]) null, CopyBack5);
        if (flagArray5[0])
          index2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray5[0]), typeof (int));
        object[] Arguments9 = new object[0];
        int integer4 = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance4, (Type) null, "Y", Arguments9, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapH), (object) 180));
        local4.Y = integer4;
        if (this.LAT < 0.0)
        {
          if (pointArray2[index2].X <= num2)
          {
            num2 = pointArray2[index2].X;
            num3 = index2;
          }
        }
        else if (pointArray2[index2].X < num2)
        {
          num2 = pointArray2[index2].X;
          num3 = index2;
        }
        checked { ++index2; }
      }
      while (index2 <= 360);
      if ((double) this.VisibiltyZone[0].Y > 3.0 & (double) this.VisibiltyZone[180].Y < (double) checked (this.MapH - 3) & (double) Math.Abs(this.VisibiltyZone[180].X - this.VisibiltyZone[0].X) < Right & (double) Math.Abs(this.VisibiltyZone[270].X - this.VisibiltyZone[90].X) < Right)
        this.g.FillPolygon((Brush) solidBrush, this.VisibiltyZone);
      else if ((double) Math.Abs(this.VisibiltyZone[0].X - this.VisibiltyZone[180].X) > 10.0)
      {
        Point[] points = new Point[366];
        if (this.LAT > 0.0)
        {
          int index3 = 3;
          do
          {
            points[index3].X = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "zone", new object[1]
            {
              (object) (checked (index3 + num3 - 2) % 360)
            }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "X", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapW), (object) 360));
            points[index3].Y = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "zone", new object[1]
            {
              (object) (checked (index3 + num3 - 2) % 360)
            }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Y", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapH), (object) 180));
            checked { ++index3; }
          }
          while (index3 <= 362);
          points[0] = new Point(checked (this.MapW - 1), 0);
          points[1] = new Point(checked (this.MapW - 1), checked (this.MapH + 1));
          points[2] = new Point(checked (this.MapW - 1), checked ((int) Math.Round(unchecked (0.5 * (double) checked (points[3].Y + points[362].Y)))));
          points[363] = new Point(0, checked ((int) Math.Round(unchecked (0.5 * (double) checked (points[3].Y + points[362].Y)))));
          points[364] = new Point(0, checked (this.MapH + 1));
          points[365] = new Point(0, 0);
        }
        else
        {
          int index4 = 2;
          do
          {
            points[index4].X = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "zone", new object[1]
            {
              (object) (checked (index4 + num3 - 2) % 360)
            }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "X", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapW), (object) 360));
            points[index4].Y = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(NewLateBinding.LateGet(this.SatActive, (Type) null, "zone", new object[1]
            {
              (object) (checked (index4 + num3 - 2) % 360)
            }, (string[]) null, (Type[]) null, (bool[]) null), (Type) null, "Y", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapH), (object) 180));
            checked { ++index4; }
          }
          while (index4 <= 361);
          points[0] = new Point(0, 0);
          points[1] = new Point(0, checked ((int) Math.Round(unchecked (0.5 * (double) checked (points[2].Y + points[361].Y)))));
          points[362] = new Point(checked (this.MapW - 1), checked ((int) Math.Round(unchecked (0.5 * (double) checked (points[2].Y + points[361].Y)))));
          points[363] = new Point(checked (this.MapW - 1), 0);
          points[364] = new Point(checked (this.MapW - 1), checked (this.MapH + 1));
          points[365] = new Point(0, checked (this.MapH + 1));
        }
        this.g.FillPolygon((Brush) solidBrush, points);
      }
      else
      {
        Point[] points1 = new Point[361];
        Point[] points2 = new Point[361];
        int index5 = 0;
        int index6 = 0;
        if (this.LONGI > 0.0)
        {
          int num4 = 0;
          do
          {
            object satActive5 = this.SatActive;
            object[] objArray6 = new object[1]
            {
              (object) num4
            };
            object[] Arguments10 = objArray6;
            bool[] flagArray6 = new bool[1]{ true };
            bool[] CopyBack6 = flagArray6;
            object Instance5 = NewLateBinding.LateGet(satActive5, (Type) null, "zone", Arguments10, (string[]) null, (Type[]) null, CopyBack6);
            if (flagArray6[0])
              num4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray6[0]), typeof (int));
            object[] Arguments11 = new object[0];
            if ((double) Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance5, (Type) null, "X", Arguments11, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapW), (object) 360)) > Right)
            {
              ref Point local5 = ref points1[index5];
              object satActive6 = this.SatActive;
              object[] objArray7 = new object[1]
              {
                (object) num4
              };
              object[] Arguments12 = objArray7;
              bool[] flagArray7 = new bool[1]{ true };
              bool[] CopyBack7 = flagArray7;
              object Instance6 = NewLateBinding.LateGet(satActive6, (Type) null, "zone", Arguments12, (string[]) null, (Type[]) null, CopyBack7);
              if (flagArray7[0])
                num4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray7[0]), typeof (int));
              object[] Arguments13 = new object[0];
              int integer5 = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance6, (Type) null, "X", Arguments13, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapW), (object) 360));
              local5.X = integer5;
              ref Point local6 = ref points1[index5];
              object satActive7 = this.SatActive;
              object[] objArray8 = new object[1]
              {
                (object) num4
              };
              object[] Arguments14 = objArray8;
              bool[] flagArray8 = new bool[1]{ true };
              bool[] CopyBack8 = flagArray8;
              object Instance7 = NewLateBinding.LateGet(satActive7, (Type) null, "zone", Arguments14, (string[]) null, (Type[]) null, CopyBack8);
              if (flagArray8[0])
                num4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray8[0]), typeof (int));
              object[] Arguments15 = new object[0];
              int integer6 = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance7, (Type) null, "Y", Arguments15, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapH), (object) 180));
              local6.Y = integer6;
              checked { ++index5; }
            }
            else
            {
              ref Point local7 = ref points2[index6];
              object satActive8 = this.SatActive;
              object[] objArray9 = new object[1]
              {
                (object) num4
              };
              object[] Arguments16 = objArray9;
              bool[] flagArray9 = new bool[1]{ true };
              bool[] CopyBack9 = flagArray9;
              object Instance8 = NewLateBinding.LateGet(satActive8, (Type) null, "zone", Arguments16, (string[]) null, (Type[]) null, CopyBack9);
              if (flagArray9[0])
                num4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray9[0]), typeof (int));
              object[] Arguments17 = new object[0];
              int integer7 = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance8, (Type) null, "X", Arguments17, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapW), (object) 360));
              local7.X = integer7;
              ref Point local8 = ref points2[index6];
              object satActive9 = this.SatActive;
              object[] objArray10 = new object[1]
              {
                (object) num4
              };
              object[] Arguments18 = objArray10;
              bool[] flagArray10 = new bool[1]{ true };
              bool[] CopyBack10 = flagArray10;
              object Instance9 = NewLateBinding.LateGet(satActive9, (Type) null, "zone", Arguments18, (string[]) null, (Type[]) null, CopyBack10);
              if (flagArray10[0])
                num4 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray10[0]), typeof (int));
              object[] Arguments19 = new object[0];
              int integer8 = Conversions.ToInteger(Operators.DivideObject(Operators.MultiplyObject(NewLateBinding.LateGet(Instance9, (Type) null, "Y", Arguments19, (string[]) null, (Type[]) null, (bool[]) null), (object) this.MapH), (object) 180));
              local8.Y = integer8;
              checked { ++index6; }
            }
            checked { ++num4; }
          }
          while (num4 <= 360);
          this.g.FillPolygon((Brush) solidBrush, points1);
          this.g.FillPolygon((Brush) solidBrush, points2);
        }
      }
    }

    public void Graph_DrawRadar()
    {
      Pen pen1 = new Pen(Color.Black, 1f);
      Pen pen2 = new Pen(Color.Black, 2f);
      Bitmap groundStation = TLE_Analyser.My.Resources.Resources.GroundStation;
      groundStation.MakeTransparent(groundStation.GetPixel(0, 0));
      this.radarGraph.DrawLine(pen1, 0, checked ((int) Math.Round(unchecked ((double) this.radarH / 2.0))), this.radarW, checked ((int) Math.Round(unchecked ((double) this.radarH / 2.0))));
      this.radarGraph.DrawLine(pen1, checked ((int) Math.Round(unchecked ((double) this.radarW / 2.0))), 0, checked ((int) Math.Round(unchecked ((double) this.radarW / 2.0))), this.radarH);
      this.radarGraph.DrawEllipse(pen2, 1, 1, checked (this.radarW - 3), checked (this.radarH - 3));
      this.radarGraph.DrawEllipse(pen1, checked ((int) Math.Round(unchecked ((double) this.radarW / 6.0))), checked ((int) Math.Round(unchecked ((double) this.radarH / 6.0))), checked ((int) Math.Round(unchecked ((double) checked (4 * this.radarW) / 6.0))), checked ((int) Math.Round(unchecked ((double) checked (4 * this.radarH) / 6.0))));
      this.radarGraph.DrawEllipse(pen1, checked ((int) Math.Round(unchecked ((double) this.radarW / 3.0))), checked ((int) Math.Round(unchecked ((double) this.radarH / 3.0))), checked ((int) Math.Round(unchecked ((double) this.radarW / 3.0))), checked ((int) Math.Round(unchecked ((double) this.radarH / 3.0))));
      this.radarGraph.DrawImage((Image) groundStation, checked (1 + (int) Math.Round(unchecked ((double) this.radarW / 2.0 - (double) groundStation.Width / 2.0))), checked ((int) Math.Round(unchecked ((double) this.radarH / 2.0 - (double) groundStation.Height / 2.0))));
    }

    public void Graph_DrawSatOnRadar()
    {
      Pen pen1 = new Pen(Color.Red, 2f);
      Pen pen2 = new Pen(Color.Green, 2f);
      Pen pen3 = new Pen(Color.Black, 2f);
      Pen pen4 = new Pen(this.radarPicture.BackColor, 30f);
      Bitmap sat2 = TLE_Analyser.My.Resources.Resources.sat2;
      sat2.MakeTransparent(sat2.GetPixel(0, 0));
      bool flag = false;
      string Right = Conversions.ToString(this.Stations_list.SelectedItem);
      double num1 = (double) this.Stations.Length / 7.0 - 1.0;
      for (double a = 0.0; a <= num1; ++a)
      {
        if (Operators.CompareString(this.Stations[checked ((int) Math.Round(a)), 0], Right, false) == 0)
        {
          flag = true;
          int num2 = checked ((int) Math.Round(a));
        }
      }
      double num3 = (90.0 - this.EL) / 90.0;
      int num4 = checked ((int) Math.Round(unchecked ((double) this.radarW / 2.0 + num3 * Math.Sin(Math.PI / 180.0 * this.AZ) * (double) this.radarW / 2.0)));
      int num5 = checked ((int) Math.Round(unchecked ((double) this.radarH / 2.0 - num3 * Math.Cos(Math.PI / 180.0 * this.AZ) * (double) this.radarH / 2.0)));
      if (this.radarTraceLine.Length > 0)
        this.radarGraph.DrawLines(pen1, this.radarTraceLine);
      this.radarGraph.DrawImage((Image) sat2, checked (num4 - (int) Math.Round(unchecked ((double) sat2.Width / 2.0))), checked (num5 - (int) Math.Round(unchecked ((double) sat2.Height / 2.0))));
      this.radarGraph.DrawEllipse(pen4, -15, -15, checked (this.radarW + 29), checked (this.radarH + 29));
      this.radarGraph.DrawEllipse(pen3, 1, 1, checked (this.radarW - 3), checked (this.radarH - 3));
    }

    private bool Station_Check(int Stat)
    {
      if (!Conversions.ToBoolean(this.Stations[Stat, 5]))
      {
        this.Stations[Stat, 6] = Conversions.ToString(false);
      }
      else
      {
        double[] numArray1 = new double[3];
        double[] v1 = new double[3];
        double[] v2 = new double[3];
        double[] numArray2 = new double[3];
        double[] v3 = new double[3];
        numArray1[0] = (6378.136658 + this.ALT) * (Math.Cos(Math.PI / 180.0 * this.LAT) * Math.Cos(Math.PI / 180.0 * this.LONGI));
        numArray1[1] = (6378.136658 + this.ALT) * (Math.Cos(Math.PI / 180.0 * this.LAT) * Math.Sin(Math.PI / 180.0 * this.LONGI));
        numArray1[2] = (6378.136658 + this.ALT) * Math.Sin(Math.PI / 180.0 * this.LAT);
        numArray2[0] = Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[Stat, 2])) * Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[Stat, 3]));
        numArray2[1] = Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[Stat, 2])) * Math.Sin(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[Stat, 3]));
        numArray2[2] = Math.Sin(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[Stat, 2]));
        v1[0] = 6378.136658 * numArray2[0];
        v1[1] = 6378.136658 * numArray2[1];
        v1[2] = 6378.136658 * numArray2[2];
        double num1 = this.Math_norm(ref v1);
        int index1 = 0;
        do
        {
          v2[index1] = v1[index1] / num1;
          checked { ++index1; }
        }
        while (index1 <= 2);
        int index2 = 0;
        do
        {
          v3[index2] = numArray1[index2] - v1[index2];
          checked { ++index2; }
        }
        while (index2 <= 2);
        double num2 = this.Math_norm(ref v3);
        int index3 = 0;
        do
        {
          v3[index3] = v3[index3] / num2;
          checked { ++index3; }
        }
        while (index3 <= 2);
        double num3 = 180.0 / Math.PI * this.Math_acose(this.Math_dot(v3, v2));
        if (Operators.CompareString(this.LimitAngle, (string) null, false) == 0 | Operators.CompareString(this.LimitAngle, "", false) == 0 | Operators.CompareString(this.LimitAngle, " ", false) == 0)
          this.LimitAngle = "0";
        this.Stations[Stat, 6] = num3 >= (double) checked ((int) Math.Round(unchecked (90.0 - Conversions.ToDouble(this.LimitAngle)))) ? Conversions.ToString(false) : Conversions.ToString(true);
      }
      bool flag;
      return flag;
    }

    public void Graph_DrawSunShadow()
    {
      double num1 = (double) this.MapW / 360.0;
      double num2 = (double) this.MapH * 2.0 / 360.0;
      int mapH = this.MapH;
      int mapW = this.MapW;
      if (!this.MAP_NightShadow.Checked)
        return;
      Corps corps = new Corps();
      Pen pen = new Pen(Color.Brown);
      SolidBrush solidBrush = new SolidBrush(Color.FromArgb(115, 0, 0, 0));
      corps.CalculZoneVisibiliteSoleil();
      Point[] pointArray = new Point[361];
      int num3 = checked (this.MapW - 3);
      int index1 = 0;
      int num4;
      do
      {
        pointArray[index1].X = checked ((int) Math.Round(unchecked ((double) this.SunZone[index1].X * num1)));
        pointArray[index1].Y = checked ((int) Math.Round(unchecked ((double) this.SunZone[index1].Y * num2)));
        if (this.LATS < 0.0)
        {
          if (pointArray[index1].X <= num3)
          {
            num3 = pointArray[index1].X;
            num4 = index1;
          }
        }
        else if (pointArray[index1].X < num3)
        {
          num3 = pointArray[index1].X;
          num4 = index1;
        }
        checked { ++index1; }
      }
      while (index1 <= 360);
      if (Math.Abs(this.LATS) > 4.27431133813411E-05)
      {
        Point[] points = new Point[366];
        if (this.LATS < 0.0)
        {
          int index2 = 3;
          do
          {
            points[index2].X = checked ((int) Math.Round(unchecked ((double) this.SunZone[checked (index2 + num4 - 2) % 360].X * num1)));
            points[index2].Y = checked ((int) Math.Round(unchecked ((double) this.SunZone[checked (index2 + num4 - 2) % 360].Y * num2)));
            checked { ++index2; }
          }
          while (index2 <= 362);
          points[0] = new Point(checked (this.MapW - 1), 0);
          points[1] = new Point(checked (this.MapW - 1), checked (mapH + 1));
          points[2] = new Point(checked (this.MapW - 1), checked ((int) Math.Round(unchecked (0.5 * (double) checked (points[3].Y + points[362].Y)))));
          points[363] = new Point(0, checked ((int) Math.Round(unchecked (0.5 * (double) checked (points[3].Y + points[362].Y)))));
          points[364] = new Point(0, checked (mapH + 1));
          points[365] = new Point(0, 0);
        }
        else
        {
          int index3 = 2;
          do
          {
            points[index3].X = checked ((int) Math.Round(unchecked ((double) this.SunZone[checked (index3 + num4 - 2) % 360].X * num1)));
            points[index3].Y = checked ((int) Math.Round(unchecked ((double) this.SunZone[checked (index3 + num4 - 2) % 360].Y * num2)));
            checked { ++index3; }
          }
          while (index3 <= 361);
          points[0] = new Point(0, 0);
          points[1] = new Point(0, checked ((int) Math.Round(unchecked (0.5 * (double) checked (points[2].Y + points[361].Y)))));
          points[362] = new Point(checked (this.MapW - 1), checked ((int) Math.Round(unchecked (0.5 * (double) checked (points[2].Y + points[361].Y)))));
          points[363] = new Point(checked (this.MapW - 1), 0);
          points[364] = new Point(checked (this.MapW - 1), checked (mapH + 1));
          points[365] = new Point(0, checked (mapH + 1));
        }
        this.g.FillPolygon((Brush) solidBrush, points);
      }
      else
      {
        Point[] points1 = new Point[4];
        Point[] points2 = new Point[4];
        if (this.lsol > (double) (mapW / 4) && this.lsol < (double) (checked (4 * mapW) / 3))
        {
          points1[0] = new Point(0, 0);
          points1[1].X = checked ((int) Math.Round(unchecked ((double) Math.Min(this.SunZone[90].X, this.SunZone[270].X) * num1)));
          points1[1].Y = 0;
          points1[2].X = checked ((int) Math.Round(unchecked ((double) Math.Min(this.SunZone[90].X, this.SunZone[270].X) * num1)));
          points1[2].Y = checked (mapH + 1);
          points1[3] = new Point(0, checked (mapH + 1));
          points2[0] = new Point(checked (this.MapW - 1), 0);
          points2[1].X = checked ((int) Math.Round(unchecked ((double) Math.Max(this.SunZone[90].X, this.SunZone[270].X) * num1)));
          points2[1].Y = 0;
          points2[2].X = checked ((int) Math.Round(unchecked ((double) Math.Max(this.SunZone[90].X, this.SunZone[270].X) * num1)));
          points2[2].Y = checked (mapH + 1);
          points2[3] = new Point(checked (mapW + 1), checked (mapH + 1));
          this.g.FillPolygon((Brush) solidBrush, points1);
          this.g.FillPolygon((Brush) solidBrush, points2);
        }
        else
        {
          points1[0] = new Point(checked ((int) Math.Round(unchecked ((double) Math.Min(this.SunZone[90].X, this.SunZone[270].X) * num1))), 0);
          points1[1] = new Point(checked ((int) Math.Round(unchecked ((double) Math.Min(this.SunZone[90].X, this.SunZone[270].X) * num1))), checked (mapH + 1));
          points1[2] = new Point(checked ((int) Math.Round(unchecked ((double) Math.Max(this.SunZone[90].X, this.SunZone[270].X) * num1))), checked (mapH + 1));
          points1[3] = new Point(checked ((int) Math.Round(unchecked ((double) Math.Max(this.SunZone[90].X, this.SunZone[270].X) * num1))), 0);
          this.g.FillPolygon((Brush) solidBrush, points1);
        }
      }
    }

    public void Graph_DrawGrid()
    {
      Pen pen = new Pen(Color.Black);
      pen.DashStyle = DashStyle.Dash;
      SolidBrush solidBrush = new SolidBrush(Color.White);
      Font font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
      int num1 = checked ((int) Math.Round(unchecked ((double) this.MapW / 2.0)));
      int num2 = checked ((int) Math.Round(unchecked ((double) this.MapH / 2.0)));
      if (this.MAP_FullGrid.Checked)
      {
        int num3 = 15;
        do
        {
          string s;
          if (num3 <= 90)
            s = Conversions.ToString(checked (-num3 - 90)) + " N";
          if (num3 > 90)
            s = Conversions.ToString(checked (-90 - num3)) + " S";
          int num4 = checked ((int) Math.Round(Math.Round(unchecked ((double) checked (num3 * this.MapH - 4) / 180.0), 0)));
          this.g.DrawLine(pen, 0, num4, this.MapW, num4);
          this.g.FillRectangle((Brush) solidBrush, 3, checked (num4 + 1), 25, 12);
          this.g.DrawString(s, font, Brushes.Black, 2f, (float) num4);
          checked { num3 += 15; }
        }
        while (num3 <= 165);
        int num5 = 30;
        do
        {
          string s;
          if (num5 <= 180)
            s = Conversions.ToString(checked (-num5 - 180)) + " W";
          if (num5 > 180)
            s = Conversions.ToString(checked (-180 - num5)) + " E";
          int num6 = checked ((int) Math.Round(Math.Round(unchecked ((double) checked (num5 * this.MapW - 1) / 360.0), 0)));
          this.g.DrawLine(pen, num6, 0, num6, this.MapH);
          this.g.FillRectangle((Brush) solidBrush, checked (num6 + 1), checked (this.MapH - 20), 35, 14);
          this.g.DrawString(s, font, Brushes.Black, (float) num6, (float) checked (this.MapH - 20));
          checked { num5 += 30; }
        }
        while (num5 <= 330);
      }
      else
      {
        this.g.DrawLine(pen, 0, checked (num2 - 2), this.MapW, checked (num2 - 2));
        this.g.DrawLine(pen, checked (num1 - 1), 0, checked (num1 - 1), this.MapH);
      }
    }

    public void Graph_DrawPointsOnTrack()
    {
      double num1 = (double) this.MapW / 2.0;
      double num2 = (double) this.MapH / 2.0;
      double num3 = (this.MA + this.AOP) % 360.0;
      double num4 = 180.0 / Math.PI * this.TA;
      SolidBrush solidBrush = new SolidBrush(Color.White);
      Pen pen = new Pen(Color.White);
      double num5 = (this.MA - 180.0 / Math.PI * (2.0 * Math.Atan(Math.Sqrt((1.0 - this.ECC) / (1.0 + this.ECC)) * Math.Tan(Math.PI / 180.0 * -this.AOP / 2.0)) - this.ECC * Math.Sqrt(1.0 - Math.Pow(this.ECC, 2.0)) * Math.Sin(Math.PI / 180.0 * -this.AOP) / (1.0 + this.ECC * Math.Cos(Math.PI / 180.0 * -this.AOP)))) % 360.0;
      if (num5 < 0.0)
        num5 = 360.0 + num5;
      this.ETFXP = Math.PI / 180.0 * (num5 % 360.0) / Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) / 86400.0;
      this.XPEPOCH = this.EPOCH - this.ETFXP;
      Functions.ETFXP_F(this.XPEPOCH);
      this.XAN = this.XXP;
      this.YAN = this.YXP;
      this.ZAN = this.ZXP;
      this.ANEPOCH = this.XPEPOCH;
      if (!(this.MM < 0.98 | this.MM > 1.02 | this.INC > 30.0))
        return;
      Font font1 = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular);
      double a1 = Math.Round(num1 + this.LAN * (double) this.MapW / 360.0, 0);
      this.g.FillEllipse((Brush) solidBrush, checked ((int) Math.Round(a1) - 3), checked ((int) Math.Round(unchecked ((double) checked (this.MapH - 2) / 2.0 - 4.0))), 6, 6);
      this.g.DrawEllipse(pen, checked ((int) Math.Round(a1) - 3), checked ((int) Math.Round(unchecked ((double) checked (this.MapH - 2) / 2.0 - 4.0))), 6, 6);
      if (a1 > (double) checked (this.MapW - 25))
        this.g.DrawString("AN", font1, Brushes.White, (float) checked ((int) Math.Round(a1) - 25), (float) ((double) this.MapH / 2.0 - 2.0));
      else
        this.g.DrawString("AN", font1, Brushes.White, (float) checked ((int) Math.Round(a1) + 5), (float) ((double) this.MapH / 2.0 - 2.0));
      double a2 = Math.Round(num1 + this.LDN * (double) this.MapW / 360.0, 0);
      this.g.DrawEllipse(pen, checked ((int) Math.Round(a2) - 3), checked ((int) Math.Round(unchecked ((double) checked (this.MapH - 2) / 2.0 - 4.0))), 6, 6);
      if (a2 > (double) checked (this.MapW - 25))
        this.g.DrawString("DN", font1, Brushes.White, (float) checked ((int) Math.Round(a2) - 25), (float) ((double) this.MapH / 2.0 - 2.0));
      else
        this.g.DrawString("DN", font1, Brushes.White, (float) checked ((int) Math.Round(a2) + 5), (float) ((double) this.MapH / 2.0 - 2.0));
      Font font2 = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular);
      Font font3 = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular);
      double a3 = Math.Acos((this.ECC + Math.Cos(Math.PI / 180.0 * this.AOP)) / (1.0 + this.ECC * Math.Cos(Math.PI / 180.0 * this.AOP)));
      if (this.AOP > 180.0)
        a3 = 2.0 * Math.PI - a3;
      double num6 = a3 - this.ECC * Math.Sin(a3);
      this.ETFXP = num6 / Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) / 86400.0;
      this.PEREPOCH = this.ANEPOCH + this.ETFXP;
      Functions.ETFXP_F(this.PEREPOCH);
      double latxp1 = this.LATXP;
      double longixp1 = this.LONGIXP;
      double a4 = Math.Round(num2 - latxp1 * (double) this.MapH / 180.0, 0);
      double a5 = Math.Round(num1 + longixp1 * (double) this.MapW / 360.0, 0);
      this.g.DrawString("+", font3, Brushes.Red, (float) checked ((int) Math.Round(a5) - 10), (float) checked ((int) Math.Round(a4) - 16));
      if (a5 > (double) checked (this.MapW - 35))
        this.g.DrawString("PER", font2, Brushes.Red, (float) checked ((int) Math.Round(a5) - 35), (float) checked ((int) Math.Round(a4) - 8));
      else
        this.g.DrawString("PER", font2, Brushes.Red, (float) checked ((int) Math.Round(a5) + 6), (float) checked ((int) Math.Round(a4) - 8));
      this.ETFXP = (num6 + Math.PI) % (2.0 * Math.PI) / Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) / 86400.0;
      this.APOEPOCH = this.ANEPOCH + this.ETFXP;
      Functions.ETFXP_F(this.APOEPOCH);
      double latxp2 = this.LATXP;
      double longixp2 = this.LONGIXP;
      double a6 = Math.Round(num2 - latxp2 * (double) this.MapH / 180.0, 0);
      double a7 = Math.Round(num1 + longixp2 * (double) this.MapW / 360.0, 0);
      this.g.DrawString("+", font3, Brushes.Red, (float) checked ((int) Math.Round(a7) - 10), (float) checked ((int) Math.Round(a6) - 16));
      if (a7 > (double) checked (this.MapW - 35))
        this.g.DrawString("APO", font2, Brushes.Red, (float) checked ((int) Math.Round(a7) - 35), (float) checked ((int) Math.Round(a6) - 8));
      else
        this.g.DrawString("APO", font2, Brushes.Red, (float) checked ((int) Math.Round(a7) + 6), (float) checked ((int) Math.Round(a6) - 8));
    }

    public void Graph_DrawInfo()
    {
      Pen pen = new Pen(Color.Yellow, 1f);
      Font font = new Font("Courier New", 10f, FontStyle.Bold);
      int width = this.MapPanel.Width;
      double num1 = (double) width / 2.0;
      int height = this.MapPanel.Height;
      double num2 = (double) height / 2.0;
      Point client = this.PointToClient(Control.MousePosition);
      double num3 = 20.0;
      double a1 = (double) checked (client.X - this.MAP_MainTab.Location.X - this.MapPanel.Location.X - this.TracePicture.Location.X - 5);
      double a2 = (double) checked (client.Y - this.MAP_MainTab.Location.Y - this.MapPanel.Location.Y - this.TracePicture.Location.Y) - num3;
      if (this.MAP_SatName.Checked)
        return;
      int num4 = checked ((int) Math.Round(unchecked ((double) this.SatLatLng.Length / 3.0 - 1.0)));
      int index1 = 0;
      while (index1 <= num4)
      {
        float num5 = (float) Math.Round(num2 - Conversions.ToDouble(this.SatLatLng[index1, 1]) * (double) checked (height - 1) / 180.0, 0);
        float num6 = (float) Math.Round(num1 + Conversions.ToDouble(this.SatLatLng[index1, 2]) * (double) checked (width - 1) / 360.0, 0);
        if (a1 > (double) num6 - 5.0 & a1 < (double) num6 + 5.0 & a2 > (double) num5 - 5.0 & a2 < (double) num5 + 5.0)
        {
          int num7 = checked (this.Sat_CheckListBox.Items.Count - 1);
          int index2 = 0;
          while (index2 <= num7)
          {
            if (Operators.CompareString(this.Satellites[index2, 2], this.SatLatLng[index1, 0], false) == 0)
            {
              if (a1 < (double) checked (width * 2) / 3.0 & a1 > 0.0)
                this.g.DrawString(this.Satellites[index1, 1], font, Brushes.Yellow, (float) checked ((int) Math.Round(a1) + 5), (float) checked ((int) Math.Round(a2)));
              else
                this.g.DrawString(this.Satellites[index1, 1], font, Brushes.Yellow, (float) checked ((int) Math.Round(a1) - 30), (float) checked ((int) Math.Round(a2)));
            }
            checked { ++index2; }
          }
        }
        checked { ++index1; }
      }
    }

    public void Icon_Stations_Detect()
    {
      string str = Conversions.ToString(this.Stations_list.SelectedItem);
      if (Operators.CompareString(str, "", false) == 0 | Operators.CompareString(str, (string) null, false) == 0)
      {
        this.Stations_On.Visible = false;
        this.Stations_Off.Visible = true;
      }
      else
      {
        double num = (double) this.Stations.Length / 7.0 - 1.0;
        int index;
        for (double a = 0.0; a <= num; ++a)
        {
          if (Operators.CompareString(this.Stations[checked ((int) Math.Round(a)), 0], str, false) == 0)
            index = checked ((int) Math.Round(a));
        }
        if (Conversions.ToBoolean(this.Stations[index, 6]))
        {
          this.Stations_On.Visible = true;
          this.Stations_Off.Visible = false;
        }
        else
        {
          this.Stations_On.Visible = false;
          this.Stations_Off.Visible = true;
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public void Stations_Load()
    {
      string[] strArray = new string[1];
      this.GS_ListBox.Items.Clear();
      this.StatNum = 0;
      try
      {
        FileSystem.FileOpen(1, this.StationsFile, OpenMode.Input);
        while (!FileSystem.EOF(1))
        {
          object obj = (object) FileSystem.LineInput(1);
          checked { ++this.StatNum; }
        }
        this.Stations = new string[checked (this.StatNum - 1 + 1), 7];
        string[] array = new string[checked (this.StatNum - 1 + 1)];
        FileSystem.FileClose(1);
        FileSystem.FileOpen(1, this.StationsFile, OpenMode.Input);
        while (!FileSystem.EOF(1))
        {
          object obj = (object) FileSystem.LineInput(1);
          int index;
          array[index] = Conversions.ToString(obj);
          checked { ++index; }
        }
        FileSystem.FileClose(1);
        Array.Sort<string>(array);
        int num = checked (this.StatNum - 1);
        int index1 = 0;
        while (index1 <= num)
        {
          object Instance = (object) Strings.Split(array[index1], ";");
          this.Stations[index1, 0] = Conversions.ToString(NewLateBinding.LateIndexGet(Instance, new object[1]
          {
            (object) 0
          }, (string[]) null));
          this.Stations[index1, 1] = Conversions.ToString(NewLateBinding.LateIndexGet(Instance, new object[1]
          {
            (object) 1
          }, (string[]) null));
          this.Stations[index1, 2] = Conversions.ToString(NewLateBinding.LateIndexGet(Instance, new object[1]
          {
            (object) 2
          }, (string[]) null));
          this.Stations[index1, 3] = Conversions.ToString(NewLateBinding.LateIndexGet(Instance, new object[1]
          {
            (object) 3
          }, (string[]) null));
          this.Stations[index1, 4] = Conversions.ToString(NewLateBinding.LateIndexGet(Instance, new object[1]
          {
            (object) 4
          }, (string[]) null));
          this.Stations[index1, 5] = Conversions.ToString(false);
          this.Stations[index1, 6] = Conversions.ToString(false);
          this.GS_ListBox.Items.Add((object) (this.Stations[index1, 0] + " - " + this.Stations[index1, 1]));
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) TopMostMessageBox.Show(this.StationsFile + " seems to be corrupted :\r\n" + ex.Message + "\r\n\r\nDocument: 'vb'\r\nBloc: 'Graph_DrawSat'", "TLE ANALYSER - Error");
        this.Cursor = Cursors.Default;
        ProjectData.ClearProjectError();
      }
    }

    public void Stations_ExportToMap(int i)
    {
      this.Stations[i, 5] = !this.GS_ListBox.GetItemChecked(i) ? Conversions.ToString(false) : Conversions.ToString(true);
      this.Graph_Actualise(false);
    }

    public void Stations_ExportToMapAll()
    {
      this.Stations_list.Items.Clear();
      int num = checked (this.GS_ListBox.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        if (this.GS_ListBox.GetItemChecked(index))
        {
          this.Stations_list.Items.Add((object) this.Stations[index, 0]);
          this.Stations_list.Sorted = true;
          this.Stations[index, 5] = Conversions.ToString(true);
        }
        else
          this.Stations[index, 5] = Conversions.ToString(false);
        checked { ++index; }
      }
      this.Graph_Actualise(false);
    }

    private void GS_4all_CheckedChanged(object sender, EventArgs e)
    {
      int num = checked (this.GS_ListBox.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        this.GS_ListBox.SetItemChecked(index, this.GS_CheckAll_CB.Checked);
        checked { ++index; }
      }
      this.Stations_ExportToMapAll();
    }

    private void GS_ListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!this.TLELoaded)
      {
        int num1 = (int) Interaction.MsgBox((object) "A TLE must be loaded.", MsgBoxStyle.Information, (object) "Ground Stations");
      }
      else
      {
        int selectedIndex = this.GS_ListBox.SelectedIndex;
        MyProject.Forms.GroundStations.GS_Range_Ranging.Checked = false;
        this.Stations_ExportToMap(selectedIndex);
        this.Stations_list.Enabled = true;
        this.Stations_list.Items.Clear();
        this.Stations_lng.Text = "";
        this.Stations_lat.Text = "";
        this.Stations_alt.Text = "";
        this.Stations_az.Text = "";
        this.Stations_el.Text = "";
        this.Stations_dist.Text = "";
        bool flag = false;
        int num2 = checked (this.StatNum - 1);
        int index = 0;
        while (index <= num2)
        {
          if (this.GS_ListBox.GetItemChecked(index))
          {
            this.Stations_list.Items.Add((object) this.Stations[index, 0]);
            string station = this.Stations[index, 0];
            flag = true;
          }
          checked { ++index; }
        }
        this.Stations_list.Sorted = true;
        this.Stations_start.Text = "";
        this.Stations_end.Text = "";
        this.Stations_remTime.Text = "";
        this.Stations_duration.Text = "";
      }
    }

    private void Stations_list_SelectedIndexChanged(object sender, EventArgs e)
    {
      Dates dates = Functions.MJD2JJ(this.EPOCH);
      string Right = Conversions.ToString(this.Stations_list.SelectedItem);
      double num = (double) this.Stations.Length / 7.0 - 1.0;
      int index;
      for (double a = 0.0; a <= num; ++a)
      {
        if (Operators.CompareString(this.Stations[checked ((int) Math.Round(a)), 0], Right, false) == 0)
          index = checked ((int) Math.Round(a));
      }
      this.Stations_lng.Text = Conversions.ToString(Math.Round(Conversions.ToDouble(this.Stations[index, 3]), 2));
      this.Stations_lat.Text = Conversions.ToString(Math.Round(Conversions.ToDouble(this.Stations[index, 2]), 2));
      this.Stations_alt.Text = Conversions.ToString(Math.Round(Conversions.ToDouble(this.Stations[index, 4]), 2));
      this.Stations_start.Text = "";
      this.Stations_end.Text = "";
      this.Stations_duration.Text = "";
      this.Stations_remTime.Text = "";
      this.GS_Antenna_Limit.SelectedItem = (object) this.LimitAngle;
      this.Graph_Actualise(false);
      Dates epochDat = dates;
      Satellite satActive = (Satellite) this.SatActive;
      ref Satellite local = ref satActive;
      this.Math_AzElDist(epochDat, ref local);
      this.SatActive = (object) satActive;
      this.AZ = Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(this.SatActive, (Type) null, "Azimut", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.EL = Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(this.SatActive, (Type) null, "Hauteur", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
      this.DIST = Conversions.ToDouble(NewLateBinding.LateGet(this.SatActive, (Type) null, "Distance", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
      int deg;
      int min;
      int sec;
      Maths.Deg2DMS(this.AZ, ref deg, ref min, ref sec);
      this.AZ_dms = Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
      Maths.Deg2DMS(this.EL, ref deg, ref min, ref sec);
      this.EL_dms = Conversions.ToString(deg) + "° " + Conversions.ToString(min) + "' " + Conversions.ToString(sec) + "''";
      this.Display_Results();
      this.Graph_Radar_Actualise();
    }

    private void GS_Antenna_Limit_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.LimitAngle = Conversions.ToString(this.GS_Antenna_Limit.SelectedItem);
      this.Graph_Actualise(false);
      this.Graph_Radar_Actualise();
    }

    public void TimeVisibility()
    {
      bool flag1 = false;
      MyProject.Forms.GroundStations.GS_Antenna_Limit.SelectedItem = (object) this.LimitAngle;
      string Right1 = Conversions.ToString(this.Stations_list.SelectedItem);
      bool flag2 = false;
      double num1 = (double) this.Stations.Length / 7.0 - 1.0;
      int index1;
      for (double a = 0.0; a <= num1; ++a)
      {
        if (Operators.CompareString(this.Stations[checked ((int) Math.Round(a)), 0], Right1, false) == 0)
        {
          flag2 = true;
          index1 = checked ((int) Math.Round(a));
        }
      }
      if (!flag2)
      {
        this.Stations_lng.Text = "";
        this.Stations_lat.Text = "";
        this.Stations_alt.Text = "";
      }
      else
      {
        this.Stations_lng.Text = this.Stations[index1, 3];
        this.Stations_lat.Text = this.Stations[index1, 2];
        this.Stations_alt.Text = this.Stations[index1, 4];
        object[] objArray1 = new object[6];
        object[,] objArray2 = new object[checked (this.StatNum - 1 + 1), 4];
        double anepoch = this.ANEPOCH;
        object Right2;
        double num2;
        string Left1;
        if (this.MM > 0.99 & this.MM < 1.01)
        {
          Right2 = (object) 0.5;
          num2 = anepoch + this.DPER / 1440.0;
          Left1 = "geo";
        }
        else
        {
          num2 = anepoch + this.DPER / 1440.0;
          Right2 = (object) 1.15740740740741E-05;
          Left1 = "std";
        }
        int index2 = 0;
        this.radarTraceLine = new PointF[100001];
        Array.Clear((Array) this.radarTraceLine, 0, this.radarTraceLine.Length);
        this.GS_ProgressBar.Visible = true;
        this.GS_ProgressBar.Value = 0;
        double num3 = num2 - anepoch;
        double Left2 = 0.0;
        double num4 = anepoch;
        double num5 = num2;
        double StepValue = Conversions.ToDouble(Right2);
        double limit = num5;
        for (double num6 = num4; ObjectFlowControl.ForLoopControl.ForNextCheckR8(num6, limit, StepValue); num6 += StepValue)
        {
          this.SGP4_Trace(num6, this.TLEPOCH);
          Functions.GSTCalc((object) Conversion.Val((object) num6));
          double num7 = Conversions.ToDouble(Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(this.SatTrack, (Type) null, "latitude", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
          double num8 = Conversions.ToDouble(Operators.MultiplyObject((object) (-180.0 / Math.PI), NewLateBinding.LateGet(this.SatTrack, (Type) null, "longitude", new object[0], (string[]) null, (Type[]) null, (bool[]) null)));
          double num9 = Conversions.ToDouble(NewLateBinding.LateGet(this.SatTrack, (Type) null, "altitude", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
          double[] numArray1 = new double[3];
          double[] v1 = new double[3];
          double[] v2 = new double[3];
          double[] numArray2 = new double[3];
          double[] v3 = new double[3];
          if (Conversions.ToBoolean(this.Stations[index1, 5]))
          {
            numArray1[0] = (6378.136658 + num9) * (Math.Cos(Math.PI / 180.0 * num7) * Math.Cos(Math.PI / 180.0 * num8));
            numArray1[1] = (6378.136658 + num9) * (Math.Cos(Math.PI / 180.0 * num7) * Math.Sin(Math.PI / 180.0 * num8));
            numArray1[2] = (6378.136658 + num9) * Math.Sin(Math.PI / 180.0 * num7);
            numArray2[0] = Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[index1, 2])) * Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[index1, 3]));
            numArray2[1] = Math.Cos(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[index1, 2])) * Math.Sin(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[index1, 3]));
            numArray2[2] = Math.Sin(Math.PI / 180.0 * Conversions.ToDouble(this.Stations[index1, 2]));
            v1[0] = 6378.136658 * numArray2[0];
            v1[1] = 6378.136658 * numArray2[1];
            v1[2] = 6378.136658 * numArray2[2];
            double num10 = this.Math_norm(ref v1);
            int index3 = 0;
            do
            {
              v2[index3] = v1[index3] / num10;
              checked { ++index3; }
            }
            while (index3 <= 2);
            int index4 = 0;
            do
            {
              v3[index4] = numArray1[index4] - v1[index4];
              checked { ++index4; }
            }
            while (index4 <= 2);
            double num11 = this.Math_norm(ref v3);
            int index5 = 0;
            do
            {
              v3[index5] = v3[index5] / num11;
              checked { ++index5; }
            }
            while (index5 <= 2);
            double num12 = 180.0 / Math.PI * this.Math_acose(this.Math_dot(v3, v2));
            if (Operators.CompareString(this.LimitAngle, (string) null, false) == 0 | Operators.CompareString(this.LimitAngle, "", false) == 0 | Operators.CompareString(this.LimitAngle, " ", false) == 0)
              this.LimitAngle = "0";
            if (num12 < (double) checked ((int) Math.Round(unchecked (90.0 - Conversions.ToDouble(this.LimitAngle)))))
            {
              if (Operators.ConditionalCompareObjectEqual(objArray2[index1, 0], (object) null, false))
              {
                objArray2[index1, 0] = (object) true;
                objArray2[index1, 1] = (object) num6;
                objArray2[index1, 3] = this.VZN <= 0.01 ? (this.VZN >= 0.01 ? (object) "N/A" : (object) "DESC") : (object) "ASC";
                flag1 = true;
              }
              double num13 = Conversions.ToDouble(Operators.DivideObject(Operators.SubtractObject((object) 90, Operators.MultiplyObject((object) (180.0 / Math.PI), NewLateBinding.LateGet(this.SatTrack, (Type) null, "Hauteur", new object[0], (string[]) null, (Type[]) null, (bool[]) null))), (object) 90));
              double num14 = (double) this.radarW / 2.0 + num13 * Math.Sin(Conversions.ToDouble(NewLateBinding.LateGet(this.SatTrack, (Type) null, "Azimut", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) * (double) this.radarW / 2.0;
              double num15 = (double) this.radarH / 2.0 - num13 * Math.Cos(Conversions.ToDouble(NewLateBinding.LateGet(this.SatTrack, (Type) null, "Azimut", new object[0], (string[]) null, (Type[]) null, (bool[]) null))) * (double) this.radarH / 2.0;
              this.radarTraceLine[index2].X = (float) num14;
              this.radarTraceLine[index2].Y = (float) num15;
              checked { ++index2; }
            }
            else if (Conversions.ToBoolean(objArray2[index1, 0]))
            {
              objArray2[index1, 0] = (object) null;
              objArray2[index1, 2] = (object) num6;
              objArray1[0] = (object) this.Stations[index1, 0];
              objArray1[2] = (object) Functions.MJDGGEHour(Conversions.ToDouble(objArray2[index1, 1]));
              objArray1[3] = (object) Functions.MJDGGEHour(Conversions.ToDouble(objArray2[index1, 2]));
              object obj1 = Operators.MultiplyObject(Operators.SubtractObject(objArray2[index1, 2], objArray2[index1, 1]), (object) 24);
              Type Type1 = typeof (Math);
              object[] objArray3 = new object[1]
              {
                RuntimeHelpers.GetObjectValue(obj1)
              };
              object[] Arguments1 = objArray3;
              bool[] flagArray1 = new bool[1]{ true };
              bool[] CopyBack1 = flagArray1;
              object obj2 = NewLateBinding.LateGet((object) null, Type1, "Truncate", Arguments1, (string[]) null, (Type[]) null, CopyBack1);
              if (flagArray1[0])
                obj1 = RuntimeHelpers.GetObjectValue(objArray3[0]);
              double Expression1 = Conversions.ToDouble(obj2);
              Type Type2 = typeof (Math);
              object[] objArray4 = new object[1];
              object[] objArray5 = objArray4;
              object Left3 = obj1;
              Type Type3 = typeof (Math);
              object[] objArray6 = new object[1]
              {
                RuntimeHelpers.GetObjectValue(obj1)
              };
              object[] Arguments2 = objArray6;
              bool[] flagArray2 = new bool[1]{ true };
              bool[] CopyBack2 = flagArray2;
              object Right3 = NewLateBinding.LateGet((object) null, Type3, "Truncate", Arguments2, (string[]) null, (Type[]) null, CopyBack2);
              if (flagArray2[0])
                obj1 = RuntimeHelpers.GetObjectValue(objArray6[0]);
              object obj3 = Operators.MultiplyObject(Operators.SubtractObject(Left3, Right3), (object) 60);
              objArray5[0] = obj3;
              object[] Arguments3 = objArray4;
              double Expression2 = Conversions.ToDouble(NewLateBinding.LateGet((object) null, Type2, "Truncate", Arguments3, (string[]) null, (Type[]) null, (bool[]) null));
              Type Type4 = typeof (Math);
              object[] objArray7 = new object[1];
              object[] objArray8 = objArray7;
              object Left4 = obj1;
              Type Type5 = typeof (Math);
              object[] objArray9 = new object[1]
              {
                RuntimeHelpers.GetObjectValue(obj1)
              };
              object[] Arguments4 = objArray9;
              bool[] flagArray3 = new bool[1]{ true };
              bool[] CopyBack3 = flagArray3;
              object Right4 = NewLateBinding.LateGet((object) null, Type5, "Truncate", Arguments4, (string[]) null, (Type[]) null, CopyBack3);
              if (flagArray3[0])
                obj1 = RuntimeHelpers.GetObjectValue(objArray9[0]);
              object Left5 = Operators.MultiplyObject(Operators.SubtractObject(Left4, Right4), (object) 60);
              Type Type6 = typeof (Math);
              object[] objArray10 = new object[1];
              object[] objArray11 = objArray10;
              object Left6 = obj1;
              Type Type7 = typeof (Math);
              object[] objArray12 = new object[1]
              {
                RuntimeHelpers.GetObjectValue(obj1)
              };
              object[] Arguments5 = objArray12;
              bool[] flagArray4 = new bool[1]{ true };
              bool[] CopyBack4 = flagArray4;
              object Right5 = NewLateBinding.LateGet((object) null, Type7, "Truncate", Arguments5, (string[]) null, (Type[]) null, CopyBack4);
              if (flagArray4[0])
                RuntimeHelpers.GetObjectValue(objArray12[0]);
              object obj4 = Operators.MultiplyObject(Operators.SubtractObject(Left6, Right5), (object) 60);
              objArray11[0] = obj4;
              object[] Arguments6 = objArray10;
              object Right6 = NewLateBinding.LateGet((object) null, Type6, "Truncate", Arguments6, (string[]) null, (Type[]) null, (bool[]) null);
              object obj5 = Operators.MultiplyObject(Operators.SubtractObject(Left5, Right6), (object) 60);
              objArray8[0] = obj5;
              object[] Arguments7 = objArray7;
              double Expression3 = Conversions.ToDouble(NewLateBinding.LateGet((object) null, Type4, "Truncate", Arguments7, (string[]) null, (Type[]) null, (bool[]) null));
              objArray1[1] = (object) (Strings.Format((object) Expression1, "00") + ":" + Strings.Format((object) Expression2, "00") + ":" + Strings.Format((object) Expression3, "00"));
              objArray1[5] = RuntimeHelpers.GetObjectValue(objArray2[index1, 3]);
              double num16;
              if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater((object) this.EPOCH, objArray2[index1, 1], false), Operators.CompareObjectLess((object) this.EPOCH, objArray2[index1, 2], false))))
                num16 = Conversions.ToDouble(Operators.SubtractObject(objArray2[index1, 2], (object) this.EPOCH));
              objArray1[4] = num16 == Conversions.ToDouble("0.0") ? (object) "N/A" : RuntimeHelpers.GetObjectValue(Functions.HtoHMS(Conversions.ToString(num16 * 24.0)));
              this.Stations_start.Text = Conversions.ToString(Operators.ConcatenateObject((object) (Functions.MJDGGEDate(Conversions.ToDouble(objArray2[index1, 1])) + " "), objArray1[2]));
              this.Stations_end.Text = Conversions.ToString(Operators.ConcatenateObject((object) (Functions.MJDGGEDate(num6) + " "), objArray1[3]));
              this.Stations_duration.Text = Conversions.ToString(objArray1[1]);
              this.Stations_remTime.Text = Conversions.ToString(objArray1[4]);
              objArray2[index1, 0] = (object) null;
              break;
            }
          }
          Left2 = Conversions.ToDouble(Operators.AddObject((object) Left2, Right2));
          this.GS_ProgressBar.Value = checked ((int) Math.Round(unchecked (Left2 * 100.0 / num3)));
        }
        this.radarTraceLine = (PointF[]) Utils.CopyArray((Array) this.radarTraceLine, (Array) new PointF[checked (index2 - 1 + 1)]);
        if (!flag1)
        {
          this.Stations_start.Text = "N/A";
          this.Stations_end.Text = "N/A";
          this.Stations_duration.Text = "N/A";
          this.Stations_remTime.Text = "N/A";
        }
        if (Operators.CompareString(Left1, "geo", false) == 0)
          this.Stations_duration.Text = "inf.";
        this.GS_ProgressBar.Value = 0;
        this.GS_ProgressBar.Visible = false;
      }
    }

    private void GS_Actualise_Click(object sender, EventArgs e) => this.TimeVisibility();

    public void Track_TrackCalc(int period)
    {
      int Left1 = checked ((int) Math.Round(unchecked ((double) this.MapW / 2.0)));
      int Left2 = checked ((int) Math.Round(unchecked ((double) this.MapH / 2.0)));
      Pen pen = new Pen(Color.Brown);
      this.SatTrace = new object[checked (360 * period + 1), 7];
      double num1 = 1.0 / (this.MM * 360.0);
      string str1 = Functions.MJDGGEDate(this.ANEPOCH);
      string str2 = Functions.MJDGGEHour(this.ANEPOCH);
      if (!this.MAP_ShowTrack.Checked)
        return;
      this.Cursor = Cursors.WaitCursor;
      double num2 = (this.MA - 180.0 / Math.PI * (2.0 * Math.Atan(Math.Sqrt((1.0 - this.ECC) / (1.0 + this.ECC)) * Math.Tan(Math.PI / 180.0 * -this.AOP / 2.0)) - this.ECC * Math.Sqrt(1.0 - Math.Pow(this.ECC, 2.0)) * Math.Sin(Math.PI / 180.0 * -this.AOP) / (1.0 + this.ECC * Math.Cos(Math.PI / 180.0 * -this.AOP)))) % 360.0;
      if (num2 < 0.0)
        num2 = 360.0 + num2;
      this.ETFXP = Math.PI / 180.0 * (num2 % 360.0) / Math.Sqrt(398600.4418 / Math.Pow(this.SMA, 3.0)) / 86400.0;
      this.XPEPOCH = this.EPOCH - this.ETFXP;
      Functions.ETFXP_F(this.XPEPOCH);
      this.XAN = this.XXP;
      this.YAN = this.YXP;
      this.ZAN = this.ZXP;
      this.LATAN = this.LATXP;
      this.LONGIAN = this.LONGIXP;
      this.ANEPOCH = this.XPEPOCH;
      double anepoch = this.ANEPOCH;
      int num3 = checked ((int) Math.Round(unchecked ((double) Left2 - this.LATAN * (double) this.MapH / 180.0)) - 2);
      int num4 = checked ((int) Math.Round(unchecked ((double) Left1 + this.LONGIAN * (double) this.MapW / 360.0)));
      double num5 = Functions.Norme((object) this.XAN, (object) this.YAN, (object) this.ZAN) - 6378.136658 / Math.Sqrt(Math.Pow(Math.Cos(Math.PI / 180.0 * this.LATAN), 2.0) + Math.Pow(Math.Sin(Math.PI / 180.0 * this.LATAN), 2.0) / 0.993305682221733);
      this.SatTrace = new object[checked (360 * period + 1), 7];
      this.SatTrace[0, 0] = (object) (double) num4;
      this.SatTrace[0, 1] = (object) (double) num3;
      this.SatTrace[0, 2] = (object) Math.Round(this.LATAN, 2);
      this.SatTrace[0, 3] = (object) Math.Round(this.LONGIAN, 2);
      this.SatTrace[0, 4] = (object) Math.Round(num5 * 1000.0, 2);
      this.SatTrace[0, 5] = (object) str1;
      this.SatTrace[0, 6] = (object) str2;
      try
      {
        int index1 = 1;
        do
        {
          int num6 = num3;
          int num7 = num4;
          double num8 = this.ANEPOCH + (double) index1 * num1;
          this.SGP4_Trace(num8, this.TLEPOCH);
          double num9 = Functions.GSTCalc((object) num8);
          double num10 = Math.Sqrt(this.XN * this.XN + this.YN * this.YN);
          double num11 = Math.Atan(this.ZN / num10);
          double num12;
          for (double a = 7.0; Math.Abs(num11 - a) > 1E-07; num11 = Math.Atan((this.ZN + 6378.136658 * (1.0 / Math.Sqrt(1.0 - 0.00669431777826672 * num12 * num12)) * 0.00669431777826672 * num12) / num10))
          {
            a = num11;
            num12 = Math.Sin(a);
          }
          double num13 = 180.0 / Math.PI * num11;
          double num14 = 180.0 / Math.PI * ((Math.Atan2(this.YN, this.XN) - Math.PI / 180.0 * num9) % (2.0 * Math.PI));
          if (num14 > 180.0)
            num14 -= 360.0;
          if (num14 < -180.0)
            num14 += 360.0;
          string str3 = Functions.MJDGGEDate(num8);
          string str4 = Functions.MJDGGEHour(num8);
          double num15 = (Functions.Norme((object) this.XN, (object) this.YN, (object) this.ZN) - 6378.136658) * 1000.0;
          this.SatTrace[index1, 0] = (object) (double) num7;
          this.SatTrace[index1, 1] = (object) (double) num6;
          this.SatTrace[index1, 2] = (object) Math.Round(num13, 2);
          this.SatTrace[index1, 3] = (object) Math.Round(num14, 2);
          this.SatTrace[index1, 4] = (object) Math.Round(num15, 2);
          this.SatTrace[index1, 5] = (object) str3;
          this.SatTrace[index1, 6] = (object) str4;
          num3 = checked ((int) Math.Round(unchecked ((double) Left2 - num13 * (double) this.MapH / 180.0)) - 2);
          num4 = checked ((int) Math.Round(unchecked ((double) Left1 + num14 * (double) this.MapW / 360.0)));
          checked { ++index1; }
        }
        while (index1 <= 360);
        if (period > 1)
        {
          int num16 = checked (360 * period);
          int index2 = 361;
          while (index2 <= num16)
          {
            this.SatTrace[index2, 2] = RuntimeHelpers.GetObjectValue(this.SatTrace[checked (index2 - 360), 2]);
            double num17 = Conversions.ToDouble(Operators.SubtractObject(this.SatTrace[checked (index2 - 360), 3], (object) this.DL));
            if (num17 > 180.0)
              num17 -= 360.0;
            if (num17 < -180.0)
              num17 += 360.0;
            this.SatTrace[index2, 3] = (object) num17;
            this.SatTrace[index2, 0] = (object) Conversions.ToInteger(Operators.AddObject((object) Left1, Operators.DivideObject(Operators.MultiplyObject(this.SatTrace[index2, 3], (object) this.MapW), (object) 360)));
            this.SatTrace[index2, 1] = (object) Conversions.ToInteger(Operators.SubtractObject((object) Left2, Operators.DivideObject(Operators.MultiplyObject(this.SatTrace[index2, 2], (object) this.MapH), (object) 180)));
            this.SatTrace[index2, 4] = RuntimeHelpers.GetObjectValue(this.SatTrace[checked (index2 - 360), 4]);
            checked { ++index2; }
          }
        }
        this.Cursor = Cursors.Default;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num18 = (int) TopMostMessageBox.Show(ex.Message + "\r\n\r\nDocument: 'home.vb'\r\nBloc: 'Track_TrackCalc'", "TLE ANALYSER - Error");
        this.ProgressBar.Visible = false;
        this.Cursor = Cursors.Default;
        ProjectData.ClearProjectError();
      }
    }

    public void Track_TrackDisp(int period)
    {
      if (!this.MAP_ShowTrack.Checked)
        return;
      this.Cursor = Cursors.WaitCursor;
      double num1 = (double) this.MapW / 2.0;
      double num2 = (double) this.MapH / 2.0;
      Pen pen = new Pen(Color.Red);
      float single1 = Conversions.ToSingle(this.SatTrace[0, 0]);
      float single2 = Conversions.ToSingle(this.SatTrace[0, 1]);
      int num3 = checked (360 * period);
      int index = 1;
      while (index <= num3)
      {
        float y1 = single2;
        float x1 = single1;
        single1 = Conversions.ToSingle(this.SatTrace[index, 0]);
        single2 = Conversions.ToSingle(this.SatTrace[index, 1]);
        if (index > 360)
          pen.Color = Color.IndianRed;
        if (this.INC < 90.0)
        {
          if ((double) x1 > num1 + num1 / 2.0 && (double) single1 < num1 - num1 / 2.0)
          {
            this.g.DrawLine(pen, x1, y1, (float) this.MapW, (float) (((double) single2 + (double) y1) / 2.0));
            x1 = 1f;
            y1 = (float) (((double) single2 + (double) y1) / 2.0);
          }
        }
        else if (this.INC > 90.0 && (double) x1 < num1 - num1 / 2.0 && (double) single1 > num1 + num1 / 2.0)
        {
          this.g.DrawLine(pen, x1, y1, 0.0f, (float) (((double) single2 + (double) y1) / 2.0));
          x1 = (float) this.MapW;
          y1 = (float) (((double) single2 + (double) y1) / 2.0);
        }
        if ((double) Math.Abs(x1 - single1) < num1)
          this.g.DrawLine(pen, x1, y1, single1, single2);
        checked { ++index; }
      }
      if (this.CheckNW & this.MAP_MainTab.SelectedIndex == 1)
      {
        this.GoogleEarthControl1.InitOrb();
        this.GoogleEarthControl1.CreateTrace();
        this.GEart2Actualise = false;
      }
      else
        this.GEart2Actualise = true;
      this.Cursor = Cursors.Default;
    }

    public void Math_AzElDist(Dates epochDat, ref Satellite sat)
    {
      string str = Conversions.ToString(this.Stations_list.SelectedItem);
      if (!(Operators.CompareString(str, "", false) != 0 | Operators.CompareString(str, (string) null, false) != 0))
        return;
      double num = (double) this.Stations.Length / 7.0 - 1.0;
      int index;
      for (double a = 0.0; a <= num; ++a)
      {
        if (Operators.CompareString(this.Stations[checked ((int) Math.Round(a)), 0], str, false) == 0)
          index = checked ((int) Math.Round(a));
      }
      Observateur observateur = new Observateur(this.Stations[index, 0], -Conversions.ToDouble(this.Stations[index, 3]), Conversions.ToDouble(this.Stations[index, 2]), Conversions.ToDouble(this.Stations[index, 4]));
      observateur.CalculPosVit(epochDat);
      sat.CalculCoordHoriz(observateur);
    }

    public double Math_acose(double x) => x < 1.0 ? (x > -1.0 ? Math.Acos(x) : Math.PI) : 0.0;

    public double Math_dot(double[] v1, double[] v2)
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

    public double Math_norm(ref double[] v) => Math.Sqrt(this.Math_dot(v, v));

    private void Math_smult(double a, double[] v, double[] av)
    {
      int index = 0;
      do
      {
        av[index] = a * v[index];
        checked { ++index; }
      }
      while (index <= 2);
    }

    private void Math_vadd(double[] v1, double[] v2, double[] s)
    {
      int index = 0;
      do
      {
        s[index] = v1[index] + v2[index];
        checked { ++index; }
      }
      while (index <= 2);
    }

    private void Math_cross(double[] v1, double[] v2, double[] b)
    {
      b[0] = v1[1] * v2[2] - v1[2] * v2[1];
      b[1] = v1[2] * v2[0] - v1[0] * v2[2];
      b[2] = v1[0] * v2[1] - v1[1] * v2[0];
    }

    private void Math_unitv(double[] v, double[] u)
    {
      double num = this.Math_norm(ref v);
      int index = 0;
      do
      {
        u[index] = v[index] / num;
        checked { ++index; }
      }
      while (index <= 2);
    }

    private void ButtonMenu_Personal_Click(object sender, EventArgs e)
    {
      this.OpenFileDialog1.Title = "Open a personal TLE file";
      this.OpenFileDialog1.FileName = "personal.txt";
      this.OpenFileDialog1.InitialDirectory = this.TLEPath;
      this.OpenFileDialog1.Filter = "Fichiers txt|*.txt";
      this.OpenFileDialog1.Multiselect = false;
      string fileName;
      if (this.OpenFileDialog1.ShowDialog() == DialogResult.OK)
      {
        fileName = Path.GetFileName(this.OpenFileDialog1.FileName);
        this.OpenFileDialog1.Dispose();
      }
      if (Operators.CompareString(fileName, (string) null, false) == 0 | Operators.CompareString(fileName, "", false) == 0)
        return;
      this.TLE_ListBox.Items.Add((object) fileName);
      this.TLE_ListBox.Sorted = true;
      this.TLE_ListBox.SelectedItem = (object) fileName;
    }

    private void Home_Resize(object sender, EventArgs e)
    {
      if (!this.AppLoaded)
        return;
      Functions.InitGraphics();
      if (this.TLELoaded)
        this.Graph_Actualise(true);
    }

    private void OrbitWizardTab_Selected(object sender, TabControlCancelEventArgs e)
    {
      if (this.TLE_MainPage.SelectedIndex != 3)
        return;
      this.CREATEPOCH = !(this.EPOCH == 0.0 | this.EPOCH == 0.0) ? this.TLEPOCH : Functions.GregtoMJD(Conversions.ToString(DateAndTime.Today));
      this.CREATE_EPOCH_Format.SelectedIndex = 1;
    }

    private void CREATE_EPOCH_Format_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.CREATE_EPOCH_Format.SelectedIndex == 1)
        this.CREATE_EPOCH_Current.Text = Functions.MJDtoGreg(Conversions.ToString(this.CREATEPOCH));
      else if (this.CREATE_EPOCH_Format.SelectedIndex == 0)
      {
        this.CREATE_EPOCH_Current.Text = Conversions.ToString(this.CREATEPOCH);
      }
      else
      {
        if (this.CREATE_EPOCH_Format.SelectedIndex != 2)
          return;
        this.CREATE_EPOCH_Current.Text = Conversions.ToString(Functions.GregtoTLE(Functions.MJDtoGreg(Conversions.ToString(this.CREATEPOCH))));
      }
    }

    private void CREATE_EPOCH_Current_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.CREATE_EPOCH_Format.SelectedIndex == 0 | this.CREATE_EPOCH_Format.SelectedIndex == 2)
      {
        if (Versioned.IsNumeric((object) e.KeyChar) | Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
          e.Handled = false;
        else if (e.KeyChar == '\b')
          e.KeyChar = '\b';
        else
          e.Handled = true;
      }
      else if (this.CREATE_EPOCH_Format.SelectedIndex == 1)
      {
        if (Versioned.IsNumeric((object) e.KeyChar))
          e.Handled = false;
        else if (e.KeyChar == '\b')
          e.KeyChar = '\b';
        else
          e.Handled = !(Operators.CompareString(Conversions.ToString(e.KeyChar), " ", false) == 0 | Operators.CompareString(Conversions.ToString(e.KeyChar), "/", false) == 0 | Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0 | Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0 | Operators.CompareString(Conversions.ToString(e.KeyChar), ":", false) == 0);
      }
      if (e.KeyChar != '\r')
        return;
      if (this.Valid_Epoch("create", this.CREATE_EPOCH_Format.SelectedIndex))
      {
        e.Handled = true;
        this.Refresh_TLE();
      }
      else
        this.TLETextBox.Text = "";
    }

    private void CREATE_Epoch_TextChanged_2(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (!this.Valid_Epoch("create", this.CREATE_EPOCH_Format.SelectedIndex))
      {
        Control createEpochCurrent = (Control) this.CREATE_EPOCH_Current;
        this.BorderColor_SatNumber(ref createEpochCurrent, Color.Red);
        this.CREATE_EPOCH_Current = (TextBox) createEpochCurrent;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createEpochCurrent = (Control) this.CREATE_EPOCH_Current;
        this.BorderColor_SatNumber(ref createEpochCurrent, Color.WhiteSmoke);
        this.CREATE_EPOCH_Current = (TextBox) createEpochCurrent;
        this.Refresh_TLE();
      }
    }

    private void CREATE_Default_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.CREATE_Panel_Kepler.Visible = true;
      this.CREATE_Panel_Cartesian.Visible = false;
      this.CREATE_LNG.Text = "";
      this.selectDefault = -1.0;
      this.Create_Defil_SMA.Maximum = 106247;
      this.Create_Defil_ECC.Maximum = 9000;
      this.Create_Defil_INC.Maximum = 180;
      this.Create_Defil_RAAN.Maximum = 360;
      this.Create_Defil_AOP.Maximum = 360;
      this.Create_Defil_TA.Maximum = 360;
      this.Create_Defil_SMA.Minimum = 6379;
      this.Create_Defil_ECC.Minimum = 0;
      this.Create_Defil_INC.Minimum = 0;
      this.Create_Defil_RAAN.Minimum = 0;
      this.Create_Defil_AOP.Minimum = 0;
      this.Create_Defil_TA.Minimum = 0;
      switch (this.CREATE_Default.SelectedIndex)
      {
        case 0:
          this.CREATE_SMA.Enabled = true;
          this.CREATE_ECC.Enabled = true;
          this.CREATE_INC.Enabled = true;
          this.CREATE_RAAN.Enabled = true;
          this.CREATE_AOP.Enabled = true;
          this.CREATE_TA.Enabled = true;
          this.Create_Defil_SMA.Enabled = true;
          this.Create_Defil_ECC.Enabled = true;
          this.Create_Defil_INC.Enabled = true;
          this.Create_Defil_RAAN.Enabled = true;
          this.Create_Defil_AOP.Enabled = true;
          this.Create_Defil_TA.Enabled = true;
          this.SMACr = 7079.291;
          this.ECCCr = 0.00138;
          this.INCCr = 98.203;
          this.RAANCr = 183.543;
          this.AOPCr = 62.883;
          this.TACr = 77.206;
          break;
        case 1:
          this.CREATE_SMA.Enabled = false;
          this.CREATE_ECC.Enabled = false;
          this.CREATE_INC.Enabled = true;
          this.CREATE_RAAN.Enabled = true;
          this.CREATE_AOP.Enabled = true;
          this.CREATE_TA.Enabled = true;
          this.Create_Defil_SMA.Enabled = false;
          this.Create_Defil_ECC.Enabled = false;
          this.Create_Defil_INC.Enabled = true;
          this.Create_Defil_RAAN.Enabled = true;
          this.Create_Defil_AOP.Enabled = true;
          this.Create_Defil_TA.Enabled = true;
          this.SMACr = 42165.785;
          this.ECCCr = 0.0002;
          this.INCCr = 0.0;
          this.RAANCr = 247.844;
          this.AOPCr = 272.536;
          this.TACr = 20.685;
          break;
        case 2:
          this.Create_Defil_SMA.Maximum = 12343;
          this.Create_Defil_INC.Minimum = 95;
          this.CREATE_SMA.Enabled = true;
          this.CREATE_ECC.Enabled = true;
          this.CREATE_INC.Enabled = true;
          this.CREATE_RAAN.Enabled = true;
          this.CREATE_AOP.Enabled = true;
          this.CREATE_TA.Enabled = true;
          this.Create_Defil_SMA.Enabled = true;
          this.Create_Defil_ECC.Enabled = true;
          this.Create_Defil_INC.Enabled = true;
          this.Create_Defil_RAAN.Enabled = true;
          this.Create_Defil_AOP.Enabled = true;
          this.Create_Defil_TA.Enabled = true;
          this.SMACr = 7079.291;
          this.ECCCr = 0.00138;
          this.INCCr = 98.203;
          this.RAANCr = 183.543;
          this.AOPCr = 62.883;
          this.TACr = 77.206;
          break;
        case 3:
          this.CREATE_SMA.Enabled = true;
          this.CREATE_ECC.Enabled = false;
          this.CREATE_INC.Enabled = true;
          this.CREATE_RAAN.Enabled = true;
          this.CREATE_AOP.Enabled = true;
          this.CREATE_TA.Enabled = true;
          this.Create_Defil_SMA.Enabled = true;
          this.Create_Defil_ECC.Enabled = false;
          this.Create_Defil_INC.Enabled = true;
          this.Create_Defil_RAAN.Enabled = true;
          this.Create_Defil_AOP.Enabled = true;
          this.Create_Defil_TA.Enabled = true;
          this.SMACr = 6784.93;
          this.ECCCr = 0.0;
          this.INCCr = 45.0;
          this.RAANCr = 180.0;
          this.AOPCr = 90.0;
          this.TACr = 0.005;
          break;
        case 4:
          this.SMACr = 26586.767;
          this.ECCCr = 0.73;
          this.INCCr = 62.967;
          this.RAANCr = 64.263;
          this.AOPCr = 258.301;
          this.TACr = 281.715;
          break;
        case 5:
          this.SMACr = 26561.679;
          this.ECCCr = 0.0154;
          this.INCCr = 53.041;
          this.RAANCr = 200.466;
          this.AOPCr = 244.689;
          this.TACr = 146.895;
          break;
        case 6:
          this.CREATE_Panel_Kepler.Visible = false;
          this.CREATE_Panel_Cartesian.Visible = true;
          this.CREATE_X.ReadOnly = true;
          this.CREATE_Y.ReadOnly = true;
          this.CREATE_Z.ReadOnly = true;
          this.CREATE_VX.ReadOnly = true;
          this.CREATE_VY.ReadOnly = true;
          this.CREATE_VZ.ReadOnly = true;
          break;
      }
      this.Create_Defil_SMA.Value = checked ((int) Math.Round(this.SMACr));
      this.Create_Defil_ECC.Value = checked ((int) Math.Round(unchecked (this.ECCCr / 0.0001)));
      this.Create_Defil_INC.Value = checked ((int) Math.Round(this.INCCr));
      this.Create_Defil_RAAN.Value = checked ((int) Math.Round(this.RAANCr));
      this.Create_Defil_AOP.Value = checked ((int) Math.Round(this.AOPCr));
      this.Create_Defil_TA.Value = checked ((int) Math.Round(this.TACr));
      this.BSTAR = 0.0001;
      Functions.KepleriantoCartesianCreate(this.SMACr, this.ECCCr, this.INCCr, this.RAANCr, this.AOPCr, this.TACr);
      this.FillBoxes();
      this.Refresh_TLE();
      this.selectDefault = 0.0;
    }

    private void CREATE_Refresh_Click(object sender, EventArgs e) => this.Refresh_TLE();

    private void CREATE_SatNumb_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.CreateFirstOpen)
        return;
      if (Versioned.IsNumeric((object) e.KeyChar))
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_Collection_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (this.CreateFirstOpen)
        return;
      if (Strings.InStr("ù%£¤^è'é&#{([-|\\çà@)]=}$*µ§/!:;.,?<>+°", Conversions.ToString(e.KeyChar)) == 0)
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_SatNumb_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen)
        return;
      if (Operators.CompareString(this.CREATE_SatNumb.Text, "", false) == 0)
      {
        Control createSatNumb = (Control) this.CREATE_SatNumb;
        this.BorderColor_SatNumber(ref createSatNumb, Color.Red);
        this.CREATE_SatNumb = (TextBox) createSatNumb;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createSatNumb = (Control) this.CREATE_SatNumb;
        this.BorderColor_SatNumber(ref createSatNumb, Color.WhiteSmoke);
        this.CREATE_SatNumb = (TextBox) createSatNumb;
        this.ScNumb = this.CREATE_SatNumb.Text;
        this.Refresh_TLE();
      }
    }

    private void CREATE_ScName_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen)
        return;
      if (Operators.CompareString(this.CREATE_ScName.Text, "", false) == 0)
      {
        Control createScName = (Control) this.CREATE_ScName;
        this.BorderColor_SatNumber(ref createScName, Color.Red);
        this.CREATE_ScName = (TextBox) createScName;
        this.SATNAME = "NewSat";
      }
      else
      {
        Control createScName = (Control) this.CREATE_ScName;
        this.BorderColor_SatNumber(ref createScName, Color.WhiteSmoke);
        this.CREATE_ScName = (TextBox) createScName;
        this.SATNAME = this.CREATE_ScName.Text;
        this.Refresh_TLE();
      }
    }

    private void CREATE_Collection_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen)
        return;
      if (Operators.CompareString(this.CREATE_Collection.Text, "", false) == 0)
      {
        Control createCollection = (Control) this.CREATE_Collection;
        this.BorderColor_SatNumber(ref createCollection, Color.Red);
        this.CREATE_Collection = (TextBox) createCollection;
        this.Collection = "NewCollection";
      }
      else
      {
        Control createCollection = (Control) this.CREATE_Collection;
        this.BorderColor_SatNumber(ref createCollection, Color.WhiteSmoke);
        this.CREATE_Collection = (TextBox) createCollection;
        this.Collection = this.CREATE_Collection.Text;
      }
    }

    private void CREATE_SMA_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar))
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_SMA.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_SMA.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_ECC_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar))
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_ECC.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_ECC.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_INC_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar))
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_INC.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_INC.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_RAAN_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar))
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_RAAN.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_RAAN.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_AOP_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar))
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_AOP.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_AOP.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_TA_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar))
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_TA.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_TA.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_SMA_TextChanged(object sender, EventArgs e)
    {
      this.actuTrack = true;
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_SMA.Text, "", false) == 0)
        this.CREATE_SMA.Text = "0.0";
      if (Operators.CompareString(this.CREATE_SMA.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_SMA.Text, "-", false) == 0 | Conversions.ToDouble(this.CREATE_SMA.Text) < 6379.0 | Conversions.ToDouble(this.CREATE_SMA.Text) > 106247.0)
      {
        Control createSma = (Control) this.CREATE_SMA;
        this.BorderColor_Keplerian(ref createSma, Color.Red);
        this.CREATE_SMA = (TextBox) createSma;
        this.TLETextBox.Text = "";
      }
      else if (this.CREATE_Default.SelectedIndex == 2)
      {
        if (Conversions.ToDouble(this.CREATE_SMA.Text) < 6379.0 | Conversions.ToDouble(this.CREATE_SMA.Text) > 12343.0)
        {
          Control createSma = (Control) this.CREATE_SMA;
          this.BorderColor_Keplerian(ref createSma, Color.Red);
          this.CREATE_SMA = (TextBox) createSma;
          this.TLETextBox.Text = "";
        }
        else
        {
          Control createSma = (Control) this.CREATE_SMA;
          this.BorderColor_Keplerian(ref createSma, Color.WhiteSmoke);
          this.CREATE_SMA = (TextBox) createSma;
          this.SMACr = Conversions.ToDouble(this.CREATE_SMA.Text);
          this.Refresh_TLE();
        }
      }
      else
      {
        Control createSma = (Control) this.CREATE_SMA;
        this.BorderColor_Keplerian(ref createSma, Color.WhiteSmoke);
        this.CREATE_SMA = (TextBox) createSma;
        this.SMACr = Conversions.ToDouble(this.CREATE_SMA.Text);
        this.Create_Defil_SMA.Value = Conversions.ToInteger(this.CREATE_SMA.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_ECC_TextChanged(object sender, EventArgs e)
    {
      this.actuTrack = true;
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_ECC.Text, "", false) == 0)
        this.CREATE_ECC.Text = "0.0";
      if (Operators.CompareString(this.CREATE_ECC.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_ECC.Text, "-", false) == 0 | Conversions.ToDouble(this.CREATE_ECC.Text) < 0.0 | Conversions.ToDouble(this.CREATE_ECC.Text) > 0.99)
      {
        Control createEcc = (Control) this.CREATE_ECC;
        this.BorderColor_Keplerian(ref createEcc, Color.Red);
        this.CREATE_ECC = (TextBox) createEcc;
        this.TLETextBox.Text = "";
      }
      else if (this.CREATE_Default.SelectedIndex == 2 & (Conversions.ToDouble(this.CREATE_ECC.Text) < 0.0 | Conversions.ToDouble(this.CREATE_ECC.Text) > 0.6))
      {
        Control createEcc = (Control) this.CREATE_ECC;
        this.BorderColor_Keplerian(ref createEcc, Color.Red);
        this.CREATE_ECC = (TextBox) createEcc;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createEcc = (Control) this.CREATE_ECC;
        this.BorderColor_Keplerian(ref createEcc, Color.WhiteSmoke);
        this.CREATE_ECC = (TextBox) createEcc;
        this.ECCCr = Conversions.ToDouble(this.CREATE_ECC.Text);
        this.Create_Defil_ECC.Value = checked ((int) Math.Round(unchecked (Conversions.ToDouble(this.CREATE_ECC.Text) / 0.0001)));
        this.Refresh_TLE();
      }
    }

    private void CREATE_INC_TextChanged(object sender, EventArgs e)
    {
      this.actuTrack = true;
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_INC.Text, "", false) == 0)
        this.CREATE_INC.Text = "0.0";
      if (Operators.CompareString(this.CREATE_INC.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_INC.Text, "-", false) == 0 | Conversions.ToDouble(this.CREATE_INC.Text) < 0.0 | Conversions.ToDouble(this.CREATE_INC.Text) > 180.0)
      {
        Control createInc = (Control) this.CREATE_INC;
        this.BorderColor_Keplerian(ref createInc, Color.Red);
        this.CREATE_INC = (TextBox) createInc;
        this.TLETextBox.Text = "";
      }
      else if (this.CREATE_Default.SelectedIndex == 2 & (Conversions.ToDouble(this.CREATE_INC.Text) < 95.7 | Conversions.ToDouble(this.CREATE_INC.Text) > 180.0))
      {
        Control createInc = (Control) this.CREATE_INC;
        this.BorderColor_Keplerian(ref createInc, Color.Red);
        this.CREATE_INC = (TextBox) createInc;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createInc = (Control) this.CREATE_INC;
        this.BorderColor_Keplerian(ref createInc, Color.WhiteSmoke);
        this.CREATE_INC = (TextBox) createInc;
        this.INCCr = Conversions.ToDouble(this.CREATE_INC.Text);
        this.Create_Defil_INC.Value = Conversions.ToInteger(this.CREATE_INC.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_RAAN_TextChanged(object sender, EventArgs e)
    {
      this.actuTrack = true;
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_RAAN.Text, "", false) == 0)
        this.CREATE_RAAN.Text = "0.0";
      if (Operators.CompareString(this.CREATE_RAAN.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_RAAN.Text, "-", false) == 0 | Conversions.ToDouble(this.CREATE_RAAN.Text) < 0.0 | Conversions.ToDouble(this.CREATE_RAAN.Text) > 360.0)
      {
        Control createRaan = (Control) this.CREATE_RAAN;
        this.BorderColor_Keplerian(ref createRaan, Color.Red);
        this.CREATE_RAAN = (TextBox) createRaan;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createRaan = (Control) this.CREATE_RAAN;
        this.BorderColor_Keplerian(ref createRaan, Color.WhiteSmoke);
        this.CREATE_RAAN = (TextBox) createRaan;
        this.RAANCr = Conversions.ToDouble(this.CREATE_RAAN.Text);
        this.Create_Defil_RAAN.Value = Conversions.ToInteger(this.CREATE_RAAN.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_AOP_TextChanged(object sender, EventArgs e)
    {
      this.actuTrack = true;
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_AOP.Text, "", false) == 0)
        this.CREATE_AOP.Text = "0.0";
      if (Operators.CompareString(this.CREATE_AOP.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_AOP.Text, "-", false) == 0 | Conversions.ToDouble(this.CREATE_AOP.Text) < 0.0 | Conversions.ToDouble(this.CREATE_AOP.Text) > 360.0)
      {
        Control createAop = (Control) this.CREATE_AOP;
        this.BorderColor_Keplerian(ref createAop, Color.Red);
        this.CREATE_AOP = (TextBox) createAop;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createAop = (Control) this.CREATE_AOP;
        this.BorderColor_Keplerian(ref createAop, Color.WhiteSmoke);
        this.CREATE_AOP = (TextBox) createAop;
        this.AOPCr = Conversions.ToDouble(this.CREATE_AOP.Text);
        this.Create_Defil_AOP.Value = Conversions.ToInteger(this.CREATE_AOP.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_TA_TextChanged(object sender, EventArgs e)
    {
      this.actuTrack = true;
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_TA.Text, "", false) == 0)
        this.CREATE_TA.Text = "0.0";
      if (Operators.CompareString(this.CREATE_TA.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_TA.Text, "-", false) == 0 | Conversions.ToDouble(this.CREATE_TA.Text) < 0.0 | Conversions.ToDouble(this.CREATE_TA.Text) > 360.0)
      {
        Control createTa = (Control) this.CREATE_TA;
        this.BorderColor_Keplerian(ref createTa, Color.Red);
        this.CREATE_TA = (TextBox) createTa;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createTa = (Control) this.CREATE_TA;
        this.BorderColor_Keplerian(ref createTa, Color.WhiteSmoke);
        this.CREATE_TA = (TextBox) createTa;
        this.TACr = Conversions.ToDouble(this.CREATE_TA.Text);
        this.Create_Defil_TA.Value = Conversions.ToInteger(this.CREATE_TA.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_X_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | this.CREATE_X.SelectionStart == 0 & Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0)
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_X.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_X.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_Y_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | this.CREATE_Y.SelectionStart == 0 & Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0)
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_Y.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_Y.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_Z_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | this.CREATE_Z.SelectionStart == 0 & Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0)
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_Z.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_Z.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_VX_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | this.CREATE_VX.SelectionStart == 0 & Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0)
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_VX.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_VX.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_VY_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | this.CREATE_VY.SelectionStart == 0 & Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0)
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_VY.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_VY.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_VZ_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | this.CREATE_VZ.SelectionStart == 0 & Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0)
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_VZ.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_VZ.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_Bstar_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | this.CREATE_Bstar.SelectionStart == 0 & Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0)
        e.Handled = false;
      else if (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0)
      {
        int num1 = Strings.Len(this.CREATE_Bstar.Text);
        int Start = 1;
        int num2;
        while (Start <= num1)
        {
          if (Operators.CompareString(Strings.Mid(this.CREATE_Bstar.Text, Start, 1), ".", false) == 0)
            checked { ++num2; }
          checked { ++Start; }
        }
        if (num2 > 0)
          e.Handled = true;
        else
          e.Handled = false;
      }
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CREATE_X_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_X.Text, "", false) == 0 | Operators.CompareString(this.CREATE_X.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_X.Text, "-", false) == 0)
      {
        Control createX = (Control) this.CREATE_X;
        this.BorderColor_Cartesian(ref createX, Color.Red);
        this.CREATE_X = (TextBox) createX;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createX = (Control) this.CREATE_X;
        this.BorderColor_Cartesian(ref createX, Color.WhiteSmoke);
        this.CREATE_X = (TextBox) createX;
        this.XCr = Conversions.ToDouble(this.CREATE_X.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_Y_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_Y.Text, "", false) == 0 | Operators.CompareString(this.CREATE_Y.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_Y.Text, "-", false) == 0)
      {
        Control createY = (Control) this.CREATE_Y;
        this.BorderColor_Cartesian(ref createY, Color.Red);
        this.CREATE_Y = (TextBox) createY;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createY = (Control) this.CREATE_Y;
        this.BorderColor_Cartesian(ref createY, Color.WhiteSmoke);
        this.CREATE_Y = (TextBox) createY;
        this.YCr = Conversions.ToDouble(this.CREATE_Y.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_Z_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_Z.Text, "", false) == 0 | Operators.CompareString(this.CREATE_Z.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_Z.Text, "-", false) == 0)
      {
        Control createZ = (Control) this.CREATE_Z;
        this.BorderColor_Cartesian(ref createZ, Color.Red);
        this.CREATE_Z = (TextBox) createZ;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createZ = (Control) this.CREATE_Z;
        this.BorderColor_Cartesian(ref createZ, Color.WhiteSmoke);
        this.CREATE_Z = (TextBox) createZ;
        this.ZCr = Conversions.ToDouble(this.CREATE_Z.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_VX_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_VX.Text, "", false) == 0 | Operators.CompareString(this.CREATE_VX.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_VX.Text, "-", false) == 0)
      {
        Control createVx = (Control) this.CREATE_VX;
        this.BorderColor_Cartesian(ref createVx, Color.Red);
        this.CREATE_VX = (TextBox) createVx;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createVx = (Control) this.CREATE_VX;
        this.BorderColor_Cartesian(ref createVx, Color.WhiteSmoke);
        this.CREATE_VX = (TextBox) createVx;
        this.VXCr = Conversions.ToDouble(this.CREATE_VX.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_VY_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_VY.Text, "", false) == 0 | Operators.CompareString(this.CREATE_VY.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_VY.Text, "-", false) == 0)
      {
        Control createVy = (Control) this.CREATE_VY;
        this.BorderColor_Cartesian(ref createVy, Color.Red);
        this.CREATE_VY = (TextBox) createVy;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createVy = (Control) this.CREATE_VY;
        this.BorderColor_Cartesian(ref createVy, Color.WhiteSmoke);
        this.CREATE_VY = (TextBox) createVy;
        this.Refresh_TLE();
      }
    }

    private void CREATE_VZ_TextChanged(object sender, EventArgs e)
    {
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_VZ.Text, "", false) == 0 | Operators.CompareString(this.CREATE_VZ.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_VZ.Text, "-", false) == 0)
      {
        Control createVz = (Control) this.CREATE_VZ;
        this.BorderColor_Cartesian(ref createVz, Color.Red);
        this.CREATE_VZ = (TextBox) createVz;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createVz = (Control) this.CREATE_VZ;
        this.BorderColor_Cartesian(ref createVz, Color.WhiteSmoke);
        this.CREATE_VZ = (TextBox) createVz;
        this.VZCr = Conversions.ToDouble(this.CREATE_VZ.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_Bstar_TextChanged(object sender, EventArgs e)
    {
      this.actuTrack = true;
      if (this.CreateFirstOpen | this.selectDefault == -1.0)
        return;
      if (Operators.CompareString(this.CREATE_Bstar.Text, "", false) == 0 | Operators.CompareString(this.CREATE_Bstar.Text, ".", false) == 0 | Operators.CompareString(this.CREATE_Bstar.Text, "-", false) == 0)
      {
        Control createBstar = (Control) this.CREATE_Bstar;
        this.BorderColor_Elements(ref createBstar, Color.Red);
        this.CREATE_Bstar = (TextBox) createBstar;
        this.TLETextBox.Text = "";
      }
      else
      {
        Control createBstar = (Control) this.CREATE_Bstar;
        this.BorderColor_Elements(ref createBstar, Color.WhiteSmoke);
        this.CREATE_Bstar = (TextBox) createBstar;
        this.BSTAR = Conversions.ToDouble(this.CREATE_Bstar.Text);
        this.Refresh_TLE();
      }
    }

    private void CREATE_Save_Click(object sender, EventArgs e) => this.SaveTLE();

    public void Refresh_TLE()
    {
      if (this.CREATE_EPOCH_Format.SelectedIndex == 1)
        this.CREATEPOCH = Functions.GregtoMJD(this.CREATE_EPOCH_Current.Text);
      else if (this.CREATE_EPOCH_Format.SelectedIndex == 0)
        this.CREATEPOCH = Conversions.ToDouble(this.CREATE_EPOCH_Current.Text);
      else if (this.CREATE_EPOCH_Format.SelectedIndex == 2)
        this.CREATEPOCH = Functions.TLEtoMJD(Conversions.ToDouble(this.CREATE_EPOCH_Current.Text));
      if (this.CREATE_Default.SelectedIndex != 6)
        Functions.KepleriantoCartesianCreate(this.SMACr, this.ECCCr, this.INCCr, this.RAANCr, this.AOPCr, this.TACr);
      double[] rri = new double[3];
      double[] vvi = new double[3];
      OP2SGP4.bstar = this.BSTAR;
      rri[0] = this.XCr * 0.000156785602695689;
      rri[1] = this.YCr * 0.000156785602695689;
      rri[2] = this.ZCr * 0.000156785602695689;
      vvi[0] = this.VXCr * 0.00940713616174136;
      vvi[1] = this.VYCr * 0.00940713616174136;
      vvi[2] = this.VZCr * 0.00940713616174136;
      OP2SGP4.rv2el(rri, vvi);
      this.SMAs = OP2SGP4.aodp / 0.000156785602695689;
      this.INCs = 180.0 / Math.PI * OP2SGP4.xincl;
      this.RAANs = 180.0 / Math.PI * OP2SGP4.xnodeo;
      this.ECCs = OP2SGP4.eo;
      this.AOPs = 180.0 / Math.PI * OP2SGP4.omegao;
      this.MAs = 180.0 / Math.PI * OP2SGP4.xmo;
      this.MMs = 180.0 / Math.PI * OP2SGP4.xno * 1440.0 / 360.0;
      double bstar = OP2SGP4.bstar;
      string str1 = Conversion.Str((object) DateAndTime.Year(Conversions.ToDate(Functions.MJDtoGreg(Conversions.ToString(this.CREATEPOCH)))));
      string str2 = Conversion.Str((object) DateAndTime.Hour(Conversions.ToDate(Functions.MJDtoGreg(Conversions.ToString(this.CREATEPOCH)))));
      string str3 = Conversion.Str((object) DateAndTime.Minute(Conversions.ToDate(Functions.MJDtoGreg(Conversions.ToString(this.CREATEPOCH)))));
      string str4 = Conversion.Str((object) DateAndTime.Second(Conversions.ToDate(Functions.MJDtoGreg(Conversions.ToString(this.CREATEPOCH)))));
      string str5 = this.CREATE_SatNumb.Text;
      while (str5.Length < 5)
      {
        if (str5.Length < 5)
          str5 = "0" + str5;
      }
      string str6 = "A";
      string str7 = "00";
      string str8 = "000";
      string str9 = "000";
      string str10 = Strings.Mid(str1, 4, 2);
      string str11 = Strings.Format((object) ((double) checked (DateAndTime.DateDiff(DateInterval.DayOfYear, Conversions.ToDate("01/01/" + str1), Conversions.ToDate(Functions.MJDtoGreg(Conversions.ToString(this.CREATEPOCH)))) + 1L) + (Conversions.ToDouble(str2) / 24.0 + Conversions.ToDouble(str3) / 1440.0 + Conversions.ToDouble(str4) / 86400.0)), "000.00000000");
      string str12 = "0000000000";
      string str13 = "000000-0";
      object obj = (object) Strings.Format((object) bstar, "0.0000E+0");
      object Right1;
      if (bstar > 0.0)
        Right1 = (object) (" " + Strings.Mid(Conversions.ToString(obj), 1, 1) + Strings.Mid(Conversions.ToString(obj), 3, 4) + Strings.Mid(Conversions.ToString(obj), 8, 1) + Conversions.ToString(Conversions.ToDouble(Strings.Mid(Conversions.ToString(obj), 9, 1)) - 1.0));
      else
        Right1 = bstar != 0.0 ? (object) (Strings.Mid(Conversions.ToString(obj), 1, 2) + Strings.Mid(Conversions.ToString(obj), 4, 4) + Strings.Mid(Conversions.ToString(obj), 9, 1) + Conversions.ToString(Conversions.ToDouble(Strings.Mid(Conversions.ToString(obj), 10, 1)) - 1.0)) : (object) "0.0000+0";
      string Right2 = "0";
      string Right3 = "    ";
      string Right4 = "0";
      this.TLELine1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) ("1 " + str5 + str6 + " " + str7 + str8 + str9 + " " + str10 + str11 + " " + str12 + " " + str13 + " "), Right1), (object) " "), (object) Right2), (object) " "), (object) Right3), (object) Right4));
      string str14 = Strings.Format((object) this.INCs, "000.0000");
      string str15 = Strings.Format((object) this.RAANs, "000.0000");
      string str16 = Strings.Mid(Conversions.ToString(this.ECCs), 3, 7);
      string str17 = Strings.Format((object) this.AOPs, "000.0000");
      string str18 = Strings.Format((object) this.MAs, "000.0000");
      string str19 = Strings.Mid(Conversions.ToString(this.MMs), 1, 11);
      string str20 = "    0";
      string str21 = "0";
      this.TLELine2 = "2 " + str5 + " " + str14 + " " + str15 + " " + str16 + " " + str17 + " " + str18 + " " + str19 + str20 + str21;
      this.TLETextBox.Text = !Functions.CheckTLE(this.TLELine1, this.TLELine2, false) ? "" : this.TLELine1 + "\r\n" + this.TLELine2;
      if (!this.checkOrbit())
      {
        this.TLETextBox.Text = "";
      }
      else
      {
        this.SATNAME = this.CREATE_ScName.Text;
        this.TLE_Import();
        this.TLE_Detail();
      }
    }

    private void BorderColor_Keplerian(ref Control _Control, Color _Color)
    {
      Graphics graphics = this.CREATE_Panel_Kepler.CreateGraphics();
      Pen pen = new Pen(_Color, 2f);
      graphics.DrawRectangle(pen, new Rectangle(_Control.Location, _Control.Size));
      pen.Dispose();
    }

    private void BorderColor_Cartesian(ref Control _Control, Color _Color)
    {
      Graphics graphics = this.CREATE_Panel_Cartesian.CreateGraphics();
      Pen pen = new Pen(_Color, 2f);
      graphics.DrawRectangle(pen, new Rectangle(_Control.Location, _Control.Size));
      pen.Dispose();
    }

    private void BorderColor_Elements(ref Control _Control, Color _Color)
    {
      Graphics graphics = this.CREATE_Elements.CreateGraphics();
      Pen pen = new Pen(_Color, 2f);
      graphics.DrawRectangle(pen, new Rectangle(_Control.Location, _Control.Size));
      pen.Dispose();
    }

    private void BorderColor_SatNumber(ref Control _Control, Color _Color)
    {
      Graphics graphics = this.CREATE_Entry.CreateGraphics();
      Pen pen = new Pen(_Color, 2f);
      graphics.DrawRectangle(pen, new Rectangle(_Control.Location, _Control.Size));
      pen.Dispose();
    }

    private void SaveTLE()
    {
      List<string> contents = new List<string>();
      contents.Add(this.SATNAME);
      contents.Add(this.TLELine1);
      contents.Add(this.TLELine2);
      this.SaveFileDialog1.Title = "Save TLE in a collection.";
      this.SaveFileDialog1.FileName = this.CREATE_Collection.Text + ".txt";
      this.SaveFileDialog1.InitialDirectory = this.TLEPath;
      this.SaveFileDialog1.Filter = "Fichiers txt|*.txt";
      this.SaveFileDialog1.OverwritePrompt = false;
      string fileName1;
      if (this.SaveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        string fileName2 = this.SaveFileDialog1.FileName;
        File.AppendAllLines(fileName2, (IEnumerable<string>) contents, Encoding.Default);
        fileName1 = Path.GetFileName(fileName2);
        this.SaveFileDialog1.Dispose();
      }
      if (!(Operators.CompareString(fileName1, (string) null, false) == 0 | Operators.CompareString(fileName1, "", false) == 0))
        ;
    }

    private void FillBoxes()
    {
      this.CREATE_SMA.Text = Conversions.ToString(this.SMACr);
      this.CREATE_ECC.Text = Conversions.ToString(this.ECCCr);
      this.CREATE_INC.Text = Conversions.ToString(this.INCCr);
      this.CREATE_RAAN.Text = Conversions.ToString(this.RAANCr);
      this.CREATE_AOP.Text = Conversions.ToString(this.AOPCr);
      this.CREATE_TA.Text = Conversions.ToString(this.TACr);
      this.CREATE_X.Text = Conversions.ToString(this.XCr);
      this.CREATE_Y.Text = Conversions.ToString(this.YCr);
      this.CREATE_Z.Text = Conversions.ToString(this.ZCr);
      this.CREATE_VX.Text = Conversions.ToString(this.VXCr);
      this.CREATE_VY.Text = Conversions.ToString(this.VYCr);
      this.CREATE_VZ.Text = Conversions.ToString(this.VZCr);
    }

    private bool checkOrbit()
    {
      bool flag = true;
      double omegao = OP2SGP4.omegao;
      double eo = OP2SGP4.eo;
      double xincl = OP2SGP4.xincl;
      double xno = OP2SGP4.xno;
      double xnodeo = OP2SGP4.xnodeo;
      double d1 = 1.0 - eo * eo;
      double num1 = Math.Sqrt(d1);
      double num2 = Math.Cos(xincl);
      double num3 = num2 * num2;
      double num4 = Math.Pow(Terre.KE / xno, 2.0 / 3.0);
      double num5 = 0.00081196185 * (3.0 * num3 - 1.0) / (num1 * d1);
      double num6 = num5 / (num4 * num4);
      double num7 = num4 * (1.0 - num6 * num6 - num6 * (1.0 / 3.0 + 134.0 * num6 * num6 / 81.0));
      double num8 = num5 / (num7 * num7);
      double num9 = xno / (1.0 + num8);
      double num10 = Math.Pow(Terre.KE / num9, 2.0 / 3.0);
      Math.Sin(xincl);
      double num11 = num10 * d1;
      double num12 = -(1.0 - 5.0 * num3) - num3 - num3;
      double num13 = num11 * num11;
      double d2 = num10 * (1.0 - eo);
      if (!double.IsNaN(d2))
      {
        if (d2 < 1.0)
          flag = false;
      }
      else
        flag = false;
      return flag;
    }

    private void Create_Defil_SMA_Scroll(object sender, ScrollEventArgs e)
    {
      if (e.Type == ScrollEventType.SmallIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_SMA.Text) + 1.0 >= (double) this.Create_Defil_SMA.Maximum)
          return;
        this.CREATE_SMA.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_SMA.Text) + 1.0);
      }
      else if (e.Type == ScrollEventType.LargeIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_SMA.Text) + 100.0 >= (double) this.Create_Defil_SMA.Maximum)
          return;
        this.CREATE_SMA.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_SMA.Text) + 100.0);
      }
      else if (e.Type == ScrollEventType.SmallDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_SMA.Text) - 1.0 <= (double) this.Create_Defil_SMA.Minimum)
          return;
        this.CREATE_SMA.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_SMA.Text) - 1.0);
      }
      else if (e.Type == ScrollEventType.LargeDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_SMA.Text) - 100.0 <= (double) this.Create_Defil_SMA.Minimum)
          return;
        this.CREATE_SMA.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_SMA.Text) - 100.0);
      }
      else
      {
        if (e.Type != ScrollEventType.ThumbTrack)
          return;
        this.CREATE_SMA.Text = Conversions.ToString(this.Create_Defil_SMA.Value);
      }
    }

    private void Create_Defil_ECC_Scroll(object sender, ScrollEventArgs e)
    {
      if (e.Type == ScrollEventType.SmallIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_ECC.Text) + 0.001 >= (double) this.Create_Defil_ECC.Maximum * 0.0001)
          return;
        this.CREATE_ECC.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_ECC.Text) + 0.001);
      }
      else if (e.Type == ScrollEventType.LargeIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_ECC.Text) + 0.1 >= (double) this.Create_Defil_ECC.Maximum * 0.0001)
          return;
        this.CREATE_ECC.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_ECC.Text) + 0.1);
      }
      else if (e.Type == ScrollEventType.SmallDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_ECC.Text) - 0.001 <= (double) this.Create_Defil_ECC.Minimum * 0.0001)
          return;
        this.CREATE_ECC.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_ECC.Text) - 0.001);
      }
      else if (e.Type == ScrollEventType.LargeDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_ECC.Text) - 0.1 <= (double) this.Create_Defil_ECC.Minimum * 0.0001)
          return;
        this.CREATE_ECC.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_ECC.Text) - 0.1);
      }
      else
      {
        if (e.Type != ScrollEventType.ThumbTrack)
          return;
        this.CREATE_ECC.Text = Conversions.ToString((double) this.Create_Defil_ECC.Value * 0.0001);
      }
    }

    private void Create_Defil_INC_Scroll(object sender, ScrollEventArgs e)
    {
      if (e.Type == ScrollEventType.SmallIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_INC.Text) + 1.0 >= (double) this.Create_Defil_INC.Maximum)
          return;
        this.CREATE_INC.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_INC.Text) + 1.0);
      }
      else if (e.Type == ScrollEventType.LargeIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_INC.Text) + 10.0 >= (double) this.Create_Defil_INC.Maximum)
          return;
        this.CREATE_INC.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_INC.Text) + 10.0);
      }
      else if (e.Type == ScrollEventType.SmallDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_INC.Text) - 1.0 <= (double) this.Create_Defil_INC.Minimum)
          return;
        this.CREATE_INC.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_INC.Text) - 1.0);
      }
      else if (e.Type == ScrollEventType.LargeDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_INC.Text) - 10.0 <= (double) this.Create_Defil_INC.Minimum)
          return;
        this.CREATE_INC.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_INC.Text) - 10.0);
      }
      else
      {
        if (e.Type != ScrollEventType.ThumbTrack)
          return;
        this.CREATE_INC.Text = Conversions.ToString(this.Create_Defil_INC.Value);
      }
    }

    private void Create_Defil_RAAN_Scroll(object sender, ScrollEventArgs e)
    {
      if (e.Type == ScrollEventType.SmallIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_RAAN.Text) + 1.0 >= (double) this.Create_Defil_RAAN.Maximum)
          return;
        this.CREATE_RAAN.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_RAAN.Text) + 1.0);
      }
      else if (e.Type == ScrollEventType.LargeIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_RAAN.Text) + 10.0 >= (double) this.Create_Defil_RAAN.Maximum)
          return;
        this.CREATE_RAAN.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_RAAN.Text) + 10.0);
      }
      else if (e.Type == ScrollEventType.SmallDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_RAAN.Text) - 1.0 <= (double) this.Create_Defil_RAAN.Minimum)
          return;
        this.CREATE_RAAN.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_RAAN.Text) - 1.0);
      }
      else if (e.Type == ScrollEventType.LargeDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_RAAN.Text) - 10.0 <= (double) this.Create_Defil_RAAN.Minimum)
          return;
        this.CREATE_RAAN.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_RAAN.Text) - 10.0);
      }
      else
      {
        if (e.Type != ScrollEventType.ThumbTrack)
          return;
        this.CREATE_RAAN.Text = Conversions.ToString(this.Create_Defil_RAAN.Value);
      }
    }

    private void Create_Defil_AOP_Scroll(object sender, ScrollEventArgs e)
    {
      if (e.Type == ScrollEventType.SmallIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_AOP.Text) + 1.0 >= (double) this.Create_Defil_AOP.Maximum)
          return;
        this.CREATE_AOP.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_AOP.Text) + 1.0);
      }
      else if (e.Type == ScrollEventType.LargeIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_AOP.Text) + 10.0 >= (double) this.Create_Defil_AOP.Maximum)
          return;
        this.CREATE_AOP.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_AOP.Text) + 10.0);
      }
      else if (e.Type == ScrollEventType.SmallDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_AOP.Text) - 1.0 <= (double) this.Create_Defil_AOP.Minimum)
          return;
        this.CREATE_AOP.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_AOP.Text) - 1.0);
      }
      else if (e.Type == ScrollEventType.LargeDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_AOP.Text) - 10.0 <= (double) this.Create_Defil_AOP.Minimum)
          return;
        this.CREATE_AOP.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_AOP.Text) - 10.0);
      }
      else
      {
        if (e.Type != ScrollEventType.ThumbTrack)
          return;
        this.CREATE_AOP.Text = Conversions.ToString(this.Create_Defil_AOP.Value);
      }
    }

    private void Create_Defil_TA_Scroll(object sender, ScrollEventArgs e)
    {
      if (e.Type == ScrollEventType.SmallIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_TA.Text) + 1.0 >= (double) this.Create_Defil_ECC.Maximum)
          return;
        this.CREATE_TA.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_TA.Text) + 1.0);
      }
      else if (e.Type == ScrollEventType.LargeIncrement)
      {
        if (Conversions.ToDouble(this.CREATE_TA.Text) + 10.0 >= (double) this.Create_Defil_ECC.Maximum)
          return;
        this.CREATE_TA.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_TA.Text) + 10.0);
      }
      else if (e.Type == ScrollEventType.SmallDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_TA.Text) - 1.0 <= (double) this.Create_Defil_TA.Minimum)
          return;
        this.CREATE_TA.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_TA.Text) - 1.0);
      }
      else if (e.Type == ScrollEventType.LargeDecrement)
      {
        if (Conversions.ToDouble(this.CREATE_TA.Text) - 10.0 <= (double) this.Create_Defil_TA.Minimum)
          return;
        this.CREATE_TA.Text = Conversions.ToString(Conversions.ToDouble(this.CREATE_TA.Text) - 10.0);
      }
      else
      {
        if (e.Type != ScrollEventType.ThumbPosition)
          return;
        this.CREATE_TA.Text = Conversions.ToString(this.Create_Defil_TA.Value);
      }
    }
  }
}
