using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimInput : MonoBehaviour
{   //purpose: to randomly activate the phone vibration
    //usage: place this script on the phone
    Animator myAnim;
    public float animTimer;
    public int vibrate;
    
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animTimer += Time.deltaTime;
        //if the timer is greater or equal to the vibrate int, execute this code 
        if (animTimer >= vibrate)
        {
            myAnim.SetBool("isVibing", true);
            vibrate = Random.Range(10, 20);

        }
        if (animTimer >= vibrate + 1) // after a couple of frames, turn off the animation vibration
             {
                 animTimer = 0;
                 myAnim.SetBool("isVibing", false);
             }       
        
        
        
    }
}
