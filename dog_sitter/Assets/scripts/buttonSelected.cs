using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//handles button functions for whether or not they are right or wrong. 
public class buttonSelected : MonoBehaviour
{
    public bool choice1 = false;
    public bool choice2 = false;
    public bool choice3 = false;
   
    // Start is called before the first frame update
    void Start()
    {
      
      
    }

    // Update is called once per frame
    void Update()
    {
       

        
    }
    //functions public void Buttons 1-3 will give the buttons different onClick functions depending on the static variables in the pointTracking script. 
    public void Button3()
    {
        choice3 = true;
        
    }
    public void Button2()
    {
        choice2 = true;

    }

    public void Button1()
    {
        choice1 = true;


    }
  
}
