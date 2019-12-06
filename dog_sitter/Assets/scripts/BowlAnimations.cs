using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlAnimations : MonoBehaviour
{
    public GameObject SelectionManager;
    private ClickManager ButtonClicked;

    float AnimationTimer = 0f;
    float MaxTime = 1f;

    public Sprite EmptyBowl;
    public Sprite FullBowl;

    public void Start()
    {
        ButtonClicked = GameObject.Find("SelectionManager").GetComponent<ClickManager>();

    }

    public void Update()
    {
        if (ButtonClicked.Correct == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = FullBowl;
            AnimationTimer += Time.deltaTime;
            if (AnimationTimer >= MaxTime)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = EmptyBowl;
                ButtonClicked.Correct = false;
                if (ButtonClicked.Correct == false)
                {
                    AnimationTimer = 0f;

                }
            }
        }
    }
}
   
    

   