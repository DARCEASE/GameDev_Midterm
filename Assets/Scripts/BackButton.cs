using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public GameObject sanitizerPanel;
    public GameObject leftNotePanel;
    public GameObject rightNotePanel;
    public GameObject plantPanel;
    public GameObject spikePosterPanel;
    public GameObject cellPhonePanel;

    public AudioSource pressedStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBack()
    {
       
            SceneManager.LoadScene("RegretOne"); // updated for arcade but usually will lead to game scene 
        
        
    }
    public void GoRegOne() // go back to scene one 
    {
        sanitizerPanel.SetActive(false);
        leftNotePanel.SetActive(false);
        rightNotePanel.SetActive(false);
        plantPanel.SetActive(false);
        spikePosterPanel.SetActive(false);
        cellPhonePanel.SetActive(false);
    }
}
