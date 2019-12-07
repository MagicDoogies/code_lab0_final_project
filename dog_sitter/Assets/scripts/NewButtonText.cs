using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewButtonText : MonoBehaviour
{
    public Text FirstButton;
    public Text SecondButton;
    public Text ThirdButton;

    public pointTracking pointTracking;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    
    // Start is called before the first frame update
    void Start()
    {
        pointTracking = GameObject.Find("trackingPoints").GetComponent<pointTracking>();
       
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
    }

}
