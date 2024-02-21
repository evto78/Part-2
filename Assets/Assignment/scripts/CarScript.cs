using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{

    public Sprite closedHood;
    public Sprite openHood;

    SpriteRenderer sr;

    float pullInTimer = 2;

    void Start()
    {
        pullInTimer = 2;
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = closedHood;
        sr.color = Color.HSVToRGB(Random.value,0.4f,Random.Range(0.2f, 1f));
    }

    void Update()
    {
        if (pullInTimer > 0) 
        {
            pullInTimer -= Time.deltaTime;
            transform.Translate(0f,-0.32f * Time.deltaTime,0f);
        }
        
        if (pullInTimer <= 0) sr.sprite = openHood;
    }
}
