using UnityEngine;
using System.Linq;
using System;

public class PlayerMovement : MonoBehaviour
{
    private String[] deaths;
    private bool jumpState;
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;

    private void Awake()
    { 
        deaths = new[] {"rock","BSS","BS"};
        jumpState = false;
        speed = 3;
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        //Code for left and right movement
        body.velocity = new Vector2(horizontalInput*speed,body.velocity.y);
        
        //Code for jumping
        if(Input.GetKey(KeyCode.Space) && !jumpState){
            body.velocity = new Vector2(body.velocity.x,speed*1.7f);
            jumpState = true;
        } 

        //Code for flipping the character
        
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(-5,5,5);
        else if (horizontalInput < -0.01f)
            transform.localScale = 5*Vector3.one;

        anim.SetBool("walk",horizontalInput!=0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (deaths.Contains(collision.gameObject.name)){
            Debug.Log("YOU DIED");
        }
        if (collision.gameObject.tag == "Ground")
        {
            jumpState = false;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {       
            if (collision.gameObject.name == "2"){
                jumpState = false;
            }
    }
}