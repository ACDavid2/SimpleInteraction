using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Interactables
{
    public int sceneBuildIndex; //Select which scene it loads
    public override GameObject Interact()//Calls on interact function
    {

        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        return null;


    }
}
