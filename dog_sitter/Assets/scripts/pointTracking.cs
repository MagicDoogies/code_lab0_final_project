using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pointTracking : MonoBehaviour
{
    public static int RanTimer = 0;
    public static int NewDay = 1;
    public static int Wrong = 0;
    public bool GameEnds = false;
    private int SceneIndex;

    float EndGameTimer = 4f;
    float EndGameStart = 0f;
  
    public static pointTracking instance = null;
   
    private void Awake()
    {
        if (instance == null)//If there is no instance of this script in the scene create one.
            instance = this;
        else if (instance != null)//If there is another script like this in the scene delete this current instance.
            Destroy(this.gameObject);
    }
    private void Start()
    {
        SceneIndex = SceneManager.GetActiveScene().buildIndex;

       /* if (GameEnds == true)
        {
            DontDestroyOnLoad(this.gameObject); //this script won't be destroyed when the game changes scenes.
        }
        */
    }

    private void Update()
    {
      if ( NewDay== 5)
        {
            print("I'm going to End now!");
            GameEnds = true;
            if (GameEnds == true)
            {
                EndGameStart += 1 * Time.deltaTime;
                if (EndGameStart >= EndGameTimer)
                {
                    SceneManager.LoadScene("score_screen");
                }
                //this script will also talk to an outside gameobject to appear for a set amount of time that says "finished" before the score screen loads in.

            }
      }
      if (SceneIndex == 1)
        {
            NewDay = 1;
            Wrong = 0;
            RanTimer = 0;
        }
    }
}
