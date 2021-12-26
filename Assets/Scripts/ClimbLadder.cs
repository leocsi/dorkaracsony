using UnityEngine;

public class ClimbLadder : MonoBehaviour
{
    Rigidbody2D body;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player"){
            collision.gameObject.transform.position = new Vector3(-3.49f,16.3f,0);
        }
    }
}
