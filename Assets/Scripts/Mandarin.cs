using UnityEngine;

public class Mandarin : MonoBehaviour
{
    private bool dialogue;

    private void Awake()
    {
        dialogue = true;
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
