using UnityEngine;

public class RockRoll : MonoBehaviour
{
    public GameObject rock;
    private Rigidbody2D body;
    private Vector2 speed;
    // Start is called before the first frame update
    void Awake()
    {
        speed = Vector2.zero;
        body = rock.GetComponent(typeof (Rigidbody2D)) as Rigidbody2D;
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        speed = new Vector2(-2,0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "hernyo")
        {
            Destroy(rock);
        }
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = speed;
        if (body.transform.position.y < 8f ){
            Destroy(rock);
        }
    }
}
