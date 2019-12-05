using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pointTracking : MonoBehaviour
{
    public static int timesFed = 0;
    public static int day = 1;
    public static int wrong = 0;

   /* private bool oneDay = false;
    private bool twoDay = false;
    private bool threeDay = false;*/

    public static pointTracking instance = null;
    private bool sceneLoaded = false;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(this.gameObject);
    }
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
      if (timesFed == 3 && day== 4 && !sceneLoaded)
        {
            SceneManager.LoadScene("score_screen");
            sceneLoaded = true;
        }
    }
}
