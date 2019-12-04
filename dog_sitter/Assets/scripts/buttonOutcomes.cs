using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This script holds all the right/wrong outcomes when a button is selected.
/// </summary>
public class buttonOutcomes : MonoBehaviour
{
    private buttonSelected buttonSelected;
    // Start is called before the first frame update
    void Start()
    {
        buttonSelected = GameObject.Find("buttonManager").GetComponent<buttonSelected>(); 
    }

    // Update is called once per frame
    void Update()
    {
        // button 1, day 1

      if(buttonSelected.choice1 == true && pointTracking.day == 1 && pointTracking.timesFed== 0)
        {
            print("Good Job!");
        }
      if(buttonSelected.choice1 == true && pointTracking.day == 1 && pointTracking.timesFed== 1)
        {
            print("That was for tomorrow");
        }
       if (buttonSelected.choice1 == true && pointTracking.day == 1 && pointTracking.timesFed == 2)
        {
            print("You gave it the runs...");
        }

        //button 2, day 1

        if (buttonSelected.choice2 == true && pointTracking.day == 1 && pointTracking.timesFed == 0)
        {
            print("NOPE!");
        }
        if (buttonSelected.choice2 == true && pointTracking.day == 1 && pointTracking.timesFed == 1)
        {
            print("YES!");
        }
        if (buttonSelected.choice2 == true && pointTracking.day == 1 && pointTracking.timesFed == 2)
        {
            print("....");
        }
        //button 3 day 1

        if (buttonSelected.choice3 == true && pointTracking.day == 1 && pointTracking.timesFed == 0)
        {
            print("WRONG");
        }
        if (buttonSelected.choice3 == true && pointTracking.day == 1 && pointTracking.timesFed == 1)
        {
            print("stay losing");
        }
        if (buttonSelected.choice3 == true && pointTracking.day == 1 && pointTracking.timesFed == 2)
        {
            print("correct! Genius!");
        }
    }
}
