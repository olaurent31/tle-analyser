// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.My.MyProject
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TLE_Analyser.My
{
  [HideModuleName]
  [GeneratedCode("MyTemplate", "10.0.0.0")]
  [StandardModule]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [DebuggerNonUserCode]
    static MyProject()
    {
    }

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyForms
    {
      public ChartForm m_ChartForm;
      public Dialog_Fleet m_Dialog_Fleet;
      public GroundStations m_GroundStations;
      public Home m_Home;
      public Options m_Options;
      public OrbitSummary m_OrbitSummary;
      public Search m_Search;
      public SplashScreen m_SplashScreen;
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;

      public ChartForm ChartForm
      {
        [DebuggerNonUserCode] get
        {
          this.m_ChartForm = MyProject.MyForms.Create__Instance__<ChartForm>(this.m_ChartForm);
          return this.m_ChartForm;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_ChartForm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<ChartForm>(ref this.m_ChartForm);
        }
      }

      public Dialog_Fleet Dialog_Fleet
      {
        [DebuggerNonUserCode] get
        {
          this.m_Dialog_Fleet = MyProject.MyForms.Create__Instance__<Dialog_Fleet>(this.m_Dialog_Fleet);
          return this.m_Dialog_Fleet;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Dialog_Fleet)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog_Fleet>(ref this.m_Dialog_Fleet);
        }
      }

      public GroundStations GroundStations
      {
        [DebuggerNonUserCode] get
        {
          this.m_GroundStations = MyProject.MyForms.Create__Instance__<GroundStations>(this.m_GroundStations);
          return this.m_GroundStations;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_GroundStations)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<GroundStations>(ref this.m_GroundStations);
        }
      }

      public Home Home
      {
        [DebuggerNonUserCode] get
        {
          this.m_Home = MyProject.MyForms.Create__Instance__<Home>(this.m_Home);
          return this.m_Home;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Home)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Home>(ref this.m_Home);
        }
      }

      public Options Options
      {
        [DebuggerNonUserCode] get
        {
          this.m_Options = MyProject.MyForms.Create__Instance__<Options>(this.m_Options);
          return this.m_Options;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Options)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Options>(ref this.m_Options);
        }
      }

      public OrbitSummary OrbitSummary
      {
        [DebuggerNonUserCode] get
        {
          this.m_OrbitSummary = MyProject.MyForms.Create__Instance__<OrbitSummary>(this.m_OrbitSummary);
          return this.m_OrbitSummary;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_OrbitSummary)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<OrbitSummary>(ref this.m_OrbitSummary);
        }
      }

      public Search Search
      {
        [DebuggerNonUserCode] get
        {
          this.m_Search = MyProject.MyForms.Create__Instance__<Search>(this.m_Search);
          return this.m_Search;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_Search)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Search>(ref this.m_Search);
        }
      }

      public SplashScreen SplashScreen
      {
        [DebuggerNonUserCode] get
        {
          this.m_SplashScreen = MyProject.MyForms.Create__Instance__<SplashScreen>(this.m_SplashScreen);
          return this.m_SplashScreen;
        }
        [DebuggerNonUserCode] set
        {
          if (value == this.m_SplashScreen)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<SplashScreen>(ref this.m_SplashScreen);
        }
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        try
        {
          return new T();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new Type GetType() => typeof (MyProject.MyForms);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();
    }

    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyWebServices
    {
      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new Type GetType() => typeof (MyProject.MyWebServices);

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new() => (object) instance == null ? new T() : instance;

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public MyWebServices()
      {
      }
    }

    [ComVisible(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
