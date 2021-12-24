using UnityEngine;
using System;

public class Checkpoints : MonoBehaviour
{
    public GameObject player;
    private BoxCollider2D trigger;
    private int current;
    private Vector3 currentPos;

    void Awake()
    {
        trigger = GetComponent<BoxCollider2D>();
        current = 0;
        currentPos = new Vector3(0,0.6f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F))
        {
            GoToCheckPoint();
        }
    }

    void GoToCheckPoint() 
    {
        player.transform.position = currentPos;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        int triggeredName;
        try 
        {
            triggeredName = Int32.Parse(trigger.gameObject.name);
        }
        catch (Exception e)
        {
            triggeredName = current;
            Debug.Log(trigger.gameObject.name);
        }
        if (triggeredName != current){
            current++;
            currentPos = collision.gameObject.transform.position;
            Debug.Log("Checkpoint " + current + "reached");
        } 
        else 
        {
            Debug.Log("Checkpoint " + current + "Passed");
        }
    }
}
