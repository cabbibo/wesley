using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ComputeVille;

public class RepellerBuffer : FloatBuffer {

  // float3 pos
  // float repelVal
  public GameObject repellerPrefab;
  public GameObject[] repellers;

  public override void AfterBuffer(){
    repellers = new GameObject[count];
    for( int i = 0; i < count; i++ ){
      repellers[i] = Instantiate( repellerPrefab , Random.insideUnitSphere , Quaternion.identity);
    }
    SetPositions();
  }

  void SetPositions(){
    for( int i = 0; i < count; i++ ){
      values[i*3+0]=repellers[i].transform.position.x;
      values[i*3+1]=repellers[i].transform.position.y;
      values[i*3+2]=repellers[i].transform.position.z;
    }
    SetData();
  }
	
	// Update is called once per frame
	void Update () {
    SetPositions();
	}
}
