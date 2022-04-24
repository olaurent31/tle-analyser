// Decompiled with JetBrains decompiler
// Type: TLE_Analyser.TopMostMessageBox
// Assembly: TLE Analyser, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CA947322-4F35-434B-8CA2-411C8482C9EF
// Assembly location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.exe
// XML documentation location: C:\Users\Olivier\OneDrive\OLIVIER\LOISIRS\TLEANALYSER\TLE Analyser.xml

using System.Drawing;
using System.Windows.Forms;

namespace TLE_Analyser
{
  public sealed class TopMostMessageBox
  {
    private TopMostMessageBox()
    {
    }

    public static DialogResult Show(string message) => TopMostMessageBox.Show(message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

    public static DialogResult Show(string message, string title) => TopMostMessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

    public static DialogResult Show(
      string message,
      string title,
      MessageBoxButtons buttons,
      MessageBoxIcon icon,
      MessageBoxDefaultButton defaultButton)
    {
      Form owner = new Form();
      owner.Size = new Size(1, 1);
      owner.StartPosition = FormStartPosition.CenterScreen;
      Rectangle virtualScreen = SystemInformation.VirtualScreen;
      owner.Location = new Point(checked (virtualScreen.Bottom + 10), checked (virtualScreen.Right + 10));
      owner.Show();
      owner.Focus();
      owner.BringToFront();
      owner.TopMost = true;
      DialogResult dialogResult = MessageBox.Show((IWin32Window) owner, message, title, buttons, icon, defaultButton);
      owner.Dispose();
      return dialogResult;
    }
  }
}
