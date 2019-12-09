using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDownTimer : MonoBehaviour
{
    
    private int sceneIndex = 0;
    public bool stopTimer = false;

    public GameObject SelectionManager;
    public pointTracking TrackingPoints;
   
    

    public float currentTime = 0f; //variable to hold what the current time of the timer is.
    float startingTime = 5f; //When the timer counts down.
    float RestartTimer = 2f;//Restart the timer when one second has passed.
    float RestartStart = 0f;//The starting point of the rest timer.
    public bool DogStarved = false;
    
    [SerializeField] Text countdownText; //Letting Unity know that the 'Text' box inside the object countdownText will be a field actively changed in this script.

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        currentTime = startingTime;
        //TrackingPoints = GameObject.Find("trackingPoints").GetComponent<pointTracking>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (stopTimer == false)
        {
            currentTime -= 1 * Time.deltaTime; // Makes sure that the seconds go down by actual seconds as opposed to by frame.
            countdownText.text = currentTime.ToString("0"); //As the numbers in the 'Text' box in game object countdownTimer change the new number will be displayed on screen.
        }

      if (currentTime <= 0 && sceneIndex == 2)//if the timer reaches 0 AND the scene Index is 2- which is the index of the memorization screen.
        {
            SceneManager.LoadScene("main_game_room");//The scene manager will load in the scene titled main_game_room.
        }

      if (currentTime <= 0 && sceneIndex== 3 && stopTimer == false) //If this timer ends then you you gain (bad) points for running the timer and a New Day happens.
        {
            print("Ran the Timer" + pointTracking.RanTimer);
            pointTracking.NewDay += 1;
            pointTracking.RanTimer += 2;
            DogStarved = true;
            stopTimer = true;
        }
        if (stopTimer == true) //If the timer has been stopped.
        {
            RestartTimer -= 1 * Time.deltaTime;//The restart timer will do a countdown.
            if(RestartTimer <= RestartStart)//If restart Timer is less than or equal to the RestartStart (which is 0) than the timer starts up again.
            {
                currentTime = startingTime;//restarts the main timer.
                RestartTimer = 2;//restarts the internal delay timer.
                DogStarved = false;
                stopTimer = false;
            }
        }
      
    }
}
