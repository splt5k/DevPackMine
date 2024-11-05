// Decompiled with JetBrains decompiler
// Type: DevPackMine.tMeshJointWeights
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

namespace DevPackMine
{
  public class tMeshJointWeights
  {
    public uint Count { get; set; }

    public byte[] JointName { get; set; }

    public tMeshWeightsMap[] WeightsMap { get; set; }
  }
}
