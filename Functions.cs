// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Functions
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  [StandardModule]
  internal sealed class Functions
  {
    public static string DS = DateTimeFormatInfo.CurrentInfo.DateSeparator;
    public static string TS = DateTimeFormatInfo.CurrentInfo.TimeSeparator;
    public static string FMT_dd_MM_yyyy = "dd" + Functions.DS + "MM" + Functions.DS + "yyyy";
    public static string FMT_HH_mm_ss = "HH" + Functions.TS + "mm" + Functions.TS + "ss";
    public static string FMT_HH_mm_ss_fff = Functions.FMT_HH_mm_ss + "ss.fff";
    public const double L22 = 345.07;
    public const double L31 = 6.98;
    public const double L33 = 20.99;

    [DllImport("Kernel32", EntryPoint = "GetPrivateProfileIntA", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern long GetPrivateProfileInt(
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName,
      long nDefault,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    [DllImport("Kernel32", EntryPoint = "WritePrivateProfileIntA", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern long WritePrivateProfileInt(
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName,
      long nDefault,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lplFileName);

    [DllImport("Kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern int GetPrivateProfileString(
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDefault,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpReturnedString,
      short nSize,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

    [DllImport("Kernel32", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern long WritePrivateProfileString(
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpApplicationName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpKeyName,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString,
      [MarshalAs(UnmanagedType.VBByRefStr)] ref string lplFileName);

    public static bool CheckNetwork()
    {
      bool flag;
      if (MyProject.Computer.Network.IsAvailable)
      {
        MyProject.Forms.Home.CheckNW = true;
        flag = true;
      }
      else
            {
                flag = false;
            }
      return flag;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static bool CheckVersion()
    {
      bool flag = true;
      try
      {
        Network network = MyProject.Computer.Network;
        object[] objArray1 = new object[7];
        object[] objArray2 = objArray1;
        Home home = MyProject.Forms.Home;
        object objectValue = RuntimeHelpers.GetObjectValue(home.CheckVersionFile);
        objArray2[0] = objectValue;
        objArray1[1] = (object) (MyProject.Forms.Home.AppPath + "version.txt");
        objArray1[2] = (object) "";
        objArray1[3] = (object) "";
        objArray1[4] = (object) false;
        objArray1[5] = (object) 100000;
        objArray1[6] = (object) true;
        object[] objArray3 = objArray1;
        object[] Arguments = objArray3;
        bool[] flagArray = new bool[7]
        {
          true,
          false,
          false,
          false,
          false,
          false,
          false
        };
        bool[] CopyBack = flagArray;
        NewLateBinding.LateCall((object) network, (Type) null, "DownloadFile", Arguments, (string[]) null, (Type[]) null, CopyBack, true);
        if (flagArray[0])
          home.CheckVersionFile = RuntimeHelpers.GetObjectValue(objArray3[0]);
        Microsoft.VisualBasic.FileSystem.FileOpen(1, MyProject.Forms.Home.AppPath + "version.txt", OpenMode.Input);
        Microsoft.VisualBasic.FileSystem.LineInput(1);
        string Expression = Microsoft.VisualBasic.FileSystem.LineInput(1);
        Microsoft.VisualBasic.FileSystem.FileClose(1);
        System.IO.File.Delete(MyProject.Forms.Home.AppPath + "version.txt");
        int integer1 = Conversions.ToInteger(Strings.Split(Expression, ".")[0]);
        int integer2 = Conversions.ToInteger(Strings.Split(Expression, ".")[1]);
        if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater((object) integer1, MyProject.Forms.Home.TLEAVersionMajor, false), Operators.AndObject(Operators.CompareObjectEqual((object) integer1, MyProject.Forms.Home.TLEAVersionMajor, false), Operators.CompareObjectGreater((object) integer2, MyProject.Forms.Home.TLEAVersionMinor, false)))))
        {
          if (TopMostMessageBox.Show("A new version of TLE ANALYSER is available.\r\nClick 'OK' to download the latest version.", "TLE ANALYSER", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            Process.Start("https://sourceforge.net/projects/tleanalyser/files/latest/download");
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) TopMostMessageBox.Show("Your Network seems to be restricted:\r\nTLE ANALYSER can't check new version availability.\r\n\r\n" + ex.Message, "TLE ANALYSER - Error");
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public static object Round4(double PARAM)
    {
      PARAM = Math.Round(PARAM, 4);
      return (object) PARAM;
    }

    public static double Norme(object Xval, object Yval, object Zval) => Math.Sqrt(Conversions.ToDouble(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(Xval, Xval), Operators.MultiplyObject(Yval, Yval)), Operators.MultiplyObject(Zval, Zval))));

    public static Vecteur ProduitVectoriel(Vecteur vec1, Vecteur vec2) => new Vecteur(vec1.Y * vec2.Z - vec1.Z * vec2.Y, vec1.Z * vec2.X - vec1.X * vec2.Z, vec1.X * vec2.Y - vec1.Y * vec2.X);

    public static double ProduitScalaire(Vecteur vec1, Vecteur vec2) => vec1.X * vec2.X + vec1.Y * vec2.Y + vec1.Z * vec2.Z;

    public static Vecteur Normalise(object Xval, object Yval, object Zval)
    {
      double num = Functions.Norme(RuntimeHelpers.GetObjectValue(Xval), RuntimeHelpers.GetObjectValue(Yval), RuntimeHelpers.GetObjectValue(Zval));
      double Right = Conversions.ToDouble(Interaction.IIf(num < 1E-10, (object) 1.0, (object) (1.0 / num)));
      return new Vecteur(Conversions.ToDouble(Operators.MultiplyObject(Xval, (object) Right)), Conversions.ToDouble(Operators.MultiplyObject(Yval, (object) Right)), Conversions.ToDouble(Operators.MultiplyObject(Zval, (object) Right)));
    }

    public static bool CheckEpoch()
    {
      bool flag = true;
      if (Operators.CompareString(MyProject.Forms.Home.EPOCH_Current.Text, "", false) == 0 || Operators.CompareString(MyProject.Forms.Home.EPOCH_Current.Text, (string) null, false) == 0)
        flag = false;
      return flag;
    }

    public static string MJDtoGreg(string epoch)
    {
      epoch = Conversions.ToString(Conversion.Val(epoch));
      object obj1 = (object) Math.Truncate(Conversions.ToDouble(epoch) + 2430000.0);
      object Right1 = Operators.AddObject(Operators.SubtractObject((object) (Conversions.ToDouble(epoch) + 2430000.0), obj1), (object) 0.5);
      object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(obj1, (object) 1867216.25), (object) 36524.25)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(objectValue1, (object) 4)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object Left1 = Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(obj1, (object) 1), objectValue1), objectValue2), (object) 1524);
      object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(Left1, (object) 122.1), (object) 365.25)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject((object) 365.25, objectValue3)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(Left1, objectValue4), (object) 30.6001)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject((object) 30.6001, obj2)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object Left2 = Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Left1, objectValue4), objectValue5), Right1);
      Type Type = typeof (Math);
      object[] objArray = new object[1]
      {
        RuntimeHelpers.GetObjectValue(Left2)
      };
      object[] Arguments = objArray;
      bool[] flagArray = new bool[1]{ true };
      bool[] CopyBack = flagArray;
      object obj3 = NewLateBinding.LateGet((object) null, Type, "Truncate", Arguments, (string[]) null, (Type[]) null, CopyBack);
      if (flagArray[0])
        Left2 = RuntimeHelpers.GetObjectValue(objArray[0]);
      object Left3 = RuntimeHelpers.GetObjectValue(obj3);
      if (Operators.ConditionalCompareObjectGreater(Left3, (object) 31, false))
      {
        Left3 = Operators.SubtractObject(Left3, (object) 31);
        obj2 = Operators.AddObject(obj2, (object) 1);
      }
      object Left4;
      Left4 = Operators.SubtractObject(obj2, (object)1);
      if (Operators.ConditionalCompareObjectLess(obj2, (object) 14, false))
        Left4 = Operators.SubtractObject(obj2, (object) 1);
      else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(obj2, (object) 14, false), Operators.CompareObjectEqual(obj2, (object) 14, false))))
        Left4 = Operators.SubtractObject(obj2, (object) 13);
      object Left5;
        Left5 = Operators.SubtractObject(objectValue3, (object)4716); 
        if (Operators.ConditionalCompareObjectGreater(Left4, (object) 2, false))
        Left5 = Operators.SubtractObject(objectValue3, (object) 4716);
      else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Left4, (object) 1, false), Operators.CompareObjectEqual(Left4, (object) 2, false))))
        Left5 = Operators.SubtractObject(objectValue3, (object) 4715);
      bool flag = false;
      int Right2 = 1912;
      do
      {
        if (Operators.ConditionalCompareObjectEqual(Left5, (object) Right2, false))
          flag = true;
        checked { Right2 += 4; }
      }
      while (Right2 <= 2112);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left3, (object) "31", false), Operators.CompareObjectEqual(Left4, (object) "02", false))))
      {
        Left3 = (object) "01";
        Left4 = (object) "03";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left3, (object) "31", false), Operators.CompareObjectEqual(Left4, (object) "04", false))))
      {
        Left3 = (object) "01";
        Left4 = (object) "05";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left3, (object) "31", false), Operators.CompareObjectEqual(Left4, (object) "06", false))))
      {
        Left3 = (object) "01";
        Left4 = (object) "07";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left3, (object) "31", false), Operators.CompareObjectEqual(Left4, (object) "09", false))))
      {
        Left3 = (object) "01";
        Left4 = (object) "10";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left3, (object) "31", false), Operators.CompareObjectEqual(Left4, (object) "11", false))))
      {
        Left3 = (object) "01";
        Left4 = (object) "12";
      }
      DateTime dateTime1 = DateAndTime.DateSerial(Conversions.ToInteger(Left5), Conversions.ToInteger(Left4), Conversions.ToInteger(Left3));
      object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject(Operators.ModObject(Left2, (object) 1), (object) 24)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue7 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject(Operators.ModObject(Operators.MultiplyObject(Operators.ModObject(Left2, (object) 1), (object) 24), (object) 1), (object) 60)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object Left6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
      {
        Operators.MultiplyObject(Operators.ModObject(Operators.MultiplyObject(Operators.ModObject(Operators.MultiplyObject(Operators.ModObject(Left2, (object) 1), (object) 24), (object) 1), (object) 60), (object) 1), (object) 60),
        (object) 0
      }, (string[]) null, (Type[]) null, (bool[]) null));
      if (Operators.ConditionalCompareObjectEqual(Left6, (object) 60, false))
        Left6 = (object) 59;
      DateTime dateTime2 = DateAndTime.TimeSerial(Conversions.ToInteger(objectValue6), Conversions.ToInteger(objectValue7), Conversions.ToInteger(Left6));
      epoch = Conversions.ToString(dateTime1) + " " + Conversions.ToString(dateTime2);
      return epoch;
    }

    public static string MJD2Day(string epoch)
    {
      epoch = Conversions.ToString(Conversion.Val(epoch));
      object obj1 = (object) Math.Truncate(Conversions.ToDouble(epoch) + 2430000.0);
      object Right1 = Operators.AddObject(Operators.SubtractObject((object) (Conversions.ToDouble(epoch) + 2430000.0), obj1), (object) 0.5);
      object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(obj1, (object) 1867216.25), (object) 36524.25)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(objectValue1, (object) 4)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object Left1 = Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(obj1, (object) 1), objectValue1), objectValue2), (object) 1524);
      object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(Left1, (object) 122.1), (object) 365.25)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject((object) 365.25, objectValue3)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(Left1, objectValue4), (object) 30.6001)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject((object) 30.6001, obj2)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object obj3 = Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Left1, objectValue4), objectValue5), Right1);
      Type Type = typeof (Math);
      object[] objArray = new object[1]
      {
        RuntimeHelpers.GetObjectValue(obj3)
      };
      object[] Arguments = objArray;
      bool[] flagArray = new bool[1]{ true };
      bool[] CopyBack = flagArray;
      object obj4 = NewLateBinding.LateGet((object) null, Type, "Truncate", Arguments, (string[]) null, (Type[]) null, CopyBack);
      if (flagArray[0])
        RuntimeHelpers.GetObjectValue(objArray[0]);
      object Left2 = RuntimeHelpers.GetObjectValue(obj4);
      if (Operators.ConditionalCompareObjectGreater(Left2, (object) 31, false))
      {
        Left2 = Operators.SubtractObject(Left2, (object) 31);
        obj2 = Operators.AddObject(obj2, (object) 1);
      }
      object Left3;
      Left3 = Operators.SubtractObject(obj2, (object)1); 
      if (Operators.ConditionalCompareObjectLess(obj2, (object) 14, false))
        Left3 = Operators.SubtractObject(obj2, (object) 1);
      else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(obj2, (object) 14, false), Operators.CompareObjectEqual(obj2, (object) 14, false))))
        Left3 = Operators.SubtractObject(obj2, (object) 13);
      object Left4;
      Left4 = Operators.SubtractObject(objectValue3, (object)4716); 
      if (Operators.ConditionalCompareObjectGreater(Left3, (object) 2, false))
        Left4 = Operators.SubtractObject(objectValue3, (object) 4716);
      else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Left3, (object) 1, false), Operators.CompareObjectEqual(Left3, (object) 2, false))))
        Left4 = Operators.SubtractObject(objectValue3, (object) 4715);
      bool flag = false;
      int Right2 = 1912;
      do
      {
        if (Operators.ConditionalCompareObjectEqual(Left4, (object) Right2, false))
          flag = true;
        checked { Right2 += 4; }
      }
      while (Right2 <= 2112);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left2, (object) "31", false), Operators.CompareObjectEqual(Left3, (object) "02", false))))
      {
        Left2 = (object) "01";
        Left3 = (object) "03";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left2, (object) "31", false), Operators.CompareObjectEqual(Left3, (object) "04", false))))
      {
        Left2 = (object) "01";
        Left3 = (object) "05";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left2, (object) "31", false), Operators.CompareObjectEqual(Left3, (object) "06", false))))
      {
        Left2 = (object) "01";
        Left3 = (object) "07";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left2, (object) "31", false), Operators.CompareObjectEqual(Left3, (object) "09", false))))
      {
        Left2 = (object) "01";
        Left3 = (object) "10";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Left2, (object) "31", false), Operators.CompareObjectEqual(Left3, (object) "11", false))))
      {
        Left2 = (object) "01";
        Left3 = (object) "12";
      }
      epoch = Conversions.ToString(DateAndTime.DateSerial(Conversions.ToInteger(Left4), Conversions.ToInteger(Left3), Conversions.ToInteger(Left2)));
      return epoch;
    }

    public static double GregtoMJD(string epoch)
    {
      int num1;
      double num2;
      int num3;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        DateTime date = Conversions.ToDate(epoch);
        object day = (object) date.Day;
        object month = (object) date.Month;
        object year = (object) date.Year;
        object hour = (object) date.Hour;
        object minute = (object) date.Minute;
        object second = (object) date.Second;
        epoch = Conversions.ToString(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.MultiplyObject((object) 367, year), Conversion.Int(Operators.DivideObject(Operators.MultiplyObject((object) 7, Operators.AddObject(year, Conversion.Int(Operators.DivideObject(Operators.AddObject(month, (object) 9), (object) 12)))), (object) 4))), Conversion.Int(Operators.DivideObject(Operators.MultiplyObject((object) 275, month), (object) 9))), day), (object) 1721013.5), (object) 2430000), Operators.DivideObject(Operators.AddObject(Operators.DivideObject(Operators.AddObject(Operators.DivideObject(second, (object) 60), minute), (object) 60), hour), (object) 24)));
        num2 = Conversions.ToDouble(epoch);
        goto label_8;
