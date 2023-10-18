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
        else if (other.CompareTag("Animal") && gameObject.CompareTag("Food"))
        {
            other.GetComponent<Hunger>().FeedAnimal(1);
            Destroy(gameObject); 
            
        }
         
    }
}
