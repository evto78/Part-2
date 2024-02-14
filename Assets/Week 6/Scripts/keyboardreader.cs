using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardreader : MonoBehaviour
{

    SceneLoad sceneLoad;

    // Start is called before the first frame update
    void Start()
    {
        sceneLoad = GetComponent<SceneLoad>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            sceneLoad.LoadNextScene();
        }
    }
}
