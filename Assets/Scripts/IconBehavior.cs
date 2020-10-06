using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// PURPOSE: Controls behavior or icons as they spin and float around the scene, bouncing off walls they might collide with 
//USAGE: Put this script on a floating icon facing +x axis (red axis)
public class IconBehavior : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //move forward along x axis 
        transform.Translate(2f * Time.deltaTime, 0f, 0f); //move 2m/s

        //create raycast and randomply turn left or right if theres a wall 
        Ray2D myRay = new Ray2D(transform.position, transform.right);
        float myMaxRayDist = 1.1f;
        Debug.DrawRay(myRay.origin, myRay.direction * myMaxRayDist, Color.green);

        //lets fire that bad boi up 
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, myMaxRayDist);

        //did we hit something?!?
        if (myRayHit.collider != null)// if it hit something  then randomly turn left or right
        {
            float randNum = Random.Range(0, 100);
            if (randNum < 50) //if less that 50 turn left 
            {
                transform.Rotate(0f, 0f, 90f);
            }
            else //50% chance turn right
            {
                transform.Rotate(0f, 0f, -90f);
            }
        }
        else 
        {
            // ... but if we're in the air, then spin
            transform.Rotate(0, 0, 30f * Time.deltaTime); // spin 30 degrees per second
        }
    }
}
