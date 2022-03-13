using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalObstacles : MonoBehaviour
{
    public float speed = 3f;

    private Vector3 origin;
    private Vector3 nextPos;


    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;

        if (origin.x > 0)
        {
            nextPos = new Vector3(-2.5f, origin.y, origin.z);
        }
        else
        {
            nextPos = new Vector3(2.5f, origin.y, origin.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        if (transform.position == nextPos)
        {
            nextPos = origin;
            origin = transform.position;
        }
    }
}
