using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
//purpose: home to all of the functions that call for a closer look into the objects on the desk
//usage: place this on the button that 
public class InteractableItems : MonoBehaviour
{
    public GameObject handSanitizer;
    public GameObject leftNoteB;
    public GameObject rightNoteB;
    public GameObject plant;
    public GameObject spikePoster;
    public GameObject lampLight;
    public bool lampOn;

    public RegretOne rOne;
    public GameObject rOneScr;

    public AudioSource clickSound;
    public AudioSource flipSound;
    public AudioSource lightSwitchSound;
   
    
    // Start is called before the first frame update
    void Start()
    {
        rOne = rOneScr.GetComponent<RegretOne>();
        handSanitizer.SetActive(false);
        leftNoteB.SetActive(false);
        rightNoteB.SetActive(false);
        plant.SetActive(false);
        spikePoster.SetActive(false);
        lampLight.SetActive(false);
        lampOn = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickSanitizer()
    {
        handSanitizer.SetActive(true);
        rOne.hasClicked += 1;
        Debug.Log("you have clicked a thing!");
       
    }
    public void ClickLeftNotebook()
    {
        flipSound.Play();
        leftNoteB.SetActive(true);
        rOne.hasClicked += 1;
    }
    public void ClickRightNotebook()
    {
        flipSound.Play();
        rightNoteB.SetActive(true);
        rOne.hasClicked += 1;
    }
    public void ClickPlant()
    {
        plant.SetActive(true);
        rOne.hasClicked += 1;
    }
    public void ClickSpikePoster()
    {
        spikePoster.SetActive(true);
        rOne.hasClicked += 1;
    }

    //when i click on the mouse button, sift through all the screen images
    public void ClickMouse()
    {
        clickSound.Play();
        rOne.screenID = Random.Range(0, 2);
        if (rOne.timeID == 2)
        {
            rOne.screenID = 3;
        }
    }
    public void GoHome() // when you click the gohome button restart the game
    {
        SceneManager.LoadScene("StartScreen");
    }
        public void TurnLampOn()
    {
        lightSwitchSound.Play();
        if (lampOn == false)
        {
            lampOn = true;
            lampLight.SetActive(true);
            
        }
        else if (lampOn == true)
        {
            lampOn = false;
            lampLight.SetActive(false);        
        }
       
        
    }

    //if the phone is vibrating look at it and see a text 
    public void AnswerText()
    {
        
    }


}
