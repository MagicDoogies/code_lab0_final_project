using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResettingScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Rsetting");
        pointTracking.NewDay = 1;
        pointTracking.Wrong = 0;
        pointTracking.RanTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
