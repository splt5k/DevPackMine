// Decompiled with JetBrains decompiler
// Type: DevPackMine.tMeshTexture
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

namespace DevPackMine
{
  public struct tMeshTexture
  {
    public byte[] InternalName;
    public int Reserverd;

    public tMeshTexture(byte[] Name)
    {
            InternalName = Name;
            Reserverd = 0;
    }
  }
}
