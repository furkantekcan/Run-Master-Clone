using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    private float swerveSpeed =2f;
    private float turnSpeed = 5f;

    private Vector3 forwardMove;
    private Rigidbody rb;

    #region Swerve vars

    private float lastPosX;
    private float moveFactorX;
    private float swerveAmount;
    private float maxSwerveAmount = 2f;

    #endregion






    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void FixedUpdate()
    {
        SwerveInputSystem();
        swerveAmount = swerveSpeed * moveFactorX;
        swerveAmount = Mathf.Clamp(swerveAmount, -maxSwerveAmount, maxSwerveAmount);
        

        forwardMove = new Vector3(0, 0, 1) * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = swerveAmount * Time.fixedDeltaTime * transform.right;

        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        rb.MoveRotation(Quaternion.Slerp(rb.rotation, Quaternion.LookRotation(rb.position + forwardMove + horizontalMove - transform.position), turnSpeed * Time.deltaTime));
    }

    void SwerveInputSystem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            moveFactorX = 0.05f*(Input.mousePosition.x - lastPosX);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            moveFactorX = 0f;
        }
    }
    
}
