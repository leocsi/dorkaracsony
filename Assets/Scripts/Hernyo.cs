using UnityEngine;

public class Hernyo : MonoBehaviour
{
    private Rigidbody2D hernyo;
    public float speed;
    private Animator anim;
    private bool turn;
    private bool dialogue;

    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
        hernyo = GetComponent<Rigidbody2D>();
        speed = 0.8f;
        turn = true;
        dialogue = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {       
            turn = !turn;
            anim.SetBool("right", turn);
            speed = -speed;
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player"&&dialogue)
        {
            Debug.Log("Collided");
            Debug.Log("Hernyo Appears...");
            dialogue = false;
            speed = 0;
            anim.SetBool("collision",false);
            hernyo.isKinematic = true;
        }    
        if (collision.gameObject.name =="rock"){
            Debug.Log("Game Over");
        }
    }

    // Update is called once per frame
    void Update()
    {
        hernyo.velocity = new Vector2(speed, 0);
    }
}
