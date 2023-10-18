using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager manager;
    private void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            manager.UpdateLives(-1);
            Destroy(gameObject);
        }
        else
        {
            manager.AddScore(5);
            Destroy(gameObject);
            Destroy(other.gameObject); 
        }
         
    }
}
