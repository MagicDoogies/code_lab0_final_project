using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDownTimer : MonoBehaviour
{

    float currentTime = 0f; //variable to hold what the current time of the timer is.

    public float startingTime; //Can edit the starting time for my timer depending on the situation.

    [SerializeField] Text countdownText; //Letting Unity know that the 'Text' box inside the object countdownText will be a field actively changed in this script.

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;

        
        
   
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; // Makes sure that the seconds go down by actual seconds as opposed to by frame.
        countdownText.text = currentTime.ToString("0"); //As the numbers in the 'Text' box in game object countdownTimer change the new number will be displayed on screen.

    }
}
