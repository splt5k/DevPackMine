// Decompiled with JetBrains decompiler
// Type: DevPackMine.tMeshContainer
// Assembly: DevPackMine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6B9BC8BF-B510-4945-A515-04135CC0F4A4
// Assembly location: C:\Users\NTServer\Desktop\DevPackMine\DevPackMine\DevPackMine.exe

namespace DevPackMine
{
  public class tMeshContainer
  {
        internal static LCMeshReader pMesh;

        public byte[] FileName { get; set; }

    public string FilePath { get; set; }

    public tHeaderInfo HeaderInfo { get; set; }

    public tMeshMorphMap[] MorphMap { get; set; }

    public tVertex3f[] Normals { get; set; }

    public tMeshObject[] Objects { get; set; }

    public pwTextures[] PWTextureList { get; set; }

    public float Scale { get; set; }

    public tMeshUVMap[] UVMaps { get; set; }

    public uint Value1 { get; set; }

    public tVertex3f[] Vertices { get; set; }

    public tMeshJointWeights[] Weights { get; set; }
  }
}
