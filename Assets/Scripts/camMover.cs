using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMover : MonoBehaviour
{
    private float moveSpeed = 0.5f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0,moveSpeed * Time.deltaTime));
        // ! cam needs to push to y axis when player is moving faster but never 
        
    }
}
