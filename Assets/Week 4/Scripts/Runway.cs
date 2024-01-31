using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runway : MonoBehaviour
{
    public float score = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score += 0.5f;
    }
}
