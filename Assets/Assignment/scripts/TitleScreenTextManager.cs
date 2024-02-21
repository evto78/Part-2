using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TitleScreenTextManager : MonoBehaviour
{
    public TextMeshProUGUI carsFixed;
    public TextMeshProUGUI moneyMade;
    public TextMeshProUGUI emotion1;
    public TextMeshProUGUI emotion2;
    public TextMeshProUGUI emotion3;

    int i;

    void Start()
    {
        carsFixed.text = ""+PlayerPrefs.GetFloat("CarsFixed")+"";
        moneyMade.text = "" + PlayerPrefs.GetFloat("MoneyMade") + "";

        if (emotion1 == null) return;
        if (emotion2 == null) return;
        if (emotion3 == null) return;

        i = Random.Range(0, 10);
        if (i == 1)
        {
            emotion1.text = "happy";
        }
        else if (i == 2)
        {
            emotion1.text = "lucky";
        }
        else if (i == 3)
        {
            emotion1.text = "sad";
        }
        else if (i == 4)
        {
            emotion1.text = "unexplicable";
        }
        else if (i == 5)
        {
            emotion1.text = "explosive";
        }
        else if (i == 6)
        {
            emotion1.text = "exshaperated";
        }
        else if (i == 7)
        {
            emotion1.text = "annoyed";
        }
        else if (i == 8)
        {
            emotion1.text = "ambiguious";
        }
        else if (i == 9)
        {
            emotion1.text = "perfect";
        }
        else if (i == 10)
        {
            emotion1.text = "stable";
        }

        i = Random.Range(0, 10);
        if (i == 1)
        {
            emotion2.text = "happy";
        }
        else if (i == 2)
        {
            emotion2.text = "lucky";
        }
        else if (i == 3)
        {
            emotion2.text = "sad";
        }
        else if (i == 4)
        {
            emotion2.text = "unexplicable";
        }
        else if (i == 5)
        {
            emotion2.text = "explosive";
        }
        else if (i == 6)
        {
            emotion2.text = "exshaperated";
        }
        else if (i == 7)
        {
            emotion2.text = "annoyed";
        }
        else if (i == 8)
        {
            emotion2.text = "ambiguious";
        }
        else if (i == 9)
        {
            emotion2.text = "perfect";
        }
        else if (i == 10)
        {
            emotion2.text = "stable";
        }

        i = Random.Range(0, 10);
        if (i == 1)
        {
            emotion3.text = "happy";
        }
        else if (i == 2)
        {
            emotion3.text = "lucky";
        }
        else if (i == 3)
        {
            emotion3.text = "sad";
        }
        else if (i == 4)
        {
            emotion3.text = "unexplicable";
        }
        else if (i == 5)
        {
            emotion3.text = "explosive";
        }
        else if (i == 6)
        {
            emotion3.text = "exshaperated";
        }
        else if (i == 7)
        {
            emotion3.text = "annoyed";
        }
        else if (i == 8)
        {
            emotion3.text = "ambiguious";
        }
        else if (i == 9)
        {
            emotion3.text = "perfect";
        }
        else if (i == 10)
        {
            emotion3.text = "stable";
        }
    }

    void Update()
    {
        carsFixed.text = "" + PlayerPrefs.GetFloat("CarsFixed") + "";
        moneyMade.text = "" + PlayerPrefs.GetFloat("MoneyMade") + "";
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("assignmentMain");
    }
}
