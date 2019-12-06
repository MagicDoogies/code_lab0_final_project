using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public bool Correct = false;
    public bool Wrong = false;

    public pointTracking ScoreBoard;
    public GameObject trackingPoints;

    // Start is called before the first frame update
    void Start()
    {
       //ScoreBoard = GameObject.Find("trackingPoints").GetComponent<pointTracking>();
    }

    public void Button1()
    {

        Correct = true;
        pointTracking.NewDay += 1;
        pointTracking.Wrong = 1;
        print("CORRECT!");
    }

    public void Button2()
    {
        Wrong = true;
        pointTracking.NewDay += 1;
        pointTracking.Wrong = 1;
        print("WRONG");
    }

    public void Button3()
    {
        Wrong = true;
        pointTracking.NewDay += 1;
        pointTracking.Wrong = 1;
        print("WRONG");
    }


}
