using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ComputeVille{
public class Basic16VertBuffer : MeshVertBuffer {

  struct Vert{
    public Vector3 pos;
    public Vector3 nor;
    public Vector3 tan;
    public Vector3 col;
    public Vector2 uv;
  };


  public override void SetStructSize(){
    structSize = 3+3+3+3+2;
  }

  public override void SetOriginalValues(){

    Vector3 t1;
    Vector3 t2;
    int index = 0;

    Vector4[] tangents = mesh.tangents;
    Color[] colors = mesh.colors;
    for( int i = 0; i < count; i++ ){

      if( rotateMesh == true ){
        t1 = transform.TransformPoint( vertices[i] );
        t2 = transform.TransformDirection( normals[i] );
      }else{
        t1 = vertices[i];
        t2 = normals[i];
      }

      // positions
      values[ index++ ] = t1.x;
      values[ index++ ] = t1.y;
      values[ index++ ] = t1.z;

      // normals
      values[ index++ ] = t2.x;
      values[ index++ ] = t2.y;
      values[ index++ ] = t2.z;


      // normals
      values[ index++ ] = tangents[i].x;
      values[ index++ ] = tangents[i].y;
      values[ index++ ] = tangents[i].z;

            // normals
      values[ index++ ] = colors[i].r;
      values[ index++ ] = colors[i].g;
      values[ index++ ] = colors[i].b;

      // uvs
      values[ index++ ] = 0;//uvs[i].x;
      values[ index++ ] = 0;//uvs[i].y;


    }

  }

}
}