label_3:
        num3 = -1;
        switch (num1)
        {
          case 2:
            epoch = Conversions.ToString(0);
            num2 = Conversions.ToDouble(epoch);
            goto label_8;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_3;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_8:
      double num4 = num2;
      if (num3 == 0)
        return num4;
      ProjectData.ClearProjectError();
      return num4;
    }

    public static int GregtoYear(string epoch) => Conversions.ToDate(epoch).Year;

    public static double GregtoTLE(string epoch)
    {
      int num1;
      double num2;
      int num3;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        DateTime date = Conversions.ToDate(epoch);
        int integer = Conversions.ToInteger(Strings.Right(Conversions.ToString(date.Year), 4));
        date = Conversions.ToDate(epoch);
        int day = date.Day;
        date = Conversions.ToDate(epoch);
        int month = date.Month;
        date = Conversions.ToDate(epoch);
        int hour = date.Hour;
        date = Conversions.ToDate(epoch);
        int minute = date.Minute;
        date = Conversions.ToDate(epoch);
        int second = date.Second;
        if (!(DateTime.Compare(Conversions.ToDate(epoch), Conversions.ToDate("04/10/1957")) < 0 | DateTime.Compare(Conversions.ToDate(epoch), Conversions.ToDate("31/12/2056")) > 0))
        {
          int num4 = checked ((int) (DateAndTime.DateDiff(DateInterval.DayOfYear, Conversions.ToDate("01/01/" + Conversions.ToString(integer)), Conversions.ToDate(epoch)) + 1L));
          double num5 = (double) hour / 24.0 + (double) minute / 1440.0 + (double) second / 86400.0;
          num2 = Math.Round(Conversions.ToDouble(Strings.Right(Conversions.ToString(integer), 2)) * 1000.0 + (double) num4 + num5, 8);
          goto label_9;
        }
        else
        {
label_3:
          num2 = 0.0;
          goto label_9;
        }
label_4:
        num3 = -1;
        switch (num1)
        {
          case 2:
            goto label_3;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num3 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_4;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_9:
      double num6 = num2;
      if (num3 == 0)
        return num6;
      ProjectData.ClearProjectError();
      return num6;
    }

    public static double TLEtoMJD(double epoch)
    {
      double num1 = Conversion.Int(epoch / 1000.0);
      double num2 = num1 <= 0.0 || num1 >= 56.0 ? 1900.0 + num1 : 2000.0 + num1;
      double num3 = (epoch / 1000.0 - Conversion.Int(epoch / 1000.0)) * 1000.0;
      return 1721424.5 - Conversion.Int((num2 - 1.0) / 100.0) + Conversion.Int((num2 - 1.0) / 400.0) + Conversion.Int(365.25 * (num2 - 1.0)) + num3 - 2430000.0;
    }

    public static object HtoHMS(string Time)
    {
      object objectValue1 = RuntimeHelpers.GetObjectValue(Conversion.Int((object) Time));
      object objectValue2 = RuntimeHelpers.GetObjectValue(Conversion.Int(Operators.MultiplyObject(Operators.SubtractObject((object) Time, objectValue1), (object) 60)));
      object obj = Operators.MultiplyObject(Operators.SubtractObject(Operators.MultiplyObject(Operators.SubtractObject((object) Time, objectValue1), (object) 60), objectValue2), (object) 60);
      Time = DateAndTime.TimeSerial(Conversions.ToInteger(objectValue1), Conversions.ToInteger(objectValue2), Conversions.ToInteger(obj)).ToString(Functions.FMT_HH_mm_ss);
      return (object) Time;
    }

    public static string MJDGGEDate(double MJDate)
    {
      object obj1 = (object) Math.Truncate(MJDate + 2430000.0);
      object Right1 = Operators.AddObject(Operators.SubtractObject((object) (MJDate + 2430000.0), obj1), (object) 0.5);
      object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(obj1, (object) 1867216.25), (object) 36524.25)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(objectValue1, (object) 4)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object Left1 = Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(obj1, (object) 1), objectValue1), objectValue2), (object) 1524);
      object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(Left1, (object) 122.1), (object) 365.25)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject((object) 365.25, objectValue3)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(Left1, objectValue4), (object) 30.6001)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject((object) 30.6001, obj2)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object obj3 = Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Left1, objectValue4), objectValue5), Right1);
      Type Type = typeof (Math);
      object[] objArray = new object[1]
      {
        RuntimeHelpers.GetObjectValue(obj3)
      };
      object[] Arguments = objArray;
      bool[] flagArray = new bool[1]{ true };
      bool[] CopyBack = flagArray;
      object obj4 = NewLateBinding.LateGet((object) null, Type, "Truncate", Arguments, (string[]) null, (Type[]) null, CopyBack);
      if (flagArray[0])
        RuntimeHelpers.GetObjectValue(objArray[0]);
      object obj5 = RuntimeHelpers.GetObjectValue(obj4);
      if (Operators.ConditionalCompareObjectGreater(obj5, (object) 31, false))
      {
        obj5 = Operators.SubtractObject(obj5, (object) 31);
        obj2 = Operators.AddObject(obj2, (object) 1);
      }
      object obj6;
      if (Operators.ConditionalCompareObjectLess(obj2, (object) 14, false))
        obj6 = Operators.SubtractObject(obj2, (object) 1);
      else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectGreater(obj2, (object) 14, false), Operators.CompareObjectEqual(obj2, (object) 14, false))))
        obj6 = Operators.SubtractObject(obj2, (object) 13);
      object Left2;
      if (Operators.ConditionalCompareObjectGreater(obj6, (object) 2, false))
        Left2 = Operators.SubtractObject(objectValue3, (object) 4716);
      else if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(obj6, (object) 1, false), Operators.CompareObjectEqual(obj6, (object) 2, false))))
        Left2 = Operators.SubtractObject(objectValue3, (object) 4715);
      bool flag = false;
      int Right2 = 1912;
      do
      {
        if (Operators.ConditionalCompareObjectEqual(Left2, (object) Right2, false))
          flag = true;
        checked { Right2 += 4; }
      }
      while (Right2 <= 2112);
      if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj5, (object) "31", false), Operators.CompareObjectEqual(obj6, (object) "02", false))))
      {
        obj5 = (object) "01";
        obj6 = (object) "03";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj5, (object) "31", false), Operators.CompareObjectEqual(obj6, (object) "04", false))))
      {
        obj5 = (object) "01";
        obj6 = (object) "05";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj5, (object) "31", false), Operators.CompareObjectEqual(obj6, (object) "06", false))))
      {
        obj5 = (object) "01";
        obj6 = (object) "07";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj5, (object) "31", false), Operators.CompareObjectEqual(obj6, (object) "09", false))))
      {
        obj5 = (object) "01";
        obj6 = (object) "10";
      }
      else if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(obj5, (object) "31", false), Operators.CompareObjectEqual(obj6, (object) "11", false))))
      {
        obj5 = (object) "01";
        obj6 = (object) "12";
      }
      return Conversions.ToString((object) Conversions.ToDate(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Left2, (object) "-"), obj6), (object) "-"), obj5)).ToString("yyyy-MM-dd"));
    }

    public static string MJDGGEHour(double MJDate)
    {
      object obj1 = (object) Math.Truncate(MJDate + 2430000.0);
      object Right = Operators.AddObject(Operators.SubtractObject((object) (MJDate + 2430000.0), obj1), (object) 0.5);
      object objectValue1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(Operators.SubtractObject(obj1, (object) 1867216.25), (object) 36524.25)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.DivideObject(objectValue1, (object) 4)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object Left1 = Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(obj1, (object) 1), objectValue1), objectValue2), (object) 1524);
      object objectValue3 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject((object) 365.25, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
        {
          Operators.DivideObject(Operators.SubtractObject(Left1, (object) 122.1), (object) 365.25)
        }, (string[]) null, (Type[]) null, (bool[]) null)))
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue4 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject((object) 30.6001, RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
        {
          Operators.DivideObject(Operators.SubtractObject(Left1, objectValue3), (object) 30.6001)
        }, (string[]) null, (Type[]) null, (bool[]) null)))
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object Left2 = Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Left1, objectValue3), objectValue4), Right);
      object objectValue5 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject(Operators.ModObject(Left2, (object) 1), (object) 24)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object objectValue6 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Truncate", new object[1]
      {
        Operators.MultiplyObject(Operators.ModObject(Operators.MultiplyObject(Operators.ModObject(Left2, (object) 1), (object) 24), (object) 1), (object) 60)
      }, (string[]) null, (Type[]) null, (bool[]) null));
      object obj2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[2]
      {
        Operators.MultiplyObject(Operators.ModObject(Operators.MultiplyObject(Operators.ModObject(Operators.MultiplyObject(Operators.ModObject(Left2, (object) 1), (object) 24), (object) 1), (object) 60), (object) 1), (object) 60),
        (object) 0
      }, (string[]) null, (Type[]) null, (bool[]) null));
      if (Operators.ConditionalCompareObjectEqual(obj2, (object) 60, false))
        obj2 = (object) 59;
      return Conversions.ToString((object) Conversions.ToDate(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue5, (object) Functions.TS), objectValue6), (object) Functions.TS), obj2)).ToString(Functions.FMT_HH_mm_ss));
    }

    public static object CurrentDateToGreg()
    {
      DateTime universalTime = TimeZone.CurrentTimeZone.ToUniversalTime(DateTime.Now);
      object year = (object) universalTime.Year;
      object month = (object) universalTime.Month;
      object day = (object) universalTime.Day;
      object hour = (object) universalTime.Hour;
      object minute = (object) universalTime.Minute;
      object second = (object) universalTime.Second;
      return (object) (Conversions.ToString(DateAndTime.DateSerial(Conversions.ToInteger(year), Conversions.ToInteger(month), Conversions.ToInteger(day))) + " " + Conversions.ToString(DateAndTime.TimeSerial(Conversions.ToInteger(hour), Conversions.ToInteger(minute), Conversions.ToInteger(second))));
    }

    public static Dates MJD2JJ(double epoch)
    {
      DateTime date = Conversions.ToDate(Functions.MJDtoGreg(Conversions.ToString(epoch)));
      double day = (double) date.Day;
      double month = (double) date.Month;
      double year = (double) date.Year;
      double hour = (double) date.Hour;
      double minute = (double) date.Minute;
      double second = (double) date.Second;
      return new Dates(checked ((int) Math.Round(year)), checked ((int) Math.Round(month)), checked ((int) Math.Round(day)), checked ((int) Math.Round(hour)), checked ((int) Math.Round(minute)), second, 0.0);
    }

    public static object CheckCaracts(ref string StringToCheck)
    {
      object Left1 = (object) Strings.InStr(1, StringToCheck, "/");
      if (Operators.ConditionalCompareObjectEqual(Left1, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left1), 1, "_");
      object Left2 = (object) Strings.InStr(1, StringToCheck, "\\");
      if (Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left2), 1, "_");
      object Left3 = (object) Strings.InStr(1, StringToCheck, ":");
      if (Operators.ConditionalCompareObjectEqual(Left3, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left3), 1, "_");
      object Left4 = (object) Strings.InStr(1, StringToCheck, "*");
      if (Operators.ConditionalCompareObjectEqual(Left4, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left4), 1, "_");
      object Left5 = (object) Strings.InStr(1, StringToCheck, "?");
      if (Operators.ConditionalCompareObjectEqual(Left5, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left5), 1, "_");
      object Left6 = (object) Strings.InStr(1, StringToCheck, "<");
      if (Operators.ConditionalCompareObjectEqual(Left6, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left6), 1, "_");
      object Left7 = (object) Strings.InStr(1, StringToCheck, ">");
      if (Operators.ConditionalCompareObjectEqual(Left7, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left7), 1, "_");
      object Left8 = (object) Strings.InStr(1, StringToCheck, "|");
      if (Operators.ConditionalCompareObjectEqual(Left8, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left8), 1, "_");
      object Left9 = (object) Strings.InStr(1, StringToCheck, "!");
      if (Operators.ConditionalCompareObjectEqual(Left9, (object) 0, false))
        StringToCheck = StringToCheck;
      else
        StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left9), 1, "_");
      return (object) StringToCheck;
    }

    public static object CheckCaracts_M(ref string StringToCheck)
    {
      if (Versioned.IsNumeric((object) Strings.Mid(StringToCheck, 1, 1)))
        StringToCheck = "S_" + StringToCheck;
      int length = StringToCheck.Length;
      int num = 0;
      while (num <= length)
      {
        object Left1 = (object) Strings.InStr(1, StringToCheck, "/");
        if (Operators.ConditionalCompareObjectEqual(Left1, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left1), 1, "_");
        object Left2 = (object) Strings.InStr(1, StringToCheck, "\\");
        if (Operators.ConditionalCompareObjectEqual(Left2, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left2), 1, "_");
        object Left3 = (object) Strings.InStr(1, StringToCheck, ":");
        if (Operators.ConditionalCompareObjectEqual(Left3, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left3), 1, "_");
        object Left4 = (object) Strings.InStr(1, StringToCheck, "*");
        if (Operators.ConditionalCompareObjectEqual(Left4, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left4), 1, "_");
        object Left5 = (object) Strings.InStr(1, StringToCheck, "?");
        if (Operators.ConditionalCompareObjectEqual(Left5, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left5), 1, "_");
        object Left6 = (object) Strings.InStr(1, StringToCheck, "<");
        if (Operators.ConditionalCompareObjectEqual(Left6, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left6), 1, "_");
        object Left7 = (object) Strings.InStr(1, StringToCheck, ">");
        if (Operators.ConditionalCompareObjectEqual(Left7, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left7), 1, "_");
        object Left8 = (object) Strings.InStr(1, StringToCheck, "|");
        if (Operators.ConditionalCompareObjectEqual(Left8, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left8), 1, "_");
        object Left9 = (object) Strings.InStr(1, StringToCheck, "!");
        if (Operators.ConditionalCompareObjectEqual(Left9, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left9), 1, "_");
        object Left10 = (object) Strings.InStr(1, StringToCheck, "-");
        if (Operators.ConditionalCompareObjectEqual(Left10, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left10), 1, "_");
        object Left11 = (object) Strings.InStr(1, StringToCheck, " ");
        if (Operators.ConditionalCompareObjectEqual(Left11, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left11), 1, "_");
        object Left12 = (object) Strings.InStr(1, StringToCheck, " (");
        if (Operators.ConditionalCompareObjectEqual(Left12, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left12), 1, "_");
        object Left13 = (object) Strings.InStr(1, StringToCheck, ")");
        if (Operators.ConditionalCompareObjectEqual(Left13, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left13), 1, "_");
        object Left14 = (object) Strings.InStr(1, StringToCheck, "(");
        if (Operators.ConditionalCompareObjectEqual(Left14, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left14), 1, "_");
        object Left15 = (object) Strings.InStr(1, StringToCheck, "[");
        if (Operators.ConditionalCompareObjectEqual(Left15, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left15), 1, "_");
        object Left16 = (object) Strings.InStr(1, StringToCheck, "]");
        if (Operators.ConditionalCompareObjectEqual(Left16, (object) 0, false))
          StringToCheck = StringToCheck;
        else
          StringType.MidStmtStr(ref StringToCheck, Conversions.ToInteger(Left16), 1, "_");
        checked { ++num; }
      }
      return (object) StringToCheck;
    }

    public static void KepleriantoCartesian(
      double SMA,
      double ECC,
      double INC,
      double RAAN,
      double AOP,
      double TA)
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
        double num4 = Conversion.Val((object) (SMA * (1.0 - Math.Pow(ECC, 2.0))));
label_3:
        num3 = 3;
        double num5 = Conversion.Val((object) (num4 / (1.0 + ECC * Math.Cos(Math.PI / 180.0 * TA))));
label_4:
        num3 = 4;
        MyProject.Forms.Home.X = num5 * (Math.Cos(Math.PI / 180.0 * (AOP + TA)) * Math.Cos(Math.PI / 180.0 * RAAN) - Math.Cos(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * (AOP + TA)) * Math.Sin(Math.PI / 180.0 * RAAN));
label_5:
        num3 = 5;
        MyProject.Forms.Home.Y = num5 * (Math.Cos(Math.PI / 180.0 * (AOP + TA)) * Math.Sin(Math.PI / 180.0 * RAAN) + Math.Cos(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * (AOP + TA)) * Math.Cos(Math.PI / 180.0 * RAAN));
label_6:
        num3 = 6;
        MyProject.Forms.Home.Z = num5 * (Math.Sin(Math.PI / 180.0 * (AOP + TA)) * Math.Sin(Math.PI / 180.0 * INC));
label_7:
        num3 = 7;
        MyProject.Forms.Home.VX = Math.Sqrt(398600.4418 / num4) * (Math.Cos(Math.PI / 180.0 * TA) + ECC) * (-Math.Sin(Math.PI / 180.0 * AOP) * Math.Cos(Math.PI / 180.0 * RAAN) - Math.Cos(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * RAAN) * Math.Cos(Math.PI / 180.0 * AOP)) - Math.Sqrt(398600.4418 / num4) * Math.Sin(Math.PI / 180.0 * TA) * (Math.Cos(Math.PI / 180.0 * AOP) * Math.Cos(Math.PI / 180.0 * RAAN) - Math.Cos(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * RAAN) * Math.Sin(Math.PI / 180.0 * AOP));
label_8:
        num3 = 8;
        MyProject.Forms.Home.VY = Math.Sqrt(398600.4418 / num4) * (Math.Cos(Math.PI / 180.0 * TA) + ECC) * (-Math.Sin(Math.PI / 180.0 * AOP) * Math.Sin(Math.PI / 180.0 * RAAN) + Math.Cos(Math.PI / 180.0 * INC) * Math.Cos(Math.PI / 180.0 * RAAN) * Math.Cos(Math.PI / 180.0 * AOP)) - Math.Sqrt(398600.4418 / num4) * Math.Sin(Math.PI / 180.0 * TA) * (Math.Cos(Math.PI / 180.0 * AOP) * Math.Sin(Math.PI / 180.0 * RAAN) + Math.Cos(Math.PI / 180.0 * INC) * Math.Cos(Math.PI / 180.0 * RAAN) * Math.Sin(Math.PI / 180.0 * AOP));
label_9:
        num3 = 9;
        MyProject.Forms.Home.VZ = Math.Sqrt(398600.4418 / num4) * ((Math.Cos(Math.PI / 180.0 * TA) + ECC) * Math.Sin(Math.PI / 180.0 * INC) * Math.Cos(Math.PI / 180.0 * AOP) - Math.Sin(Math.PI / 180.0 * TA) * Math.Sin(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * AOP));
        goto label_16;
label_11:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num6 = num2 + 1;
            num2 = 0;
            switch (num6)
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
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_16;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
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

    public static void KepleriantoCartesianCreate(
      double SMA,
      double ECC,
      double INC,
      double RAAN,
      double AOP,
      double TA)
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
        double num4 = Conversion.Val((object) (SMA * (1.0 - Math.Pow(ECC, 2.0))));
