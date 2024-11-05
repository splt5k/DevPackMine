// Decompiled with JetBrains decompiler
// Type: DevPackMine.smcMesh
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

using System.Collections.Generic;

namespace DevPackMine
{
  public struct smcMesh
  {
    public string FileName;
    public List<smcObject> Object;

    public smcMesh(string FileName)
    {
      this.FileName = FileName;
            Object = new List<smcObject>();
    }
  }
}
