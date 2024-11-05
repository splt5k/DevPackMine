// Decompiled with JetBrains decompiler
// Type: DevPackMine.Globals
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

namespace DevPackMine
{
  public class Globals
  {
    public static string Name = "LastChaos Tool Collection ";
    public static string DebugRelease = "R";
    public static string Version = "1." + EditorInformation.Editor_Release.Length.ToString() + "." + EditorInformation.Editor_Beta.Length.ToString() + EditorInformation.Editor_Alpha.Length.ToString() + Globals.DebugRelease;
    public static bool LicenceSystem = false;
    public static bool Console = false;
  }
}
