using System;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public List<GameObject> targets;
    private int counter = -1;
    private bool won = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(counter == 0 && !won){
            won = true;
            Debug.Log("YOU WON!");
        }
    }

    private void OnTriggerEnter(Collider collision){
        if (collision.gameObject.tag == "Ball"){
            targets.Add(collision.gameObject);
            counter = targets.Count;
        }
    }

    private void OnTriggerExit(Collider collision){
        if (collision.gameObject.tag == "Ball"){
            targets.Remove(collision.gameObject);
            counter = targets.Count;
        }
    }
}
