using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject AxisToSpawn;
    public GameObject SphereToSpawn;
    public GameObject CubeToSpawn;
    public GameObject PlaneToSpawn;
    public GameObject LineToSpawn;
    public GameObject CylinderToSpawn;
    public GameObject sample;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void SpawnAxis()
     {
         Instantiate(AxisToSpawn, Vector3.zero, Quaternion.Euler(0, 0, 0));
     }

     public void SpawnSphere()
     {
         Instantiate(SphereToSpawn, Vector3.zero, Quaternion.Euler(0, 0, 0));
     }

     public void SpawnCube()
     {
         Instantiate(CubeToSpawn, Vector3.zero, Quaternion.Euler(0, 0, 0));
     }

     public void SpawnPlane()
     {
         Instantiate(PlaneToSpawn, Vector3.zero, Quaternion.Euler(0, 0, 0));
     }

     public void SpawnLine()
     {
         Instantiate(LineToSpawn, Vector3.zero, Quaternion.Euler(0, 0, 0));
     }
     public void SpawnCylinder()
     {
         Instantiate(CylinderToSpawn, Vector3.zero, Quaternion.Euler(0, 0, 0));
     }
    public void Rot()
    {
        int count = 0;
        if (count % 2 == 0)
        {
            sample.SetActive(true);
            count++;
        }
        else
            sample.SetActive(false);
    }
}
