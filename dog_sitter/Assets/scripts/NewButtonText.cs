using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewButtonText : MonoBehaviour
{
    Text FirstButton;
    Text SecondButton;
    Text ThirdButton;

    public Button button1;
    public Button button2;
    public Button button3;

   
  
    
    // Start is called before the first frame update
    void Start()
    {
         FirstButton = GameObject.Find("Canvas/button1").GetComponent<Text>();
         SecondButton = GameObject.Find("Canvas/button2").GetComponent<Text>();
         ThirdButton = GameObject.Find("Canvas/button3").GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        if(pointTracking.NewDay ==2)
        {
            FirstButton.text = "Cheeseborgor";
            SecondButton.text = "CheeseBalls";
            ThirdButton.text = "Kibble";
        }

        if (pointTracking.NewDay == 3)
        {
            FirstButton.text = "Beef Jerky";
            SecondButton.text = "Student Loans";
            ThirdButton.text = "Chorkin Bits";
        }
    }

}
