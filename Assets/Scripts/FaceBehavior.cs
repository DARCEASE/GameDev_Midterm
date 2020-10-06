﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PURPOSE: Using raycasts, have the mouse of the player direct the way the face is oriented
//USAGE: Place this script of the face in the center of the scene 
public class FaceBehavior : MonoBehaviour
{
    public GameObject faceLeft;
    public GameObject faceRight;
    public GameObject faceUp;
    public GameObject faceDown;

    // Update is called once per frame
    void Update()
    {
        //raycast will from the face to anywhere the mouse is on screen
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //mouse curspor poition in world 
        Vector2 faceToMouseCursor = mousePos - transform.position; //finds the distance between the face and the position of the mouse 
       
        Debug.DrawRay(transform.position, faceToMouseCursor, Color.cyan);

        //raycast from face to mouse cursor and instantiate the new appropritae face 
        Ray2D faceRay = new Ray2D(transform.position, faceToMouseCursor);
        float myMaxRayDist = 10f;
        RaycastHit2D faceRayHit = Physics2D.Raycast(faceRay.origin, faceRay.direction, myMaxRayDist);

        //did we hit something? 

        if (faceRayHit.collider != null)// if we actually hit it 
        { 
           //instantiate new face prefab at the position of the face
           
        }
    }
}