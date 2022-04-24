// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Search
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  [DesignerGenerated]
  public class Search : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("SearchByNameGrp")]
    private GroupBox _SearchByNameGrp;
    [AccessedThroughProperty("SEARCH_Name")]
    private TextBox _SEARCH_Name;
    [AccessedThroughProperty("SEARCH_ByName")]
    private RadioButton _SEARCH_ByName;
    [AccessedThroughProperty("SearchByTypeGrp")]
    private GroupBox _SearchByTypeGrp;
    [AccessedThroughProperty("SEARCH_ByType")]
    private RadioButton _SEARCH_ByType;
    [AccessedThroughProperty("SEARCH_LNGList")]
    private ComboBox _SEARCH_LNGList;
    [AccessedThroughProperty("SEARCH_TypeList")]
    private ComboBox _SEARCH_TypeList;
    [AccessedThroughProperty("SearchLngLabel")]
    private Label _SearchLngLabel;
    [AccessedThroughProperty("SearchResult")]
    private Label _SearchResult;
    [AccessedThroughProperty("SearchByParGrp")]
    private GroupBox _SearchByParGrp;
    [AccessedThroughProperty("SEARCH_ByPar")]
    private RadioButton _SEARCH_ByPar;
    [AccessedThroughProperty("SEARCH_Number")]
    private TextBox _SEARCH_Number;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label9")]
    private Label _Label9;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("SEARCH_PERMAX")]
    private TextBox _SEARCH_PERMAX;
    [AccessedThroughProperty("SEARCH_PERMIN")]
    private TextBox _SEARCH_PERMIN;
    [AccessedThroughProperty("SEARCH_ECCMAX")]
    private TextBox _SEARCH_ECCMAX;
    [AccessedThroughProperty("SEARCH_INCMAX")]
    private TextBox _SEARCH_INCMAX;
    [AccessedThroughProperty("SEARCH_ECCMIN")]
    private TextBox _SEARCH_ECCMIN;
    [AccessedThroughProperty("SEARCH_INCMIN")]
    private TextBox _SEARCH_INCMIN;
    [AccessedThroughProperty("SEARCH_PEAMAX")]
    private TextBox _SEARCH_PEAMAX;
    [AccessedThroughProperty("SEARCH_PEAMIN")]
    private TextBox _SEARCH_PEAMIN;
    [AccessedThroughProperty("SEARCH_APAMAX")]
    private TextBox _SEARCH_APAMAX;
    [AccessedThroughProperty("SEARCH_APAMIN")]
    private TextBox _SEARCH_APAMIN;
    [AccessedThroughProperty("Label13")]
    private Label _Label13;
    [AccessedThroughProperty("Label11")]
    private Label _Label11;
    [AccessedThroughProperty("Label10")]
    private Label _Label10;
    [AccessedThroughProperty("SEARCH_Period")]
    private CheckBox _SEARCH_Period;
    [AccessedThroughProperty("SEARCH_ECC")]
    private CheckBox _SEARCH_ECC;
    [AccessedThroughProperty("SEARCH_INC")]
    private CheckBox _SEARCH_INC;
    [AccessedThroughProperty("SEARCH_PEA")]
    private CheckBox _SEARCH_PEA;
    [AccessedThroughProperty("SEARCH_APA")]
    private CheckBox _SEARCH_APA;
    [AccessedThroughProperty("SEARCH_Search")]
    private Button _SEARCH_Search;
    [AccessedThroughProperty("SEARCH_Close")]
    private Button _SEARCH_Close;
    [AccessedThroughProperty("SEARCH_Date")]
    private TextBox _SEARCH_Date;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _TabControl1;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _TabPage1;
    [AccessedThroughProperty("TabPage2")]
    private TabPage _TabPage2;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("SFC_LaunchYear")]
    private TextBox _SFC_LaunchYear;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    [AccessedThroughProperty("SFC_NoradID")]
    private TextBox _SFC_NoradID;
    [AccessedThroughProperty("Label7")]
    private Label _Label7;
    [AccessedThroughProperty("Label8")]
    private Label _Label8;
    [AccessedThroughProperty("SFC_Name")]
    private TextBox _SFC_Name;
    [AccessedThroughProperty("SFC_SatListBox")]
    private ListBox _SFC_SatListBox;
    [AccessedThroughProperty("GroupBox2")]
    private GroupBox _GroupBox2;
    [AccessedThroughProperty("SFC_IntDesBox")]
    private TextBox _SFC_IntDesBox;
    [AccessedThroughProperty("Label12")]
    private Label _Label12;
    [AccessedThroughProperty("SFC_Import")]
    private Button _SFC_Import;
    [AccessedThroughProperty("SFC_TextBox")]
    private TextBox _SFC_TextBox;
    [AccessedThroughProperty("SFC_DecayDateBox")]
    private TextBox _SFC_DecayDateBox;
    [AccessedThroughProperty("Label21")]
    private Label _Label21;
    [AccessedThroughProperty("SFC_LaunchSiteBox")]
    private TextBox _SFC_LaunchSiteBox;
    [AccessedThroughProperty("Label20")]
    private Label _Label20;
    [AccessedThroughProperty("SFC_LaunchDateBox")]
    private TextBox _SFC_LaunchDateBox;
    [AccessedThroughProperty("Label19")]
    private Label _Label19;
    [AccessedThroughProperty("SFC_OwnerBox")]
    private TextBox _SFC_OwnerBox;
    [AccessedThroughProperty("Label18")]
    private Label _Label18;
    [AccessedThroughProperty("SFC_NameBox")]
    private TextBox _SFC_NameBox;
    [AccessedThroughProperty("Label17")]
    private Label _Label17;
    [AccessedThroughProperty("SFC_StatusBox")]
    private TextBox _SFC_StatusBox;
    [AccessedThroughProperty("Label16")]
    private Label _Label16;
    [AccessedThroughProperty("SFC_AltNameBox")]
    private TextBox _SFC_AltNameBox;
    [AccessedThroughProperty("Label15")]
    private Label _Label15;
    [AccessedThroughProperty("SFC_NoradIdBox")]
    private TextBox _SFC_NoradIdBox;
    [AccessedThroughProperty("Label14")]
    private Label _Label14;
    [AccessedThroughProperty("SFC_Search")]
    private Button _SFC_Search;
    [AccessedThroughProperty("SFC_DisplayAll")]
    private Button _SFC_DisplayAll;
    [AccessedThroughProperty("SFC_Debris")]
    private CheckBox _SFC_Debris;
    [AccessedThroughProperty("SFC_Rocket")]
    private CheckBox _SFC_Rocket;
    [AccessedThroughProperty("SFC_Platform")]
    private CheckBox _SFC_Platform;
    [AccessedThroughProperty("SFC_Payload")]
    private CheckBox _SFC_Payload;
    [AccessedThroughProperty("SFC_CountLabel")]
    private Label _SFC_CountLabel;
    [AccessedThroughProperty("SFC_ObjectType")]
    private TextBox _SFC_ObjectType;
    [AccessedThroughProperty("Label22")]
    private Label _Label22;
    [AccessedThroughProperty("SFC_Inclination")]
    private TextBox _SFC_Inclination;
    [AccessedThroughProperty("Label26")]
    private Label _Label26;
    [AccessedThroughProperty("SFC_Period")]
    private TextBox _SFC_Period;
    [AccessedThroughProperty("Label25")]
    private Label _Label25;
    [AccessedThroughProperty("SFC_Periapsis")]
    private TextBox _SFC_Periapsis;
    [AccessedThroughProperty("Label24")]
    private Label _Label24;
    [AccessedThroughProperty("SFC_Apoapsis")]
    private TextBox _SFC_Apoapsis;
    [AccessedThroughProperty("Label23")]
    private Label _Label23;
    [AccessedThroughProperty("SFC_Collection")]
    private TextBox _SFC_Collection;
    [AccessedThroughProperty("Label105")]
    private Label _Label105;

    [DebuggerNonUserCode]
    static Search()
    {
    }

    [DebuggerNonUserCode]
    public Search()
    {
      Search.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (Search.__ENCList)
      {
        if (Search.__ENCList.Count == Search.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (Search.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (Search.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                Search.__ENCList[index1] = Search.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          Search.__ENCList.RemoveRange(index1, checked (Search.__ENCList.Count - index1));
          Search.__ENCList.Capacity = Search.__ENCList.Count;
        }
        Search.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Search));
      this.SearchByNameGrp = new GroupBox();
      this.SEARCH_Date = new TextBox();
      this.Label3 = new Label();
      this.SEARCH_Number = new TextBox();
      this.Label2 = new Label();
      this.Label1 = new Label();
      this.SEARCH_Name = new TextBox();
      this.SEARCH_ByName = new RadioButton();
      this.SearchByTypeGrp = new GroupBox();
      this.SearchLngLabel = new Label();
      this.SEARCH_LNGList = new ComboBox();
      this.SEARCH_TypeList = new ComboBox();
      this.SEARCH_ByType = new RadioButton();
      this.SearchResult = new Label();
      this.SearchByParGrp = new GroupBox();
      this.SEARCH_Period = new CheckBox();
      this.SEARCH_ECC = new CheckBox();
      this.SEARCH_INC = new CheckBox();
      this.SEARCH_PEA = new CheckBox();
      this.SEARCH_APA = new CheckBox();
      this.Label13 = new Label();
      this.Label11 = new Label();
      this.Label10 = new Label();
      this.Label9 = new Label();
      this.Label5 = new Label();
      this.Label4 = new Label();
      this.SEARCH_PERMAX = new TextBox();
      this.SEARCH_PERMIN = new TextBox();
      this.SEARCH_ECCMAX = new TextBox();
      this.SEARCH_INCMAX = new TextBox();
      this.SEARCH_ECCMIN = new TextBox();
      this.SEARCH_INCMIN = new TextBox();
      this.SEARCH_PEAMAX = new TextBox();
      this.SEARCH_PEAMIN = new TextBox();
      this.SEARCH_APAMAX = new TextBox();
      this.SEARCH_APAMIN = new TextBox();
      this.SEARCH_ByPar = new RadioButton();
      this.SEARCH_Search = new Button();
      this.SEARCH_Close = new Button();
      this.TabControl1 = new TabControl();
      this.TabPage1 = new TabPage();
      this.TabPage2 = new TabPage();
      this.SFC_CountLabel = new Label();
      this.SFC_Import = new Button();
      this.GroupBox2 = new GroupBox();
      this.SFC_Collection = new TextBox();
      this.Label105 = new Label();
      this.SFC_Inclination = new TextBox();
      this.Label26 = new Label();
      this.SFC_Period = new TextBox();
      this.Label25 = new Label();
      this.Label15 = new Label();
      this.SFC_AltNameBox = new TextBox();
      this.SFC_Periapsis = new TextBox();
      this.Label24 = new Label();
      this.SFC_Apoapsis = new TextBox();
      this.Label23 = new Label();
      this.SFC_ObjectType = new TextBox();
      this.Label22 = new Label();
      this.SFC_DecayDateBox = new TextBox();
      this.Label21 = new Label();
      this.SFC_LaunchSiteBox = new TextBox();
      this.Label20 = new Label();
      this.SFC_LaunchDateBox = new TextBox();
      this.Label19 = new Label();
      this.SFC_OwnerBox = new TextBox();
      this.Label18 = new Label();
      this.SFC_NameBox = new TextBox();
      this.Label17 = new Label();
      this.SFC_StatusBox = new TextBox();
      this.Label16 = new Label();
      this.SFC_NoradIdBox = new TextBox();
      this.Label14 = new Label();
      this.SFC_IntDesBox = new TextBox();
      this.Label12 = new Label();
      this.SFC_TextBox = new TextBox();
      this.SFC_SatListBox = new ListBox();
      this.GroupBox1 = new GroupBox();
      this.SFC_Debris = new CheckBox();
      this.SFC_Rocket = new CheckBox();
      this.SFC_Platform = new CheckBox();
      this.SFC_Payload = new CheckBox();
      this.SFC_DisplayAll = new Button();
      this.SFC_LaunchYear = new TextBox();
      this.Label6 = new Label();
      this.SFC_Search = new Button();
      this.SFC_NoradID = new TextBox();
      this.Label7 = new Label();
      this.Label8 = new Label();
      this.SFC_Name = new TextBox();
      this.SearchByNameGrp.SuspendLayout();
      this.SearchByTypeGrp.SuspendLayout();
      this.SearchByParGrp.SuspendLayout();
      this.TabControl1.SuspendLayout();
      this.TabPage1.SuspendLayout();
      this.TabPage2.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.SearchByNameGrp.Controls.Add((Control) this.SEARCH_Date);
      this.SearchByNameGrp.Controls.Add((Control) this.Label3);
      this.SearchByNameGrp.Controls.Add((Control) this.SEARCH_Number);
      this.SearchByNameGrp.Controls.Add((Control) this.Label2);
      this.SearchByNameGrp.Controls.Add((Control) this.Label1);
      this.SearchByNameGrp.Controls.Add((Control) this.SEARCH_Name);
      GroupBox searchByNameGrp1 = this.SearchByNameGrp;
      Point point1 = new Point(6, 28);
      Point point2 = point1;
      searchByNameGrp1.Location = point2;
      this.SearchByNameGrp.Name = "SearchByNameGrp";
      GroupBox searchByNameGrp2 = this.SearchByNameGrp;
      Size size1 = new Size(176, 110);
      Size size2 = size1;
      searchByNameGrp2.Size = size2;
      this.SearchByNameGrp.TabIndex = 0;
      this.SearchByNameGrp.TabStop = false;
      this.SEARCH_Date.CharacterCasing = CharacterCasing.Upper;
      TextBox searchDate1 = this.SEARCH_Date;
      point1 = new Point(101, 71);
      Point point3 = point1;
      searchDate1.Location = point3;
      this.SEARCH_Date.MaxLength = 4;
      this.SEARCH_Date.Name = "SEARCH_Date";
      TextBox searchDate2 = this.SEARCH_Date;
      size1 = new Size(69, 20);
      Size size3 = size1;
      searchDate2.Size = size3;
      this.SEARCH_Date.TabIndex = 79;
      this.Label3.AutoSize = true;
      Label label3_1 = this.Label3;
      point1 = new Point(6, 75);
      Point point4 = point1;
      label3_1.Location = point4;
      this.Label3.Name = "Label3";
      Label label3_2 = this.Label3;
      size1 = new Size(68, 13);
      Size size4 = size1;
      label3_2.Size = size4;
      this.Label3.TabIndex = 78;
      this.Label3.Text = "Launch Year";
      this.SEARCH_Number.CharacterCasing = CharacterCasing.Upper;
      TextBox searchNumber1 = this.SEARCH_Number;
      point1 = new Point(101, 45);
      Point point5 = point1;
      searchNumber1.Location = point5;
      this.SEARCH_Number.MaxLength = 5;
      this.SEARCH_Number.Name = "SEARCH_Number";
      TextBox searchNumber2 = this.SEARCH_Number;
      size1 = new Size(69, 20);
      Size size5 = size1;
      searchNumber2.Size = size5;
      this.SEARCH_Number.TabIndex = 77;
      this.Label2.AutoSize = true;
      Label label2_1 = this.Label2;
      point1 = new Point(6, 49);
      Point point6 = point1;
      label2_1.Location = point6;
      this.Label2.Name = "Label2";
      Label label2_2 = this.Label2;
      size1 = new Size(60, 13);
      Size size6 = size1;
      label2_2.Size = size6;
      this.Label2.TabIndex = 76;
      this.Label2.Text = "NORAD ID";
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(6, 22);
      Point point7 = point1;
      label1_1.Location = point7;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(35, 13);
      Size size7 = size1;
      label1_2.Size = size7;
      this.Label1.TabIndex = 75;
      this.Label1.Text = "Name";
      this.SEARCH_Name.CharacterCasing = CharacterCasing.Upper;
      TextBox searchName1 = this.SEARCH_Name;
      point1 = new Point(76, 19);
      Point point8 = point1;
      searchName1.Location = point8;
      this.SEARCH_Name.Name = "SEARCH_Name";
      TextBox searchName2 = this.SEARCH_Name;
      size1 = new Size(94, 20);
      Size size8 = size1;
      searchName2.Size = size8;
      this.SEARCH_Name.TabIndex = 1;
      this.SEARCH_ByName.AutoSize = true;
      this.SEARCH_ByName.Checked = true;
      RadioButton searchByName1 = this.SEARCH_ByName;
      point1 = new Point(9, 6);
      Point point9 = point1;
      searchByName1.Location = point9;
      this.SEARCH_ByName.Name = "SEARCH_ByName";
      RadioButton searchByName2 = this.SEARCH_ByName;
      size1 = new Size(151, 17);
      Size size9 = size1;
      searchByName2.Size = size9;
      this.SEARCH_ByName.TabIndex = 0;
      this.SEARCH_ByName.TabStop = true;
      this.SEARCH_ByName.Text = "Name / NORAD ID / Date";
      this.SEARCH_ByName.UseVisualStyleBackColor = true;
      this.SearchByTypeGrp.Controls.Add((Control) this.SearchLngLabel);
      this.SearchByTypeGrp.Controls.Add((Control) this.SEARCH_LNGList);
      this.SearchByTypeGrp.Controls.Add((Control) this.SEARCH_TypeList);
      GroupBox searchByTypeGrp1 = this.SearchByTypeGrp;
      point1 = new Point(6, 167);
      Point point10 = point1;
      searchByTypeGrp1.Location = point10;
      this.SearchByTypeGrp.Name = "SearchByTypeGrp";
      GroupBox searchByTypeGrp2 = this.SearchByTypeGrp;
      size1 = new Size(176, 81);
      Size size10 = size1;
      searchByTypeGrp2.Size = size10;
      this.SearchByTypeGrp.TabIndex = 1;
      this.SearchByTypeGrp.TabStop = false;
      this.SearchLngLabel.AutoSize = true;
      Label searchLngLabel1 = this.SearchLngLabel;
      point1 = new Point(59, 49);
      Point point11 = point1;
      searchLngLabel1.Location = point11;
      this.SearchLngLabel.Name = "SearchLngLabel";
      Label searchLngLabel2 = this.SearchLngLabel;
      size1 = new Size(47, 13);
      Size size11 = size1;
      searchLngLabel2.Size = size11;
      this.SearchLngLabel.TabIndex = 4;
      this.SearchLngLabel.Text = "< LNG <";
      this.SearchLngLabel.Visible = false;
      this.SEARCH_LNGList.DropDownStyle = ComboBoxStyle.DropDownList;
      this.SEARCH_LNGList.Enabled = false;
      this.SEARCH_LNGList.FormattingEnabled = true;
      this.SEARCH_LNGList.Items.AddRange(new object[14]
      {
        (object) "All",
        (object) "-180",
        (object) "-150",
        (object) "-120",
        (object) "-90",
        (object) "-60",
        (object) "-30",
        (object) "0",
        (object) "+30",
        (object) "+60",
        (object) "+90",
        (object) "+120",
        (object) "+130",
        (object) "+150"
      });
      ComboBox searchLngList1 = this.SEARCH_LNGList;
      point1 = new Point(6, 46);
      Point point12 = point1;
      searchLngList1.Location = point12;
      this.SEARCH_LNGList.Name = "SEARCH_LNGList";
      ComboBox searchLngList2 = this.SEARCH_LNGList;
      size1 = new Size(47, 21);
      Size size12 = size1;
      searchLngList2.Size = size12;
      this.SEARCH_LNGList.TabIndex = 3;
      this.SEARCH_TypeList.DropDownStyle = ComboBoxStyle.DropDownList;
      this.SEARCH_TypeList.FormattingEnabled = true;
      this.SEARCH_TypeList.Items.AddRange(new object[6]
      {
        (object) "Geostationnary",
        (object) "Sun Synchronous",
        (object) "Polar",
        (object) "Molniya",
        (object) "Circular",
        (object) "Geosynchronous"
      });
      ComboBox searchTypeList1 = this.SEARCH_TypeList;
      point1 = new Point(6, 19);
      Point point13 = point1;
      searchTypeList1.Location = point13;
      this.SEARCH_TypeList.Name = "SEARCH_TypeList";
      ComboBox searchTypeList2 = this.SEARCH_TypeList;
      size1 = new Size(143, 21);
      Size size13 = size1;
      searchTypeList2.Size = size13;
      this.SEARCH_TypeList.TabIndex = 2;
      this.SEARCH_ByType.AutoSize = true;
      RadioButton searchByType1 = this.SEARCH_ByType;
      point1 = new Point(9, 144);
      Point point14 = point1;
      searchByType1.Location = point14;
      this.SEARCH_ByType.Name = "SEARCH_ByType";
      RadioButton searchByType2 = this.SEARCH_ByType;
      size1 = new Size(86, 17);
      Size size14 = size1;
      searchByType2.Size = size14;
      this.SEARCH_ByType.TabIndex = 1;
      this.SEARCH_ByType.Text = "Type of Orbit";
      this.SEARCH_ByType.UseVisualStyleBackColor = true;
      this.SearchResult.AutoSize = true;
      Label searchResult1 = this.SearchResult;
      point1 = new Point(188, 235);
      Point point15 = point1;
      searchResult1.Location = point15;
      this.SearchResult.Name = "SearchResult";
      Label searchResult2 = this.SearchResult;
      size1 = new Size(0, 13);
      Size size15 = size1;
      searchResult2.Size = size15;
      this.SearchResult.TabIndex = 74;
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_Period);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_ECC);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_INC);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_PEA);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_APA);
      this.SearchByParGrp.Controls.Add((Control) this.Label13);
      this.SearchByParGrp.Controls.Add((Control) this.Label11);
      this.SearchByParGrp.Controls.Add((Control) this.Label10);
      this.SearchByParGrp.Controls.Add((Control) this.Label9);
      this.SearchByParGrp.Controls.Add((Control) this.Label5);
      this.SearchByParGrp.Controls.Add((Control) this.Label4);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_PERMAX);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_PERMIN);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_ECCMAX);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_INCMAX);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_ECCMIN);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_INCMIN);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_PEAMAX);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_PEAMIN);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_APAMAX);
      this.SearchByParGrp.Controls.Add((Control) this.SEARCH_APAMIN);
      GroupBox searchByParGrp1 = this.SearchByParGrp;
      point1 = new Point(188, 28);
      Point point16 = point1;
      searchByParGrp1.Location = point16;
      this.SearchByParGrp.Name = "SearchByParGrp";
      GroupBox searchByParGrp2 = this.SearchByParGrp;
      size1 = new Size(309, 163);
      Size size16 = size1;
      searchByParGrp2.Size = size16;
      this.SearchByParGrp.TabIndex = 75;
      this.SearchByParGrp.TabStop = false;
      this.SEARCH_Period.AutoSize = true;
      CheckBox searchPeriod1 = this.SEARCH_Period;
      point1 = new Point(15, 138);
      Point point17 = point1;
      searchPeriod1.Location = point17;
      this.SEARCH_Period.Name = "SEARCH_Period";
      CheckBox searchPeriod2 = this.SEARCH_Period;
      size1 = new Size(56, 17);
      Size size17 = size1;
      searchPeriod2.Size = size17;
      this.SEARCH_Period.TabIndex = 104;
      this.SEARCH_Period.Text = "Period";
      this.SEARCH_Period.UseVisualStyleBackColor = true;
      this.SEARCH_ECC.AutoSize = true;
      CheckBox searchEcc1 = this.SEARCH_ECC;
      point1 = new Point(15, 112);
      Point point18 = point1;
      searchEcc1.Location = point18;
      this.SEARCH_ECC.Name = "SEARCH_ECC";
      CheckBox searchEcc2 = this.SEARCH_ECC;
      size1 = new Size(47, 17);
      Size size18 = size1;
      searchEcc2.Size = size18;
      this.SEARCH_ECC.TabIndex = 104;
      this.SEARCH_ECC.Text = "ECC";
      this.SEARCH_ECC.UseVisualStyleBackColor = true;
      this.SEARCH_INC.AutoSize = true;
      CheckBox searchInc1 = this.SEARCH_INC;
      point1 = new Point(15, 86);
      Point point19 = point1;
      searchInc1.Location = point19;
      this.SEARCH_INC.Name = "SEARCH_INC";
      CheckBox searchInc2 = this.SEARCH_INC;
      size1 = new Size(44, 17);
      Size size19 = size1;
      searchInc2.Size = size19;
      this.SEARCH_INC.TabIndex = 103;
      this.SEARCH_INC.Text = "INC";
      this.SEARCH_INC.UseVisualStyleBackColor = true;
      this.SEARCH_PEA.AutoSize = true;
      CheckBox searchPea1 = this.SEARCH_PEA;
      point1 = new Point(15, 60);
      Point point20 = point1;
      searchPea1.Location = point20;
      this.SEARCH_PEA.Name = "SEARCH_PEA";
      CheckBox searchPea2 = this.SEARCH_PEA;
      size1 = new Size(46, 17);
      Size size20 = size1;
      searchPea2.Size = size20;
      this.SEARCH_PEA.TabIndex = 102;
      this.SEARCH_PEA.Text = "PeA";
      this.SEARCH_PEA.UseVisualStyleBackColor = true;
      this.SEARCH_APA.AutoSize = true;
      CheckBox searchApa1 = this.SEARCH_APA;
      point1 = new Point(15, 34);
      Point point21 = point1;
      searchApa1.Location = point21;
      this.SEARCH_APA.Name = "SEARCH_APA";
      CheckBox searchApa2 = this.SEARCH_APA;
      size1 = new Size(46, 17);
      Size size21 = size1;
      searchApa2.Size = size21;
      this.SEARCH_APA.TabIndex = 101;
      this.SEARCH_APA.Text = "ApA";
      this.SEARCH_APA.UseVisualStyleBackColor = true;
      this.Label13.AutoSize = true;
      Label label13_1 = this.Label13;
      point1 = new Point(213, 139);
      Point point22 = point1;
      label13_1.Location = point22;
      this.Label13.Name = "Label13";
      Label label13_2 = this.Label13;
      size1 = new Size(23, 13);
      Size size22 = size1;
      label13_2.Size = size22;
      this.Label13.TabIndex = 100;
      this.Label13.Text = "min";
      this.Label11.AutoSize = true;
      Label label11_1 = this.Label11;
      point1 = new Point(213, 87);
      Point point23 = point1;
      label11_1.Location = point23;
      this.Label11.Name = "Label11";
      Label label11_2 = this.Label11;
      size1 = new Size(25, 13);
      Size size23 = size1;
      label11_2.Size = size23;
      this.Label11.TabIndex = 99;
      this.Label11.Text = "deg";
      this.Label10.AutoSize = true;
      Label label10_1 = this.Label10;
      point1 = new Point(213, 61);
      Point point24 = point1;
      label10_1.Location = point24;
      this.Label10.Name = "Label10";
      Label label10_2 = this.Label10;
      size1 = new Size(21, 13);
      Size size24 = size1;
      label10_2.Size = size24;
      this.Label10.TabIndex = 98;
      this.Label10.Text = "km";
      this.Label9.AutoSize = true;
      Label label9_1 = this.Label9;
      point1 = new Point(213, 35);
      Point point25 = point1;
      label9_1.Location = point25;
      this.Label9.Name = "Label9";
      Label label9_2 = this.Label9;
      size1 = new Size(21, 13);
      Size size25 = size1;
      label9_2.Size = size25;
      this.Label9.TabIndex = 97;
      this.Label9.Text = "km";
      this.Label5.AutoSize = true;
      Label label5_1 = this.Label5;
      point1 = new Point(162, 15);
      Point point26 = point1;
      label5_1.Location = point26;
      this.Label5.Name = "Label5";
      Label label5_2 = this.Label5;
      size1 = new Size(27, 13);
      Size size26 = size1;
      label5_2.Size = size26;
      this.Label5.TabIndex = 96;
      this.Label5.Text = "Max";
      this.Label4.AutoSize = true;
      Label label4_1 = this.Label4;
      point1 = new Point(94, 15);
      Point point27 = point1;
      label4_1.Location = point27;
      this.Label4.Name = "Label4";
      Label label4_2 = this.Label4;
      size1 = new Size(24, 13);
      Size size27 = size1;
      label4_2.Size = size27;
      this.Label4.TabIndex = 95;
      this.Label4.Text = "Min";
      this.SEARCH_PERMAX.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_PERMAX.Enabled = false;
      TextBox searchPermax1 = this.SEARCH_PERMAX;
      point1 = new Point(147, 136);
      Point point28 = point1;
      searchPermax1.Location = point28;
      this.SEARCH_PERMAX.MaxLength = 5;
      this.SEARCH_PERMAX.Name = "SEARCH_PERMAX";
      TextBox searchPermax2 = this.SEARCH_PERMAX;
      size1 = new Size(60, 20);
      Size size28 = size1;
      searchPermax2.Size = size28;
      this.SEARCH_PERMAX.TabIndex = 94;
      this.SEARCH_PERMAX.Text = "99999";
      this.SEARCH_PERMIN.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_PERMIN.Enabled = false;
      TextBox searchPermin1 = this.SEARCH_PERMIN;
      point1 = new Point(77, 136);
      Point point29 = point1;
      searchPermin1.Location = point29;
      this.SEARCH_PERMIN.MaxLength = 5;
      this.SEARCH_PERMIN.Name = "SEARCH_PERMIN";
      TextBox searchPermin2 = this.SEARCH_PERMIN;
      size1 = new Size(64, 20);
      Size size29 = size1;
      searchPermin2.Size = size29;
      this.SEARCH_PERMIN.TabIndex = 92;
      this.SEARCH_PERMIN.Text = "0";
      this.SEARCH_ECCMAX.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_ECCMAX.Enabled = false;
      TextBox searchEccmax1 = this.SEARCH_ECCMAX;
      point1 = new Point(147, 110);
      Point point30 = point1;
      searchEccmax1.Location = point30;
      this.SEARCH_ECCMAX.MaxLength = 7;
      this.SEARCH_ECCMAX.Name = "SEARCH_ECCMAX";
      TextBox searchEccmax2 = this.SEARCH_ECCMAX;
      size1 = new Size(60, 20);
      Size size30 = size1;
      searchEccmax2.Size = size30;
      this.SEARCH_ECCMAX.TabIndex = 90;
      this.SEARCH_ECCMAX.Text = "1.00000";
      this.SEARCH_INCMAX.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_INCMAX.Enabled = false;
      TextBox searchIncmax1 = this.SEARCH_INCMAX;
      point1 = new Point(147, 84);
      Point point31 = point1;
      searchIncmax1.Location = point31;
      this.SEARCH_INCMAX.MaxLength = 3;
      this.SEARCH_INCMAX.Name = "SEARCH_INCMAX";
      TextBox searchIncmax2 = this.SEARCH_INCMAX;
      size1 = new Size(60, 20);
      Size size31 = size1;
      searchIncmax2.Size = size31;
      this.SEARCH_INCMAX.TabIndex = 88;
      this.SEARCH_INCMAX.Text = "180";
      this.SEARCH_ECCMIN.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_ECCMIN.Enabled = false;
      TextBox searchEccmin1 = this.SEARCH_ECCMIN;
      point1 = new Point(77, 110);
      Point point32 = point1;
      searchEccmin1.Location = point32;
      this.SEARCH_ECCMIN.MaxLength = 7;
      this.SEARCH_ECCMIN.Name = "SEARCH_ECCMIN";
      TextBox searchEccmin2 = this.SEARCH_ECCMIN;
      size1 = new Size(64, 20);
      Size size32 = size1;
      searchEccmin2.Size = size32;
      this.SEARCH_ECCMIN.TabIndex = 86;
      this.SEARCH_ECCMIN.Text = "0.00000";
      this.SEARCH_INCMIN.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_INCMIN.Enabled = false;
      TextBox searchIncmin1 = this.SEARCH_INCMIN;
      point1 = new Point(77, 84);
      Point point33 = point1;
      searchIncmin1.Location = point33;
      this.SEARCH_INCMIN.MaxLength = 3;
      this.SEARCH_INCMIN.Name = "SEARCH_INCMIN";
      TextBox searchIncmin2 = this.SEARCH_INCMIN;
      size1 = new Size(64, 20);
      Size size33 = size1;
      searchIncmin2.Size = size33;
      this.SEARCH_INCMIN.TabIndex = 84;
      this.SEARCH_INCMIN.Text = "0";
      this.SEARCH_PEAMAX.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_PEAMAX.Enabled = false;
      TextBox searchPeamax1 = this.SEARCH_PEAMAX;
      point1 = new Point(147, 58);
      Point point34 = point1;
      searchPeamax1.Location = point34;
      this.SEARCH_PEAMAX.MaxLength = 5;
      this.SEARCH_PEAMAX.Name = "SEARCH_PEAMAX";
      TextBox searchPeamax2 = this.SEARCH_PEAMAX;
      size1 = new Size(60, 20);
      Size size34 = size1;
      searchPeamax2.Size = size34;
      this.SEARCH_PEAMAX.TabIndex = 82;
      this.SEARCH_PEAMAX.Text = "99999";
      this.SEARCH_PEAMIN.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_PEAMIN.Enabled = false;
      TextBox searchPeamin1 = this.SEARCH_PEAMIN;
      point1 = new Point(77, 58);
      Point point35 = point1;
      searchPeamin1.Location = point35;
      this.SEARCH_PEAMIN.MaxLength = 5;
      this.SEARCH_PEAMIN.Name = "SEARCH_PEAMIN";
      TextBox searchPeamin2 = this.SEARCH_PEAMIN;
      size1 = new Size(64, 20);
      Size size35 = size1;
      searchPeamin2.Size = size35;
      this.SEARCH_PEAMIN.TabIndex = 80;
      this.SEARCH_PEAMIN.Text = "0";
      this.SEARCH_APAMAX.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_APAMAX.Enabled = false;
      TextBox searchApamax1 = this.SEARCH_APAMAX;
      point1 = new Point(147, 32);
      Point point36 = point1;
      searchApamax1.Location = point36;
      this.SEARCH_APAMAX.MaxLength = 6;
      this.SEARCH_APAMAX.Name = "SEARCH_APAMAX";
      TextBox searchApamax2 = this.SEARCH_APAMAX;
      size1 = new Size(60, 20);
      Size size36 = size1;
      searchApamax2.Size = size36;
      this.SEARCH_APAMAX.TabIndex = 78;
      this.SEARCH_APAMAX.Text = "999999";
      this.SEARCH_APAMIN.CharacterCasing = CharacterCasing.Upper;
      this.SEARCH_APAMIN.Enabled = false;
      TextBox searchApamin1 = this.SEARCH_APAMIN;
      point1 = new Point(77, 32);
      Point point37 = point1;
      searchApamin1.Location = point37;
      this.SEARCH_APAMIN.MaxLength = 6;
      this.SEARCH_APAMIN.Name = "SEARCH_APAMIN";
      TextBox searchApamin2 = this.SEARCH_APAMIN;
      size1 = new Size(64, 20);
      Size size37 = size1;
      searchApamin2.Size = size37;
      this.SEARCH_APAMIN.TabIndex = 76;
      this.SEARCH_APAMIN.Text = "0";
      this.SEARCH_ByPar.AutoSize = true;
      RadioButton searchByPar1 = this.SEARCH_ByPar;
      point1 = new Point(188, 6);
      Point point38 = point1;
      searchByPar1.Location = point38;
      this.SEARCH_ByPar.Name = "SEARCH_ByPar";
      RadioButton searchByPar2 = this.SEARCH_ByPar;
      size1 = new Size(78, 17);
      Size size38 = size1;
      searchByPar2.Size = size38;
      this.SEARCH_ByPar.TabIndex = 76;
      this.SEARCH_ByPar.Text = "Parameters";
      this.SEARCH_ByPar.UseVisualStyleBackColor = true;
      Button searchSearch1 = this.SEARCH_Search;
      point1 = new Point(294, 206);
      Point point39 = point1;
      searchSearch1.Location = point39;
      this.SEARCH_Search.Name = "SEARCH_Search";
      Button searchSearch2 = this.SEARCH_Search;
      size1 = new Size(75, 23);
      Size size39 = size1;
      searchSearch2.Size = size39;
      this.SEARCH_Search.TabIndex = 77;
      this.SEARCH_Search.Text = nameof (Search);
      this.SEARCH_Search.UseVisualStyleBackColor = true;
      Button searchClose1 = this.SEARCH_Close;
      point1 = new Point(444, 491);
      Point point40 = point1;
      searchClose1.Location = point40;
      this.SEARCH_Close.Name = "SEARCH_Close";
      Button searchClose2 = this.SEARCH_Close;
      size1 = new Size(75, 23);
      Size size40 = size1;
      searchClose2.Size = size40;
      this.SEARCH_Close.TabIndex = 78;
      this.SEARCH_Close.Text = "Close";
      this.SEARCH_Close.UseVisualStyleBackColor = true;
      this.TabControl1.Controls.Add((Control) this.TabPage1);
      this.TabControl1.Controls.Add((Control) this.TabPage2);
      TabControl tabControl1_1 = this.TabControl1;
      point1 = new Point(12, 12);
      Point point41 = point1;
      tabControl1_1.Location = point41;
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      TabControl tabControl1_2 = this.TabControl1;
      size1 = new Size(511, 473);
      Size size41 = size1;
      tabControl1_2.Size = size41;
      this.TabControl1.TabIndex = 79;
      this.TabPage1.BackColor = SystemColors.Control;
      this.TabPage1.Controls.Add((Control) this.SEARCH_ByPar);
      this.TabPage1.Controls.Add((Control) this.SearchByNameGrp);
      this.TabPage1.Controls.Add((Control) this.SEARCH_Search);
      this.TabPage1.Controls.Add((Control) this.SEARCH_ByType);
      this.TabPage1.Controls.Add((Control) this.SearchByTypeGrp);
      this.TabPage1.Controls.Add((Control) this.SearchByParGrp);
      this.TabPage1.Controls.Add((Control) this.SEARCH_ByName);
      this.TabPage1.Controls.Add((Control) this.SearchResult);
      TabPage tabPage1_1 = this.TabPage1;
      point1 = new Point(4, 22);
      Point point42 = point1;
      tabPage1_1.Location = point42;
      this.TabPage1.Name = "TabPage1";
      TabPage tabPage1_2 = this.TabPage1;
      Padding padding1 = new Padding(3);
      Padding padding2 = padding1;
      tabPage1_2.Padding = padding2;
      TabPage tabPage1_3 = this.TabPage1;
      size1 = new Size(503, 447);
      Size size42 = size1;
      tabPage1_3.Size = size42;
      this.TabPage1.TabIndex = 0;
      this.TabPage1.Text = "Collections";
      this.TabPage2.BackColor = SystemColors.Control;
      this.TabPage2.Controls.Add((Control) this.SFC_CountLabel);
      this.TabPage2.Controls.Add((Control) this.SFC_Import);
      this.TabPage2.Controls.Add((Control) this.GroupBox2);
      this.TabPage2.Controls.Add((Control) this.SFC_TextBox);
      this.TabPage2.Controls.Add((Control) this.SFC_SatListBox);
      this.TabPage2.Controls.Add((Control) this.GroupBox1);
      TabPage tabPage2_1 = this.TabPage2;
      point1 = new Point(4, 22);
      Point point43 = point1;
      tabPage2_1.Location = point43;
      this.TabPage2.Name = "TabPage2";
      TabPage tabPage2_2 = this.TabPage2;
      padding1 = new Padding(3);
      Padding padding3 = padding1;
      tabPage2_2.Padding = padding3;
      TabPage tabPage2_3 = this.TabPage2;
      size1 = new Size(503, 447);
      Size size43 = size1;
      tabPage2_3.Size = size43;
      this.TabPage2.TabIndex = 1;
      this.TabPage2.Text = "Full Catalog";
      this.SFC_CountLabel.AutoSize = true;
      Label sfcCountLabel1 = this.SFC_CountLabel;
      point1 = new Point(12, 419);
      Point point44 = point1;
      sfcCountLabel1.Location = point44;
      this.SFC_CountLabel.Name = "SFC_CountLabel";
      Label sfcCountLabel2 = this.SFC_CountLabel;
      size1 = new Size(0, 13);
      Size size44 = size1;
      sfcCountLabel2.Size = size44;
      this.SFC_CountLabel.TabIndex = 82;
      this.SFC_Import.Enabled = false;
      Button sfcImport1 = this.SFC_Import;
      point1 = new Point(216, 413);
      Point point45 = point1;
      sfcImport1.Location = point45;
      this.SFC_Import.Name = "SFC_Import";
      Button sfcImport2 = this.SFC_Import;
      size1 = new Size(75, 25);
      Size size45 = size1;
      sfcImport2.Size = size45;
      this.SFC_Import.TabIndex = 81;
      this.SFC_Import.Text = "Import TLE";
      this.SFC_Import.UseVisualStyleBackColor = true;
      this.GroupBox2.Controls.Add((Control) this.SFC_Collection);
      this.GroupBox2.Controls.Add((Control) this.Label105);
      this.GroupBox2.Controls.Add((Control) this.SFC_Inclination);
      this.GroupBox2.Controls.Add((Control) this.Label26);
      this.GroupBox2.Controls.Add((Control) this.SFC_Period);
      this.GroupBox2.Controls.Add((Control) this.Label25);
      this.GroupBox2.Controls.Add((Control) this.Label15);
      this.GroupBox2.Controls.Add((Control) this.SFC_AltNameBox);
      this.GroupBox2.Controls.Add((Control) this.SFC_Periapsis);
      this.GroupBox2.Controls.Add((Control) this.Label24);
      this.GroupBox2.Controls.Add((Control) this.SFC_Apoapsis);
      this.GroupBox2.Controls.Add((Control) this.Label23);
      this.GroupBox2.Controls.Add((Control) this.SFC_ObjectType);
      this.GroupBox2.Controls.Add((Control) this.Label22);
      this.GroupBox2.Controls.Add((Control) this.SFC_DecayDateBox);
      this.GroupBox2.Controls.Add((Control) this.Label21);
      this.GroupBox2.Controls.Add((Control) this.SFC_LaunchSiteBox);
      this.GroupBox2.Controls.Add((Control) this.Label20);
      this.GroupBox2.Controls.Add((Control) this.SFC_LaunchDateBox);
      this.GroupBox2.Controls.Add((Control) this.Label19);
      this.GroupBox2.Controls.Add((Control) this.SFC_OwnerBox);
      this.GroupBox2.Controls.Add((Control) this.Label18);
      this.GroupBox2.Controls.Add((Control) this.SFC_NameBox);
      this.GroupBox2.Controls.Add((Control) this.Label17);
      this.GroupBox2.Controls.Add((Control) this.SFC_StatusBox);
      this.GroupBox2.Controls.Add((Control) this.Label16);
      this.GroupBox2.Controls.Add((Control) this.SFC_NoradIdBox);
      this.GroupBox2.Controls.Add((Control) this.Label14);
      this.GroupBox2.Controls.Add((Control) this.SFC_IntDesBox);
      this.GroupBox2.Controls.Add((Control) this.Label12);
      GroupBox groupBox2_1 = this.GroupBox2;
      point1 = new Point(6, 190);
      Point point46 = point1;
      groupBox2_1.Location = point46;
      this.GroupBox2.Name = "GroupBox2";
      GroupBox groupBox2_2 = this.GroupBox2;
      size1 = new Size(489, 164);
      Size size46 = size1;
      groupBox2_2.Size = size46;
      this.GroupBox2.TabIndex = 14;
      this.GroupBox2.TabStop = false;
      this.SFC_Collection.BackColor = SystemColors.Control;
      this.SFC_Collection.BorderStyle = BorderStyle.None;
      this.SFC_Collection.ForeColor = Color.Black;
      TextBox sfcCollection1 = this.SFC_Collection;
      point1 = new Point(81, 142);
      Point point47 = point1;
      sfcCollection1.Location = point47;
      this.SFC_Collection.Name = "SFC_Collection";
      this.SFC_Collection.ReadOnly = true;
      TextBox sfcCollection2 = this.SFC_Collection;
      size1 = new Size(402, 13);
      Size size47 = size1;
      sfcCollection2.Size = size47;
      this.SFC_Collection.TabIndex = 41;
      this.SFC_Collection.TabStop = false;
      this.Label105.AutoSize = true;
      this.Label105.BackColor = SystemColors.Control;
      this.Label105.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label105.ForeColor = Color.Black;
      this.Label105.ImeMode = ImeMode.NoControl;
      Label label105_1 = this.Label105;
      point1 = new Point(6, 142);
      Point point48 = point1;
      label105_1.Location = point48;
      this.Label105.Name = "Label105";
      Label label105_2 = this.Label105;
      size1 = new Size(53, 13);
      Size size48 = size1;
      label105_2.Size = size48;
      this.Label105.TabIndex = 40;
      this.Label105.Text = "Collection";
      this.SFC_Inclination.BackColor = SystemColors.Control;
      this.SFC_Inclination.BorderStyle = BorderStyle.None;
      this.SFC_Inclination.ForeColor = Color.Black;
      TextBox sfcInclination1 = this.SFC_Inclination;
      point1 = new Point(263, 70);
      Point point49 = point1;
      sfcInclination1.Location = point49;
      this.SFC_Inclination.Name = "SFC_Inclination";
      this.SFC_Inclination.ReadOnly = true;
      TextBox sfcInclination2 = this.SFC_Inclination;
      size1 = new Size(220, 13);
      Size size49 = size1;
      sfcInclination2.Size = size49;
      this.SFC_Inclination.TabIndex = 39;
      this.SFC_Inclination.TabStop = false;
      this.Label26.AutoSize = true;
      this.Label26.BackColor = SystemColors.Control;
      this.Label26.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label26.ForeColor = Color.Black;
      this.Label26.ImeMode = ImeMode.NoControl;
      Label label26_1 = this.Label26;
      point1 = new Point(188, 70);
      Point point50 = point1;
      label26_1.Location = point50;
      this.Label26.Name = "Label26";
      Label label26_2 = this.Label26;
      size1 = new Size(55, 13);
      Size size50 = size1;
      label26_2.Size = size50;
      this.Label26.TabIndex = 38;
      this.Label26.Text = "Inclination";
      this.SFC_Period.BackColor = SystemColors.Control;
      this.SFC_Period.BorderStyle = BorderStyle.None;
      this.SFC_Period.ForeColor = Color.Black;
      TextBox sfcPeriod1 = this.SFC_Period;
      point1 = new Point(263, 52);
      Point point51 = point1;
      sfcPeriod1.Location = point51;
      this.SFC_Period.Name = "SFC_Period";
      this.SFC_Period.ReadOnly = true;
      TextBox sfcPeriod2 = this.SFC_Period;
      size1 = new Size(220, 13);
      Size size51 = size1;
      sfcPeriod2.Size = size51;
      this.SFC_Period.TabIndex = 37;
      this.SFC_Period.TabStop = false;
      this.Label25.AutoSize = true;
      this.Label25.BackColor = SystemColors.Control;
      this.Label25.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label25.ForeColor = Color.Black;
      this.Label25.ImeMode = ImeMode.NoControl;
      Label label25_1 = this.Label25;
      point1 = new Point(188, 52);
      Point point52 = point1;
      label25_1.Location = point52;
      this.Label25.Name = "Label25";
      Label label25_2 = this.Label25;
      size1 = new Size(37, 13);
      Size size52 = size1;
      label25_2.Size = size52;
      this.Label25.TabIndex = 36;
      this.Label25.Text = "Period";
      this.Label15.AutoSize = true;
      this.Label15.BackColor = SystemColors.Control;
      this.Label15.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label15.ForeColor = Color.Black;
      this.Label15.ImeMode = ImeMode.NoControl;
      Label label15_1 = this.Label15;
      point1 = new Point(188, 106);
      Point point53 = point1;
      label15_1.Location = point53;
      this.Label15.Name = "Label15";
      Label label15_2 = this.Label15;
      size1 = new Size(53, 13);
      Size size53 = size1;
      label15_2.Size = size53;
      this.Label15.TabIndex = 16;
      this.Label15.Text = "Alt. Name";
      this.SFC_AltNameBox.BackColor = SystemColors.Control;
      this.SFC_AltNameBox.BorderStyle = BorderStyle.None;
      this.SFC_AltNameBox.ForeColor = Color.Black;
      TextBox sfcAltNameBox1 = this.SFC_AltNameBox;
      point1 = new Point(263, 106);
      Point point54 = point1;
      sfcAltNameBox1.Location = point54;
      this.SFC_AltNameBox.Name = "SFC_AltNameBox";
      this.SFC_AltNameBox.ReadOnly = true;
      TextBox sfcAltNameBox2 = this.SFC_AltNameBox;
      size1 = new Size(220, 13);
      Size size54 = size1;
      sfcAltNameBox2.Size = size54;
      this.SFC_AltNameBox.TabIndex = 17;
      this.SFC_AltNameBox.TabStop = false;
      this.SFC_Periapsis.BackColor = SystemColors.Control;
      this.SFC_Periapsis.BorderStyle = BorderStyle.None;
      this.SFC_Periapsis.ForeColor = Color.Black;
      TextBox sfcPeriapsis1 = this.SFC_Periapsis;
      point1 = new Point(263, 34);
      Point point55 = point1;
      sfcPeriapsis1.Location = point55;
      this.SFC_Periapsis.Name = "SFC_Periapsis";
      this.SFC_Periapsis.ReadOnly = true;
      TextBox sfcPeriapsis2 = this.SFC_Periapsis;
      size1 = new Size(220, 13);
      Size size55 = size1;
      sfcPeriapsis2.Size = size55;
      this.SFC_Periapsis.TabIndex = 35;
      this.SFC_Periapsis.TabStop = false;
      this.Label24.AutoSize = true;
      this.Label24.BackColor = SystemColors.Control;
      this.Label24.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label24.ForeColor = Color.Black;
      this.Label24.ImeMode = ImeMode.NoControl;
      Label label24_1 = this.Label24;
      point1 = new Point(188, 34);
      Point point56 = point1;
      label24_1.Location = point56;
      this.Label24.Name = "Label24";
      Label label24_2 = this.Label24;
      size1 = new Size(49, 13);
      Size size56 = size1;
      label24_2.Size = size56;
      this.Label24.TabIndex = 34;
      this.Label24.Text = "Periapsis";
      this.SFC_Apoapsis.BackColor = SystemColors.Control;
      this.SFC_Apoapsis.BorderStyle = BorderStyle.None;
      this.SFC_Apoapsis.ForeColor = Color.Black;
      TextBox sfcApoapsis1 = this.SFC_Apoapsis;
      point1 = new Point(263, 16);
      Point point57 = point1;
      sfcApoapsis1.Location = point57;
      this.SFC_Apoapsis.Name = "SFC_Apoapsis";
      this.SFC_Apoapsis.ReadOnly = true;
      TextBox sfcApoapsis2 = this.SFC_Apoapsis;
      size1 = new Size(220, 13);
      Size size57 = size1;
      sfcApoapsis2.Size = size57;
      this.SFC_Apoapsis.TabIndex = 33;
      this.SFC_Apoapsis.TabStop = false;
      this.Label23.AutoSize = true;
      this.Label23.BackColor = SystemColors.Control;
      this.Label23.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label23.ForeColor = Color.Black;
      this.Label23.ImeMode = ImeMode.NoControl;
      Label label23_1 = this.Label23;
      point1 = new Point(188, 16);
      Point point58 = point1;
      label23_1.Location = point58;
      this.Label23.Name = "Label23";
      Label label23_2 = this.Label23;
      size1 = new Size(50, 13);
      Size size58 = size1;
      label23_2.Size = size58;
      this.Label23.TabIndex = 32;
      this.Label23.Text = "Apoapsis";
      this.SFC_ObjectType.BackColor = SystemColors.Control;
      this.SFC_ObjectType.BorderStyle = BorderStyle.None;
      this.SFC_ObjectType.ForeColor = Color.Black;
      TextBox sfcObjectType1 = this.SFC_ObjectType;
      point1 = new Point(81, 34);
      Point point59 = point1;
      sfcObjectType1.Location = point59;
      this.SFC_ObjectType.Name = "SFC_ObjectType";
      this.SFC_ObjectType.ReadOnly = true;
      TextBox sfcObjectType2 = this.SFC_ObjectType;
      size1 = new Size(101, 13);
      Size size59 = size1;
      sfcObjectType2.Size = size59;
      this.SFC_ObjectType.TabIndex = 31;
      this.SFC_ObjectType.TabStop = false;
      this.Label22.AutoSize = true;
      this.Label22.BackColor = SystemColors.Control;
      this.Label22.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label22.ForeColor = Color.Black;
      this.Label22.ImeMode = ImeMode.NoControl;
      Label label22_1 = this.Label22;
      point1 = new Point(6, 34);
      Point point60 = point1;
      label22_1.Location = point60;
      this.Label22.Name = "Label22";
      Label label22_2 = this.Label22;
      size1 = new Size(65, 13);
      Size size60 = size1;
      label22_2.Size = size60;
      this.Label22.TabIndex = 30;
      this.Label22.Text = "Object Type";
      this.SFC_DecayDateBox.BackColor = SystemColors.Control;
      this.SFC_DecayDateBox.BorderStyle = BorderStyle.None;
      this.SFC_DecayDateBox.ForeColor = Color.Black;
      TextBox sfcDecayDateBox1 = this.SFC_DecayDateBox;
      point1 = new Point(81, 124);
      Point point61 = point1;
      sfcDecayDateBox1.Location = point61;
      this.SFC_DecayDateBox.Name = "SFC_DecayDateBox";
      this.SFC_DecayDateBox.ReadOnly = true;
      TextBox sfcDecayDateBox2 = this.SFC_DecayDateBox;
      size1 = new Size(101, 13);
      Size size61 = size1;
      sfcDecayDateBox2.Size = size61;
      this.SFC_DecayDateBox.TabIndex = 29;
      this.SFC_DecayDateBox.TabStop = false;
      this.Label21.AutoSize = true;
      this.Label21.BackColor = SystemColors.Control;
      this.Label21.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label21.ForeColor = Color.Black;
      this.Label21.ImeMode = ImeMode.NoControl;
      Label label21_1 = this.Label21;
      point1 = new Point(6, 124);
      Point point62 = point1;
      label21_1.Location = point62;
      this.Label21.Name = "Label21";
      Label label21_2 = this.Label21;
      size1 = new Size(64, 13);
      Size size62 = size1;
      label21_2.Size = size62;
      this.Label21.TabIndex = 28;
      this.Label21.Text = "Decay Date";
      this.SFC_LaunchSiteBox.BackColor = SystemColors.Control;
      this.SFC_LaunchSiteBox.BorderStyle = BorderStyle.None;
      this.SFC_LaunchSiteBox.ForeColor = Color.Black;
      TextBox sfcLaunchSiteBox1 = this.SFC_LaunchSiteBox;
      point1 = new Point(263, 88);
      Point point63 = point1;
      sfcLaunchSiteBox1.Location = point63;
      this.SFC_LaunchSiteBox.Name = "SFC_LaunchSiteBox";
      this.SFC_LaunchSiteBox.ReadOnly = true;
      TextBox sfcLaunchSiteBox2 = this.SFC_LaunchSiteBox;
      size1 = new Size(220, 13);
      Size size63 = size1;
      sfcLaunchSiteBox2.Size = size63;
      this.SFC_LaunchSiteBox.TabIndex = 27;
      this.SFC_LaunchSiteBox.TabStop = false;
      this.Label20.AutoSize = true;
      this.Label20.BackColor = SystemColors.Control;
      this.Label20.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label20.ForeColor = Color.Black;
      this.Label20.ImeMode = ImeMode.NoControl;
      Label label20_1 = this.Label20;
      point1 = new Point(188, 88);
      Point point64 = point1;
      label20_1.Location = point64;
      this.Label20.Name = "Label20";
      Label label20_2 = this.Label20;
      size1 = new Size(64, 13);
      Size size64 = size1;
      label20_2.Size = size64;
      this.Label20.TabIndex = 26;
      this.Label20.Text = "Launch Site";
      this.SFC_LaunchDateBox.BackColor = SystemColors.Control;
      this.SFC_LaunchDateBox.BorderStyle = BorderStyle.None;
      this.SFC_LaunchDateBox.ForeColor = Color.Black;
      TextBox sfcLaunchDateBox1 = this.SFC_LaunchDateBox;
      point1 = new Point(81, 88);
      Point point65 = point1;
      sfcLaunchDateBox1.Location = point65;
      this.SFC_LaunchDateBox.Name = "SFC_LaunchDateBox";
      this.SFC_LaunchDateBox.ReadOnly = true;
      TextBox sfcLaunchDateBox2 = this.SFC_LaunchDateBox;
      size1 = new Size(101, 13);
      Size size65 = size1;
      sfcLaunchDateBox2.Size = size65;
      this.SFC_LaunchDateBox.TabIndex = 25;
      this.SFC_LaunchDateBox.TabStop = false;
      this.Label19.AutoSize = true;
      this.Label19.BackColor = SystemColors.Control;
      this.Label19.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label19.ForeColor = Color.Black;
      this.Label19.ImeMode = ImeMode.NoControl;
      Label label19_1 = this.Label19;
      point1 = new Point(6, 88);
      Point point66 = point1;
      label19_1.Location = point66;
      this.Label19.Name = "Label19";
      Label label19_2 = this.Label19;
      size1 = new Size(69, 13);
      Size size66 = size1;
      label19_2.Size = size66;
      this.Label19.TabIndex = 24;
      this.Label19.Text = "Launch Date";
      this.SFC_OwnerBox.BackColor = SystemColors.Control;
      this.SFC_OwnerBox.BorderStyle = BorderStyle.None;
      this.SFC_OwnerBox.ForeColor = Color.Black;
      TextBox sfcOwnerBox1 = this.SFC_OwnerBox;
      point1 = new Point(263, 124);
      Point point67 = point1;
      sfcOwnerBox1.Location = point67;
      this.SFC_OwnerBox.Name = "SFC_OwnerBox";
      this.SFC_OwnerBox.ReadOnly = true;
      TextBox sfcOwnerBox2 = this.SFC_OwnerBox;
      size1 = new Size(220, 13);
      Size size67 = size1;
      sfcOwnerBox2.Size = size67;
      this.SFC_OwnerBox.TabIndex = 23;
      this.SFC_OwnerBox.TabStop = false;
      this.Label18.AutoSize = true;
      this.Label18.BackColor = SystemColors.Control;
      this.Label18.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label18.ForeColor = Color.Black;
      this.Label18.ImeMode = ImeMode.NoControl;
      Label label18_1 = this.Label18;
      point1 = new Point(188, 124);
      Point point68 = point1;
      label18_1.Location = point68;
      this.Label18.Name = "Label18";
      Label label18_2 = this.Label18;
      size1 = new Size(38, 13);
      Size size68 = size1;
      label18_2.Size = size68;
      this.Label18.TabIndex = 22;
      this.Label18.Text = "Owner";
      this.SFC_NameBox.BackColor = SystemColors.Control;
      this.SFC_NameBox.BorderStyle = BorderStyle.None;
      this.SFC_NameBox.ForeColor = Color.Black;
      TextBox sfcNameBox1 = this.SFC_NameBox;
      point1 = new Point(81, 16);
      Point point69 = point1;
      sfcNameBox1.Location = point69;
      this.SFC_NameBox.Name = "SFC_NameBox";
      this.SFC_NameBox.ReadOnly = true;
      TextBox sfcNameBox2 = this.SFC_NameBox;
      size1 = new Size(101, 13);
      Size size69 = size1;
      sfcNameBox2.Size = size69;
      this.SFC_NameBox.TabIndex = 21;
      this.SFC_NameBox.TabStop = false;
      this.Label17.AutoSize = true;
      this.Label17.BackColor = SystemColors.Control;
      this.Label17.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label17.ForeColor = Color.Black;
      this.Label17.ImeMode = ImeMode.NoControl;
      Label label17_1 = this.Label17;
      point1 = new Point(6, 16);
      Point point70 = point1;
      label17_1.Location = point70;
      this.Label17.Name = "Label17";
      Label label17_2 = this.Label17;
      size1 = new Size(35, 13);
      Size size70 = size1;
      label17_2.Size = size70;
      this.Label17.TabIndex = 20;
      this.Label17.Text = "Name";
      this.SFC_StatusBox.BackColor = SystemColors.Control;
      this.SFC_StatusBox.BorderStyle = BorderStyle.None;
      this.SFC_StatusBox.ForeColor = Color.Black;
      TextBox sfcStatusBox1 = this.SFC_StatusBox;
      point1 = new Point(81, 106);
      Point point71 = point1;
      sfcStatusBox1.Location = point71;
      this.SFC_StatusBox.Name = "SFC_StatusBox";
      this.SFC_StatusBox.ReadOnly = true;
      TextBox sfcStatusBox2 = this.SFC_StatusBox;
      size1 = new Size(101, 13);
      Size size71 = size1;
      sfcStatusBox2.Size = size71;
      this.SFC_StatusBox.TabIndex = 19;
      this.SFC_StatusBox.TabStop = false;
      this.Label16.AutoSize = true;
      this.Label16.BackColor = SystemColors.Control;
      this.Label16.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label16.ForeColor = Color.Black;
      this.Label16.ImeMode = ImeMode.NoControl;
      Label label16_1 = this.Label16;
      point1 = new Point(6, 106);
      Point point72 = point1;
      label16_1.Location = point72;
      this.Label16.Name = "Label16";
      Label label16_2 = this.Label16;
      size1 = new Size(37, 13);
      Size size72 = size1;
      label16_2.Size = size72;
      this.Label16.TabIndex = 18;
      this.Label16.Text = "Status";
      this.SFC_NoradIdBox.BackColor = SystemColors.Control;
      this.SFC_NoradIdBox.BorderStyle = BorderStyle.None;
      this.SFC_NoradIdBox.ForeColor = Color.Black;
      TextBox sfcNoradIdBox1 = this.SFC_NoradIdBox;
      point1 = new Point(81, 70);
      Point point73 = point1;
      sfcNoradIdBox1.Location = point73;
      this.SFC_NoradIdBox.Name = "SFC_NoradIdBox";
      this.SFC_NoradIdBox.ReadOnly = true;
      TextBox sfcNoradIdBox2 = this.SFC_NoradIdBox;
      size1 = new Size(101, 13);
      Size size73 = size1;
      sfcNoradIdBox2.Size = size73;
      this.SFC_NoradIdBox.TabIndex = 15;
      this.SFC_NoradIdBox.TabStop = false;
      this.Label14.AutoSize = true;
      this.Label14.BackColor = SystemColors.Control;
      this.Label14.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label14.ForeColor = Color.Black;
      this.Label14.ImeMode = ImeMode.NoControl;
      Label label14_1 = this.Label14;
      point1 = new Point(6, 70);
      Point point74 = point1;
      label14_1.Location = point74;
      this.Label14.Name = "Label14";
      Label label14_2 = this.Label14;
      size1 = new Size(58, 13);
      Size size74 = size1;
      label14_2.Size = size74;
      this.Label14.TabIndex = 14;
      this.Label14.Text = "NORAD Id";
      this.SFC_IntDesBox.BackColor = SystemColors.Control;
      this.SFC_IntDesBox.BorderStyle = BorderStyle.None;
      this.SFC_IntDesBox.ForeColor = Color.Black;
      TextBox sfcIntDesBox1 = this.SFC_IntDesBox;
      point1 = new Point(81, 52);
      Point point75 = point1;
      sfcIntDesBox1.Location = point75;
      this.SFC_IntDesBox.Name = "SFC_IntDesBox";
      this.SFC_IntDesBox.ReadOnly = true;
      TextBox sfcIntDesBox2 = this.SFC_IntDesBox;
      size1 = new Size(101, 13);
      Size size75 = size1;
      sfcIntDesBox2.Size = size75;
      this.SFC_IntDesBox.TabIndex = 13;
      this.SFC_IntDesBox.TabStop = false;
      this.Label12.AutoSize = true;
      this.Label12.BackColor = SystemColors.Control;
      this.Label12.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.Label12.ForeColor = Color.Black;
      this.Label12.ImeMode = ImeMode.NoControl;
      Label label12_1 = this.Label12;
      point1 = new Point(6, 52);
      Point point76 = point1;
      label12_1.Location = point76;
      this.Label12.Name = "Label12";
      Label label12_2 = this.Label12;
      size1 = new Size(47, 13);
      Size size76 = size1;
      label12_2.Size = size76;
      this.Label12.TabIndex = 12;
      this.Label12.Text = "Int. Des.";
      this.SFC_TextBox.BackColor = Color.White;
      this.SFC_TextBox.BorderStyle = BorderStyle.FixedSingle;
      this.SFC_TextBox.Font = new Font("Lucida Console", 8.25f);
      TextBox sfcTextBox1 = this.SFC_TextBox;
      point1 = new Point(6, 360);
      Point point77 = point1;
      sfcTextBox1.Location = point77;
      this.SFC_TextBox.MaxLength = 140;
      this.SFC_TextBox.Multiline = true;
      this.SFC_TextBox.Name = "SFC_TextBox";
      TextBox sfcTextBox2 = this.SFC_TextBox;
      size1 = new Size(489, 47);
      Size size77 = size1;
      sfcTextBox2.Size = size77;
      this.SFC_TextBox.TabIndex = 15;
      this.SFC_SatListBox.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.SFC_SatListBox.FormattingEnabled = true;
      this.SFC_SatListBox.ItemHeight = 12;
      ListBox sfcSatListBox1 = this.SFC_SatListBox;
      point1 = new Point(194, 12);
      Point point78 = point1;
      sfcSatListBox1.Location = point78;
      this.SFC_SatListBox.Name = "SFC_SatListBox";
      ListBox sfcSatListBox2 = this.SFC_SatListBox;
      size1 = new Size(301, 172);
      Size size78 = size1;
      sfcSatListBox2.Size = size78;
      this.SFC_SatListBox.Sorted = true;
      this.SFC_SatListBox.TabIndex = 2;
      this.GroupBox1.Controls.Add((Control) this.SFC_Debris);
      this.GroupBox1.Controls.Add((Control) this.SFC_Rocket);
      this.GroupBox1.Controls.Add((Control) this.SFC_Platform);
      this.GroupBox1.Controls.Add((Control) this.SFC_Payload);
      this.GroupBox1.Controls.Add((Control) this.SFC_DisplayAll);
      this.GroupBox1.Controls.Add((Control) this.SFC_LaunchYear);
      this.GroupBox1.Controls.Add((Control) this.Label6);
      this.GroupBox1.Controls.Add((Control) this.SFC_Search);
      this.GroupBox1.Controls.Add((Control) this.SFC_NoradID);
      this.GroupBox1.Controls.Add((Control) this.Label7);
      this.GroupBox1.Controls.Add((Control) this.Label8);
      this.GroupBox1.Controls.Add((Control) this.SFC_Name);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(6, 6);
      Point point79 = point1;
      groupBox1_1.Location = point79;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(182, 178);
      Size size79 = size1;
      groupBox1_2.Size = size79;
      this.GroupBox1.TabIndex = 1;
      this.GroupBox1.TabStop = false;
      this.SFC_Debris.AutoSize = true;
      CheckBox sfcDebris1 = this.SFC_Debris;
      point1 = new Point(110, 113);
      Point point80 = point1;
      sfcDebris1.Location = point80;
      this.SFC_Debris.Name = "SFC_Debris";
      CheckBox sfcDebris2 = this.SFC_Debris;
      size1 = new Size(56, 17);
      Size size80 = size1;
      sfcDebris2.Size = size80;
      this.SFC_Debris.TabIndex = 84;
      this.SFC_Debris.Text = "Debris";
      this.SFC_Debris.UseVisualStyleBackColor = true;
      this.SFC_Rocket.AutoSize = true;
      CheckBox sfcRocket1 = this.SFC_Rocket;
      point1 = new Point(9, 113);
      Point point81 = point1;
      sfcRocket1.Location = point81;
      this.SFC_Rocket.Name = "SFC_Rocket";
      CheckBox sfcRocket2 = this.SFC_Rocket;
      size1 = new Size(88, 17);
      Size size81 = size1;
      sfcRocket2.Size = size81;
      this.SFC_Rocket.TabIndex = 83;
      this.SFC_Rocket.Text = "Rocket Body";
      this.SFC_Rocket.UseVisualStyleBackColor = true;
      this.SFC_Platform.AutoSize = true;
      CheckBox sfcPlatform1 = this.SFC_Platform;
      point1 = new Point(110, 90);
      Point point82 = point1;
      sfcPlatform1.Location = point82;
      this.SFC_Platform.Name = "SFC_Platform";
      CheckBox sfcPlatform2 = this.SFC_Platform;
      size1 = new Size(64, 17);
      Size size82 = size1;
      sfcPlatform2.Size = size82;
      this.SFC_Platform.TabIndex = 82;
      this.SFC_Platform.Text = "Platform";
      this.SFC_Platform.UseVisualStyleBackColor = true;
      this.SFC_Payload.AutoSize = true;
      CheckBox sfcPayload1 = this.SFC_Payload;
      point1 = new Point(9, 90);
      Point point83 = point1;
      sfcPayload1.Location = point83;
      this.SFC_Payload.Name = "SFC_Payload";
      CheckBox sfcPayload2 = this.SFC_Payload;
      size1 = new Size(64, 17);
      Size size83 = size1;
      sfcPayload2.Size = size83;
      this.SFC_Payload.TabIndex = 81;
      this.SFC_Payload.Text = "Payload";
      this.SFC_Payload.UseVisualStyleBackColor = true;
      Button sfcDisplayAll1 = this.SFC_DisplayAll;
      point1 = new Point(99, 144);
      Point point84 = point1;
      sfcDisplayAll1.Location = point84;
      this.SFC_DisplayAll.Name = "SFC_DisplayAll";
      Button sfcDisplayAll2 = this.SFC_DisplayAll;
      size1 = new Size(75, 23);
      Size size84 = size1;
      sfcDisplayAll2.Size = size84;
      this.SFC_DisplayAll.TabIndex = 80;
      this.SFC_DisplayAll.Text = "Display All";
      this.SFC_DisplayAll.UseVisualStyleBackColor = true;
      this.SFC_LaunchYear.CharacterCasing = CharacterCasing.Upper;
      TextBox sfcLaunchYear1 = this.SFC_LaunchYear;
      point1 = new Point(80, 64);
      Point point85 = point1;
      sfcLaunchYear1.Location = point85;
      this.SFC_LaunchYear.MaxLength = 4;
      this.SFC_LaunchYear.Name = "SFC_LaunchYear";
      TextBox sfcLaunchYear2 = this.SFC_LaunchYear;
      size1 = new Size(94, 20);
      Size size85 = size1;
      sfcLaunchYear2.Size = size85;
      this.SFC_LaunchYear.TabIndex = 79;
      this.Label6.AutoSize = true;
      Label label6_1 = this.Label6;
      point1 = new Point(6, 67);
      Point point86 = point1;
      label6_1.Location = point86;
      this.Label6.Name = "Label6";
      Label label6_2 = this.Label6;
      size1 = new Size(68, 13);
      Size size86 = size1;
      label6_2.Size = size86;
      this.Label6.TabIndex = 78;
      this.Label6.Text = "Launch Year";
      Button sfcSearch1 = this.SFC_Search;
      point1 = new Point(9, 146);
      Point point87 = point1;
      sfcSearch1.Location = point87;
      this.SFC_Search.Name = "SFC_Search";
      Button sfcSearch2 = this.SFC_Search;
      size1 = new Size(75, 23);
      Size size87 = size1;
      sfcSearch2.Size = size87;
      this.SFC_Search.TabIndex = 79;
      this.SFC_Search.Text = nameof (Search);
      this.SFC_Search.UseVisualStyleBackColor = true;
      this.SFC_NoradID.CharacterCasing = CharacterCasing.Upper;
      TextBox sfcNoradId1 = this.SFC_NoradID;
      point1 = new Point(80, 38);
      Point point88 = point1;
      sfcNoradId1.Location = point88;
      this.SFC_NoradID.MaxLength = 5;
      this.SFC_NoradID.Name = "SFC_NoradID";
      TextBox sfcNoradId2 = this.SFC_NoradID;
      size1 = new Size(94, 20);
      Size size88 = size1;
      sfcNoradId2.Size = size88;
      this.SFC_NoradID.TabIndex = 77;
      this.Label7.AutoSize = true;
      Label label7_1 = this.Label7;
      point1 = new Point(6, 41);
      Point point89 = point1;
      label7_1.Location = point89;
      this.Label7.Name = "Label7";
      Label label7_2 = this.Label7;
      size1 = new Size(60, 13);
      Size size89 = size1;
      label7_2.Size = size89;
      this.Label7.TabIndex = 76;
      this.Label7.Text = "NORAD ID";
      this.Label8.AutoSize = true;
      Label label8_1 = this.Label8;
      point1 = new Point(6, 16);
      Point point90 = point1;
      label8_1.Location = point90;
      this.Label8.Name = "Label8";
      Label label8_2 = this.Label8;
      size1 = new Size(35, 13);
      Size size90 = size1;
      label8_2.Size = size90;
      this.Label8.TabIndex = 75;
      this.Label8.Text = "Name";
      this.SFC_Name.CharacterCasing = CharacterCasing.Upper;
      TextBox sfcName1 = this.SFC_Name;
      point1 = new Point(80, 12);
      Point point91 = point1;
      sfcName1.Location = point91;
      this.SFC_Name.Name = "SFC_Name";
      TextBox sfcName2 = this.SFC_Name;
      size1 = new Size(94, 20);
      Size size91 = size1;
      sfcName2.Size = size91;
      this.SFC_Name.TabIndex = 1;
      this.AcceptButton = (IButtonControl) this.SEARCH_Search;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(535, 522);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.SEARCH_Close);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Search);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Advanced Search";
      this.TopMost = true;
      this.SearchByNameGrp.ResumeLayout(false);
      this.SearchByNameGrp.PerformLayout();
      this.SearchByTypeGrp.ResumeLayout(false);
      this.SearchByTypeGrp.PerformLayout();
      this.SearchByParGrp.ResumeLayout(false);
      this.SearchByParGrp.PerformLayout();
      this.TabControl1.ResumeLayout(false);
      this.TabPage1.ResumeLayout(false);
      this.TabPage1.PerformLayout();
      this.TabPage2.ResumeLayout(false);
      this.TabPage2.PerformLayout();
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual GroupBox SearchByNameGrp
    {
      [DebuggerNonUserCode] get => this._SearchByNameGrp;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SearchByNameGrp = value;
    }

    internal virtual TextBox SEARCH_Name
    {
      [DebuggerNonUserCode] get => this._SEARCH_Name;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SEARCH_Name = value;
    }

    internal virtual RadioButton SEARCH_ByName
    {
      [DebuggerNonUserCode] get => this._SEARCH_ByName;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SearchByNameBut_CheckedChanged);
        if (this._SEARCH_ByName != null)
          this._SEARCH_ByName.CheckedChanged -= eventHandler;
        this._SEARCH_ByName = value;
        if (this._SEARCH_ByName == null)
          return;
        this._SEARCH_ByName.CheckedChanged += eventHandler;
      }
    }

    internal virtual GroupBox SearchByTypeGrp
    {
      [DebuggerNonUserCode] get => this._SearchByTypeGrp;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SearchByTypeGrp = value;
    }

    internal virtual RadioButton SEARCH_ByType
    {
      [DebuggerNonUserCode] get => this._SEARCH_ByType;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SearchByTypeBut_CheckedChanged);
        if (this._SEARCH_ByType != null)
          this._SEARCH_ByType.CheckedChanged -= eventHandler;
        this._SEARCH_ByType = value;
        if (this._SEARCH_ByType == null)
          return;
        this._SEARCH_ByType.CheckedChanged += eventHandler;
      }
    }

    internal virtual ComboBox SEARCH_LNGList
    {
      [DebuggerNonUserCode] get => this._SEARCH_LNGList;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SearchByTypeMoreBox_SelectedIndexChanged);
        if (this._SEARCH_LNGList != null)
          this._SEARCH_LNGList.SelectedIndexChanged -= eventHandler;
        this._SEARCH_LNGList = value;
        if (this._SEARCH_LNGList == null)
          return;
        this._SEARCH_LNGList.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox SEARCH_TypeList
    {
      [DebuggerNonUserCode] get => this._SEARCH_TypeList;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SearchByTypeBox_SelectedIndexChanged);
        if (this._SEARCH_TypeList != null)
          this._SEARCH_TypeList.SelectedIndexChanged -= eventHandler;
        this._SEARCH_TypeList = value;
        if (this._SEARCH_TypeList == null)
          return;
        this._SEARCH_TypeList.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label SearchLngLabel
    {
      [DebuggerNonUserCode] get => this._SearchLngLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SearchLngLabel = value;
    }

    internal virtual Label SearchResult
    {
      [DebuggerNonUserCode] get => this._SearchResult;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SearchResult = value;
    }

    internal virtual GroupBox SearchByParGrp
    {
      [DebuggerNonUserCode] get => this._SearchByParGrp;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SearchByParGrp = value;
    }

    internal virtual RadioButton SEARCH_ByPar
    {
      [DebuggerNonUserCode] get => this._SEARCH_ByPar;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SearchByParBut_CheckedChanged);
        if (this._SEARCH_ByPar != null)
          this._SEARCH_ByPar.CheckedChanged -= eventHandler;
        this._SEARCH_ByPar = value;
        if (this._SEARCH_ByPar == null)
          return;
        this._SEARCH_ByPar.CheckedChanged += eventHandler;
      }
    }

    internal virtual TextBox SEARCH_Number
    {
      [DebuggerNonUserCode] get => this._SEARCH_Number;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SEARCH_Number = value;
    }

    internal virtual Label Label2
    {
      [DebuggerNonUserCode] get => this._Label2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label Label9
    {
      [DebuggerNonUserCode] get => this._Label9;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label9 = value;
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

    internal virtual TextBox SEARCH_PERMAX
    {
      [DebuggerNonUserCode] get => this._SEARCH_PERMAX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.PERMAX_KeyPress);
        if (this._SEARCH_PERMAX != null)
          this._SEARCH_PERMAX.KeyPress -= pressEventHandler;
        this._SEARCH_PERMAX = value;
        if (this._SEARCH_PERMAX == null)
          return;
        this._SEARCH_PERMAX.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_PERMIN
    {
      [DebuggerNonUserCode] get => this._SEARCH_PERMIN;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.PERMIN_KeyPress);
        if (this._SEARCH_PERMIN != null)
          this._SEARCH_PERMIN.KeyPress -= pressEventHandler;
        this._SEARCH_PERMIN = value;
        if (this._SEARCH_PERMIN == null)
          return;
        this._SEARCH_PERMIN.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_ECCMAX
    {
      [DebuggerNonUserCode] get => this._SEARCH_ECCMAX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.SEARCH_ECCMAX_KeyPress);
        if (this._SEARCH_ECCMAX != null)
          this._SEARCH_ECCMAX.KeyPress -= pressEventHandler;
        this._SEARCH_ECCMAX = value;
        if (this._SEARCH_ECCMAX == null)
          return;
        this._SEARCH_ECCMAX.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_INCMAX
    {
      [DebuggerNonUserCode] get => this._SEARCH_INCMAX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.INCMAX_KeyPress);
        if (this._SEARCH_INCMAX != null)
          this._SEARCH_INCMAX.KeyPress -= pressEventHandler;
        this._SEARCH_INCMAX = value;
        if (this._SEARCH_INCMAX == null)
          return;
        this._SEARCH_INCMAX.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_ECCMIN
    {
      [DebuggerNonUserCode] get => this._SEARCH_ECCMIN;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.SEARCH_ECCMIN_KeyPress);
        if (this._SEARCH_ECCMIN != null)
          this._SEARCH_ECCMIN.KeyPress -= pressEventHandler;
        this._SEARCH_ECCMIN = value;
        if (this._SEARCH_ECCMIN == null)
          return;
        this._SEARCH_ECCMIN.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_INCMIN
    {
      [DebuggerNonUserCode] get => this._SEARCH_INCMIN;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.INCMIN_KeyPress);
        if (this._SEARCH_INCMIN != null)
          this._SEARCH_INCMIN.KeyPress -= pressEventHandler;
        this._SEARCH_INCMIN = value;
        if (this._SEARCH_INCMIN == null)
          return;
        this._SEARCH_INCMIN.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_PEAMAX
    {
      [DebuggerNonUserCode] get => this._SEARCH_PEAMAX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.PEAMAX_KeyPress);
        if (this._SEARCH_PEAMAX != null)
          this._SEARCH_PEAMAX.KeyPress -= pressEventHandler;
        this._SEARCH_PEAMAX = value;
        if (this._SEARCH_PEAMAX == null)
          return;
        this._SEARCH_PEAMAX.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_PEAMIN
    {
      [DebuggerNonUserCode] get => this._SEARCH_PEAMIN;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.PEAMIN_KeyPress);
        if (this._SEARCH_PEAMIN != null)
          this._SEARCH_PEAMIN.KeyPress -= pressEventHandler;
        this._SEARCH_PEAMIN = value;
        if (this._SEARCH_PEAMIN == null)
          return;
        this._SEARCH_PEAMIN.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_APAMAX
    {
      [DebuggerNonUserCode] get => this._SEARCH_APAMAX;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.APAMAX_KeyPress);
        if (this._SEARCH_APAMAX != null)
          this._SEARCH_APAMAX.KeyPress -= pressEventHandler;
        this._SEARCH_APAMAX = value;
        if (this._SEARCH_APAMAX == null)
          return;
        this._SEARCH_APAMAX.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox SEARCH_APAMIN
    {
      [DebuggerNonUserCode] get => this._SEARCH_APAMIN;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.APAMIN_KeyPress);
        if (this._SEARCH_APAMIN != null)
          this._SEARCH_APAMIN.KeyPress -= pressEventHandler;
        this._SEARCH_APAMIN = value;
        if (this._SEARCH_APAMIN == null)
          return;
        this._SEARCH_APAMIN.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label13
    {
      [DebuggerNonUserCode] get => this._Label13;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label13 = value;
    }

    internal virtual Label Label11
    {
      [DebuggerNonUserCode] get => this._Label11;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label11 = value;
    }

    internal virtual Label Label10
    {
      [DebuggerNonUserCode] get => this._Label10;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label10 = value;
    }

    internal virtual CheckBox SEARCH_Period
    {
      [DebuggerNonUserCode] get => this._SEARCH_Period;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PERCB_CheckedChanged);
        if (this._SEARCH_Period != null)
          this._SEARCH_Period.CheckedChanged -= eventHandler;
        this._SEARCH_Period = value;
        if (this._SEARCH_Period == null)
          return;
        this._SEARCH_Period.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox SEARCH_ECC
    {
      [DebuggerNonUserCode] get => this._SEARCH_ECC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ECCCB_CheckedChanged);
        if (this._SEARCH_ECC != null)
          this._SEARCH_ECC.CheckedChanged -= eventHandler;
        this._SEARCH_ECC = value;
        if (this._SEARCH_ECC == null)
          return;
        this._SEARCH_ECC.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox SEARCH_INC
    {
      [DebuggerNonUserCode] get => this._SEARCH_INC;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.INCCB_CheckedChanged);
        if (this._SEARCH_INC != null)
          this._SEARCH_INC.CheckedChanged -= eventHandler;
        this._SEARCH_INC = value;
        if (this._SEARCH_INC == null)
          return;
        this._SEARCH_INC.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox SEARCH_PEA
    {
      [DebuggerNonUserCode] get => this._SEARCH_PEA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.PEACB_CheckedChanged);
        if (this._SEARCH_PEA != null)
          this._SEARCH_PEA.CheckedChanged -= eventHandler;
        this._SEARCH_PEA = value;
        if (this._SEARCH_PEA == null)
          return;
        this._SEARCH_PEA.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox SEARCH_APA
    {
      [DebuggerNonUserCode] get => this._SEARCH_APA;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.APACB_CheckedChanged);
        if (this._SEARCH_APA != null)
          this._SEARCH_APA.CheckedChanged -= eventHandler;
        this._SEARCH_APA = value;
        if (this._SEARCH_APA == null)
          return;
        this._SEARCH_APA.CheckedChanged += eventHandler;
      }
    }

    internal virtual Button SEARCH_Search
    {
      [DebuggerNonUserCode] get => this._SEARCH_Search;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SEARCH_Search_Click);
        if (this._SEARCH_Search != null)
          this._SEARCH_Search.Click -= eventHandler;
        this._SEARCH_Search = value;
        if (this._SEARCH_Search == null)
          return;
        this._SEARCH_Search.Click += eventHandler;
      }
    }

    internal virtual Button SEARCH_Close
    {
      [DebuggerNonUserCode] get => this._SEARCH_Close;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CancelBut_Click);
        if (this._SEARCH_Close != null)
          this._SEARCH_Close.Click -= eventHandler;
        this._SEARCH_Close = value;
        if (this._SEARCH_Close == null)
          return;
        this._SEARCH_Close.Click += eventHandler;
      }
    }

    internal virtual TextBox SEARCH_Date
    {
      [DebuggerNonUserCode] get => this._SEARCH_Date;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SEARCH_Date = value;
    }

    internal virtual Label Label3
    {
      [DebuggerNonUserCode] get => this._Label3;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual TabControl TabControl1
    {
      [DebuggerNonUserCode] get => this._TabControl1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabControl1 = value;
    }

    internal virtual TabPage TabPage1
    {
      [DebuggerNonUserCode] get => this._TabPage1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage1 = value;
    }

    internal virtual TabPage TabPage2
    {
      [DebuggerNonUserCode] get => this._TabPage2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TabPage2 = value;
    }

    internal virtual GroupBox GroupBox1
    {
      [DebuggerNonUserCode] get => this._GroupBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox1 = value;
    }

    internal virtual TextBox SFC_LaunchYear
    {
      [DebuggerNonUserCode] get => this._SFC_LaunchYear;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_LaunchYear_TextChanged);
        if (this._SFC_LaunchYear != null)
          this._SFC_LaunchYear.TextChanged -= eventHandler;
        this._SFC_LaunchYear = value;
        if (this._SFC_LaunchYear == null)
          return;
        this._SFC_LaunchYear.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label6
    {
      [DebuggerNonUserCode] get => this._Label6;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    internal virtual TextBox SFC_NoradID
    {
      [DebuggerNonUserCode] get => this._SFC_NoradID;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_NoradID_TextChanged);
        if (this._SFC_NoradID != null)
          this._SFC_NoradID.TextChanged -= eventHandler;
        this._SFC_NoradID = value;
        if (this._SFC_NoradID == null)
          return;
        this._SFC_NoradID.TextChanged += eventHandler;
      }
    }

    internal virtual Label Label7
    {
      [DebuggerNonUserCode] get => this._Label7;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label7 = value;
    }

    internal virtual Label Label8
    {
      [DebuggerNonUserCode] get => this._Label8;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label8 = value;
    }

    internal virtual TextBox SFC_Name
    {
      [DebuggerNonUserCode] get => this._SFC_Name;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_Name_TextChanged);
        if (this._SFC_Name != null)
          this._SFC_Name.TextChanged -= eventHandler;
        this._SFC_Name = value;
        if (this._SFC_Name == null)
          return;
        this._SFC_Name.TextChanged += eventHandler;
      }
    }

    internal virtual ListBox SFC_SatListBox
    {
      [DebuggerNonUserCode] get => this._SFC_SatListBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_SatListBox_SelectedIndexChanged);
        if (this._SFC_SatListBox != null)
          this._SFC_SatListBox.SelectedIndexChanged -= eventHandler;
        this._SFC_SatListBox = value;
        if (this._SFC_SatListBox == null)
          return;
        this._SFC_SatListBox.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox2
    {
      [DebuggerNonUserCode] get => this._GroupBox2;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox2 = value;
    }

    internal virtual TextBox SFC_IntDesBox
    {
      [DebuggerNonUserCode] get => this._SFC_IntDesBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_IntDesBox = value;
    }

    internal virtual Label Label12
    {
      [DebuggerNonUserCode] get => this._Label12;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label12 = value;
    }

    internal virtual Button SFC_Import
    {
      [DebuggerNonUserCode] get => this._SFC_Import;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_Import_Click);
        if (this._SFC_Import != null)
          this._SFC_Import.Click -= eventHandler;
        this._SFC_Import = value;
        if (this._SFC_Import == null)
          return;
        this._SFC_Import.Click += eventHandler;
      }
    }

    internal virtual TextBox SFC_TextBox
    {
      [DebuggerNonUserCode] get => this._SFC_TextBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_TextBox = value;
    }

    internal virtual TextBox SFC_DecayDateBox
    {
      [DebuggerNonUserCode] get => this._SFC_DecayDateBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_DecayDateBox = value;
    }

    internal virtual Label Label21
    {
      [DebuggerNonUserCode] get => this._Label21;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label21 = value;
    }

    internal virtual TextBox SFC_LaunchSiteBox
    {
      [DebuggerNonUserCode] get => this._SFC_LaunchSiteBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_LaunchSiteBox = value;
    }

    internal virtual Label Label20
    {
      [DebuggerNonUserCode] get => this._Label20;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label20 = value;
    }

    internal virtual TextBox SFC_LaunchDateBox
    {
      [DebuggerNonUserCode] get => this._SFC_LaunchDateBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_LaunchDateBox = value;
    }

    internal virtual Label Label19
    {
      [DebuggerNonUserCode] get => this._Label19;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label19 = value;
    }

    internal virtual TextBox SFC_OwnerBox
    {
      [DebuggerNonUserCode] get => this._SFC_OwnerBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_OwnerBox = value;
    }

    internal virtual Label Label18
    {
      [DebuggerNonUserCode] get => this._Label18;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label18 = value;
    }

    internal virtual TextBox SFC_NameBox
    {
      [DebuggerNonUserCode] get => this._SFC_NameBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_NameBox = value;
    }

    internal virtual Label Label17
    {
      [DebuggerNonUserCode] get => this._Label17;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label17 = value;
    }

    internal virtual TextBox SFC_StatusBox
    {
      [DebuggerNonUserCode] get => this._SFC_StatusBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_StatusBox = value;
    }

    internal virtual Label Label16
    {
      [DebuggerNonUserCode] get => this._Label16;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label16 = value;
    }

    internal virtual TextBox SFC_AltNameBox
    {
      [DebuggerNonUserCode] get => this._SFC_AltNameBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_AltNameBox = value;
    }

    internal virtual Label Label15
    {
      [DebuggerNonUserCode] get => this._Label15;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label15 = value;
    }

    internal virtual TextBox SFC_NoradIdBox
    {
      [DebuggerNonUserCode] get => this._SFC_NoradIdBox;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_NoradIdBox = value;
    }

    internal virtual Label Label14
    {
      [DebuggerNonUserCode] get => this._Label14;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label14 = value;
    }

    internal virtual Button SFC_Search
    {
      [DebuggerNonUserCode] get => this._SFC_Search;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_Search_Click);
        if (this._SFC_Search != null)
          this._SFC_Search.Click -= eventHandler;
        this._SFC_Search = value;
        if (this._SFC_Search == null)
          return;
        this._SFC_Search.Click += eventHandler;
      }
    }

    internal virtual Button SFC_DisplayAll
    {
      [DebuggerNonUserCode] get => this._SFC_DisplayAll;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_DisplayAll_Click);
        if (this._SFC_DisplayAll != null)
          this._SFC_DisplayAll.Click -= eventHandler;
        this._SFC_DisplayAll = value;
        if (this._SFC_DisplayAll == null)
          return;
        this._SFC_DisplayAll.Click += eventHandler;
      }
    }

    internal virtual CheckBox SFC_Debris
    {
      [DebuggerNonUserCode] get => this._SFC_Debris;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_Debris_CheckedChanged);
        if (this._SFC_Debris != null)
          this._SFC_Debris.CheckedChanged -= eventHandler;
        this._SFC_Debris = value;
        if (this._SFC_Debris == null)
          return;
        this._SFC_Debris.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox SFC_Rocket
    {
      [DebuggerNonUserCode] get => this._SFC_Rocket;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_Rocket_CheckedChanged);
        if (this._SFC_Rocket != null)
          this._SFC_Rocket.CheckedChanged -= eventHandler;
        this._SFC_Rocket = value;
        if (this._SFC_Rocket == null)
          return;
        this._SFC_Rocket.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox SFC_Platform
    {
      [DebuggerNonUserCode] get => this._SFC_Platform;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_Platform_CheckedChanged);
        if (this._SFC_Platform != null)
          this._SFC_Platform.CheckedChanged -= eventHandler;
        this._SFC_Platform = value;
        if (this._SFC_Platform == null)
          return;
        this._SFC_Platform.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox SFC_Payload
    {
      [DebuggerNonUserCode] get => this._SFC_Payload;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.SFC_Payload_CheckedChanged);
        if (this._SFC_Payload != null)
          this._SFC_Payload.CheckedChanged -= eventHandler;
        this._SFC_Payload = value;
        if (this._SFC_Payload == null)
          return;
        this._SFC_Payload.CheckedChanged += eventHandler;
      }
    }

    internal virtual Label SFC_CountLabel
    {
      [DebuggerNonUserCode] get => this._SFC_CountLabel;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_CountLabel = value;
    }

    internal virtual TextBox SFC_ObjectType
    {
      [DebuggerNonUserCode] get => this._SFC_ObjectType;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_ObjectType = value;
    }

    internal virtual Label Label22
    {
      [DebuggerNonUserCode] get => this._Label22;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label22 = value;
    }

    internal virtual TextBox SFC_Inclination
    {
      [DebuggerNonUserCode] get => this._SFC_Inclination;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_Inclination = value;
    }

    internal virtual Label Label26
    {
      [DebuggerNonUserCode] get => this._Label26;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label26 = value;
    }

    internal virtual TextBox SFC_Period
    {
      [DebuggerNonUserCode] get => this._SFC_Period;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_Period = value;
    }

    internal virtual Label Label25
    {
      [DebuggerNonUserCode] get => this._Label25;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label25 = value;
    }

    internal virtual TextBox SFC_Periapsis
    {
      [DebuggerNonUserCode] get => this._SFC_Periapsis;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_Periapsis = value;
    }

    internal virtual Label Label24
    {
      [DebuggerNonUserCode] get => this._Label24;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label24 = value;
    }

    internal virtual TextBox SFC_Apoapsis
    {
      [DebuggerNonUserCode] get => this._SFC_Apoapsis;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_Apoapsis = value;
    }

    internal virtual Label Label23
    {
      [DebuggerNonUserCode] get => this._Label23;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label23 = value;
    }

    internal virtual TextBox SFC_Collection
    {
      [DebuggerNonUserCode] get => this._SFC_Collection;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._SFC_Collection = value;
    }

    internal virtual Label Label105
    {
      [DebuggerNonUserCode] get => this._Label105;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label105 = value;
    }

    private void SearchByNameBut_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SEARCH_ByName.Checked)
        return;
      this.SearchByNameGrp.Enabled = true;
      this.SearchByTypeGrp.Enabled = false;
      this.SearchByParGrp.Enabled = false;
    }

    private void SearchByTypeBut_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SEARCH_ByType.Checked)
        return;
      this.SearchByTypeGrp.Enabled = true;
      this.SearchByNameGrp.Enabled = false;
      this.SearchByParGrp.Enabled = false;
    }

    private void SearchByParBut_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SEARCH_ByPar.Checked)
        return;
      this.SearchByTypeGrp.Enabled = false;
      this.SearchByNameGrp.Enabled = false;
      this.SearchByParGrp.Enabled = true;
    }

    private void SEARCH_Search_Click(object sender, EventArgs e) => MyProject.Forms.Home.TLE_Search();

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SFC_Search_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      this.SFC_NameBox.Text = "";
      this.SFC_IntDesBox.Text = "";
      this.SFC_NoradIdBox.Text = "";
      this.SFC_AltNameBox.Text = "";
      this.SFC_StatusBox.Text = "";
      this.SFC_OwnerBox.Text = "";
      this.SFC_LaunchDateBox.Text = "";
      this.SFC_LaunchSiteBox.Text = "";
      this.SFC_DecayDateBox.Text = "";
      this.SFC_TextBox.Text = "";
      if (!MyProject.Computer.FileSystem.FileExists(MyProject.Forms.Home.SatCat))
      {
        int num2 = (int) TopMostMessageBox.Show("You must dowload the catalog\r\n(Options/Catalog Updater)", "Full Catalog Search", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
      else
      {
        this.Cursor = Cursors.WaitCursor;
        if (!this.SFC_Payload.Checked & !this.SFC_Platform.Checked & !this.SFC_Rocket.Checked & !this.SFC_Debris.Checked && Operators.CompareString(this.SFC_Name.Text, "", false) == 0 & Operators.CompareString(this.SFC_NoradID.Text, "", false) == 0 & Operators.CompareString(this.SFC_LaunchYear.Text, "", false) == 0)
        {
          int num3 = (int) Interaction.MsgBox((object) "Complete at least 'Name' or 'NORAD ID' or 'Launch Year' text box", MsgBoxStyle.Exclamation, (object) "Full Catalog Search");
          this.Cursor = Cursors.Default;
        }
        else
        {
          this.SFC_SatListBox.Items.Clear();
          FileSystem.FileOpen(1, MyProject.Forms.Home.SatCat, OpenMode.Input);
          while (!FileSystem.EOF(1))
          {
            string str1 = FileSystem.LineInput(1);
            string str2 = "";
            int index1 = 23;
            do
            {
              str2 += Conversions.ToString(str1[index1]);
              checked { ++index1; }
            }
            while (index1 <= 46);
            if (this.SFC_Payload.Checked)
            {
              string Left = "";
              int index2 = 20;
              do
              {
                Left += Conversions.ToString(str1[index2]);
                checked { ++index2; }
              }
              while (index2 <= 20);
              if (Operators.CompareString(Left, "*", false) == 0)
              {
                checked { ++num1; }
                this.SFC_SatListBox.Items.Add((object) str1);
              }
            }
            else if (this.SFC_Platform.Checked)
            {
              if (str2.Contains("PLAT"))
              {
                checked { ++num1; }
                this.SFC_SatListBox.Items.Add((object) str1);
              }
            }
            else if (this.SFC_Debris.Checked)
            {
              if (str2.Contains("DEB"))
              {
                checked { ++num1; }
                this.SFC_SatListBox.Items.Add((object) str1);
              }
            }
            else if (this.SFC_Rocket.Checked)
            {
              if (str2.Contains("R/B"))
              {
                checked { ++num1; }
                this.SFC_SatListBox.Items.Add((object) str1);
              }
            }
            else
            {
              bool flag;
              if (Operators.CompareString(this.SFC_Name.Text, "", false) != 0 & str2.Contains(this.SFC_Name.Text))
              {
                flag = true;
                checked { ++num1; }
                this.SFC_SatListBox.Items.Add((object) str1);
              }
              string str3 = "";
              int index3 = 13;
              do
              {
                str3 += Conversions.ToString(str1[index3]);
                checked { ++index3; }
              }
              while (index3 <= 17);
              if (Operators.CompareString(this.SFC_NoradID.Text, "", false) != 0 & str3.Contains(this.SFC_NoradID.Text))
              {
                flag = true;
                checked { ++num1; }
                this.SFC_SatListBox.Items.Add((object) str1);
              }
              if (Operators.CompareString(this.SFC_LaunchYear.Text, "", false) != 0 & str1.StartsWith(this.SFC_LaunchYear.Text))
              {
                flag = true;
                checked { ++num1; }
                this.SFC_SatListBox.Items.Add((object) str1);
              }
            }
          }
          FileSystem.FileClose(1);
          this.Cursor = Cursors.Default;
          this.SFC_CountLabel.Text = Conversions.ToString(num1) + " object(s) found.";
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SFC_DisplayAll_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.SFC_NameBox.Text = "";
      this.SFC_ObjectType.Text = "";
      this.SFC_IntDesBox.Text = "";
      this.SFC_NoradIdBox.Text = "";
      this.SFC_Apoapsis.Text = "";
      this.SFC_Periapsis.Text = "";
      this.SFC_Period.Text = "";
      this.SFC_Inclination.Text = "";
      this.SFC_AltNameBox.Text = "";
      this.SFC_StatusBox.Text = "";
      this.SFC_OwnerBox.Text = "";
      this.SFC_LaunchDateBox.Text = "";
      this.SFC_LaunchSiteBox.Text = "";
      this.SFC_DecayDateBox.Text = "";
      this.SFC_Collection.Text = "";
      FileSystem.FileOpen(1, MyProject.Forms.Home.SatCat, OpenMode.Input);
      while (!FileSystem.EOF(1))
        this.SFC_SatListBox.Items.Add((object) FileSystem.LineInput(1));
      FileSystem.FileClose(1);
      this.Cursor = Cursors.Default;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void SFC_SatListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      string str1 = Conversions.ToString(this.SFC_SatListBox.SelectedItem);
      string satCatSources = MyProject.Forms.Home.SatCatSources;
      string satCatSites = MyProject.Forms.Home.SatCatSites;
      string satCatAnn = MyProject.Forms.Home.SatCatAnn;
      this.SFC_NameBox.Text = "";
      this.SFC_ObjectType.Text = "";
      this.SFC_IntDesBox.Text = "";
      this.SFC_NoradIdBox.Text = "";
      this.SFC_Apoapsis.Text = "";
      this.SFC_Periapsis.Text = "";
      this.SFC_Period.Text = "";
      this.SFC_Inclination.Text = "";
      this.SFC_AltNameBox.Text = "";
      this.SFC_StatusBox.Text = "";
      this.SFC_OwnerBox.Text = "";
      this.SFC_LaunchDateBox.Text = "";
      this.SFC_LaunchSiteBox.Text = "";
      this.SFC_DecayDateBox.Text = "";
      this.SFC_Collection.Text = "";
      string str2 = "";
      int index1 = 0;
      do
      {
        str2 += Conversions.ToString(str1[index1]);
        checked { ++index1; }
      }
      while (index1 <= 10);
      string str3 = "";
      int index2 = 13;
      do
      {
        str3 += Conversions.ToString(str1[index2]);
        checked { ++index2; }
      }
      while (index2 <= 17);
      bool flag1 = false;
      string str4 = "";
      int index3 = 19;
      do
      {
        str4 += Conversions.ToString(str1[index3]);
        checked { ++index3; }
      }
      while (index3 <= 19);
      if (Operators.CompareString(str4, "M", false) == 0)
      {
        str4 = "";
        FileSystem.FileOpen(1, satCatAnn, OpenMode.Input);
        while (!FileSystem.EOF(1))
        {
          string Expression = FileSystem.LineInput(1);
          if (Operators.CompareString(Strings.Split(Expression, "|")[0], str3, false) == 0)
          {
            int num = checked (Strings.Split(Expression, "|").GetLength(0) - 1);
            int index4 = 1;
            while (index4 <= num)
            {
              str4 = str4 + Strings.Split(Expression, "|")[index4] + " - ";
              checked { ++index4; }
            }
            break;
          }
        }
        FileSystem.FileClose(1);
      }
      flag1 = true;
      string Left1 = "";
      int index5 = 20;
      do
      {
        Left1 += Conversions.ToString(str1[index5]);
        checked { ++index5; }
      }
      while (index5 <= 20);
      string str5 = "";
      int index6 = 21;
      do
      {
        str5 += Conversions.ToString(str1[index6]);
        checked { ++index6; }
      }
      while (index6 <= 21);
      string Left2 = str5;
      if (Operators.CompareString(Left2, "+", false) == 0)
        str5 = "Operational";
      else if (Operators.CompareString(Left2, "-", false) == 0)
        str5 = "Nonoperational";
      else if (Operators.CompareString(Left2, "P", false) == 0)
        str5 = "Partially Operational";
      else if (Operators.CompareString(Left2, "B", false) == 0)
        str5 = "Backup/Stanby";
      else if (Operators.CompareString(Left2, "S", false) == 0)
        str5 = "Spare";
      else if (Operators.CompareString(Left2, "X", false) == 0)
        str5 = "Extended Mission";
      else if (Operators.CompareString(Left2, "D", false) == 0)
        str5 = "Decayed";
      else if (Operators.CompareString(Left2, "?", false) == 0)
        str5 = "Unknown";
      string str6 = "";
      int index7 = 23;
      do
      {
        str6 += Conversions.ToString(str1[index7]);
        checked { ++index7; }
      }
      while (index7 <= 46);
      string str7 = "";
      int index8 = 49;
      do
      {
        str7 += Conversions.ToString(str1[index8]);
        checked { ++index8; }
      }
      while (index8 <= 53);
      string str8 = Strings.Trim(str7);
      FileSystem.FileOpen(1, satCatSources, OpenMode.Input);
      bool flag2 = false;
      while (!FileSystem.EOF(1))
      {
        string Expression = FileSystem.LineInput(1);
        if (Operators.CompareString(Strings.Split(Expression, ";")[0], str8, false) == 0)
        {
          str8 = Strings.Split(Expression, ";")[1];
          flag2 = true;
          break;
        }
      }
      FileSystem.FileClose(1);
      if (!flag2)
        str8 = "unknown";
      string str9 = "";
      int index9 = 56;
      do
      {
        str9 += Conversions.ToString(str1[index9]);
        checked { ++index9; }
      }
      while (index9 <= 65);
      string str10 = "";
      int index10 = 68;
      do
      {
        str10 += Conversions.ToString(str1[index10]);
        checked { ++index10; }
      }
      while (index10 <= 72);
      string str11 = Strings.Trim(str10);
      FileSystem.FileOpen(1, satCatSites, OpenMode.Input);
      bool flag3 = false;
      while (!FileSystem.EOF(1))
      {
        string Expression = FileSystem.LineInput(1);
        if (Operators.CompareString(Strings.Split(Expression, ";")[0], str11, false) == 0)
        {
          str11 = Strings.Split(Expression, ";")[1];
          flag3 = true;
          break;
        }
      }
      FileSystem.FileClose(1);
      if (!flag3)
        str8 = "unknown";
      string str12 = "";
      int index11 = 75;
      do
      {
        str12 += Conversions.ToString(str1[index11]);
        checked { ++index11; }
      }
      while (index11 <= 84);
      string str13 = "";
      int index12 = 87;
      do
      {
        str13 += Conversions.ToString(str1[index12]);
        checked { ++index12; }
      }
      while (index12 <= 93);
      string str14 = "";
      int index13 = 96;
      do
      {
        str14 += Conversions.ToString(str1[index13]);
        checked { ++index13; }
      }
      while (index13 <= 100);
      string str15 = "";
      int index14 = 103;
      do
      {
        str15 += Conversions.ToString(str1[index14]);
        checked { ++index14; }
      }
      while (index14 <= 108);
      string str16 = "";
      int index15 = 111;
      do
      {
        str16 += Conversions.ToString(str1[index15]);
        checked { ++index15; }
      }
      while (index15 <= 116);
      this.SFC_NameBox.Text = Strings.Trim(str6);
      if (Operators.CompareString(Left1, "*", false) == 0)
        this.SFC_ObjectType.Text = "Payload";
      if (str6.Contains("PLAT"))
        this.SFC_ObjectType.Text = "Platform";
      if (str6.Contains("DEB"))
        this.SFC_ObjectType.Text = "Debris";
      if (str6.Contains("R/B(1)"))
        this.SFC_ObjectType.Text = "Rocket body, first stage";
      else if (str6.Contains("R/B(2)"))
        this.SFC_ObjectType.Text = "Rocket body, second stage";
      else if (str6.Contains("R/B"))
        this.SFC_ObjectType.Text = "Rocket body";
      this.SFC_IntDesBox.Text = Strings.Trim(str2);
      this.SFC_NoradIdBox.Text = Strings.Trim(str3);
      this.SFC_Apoapsis.Text = Strings.Trim(str15) + " kms";
      this.SFC_Periapsis.Text = Strings.Trim(str16) + " kms";
      this.SFC_Period.Text = Strings.Trim(str13) + " min";
      this.SFC_Inclination.Text = Strings.Trim(str14) + " deg";
      this.SFC_AltNameBox.Text = Strings.Trim(str4);
      this.SFC_StatusBox.Text = Strings.Trim(str5);
      this.SFC_OwnerBox.Text = Strings.Trim(str8);
      this.SFC_LaunchDateBox.Text = Strings.Trim(str9);
      this.SFC_LaunchSiteBox.Text = Strings.Trim(str11);
      this.SFC_DecayDateBox.Text = Strings.Trim(str12);
      int num1 = checked (MyProject.Forms.Home.TLE_ListBox.Items.Count - 1);
      int index16 = 0;
      while (index16 <= num1)
      {
        object obj = Operators.ConcatenateObject((object) MyProject.Forms.Home.TLEPath, MyProject.Forms.Home.TLE_ListBox.Items[index16]);
        if (!Conversions.ToBoolean(Operators.OrObject(NewLateBinding.LateGet(MyProject.Forms.Home.TLE_ListBox.Items[index16], (Type) null, "startswith", new object[1]
        {
          (object) "fleet_"
        }, (string[]) null, (Type[]) null, (bool[]) null), NewLateBinding.LateGet(MyProject.Forms.Home.TLE_ListBox.Items[index16], (Type) null, "startswith", new object[1]
        {
          (object) "search"
        }, (string[]) null, (Type[]) null, (bool[]) null))))
        {
          FileSystem.FileOpen(1, Conversions.ToString(obj), OpenMode.Input);
          while (!FileSystem.EOF(1))
          {
            FileSystem.LineInput(1);
            string str17 = FileSystem.LineInput(1);
            FileSystem.LineInput(1);
            string Left3 = "";
            int index17 = 2;
            do
            {
              Left3 += Conversions.ToString(str17[index17]);
              checked { ++index17; }
            }
            while (index17 <= 6);
            if (Operators.CompareString(Left3, this.SFC_NoradIdBox.Text, false) == 0)
              this.SFC_Collection.Text = Conversions.ToString(Operators.ConcatenateObject((object) (this.SFC_Collection.Text + " - "), MyProject.Forms.Home.TLE_ListBox.Items[index16]));
          }
        }
        FileSystem.FileClose(1);
        checked { ++index16; }
      }
      try
      {
        MyProject.Computer.Network.DownloadFile("http://www.celestrak.com/cgi-bin/TLE.pl?CATNR=" + str3, MyProject.Forms.Home.CATPath + "tle.txt", "", "", false, 10000, true);
        FileSystem.FileOpen(1, MyProject.Forms.Home.CATPath + "tle.txt", OpenMode.Input);
        string[] strArray = new string[251];
        int index18 = 0;
        while (!FileSystem.EOF(1))
        {
          strArray[index18] = FileSystem.LineInput(1);
          checked { ++index18; }
        }
        FileSystem.FileClose(1);
        if (Operators.CompareString(strArray[15], "", false) == 0)
        {
          this.SFC_TextBox.Text = Strings.Trim(strArray[13]);
          this.SFC_Import.Enabled = false;
        }
        else
        {
          this.SFC_TextBox.Text = Strings.Trim(strArray[13]) + "\r\n" + strArray[14] + "\r\n" + strArray[15];
          this.SFC_Import.Enabled = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        FileSystem.FileClose(1);
        int num2 = (int) TopMostMessageBox.Show("Your Network seems to be restricted:\r\nTLE ANALYSER can't dowload updated TLE.\r\n" + exception.Message + "\r\n\r\nDocument: 'search.vb'\r\nBloc: 'SFC_SatListBox_SelectedIndexChanged'", "TLE ANALYSER - Error");
        ProjectData.ClearProjectError();
      }
    }

    private void SFC_Import_Click(object sender, EventArgs e)
    {
      string line1 = this.SFC_TextBox.Lines[1];
      string line2 = this.SFC_TextBox.Lines[2];
      Home home = MyProject.Forms.Home;
      string StringToCheck = Strings.RTrim(this.SFC_TextBox.Lines[0]);
      string str = Conversions.ToString(Functions.CheckCaracts(ref StringToCheck));
      home.SATNAME = str;
      MyProject.Forms.Home.TLETextBox.Text = line1 + "\r\n" + line2;
      MyProject.Forms.Home.TLETextBox.ReadOnly = true;
      MyProject.Forms.Home.ButtonMenu_Import.Enabled = false;
      MyProject.Forms.Home.Fleet_Add.Enabled = false;
      MyProject.Forms.Home.Fleet_Remove.Enabled = false;
      MyProject.Forms.Home.TLE_Import();
      MyProject.Forms.Home.TLE_Detail();
    }

    private void SearchByTypeBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.SEARCH_TypeList.SelectedIndex == 0)
      {
        this.SEARCH_LNGList.Enabled = true;
        this.SEARCH_LNGList.SelectedIndex = 0;
      }
      else
      {
        this.SEARCH_LNGList.SelectedIndex = 0;
        this.SearchLngLabel.Visible = false;
        this.SEARCH_LNGList.Enabled = false;
      }
    }

    private void SearchByTypeMoreBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.SEARCH_LNGList.SelectedIndex == 0)
      {
        this.SearchLngLabel.Visible = false;
      }
      else
      {
        this.SearchLngLabel.Visible = true;
        this.SearchLngLabel.Text = "< LNG < " + Conversions.ToString(Conversions.ToDouble(this.SEARCH_LNGList.SelectedItem) + 30.0);
      }
    }

    private void APACB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.SEARCH_APA.Checked)
      {
        this.SEARCH_APAMIN.Enabled = true;
        this.SEARCH_APAMAX.Enabled = true;
      }
      else
      {
        this.SEARCH_APAMIN.Enabled = false;
        this.SEARCH_APAMAX.Enabled = false;
        this.SEARCH_APAMIN.Text = "0";
        this.SEARCH_APAMAX.Text = "999999";
      }
    }

    private void PEACB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.SEARCH_PEA.Checked)
      {
        this.SEARCH_PEAMIN.Enabled = true;
        this.SEARCH_PEAMAX.Enabled = true;
      }
      else
      {
        this.SEARCH_PEAMIN.Enabled = false;
        this.SEARCH_PEAMAX.Enabled = false;
        this.SEARCH_PEAMIN.Text = "0";
        this.SEARCH_PEAMAX.Text = "99999";
      }
    }

    private void INCCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.SEARCH_INC.Checked)
      {
        this.SEARCH_INCMIN.Enabled = true;
        this.SEARCH_INCMAX.Enabled = true;
      }
      else
      {
        this.SEARCH_INCMIN.Enabled = false;
        this.SEARCH_INCMAX.Enabled = false;
        this.SEARCH_INCMIN.Text = "0";
        this.SEARCH_INCMAX.Text = "180";
      }
    }

    private void ECCCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.SEARCH_ECC.Checked)
      {
        this.SEARCH_ECCMIN.Enabled = true;
        this.SEARCH_ECCMAX.Enabled = true;
      }
      else
      {
        this.SEARCH_ECCMIN.Enabled = false;
        this.SEARCH_ECCMAX.Enabled = false;
        this.SEARCH_ECCMIN.Text = "0.00000";
        this.SEARCH_ECCMAX.Text = "1.00000";
      }
    }

    private void PERCB_CheckedChanged(object sender, EventArgs e)
    {
      if (this.SEARCH_Period.Checked)
      {
        this.SEARCH_PERMIN.Enabled = true;
        this.SEARCH_PERMAX.Enabled = true;
      }
      else
      {
        this.SEARCH_PERMIN.Enabled = false;
        this.SEARCH_PERMAX.Enabled = false;
        this.SEARCH_PERMIN.Text = "0";
        this.SEARCH_PERMAX.Text = "99999";
      }
    }

    private void APAMIN_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void APAMAX_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void PEAMIN_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void PEAMAX_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void INCMIN_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void INCMAX_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void SEARCH_ECCMIN_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void SEARCH_ECCMAX_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void PERMIN_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void PERMAX_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (Versioned.IsNumeric((object) e.KeyChar) | e.KeyChar == '.')
        e.Handled = false;
      else if (e.KeyChar == '\b')
        e.KeyChar = '\b';
      else
        e.Handled = true;
    }

    private void CancelBut_Click(object sender, EventArgs e) => this.Close();

    private void SFC_Payload_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SFC_Payload.Checked)
        return;
      this.SFC_Platform.Checked = false;
      this.SFC_Debris.Checked = false;
      this.SFC_Rocket.Checked = false;
    }

    private void SFC_Platform_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SFC_Platform.Checked)
        return;
      this.SFC_Payload.Checked = false;
      this.SFC_Debris.Checked = false;
      this.SFC_Rocket.Checked = false;
    }

    private void SFC_Rocket_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SFC_Rocket.Checked)
        return;
      this.SFC_Payload.Checked = false;
      this.SFC_Debris.Checked = false;
      this.SFC_Platform.Checked = false;
    }

    private void SFC_Debris_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.SFC_Debris.Checked)
        return;
      this.SFC_Payload.Checked = false;
      this.SFC_Rocket.Checked = false;
      this.SFC_Platform.Checked = false;
    }

    private void SFC_Name_TextChanged(object sender, EventArgs e)
    {
      this.SFC_Debris.Checked = false;
      this.SFC_Payload.Checked = false;
      this.SFC_Rocket.Checked = false;
      this.SFC_Platform.Checked = false;
    }

    private void SFC_NoradID_TextChanged(object sender, EventArgs e)
    {
      this.SFC_Debris.Checked = false;
      this.SFC_Payload.Checked = false;
      this.SFC_Rocket.Checked = false;
      this.SFC_Platform.Checked = false;
    }

    private void SFC_LaunchYear_TextChanged(object sender, EventArgs e)
    {
      this.SFC_Debris.Checked = false;
      this.SFC_Payload.Checked = false;
      this.SFC_Rocket.Checked = false;
      this.SFC_Platform.Checked = false;
    }
  }
}
