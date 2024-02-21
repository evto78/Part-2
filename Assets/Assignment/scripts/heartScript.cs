using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartScript : MonoBehaviour
{
    SpriteRenderer sr;

    public bool ready;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (Random.value > 0.5f)
        {
            ready = false;
            sr.color = Color.HSVToRGB(0.3f, 0.5f, 0.5f);
        }
        else
        {
            ready = true;
            sr.color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.Translate(0, 0, 10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "cleaner")
        {
            sr.color = Color.white;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (sr.color == Color.white && collision.tag == "goal")
        {
            ready = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "goal")
        {
            ready = false;
        }
    }
}
