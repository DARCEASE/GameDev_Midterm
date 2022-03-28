using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

//purpose: game manager to RegretOne 
//usage: place this on an empty game object and drag it into the scene 

public class RegretOne : MonoBehaviour
{
    public Sprite[] compScreen; //list of images on the screen of the computer 
    public GameObject compScreenSpr;
    public int screenID; // which image in the array are you

    public Sprite[] timeOD;// time of day
    public GameObject timeChngSpr;//obj that will have the spr change for timeOD
    public int timeID;// which time of day image are you

   // how many times youve clicked something 
    public int hasClicked;
    public GameObject phone;

    public AudioSource phoneBoop;
    public GameObject goHomeButt;


    void Start()
    {
        goHomeButt.SetActive(false);
        phone.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //for arcade build - will restart the game 

        //raycast will from the face to anywhere the mouse is on screen
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //mouse curspor poition in world 
        Vector2 screenToMouseCursor = mousePos - transform.position; 

        Debug.DrawRay(transform.position, screenToMouseCursor, Color.cyan);

        
        Ray2D Ray = new Ray2D(transform.position, screenToMouseCursor);
        float myMaxRayDist = 10f;
        RaycastHit2D RayHit = Physics2D.Raycast(Ray.origin, Ray.direction, myMaxRayDist);

        //did we hit something? 

        if (RayHit.collider != null)// if we actually hit it 
        {
            //instantiate new face prefab at the position of the face
            if (RayHit.transform.name == "phoneVibe" && Input.GetMouseButtonDown(0) || Input.GetButtonDown("Submit"))
            {
                
                phone.SetActive(true);
                if (phoneBoop.isPlaying == false)
                { 
                    phoneBoop.Play();
                }
            }
        }
         //based on how many things you clicked the time of day should change into the next phase on the window
         timeChngSpr.GetComponent<SpriteRenderer>().sprite = timeOD[timeID];
         compScreenSpr.GetComponent<SpriteRenderer>().sprite = compScreen[screenID];  

        // if youve clicked a certain number of things, then change the time of day
        if (hasClicked == 2)
        {
            timeID = 1; //afternoon
        }
        if (hasClicked == 5)
        {
            timeID = 2;//night
        }
        if (timeID != 2)  
        {
            //if the timeID is anything but element 2, keep going.
        }
        else if (timeID == 2) // but if it is element 2 then stop the array 
        {
            screenID = 3;
            goHomeButt.SetActive(true);

            //if youre on the go home screen instantiate a go home button that will take you back to the start screen
        }

        
        

      



    }
}
