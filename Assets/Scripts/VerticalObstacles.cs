using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalObstacles : MonoBehaviour
{
    private float downSpeed = 5f;
    private float upSpeed = 1f;
    private float speed;

    private Vector3 origin;
    private Vector3 nextPos;
    private GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = transform.GetChild(0).gameObject;
        origin = obstacle.transform.position;
        nextPos = new Vector3(origin.x, 2.1f, origin.z);
    }

    // Update is called once per frame
    void Update()
    {
        SetSpeed();

        obstacle.transform.position = Vector3.MoveTowards(obstacle.transform.position, nextPos, speed * Time.deltaTime);

        if (obstacle.transform.position == nextPos)
        {
            nextPos = origin;
            origin = obstacle.transform.position;
        }

    }

    void SetSpeed()
    {
        if (origin.y > nextPos.y)
        {
            speed = downSpeed;
        }
        else if (origin.y < nextPos.y)
        {
            speed = upSpeed;
        }
    }
}
