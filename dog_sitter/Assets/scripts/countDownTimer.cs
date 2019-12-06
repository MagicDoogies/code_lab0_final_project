using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDownTimer : MonoBehaviour
{
    
    private int sceneIndex = 0;
    private bool stopTimer = false;

    float currentTime = 0f; //variable to hold what the current time of the timer is.
    float startingTime = 8f;
    
    [SerializeField] Text countdownText; //Letting Unity know that the 'Text' box inside the object countdownText will be a field actively changed in this script.

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        currentTime = startingTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (!stopTimer)
        {
            currentTime -= 1 * Time.deltaTime; // Makes sure that the seconds go down by actual seconds as opposed to by frame.
            countdownText.text = currentTime.ToString("0"); //As the numbers in the 'Text' box in game object countdownTimer change the new number will be displayed on screen.
        }

      if (currentTime <= 0 && sceneIndex == 2)//if the timer reaches 0 AND the scene Index is 2- which is the index of the memorization screen.
        {
            SceneManager.LoadScene("main_game_room");//The scene manager will load in the scene titled main_game_room.
        }

      if (currentTime <= 0 && sceneIndex== 3 && !stopTimer) 
        {
            
            print("DOG STARVED!!");
            pointTracking.RanTimer = 2;
            stopTimer = true;
          
        }
    

    }
}
