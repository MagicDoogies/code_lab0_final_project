using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogActions : MonoBehaviour
{
    /*public float leftSpeed;
    public int frames;
    private bool changeDirection;
    public float stopChanging = 1f;*/

    Vector3 center;
    public float centerDistance;
    public float vibrateSpeed;

    void Start()
    {
        center = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(center.x + Mathf.Sin(Time.time *vibrateSpeed) * centerDistance, center.y, center.z);// rowan from code lab help is good at math and I'm not. It's a math sine.

    }
}
