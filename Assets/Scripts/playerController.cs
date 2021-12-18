using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
 
    private Rigidbody2D body;
    private Animator anim;
    private bool isOnGround;
    [SerializeField] private float jump_speed;
    [SerializeField] private float movement_speed;
    Vector2 move;


    private void Awake()
    {
        // grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // FixedUpdate call in order ot get correct update on physics
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(horizontalInput,body.velocity.y);
        
        // ! something is wrong here ! when running and holding shift start running
        if (Input.GetKeyDown(KeyCode.A | KeyCode.D) && Input.GetKeyDown(KeyCode.LeftShift | KeyCode.RightShift))
        {
            body.velocity = new Vector2(horizontalInput * movement_speed,body.velocity.y);
        }
        
        // ANIMATION flip player sprite
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
            body.velocity = new Vector2(body.velocity.x,jump_speed);
            
        }
        

        // ANIMATION set animator parameters
        anim.SetBool("run", horizontalInput != 0);
    }

    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
    }

}