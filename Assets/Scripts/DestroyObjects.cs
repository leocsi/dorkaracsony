using UnityEngine;

public class DestroyObjects : MonoBehaviour
{

    public GameObject destroy;
    
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        Destroy(destroy);
        // Destroy();
    }
}
