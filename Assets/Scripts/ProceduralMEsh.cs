using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ProceduralMEsh : MonoBehaviour
{
    Vector3[] vertices;
    int[] triangles;
    Mesh mesh;
    // Start is called before the first frame update
     void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    // Update is called once per frame
    private void Start()
    {
        MakeMesh();
        UpdateMeshData();
    }
     void MakeMesh()
    {
        vertices = new Vector3[] { new Vector3(0, 1, 0), new Vector3(0, 1, 1), new Vector3(1, 1, 0),new Vector3(1,1,1),new Vector3(0,0,0),new Vector3(0,0,1),new Vector3(1,0,0)};
        triangles = new int[] { 0, 1, 2 ,2,1,3,3,1,2,2,1,0,4,5,6,0,4,6};
    }
    void UpdateMeshData()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
    }
}
