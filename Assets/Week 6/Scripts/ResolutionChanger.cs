using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionChanger : MonoBehaviour
{
    public void SetAspectRatioSixteenByNine()
    {
        Screen.SetResolution(1600, 900, false);
        Debug.Log("16/9");
    }
    public void SetAspectRatioFULLHD()
    {
        Screen.SetResolution(1920, 1080, false);
        Debug.Log("Full HD");
    }
}
