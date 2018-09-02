using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ComputeVille{
public class LinkBufferToPhysics : MonoBehaviour {

  public string name;
  public string countName;
  public Physics physics;
  public Buffer buffer;

	// Use this for initialization
	void OnEnable() {
    physics.OnBeforeDispatch += SetBuffer;
	}

  void OnDisable(){
    physics.OnBeforeDispatch -= SetBuffer;
  }
	
  void SetBuffer( ComputeShader shader , int kernel ){
    shader.SetBuffer( kernel , name , buffer._buffer );
    shader.SetInt(countName,buffer.count);
  }

}
}
