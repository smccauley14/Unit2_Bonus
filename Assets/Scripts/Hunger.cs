using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hunger : MonoBehaviour
{
    public Slider slider;
    public int amountToBeFed;
    private int currentFedAmount = 0;
    private GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = amountToBeFed;
        slider.value = 0;
        slider.fillRect.gameObject.SetActive(false);
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        slider.fillRect.gameObject.SetActive(true);
        slider.value = currentFedAmount;
        if (currentFedAmount >= amountToBeFed)
        {
            manager.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
