using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firejetscript : MonoBehaviour
{
    public GameObject fireJet1;
    public GameObject fireJet2;
    public GameObject fireJet3;
    public GameObject fireJet4;

    float fireJetTimer;

    float i;
    void Start()
    {
        fireJet1.SetActive(false);
        fireJet2.SetActive(false);
        fireJet3.SetActive(false);
        fireJet4.SetActive(false);

        fireJetTimer = 8f;
    }

    // Update is called once per frame
    void Update()
    {
        fireJetTimer -= Time.deltaTime;
        if (fireJetTimer < 0)
        {
            i = Random.Range(1, 4);
            if (i == 1)
            {
                fireJet1.SetActive(true);
            }
            else if (i == 2)
            {
                fireJet2.SetActive(true);
            }
            else if (i == 3)
            {
                fireJet3.SetActive(true);
            }
            else if (i == 4)
            {
                fireJet4.SetActive(true);
            }

            fireJetTimer = Random.Range(8, 14);
        }
    }
}
