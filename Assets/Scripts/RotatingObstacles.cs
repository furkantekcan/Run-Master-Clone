using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacles : MonoBehaviour
{
    public float turn = 1f;

    private float turnSpeed = 100f;
   
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
    }
}
