using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeapotScript : MonoBehaviour
{
    SpriteRenderer sr;

    public bool ready;

    public GameObject water;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.Rotate(0, 0, 1);
        transform.Translate(0, 0, 10);
        water.SetActive(true);
    }

    private void OnMouseUp()
    {
        water.SetActive(false);
    }
}