label_3:
        num3 = 3;
        double num5 = Conversion.Val((object) (num4 / (1.0 + ECC * Math.Cos(Math.PI / 180.0 * TA))));
label_4:
        num3 = 4;
        MyProject.Forms.Home.XCr = num5 * (Math.Cos(Math.PI / 180.0 * (AOP + TA)) * Math.Cos(Math.PI / 180.0 * RAAN) - Math.Cos(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * (AOP + TA)) * Math.Sin(Math.PI / 180.0 * RAAN));
label_5:
        num3 = 5;
        MyProject.Forms.Home.YCr = num5 * (Math.Cos(Math.PI / 180.0 * (AOP + TA)) * Math.Sin(Math.PI / 180.0 * RAAN) + Math.Cos(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * (AOP + TA)) * Math.Cos(Math.PI / 180.0 * RAAN));
label_6:
        num3 = 6;
        MyProject.Forms.Home.ZCr = num5 * (Math.Sin(Math.PI / 180.0 * (AOP + TA)) * Math.Sin(Math.PI / 180.0 * INC));
label_7:
        num3 = 7;
        MyProject.Forms.Home.VXCr = Math.Sqrt(398600.4418 / num4) * (Math.Cos(Math.PI / 180.0 * TA) + ECC) * (-Math.Sin(Math.PI / 180.0 * AOP) * Math.Cos(Math.PI / 180.0 * RAAN) - Math.Cos(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * RAAN) * Math.Cos(Math.PI / 180.0 * AOP)) - Math.Sqrt(398600.4418 / num4) * Math.Sin(Math.PI / 180.0 * TA) * (Math.Cos(Math.PI / 180.0 * AOP) * Math.Cos(Math.PI / 180.0 * RAAN) - Math.Cos(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * RAAN) * Math.Sin(Math.PI / 180.0 * AOP));
label_8:
        num3 = 8;
        MyProject.Forms.Home.VYCr = Math.Sqrt(398600.4418 / num4) * (Math.Cos(Math.PI / 180.0 * TA) + ECC) * (-Math.Sin(Math.PI / 180.0 * AOP) * Math.Sin(Math.PI / 180.0 * RAAN) + Math.Cos(Math.PI / 180.0 * INC) * Math.Cos(Math.PI / 180.0 * RAAN) * Math.Cos(Math.PI / 180.0 * AOP)) - Math.Sqrt(398600.4418 / num4) * Math.Sin(Math.PI / 180.0 * TA) * (Math.Cos(Math.PI / 180.0 * AOP) * Math.Sin(Math.PI / 180.0 * RAAN) + Math.Cos(Math.PI / 180.0 * INC) * Math.Cos(Math.PI / 180.0 * RAAN) * Math.Sin(Math.PI / 180.0 * AOP));
label_9:
        num3 = 9;
        MyProject.Forms.Home.VZCr = Math.Sqrt(398600.4418 / num4) * ((Math.Cos(Math.PI / 180.0 * TA) + ECC) * Math.Sin(Math.PI / 180.0 * INC) * Math.Cos(Math.PI / 180.0 * AOP) - Math.Sin(Math.PI / 180.0 * TA) * Math.Sin(Math.PI / 180.0 * INC) * Math.Sin(Math.PI / 180.0 * AOP));
        goto label_16;
