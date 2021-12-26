using UnityEngine;

public class Levitateplayer : MonoBehaviour
{
    bool lev;
    public GameObject player;

    void Awake()
    {
        lev = false;
    }
    void OnTriggerEnter2D(Collider2D collision){
        lev = !lev;
        while (lev)
        {
            player.transform.position += (Vector3.up*0.001f)*Time.deltaTime;
        }
        
    }
}
