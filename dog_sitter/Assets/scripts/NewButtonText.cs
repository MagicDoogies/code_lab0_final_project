using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewButtonText : MonoBehaviour
{
    public Text FirstButton;
    public Text SecondButton;
    public Text ThirdButton;
    public Text DayBanner;

    public pointTracking pointTracking;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject CorrectImage;
    public GameObject WrongImage;
    public GameObject DogStarved;
    public countDownTimer TheTimer;
    public DogAnimations Dog;
    public BowlAnimations Bowl;
    public countDownTimer Timer;
   
    
    // Start is called before the first frame update
    void Start()
    {
        pointTracking = GameObject.Find("trackingPoints").GetComponent<pointTracking>();
        Dog = GameObject.Find("dog").GetComponent<DogAnimations>();
        Bowl = GameObject.Find("bowl").GetComponent<BowlAnimations>();
        Timer = GameObject.Find("Canvas").GetComponent<countDownTimer>();
       
    }

    // Update is called once per frame
    void Update()
    {  // The text will change depending on what the day is.
        if(pointTracking.NewDay ==1)
        {
            FirstButton.text = "Bow Chow";
            SecondButton.text = "Yams";
            ThirdButton.text = "Milk Bone";
        }
        if(pointTracking.NewDay ==2)
        {
            FirstButton.text = "Chunks";
            SecondButton.text = "Yarn Snacks";
            ThirdButton.text = "Kibble";
        }

        if (pointTracking.NewDay == 3)
        {
            FirstButton.text = "Beef Janky";
            SecondButton.text = "The Dead";
            ThirdButton.text = "Chorkin Bits";
        }
        if (pointTracking.NewDay == 4)
        {
            FirstButton.text = "Chicken Nuggies";
            SecondButton.text = "Nerds Candy";
            ThirdButton.text = "Mom's Spaghetti";
        }

        if (pointTracking.NewDay == 5)
        {
            Button1.SetActive(false);
            Button2.SetActive(false);
            Button3.SetActive(false);

        }
        if (Dog.Animating == true)
        {
            WrongImage.SetActive(true);
        }
        else
        if (Dog.Animating == false)
        {
            WrongImage.SetActive(false);
        }
        if (Bowl.Animating == true)
        {
            CorrectImage.SetActive(true);
        }
        else
        if (Bowl.Animating == false)
        {
            CorrectImage.SetActive(false);
        }

        if (Timer.DogStarved == true)
        {
            DogStarved.SetActive(true);
        }
        else
        if (Timer.DogStarved == false)
        {
            DogStarved.SetActive(false);
        }
        //This changes the banner text so players know what Day they are on.
        if (pointTracking.NewDay == 1)
        {
            DayBanner.text = "DAY 1";
        }
        if (pointTracking.NewDay == 2)
        {
            DayBanner.text = "DAY 2";
        }
        if (pointTracking.NewDay == 3)
        {
            DayBanner.text = "DAY 3";
        }
        if (pointTracking.NewDay == 4)
        {
            DayBanner.text = "DAY 4";
        }
        if (pointTracking.NewDay == 5)
        {
            DayBanner.text = "DONE";
        }
    }
  
}
