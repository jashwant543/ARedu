using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOve : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 5f;
    void Start()
    {
        transform.position = pointA.position;
        // StartCoroutine(move());
        Debug.Log(pointA);
    }


    //IEnumerator move()
    //{
    //    while (transform.position != pointB.position)
    //    {
    //        Vector3.Lerp(transform.position, pointB.position, speed);
    //        yield return new WaitForEndOfFrame();
    //    }
    //}



    // Update is called once per frame
    void Update()
    {
        //while (this.transform.position != pointB.position)
        //{
          this.transform.position=  Vector3.Lerp(transform.position, pointB.position, speed);
            
        //}
    }
}