label_11:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num6 = num2 + 1;
            num2 = 0;
            switch (num6)
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
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_16;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
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

    public static void CartesianToKeplerian(
      double Xval,
      double Yval,
      double Zval,
      double VXval,
      double VYval,
      double VZval)
    {
      Vecteur vecteur1 = new Vecteur(Xval, Yval, Zval);
      Vecteur vecteur2 = new Vecteur(VXval, VYval, VZval);
      MyProject.Forms.Home.SMA = -199300.2209 / (Math.Pow(Functions.Norme((object) VXval, (object) VYval, (object) VZval), 2.0) / 2.0 - 398600.4418 / Functions.Norme((object) Xval, (object) Yval, (object) Zval));
      double num1 = Functions.Norme((object) vecteur1.X, (object) vecteur1.Y, (object) vecteur1.Z);
      Vecteur vec2_1 = Functions.ProduitVectoriel(vecteur1, vecteur2);
      double num2 = Functions.Norme((object) vec2_1.X, (object) vec2_1.Y, (object) vec2_1.Z);
      Vecteur vecteur3 = Functions.ProduitVectoriel(vecteur2, vec2_1);
      Vecteur vecteur4 = new Vecteur(vecteur3.X / 398600.4418, vecteur3.Y / 398600.4418, vecteur3.Z / 398600.4418);
      Vecteur vecteur5 = new Vecteur(vecteur1.X / num1, vecteur1.Y / num1, vecteur1.Z / num1);
      Vecteur vec1 = new Vecteur(vecteur4.X - vecteur5.X, vecteur4.Y - vecteur5.Y, vecteur4.Z - vecteur5.Z);
      MyProject.Forms.Home.ECC = Functions.Norme((object) vec1.X, (object) vec1.Y, (object) vec1.Z);
      MyProject.Forms.Home.INC = 180.0 / Math.PI * Math.Acos(vec2_1.Z / num2);
      Vecteur vec2_2 = Functions.ProduitVectoriel(new Vecteur(0.0, 0.0, 1.0), vec2_1);
      double num3 = Functions.ProduitScalaire(vec1, vecteur1);
      double num4 = Functions.Norme((object) vec2_2.X, (object) vec2_2.Y, (object) vec2_2.Z);
      MyProject.Forms.Home.RAAN = 180.0 / Math.PI * Math.Acos(vec2_2.X / num4);
      if (vec2_2.Y < 0.0)
        MyProject.Forms.Home.RAAN = 360.0 - MyProject.Forms.Home.RAAN;
      MyProject.Forms.Home.AOP = 180.0 / Math.PI * Math.Acos(Functions.ProduitScalaire(vec1, vec2_2) / (num4 * MyProject.Forms.Home.ECC));
      if (vec1.Z < 0.0)
        MyProject.Forms.Home.AOP = 360.0 - MyProject.Forms.Home.AOP;
      MyProject.Forms.Home.TA = Math.Acos(num3 / (MyProject.Forms.Home.ECC * num1));
      if (Functions.ProduitScalaire(vecteur1, vecteur2) < 0.0)
        MyProject.Forms.Home.TA = 2.0 * Math.PI - MyProject.Forms.Home.TA;
      MyProject.Forms.Home.EA = Math.Acos((MyProject.Forms.Home.ECC + Math.Cos(MyProject.Forms.Home.TA)) / (1.0 + MyProject.Forms.Home.ECC * Math.Cos(MyProject.Forms.Home.TA)));
      if (MyProject.Forms.Home.TA > Math.PI)
        MyProject.Forms.Home.EA = 2.0 * Math.PI - MyProject.Forms.Home.EA;
      MyProject.Forms.Home.MA = 180.0 / Math.PI * (MyProject.Forms.Home.EA - MyProject.Forms.Home.ECC * Math.Sin(MyProject.Forms.Home.EA));
    }

    public static void CartesianToKeplerianChart(
      double Xval,
      double Yval,
      double Zval,
      double VXval,
      double VYval,
      double VZval)
    {
      Vecteur vecteur1 = new Vecteur(Xval, Yval, Zval);
      Vecteur vecteur2 = new Vecteur(VXval, VYval, VZval);
      MyProject.Forms.Home.SMAC = -199300.2209 / (Math.Pow(Functions.Norme((object) VXval, (object) VYval, (object) VZval), 2.0) / 2.0 - 398600.4418 / Functions.Norme((object) Xval, (object) Yval, (object) Zval));
      double num1 = Functions.Norme((object) vecteur1.X, (object) vecteur1.Y, (object) vecteur1.Z);
      Vecteur vec2_1 = Functions.ProduitVectoriel(vecteur1, vecteur2);
      double num2 = Functions.Norme((object) vec2_1.X, (object) vec2_1.Y, (object) vec2_1.Z);
      Vecteur vecteur3 = Functions.ProduitVectoriel(vecteur2, vec2_1);
      Vecteur vecteur4 = new Vecteur(vecteur3.X / 398600.4418, vecteur3.Y / 398600.4418, vecteur3.Z / 398600.4418);
      Vecteur vecteur5 = new Vecteur(vecteur1.X / num1, vecteur1.Y / num1, vecteur1.Z / num1);
      Vecteur vec1 = new Vecteur(vecteur4.X - vecteur5.X, vecteur4.Y - vecteur5.Y, vecteur4.Z - vecteur5.Z);
      MyProject.Forms.Home.ECCC = Functions.Norme((object) vec1.X, (object) vec1.Y, (object) vec1.Z);
      MyProject.Forms.Home.INCC = 180.0 / Math.PI * Math.Acos(vec2_1.Z / num2);
      Vecteur vec2_2 = Functions.ProduitVectoriel(new Vecteur(0.0, 0.0, 1.0), vec2_1);
      double num3 = Functions.ProduitScalaire(vec1, vecteur1);
      double num4 = Functions.Norme((object) vec2_2.X, (object) vec2_2.Y, (object) vec2_2.Z);
      MyProject.Forms.Home.RAANC = 180.0 / Math.PI * Math.Acos(vec2_2.X / num4);
      if (vec2_2.Y < 0.0)
        MyProject.Forms.Home.RAANC = 360.0 - MyProject.Forms.Home.RAANC;
      MyProject.Forms.Home.AOPC = 180.0 / Math.PI * Math.Acos(Functions.ProduitScalaire(vec1, vec2_2) / (num4 * MyProject.Forms.Home.ECCC));
      if (vec1.Z < 0.0)
        MyProject.Forms.Home.AOPC = 360.0 - MyProject.Forms.Home.AOPC;
      MyProject.Forms.Home.TAC = Math.Acos(num3 / (MyProject.Forms.Home.ECCC * num1));
      if (Functions.ProduitScalaire(vecteur1, vecteur2) >= 0.0)
        return;
      MyProject.Forms.Home.TAC = 2.0 * Math.PI - MyProject.Forms.Home.TAC;
    }

    public static void CartesianToKeplerianCreate(
      double Xval,
      double Yval,
      double Zval,
      double VXval,
      double VYval,
      double VZval)
    {
      Vecteur vecteur1 = new Vecteur(Xval, Yval, Zval);
      Vecteur vecteur2 = new Vecteur(VXval, VYval, VZval);
      MyProject.Forms.Home.SMACr = -199300.2209 / (Math.Pow(Functions.Norme((object) VXval, (object) VYval, (object) VZval), 2.0) / 2.0 - 398600.4418 / Functions.Norme((object) Xval, (object) Yval, (object) Zval));
      double num1 = Functions.Norme((object) vecteur1.X, (object) vecteur1.Y, (object) vecteur1.Z);
      Vecteur vec2_1 = Functions.ProduitVectoriel(vecteur1, vecteur2);
      double num2 = Functions.Norme((object) vec2_1.X, (object) vec2_1.Y, (object) vec2_1.Z);
      Vecteur vecteur3 = Functions.ProduitVectoriel(vecteur2, vec2_1);
      Vecteur vecteur4 = new Vecteur(vecteur3.X / 398600.4418, vecteur3.Y / 398600.4418, vecteur3.Z / 398600.4418);
      Vecteur vecteur5 = new Vecteur(vecteur1.X / num1, vecteur1.Y / num1, vecteur1.Z / num1);
      Vecteur vec1 = new Vecteur(vecteur4.X - vecteur5.X, vecteur4.Y - vecteur5.Y, vecteur4.Z - vecteur5.Z);
      MyProject.Forms.Home.ECCCr = Functions.Norme((object) vec1.X, (object) vec1.Y, (object) vec1.Z);
      MyProject.Forms.Home.INCCr = 180.0 / Math.PI * Math.Acos(vec2_1.Z / num2);
      Vecteur vec2_2 = Functions.ProduitVectoriel(new Vecteur(0.0, 0.0, 1.0), vec2_1);
      double num3 = Functions.ProduitScalaire(vec1, vecteur1);
      double num4 = Functions.Norme((object) vec2_2.X, (object) vec2_2.Y, (object) vec2_2.Z);
      MyProject.Forms.Home.RAANCr = num4 != 0.0 ? 180.0 / Math.PI * Math.Acos(vec2_2.X / num4) : 0.0;
      if (vec2_2.Y < 0.0)
        MyProject.Forms.Home.RAANCr = 360.0 - MyProject.Forms.Home.RAANCr;
      double num5 = Functions.ProduitScalaire(vec1, vec2_2);
      MyProject.Forms.Home.AOPCr = num4 != 0.0 ? 180.0 / Math.PI * Math.Acos(num5 / (num4 * MyProject.Forms.Home.ECCCr)) : 0.0;
      if (vec1.Z < 0.0)
        MyProject.Forms.Home.AOPCr = 360.0 - MyProject.Forms.Home.AOPCr;
      MyProject.Forms.Home.TACr = Math.Acos(num3 / (MyProject.Forms.Home.ECCCr * num1));
      if (Functions.ProduitScalaire(vecteur1, vecteur2) < 0.0)
        MyProject.Forms.Home.TACr = 2.0 * Math.PI - MyProject.Forms.Home.TACr;
      MyProject.Forms.Home.TACr = 180.0 / Math.PI * MyProject.Forms.Home.TACr;
    }

    public static void AdpatedParameters()
    {
      if (MyProject.Forms.Home.ECC < 0.1 && MyProject.Forms.Home.INC < 1.0 && MyProject.Forms.Home.INC > -1.0)
      {
        MyProject.Forms.Home.CircularPanel.Visible = false;
        MyProject.Forms.Home.EquPanel.Visible = false;
        MyProject.Forms.Home.CircEquPanel.Visible = true;
        double num = Math.Round((MyProject.Forms.Home.AOP + MyProject.Forms.Home.RAAN) % 360.0, 4);
        MyProject.Forms.Home.SMA_AP_ECCINC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.SMA, 3));
        MyProject.Forms.Home.ex_ECCINC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.ECC * Math.Cos(Math.PI / 180.0 * num), 4));
        MyProject.Forms.Home.ey_ECCINC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.ECC * Math.Sin(Math.PI / 180.0 * num), 4));
        MyProject.Forms.Home.ix_ECCINC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.INC * Math.Cos(Math.PI / 180.0 * MyProject.Forms.Home.RAAN), 4));
        MyProject.Forms.Home.iy_ECCINC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.INC * Math.Sin(Math.PI / 180.0 * MyProject.Forms.Home.RAAN), 4));
        MyProject.Forms.Home.MeanL_ECCINC.Text = Conversions.ToString(Math.Round((MyProject.Forms.Home.AOP + MyProject.Forms.Home.RAAN + MyProject.Forms.Home.MA - MyProject.Forms.Home.GST) % 360.0, 4));
      }
      else if (MyProject.Forms.Home.ECC < 0.1)
      {
        MyProject.Forms.Home.CircEquPanel.Visible = false;
        MyProject.Forms.Home.EquPanel.Visible = false;
        MyProject.Forms.Home.CircularPanel.Visible = true;
        MyProject.Forms.Home.SMA_AP_ECC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.SMA, 3));
        MyProject.Forms.Home.ex.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.ECC * Math.Cos(Math.PI / 180.0 * MyProject.Forms.Home.AOP), 4));
        MyProject.Forms.Home.ey.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.ECC * Math.Sin(Math.PI / 180.0 * MyProject.Forms.Home.AOP), 4));
        MyProject.Forms.Home.INC_AP_ECC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.INC, 4));
        MyProject.Forms.Home.RAAN_AP_ECC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.RAAN, 4));
        MyProject.Forms.Home.AlphaPrime.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.AOL, 4));
      }
      else if (MyProject.Forms.Home.INC < 1.0 && MyProject.Forms.Home.INC > -1.0)
      {
        MyProject.Forms.Home.CircularPanel.Visible = false;
        MyProject.Forms.Home.CircEquPanel.Visible = false;
        MyProject.Forms.Home.EquPanel.Visible = true;
        MyProject.Forms.Home.SMA_AP_INC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.SMA, 3));
        MyProject.Forms.Home.ECC_AP_INC.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.ECC, 4));
        MyProject.Forms.Home.AOP_AP_INC.Text = Conversions.ToString(Math.Round((MyProject.Forms.Home.AOP + MyProject.Forms.Home.RAAN) % 360.0, 4));
        MyProject.Forms.Home.ix.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.INC * Math.Cos(Math.PI / 180.0 * MyProject.Forms.Home.RAAN), 4));
        MyProject.Forms.Home.iy.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.INC * Math.Sin(Math.PI / 180.0 * MyProject.Forms.Home.RAAN), 4));
        MyProject.Forms.Home.MA_AP.Text = Conversions.ToString(Math.Round(MyProject.Forms.Home.MA, 4));
      }
      else
      {
        MyProject.Forms.Home.CircularPanel.Visible = false;
        MyProject.Forms.Home.CircEquPanel.Visible = false;
        MyProject.Forms.Home.EquPanel.Visible = false;
        MyProject.Forms.Home.AP_GroupBox.Text = "Adapted Parameters";
      }
    }

    public static void LATLONG(double X, double Y, double Z, double GST)
    {
      double num1 = Math.Sqrt(X * X + Y * Y);
      double num2 = Math.Atan(Z / num1);
      double num3;
      double num4;
      for (double a = 7.0; Math.Abs(num2 - a) > 1E-07; num2 = Math.Atan((Z + 6378.136658 * num4 * 0.00669431777826672 * num3) / num1))
      {
        a = num2;
        num3 = Math.Sin(a);
        num4 = 1.0 / Math.Sqrt(1.0 - 0.00669431777826672 * num3 * num3);
      }
      MyProject.Forms.Home.LAT_RAD = num2;
      MyProject.Forms.Home.LAT = 180.0 / Math.PI * num2;
      MyProject.Forms.Home.LNG_RAD = (Math.Atan2(Y, X) - Math.PI / 180.0 * GST) % (2.0 * Math.PI);
      double num5 = 180.0 / Math.PI * MyProject.Forms.Home.LNG_RAD;
      if (num5 > 180.0)
        MyProject.Forms.Home.LONGI = num5 - 360.0;
      else if (num5 < -180.0)
        MyProject.Forms.Home.LONGI = 360.0 + num5;
      else
        MyProject.Forms.Home.LONGI = num5;
    }

    public static object ETFXP_F(double EP)
    {
      MyProject.Forms.Home.GSTXP = Functions.GSTCalc((object) EP);
      MyProject.Forms.Home.SGP4_XP_EPOCH(EP, MyProject.Forms.Home.TLEPOCH);
      Functions.LATLONGXP(MyProject.Forms.Home.XXP, MyProject.Forms.Home.YXP, MyProject.Forms.Home.ZXP, MyProject.Forms.Home.GSTXP);
      object obj;
      return obj;
    }

    public static void LATLONGXP(double X, double Y, double Z, double GST)
    {
      double num1 = Math.Sqrt(X * X + Y * Y);
      double num2 = Math.Atan(Z / num1);
      double num3;
      double num4;
      for (double a = 7.0; Math.Abs(num2 - a) > 1E-07; num2 = Math.Atan((Z + 6378.136658 * num4 * 0.00669431777826672 * num3) / num1))
      {
        a = num2;
        num3 = Math.Sin(a);
        num4 = 1.0 / Math.Sqrt(1.0 - 0.00669431777826672 * num3 * num3);
      }
      MyProject.Forms.Home.LATXP = 180.0 / Math.PI * num2;
      double num5 = 180.0 / Math.PI * ((Math.Atan2(Y, X) - Math.PI / 180.0 * GST) % (2.0 * Math.PI));
      if (num5 > 180.0)
        MyProject.Forms.Home.LONGIXP = num5 - 360.0;
      else if (num5 < -180.0)
        MyProject.Forms.Home.LONGIXP = 360.0 + num5;
      else
        MyProject.Forms.Home.LONGIXP = num5;
    }

    public static object LNGCalc(double X, double Y, double Z, double GST)
    {
      object obj = (object) (180.0 / Math.PI * ((Math.Atan2(Y, X) - Math.PI / 180.0 * GST) % (2.0 * Math.PI)));
      if (Operators.ConditionalCompareObjectGreater(obj, (object) 180, false))
        obj = Operators.SubtractObject(obj, (object) 360);
      else if (Operators.ConditionalCompareObjectLess(obj, (object) -180, false))
        obj = Operators.AddObject((object) 360, obj);
      return obj;
    }

    public static object LATCalc(double X, double Y, double Z, double GST)
    {
      double num1 = Math.Sqrt(X * X + Y * Y);
      double num2 = Math.Atan(Z / num1);
      double num3;
      double num4;
      for (double a = 7.0; Math.Abs(num2 - a) > 1E-07; num2 = Math.Atan((Z + 6378.136658 * num4 * 0.00669431777826672 * num3) / num1))
      {
        a = num2;
        num3 = Math.Sin(a);
        num4 = 1.0 / Math.Sqrt(1.0 - 0.00669431777826672 * num3 * num3);
      }
      return (object) (180.0 / Math.PI * num2);
    }

    public static double LAN_F(
      double ECC,
      double MA,
      double AnoPeriod,
      double RAAN,
      double ArgP,
      double gst)
    {
      double num1 = Math.PI / 180.0 * -ArgP;
      double num2 = (MA - 180.0 / Math.PI * (2.0 * Math.Atan(Math.Sqrt((1.0 - ECC) / (1.0 + ECC)) * Math.Tan(num1 / 2.0)) - ECC * Math.Sqrt(1.0 - Math.Pow(ECC, 2.0)) * Math.Sin(num1) / (1.0 + ECC * Math.Cos(num1)))) % 360.0;
      if (num2 < 0.0)
        num2 = 360.0 + num2;
      double num3 = num2 / 360.0 * (AnoPeriod * 60.0);
      return RAAN - gst - -num3 * 360.0 / 86400.0;
    }

    public static double LDN_F(
      double ECC,
      double MA,
      double AnoPeriod,
      double RAAN,
      double ArgP,
      double gst)
    {
      double num1 = Math.PI / 180.0 * (-ArgP + 180.0);
      double num2 = (180.0 / Math.PI * (2.0 * Math.Atan(Math.Sqrt((1.0 - ECC) / (1.0 + ECC)) * Math.Tan(num1 / 2.0)) - ECC * Math.Sqrt(1.0 - Math.Pow(ECC, 2.0)) * Math.Sin(num1) / (1.0 + ECC * Math.Cos(num1))) - MA) % 360.0;
      if (num2 < 0.0 & MyProject.Forms.Home.LAT < 0.0)
        num2 = num2;
      else if (num2 < 0.0)
        num2 = 360.0 + num2;
      double num3 = num2 / 360.0 * (AnoPeriod * 60.0);
      return RAAN + 180.0 - gst + -num3 * 360.0 / 86400.0;
    }

    public static double Saison(object YY)
    {
      int integer = Conversions.ToInteger(Operators.SubtractObject(Operators.SubtractObject(YY, (object) 2000), (object) 1));
      int num = 0;
      object Left1;
      do
      {
        object Right = (object) ((double) integer + 0.25 * (double) num);
        Left1 = Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.SubtractObject(Operators.SubtractObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object) 0.21451814, Operators.MultiplyObject((object) 0.99997862442, Right)), (object) (0.00642125 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 1.580244, Operators.MultiplyObject((object) 0.0001621008, Right)))))), (object) (0.0031065 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 4.143931, Operators.MultiplyObject((object) 6.2829005032, Right)))))), (object) (0.00190024 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.604775, Operators.MultiplyObject((object) 6.2829478479, Right)))))), (object) (0.00178801 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 3.987335, Operators.MultiplyObject((object) 6.2828291282, Right)))))), (object) (4.981E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 1.507976, Operators.MultiplyObject((object) 6.283109952, Right)))))), (object) (6.264E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.723365, Operators.MultiplyObject((object) 6.283062603, Right)))))), (object) (6.262E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.702396, Operators.MultiplyObject((object) 6.2827383999, Right)))))), (object) (3.833E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 7.166906, Operators.MultiplyObject((object) 6.2827857489, Right)))))), (object) (3.616E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.58175, Operators.MultiplyObject((object) 6.2829912245, Right)))))), (object) (3.597E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.591081, Operators.MultiplyObject((object) 6.2826670315, Right)))))), (object) (3.744E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 4.3918, Operators.MultiplyObject((object) 12.5657883, Right)))))), (object) (1.827E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 8.3129, Operators.MultiplyObject((object) 12.56582984, Right)))))), (object) (3.482E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 8.1219, Operators.MultiplyObject((object) 12.56572963, Right)))))), (object) (1.327E-05 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) -2.1076, Operators.MultiplyObject((object) 0.33756278, Right)))))), (object) (5.57E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.549, Operators.MultiplyObject((object) 5.753262, Right)))))), (object) (5.37E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 1.255, Operators.MultiplyObject((object) 0.003393, Right)))))), (object) (4.86E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 19.268, Operators.MultiplyObject((object) 77.7121103, Right)))))), (object) (4.26E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 7.675, Operators.MultiplyObject((object) 7.8602511, Right)))))), (object) (3.85E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 2.911, Operators.MultiplyObject((object) 0.0005412, Right)))))), (object) (3.72E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 2.266, Operators.MultiplyObject((object) 3.9301258, Right)))))), (object) (2.1E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 4.785, Operators.MultiplyObject((object) 11.5065238, Right)))))), (object) (1.9E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 6.158, Operators.MultiplyObject((object) 1.5774, Right)))))), (object) (2.04E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 0.582, Operators.MultiplyObject((object) 0.5296557, Right)))))), (object) (1.57E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 1.782, Operators.MultiplyObject((object) 5.8848012, Right)))))), (object) (1.37E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) -4.265, Operators.MultiplyObject((object) 0.3980615, Right)))))), (object) (1.24E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 3.871, Operators.MultiplyObject((object) 5.2236573, Right)))))), (object) (1.19E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 2.145, Operators.MultiplyObject((object) 5.5075293, Right)))))), (object) (1.44E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 0.476, Operators.MultiplyObject((object) 0.0261074, Right)))))), (object) (3.8E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 6.45, Operators.MultiplyObject((object) 18.848689, Right)))))), (object) (7.8E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 2.8, Operators.MultiplyObject((object) 0.775638, Right)))))), (object) (5.1E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 3.67, Operators.MultiplyObject((object) 11.790375, Right)))))), (object) (4.5E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) -5.79, Operators.MultiplyObject((object) 0.796122, Right)))))), (object) (2.4E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.61, Operators.MultiplyObject((object) 0.213214, Right)))))), (object) (4.3E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 7.39, Operators.MultiplyObject((object) 10.976868, Right)))))), (object) (3.8E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 3.1, Operators.MultiplyObject((object) 5.486739, Right)))))), (object) (3.3E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 0.64, Operators.MultiplyObject((object) 2.544339, Right)))))), (object) (3.3E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) -4.78, Operators.MultiplyObject((object) 5.573024, Right)))))), (object) (3.2E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.33, Operators.MultiplyObject((object) 6.069644, Right)))))), (object) (2.1E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 2.65, Operators.MultiplyObject((object) 0.020781, Right)))))), (object) (2.1E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.61, Operators.MultiplyObject((object) (1839.0 / 625.0), Right)))))), (object) (1.9E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) -0.93, Operators.MultiplyObject((object) 0.000799, Right)))))), (object) (1.6E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 3.22, Operators.MultiplyObject((object) 4.694014, Right)))))), (object) (1.6E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) -3.59, Operators.MultiplyObject((object) 0.006829, Right)))))), (object) (1.6E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 1.96, Operators.MultiplyObject((object) 2.146279, Right)))))), (object) (1.6E-07 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 5.92, Operators.MultiplyObject((object) 15.720504, Right)))))), (object) (1.15E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 23.671, Operators.MultiplyObject((object) 83.9950108, Right)))))), (object) (1.15E-06 * Math.Sin(Conversions.ToDouble(Operators.AddObject((object) 17.845, Operators.MultiplyObject((object) 71.4292098, Right))))));
        checked { ++num; }
      }
      while (num <= 4);
      double Left2 = Conversions.ToDouble(Operators.AddObject((object) 2451545, Operators.MultiplyObject(Left1, (object) 365.25)));
      object Left3 = Operators.DivideObject(YY, (object) 100);
      object Right1 = Operators.DivideObject(Operators.SubtractObject(Operators.MultiplyObject(Operators.MultiplyObject((object) (3223.0 / 100.0), Operators.SubtractObject(Left3, (object) 18.3)), Operators.SubtractObject(Left3, (object) 18.3)), (object) 15), (object) 86400);
      return Conversions.ToDouble(Operators.SubtractObject((object) Left2, Right1)) + 0.0003472222;
    }

    public static double GSTCalc(object Epoch)
    {
      Epoch = Operators.AddObject(Epoch, (object) 2430000);
      double num1;
      if (Operators.ConditionalCompareObjectGreaterEqual(Epoch, Operators.AddObject(Conversion.Int(RuntimeHelpers.GetObjectValue(Epoch)), (object) 0.5), false))
        num1 = Conversions.ToDouble(Operators.SubtractObject(Operators.AddObject(Conversion.Int(RuntimeHelpers.GetObjectValue(Epoch)), (object) 0.5), (object) 2451545.0));
      else if (Operators.ConditionalCompareObjectLess(Epoch, Operators.AddObject(Conversion.Int(RuntimeHelpers.GetObjectValue(Epoch)), (object) 0.5), false))
        num1 = Conversions.ToDouble(Operators.SubtractObject(Operators.SubtractObject(Conversion.Int(RuntimeHelpers.GetObjectValue(Epoch)), (object) 0.5), (object) 2451545.0));
      double x = num1 / 36525.0;
      double num2 = (24110.54841 + 8640184.7568378 * x + 0.093104 * Math.Pow(x, 2.0) - 6.2E-06 * Math.Pow(x, 3.0)) % 86400.0;
      double num3;
      if (Operators.ConditionalCompareObjectLess(Epoch, Operators.AddObject(Conversion.Int(RuntimeHelpers.GetObjectValue(Epoch)), (object) 0.5), false))
        num3 = Conversions.ToDouble(Operators.SubtractObject(Epoch, Operators.SubtractObject(Conversion.Int(RuntimeHelpers.GetObjectValue(Epoch)), (object) 0.5)));
      else if (Operators.ConditionalCompareObjectGreater(Epoch, Operators.AddObject(Conversion.Int(RuntimeHelpers.GetObjectValue(Epoch)), (object) 0.5), false))
        num3 = Conversions.ToDouble(Operators.SubtractObject(Epoch, Operators.AddObject(Conversion.Int(RuntimeHelpers.GetObjectValue(Epoch)), (object) 0.5)));
      return (num2 + 86400.0 * num3 * 1.0027379093508) % 86400.0 / 240.0 % 360.0;
    }

    public static object LTAN_F()
    {
      double num1 = 72.0 / 73.0;
      double num2 = Functions.Saison(RuntimeHelpers.GetObjectValue((object) Functions.GregtoYear(Functions.MJDtoGreg(Conversions.ToString(MyProject.Forms.Home.EPOCH))))) - 2430000.0;
      object Right = MyProject.Forms.Home.EPOCH <= num2 ? (object) (360.0 + ((MyProject.Forms.Home.EPOCH - num2) * num1 - 2.0 * num1) % 360.0) : (object) (((MyProject.Forms.Home.EPOCH - num2) * num1 - 2.0 * num1) % 360.0);
      object Left = !Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) MyProject.Forms.Home.RAAN, Right), (object) 0, false) ? Operators.SubtractObject((object) MyProject.Forms.Home.RAAN, Right) : Operators.AddObject((object) 360, Operators.SubtractObject((object) MyProject.Forms.Home.RAAN, Right));
      if (Operators.ConditionalCompareObjectEqual(Left, (object) null, false))
        Left = (object) 0;
      return RuntimeHelpers.GetObjectValue(Functions.HtoHMS(Conversions.ToString(Operators.ModObject(Operators.AddObject((object) 12, Operators.DivideObject(Left, (object) 15)), (object) 24))));
    }

    public static object LTDN_F()
    {
      double num1 = 72.0 / 73.0;
      double num2 = Functions.Saison(RuntimeHelpers.GetObjectValue((object) Functions.GregtoYear(Functions.MJDtoGreg(Conversions.ToString(MyProject.Forms.Home.EPOCH))))) - 2430000.0;
      object Right = MyProject.Forms.Home.EPOCH <= num2 ? (object) (360.0 + ((MyProject.Forms.Home.EPOCH - num2) * num1 - 2.0 * num1) % 360.0) : (object) (((MyProject.Forms.Home.EPOCH - num2) * num1 - 2.0 * num1) % 360.0);
      object Left = !Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object) MyProject.Forms.Home.RAAN, Right), (object) 0, false) ? Operators.SubtractObject((object) MyProject.Forms.Home.RAAN, Right) : Operators.AddObject((object) 360, Operators.SubtractObject((object) MyProject.Forms.Home.RAAN, Right));
      if (Operators.ConditionalCompareObjectEqual(Left, (object) null, false))
        Left = (object) 0;
      return RuntimeHelpers.GetObjectValue(Functions.HtoHMS(Conversions.ToString(Operators.ModObject(Operators.DivideObject(Left, (object) 15), (object) 24))));
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void CreateTLEFolder()
    {
      if (!MyProject.Computer.FileSystem.DirectoryExists("C:\\TLEAnalyser"))
        MyProject.Computer.FileSystem.CreateDirectory("C:\\TLEAnalyser");
      if (!MyProject.Computer.FileSystem.DirectoryExists("C:\\TLEAnalyser\\TLE"))
        MyProject.Computer.FileSystem.CreateDirectory("C:\\TLEAnalyser\\TLE");
      if (MyProject.Computer.FileSystem.FileExists("C:\\TLEAnalyser\\TLE\\TLEList.txt"))
        MyProject.Computer.FileSystem.DeleteFile("C:\\TLEAnalyser\\TLE\\TLEList.txt");
      System.IO.File.AppendAllText("C:\\TLEAnalyser\\TLE\\TLEList.txt", TLE_Analyser.My.Resources.Resources.TLEList);
      Microsoft.VisualBasic.FileSystem.FileOpen(1, "C:\\TLEAnalyser\\TLE\\TLEList.txt", OpenMode.Input);
      while (!Microsoft.VisualBasic.FileSystem.EOF(1))
      {
        object obj1 = (object) Microsoft.VisualBasic.FileSystem.LineInput(1);
        object obj2 = (object) Conversions.ToString(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj1, (Type) null, "Replace", new object[2]
        {
          (object) "-",
          (object) "_"
        }, (string[]) null, (Type[]) null, (bool[]) null)))));
        if (!MyProject.Computer.FileSystem.FileExists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) MyProject.Forms.Home.TLEPath, obj1), (object) ".txt"))))
          System.IO.File.WriteAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) MyProject.Forms.Home.TLEPath, obj1), (object) ".txt")), Conversions.ToString(obj2));
      }
      Microsoft.VisualBasic.FileSystem.FileClose(1);
      if (MyProject.Computer.FileSystem.FileExists("C:\\TLEAnalyser\\TLE\\SuppList.txt"))
        MyProject.Computer.FileSystem.DeleteFile("C:\\TLEAnalyser\\TLE\\SuppList.txt");
      System.IO.File.AppendAllText("C:\\TLEAnalyser\\TLE\\SuppList.txt", TLE_Analyser.My.Resources.Resources.SuppList);
      Microsoft.VisualBasic.FileSystem.FileOpen(1, "C:\\TLEAnalyser\\TLE\\SuppList.txt", OpenMode.Input);
      while (!Microsoft.VisualBasic.FileSystem.EOF(1))
      {
        object obj3 = (object) Microsoft.VisualBasic.FileSystem.LineInput(1);
        object obj4 = (object) Conversions.ToString(TLE_Analyser.My.Resources.Resources.ResourceManager.GetObject(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj3, (Type) null, "Replace", new object[2]
        {
          (object) "-",
          (object) "_"
        }, (string[]) null, (Type[]) null, (bool[]) null)))));
        if (!MyProject.Computer.FileSystem.FileExists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) MyProject.Forms.Home.TLEPath, obj3), (object) ".txt"))))
          System.IO.File.WriteAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) MyProject.Forms.Home.TLEPath, obj3), (object) ".txt")), Conversions.ToString(obj4));
      }
      Microsoft.VisualBasic.FileSystem.FileClose(1);
    }

    public static void CreateFolders()
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
        if (MyProject.Computer.FileSystem.DirectoryExists(MyProject.Forms.Home.GMATPath))
          goto label_4;
