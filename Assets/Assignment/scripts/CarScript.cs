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

    public carButtonScript carButton1;
    public carButtonScript carButton2;
    public carButtonScript carButton3;
    public spinnythingScript spinny;
    public leverScript lever;

    float pullInTimer = 2;
    float pullOutTimer = 0;

    public bool everyThingReady = false;

    void Start()
    {
        pullInTimer = 2;
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = closedHood;
        sr.sortingOrder = 3;
        sr.color = Color.HSVToRGB(Random.value,0.4f,Random.Range(0.7f, 1f));
    }

    void Update()
    {
        if (pullInTimer > 0) 
        {
            pullInTimer -= Time.deltaTime;
            transform.Translate(0f,-0.32f * Time.deltaTime,0f);
        }

        if (pullInTimer <= 0) 
        {
            sr.sprite = openHood;
            sr.sortingOrder = -10;
        }

        if (carButton1.ready && carButton2.ready && carButton3.ready && spinny.ready && lever.ready)
        {
            everyThingReady = true;
            sr.sprite = closedHood;
            sr.sortingOrder = 3;
            pullOutTimer = 10f;
        }
    }
}
