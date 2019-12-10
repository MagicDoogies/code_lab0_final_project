using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This script controls what the final score of the player would be based on their choices.
public class ScoreRating : MonoBehaviour
{
    public GameObject WorstScore;
    public GameObject BestScore;
    public GameObject OneStar;
    public GameObject ThreeStar;
    public pointTracking pointTracking;

    /*private Image WorstScore;
    private Image BestScore;
    private Image OneStar;
    private Image ThreeStar;*/

    // Start is called before the first frame update
    void Start()
    {
        /*WorstScore = GameObject.Find("ThreeStar").GetComponent<Image>();
        BestScore = GameObject.Find("OneStar").GetComponent<Image>();
        OneStar = GameObject.Find("WorstScore").GetComponent<Image>();
        ThreeStar = GameObject.Find("ThreeStar").GetComponent<Image>()*/
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("RanTimer" + pointTracking.RanTimer);

            OneStar.SetActive(pointTracking.Wrong == 4 || pointTracking.Wrong == 3);
            WorstScore.SetActive(pointTracking.RanTimer == 4);
            WorstScore.SetActive(pointTracking.RanTimer == 6);
            WorstScore.SetActive(pointTracking.RanTimer == 8);
            ThreeStar.SetActive(pointTracking.Wrong == 2 || pointTracking.Wrong == 1);
            BestScore.SetActive(pointTracking.Wrong == 0);
       
        if (pointTracking.RanTimer >= 4)
        {
            BestScore.SetActive(false);
        }
    }
}
