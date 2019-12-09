using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This script controls what the final score of the player would be based on their choices.
public class ScoreRating : MonoBehaviour
{
    public Sprite PerfectScore;
    public Sprite WorstScore;
    public Sprite OneStar;
    public Sprite ThreeStar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pointTracking.Wrong == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = OneStar;
        }
        if (pointTracking.Wrong == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = OneStar;
        }
        if(pointTracking.RanTimer == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = WorstScore;
        }
        if(pointTracking.Wrong == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = PerfectScore;
        }
        if (pointTracking. Wrong == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ThreeStar;
        }
        if(pointTracking.Wrong == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ThreeStar;
        }
        if (pointTracking.RanTimer == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = OneStar;
        }
        if (pointTracking.RanTimer == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = WorstScore;
        }
        if (pointTracking.RanTimer == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = WorstScore;
        }
    }
}
