using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//purpose: game manager to RegretOne 
//usage: place this on an empty game object and drag it into the scene 
public class RegretOne : MonoBehaviour
{
    public Sprite[] compScreen; //list of images on the screen of the computer 
    public GameObject compScreenSpr;
    public int screenID; // which image in the array are you

    public Sprite[] timeOD;// time of day
    public GameObject timeChngSpr;//obj that will have the spr change for timeOD
    public int timeID;// whihc time of day image are you
   
    public int hasClicked;// how many times youve clicked something 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //based on how many things you clicked the time of day should change into the next phase on the window
        
        timeChngSpr.GetComponent<SpriteRenderer>().sprite = timeOD[timeID];
        compScreenSpr.GetComponent<SpriteRenderer>().sprite = compScreen[screenID];  

        if (hasClicked == 1)// if youve clicked this many things, then change the time of day

        {
            timeID = 1; 
        }
        if (timeID != 2) //if the timeID is anything but element 2, keep going. 
        {

        }
        else if (timeID == 2) // but if it is element then stop the array 
        {
            screenID = 3;
        }

        //when I left click, the image on the computer should change 
        if (Input.GetMouseButtonDown(0))
        {
            screenID = Random.Range(0,2); // last numb of array   
        }
        

        // on a timer, the phone on the desk should randomly vibrate 



    }
}