label_3:
        num3 = 3;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.GMATPath);
label_4:
        num3 = 5;
        if (MyProject.Computer.FileSystem.DirectoryExists(MyProject.Forms.Home.FavPath))
          goto label_6;
label_5:
        num3 = 6;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.FavPath);
label_6:
        num3 = 8;
        if (MyProject.Computer.FileSystem.DirectoryExists(MyProject.Forms.Home.CATPath))
          goto label_8;
label_7:
        num3 = 9;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.CATPath);
label_8:
        num3 = 11;
        if (!MyProject.Computer.FileSystem.FileExists(MyProject.Forms.Home.SatCatSources))
          goto label_10;
label_9:
        num3 = 12;
        System.IO.File.Delete(MyProject.Forms.Home.SatCatSources);
label_10:
        num3 = 14;
        System.IO.File.AppendAllText(MyProject.Forms.Home.SatCatSources, TLE_Analyser.My.Resources.Resources.satcat_sources);
label_11:
        num3 = 15;
        if (!MyProject.Computer.FileSystem.FileExists(MyProject.Forms.Home.SatCatSites))
          goto label_13;
label_12:
        num3 = 16;
        System.IO.File.Delete(MyProject.Forms.Home.SatCatSites);
label_13:
        num3 = 18;
        System.IO.File.AppendAllText(MyProject.Forms.Home.SatCatSites, TLE_Analyser.My.Resources.Resources.satcat_sites);
label_14:
        num3 = 19;
        if (MyProject.Computer.FileSystem.DirectoryExists(MyProject.Forms.Home.Orbit3DPath))
          goto label_37;
label_15:
        num3 = 20;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.Orbit3DPath);
label_16:
        num3 = 21;
        System.IO.File.AppendAllText(MyProject.Forms.Home.Orbit3DPath + "Orbit3D.html", TLE_Analyser.My.Resources.Resources.Orbit3D);
label_17:
        num3 = 22;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.Orbit3DPath + "/js");
label_18:
        num3 = 23;
        System.IO.File.AppendAllText(MyProject.Forms.Home.Orbit3DPath + "/js/Detector.js", TLE_Analyser.My.Resources.Resources.Detector);
label_19:
        num3 = 24;
        System.IO.File.AppendAllText(MyProject.Forms.Home.Orbit3DPath + "/js/three.min.js", TLE_Analyser.My.Resources.Resources.three_min);
label_20:
        num3 = 25;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.Orbit3DPath + "/js/controls");
label_21:
        num3 = 26;
        System.IO.File.AppendAllText(MyProject.Forms.Home.Orbit3DPath + "/js/controls/OrbitControls.js", TLE_Analyser.My.Resources.Resources.OrbitControls);
label_22:
        num3 = 27;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.Orbit3DPath + "/js/renderers");
label_23:
        num3 = 28;
        System.IO.File.AppendAllText(MyProject.Forms.Home.Orbit3DPath + "/js/renderers/Projector.js", TLE_Analyser.My.Resources.Resources.Projector);
label_24:
        num3 = 29;
        System.IO.File.AppendAllText(MyProject.Forms.Home.Orbit3DPath + "/js/renderers/CanvasRenderer.js", TLE_Analyser.My.Resources.Resources.CanvasRenderer);
label_25:
        num3 = 30;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.Orbit3DPath + "/textures");
label_26:
        num3 = 31;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.Orbit3DPath + "/textures/planets");
label_27:
        num3 = 32;
        Image earthAtmos2048 = (Image) TLE_Analyser.My.Resources.Resources.earth_atmos_2048;
label_28:
        num3 = 33;
        Image earthClouds1024 = (Image) TLE_Analyser.My.Resources.Resources.earth_clouds_1024;
label_29:
        num3 = 34;
        Image earthNormal2048 = (Image) TLE_Analyser.My.Resources.Resources.earth_normal_2048;
label_30:
        num3 = 35;
        Image earthSpecular2048 = (Image) TLE_Analyser.My.Resources.Resources.earth_specular_2048;
label_31:
        num3 = 36;
        Image earthMap2 = (Image) TLE_Analyser.My.Resources.Resources.EarthMap2;
label_32:
        num3 = 37;
        earthAtmos2048.Save(MyProject.Forms.Home.Orbit3DPath + "/textures/planets/earth_atmos_2048.jpg");
label_33:
        num3 = 38;
        earthClouds1024.Save(MyProject.Forms.Home.Orbit3DPath + "/textures/planets/earth_clouds_1024.png");
label_34:
        num3 = 39;
        earthNormal2048.Save(MyProject.Forms.Home.Orbit3DPath + "/textures/planets/earth_normal_2048.jpg");
label_35:
        num3 = 40;
        earthSpecular2048.Save(MyProject.Forms.Home.Orbit3DPath + "/textures/planets/earth_specular_2048.jpg");
label_36:
        num3 = 41;
        earthMap2.Save(MyProject.Forms.Home.Orbit3DPath + "/textures/planets/EarthMap2.png");
label_37:
label_38:
        num3 = 43;
        if (MyProject.Computer.FileSystem.DirectoryExists(MyProject.Forms.Home.EXPORTPath))
          goto label_40;
label_39:
        num3 = 44;
        MyProject.Computer.FileSystem.CreateDirectory(MyProject.Forms.Home.EXPORTPath);
label_40:
        num3 = 46;
        if (MyProject.Computer.FileSystem.FileExists(MyProject.Forms.Home.AppPath + "tlea.ini"))
          goto label_42;
label_41:
        num3 = 47;
        System.IO.File.AppendAllText(MyProject.Forms.Home.AppPath + "tlea.ini", TLE_Analyser.My.Resources.Resources.tlea);
label_42:
        num3 = 49;
        if (MyProject.Computer.FileSystem.FileExists(MyProject.Forms.Home.StationsFile))
          goto label_44;
label_43:
        num3 = 50;
        System.IO.File.AppendAllText(MyProject.Forms.Home.StationsFile, TLE_Analyser.My.Resources.Resources.GroundStations);
label_44:
        num3 = 52;
        if (!MyProject.Computer.FileSystem.FileExists(MyProject.Forms.Home.UMFile))
          goto label_46;
label_45:
        num3 = 53;
        MyProject.Computer.FileSystem.DeleteFile(MyProject.Forms.Home.UMFile);
label_46:
        num3 = 55;
        System.IO.File.WriteAllBytes(MyProject.Forms.Home.UMFile, TLE_Analyser.My.Resources.Resources.TAUM);
label_47:
        num3 = 56;
        if (!MyProject.Computer.FileSystem.DirectoryExists("C:\\TLEAnalyser\\GOOGLEMAP"))
          goto label_49;
label_48:
        num3 = 57;
        MyProject.Computer.FileSystem.DeleteDirectory("C:\\TLEAnalyser\\GOOGLEMAP", DeleteDirectoryOption.DeleteAllContents);
label_49:
        num3 = 59;
        if (!MyProject.Computer.FileSystem.FileExists(MyProject.Forms.Home.FavPath + "\\favourites.txt"))
          goto label_51;
label_50:
        num3 = 60;
        MyProject.Computer.FileSystem.RenameFile(MyProject.Forms.Home.FavPath + "\\favourites.txt", "Favorites.txt");
label_51:
        num3 = 62;
        if (!MyProject.Computer.FileSystem.DirectoryExists(MyProject.Forms.Home.PlotPath))
          goto label_59;
label_52:
        num3 = 63;
        MyProject.Computer.FileSystem.DeleteDirectory(MyProject.Forms.Home.PlotPath, DeleteDirectoryOption.DeleteAllContents);
        goto label_59;
