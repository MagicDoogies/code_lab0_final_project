using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointTracking : MonoBehaviour
{
    public static int timesFed = 0;
    public static int day = 1;
    public static int wrong = 0;

    public static pointTracking instance = null;
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
   

}
