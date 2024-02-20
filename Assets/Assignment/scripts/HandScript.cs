using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    Animator animator;
    float damagedTimer = 0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Selecting", false);
    }

    void Update()
    {
        if (damagedTimer > 0f)
        {
            damagedTimer -= Time.deltaTime;
        }
        else
        {
            animator.SetBool("Damaged", false);
        }
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.Translate(0, 0, 10);
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("Holding", true);
        }
        else
        {
            animator.SetBool("Holding", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision detected");
        if (collision.tag == "interactable")
        {
            animator.SetBool("Selecting", true);
        }
        else if (collision.tag == "dangerous")
        {
            animator.SetBool("Damaged", true);
            damagedTimer = 3f;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "dangerous")
        {
            animator.SetBool("Damaged", true);
            damagedTimer = 3f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Selecting", false);
    }
}