label_54:
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
              case 5:
                goto label_4;
              case 6:
                goto label_5;
              case 7:
              case 8:
                goto label_6;
              case 9:
                goto label_7;
              case 10:
              case 11:
                goto label_8;
              case 12:
                goto label_9;
              case 13:
              case 14:
                goto label_10;
              case 15:
                goto label_11;
              case 16:
                goto label_12;
              case 17:
              case 18:
                goto label_13;
              case 19:
                goto label_14;
              case 20:
                goto label_15;
              case 21:
                goto label_16;
              case 22:
                goto label_17;
              case 23:
                goto label_18;
              case 24:
                goto label_19;
              case 25:
                goto label_20;
              case 26:
                goto label_21;
              case 27:
                goto label_22;
              case 28:
                goto label_23;
              case 29:
                goto label_24;
              case 30:
                goto label_25;
              case 31:
                goto label_26;
              case 32:
                goto label_27;
              case 33:
                goto label_28;
              case 34:
                goto label_29;
              case 35:
                goto label_30;
              case 36:
                goto label_31;
              case 37:
                goto label_32;
              case 38:
                goto label_33;
              case 39:
                goto label_34;
              case 40:
                goto label_35;
              case 41:
                goto label_36;
              case 42:
                goto label_37;
              case 43:
                goto label_38;
              case 44:
                goto label_39;
              case 45:
              case 46:
                goto label_40;
              case 47:
                goto label_41;
              case 48:
              case 49:
                goto label_42;
              case 50:
                goto label_43;
              case 51:
              case 52:
                goto label_44;
              case 53:
                goto label_45;
              case 54:
              case 55:
                goto label_46;
              case 56:
                goto label_47;
              case 57:
                goto label_48;
              case 58:
              case 59:
                goto label_49;
              case 60:
                goto label_50;
              case 61:
              case 62:
                goto label_51;
              case 63:
                goto label_52;
              case 64:
                goto label_59;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_54;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_59:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void Init_RawDataGrid()
    {
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Clear();
      string[] strArray1 = new string[4]
      {
        "1",
        "01",
        "",
        "Line Number"
      };
      string[] strArray2 = new string[4]
      {
        "1",
        "03-07",
        "",
        "NORAD #"
      };
      string[] strArray3 = new string[4]
      {
        "1",
        "08",
        "",
        "Classification (U=Unclassified)"
      };
      string[] strArray4 = new string[4]
      {
        "1",
        "10-11",
        "",
        "COSPAR # (Launch year)"
      };
      string[] strArray5 = new string[4]
      {
        "1",
        "12-14",
        "",
        "COSPAR # (Launch #)"
      };
      string[] strArray6 = new string[4]
      {
        "1",
        "15-17",
        "",
        "COSPAR # (Piece of the launch)"
      };
      string[] strArray7 = new string[4]
      {
        "1",
        "19-20",
        "",
        "Last two digit of year"
      };
      string[] strArray8 = new string[4]
      {
        "1",
        "21-32",
        "",
        "Day of the year"
      };
      string[] strArray9 = new string[4]
      {
        "1",
        "34-43",
        "",
        "n'/2 (rev/day^2)"
      };
      string[] strArray10 = new string[4]
      {
        "1",
        "45-52",
        "",
        "n''/6 (rev/day^3)"
      };
      string[] strArray11 = new string[4]
      {
        "1",
        "54-61",
        "",
        "Drag Term (B*)"
      };
      string[] strArray12 = new string[4]
      {
        "1",
        "63",
        "",
        "Ephemeris Type"
      };
      string[] strArray13 = new string[4]
      {
        "1",
        "65-68",
        "",
        "Element Number"
      };
      string[] strArray14 = new string[4]
      {
        "1",
        "69",
        "",
        "Checksum (Modulo 10)"
      };
      string[] strArray15 = new string[4]
      {
        "2",
        "01",
        "",
        "Line Number"
      };
      string[] strArray16 = new string[4]
      {
        "2",
        "03-07",
        "",
        "NORAD #"
      };
      string[] strArray17 = new string[4]
      {
        "2",
        "09-16",
        "",
        "Inclinaison"
      };
      string[] strArray18 = new string[4]
      {
        "2",
        "18-25",
        "",
        "Right Ascension of Ascending Node"
      };
      string[] strArray19 = new string[4]
      {
        "2",
        "27-33",
        "",
        "Eccentricity"
      };
      string[] strArray20 = new string[4]
      {
        "2",
        "35-42",
        "",
        "Argument of Perigee"
      };
      string[] strArray21 = new string[4]
      {
        "2",
        "44-51",
        "",
        "Mean Anomaly"
      };
      string[] strArray22 = new string[4]
      {
        "2",
        "53-63",
        "",
        "Mean Motion (n)"
      };
      string[] strArray23 = new string[4]
      {
        "2",
        "64-68",
        "",
        "Revolution Number at Epoch"
      };
      string[] strArray24 = new string[4]
      {
        "2",
        "69",
        "",
        "Checksum (Modulo 10)"
      };
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray1);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray2);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray3);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray4);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray5);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray6);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray7);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray8);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray9);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray10);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray11);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray12);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray13);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray14);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray15);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray16);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray17);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray18);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray19);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray20);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray21);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray22);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray23);
      MyProject.Forms.Home.Raw_Data_GridView.Rows.Add((object[]) strArray24);
      MyProject.Forms.Home.Raw_Data_GridView.AlternatingRowsDefaultCellStyle.BackColor = Color.GhostWhite;
      MyProject.Forms.Home.Raw_Data_GridView.RowHeadersVisible = false;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static object SatCount()
    {
      object Left1 = (object) 0;
      int num = checked (MyProject.Forms.Home.TLE_ListBox.Items.Count - 1);
      int index = 0;
      while (index <= num)
      {
        string Left2 = Conversions.ToString(MyProject.Forms.Home.TLE_ListBox.Items[index]);
        if (!(Operators.CompareString(Left2, "favorites.txt", false) == 0 | Operators.CompareString(Left2, "search.txt", false) == 0 | Left2.StartsWith("fleet_")))
        {
          string FileName = Conversions.ToString(Operators.ConcatenateObject((object) MyProject.Forms.Home.TLEPath, MyProject.Forms.Home.TLE_ListBox.Items[index]));
          Microsoft.VisualBasic.FileSystem.FileOpen(checked (index + 1), FileName, OpenMode.Input);
          object Left3 = (object) 0;
          while (!Microsoft.VisualBasic.FileSystem.EOF(checked (index + 1)))
          {
            object obj = (object) Microsoft.VisualBasic.FileSystem.LineInput(checked (index + 1));
            Left3 = Operators.AddObject(Left3, (object) 1);
          }
          Left1 = Operators.AddObject(Left1, Operators.DivideObject(Left3, (object) 3));
          Microsoft.VisualBasic.FileSystem.FileClose(checked (index + 1));
        }
        checked { ++index; }
      }
      return RuntimeHelpers.GetObjectValue(Left1);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static object SatCount(string collection)
    {
      int num1;
      object objectValue;
      int num2;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        int Right = Operators.CompareString(MyProject.Forms.Home.CollectionType, "fleet", false) != 0 ? 3 : 2;
        object Left1 = (object) 0;
        Microsoft.VisualBasic.FileSystem.FileOpen(1, collection, OpenMode.Input);
        object Left2 = (object) 0;
        while (!Microsoft.VisualBasic.FileSystem.EOF(1))
        {
          object obj = (object) Microsoft.VisualBasic.FileSystem.LineInput(1);
          Left2 = Operators.AddObject(Left2, (object) 1);
        }
        object obj1 = Operators.AddObject(Left1, Operators.DivideObject(Left2, (object) Right));
        Microsoft.VisualBasic.FileSystem.FileClose(1);
        objectValue = RuntimeHelpers.GetObjectValue(obj1);
        goto label_10;
label_5:
        num2 = -1;
        switch (num1)
        {
          case 2:
            goto label_10;
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
        goto label_5;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_10:
      object obj2 = objectValue;
      if (num2 == 0)
        return obj2;
      ProjectData.ClearProjectError();
      return obj2;
    }

    public static void Pause(int t) => Thread.Sleep(checked (t * 1000));

    public static bool CheckTLE(string line1, string line2, bool displayMess)
    {
label_1:
      bool flag;
      int num1;
      int num2;
      try
      {
        int num3 = 1;
        string message = "Check TLE :\r\n\r\n";
label_2:
        num3 = 2;
        flag = true;
label_3:
        num3 = 3;
        if (!(Operators.CompareString(line1, "", false) == 0 | Operators.CompareString(line2, "", false) == 0 | line1.Length < 69 | line2.Length < 69))
          goto label_6;
label_4:
        num3 = 4;
        flag = false;
label_5:
        num3 = 5;
        message += "Line 1 and/or Line 2 seems to be empty or incorect.";
label_6:
label_7:
        ProjectData.ClearProjectError();
        num1 = -2;
label_8:
        num3 = 8;
        if (Operators.CompareString(line1, "", false) != 0)
          goto label_11;
label_9:
        num3 = 9;
        flag = false;
label_10:
        num3 = 10;
        message += "\r\nLine 1 seems to be empty";
        goto label_16;
label_11:
        num3 = 12;
label_12:
        num3 = 13;
        if (line1.StartsWith("1 "))
          goto label_15;
label_13:
        num3 = 14;
        flag = false;
label_14:
        num3 = 15;
        message += "\r\nLine 1 must begin with '1 '";
label_15:
label_16:
label_17:
        num3 = 18;
        if (Operators.CompareString(line2, "", false) != 0)
          goto label_20;
label_18:
        num3 = 19;
        flag = false;
label_19:
        num3 = 20;
        message += "\r\nLine 2 seems to be empty";
        goto label_25;
label_20:
        num3 = 22;
label_21:
        num3 = 23;
        if (line2.StartsWith("2 "))
          goto label_24;
label_22:
        num3 = 24;
        flag = false;
label_23:
        num3 = 25;
        message += "\r\nLine 2 must begin with '2 ' ";
label_24:
label_25:
label_26:
        num3 = 28;
        int length1 = line1.Length;
label_27:
        num3 = 29;
        int length2 = line2.Length;
label_28:
        num3 = 30;
        if (!(length1 < 69 | length2 < 69 | length1 > 69 | length2 > 69))
          goto label_31;
label_29:
        num3 = 31;
        flag = false;
label_30:
        num3 = 32;
        message = message + "\r\n\r\nEach line must contain 69 characters.\nActually: \n" + Conversions.ToString(length1) + " characters on line 1\n" + Conversions.ToString(length2) + " characters on line 2";
label_31:
label_32:
        num3 = 34;
        if (MyProject.Forms.Home.OptionsSaved)
          goto label_35;
label_33:
        num3 = 35;
        if (!(!flag & displayMess))
          goto label_35;
label_34:
        num3 = 36;
        int num4 = (int) TopMostMessageBox.Show(message, "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
label_35:
        goto label_42;
label_37:
        num2 = num3;
        switch (num1 > -2 ? num1 : 1)
        {
          case 1:
            int num5 = num2 + 1;
            num2 = 0;
            switch (num5)
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
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
              case 17:
                goto label_16;
              case 12:
                goto label_11;
              case 13:
                goto label_12;
              case 14:
                goto label_13;
              case 15:
                goto label_14;
              case 16:
                goto label_15;
              case 18:
                goto label_17;
              case 19:
                goto label_18;
              case 20:
                goto label_19;
              case 21:
              case 27:
                goto label_25;
              case 22:
                goto label_20;
              case 23:
                goto label_21;
              case 24:
                goto label_22;
              case 25:
                goto label_23;
              case 26:
                goto label_24;
              case 28:
                goto label_26;
              case 29:
                goto label_27;
              case 30:
                goto label_28;
              case 31:
                goto label_29;
              case 32:
                goto label_30;
              case 33:
                goto label_31;
              case 34:
                goto label_32;
              case 35:
                goto label_33;
              case 36:
                goto label_34;
              case 37:
              case 38:
                goto label_35;
              case 39:
                goto label_42;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_37;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_42:
      int num6 = flag ? 1 : 0;
      if (num2 == 0)
        return num6 != 0;
      ProjectData.ClearProjectError();
      return num6 != 0;
    }

    public static void DownloadFile(
      Uri address,
      string destinationFileName,
      ICredentials networkCredentials,
      bool showUI,
      int connectionTimeout,
      bool overwrite)
    {
    }

    public static void SetCulture(string culture)
    {
      if (Operators.CompareString(culture, "", false) != 0)
      {
        try
        {
          Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
        }
        catch (ArgumentException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) TopMostMessageBox.Show(ex.Message + "\r\n\r\nDocument: 'Function.vb'\r\nBloc: 'SetCulture'", "TLE ANALYSER - Error");
          ProjectData.ClearProjectError();
        }
      }
      CultureInfo cultureInfo = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);
      cultureInfo.NumberFormat.NumberDecimalSeparator = ".";
      cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
      Thread.CurrentThread.CurrentCulture = cultureInfo;
      Thread.CurrentThread.CurrentUICulture = cultureInfo;
    }

    public static void TimeZoneDef()
    {
      TimeZone currentTimeZone = TimeZone.CurrentTimeZone;
      DateTime now = DateTime.Now;
      int year = now.Year;
      MyProject.Forms.Options.TimeZoneBox.Text = currentTimeZone.StandardName;
      MyProject.Forms.Options.CurrentDateBox.Text = Conversions.ToString(now);
      DateTime universalTime = currentTimeZone.ToUniversalTime(now);
      MyProject.Forms.Home.OffsetUTC = currentTimeZone.GetUtcOffset(now).Hours.ToString("00");
      MyProject.Forms.Options.CurrentDateUTCBox.Text = Conversions.ToString(universalTime);
      MyProject.Forms.Options.OffsetUTCBox.Text = MyProject.Forms.Home.OffsetUTC + ":00";
    }

    public static void ExportToGMAT()
    {
      if (MyProject.Forms.Home.EPOCH_Format.SelectedIndex == 0)
        MyProject.Forms.Home.EPOCH = Conversions.ToDouble(MyProject.Forms.Home.EPOCH_Current.Text);
      if (MyProject.Forms.Home.EPOCH_Format.SelectedIndex == 1)
        MyProject.Forms.Home.EPOCH = Functions.GregtoMJD(MyProject.Forms.Home.EPOCH_Current.Text);
      object text = (object) MyProject.Forms.Home.SCName.Text;
      object Right1;
      if (Operators.CompareString(MyProject.Forms.Home.DracoPeriod_Label.Text, "sec", false) == 0)
        Right1 = (object) (MyProject.Forms.Home.DPER * Conversions.ToDouble(MyProject.Forms.Home.Propagate));
      if (Operators.CompareString(MyProject.Forms.Home.DracoPeriod_Label.Text, "min", false) == 0)
        Right1 = (object) (MyProject.Forms.Home.DPER * 60.0 * Conversions.ToDouble(MyProject.Forms.Home.Propagate));
      object Right2 = !Conversions.ToBoolean(MyProject.Forms.Home.ShowTrack) ? (object) "" : (object) "Create GroundTrackPlot DefaultGroundTrackPlot;\r\nGMAT DefaultGroundTrackPlot.SolverIterations = Current;\r\nGMAT DefaultGroundTrackPlot.UpperLeft = [ 0.004716981132075472 0.4570446735395189 ];\r\nGMAT DefaultGroundTrackPlot.Size = [ 0.5009433962264152 0.4501718213058419 ];\r\nGMAT DefaultGroundTrackPlot.RelativeZOrder = 17;\r\nGMAT DefaultGroundTrackPlot.Add = {DefaultSC, Earth};\r\nGMAT DefaultGroundTrackPlot.DataCollectFrequency = 1;\r\nGMAT DefaultGroundTrackPlot.UpdatePlotFrequency = 50;\r\nGMAT DefaultGroundTrackPlot.NumPointsToRedraw = 0;\r\nGMAT DefaultGroundTrackPlot.ShowPlot = true;\r\nGMAT DefaultGroundTrackPlot.CentralBody = Earth;\r\nGMAT DefaultGroundTrackPlot.TextureMap = '../data/graphics/texture/ModifiedBlueMarble.jpg';";
      object Right3;
      if (Conversions.ToBoolean(MyProject.Forms.Home.OptionGmatModel1))
        Right3 = (object) "%----------------------------------------\r\n%---------- ForceModels\r\n%----------------------------------------\r\nCreate ForceModel DefaultProp_ForceModel;\r\nGMAT DefaultProp_ForceModel.CentralBody = Earth;\r\nGMAT DefaultProp_ForceModel.PrimaryBodies = {Earth};\r\nGMAT DefaultProp_ForceModel.Drag = None;\r\nGMAT DefaultProp_ForceModel.SRP = Off;\r\nGMAT DefaultProp_ForceModel.RelativisticCorrection = Off;\r\nGMAT DefaultProp_ForceModel.ErrorControl = RSSStep;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.Degree = 2;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.Order = 0;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.PotentialFile = 'JGM3.cof';\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.EarthTideModel = 'None';";
      else if (Conversions.ToBoolean(MyProject.Forms.Home.OptionGmatModel2))
        Right3 = (object) "%----------------------------------------\r\n%---------- ForceModels\r\n%----------------------------------------\r\nCreate ForceModel DefaultProp_ForceModel;\r\nGMAT DefaultProp_ForceModel.CentralBody = Earth;\r\nGMAT DefaultProp_ForceModel.PrimaryBodies = {Earth};\r\nGMAT DefaultProp_ForceModel.PointMasses = {Luna, Sun};\r\nGMAT DefaultProp_ForceModel.Drag = None;\r\nGMAT DefaultProp_ForceModel.SRP = On;\r\nGMAT DefaultProp_ForceModel.RelativisticCorrection = Off;\r\nGMAT DefaultProp_ForceModel.ErrorControl = RSSStep;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.Degree = 4;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.Order = 4;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.PotentialFile = 'JGM3.cof';\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.EarthTideModel = 'None';\r\nGMAT DefaultProp_ForceModel.Drag.AtmosphereModel = MSISE90;\r\nGMAT DefaultProp_ForceModel.Drag.F107 = 150;\r\nGMAT DefaultProp_ForceModel.Drag.F107A = 150;\r\nGMAT DefaultProp_ForceModel.Drag.MagneticIndex = 3;\r\nGMAT DefaultProp_ForceModel.SRP.Flux = 1367;\r\nGMAT DefaultProp_ForceModel.SRP.Nominal_Sun = 149597870.691;";
      string contents = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) ("%General Mission Analysis Tool(GMAT) Script\r\n%Created from TLE Analyser:" + Conversions.ToString(DateTime.Now) + "\r\n" + "%----------------------------------------" + "\r\n" + "%----------"), text), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "Create Spacecraft DefaultSC;"), (object) "\r\n"), (object) "GMAT DefaultSC.DateFormat = UTCModJulian;"), (object) "\r\n"), (object) "GMAT DefaultSC.Epoch = '"), (object) MyProject.Forms.Home.EPOCH), (object) "';"), (object) "\r\n"), (object) "GMAT DefaultSC.CoordinateSystem = EarthMJ2000Eq;"), (object) "\r\n"), (object) "GMAT DefaultSC.DisplayStateType = Keplerian;"), (object) "\r\n"), (object) "GMAT DefaultSC.SMA = "), (object) MyProject.Forms.Home.SMA), (object) ";"), (object) "\r\n"), (object) "GMAT DefaultSC.ECC = "), (object) MyProject.Forms.Home.ECC), (object) ";"), (object) "\r\n"), (object) "GMAT DefaultSC.INC = "), (object) MyProject.Forms.Home.INC), (object) ";"), (object) "\r\n"), (object) "GMAT DefaultSC.RAAN = "), (object) MyProject.Forms.Home.RAAN), (object) ";"), (object) "\r\n"), (object) "GMAT DefaultSC.AOP = "), (object) MyProject.Forms.Home.AOP), (object) ";"), (object) "\r\n"), (object) "GMAT DefaultSC.TA = "), (object) (180.0 / Math.PI * MyProject.Forms.Home.TA)), (object) ";"), (object) "\r\n"), (object) "GMAT DefaultSC.DryMass = 850;"), (object) "\r\n"), (object) "GMAT DefaultSC.Cd = 2.2;"), (object) "\r\n"), (object) "GMAT DefaultSC.Cr = 1.8;"), (object) "\r\n"), (object) "GMAT DefaultSC.DragArea = 15;"), (object) "\r\n"), (object) "GMAT DefaultSC.SRPArea = 1;"), (object) "\r\n"), (object) "GMAT DefaultSC.NAIFId = -123456789;"), (object) "\r\n"), (object) "GMAT DefaultSC.NAIFIdReferenceFrame = -123456789;"), (object) "\r\n"), (object) "GMAT DefaultSC.Id = 'SatId';"), (object) "\r\n"), (object) "GMAT DefaultSC.Attitude = CoordinateSystemFixed;"), (object) "\r\n"), (object) "GMAT DefaultSC.ModelFile = '../data/vehicle/models/aura.3ds';"), (object) "\r\n"), (object) "GMAT DefaultSC.ModelOffsetX = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.ModelOffsetY = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.ModelOffsetZ = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.ModelRotationX = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.ModelRotationY = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.ModelRotationZ = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.ModelScale = 3;"), (object) "\r\n"), (object) "GMAT DefaultSC.AttitudeDisplayStateType = 'Quaternion';"), (object) "\r\n"), (object) "GMAT DefaultSC.AttitudeRateDisplayStateType = 'AngularVelocity';"), (object) "\r\n"), (object) "GMAT DefaultSC.AttitudeCoordinateSystem = 'EarthMJ2000Eq';"), (object) "\r\n"), (object) "GMAT DefaultSC.Q1 = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.Q2 = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.Q3 = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.Q4 = 1;"), (object) "\r\n"), (object) "GMAT DefaultSC.EulerAngleSequence = '321';"), (object) "\r\n"), (object) "GMAT DefaultSC.AngularVelocityX = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.AngularVelocityY = 0;"), (object) "\r\n"), (object) "GMAT DefaultSC.AngularVelocityZ = 0;"), (object) "\r\n"), Right3), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "%---------- Propagators"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "Create Propagator DefaultProp;"), (object) "\r\n"), (object) "GMAT DefaultProp.FM = DefaultProp_ForceModel;"), (object) "\r\n"), (object) "GMAT DefaultProp.Type = RungeKutta89;"), (object) "\r\n"), (object) "GMAT DefaultProp.InitialStepSize = 60;"), (object) "\r\n"), (object) "GMAT DefaultProp.Accuracy = 9.999999999999999e-012;"), (object) "\r\n"), (object) "GMAT DefaultProp.MinStep = 0.001;"), (object) "\r\n"), (object) "GMAT DefaultProp.MaxStep = 2700;"), (object) "\r\n"), (object) "GMAT DefaultProp.MaxStepAttempts = 50;"), (object) "\r\n"), (object) "GMAT DefaultProp.StopIfAccuracyIsViolated = true;"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "%---------- Burns"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "Create ImpulsiveBurn DefaultIB;"), (object) "\r\n"), (object) "GMAT DefaultIB.CoordinateSystem = Local;"), (object) "\r\n"), (object) "GMAT DefaultIB.Origin = Earth;"), (object) "\r\n"), (object) "GMAT DefaultIB.Axes = VNB;"), (object) "\r\n"), (object) "GMAT DefaultIB.Element1 = 0;"), (object) "\r\n"), (object) "GMAT DefaultIB.Element2 = 0;"), (object) "\r\n"), (object) "GMAT DefaultIB.Element3 = 0;"), (object) "\r\n"), (object) "GMAT DefaultIB.DecrementMass = false;"), (object) "\r\n"), (object) "GMAT DefaultIB.Isp = 300;"), (object) "\r\n"), (object) "GMAT DefaultIB.GravitationalAccel = 9.810000000000001;"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "%---------- Subscribers"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "Create OrbitView DefaultOrbitView;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.SolverIterations = Current;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.UpperLeft = [ 0.004716981132075472 0 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.Size = [ 0.5009433962264152 0.4501718213058419 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.RelativeZOrder = 5;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.Add = {DefaultSC, Earth};"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.CoordinateSystem = EarthMJ2000Eq;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.DrawObject = [ true true ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.OrbitColor = [ 255 32768 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.TargetColor = [ 8421440 0 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.DataCollectFrequency = 1;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.UpdatePlotFrequency = 50;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.NumPointsToRedraw = 0;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ShowPlot = true;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewPointReference = Earth;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewPointVector = [ 30000 0 0 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewDirection = Earth;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewScaleFactor = 1;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewUpCoordinateSystem = EarthMJ2000Eq;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewUpAxis = Z;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.EclipticPlane = Off;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.XYPlane = Off;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.WireFrame = Off;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.Axes = On;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.Grid = Off;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.SunLine = On;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.UseInitialView = On;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.StarCount = 7000;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.EnableStars = On;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.EnableConstellations = Off;"), (object) "\r\n"), Right2), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "%---------- Mission Sequence"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "BeginMissionSequence;"), (object) "\r\n"), (object) "Propagate DefaultProp(DefaultSC) {DefaultSC.ElapsedSecs = "), Right1), (object) "};"));
      System.IO.File.WriteAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) MyProject.Forms.Home.GMATPath, text), (object) ".script")), contents);
      int num = (int) TopMostMessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text, (object) ".script has been created in "), (object) "\r\n"), (object) MyProject.Forms.Home.GMATPath)), "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void ExportToGMAT_M()
    {
      Microsoft.VisualBasic.FileSystem.FileOpen(1, MyProject.Forms.Home.FleetFile, OpenMode.Input);
      object objectValue1;
      object obj1;
      object obj2;
      while (!Microsoft.VisualBasic.FileSystem.EOF(1))
      {
        string FileName = Microsoft.VisualBasic.FileSystem.LineInput(1);
        string Right1 = Microsoft.VisualBasic.FileSystem.LineInput(1);
        Microsoft.VisualBasic.FileSystem.FileOpen(2, FileName, OpenMode.Input);
        while (!Microsoft.VisualBasic.FileSystem.EOF(2))
        {
          string StringToCheck = Strings.RTrim(Microsoft.VisualBasic.FileSystem.LineInput(2));
          objectValue1 = RuntimeHelpers.GetObjectValue(Functions.CheckCaracts_M(ref StringToCheck));
          object obj3 = (object) Microsoft.VisualBasic.FileSystem.LineInput(2);
          object obj4 = (object) Microsoft.VisualBasic.FileSystem.LineInput(2);
          string Left1 = "";
          int num = 2;
          do
          {
            string Left2 = Left1;
            object Instance = obj3;
            object[] objArray = new object[1]
            {
              (object) num
            };
            object[] Arguments = objArray;
            bool[] flagArray = new bool[1]{ true };
            bool[] CopyBack = flagArray;
            object Right2 = NewLateBinding.LateGet(Instance, (Type) null, "Chars", Arguments, (string[]) null, (Type[]) null, CopyBack);
            if (flagArray[0])
              num = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (int));
            Left1 = Conversions.ToString(Operators.ConcatenateObject((object) Left2, Right2));
            checked { ++num; }
          }
          while (num <= 6);
          if (Operators.CompareString(Left1, Right1, false) == 0)
          {
            obj1 = !Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(obj1, (object) "", false), Operators.CompareObjectEqual(obj1, (object) null, false))) ? Operators.ConcatenateObject(Operators.ConcatenateObject(obj1, (object) ", "), objectValue1) : RuntimeHelpers.GetObjectValue(objectValue1);
            MyProject.Forms.Home.TLE_LoadMulti(Conversions.ToString(obj3), Conversions.ToString(obj4));
            obj2 = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(obj2, (object) "Create Spacecraft "), objectValue1), (object) ";"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".DateFormat = UTCModJulian;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Epoch = '"), (object) MyProject.Forms.Home.EPOCH), (object) "';"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".CoordinateSystem = EarthMJ2000Eq;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".DisplayStateType = Keplerian;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".SMA = "), (object) MyProject.Forms.Home.SMA), (object) ";"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ECC = "), (object) MyProject.Forms.Home.ECC), (object) ";"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".INC = "), (object) MyProject.Forms.Home.INC), (object) ";"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".RAAN = "), (object) MyProject.Forms.Home.RAAN), (object) ";"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".AOP = "), (object) MyProject.Forms.Home.AOP), (object) ";"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".TA = "), (object) (180.0 / Math.PI * MyProject.Forms.Home.TA)), (object) ";"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".DryMass = 850;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Cd = 2.2;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Cr = 1.8;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".DragArea = 15;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".SRPArea = 1;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".NAIFId = -123456789;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".NAIFIdReferenceFrame = -123456789;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Id = 'SatId';"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Attitude = CoordinateSystemFixed;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ModelFile = '../data/vehicle/models/aura.3ds';"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ModelOffsetX = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ModelOffsetY = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ModelOffsetZ = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ModelRotationX = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ModelRotationY = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ModelRotationZ = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".ModelScale = 3;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".AttitudeDisplayStateType = 'Quaternion';"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".AttitudeRateDisplayStateType = 'AngularVelocity';"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".AttitudeCoordinateSystem = 'EarthMJ2000Eq';"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Q1 = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Q2 = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Q3 = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".Q4 = 1;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".EulerAngleSequence = '321';"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".AngularVelocityX = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".AngularVelocityY = 0;"), (object) "\r\n"), (object) "GMAT "), objectValue1), (object) ".AngularVelocityZ = 0;"), (object) "\r\n"), (object) "\r\n");
          }
        }
        Microsoft.VisualBasic.FileSystem.FileClose(2);
      }
      Microsoft.VisualBasic.FileSystem.FileClose(1);
      if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(objectValue1, (object) "", false), Operators.CompareObjectEqual(objectValue1, (object) null, false))))
      {
        int num1 = (int) Interaction.MsgBox((object) "The GMAT fleet list seems to be empty.", MsgBoxStyle.Information, (object) "TLE ANALYSER");
      }
      else
      {
        object Right3 = (object) ((string[]) NewLateBinding.LateGet(obj1, (Type) null, "Split", new object[1]
        {
          (object) ","
        }, (string[]) null, (Type[]) null, (bool[]) null))[0];
        object Instance1 = (object) MyProject.Forms.Home.FleetFile.Remove(0, Strings.InStrRev(MyProject.Forms.Home.FleetFile, "\\"));
        int integer = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(Instance1, (Type) null, "Length", new object[0], (string[]) null, (Type[]) null, (bool[]) null), (object) 4));
        object Instance2 = Instance1;
        object[] objArray = new object[2]
        {
          (object) integer,
          (object) 4
        };
        object[] Arguments = objArray;
        bool[] flagArray = new bool[2]{ true, false };
        bool[] CopyBack = flagArray;
        object obj5 = NewLateBinding.LateGet(Instance2, (Type) null, "Remove", Arguments, (string[]) null, (Type[]) null, CopyBack);
        if (flagArray[0])
        {
          int num2 = (int) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (int));
        }
        object objectValue2 = RuntimeHelpers.GetObjectValue(obj5);
        object Right4 = !Conversions.ToBoolean(MyProject.Forms.Home.ShowTrack) ? (object) "" : Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) "Create GroundTrackPlot DefaultGroundTrackPlot;\r\nGMAT DefaultGroundTrackPlot.SolverIterations = Current;\r\nGMAT DefaultGroundTrackPlot.UpperLeft = [ 0.004716981132075472 0.4570446735395189 ];\r\nGMAT DefaultGroundTrackPlot.Size = [ 0.5009433962264152 0.4501718213058419 ];\r\nGMAT DefaultGroundTrackPlot.RelativeZOrder = 17;\r\nGMAT DefaultGroundTrackPlot.Add = {", obj1), (object) ", Earth};"), (object) "\r\n"), (object) "GMAT DefaultGroundTrackPlot.DataCollectFrequency = 1;"), (object) "\r\n"), (object) "GMAT DefaultGroundTrackPlot.UpdatePlotFrequency = 50;"), (object) "\r\n"), (object) "GMAT DefaultGroundTrackPlot.NumPointsToRedraw = 0;"), (object) "\r\n"), (object) "GMAT DefaultGroundTrackPlot.ShowPlot = true;"), (object) "\r\n"), (object) "GMAT DefaultGroundTrackPlot.CentralBody = Earth;"), (object) "\r\n"), (object) "GMAT DefaultGroundTrackPlot.TextureMap = '../data/graphics/texture/ModifiedBlueMarble.jpg';");
        object Right5;
        if (Conversions.ToBoolean(MyProject.Forms.Home.OptionGmatModel1))
          Right5 = (object) "%----------------------------------------\r\n%---------- ForceModels\r\n%----------------------------------------\r\nCreate ForceModel DefaultProp_ForceModel;\r\nGMAT DefaultProp_ForceModel.CentralBody = Earth;\r\nGMAT DefaultProp_ForceModel.PrimaryBodies = {Earth};\r\nGMAT DefaultProp_ForceModel.Drag = None;\r\nGMAT DefaultProp_ForceModel.SRP = Off;\r\nGMAT DefaultProp_ForceModel.RelativisticCorrection = Off;\r\nGMAT DefaultProp_ForceModel.ErrorControl = RSSStep;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.Degree = 2;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.Order = 0;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.PotentialFile = 'JGM3.cof';\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.EarthTideModel = 'None';";
        else if (Conversions.ToBoolean(MyProject.Forms.Home.OptionGmatModel2))
          Right5 = (object) "%----------------------------------------\r\n%---------- ForceModels\r\n%----------------------------------------\r\nCreate ForceModel DefaultProp_ForceModel;\r\nGMAT DefaultProp_ForceModel.CentralBody = Earth;\r\nGMAT DefaultProp_ForceModel.PrimaryBodies = {Earth};\r\nGMAT DefaultProp_ForceModel.PointMasses = {Luna, Sun};\r\nGMAT DefaultProp_ForceModel.Drag = None;\r\nGMAT DefaultProp_ForceModel.SRP = On;\r\nGMAT DefaultProp_ForceModel.RelativisticCorrection = Off;\r\nGMAT DefaultProp_ForceModel.ErrorControl = RSSStep;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.Degree = 4;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.Order = 4;\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.PotentialFile = 'JGM3.cof';\r\nGMAT DefaultProp_ForceModel.GravityField.Earth.EarthTideModel = 'None';\r\nGMAT DefaultProp_ForceModel.Drag.AtmosphereModel = MSISE90;\r\nGMAT DefaultProp_ForceModel.Drag.F107 = 150;\r\nGMAT DefaultProp_ForceModel.Drag.F107A = 150;\r\nGMAT DefaultProp_ForceModel.Drag.MagneticIndex = 3;\r\nGMAT DefaultProp_ForceModel.SRP.Flux = 1367;\r\nGMAT DefaultProp_ForceModel.SRP.Nominal_Sun = 149597870.691;";
        string contents = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object) ("%General Mission Analysis Tool(GMAT) Script\r\n%Created from TLE Analyser:" + Conversions.ToString(DateTime.Now) + "\r\n" + "%----------------------------------------" + "\r\n" + "%----------"), objectValue2), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), obj2), Right5), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "%---------- Propagators"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "Create Propagator DefaultProp;"), (object) "\r\n"), (object) "GMAT DefaultProp.FM = DefaultProp_ForceModel;"), (object) "\r\n"), (object) "GMAT DefaultProp.Type = RungeKutta89;"), (object) "\r\n"), (object) "GMAT DefaultProp.InitialStepSize = 60;"), (object) "\r\n"), (object) "GMAT DefaultProp.Accuracy = 9.999999999999999e-012;"), (object) "\r\n"), (object) "GMAT DefaultProp.MinStep = 0.001;"), (object) "\r\n"), (object) "GMAT DefaultProp.MaxStep = 2700;"), (object) "\r\n"), (object) "GMAT DefaultProp.MaxStepAttempts = 50;"), (object) "\r\n"), (object) "GMAT DefaultProp.StopIfAccuracyIsViolated = true;"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "%---------- Burns"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "Create ImpulsiveBurn DefaultIB;"), (object) "\r\n"), (object) "GMAT DefaultIB.CoordinateSystem = Local;"), (object) "\r\n"), (object) "GMAT DefaultIB.Origin = Earth;"), (object) "\r\n"), (object) "GMAT DefaultIB.Axes = VNB;"), (object) "\r\n"), (object) "GMAT DefaultIB.Element1 = 0;"), (object) "\r\n"), (object) "GMAT DefaultIB.Element2 = 0;"), (object) "\r\n"), (object) "GMAT DefaultIB.Element3 = 0;"), (object) "\r\n"), (object) "GMAT DefaultIB.DecrementMass = false;"), (object) "\r\n"), (object) "GMAT DefaultIB.Isp = 300;"), (object) "\r\n"), (object) "GMAT DefaultIB.GravitationalAccel = 9.810000000000001;"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "%---------- Subscribers"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "Create OrbitView DefaultOrbitView;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.SolverIterations = Current;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.UpperLeft = [ 0.004716981132075472 0 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.Size = [ 0.5009433962264152 0.4501718213058419 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.RelativeZOrder = 5;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.Add = {"), obj1), (object) ", Earth, Sun};"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.CoordinateSystem = EarthMJ2000Eq;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.DrawObject = [ true true ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.OrbitColor = [ 255 32768 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.TargetColor = [ 8421440 0 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.DataCollectFrequency = 1;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.UpdatePlotFrequency = 50;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.NumPointsToRedraw = 0;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ShowPlot = true;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewPointReference = Earth;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewPointVector = [ 30000 0 0 ];"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewDirection = Earth;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewScaleFactor = 1;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewUpCoordinateSystem = EarthMJ2000Eq;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.ViewUpAxis = Z;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.EclipticPlane = Off;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.XYPlane = Off;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.WireFrame = Off;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.Axes = On;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.Grid = Off;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.SunLine = On;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.UseInitialView = On;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.StarCount = 7000;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.EnableStars = On;"), (object) "\r\n"), (object) "GMAT DefaultOrbitView.EnableConstellations = Off;"), (object) "\r\n"), Right4), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "%---------- Mission Sequence"), (object) "\r\n"), (object) "%----------------------------------------"), (object) "\r\n"), (object) "BeginMissionSequence;"), (object) "\r\n"), (object) "Propagate DefaultProp("), obj1), (object) ") {"), Right3), (object) ".ElapsedDays = 1};"));
        System.IO.File.WriteAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object) MyProject.Forms.Home.GMATPath, objectValue2), (object) ".script")), contents);
        int num3 = (int) TopMostMessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(objectValue2, (object) ".script has been created in "), (object) "\r\n"), (object) MyProject.Forms.Home.GMATPath)), "TLE Analyser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
      }
    }

    public static long Get_Private_Profile_Int(
      string cAppName,
      string cKeyName,
      int nKeyDefault,
      string cProfName)
    {
      return Functions.GetPrivateProfileInt(ref cAppName, ref cKeyName, (long) nKeyDefault, ref cProfName);
    }

    public static int Get_Private_Profile_String(
      string cAppName,
      string cKeyName,
      string cKeyDefault,
      ref string cKeyValue,
      string cProfName)
    {
      int privateProfileString;
      if (Operators.CompareString(cKeyName, "", false) == 0)
      {
        cKeyValue = Strings.Space(1025);
        ref string local1 = ref cAppName;
        string str1 = "";
        ref string local2 = ref str1;
        string str2 = "";
        ref string local3 = ref str2;
        ref string local4 = ref cKeyValue;
        ref string local5 = ref cProfName;
        privateProfileString = Functions.GetPrivateProfileString(ref local1, ref local2, ref local3, ref local4, (short) 1024, ref local5);
      }
      else
      {
        cKeyValue = Strings.Space((int) byte.MaxValue);
        privateProfileString = Functions.GetPrivateProfileString(ref cAppName, ref cKeyName, ref cKeyDefault, ref cKeyValue, (short) byte.MaxValue, ref cProfName);
      }
      cKeyValue = Strings.Trim(cKeyValue);
      return privateProfileString;
    }

    public static bool Put_Private_Profile_String(
      string cAppName,
      string cKeyName,
      string cKeyValue,
      string cProfName)
    {
      return Functions.WritePrivateProfileString(ref cAppName, ref cKeyName, ref cKeyValue, ref cProfName) != 0L;
    }

    public static void ReadInit()
    {
label_1:
      int num1;
      int num2;
      try
      {
        int num3 = 1;
        MyProject.Forms.Home.TleUpdateDate = Strings.Space((int) byte.MaxValue);
label_2:
        num3 = 2;
        MyProject.Forms.Home.Speed = Strings.Space((int) byte.MaxValue);
label_3:
        num3 = 3;
        MyProject.Forms.Home.SatVisual1 = Strings.Space((int) byte.MaxValue);
label_4:
        num3 = 4;
        MyProject.Forms.Home.SatVisual2 = Strings.Space((int) byte.MaxValue);
label_5:
        num3 = 5;
        MyProject.Forms.Home.SatVisual3 = Strings.Space((int) byte.MaxValue);
label_6:
        num3 = 6;
        MyProject.Forms.Home.ShowTrack = Strings.Space((int) byte.MaxValue);
label_7:
        num3 = 7;
        MyProject.Forms.Home.OptionGmatModel1 = Strings.Space((int) byte.MaxValue);
label_8:
        num3 = 8;
        MyProject.Forms.Home.OptionGmatModel2 = Strings.Space((int) byte.MaxValue);
label_9:
        num3 = 9;
        MyProject.Forms.Home.Propagate = Strings.Space((int) byte.MaxValue);
label_10:
        num3 = 10;
        MyProject.Forms.Home.SimulOn = Strings.Space((int) byte.MaxValue);
label_11:
        num3 = 11;
        MyProject.Forms.Home.RealTimeStep = Strings.Space((int) byte.MaxValue);
label_12:
        num3 = 12;
        MyProject.Forms.Home.LoadTleNow = Strings.Space((int) byte.MaxValue);
label_13:
        num3 = 13;
        MyProject.Forms.Home.LoadTleEpoch = Strings.Space((int) byte.MaxValue);
label_14:
        num3 = 14;
        MyProject.Forms.Home.GSFullName = Strings.Space((int) byte.MaxValue);
label_15:
        num3 = 15;
        MyProject.Forms.Home.GSShortName = Strings.Space((int) byte.MaxValue);
label_16:
        num3 = 16;
        MyProject.Forms.Home.LimitAngle = Strings.Space((int) byte.MaxValue);
label_17:
        num3 = 17;
        MyProject.Forms.Home.EquRadius = Strings.Space((int) byte.MaxValue);
label_18:
        num3 = 18;
        string cProfName = MyProject.Forms.Home.AppPath + "tlea.ini";
label_19:
        ProjectData.ClearProjectError();
        num1 = -2;
label_20:
        num3 = 20;
        int privateProfileString = Functions.Get_Private_Profile_String("TLE", "date", "", ref MyProject.Forms.Home.TleUpdateDate, cProfName);
label_21:
        num3 = 21;
        privateProfileString = Functions.Get_Private_Profile_String("Tracking Options", "speed", "", ref MyProject.Forms.Home.Speed, cProfName);
label_22:
        num3 = 22;
        privateProfileString = Functions.Get_Private_Profile_String("Tracking Options", "SatVisual1", "", ref MyProject.Forms.Home.SatVisual1, cProfName);
label_23:
        num3 = 23;
        privateProfileString = Functions.Get_Private_Profile_String("Tracking Options", "SatVisual2", "", ref MyProject.Forms.Home.SatVisual2, cProfName);
label_24:
        num3 = 24;
        privateProfileString = Functions.Get_Private_Profile_String("Tracking Options", "SatVisual3", "", ref MyProject.Forms.Home.SatVisual3, cProfName);
label_25:
        num3 = 25;
        privateProfileString = Functions.Get_Private_Profile_String("Tracking Options", "Simulation On", "", ref MyProject.Forms.Home.SimulOn, cProfName);
label_26:
        num3 = 26;
        privateProfileString = Functions.Get_Private_Profile_String("Tracking Options", "RealTimeStep", "", ref MyProject.Forms.Home.RealTimeStep, cProfName);
label_27:
        num3 = 27;
        privateProfileString = Functions.Get_Private_Profile_String("GMAT Export", "show track", "", ref MyProject.Forms.Home.ShowTrack, cProfName);
label_28:
        num3 = 28;
        privateProfileString = Functions.Get_Private_Profile_String("GMAT Export", "OptionGmatModel1", "", ref MyProject.Forms.Home.OptionGmatModel1, cProfName);
label_29:
        num3 = 29;
        privateProfileString = Functions.Get_Private_Profile_String("GMAT Export", "OptionGmatModel2", "", ref MyProject.Forms.Home.OptionGmatModel2, cProfName);
label_30:
        num3 = 30;
        privateProfileString = Functions.Get_Private_Profile_String("GMAT Export", "propagate", "", ref MyProject.Forms.Home.Propagate, cProfName);
label_31:
        num3 = 31;
        privateProfileString = Functions.Get_Private_Profile_String("TLE Options", "LoadTleNow", "", ref MyProject.Forms.Home.LoadTleNow, cProfName);
label_32:
        num3 = 32;
        privateProfileString = Functions.Get_Private_Profile_String("TLE Options", "LoadTleEpoch", "", ref MyProject.Forms.Home.LoadTleEpoch, cProfName);
label_33:
        num3 = 33;
        privateProfileString = Functions.Get_Private_Profile_String("Ground Stations", "GSFullName", "", ref MyProject.Forms.Home.GSFullName, cProfName);
label_34:
        num3 = 34;
        privateProfileString = Functions.Get_Private_Profile_String("Ground Stations", "GSShortName", "", ref MyProject.Forms.Home.GSShortName, cProfName);
label_35:
        num3 = 35;
        privateProfileString = Functions.Get_Private_Profile_String("Ground Stations", "LimitAngle", "", ref MyProject.Forms.Home.LimitAngle, cProfName);
label_36:
        num3 = 36;
        privateProfileString = Functions.Get_Private_Profile_String("Elements Options", "EquRadius", "", ref MyProject.Forms.Home.EquRadius, cProfName);
label_37:
        num3 = 37;
        MyProject.Forms.Options.TleLastUpdate.Text = MyProject.Forms.Home.TleUpdateDate;
label_38:
        num3 = 38;
        MyProject.Forms.Options.GMAT_ShowTrack.Checked = Conversions.ToBoolean(MyProject.Forms.Home.ShowTrack);
label_39:
        num3 = 39;
        MyProject.Forms.Options.GMAT_PartialModel.Checked = Conversions.ToBoolean(MyProject.Forms.Home.OptionGmatModel1);
label_40:
        num3 = 40;
        MyProject.Forms.Options.GMAT_FullModel.Checked = Conversions.ToBoolean(MyProject.Forms.Home.OptionGmatModel2);
label_41:
        num3 = 41;
        MyProject.Forms.Options.GMAT_Period.SelectedItem = (object) Conversions.ToString(Conversions.ToInteger(MyProject.Forms.Home.Propagate));
label_42:
        num3 = 42;
        MyProject.Forms.Options.TRACK_Speed.SelectedItem = (object) Conversions.ToString(Conversions.ToInteger(MyProject.Forms.Home.Speed));
label_43:
        num3 = 43;
        MyProject.Forms.Options.MAP_SatIcon1.Checked = Conversions.ToBoolean(MyProject.Forms.Home.SatVisual1);
label_44:
        num3 = 44;
        MyProject.Forms.Options.MAP_SatIcon3.Checked = Conversions.ToBoolean(MyProject.Forms.Home.SatVisual2);
label_45:
        num3 = 45;
        MyProject.Forms.Options.MAP_SatIcon2.Checked = Conversions.ToBoolean(MyProject.Forms.Home.SatVisual3);
label_46:
        num3 = 46;
        MyProject.Forms.Options.TRACK_RTMStart.Checked = Conversions.ToBoolean(MyProject.Forms.Home.SimulOn);
label_47:
        num3 = 47;
        MyProject.Forms.Options.TRACK_RTMStep.SelectedItem = (object) Conversions.ToString(Conversions.ToInteger(MyProject.Forms.Home.RealTimeStep));
label_48:
        num3 = 48;
        Bitmap bitmap1 = new Bitmap((Image) TLE_Analyser.My.Resources.Resources.Sat);
label_49:
        num3 = 49;
        Bitmap bitmap2 = new Bitmap((Image) TLE_Analyser.My.Resources.Resources.sat2);
label_50:
        num3 = 50;
        Bitmap bitmap3 = new Bitmap((Image) TLE_Analyser.My.Resources.Resources.Sat3);
label_51:
        num3 = 51;
        bitmap1.MakeTransparent(bitmap1.GetPixel(0, 0));
label_52:
        num3 = 52;
        bitmap2.MakeTransparent(bitmap2.GetPixel(0, 0));
label_53:
        num3 = 53;
        bitmap3.MakeTransparent(bitmap3.GetPixel(0, 0));
label_54:
        num3 = 54;
        MyProject.Forms.Options.SatPictOp1.Image = (Image) bitmap1;
label_55:
        num3 = 55;
        MyProject.Forms.Options.SatPictOp2.Image = (Image) bitmap2;
label_56:
        num3 = 56;
        MyProject.Forms.Options.SatPictOp3.Image = (Image) bitmap3;
label_57:
        num3 = 57;
        MyProject.Forms.Options.TLE_LoadCurrentEpoch.Checked = Conversions.ToBoolean(MyProject.Forms.Home.LoadTleNow);
label_58:
        num3 = 58;
        MyProject.Forms.Options.TLE_LoadTLEepoch.Checked = Conversions.ToBoolean(MyProject.Forms.Home.LoadTleEpoch);
label_59:
        num3 = 59;
        MyProject.Forms.Options.GS_FullName.Checked = Conversions.ToBoolean(MyProject.Forms.Home.GSFullName);
label_60:
        num3 = 60;
        MyProject.Forms.Options.GS_ShortName.Checked = Conversions.ToBoolean(MyProject.Forms.Home.GSShortName);
label_61:
        num3 = 61;
        MyProject.Forms.Options.GS_LimitAngle.SelectedItem = (object) Conversions.ToString(Conversions.ToInteger(MyProject.Forms.Home.LimitAngle));
label_62:
        num3 = 62;
        MyProject.Forms.Options.AltMeanRadius.Checked = Conversions.ToBoolean(MyProject.Forms.Home.EquRadius);
        goto label_69;
label_64:
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
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_10;
              case 11:
                goto label_11;
              case 12:
                goto label_12;
              case 13:
                goto label_13;
              case 14:
                goto label_14;
              case 15:
                goto label_15;
              case 16:
                goto label_16;
              case 17:
                goto label_17;
              case 18:
                goto label_18;
              case 19:
                goto label_19;
              case 20:
                goto label_20;
              case 21:
                goto label_21;
              case 22:
                goto label_22;
              case 23:
                goto label_23;
              case 24:
                goto label_24;
              case 25:
                goto label_25;
              case 26:
                goto label_26;
              case 27:
                goto label_27;
              case 28:
                goto label_28;
              case 29:
                goto label_29;
              case 30:
                goto label_30;
              case 31:
                goto label_31;
              case 32:
                goto label_32;
              case 33:
                goto label_33;
              case 34:
                goto label_34;
              case 35:
                goto label_35;
              case 36:
                goto label_36;
              case 37:
                goto label_37;
              case 38:
                goto label_38;
              case 39:
                goto label_39;
              case 40:
                goto label_40;
              case 41:
                goto label_41;
              case 42:
                goto label_42;
              case 43:
                goto label_43;
              case 44:
                goto label_44;
              case 45:
                goto label_45;
              case 46:
                goto label_46;
              case 47:
                goto label_47;
              case 48:
                goto label_48;
              case 49:
                goto label_49;
              case 50:
                goto label_50;
              case 51:
                goto label_51;
              case 52:
                goto label_52;
              case 53:
                goto label_53;
              case 54:
                goto label_54;
              case 55:
                goto label_55;
              case 56:
                goto label_56;
              case 57:
                goto label_57;
              case 58:
                goto label_58;
              case 59:
                goto label_59;
              case 60:
                goto label_60;
              case 61:
                goto label_61;
              case 62:
                goto label_62;
              case 63:
                goto label_69;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
        goto label_64;
      }
      throw ProjectData.CreateProjectError(-2146828237);
label_69:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public static void SaveInit()
    {
      string initFile = MyProject.Forms.Home.InitFile;
      MyProject.Forms.Home.TleUpdateDate = MyProject.Forms.Home.TleUpdateDate;
      MyProject.Forms.Home.TLEAVersion = (object) Conversions.ToString(MyProject.Forms.Home.TLEAVersion);
      MyProject.Forms.Home.ShowTrack = Conversions.ToString(MyProject.Forms.Options.GMAT_ShowTrack.Checked);
      MyProject.Forms.Home.OptionGmatModel1 = Conversions.ToString(MyProject.Forms.Options.GMAT_PartialModel.Checked);
      MyProject.Forms.Home.OptionGmatModel2 = Conversions.ToString(MyProject.Forms.Options.GMAT_FullModel.Checked);
      MyProject.Forms.Home.Propagate = Conversions.ToString(MyProject.Forms.Options.GMAT_Period.SelectedItem);
      MyProject.Forms.Home.Speed = Conversions.ToString(MyProject.Forms.Options.TRACK_Speed.SelectedItem);
      MyProject.Forms.Home.SatVisual1 = Conversions.ToString(MyProject.Forms.Options.MAP_SatIcon1.Checked);
      MyProject.Forms.Home.SatVisual2 = Conversions.ToString(MyProject.Forms.Options.MAP_SatIcon3.Checked);
      MyProject.Forms.Home.SatVisual3 = Conversions.ToString(MyProject.Forms.Options.MAP_SatIcon2.Checked);
      MyProject.Forms.Home.SimulOn = Conversions.ToString(MyProject.Forms.Options.TRACK_RTMStart.Checked);
      MyProject.Forms.Home.RealTimeStep = Conversions.ToString(MyProject.Forms.Options.TRACK_RTMStep.SelectedItem);
      MyProject.Forms.Home.LoadTleNow = Conversions.ToString(MyProject.Forms.Options.TLE_LoadCurrentEpoch.Checked);
      MyProject.Forms.Home.LoadTleEpoch = Conversions.ToString(MyProject.Forms.Options.TLE_LoadTLEepoch.Checked);
      MyProject.Forms.Home.GSFullName = Conversions.ToString(MyProject.Forms.Options.GS_FullName.Checked);
      MyProject.Forms.Home.GSShortName = Conversions.ToString(MyProject.Forms.Options.GS_ShortName.Checked);
      MyProject.Forms.Home.LimitAngle = Conversions.ToString(MyProject.Forms.Options.GS_LimitAngle.SelectedItem);
      MyProject.Forms.Home.EquRadius = Conversions.ToString(MyProject.Forms.Options.AltMeanRadius.Checked);
      bool flag = Functions.Put_Private_Profile_String("TLE", "date", MyProject.Forms.Home.TleUpdateDate, initFile);
      flag = Functions.Put_Private_Profile_String("TLE", "version", Conversions.ToString(MyProject.Forms.Home.TLEAVersion), initFile);
      flag = Functions.Put_Private_Profile_String("Tracking Options", "speed", MyProject.Forms.Home.Speed, initFile);
      flag = Functions.Put_Private_Profile_String("Tracking Options", "SatVisual1", MyProject.Forms.Home.SatVisual1, initFile);
      flag = Functions.Put_Private_Profile_String("Tracking Options", "SatVisual2", MyProject.Forms.Home.SatVisual2, initFile);
      flag = Functions.Put_Private_Profile_String("Tracking Options", "SatVisual3", MyProject.Forms.Home.SatVisual3, initFile);
      flag = Functions.Put_Private_Profile_String("Tracking Options", "Simulation On", MyProject.Forms.Home.SimulOn, initFile);
      flag = Functions.Put_Private_Profile_String("Tracking Options", "RealTimeStep", MyProject.Forms.Home.RealTimeStep, initFile);
      flag = Functions.Put_Private_Profile_String("GMAT Export", "show track", MyProject.Forms.Home.ShowTrack, initFile);
      flag = Functions.Put_Private_Profile_String("GMAT Export", "OptionGmatModel1", MyProject.Forms.Home.OptionGmatModel1, initFile);
      flag = Functions.Put_Private_Profile_String("GMAT Export", "OptionGmatModel2", MyProject.Forms.Home.OptionGmatModel2, initFile);
      flag = Functions.Put_Private_Profile_String("GMAT Export", "propagate", MyProject.Forms.Home.Propagate, initFile);
      flag = Functions.Put_Private_Profile_String("TLE Options", "LoadTleNow", MyProject.Forms.Home.LoadTleNow, initFile);
      flag = Functions.Put_Private_Profile_String("TLE Options", "LoadTleEpoch", MyProject.Forms.Home.LoadTleEpoch, initFile);
      flag = Functions.Put_Private_Profile_String("Ground Stations", "GSFullName", MyProject.Forms.Home.GSFullName, initFile);
      flag = Functions.Put_Private_Profile_String("Ground Stations", "GSShortName", MyProject.Forms.Home.GSShortName, initFile);
      flag = Functions.Put_Private_Profile_String("Ground Stations", "LimitAngle", MyProject.Forms.Home.LimitAngle, initFile);
      flag = Functions.Put_Private_Profile_String("Elements Options", "EquRadius", MyProject.Forms.Home.EquRadius, initFile);
    }

    public static void InitGraphics()
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
        MyProject.Forms.Home.MapW = MyProject.Forms.Home.MapPanel.Width;
label_3:
        num3 = 3;
        MyProject.Forms.Home.MapH = MyProject.Forms.Home.MapPanel.Height;
label_4:
        num3 = 4;
        MyProject.Forms.Home.Trace = new Bitmap(MyProject.Forms.Home.MapW, MyProject.Forms.Home.MapH);
label_5:
        num3 = 5;
        MyProject.Forms.Home.g = Graphics.FromImage((Image) MyProject.Forms.Home.Trace);
label_6:
        num3 = 6;
        MyProject.Forms.Home.radarW = MyProject.Forms.Home.radarPicture.Width;
label_7:
        num3 = 7;
        MyProject.Forms.Home.radarH = MyProject.Forms.Home.radarPicture.Height;
label_8:
        num3 = 8;
        MyProject.Forms.Home.radarTrace = new Bitmap(MyProject.Forms.Home.radarW, MyProject.Forms.Home.radarH);
label_9:
        num3 = 9;
        MyProject.Forms.Home.radarGraph = Graphics.FromImage((Image) MyProject.Forms.Home.radarTrace);
        goto label_16;
label_11:
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
                goto label_5;
              case 6:
                goto label_6;
              case 7:
                goto label_7;
              case 8:
                goto label_8;
              case 9:
                goto label_9;
              case 10:
                goto label_16;
            }
            break;
        }
      }
      catch (Exception ex) when (ex is Exception & num1 != 0 & num2 == 0)
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
  }
}
