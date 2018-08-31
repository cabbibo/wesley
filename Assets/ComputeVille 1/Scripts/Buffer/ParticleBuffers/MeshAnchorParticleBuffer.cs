﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ComputeVille{
public class MeshAnchorParticleBuffer : ParticleBuffer {

  public MeshVertBuffer mesh;

  struct Particle{
    public Vector3 pos;
    public Vector3 vel;
    public float id;    // particle id
    public float life;  // lifetime of particle
    public float cap;   // connection information
    public Vector3 debug; //
  }

  public override void SetCount(){
    print("whats up");
    count = mesh.count;
  }

}
}
