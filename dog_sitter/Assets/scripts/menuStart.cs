using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuStart : MonoBehaviour //The purpose of this script is to control all button navigation to different scenes.
{
  public void changemenuscene(string scenename)// Creaated a simple class that allows a Unity user to simply put in the names of the scene.
    {
        SceneManager.LoadScene(scenename);  //Telling the script that if I input the name of the scene in the "scenename" box then when the player clicks the button it wil load that scene.. 
    }
}
