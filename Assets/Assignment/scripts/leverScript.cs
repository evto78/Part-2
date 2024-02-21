using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverScript : MonoBehaviour
{
    SpriteRenderer sr;

    public bool ready;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (Random.value > 0.5f)
        {
            ready = true;
            sr.flipX = false;
        }
        else
        {
            ready = false;
            sr.flipX = true;
            transform.Translate(-0.5f,0f,0f);
        }
    }

    private void OnMouseDown()
    {
        if (!ready)
        {
            sr.flipX = false;
            transform.Translate(0.5f, 0f, 0f);
        }
        ready = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
