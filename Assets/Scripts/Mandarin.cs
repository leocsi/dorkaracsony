using UnityEngine;

public class Mandarin : MonoBehaviour
{
    private BoxCollider2D trigger;
    private bool dialogue;

    private void Awake()
    {
        dialogue = true;
        trigger = GetComponent<BoxCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && dialogue)
        {
            Debug.Log("Mandarin appears...");
            dialogue = false;
        }
    }
}
