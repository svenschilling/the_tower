using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isFreeSpace : MonoBehaviour
{
    /*
        Checks if there is free space to place an object
    */

    
    // Start is called before the first frame update
    void Start()
    {
        // instanciate obj of levelGen to access their vars
        levelGen lvlgen = new levelGen();
        int endpoint = lvlgen.endPoint;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int freeSpace(int vec)
    {
        // catch x,y position and check if there is a block
        // if !block then decide place on 1-3 % a powerup
        return vec;
    }
}
