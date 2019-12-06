using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//handles button functions for whether or not they are right or wrong. 
public class buttonSelected : MonoBehaviour
{
    public GameObject dog;

    public bool correct = false;
    public bool wrong = false;
    


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
       /* if (pointTracking.NewDay == 1 && pointTracking.RanTimer == 0)
        {
            print("correct");
            correct = true;
            pointTracking.NewDay = 2;
            pointTracking.RanTimer = 1;
            //SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.NewDay ==2 && pointTracking.timesFed == 1)
        {
            print("cogh");
            wrong = true;
            pointTracking.NewDay = 3;
            pointTracking.RanTimer = 2;
            //SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.NewDay == 3 && pointTracking.RanTimer == 2)
        {
            pointTracking.day = 4;
            print("wrong3");
            wrong = true;
            pointTracking.timesFed = 3;
            //SceneManager.LoadScene("main_game_room");
            return;
        }


    }
    public void Button2()
    {
        if (pointTracking.day == 1 && pointTracking.timesFed == 0)
        {
            print("It's d");
            wrong = true;
            pointTracking.day = 2;
            pointTracking.timesFed = 1;
            //SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 2 && pointTracking.timesFed == 1)
        {
            print("It's day 2");
            wrong = true;
            pointTracking.day = 3;
            pointTracking.timesFed = 2;
            //SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 3 && pointTracking.timesFed == 2)
        {
            pointTracking.day = 4;
            correct = true; 
            print("it's day3");
            pointTracking.timesFed = 3;
            //SceneManager.LoadScene("main_game_room");
            return;
        }

    }

    public void Button3()
    {
        if (pointTracking.day == 1 && pointTracking.timesFed == 0)
        {
            print("It's day 1");
            wrong = true;
            pointTracking.day = 2;
            pointTracking.timesFed = 1;
            //SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 2 && pointTracking.timesFed == 1)
        {
            print("It's day 2");
            correct = true;
            pointTracking.day = 3;
            pointTracking.timesFed = 2;
            //SceneManager.LoadScene("main_game_room");
            return;
        }

        if (pointTracking.day == 3 && pointTracking.timesFed == 2)
        {
            print("It's day3 ");
            wrong = true;
            pointTracking.day = 4;
            pointTracking.timesFed = 3;
            //SceneManager.LoadScene("main_game_room");  
            return;
        }*/
    }

  
  
}
