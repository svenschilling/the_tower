using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confinerTransform : MonoBehaviour
{
    
    levelGen lvlGen = new levelGen();
    private GameObject playerObj;
    public Camera camPosition;
    void Start() 
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        float camPosition = Camera.main.transform.position.y;
        
        int startPoint = lvlGen.startPoint;
        
        
        // transform y to player y position
        // transform.position.y = camPosition
        playerObj = GameObject.FindGameObjectWithTag("Player");
        
        float confinerPos = transform.position.y;

        confinerPos = playerObj.transform.position.y;

    }
}
