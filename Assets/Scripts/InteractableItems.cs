using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItems : MonoBehaviour
{
    public GameObject handSanitizer;
    //public GameObject leftNoteB;
    public RegretOne rOne;
    public GameObject rOneScr;
    
    // Start is called before the first frame update
    void Start()
    {
        rOne = rOneScr.GetComponent<RegretOne>();
        handSanitizer.SetActive(false);
        //leftNoteB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickSanitizer()
    {
        handSanitizer.SetActive(true);
        rOne.hasClicked += 1;
       
    }
    public void ClickLeftNotebook()
    {
        //leftNoteB.SetActive(true);
    }
    
}
