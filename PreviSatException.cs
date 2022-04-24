// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.PreviSatException
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace TLE_Analyser
{
  public class PreviSatException : Exception
  {
    private static List<WeakReference> __ENCList = new List<WeakReference>();

    [DebuggerNonUserCode]
    static PreviSatException()
    {
    }

    [DebuggerNonUserCode]
    private static void __ENCAddToList(object value)
    {
      lock (PreviSatException.__ENCList)
      {
        if (PreviSatException.__ENCList.Count == PreviSatException.__ENCList.Capacity)
        {
          int index1 = 0;
          int num = checked (PreviSatException.__ENCList.Count - 1);
          int index2 = 0;
          while (index2 <= num)
          {
            if (PreviSatException.__ENCList[index2].IsAlive)
            {
              if (index2 != index1)
                PreviSatException.__ENCList[index1] = PreviSatException.__ENCList[index2];
              checked { ++index1; }
            }
            checked { ++index2; }
          }
          PreviSatException.__ENCList.RemoveRange(index1, checked (PreviSatException.__ENCList.Count - index1));
          PreviSatException.__ENCList.Capacity = PreviSatException.__ENCList.Count;
        }
        PreviSatException.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
      }
    }

    public PreviSatException() => PreviSatException.__ENCAddToList((object) this);

    public PreviSatException(ref int ierr)
    {
      PreviSatException.__ENCAddToList((object) this);
      this.Source = ierr.ToString((IFormatProvider) CultureInfo.CurrentCulture);
    }

    public PreviSatException(string msgvar, string msgfix, int ierr)
    {
      PreviSatException.__ENCAddToList((object) this);
      Messages.Afficher(msgvar, msgfix, ierr);
    }
  }
}
