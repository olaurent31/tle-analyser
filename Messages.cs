// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.Messages
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TLE_Analyser.My;

namespace TLE_Analyser
{
  public sealed class Messages
  {
    public const int INFO = 0;
    public const int ERREUR = -1;
    public const int WARNING = 1;

    private Messages()
    {
    }

    /// <summary>Construction d'un message</summary>
    /// <param name="msgvar">Partie variable du message</param>
    /// <param name="msgfix">Partie fixe du message</param>
    /// <returns>Message construit</returns>
    /// <remarks></remarks>
    public static string Construire(string msgvar, string msgfix)
    {
      string str = msgfix;
      if (msgfix.Contains("#"))
      {
        string[] strArray = msgvar.Split('#');
        if (checked (msgfix.Split('#').Length - 1) == strArray.Length)
        {
          int startIndex1 = 0;
          int num = checked (strArray.Length - 1);
          int index = 0;
          while (index <= num)
          {
            int startIndex2 = str.IndexOf("#", startIndex1, StringComparison.CurrentCulture);
            str = str.Insert(startIndex2, strArray[index]);
            startIndex1 = checked (startIndex2 + strArray[index].Length + 1);
            checked { ++index; }
          }
          str = str.Replace("#", "").Replace("&", Environment.NewLine).Replace('$', '\t');
        }
      }
      else
        str = str.Replace("&", Environment.NewLine).Replace('$', '\t');
      return str;
    }

    /// <summary>Affichage des boites de message d'erreur ou d'information</summary>
    /// <param name="msgvar">Partie variable du message apparaissant dans le corps de la boite de message</param>
    /// <param name="msgfix">Partie fixe du message apparaissant dans le corps de la boite de message</param>
    /// <param name="ierr">Type de l'erreur</param>
    /// <remarks></remarks>
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    public static void Afficher(string msgvar, string msgfix, int ierr)
    {
      string caption = "";
      MessageBoxIcon icon;
      switch (ierr)
      {
        case -1:
          icon = MessageBoxIcon.Hand;
          caption = TLE_Analyser.My.Resources.Resources.titre2;
          break;
        case 0:
          icon = MessageBoxIcon.Asterisk;
          caption = TLE_Analyser.My.Resources.Resources.titre1;
          break;
        case 1:
          icon = MessageBoxIcon.Exclamation;
          caption = TLE_Analyser.My.Resources.Resources.titre3;
          break;
      }
      int num = (int) MessageBox.Show(Messages.Construire(msgvar, msgfix), caption, MessageBoxButtons.OK, icon, MessageBoxDefaultButton.Button1, (MessageBoxOptions) 0, false);
      if (ierr != -1)
        return;
      DirectoryInfo directoryInfo = new DirectoryInfo(MyProject.Application.Info.DirectoryPath + "\\out");
      if (directoryInfo.Exists)
        directoryInfo.Delete(true);
      ProjectData.EndApp();
    }
  }
}
