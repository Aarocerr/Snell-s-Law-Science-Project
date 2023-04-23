using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
}
// script is attached to quitButton -- essentially just an onclick event which runs "Application.Quit();" which, as you could've guessed, quits the application
