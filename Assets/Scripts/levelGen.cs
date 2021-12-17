using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGen : MonoBehaviour
{
    List<GameObject> blockList = new List<GameObject>();
    // saves coordinates of free space
    List<int> freeSpaces = new List<int>();
    public GameObject wall;
    public GameObject block1;
    public GameObject block2;
    public GameObject block3;
    public GameObject block4;
    public int startPoint = 0;
    public int endPoint = 30;
    public int blockHeight = 30;
    public Camera camPosition;

    
    // Start is called before the first frame update
    void Start()
    {
        // initialzie first block
        SpawnLevelBlock();   
    }

    void Update()
    {
        
        // get camera y-position
        float camPosition = Camera.main.transform.position.y;

        // build new block when reached the middle of current block
        if (camPosition >= startPoint - 15) // mb divide by 2
        {
            SpawnLevelBlock();
        }
        
    }

    void SpawnLevelBlock()
    {          
        int level_width = 20;
        int blockIndex = Random.Range(0,4);
              
        // add block GameObjects into list
        blockList.Add(block1);
        blockList.Add(block2);
        blockList.Add(block3);
        blockList.Add(block4);
        
        // main logic
        for (int y = startPoint; y < endPoint; y++)
        {     
            for (int x = 0; x < level_width; x++)
            {           
                // random seed
                int block_or_not = Random.Range(0,101);             

                // build a wall
                int wall_left = x-1;
                int wall_right = x+level_width;
                
                if(x == 0)
                {
                    Instantiate(wall,new Vector2(wall_left,y),Quaternion.identity);
                    Instantiate(wall,new Vector2(wall_right,y),Quaternion.identity);
                }
                // if no block then save coordinates
                if(block_or_not < 60)
                {
                    freeSpaces.Add(x * 32);
                    freeSpaces.Add(y * 32);
                    Debug.Log(freeSpaces[y]);
                    Debug.Log(freeSpaces[y+1]);
                }
                // build random level structure
                if(block_or_not >= 60 && block_or_not < 80)
                {
                    Instantiate(blockList[0],new Vector2(x,y),Quaternion.identity );
                }
                else if(block_or_not >= 80 && block_or_not < 90)
                {
                    Instantiate(blockList[1],new Vector2(x,y),Quaternion.identity );
                }
                else if(block_or_not >= 90 && block_or_not < 95)
                {
                    Instantiate(blockList[2],new Vector2(x,y),Quaternion.identity );
                }
                else if(block_or_not >= 95 && block_or_not < 100)
                {
                    Instantiate(blockList[3],new Vector2(x,y),Quaternion.identity );
                }


            }           
        }    
        // recalculate start and endpoint
        startPoint += blockHeight;       
        endPoint += blockHeight;
    }
}
