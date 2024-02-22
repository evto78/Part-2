using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperController : MonoBehaviour
{
    public Rigidbody2D goalkeeperRb;
    Vector2 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = ((Vector2)SportController.CurrentSelection.transform.position - (Vector2)transform.position) / 2;
        goalkeeperRb.position = (Vector2)transform.position + direction;
    }
}
