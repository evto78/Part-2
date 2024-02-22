using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fluctuate : MonoBehaviour
{
    public float i = -0.5f;
    bool fluctuateDirUp = false;

    

    // Update is called once per frame
    void Update()
    {
        if (fluctuateDirUp)
        {
            i += 0.002f;
        }
        else
        {
            i -= 0.002f;
        }

        if (i > 0.3f)
        {
            fluctuateDirUp = false;
        }
        else if (i < -0.3f)
        {
            fluctuateDirUp = true;
        }

        transform.Translate(0, i, 0);
    }
}
