using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//purpose: home to all of the functions that call for a closer look into the objects on the desk
//usage: place this on the button that 
public class InteractableItems : MonoBehaviour
{
    public GameObject handSanitizer;
    public GameObject leftNoteB;
    public GameObject rightNoteB;
    public GameObject plant;
    public GameObject spikePoster;

    public RegretOne rOne;
    public GameObject rOneScr;
    
    // Start is called before the first frame update
    void Start()
    {
        rOne = rOneScr.GetComponent<RegretOne>();
        handSanitizer.SetActive(false);
        leftNoteB.SetActive(false);
        rightNoteB.SetActive(false);
        plant.SetActive(false);
        spikePoster.SetActive(false);
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
        leftNoteB.SetActive(true);
        rOne.hasClicked += 1;
    }
    public void ClickRightNotebook()
    {
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
}
