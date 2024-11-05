// Decompiled with JetBrains decompiler
// Type: DevPackMine.MessageHandle
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using System.Windows.Forms;

namespace DevPackMine
{
  public class MessageHandle
  {
    public void SuccessFileMessage()
    {
      int num = (int) MessageBox.Show("Your file success saved!", "Success");
    }

    public void FailedFileMessage()
    {
      int num = (int) MessageBox.Show("Your file can't saved!", "Failed");
    }

    public void WelcomeMessage()
    {
      int num = (int) MessageBox.Show("This program use the ExportLod DLL by DamonA.", "Welcome devloper!");
    }
  }
}
