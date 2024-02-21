using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportController : MonoBehaviour
{

    public static PlayerSportScript CurrentSelection { get; private set; }
    public static void SetCurrentSelection(PlayerSportScript player)
    {
        if(CurrentSelection != null)
        {
            CurrentSelection.Selected(false);
        }
        CurrentSelection = player;
        CurrentSelection.Selected(true);
    }

}
