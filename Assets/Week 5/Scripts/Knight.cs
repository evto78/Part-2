using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;

    Vector2 destination;
    Vector2 movement;

    public float speed = 3f;
    public float maxHealth = 10f;
    public float health = 10f;

    bool clickedOnSelf = false;
    bool isDead = false;

    void Start()
    {
        health = maxHealth;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (isDead) return;
        movement = destination - (Vector2)transform.position;
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);
    }

    void Update()
    {
        if (isDead) return;
        if (Input.GetMouseButtonDown(0) && !clickedOnSelf)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonDown(1) && !clickedOnSelf)
        {
            animator.SetTrigger("Attack");
        }
        animator.SetFloat("Movement", movement.magnitude);
    }

    private void OnMouseDown()
    {
        if (isDead) return;
        clickedOnSelf = true;
        SendMessage("TakeDamage", 1f);
    }

    private void OnMouseUp()
    {
        clickedOnSelf = false;
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        health = Mathf.Clamp(health, 0, maxHealth);
        if (health <= 0)
        {
            animator.SetTrigger("Death");
            isDead = true;
        }
        else 
        {
            animator.SetTrigger("TakeDamage");
            isDead = false;
        }
    }
}
