using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEnabler : Interactables
{
    public GameObject EnabledUI;

    public override GameObject Interact()//call on interact function
    {

        if (!EnabledUI.activeSelf)//checks if UI is not active
        {
            EnabledUI.SetActive(true);
            return EnabledUI;
        }
        return null;//returns boolean as a game object
    }
}
