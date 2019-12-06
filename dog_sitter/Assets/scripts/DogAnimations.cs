using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimations : MonoBehaviour
{
    Vector3 center;

    
    public float CenterDistance;
    public float VibrateSpeed;
    float AnimationTimer = 0f;//number the timer starts at.
    float MaxTime = 1f; //Maximum amount of time any timer can go past.

    private ClickManager ButtonClicked;// Referencing the Click Manager game object
    public GameObject SelectionManager;//referencing the Click Manager script.

    public Sprite NormalDog;
    public Sprite PukingDog;
   
    // Start is called before the first frame update
    void Start()
    {
        ButtonClicked = GameObject.Find("SelectionManager").GetComponent<ClickManager>();// Telling the progra what ButtonClicked means
        center = transform.position; // Defining the initial starting position of the do sprite. 

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(center.x + Mathf.Sin(Time.time * VibrateSpeed) * CenterDistance, center.y, center.z);// rowan from code lab help is good at math and I'm not. It's a math sine.
        if (ButtonClicked.Wrong == true)//If the choice boolean in Click Manager is true.
        {
            AnimationTimer += Time.deltaTime; //animation counter will start going up.
            this.gameObject.GetComponent<SpriteRenderer>().sprite = PukingDog;
            if (AnimationTimer >= MaxTime)//if the animation timer exceeds or is equal to the Max Time-
            {
            
                this.gameObject.GetComponent<SpriteRenderer>().sprite = NormalDog; //changing the sprite back to it's normal image.
                AnimationTimer = 0f; //resetting the timer.
                ButtonClicked.Wrong = false; //Resetting the button clicked statement.
               
                if (ButtonClicked.Wrong == false) //resetting the timer function.
                {
                    AnimationTimer = 0f;
                }
            }
           
        }

    }
}
