using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerSportScript : MonoBehaviour
{
    SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
        Selected(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SportController.SetCurrentSelection(this);
    }

    public void Selected(bool isSelected)
    {
        if (isSelected)
        {
            sr.color = Color.green;
        }
        else
        {
            sr.color = Color.red;
        }
    }
}
