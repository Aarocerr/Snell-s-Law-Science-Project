using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("QUIT"); // this line is redundant when ran on a user's pc, it's just for testing purposes so while in the Unity editor I know that the Quit button works
        Application.Quit();
    }
}
// script is attached to quitButton -- essentially just an onclick event which runs this code ^
