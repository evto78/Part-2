using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Sprite[] sprites;
    public List<Vector2> points;
    public float newPointThreshold = 0.2f;
    public float speed = 1f;
    float landingTimer;

    bool isLanding = false;

    Vector2 lastPosition;
    Vector2 currentPosition;

    LineRenderer lineRenderer;
    Rigidbody2D rb;
    SpriteRenderer sr;

    public AnimationCurve landing;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        transform.Translate(Random.Range(-5, 5), Random.Range(-5, 5),0);
        rb.rotation = Random.Range(0f, 360f);
        speed = Random.Range(1, 3);
        sr.sprite = sprites[Random.Range(1, 4)];
    }

    private void FixedUpdate()
    {
        currentPosition = transform.position;
        if(points.Count > 0)
        {
            Vector2 direction = points[0] - currentPosition;
            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            rb.rotation = -angle;
        }
        rb.MovePosition(rb.position + (Vector2)transform.up * speed * Time.deltaTime);
    }

    private void Update()
    {
        if(isLanding)
        {
            landingTimer += 2f * Time.deltaTime;
            float interpolation = landing.Evaluate(landingTimer);
            if (transform.localScale.z < 0.1f)
            {
                Destroy(gameObject);
            }
            transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, interpolation);
        }

        lineRenderer.SetPosition(0, transform.position);
        if (points.Count > 0)
        {
            if (Vector2.Distance(currentPosition, points[0]) < newPointThreshold)
            {
                points.RemoveAt(0);
                
                for (int i = 1; i < lineRenderer.positionCount - 2; i++) 
                {
                    lineRenderer.SetPosition(i, lineRenderer.GetPosition(i + 1));
                }
                if(lineRenderer.positionCount != 0) lineRenderer.positionCount--;
            }
        }
    }

    private void OnMouseDown()
    {
        points = new List<Vector2>();
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        points.Add(newPosition);
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);

    }
    private void OnMouseDrag()
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Vector2.Distance(lastPosition, newPosition) > newPointThreshold)
        {
            points.Add(newPosition);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, newPosition);
            lastPosition = newPosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Plane") sr.color = Color.red;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Vector3.Distance(transform.position, collision.transform.position) < 0.4f && collision.tag == "Plane")
        {
            Destroy(gameObject);
        }

        if (collision.tag != "Plane")
        {
            isLanding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        if (collision.tag == "Plane") sr.color = Color.white;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
