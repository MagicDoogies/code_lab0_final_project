using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public bool Correct = false;
   /* public bool Wrong = false;*/

    public pointTracking ScoreBoard;
    public GameObject trackingPoints;
    public countDownTimer TheTimer;
    public DogAnimations Dog;
    public BowlAnimations Bowl;

    // Start is called before the first frame update
    void Start()
    {
        //ScoreBoard = GameObject.Find("trackingPoints").GetComponent<pointTracking>();
        TheTimer = GameObject.Find("Canvas").GetComponent<countDownTimer>();
        Dog = GameObject.Find("dog").GetComponent<DogAnimations>();
        Bowl = GameObject.Find("bowl").GetComponent<BowlAnimations>();
    }

    public void Button1()
    {
        StopTheTimer();
        
            if (pointTracking.NewDay == 2)//These booleans will change the buttons correct or wrong statements if the day is different.
            {
                Dog.Animating = true;
                pointTracking.Wrong += 1;
            }
            else
            if (pointTracking.NewDay == 3)
            {
                Dog.Animating = false;
                pointTracking.Wrong += 1;
            }
            else
            if (pointTracking.NewDay == 4)
            {
                Dog.Animating = false;
                pointTracking.Wrong += 1;
            }
            if (pointTracking.NewDay == 1)
            {
                Bowl.Animating = true;
            }
        
        pointTracking.NewDay += 1;
        print("It's a new day" + pointTracking.NewDay);
    }

    public void Button2()
    {
        StopTheTimer();

            if (pointTracking.NewDay == 2)
            {
                Bowl.Animating = true;
            }
            else
            if (pointTracking.NewDay == 3)
            {
                Dog.Animating = true;
                pointTracking.Wrong += 1;
            }
            else
            if (pointTracking.NewDay == 4)
            {
                Bowl.Animating = true;
            }
            if (pointTracking.NewDay ==1)
            {
                Dog.Animating = true;
                pointTracking.Wrong += 1;
                print("It's a new day" + pointTracking.NewDay);
            }
        
        pointTracking.NewDay += 1;
        print("It's a new day" + pointTracking.NewDay);
    }

    public void Button3()
    {
        StopTheTimer();

            if (pointTracking.NewDay == 2)
            {
                Dog.Animating = true;
                pointTracking.Wrong += 1;
            }
            else
            if (pointTracking.NewDay == 3)
            {
                Bowl.Animating = true;
                Correct = true;
            }
            else
            if (pointTracking.NewDay == 4)
            {
                Dog.Animating = true;
                pointTracking.Wrong += 1;
            }
            if(pointTracking.NewDay == 1)
            {
                Dog.Animating = true;
                pointTracking.Wrong += 1;
                print("It's a new day" + pointTracking.NewDay);
            }

        pointTracking.NewDay += 1;
        print("It's a new day" + pointTracking.NewDay);
    }
    public void StopTheTimer()
    {
        TheTimer.stopTimer = true;
    }

  
}
