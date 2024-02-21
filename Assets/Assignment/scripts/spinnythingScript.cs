using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnythingScript : MonoBehaviour
{
    SpriteRenderer sr;

    public bool ready;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (Random.value > 0.5f)
        {
            ready = true;
            sr.color = Color.HSVToRGB(0.3f, 0.5f, 0.5f);
            sr.flipY = true;
        }
        else
        {
            ready = false;
            sr.color = Color.HSVToRGB(1f, 1f, 1f);
            sr.flipY = false;
        }
    }

    private void OnMouseDrag()
    {
        ready = true;
        sr.color = Color.HSVToRGB(0.3f, 0.5f, 0.5f);
        sr.flipY = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
