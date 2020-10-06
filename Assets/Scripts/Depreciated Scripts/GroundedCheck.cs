using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if we are on the ground, then do nothing

        // 1. declare a Ray variable
        Ray2D myRay = new Ray2D(transform.position, Vector2.down);

        // 2. define the maximum Raycast distance
        float maxRayDist = 0.6f;

        // 3. visualize the raycast in the Scene view (ONLY YOU CAN SEE THIS)
        Debug.DrawRay(myRay.origin, myRay.direction * maxRayDist, Color.green);

        // 4. actually fire the raycast now!
        RaycastHit2D myRayHit = Physics2D.Raycast(myRay.origin, myRay.direction, maxRayDist);

        // 5. see if the raycast actually hit something?
        if (myRayHit.collider != null)
        {
            // do nothing
            Debug.Log("Raycast is hitting " + myRayHit.collider.name);
        }
        else
        {
            // ... but if we're in the air, then spin
            transform.Rotate(0, 0, 30f * Time.deltaTime); // spin 30 degrees per second
        }

    }
}
