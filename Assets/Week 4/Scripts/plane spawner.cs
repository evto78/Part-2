using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planespawner : MonoBehaviour
{
    float timer = 0f;
    float timerTarget;

    public GameObject planePrefab;
    void Start()
    {
        timerTarget = Random.Range(1f, 5f);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerTarget)
        {
            Instantiate(planePrefab, transform);
            Debug.Log("plane spawned");
            timer = 0f;
            timerTarget = Random.Range(1f, 5f);

        }
    }
}
