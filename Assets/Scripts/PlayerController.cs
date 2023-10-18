using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Vertical
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float xRange = 15;
    private float yMaxRange = 15;
    private float yMinRange = 0;

    public GameObject foodPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkUserIsInBounds();

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }

    void checkUserIsInBounds()
    {
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z <= yMinRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, yMinRange);
        }

        if (transform.position.z >= yMaxRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, yMaxRange);
        }
    }
}
