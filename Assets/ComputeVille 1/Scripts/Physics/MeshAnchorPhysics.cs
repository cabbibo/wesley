using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ComputeVille{
[RequireComponent(typeof(VerletVertBuffer))]
public class MeshAnchorPhysics : Physics {

  public MeshVertBuffer anchorBuffer;

  public override void GetBuffer(){ 
    buffer = GetComponent<MeshAnchorParticleBuffer>(); 
    anchorBuffer = GetComponent<MeshVertBuffer>();
  }

  public override void Dispatch(){
    shader.SetFloat("_Time", Time.time);
    shader.SetFloat("_Delta", Time.deltaTime);
    shader.SetInt("_Count", buffer.count );
    shader.SetBuffer(kernel, "vertBuffer" , buffer._buffer );
    shader.SetBuffer(kernel, "anchorBuffer" , anchorBuffer._buffer );
    SetShaderValues();
    shader.Dispatch(kernel,numGroups,1,1);
  }



}
}