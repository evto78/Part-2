using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    bool positiveFrame;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (positiveFrame)
        {
            transform.Translate(Time.deltaTime, Time.deltaTime, Time.deltaTime);
            positiveFrame = false;
        }
        else
        {
            transform.Translate(-Time.deltaTime, -Time.deltaTime, -Time.deltaTime);
            positiveFrame = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "water")
        {
            gameObject.SetActive(false);
        }
    }
}
