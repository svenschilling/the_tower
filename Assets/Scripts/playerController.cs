using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
 
    private Rigidbody2D body;
    private Animator anim;
    private bool isOnGround;
    [SerializeField] private float speed;


    private void Awake()
    {
        // grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(horizontalInput,body.velocity.y);
        // body.velocity = new Vector2(body.velocity.x,Input.GetAxis("Vertical"));
        
        // flip player sprite
        if(horizontalInput > 0.01f)
        {
            transform.localScale = Vector2.one;
        }
        else if(horizontalInput < 0.01f)
        {
            transform.localScale = new Vector2(-1,1);
        }
        
        if(Input.GetKey(KeyCode.Space))
        {
            body.velocity = new Vector2(body.velocity.x,speed);
            
        }
        

        // set animator parameters
        anim.SetBool("run", horizontalInput != 0);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
  
    }

}