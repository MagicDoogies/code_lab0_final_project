using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//handles button functions for whether or not they are right or wrong. 
public class buttonSelected : MonoBehaviour
{
   /* public bool choice1 = false;
    public bool choice2 = false;
    public bool choice3 = false;*/
   
    // Start is called before the first frame update
    void Start()
    {
      
      
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }
    //functions public void Buttons 1-3 will give the buttons different onClick functions depending on the static variables in the pointTracking script. 
    public void Button1()
    {
        if (pointTracking.day == 1 && pointTracking.timesFed == 0)
        {
            print("It's day 1");
            pointTracking.day = 2;
            pointTracking.timesFed = 1;
            SceneManager.LoadScene("main_game_room");
            Invoke("DogPuke", 2.0f);
            return;
        }

        if (pointTracking.day ==2 && pointTracking.timesFed == 1)
        {
            print("It's day 2");
            pointTracking.day = 3;
            pointTracking.timesFed = 2;
            SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 3 && pointTracking.timesFed == 2)
        {
            pointTracking.day = 4;
            pointTracking.timesFed = 3;
            SceneManager.LoadScene("main_game_room");
            return;
        }


    }
    public void Button2()
    {
        if (pointTracking.day == 1 && pointTracking.timesFed == 0)
        {
            print("It's day 1");
            pointTracking.day = 2;
            pointTracking.timesFed = 1;
            SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 2 && pointTracking.timesFed == 1)
        {
            print("It's day 2");
            pointTracking.day = 3;
            pointTracking.timesFed = 2;
            SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 3 && pointTracking.timesFed == 2)
        {
            pointTracking.day = 4;
            print("it's day3");
            pointTracking.timesFed = 3;
            SceneManager.LoadScene("main_game_room");
            return;
        }

    }

    public void Button3()
    {
        if (pointTracking.day == 1 && pointTracking.timesFed == 0)
        {
            print("It's day 1");
            pointTracking.day = 2;
            pointTracking.timesFed = 1;
            SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 2 && pointTracking.timesFed == 1)
        {
            print("It's day 2");
            pointTracking.day = 3;
            pointTracking.timesFed = 2;
            SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 3 && pointTracking.timesFed == 2)
        {
            print("It's day3 ");
            pointTracking.day = 4;
            pointTracking.timesFed = 3;
            SceneManager.LoadScene("main_game_room");  
            return;
        }
    }

    public void DogPuke()
    {
        Debug.Log("Dog pukes");
    }
  
}
