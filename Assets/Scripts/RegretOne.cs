using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//purpose: game manager to RegretOne 
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
        if (dayTimer > 2)
        {
            //
            dayTimer = 0;
            if (timeID == 2)
            {
                timeID = 0;
            }
            else
            { 
                timeID += 1;
            }
        }
        //when i right click, the image on the computer should change 

        // on a timer, the phone on the desk should randomly vibrate 

        
    }
}
