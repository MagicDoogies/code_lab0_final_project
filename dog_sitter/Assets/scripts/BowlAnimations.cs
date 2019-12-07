using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Outside of the Game Object this script is attached to and the script used this is basically a 1:1 copy of the DogAnimations script.
public class BowlAnimations : MonoBehaviour
{
    public GameObject SelectionManager;
    public bool Animating = false;

    float AnimationTimer = 0f;
    float MaxTime = 2f;

    public Sprite EmptyBowl;
    public Sprite FullBowl;

    public void Start()
    {

    }

    public void Update()
    {
        if (Animating == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = FullBowl;
            AnimationTimer += 1 * Time.deltaTime;
            if (AnimationTimer >= MaxTime)
            {
                Animating = false;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = EmptyBowl;
                AnimationTimer = 0f;
            }
        }
    }
}
   
    

   