﻿using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class drag : MonoBehaviour

{
    //public GameObject obj;
    //public GameObject Part1;
    public GameObject jasii;


    private Vector3 mOffset;



    private float mZCoord;



    void OnMouseDown()

    {

        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;



        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen

        mousePoint.z = mZCoord;



        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(collision.collider.gameObject);
    //    Destroy(gameObject);
    //    Part1.SetActive(true);
    //}


    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint() + mOffset;

    }
    public void Checksss()
    {
        jasii.SetActive(true);
    }

}