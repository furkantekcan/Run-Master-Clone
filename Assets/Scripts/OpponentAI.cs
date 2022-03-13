using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OpponentAI : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 forwardMove;
    private Vector3 startPoint;
    private float speed = 3.0f;
    private float turnSpeed = 5f;
    private float turnAmount = 2f;
    private Vector3 horizontalMovement;
    private NavMeshAgent agent;

    public List<GameObject> obstacles;
    public float distanceRun = 1f;
    public GameObject obstacle;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPoint = transform.position;
        agent = GetComponent<NavMeshAgent>();
    }

    //private void Update()
    //{
        
    //}

    private void FixedUpdate()
    {
        
        //forwardMove = new Vector3(0, 0, 1) * speed * Time.fixedDeltaTime;
        ////obstacle = FindClosestObject(obstacles);
        ////Debug.Log(obstacle.transform.name);
        //float distance = Vector3.Distance(transform.position, obstacle.transform.position);
        //if (distance < distanceRun)
        //{
        //    Vector3 dorToObstacle = Vector3.Normalize(transform.position - obstacle.transform.position);
        //    dorToObstacle.y = 0;
        //    dorToObstacle.z = 0;
        //    horizontalMovement = turnAmount * Time.fixedDeltaTime * dorToObstacle;

        //}
        //else
        //{
        //    horizontalMovement = new Vector3(0, 0, 0);
        //}
        //Vector3 movement = rb.position + forwardMove + horizontalMovement;
        //rb.MovePosition(movement);
        //rb.MoveRotation(Quaternion.Slerp(rb.rotation, Quaternion.LookRotation(rb.position + forwardMove + horizontalMovement - transform.position), turnSpeed * Time.deltaTime));


    }

    //GameObject FindClosestObject(List<GameObject> obs)
    //{
    //    GameObject tMin = null;
    //    float minDist = Mathf.Infinity;
    //    Vector3 currentPos = transform.position;

    //    foreach (GameObject t in obs)
    //    {
    //        float dist = Vector3.Distance(t.transform.position, currentPos);
            
    //        if (dist < minDist)
    //        {
    //            tMin = t;
    //            minDist = dist;
    //        }
    //    }

    //    return tMin;
    //}

    private void OnCollisionEnter(Collision collision)
    { 
        if (!collision.transform.CompareTag("CanTouch"))
        {
            transform.position = startPoint;
        }
        
    }
}
