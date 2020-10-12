using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//purpose: game manager to RegretOne 
//usage: place this on an empty game object and drag it into the scene 
public class RegretOne : MonoBehaviour
{
    public Sprite[] compScreen; //list of images on the screen of the computer 
    public GameObject compScreenSpr;
    public int screenID;

    public Sprite[] timeOD;// time of day
    public GameObject timeChngSpr;//obj that will have the spr change for timeOD
    public int timeID;
    public float dayTimer;


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //on a timer the time of day should change into the next phase on the window
        dayTimer += Time.deltaTime;
        timeChngSpr.GetComponent<SpriteRenderer>().sprite = timeOD[timeID];
        if (dayTimer > 10)
        {
            //
            dayTimer = 0;
            if (timeID != 2) //if the timeID is anything but element 2, keep going. 
            {
                timeID += 1;
            }
            else if (timeID == 2) // but if it is element then stop the array 
            { 
               
            }
        }
        //when i right click, the image on the computer should change 
        compScreenSpr.GetComponent<SpriteRenderer>().sprite = compScreen[screenID]; 
        if (Input.GetMouseButtonDown(0))
        {
            screenID = Random.Range(0, 3); // last numb of array 
            
        }
        // on a timer, the phone on the desk should randomly vibrate 


        
    }
}
