// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Dialog_Fleet
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
  public class Dialog_Fleet : Form
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();
    private IContainer components;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;
    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;
    [AccessedThroughProperty("GroupBox1")]
    private GroupBox _GroupBox1;
    [AccessedThroughProperty("Fleet_List")]
    private ComboBox _Fleet_List;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    [DebuggerNonUserCode]
    static Dialog_Fleet()
    {
    }

    [DebuggerNonUserCode]
    public Dialog_Fleet()
    {
      this.Load += new EventHandler(this.Load_App);
      Dialog_Fleet.__ENCAddToList((object) this);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (Dialog_Fleet.__ENCList)
      {
        if (Dialog_Fleet.__ENCList.Count == Dialog_Fleet.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (Dialog_Fleet.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (Dialog_Fleet.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                Dialog_Fleet.__ENCList[index1] = Dialog_Fleet.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          Dialog_Fleet.__ENCList.RemoveRange(index1, checked (Dialog_Fleet.__ENCList.Count - index1));
          Dialog_Fleet.__ENCList.Capacity = Dialog_Fleet.__ENCList.Count;
        }
        Dialog_Fleet.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Dialog_Fleet));
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.OK_Button = new Button();
      this.Cancel_Button = new Button();
      this.GroupBox1 = new GroupBox();
      this.Label1 = new Label();
      this.Fleet_List = new ComboBox();
      this.TableLayoutPanel1.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      this.TableLayoutPanel1.Anchor = AnchorStyles.None;
      this.TableLayoutPanel1.ColumnCount = 2;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
      TableLayoutPanel tableLayoutPanel1_1 = this.TableLayoutPanel1;
      Point point1 = new Point(88, 78);
      Point point2 = point1;
      tableLayoutPanel1_1.Location = point2;
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 1;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      TableLayoutPanel tableLayoutPanel1_2 = this.TableLayoutPanel1;
      Size size1 = new Size(146, 29);
      Size size2 = size1;
      tableLayoutPanel1_2.Size = size2;
      this.TableLayoutPanel1.TabIndex = 0;
      this.OK_Button.Anchor = AnchorStyles.None;
      Button okButton1 = this.OK_Button;
      point1 = new Point(3, 3);
      Point point3 = point1;
      okButton1.Location = point3;
      this.OK_Button.Name = "OK_Button";
      Button okButton2 = this.OK_Button;
      size1 = new Size(67, 23);
      Size size3 = size1;
      okButton2.Size = size3;
      this.OK_Button.TabIndex = 0;
      this.OK_Button.Text = "OK";
      this.Cancel_Button.Anchor = AnchorStyles.None;
      this.Cancel_Button.DialogResult = DialogResult.Cancel;
      Button cancelButton1 = this.Cancel_Button;
      point1 = new Point(76, 3);
      Point point4 = point1;
      cancelButton1.Location = point4;
      this.Cancel_Button.Name = "Cancel_Button";
      Button cancelButton2 = this.Cancel_Button;
      size1 = new Size(67, 23);
      Size size4 = size1;
      cancelButton2.Size = size4;
      this.Cancel_Button.TabIndex = 1;
      this.Cancel_Button.Text = "Cancel";
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.Fleet_List);
      GroupBox groupBox1_1 = this.GroupBox1;
      point1 = new Point(12, 12);
      Point point5 = point1;
      groupBox1_1.Location = point5;
      this.GroupBox1.Name = "GroupBox1";
      GroupBox groupBox1_2 = this.GroupBox1;
      size1 = new Size(300, 53);
      Size size5 = size1;
      groupBox1_2.Size = size5;
      this.GroupBox1.TabIndex = 1;
      this.GroupBox1.TabStop = false;
      this.Label1.AutoSize = true;
      Label label1_1 = this.Label1;
      point1 = new Point(7, 20);
      Point point6 = point1;
      label1_1.Location = point6;
      this.Label1.Name = "Label1";
      Label label1_2 = this.Label1;
      size1 = new Size(134, 13);
      Size size6 = size1;
      label1_2.Size = size6;
      this.Label1.TabIndex = 34;
      this.Label1.Text = "Choose a fleet from the list:";
      this.Fleet_List.BackColor = SystemColors.Window;
      this.Fleet_List.DropDownStyle = ComboBoxStyle.DropDownList;
      this.Fleet_List.FormattingEnabled = true;
      ComboBox fleetList1 = this.Fleet_List;
      point1 = new Point(147, 17);
      Point point7 = point1;
      fleetList1.Location = point7;
      this.Fleet_List.Name = "Fleet_List";
      ComboBox fleetList2 = this.Fleet_List;
      size1 = new Size(141, 21);
      Size size7 = size1;
      fleetList2.Size = size7;
      this.Fleet_List.TabIndex = 33;
      this.AcceptButton = (IButtonControl) this.OK_Button;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Cancel_Button;
      size1 = new Size(321, 119);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Dialog_Fleet);
      this.ShowInTaskbar = false;
      this.Text = "Fleet Manager";
      this.TopMost = true;
      this.TableLayoutPanel1.ResumeLayout(false);
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

    internal virtual TableLayoutPanel TableLayoutPanel1
    {
      [DebuggerNonUserCode] get => this._TableLayoutPanel1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._TableLayoutPanel1 = value;
    }

    internal virtual Button OK_Button
    {
      [DebuggerNonUserCode] get => this._OK_Button;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
        if (this._OK_Button != null)
          this._OK_Button.Click -= eventHandler;
        this._OK_Button = value;
        if (this._OK_Button == null)
          return;
        this._OK_Button.Click += eventHandler;
      }
    }

    internal virtual Button Cancel_Button
    {
      [DebuggerNonUserCode] get => this._Cancel_Button;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
        if (this._Cancel_Button != null)
          this._Cancel_Button.Click -= eventHandler;
        this._Cancel_Button = value;
        if (this._Cancel_Button == null)
          return;
        this._Cancel_Button.Click += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox1
    {
      [DebuggerNonUserCode] get => this._GroupBox1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._GroupBox1 = value;
    }

    internal virtual ComboBox Fleet_List
    {
      [DebuggerNonUserCode] get => this._Fleet_List;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Fleet_List = value;
    }

    internal virtual Label Label1
    {
      [DebuggerNonUserCode] get => this._Label1;
      [DebuggerNonUserCode, MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    private void Load_App(object sender, EventArgs e)
    {
      string favPath = MyProject.Forms.Home.FavPath;
      string[] files = Directory.GetFiles(favPath);
      int num = checked (Directory.GetFiles(favPath).Length - 1);
      int index = 0;
      while (index <= num)
      {
        string StringCheck = files[index];
        string str1 = StringCheck.Remove(0, Strings.InStrRev(StringCheck, "\\"));
        int startIndex = checked (str1.Length - 4);
        string str2 = str1.Remove(startIndex, 4);
        if (str2.StartsWith("fleet_"))
          this.Fleet_List.Items.Add((object) str2);
        checked { ++index; }
      }
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      MyProject.Forms.Home.FleetFile = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) MyProject.Forms.Home.FavPath, this.Fleet_List.SelectedItem), (object) ".txt"));
      if (Operators.CompareString(MyProject.Forms.Home.FleetManagerMode, "add", false) == 0)
        MyProject.Forms.Home.Fleet_Add_F();
      else if (Operators.CompareString(MyProject.Forms.Home.FleetManagerMode, "delete", false) == 0)
        MyProject.Forms.Home.Fleet_Delete_F();
      else if (Operators.CompareString(MyProject.Forms.Home.FleetManagerMode, "export", false) == 0)
        Functions.ExportToGMAT_M();
      this.Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }
}
