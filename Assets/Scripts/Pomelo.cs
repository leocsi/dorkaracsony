using UnityEngine;

public class Pomelo : MonoBehaviour
{
    private Rigidbody2D pomelo;
    public int speed;
    private Animator anim;
    private bool turn;
    private bool dialogue;

    // Start is called before the first frame update
    private void Awake()
    {
        anim = GetComponent<Animator>();
        pomelo = GetComponent<Rigidbody2D>();
        speed = 3;
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
            Debug.Log("Pomelo Appears...");
            dialogue = false;
            speed = 0;
            anim.SetBool("collision",false);
            pomelo.isKinematic = true;
        }    
    }

    // Update is called once per frame
    void Update()
    {
        pomelo.velocity = new Vector2(speed, 0);
    }
}
