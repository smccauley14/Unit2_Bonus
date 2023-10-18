using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float leftBound = -20;
    private float rightBound = 20;
    private GameManager manager;

    private void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (isObjectOutOfBounds())
        {
            manager.UpdateLives(-1);
            Destroy(gameObject);
        }
    }

    bool isObjectOutOfBounds()
    {
        return transform.position.z < lowerBound || transform.position.x > rightBound || transform.position.x < leftBound;
    }
}
