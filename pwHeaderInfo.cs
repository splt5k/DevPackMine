// Decompiled with JetBrains decompiler
// Type: DevPackMine.pwHeaderInfo
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

namespace DevPackMine
{
  public class pwHeaderInfo
  {
    public byte[] Format { get; set; }

    public uint JointCount { get; set; }

    public uint MaterialCount { get; set; }

    public uint MeshCount { get; set; }

    public uint TextureCount { get; set; }

    public uint TypeMask { get; set; }

    public uint UnknownValue1 { get; set; }

    public uint UnknownValue2 { get; set; }

    public uint UnknownValue3 { get; set; }

    public int Version { get; set; }

    public uint VertexType { get; set; }
  }
}
