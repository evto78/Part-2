using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
        if (PlayerPrefs.GetFloat("KnightHp") != null)
        {
            health = PlayerPrefs.GetFloat("KnightHp");
            SendMessage("SetHealth", health, SendMessageOptions.DontRequireReceiver);
        }
        else
        {
            health = maxHealth;
            SendMessage("SetHealth", health, SendMessageOptions.DontRequireReceiver);
        }

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        if (health <= 0)
        {
            animator.SetTrigger("Death");
            isDead = true;
        }
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
        PlayerPrefs.SetFloat("KnightHp", health);
        if (isDead) return;
        if (Input.GetMouseButtonDown(0) && !clickedOnSelf && !EventSystem.current.IsPointerOverGameObject())
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
