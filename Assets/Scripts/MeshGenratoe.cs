using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class MeshGenratoe : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;

    int[] triangles;
   
    // Start is called before the first frame update
    void Start()
    {
        mesh= new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateShapes();
        UpdateMesh();
    }
    void CreateShapes()
    {
        vertices = new Vector3[]
            {
                //new Vector3(0,0,0),
            new Vector3(2,3,-1),
        new Vector3(1,1,2),
        new Vector3(7,-6,-1)
       
            
            
            };
        triangles = new int[]
           {
                0,1,2,
                1,3,2
            };


    }
    private void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }


}
