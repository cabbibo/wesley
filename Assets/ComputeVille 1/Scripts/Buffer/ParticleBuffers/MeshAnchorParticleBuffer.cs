﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ComputeVille{
public class MeshAnchorParticleBuffer : ParticleBuffer {

  public MeshVertBuffer mesh;

  struct Particle{
    public Vector3 pos;
    public Vector3 vel;
    public Vector3 nor;
    public Vector3 tan;
    public Vector3 col;
    public Vector2 uv;
    public float debug;
  }

  public override void SetStructSize(){
    structSize = 18;
  }
  public override void SetCount(){
    mesh = GetComponent<MeshVertBuffer>();
    count = mesh.count;//mesh.count;
  }

}
}
