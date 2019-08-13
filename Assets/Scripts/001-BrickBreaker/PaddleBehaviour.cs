using System;
using System.Collections;
using UnityEngine;

public class PaddleBehaviour : MonoBehaviour
{
    public Rigidbody2D ballRigidBody;
    public Vector3 initialPosition;
    [Range(0, 100)] public float paddleVelocity = 0;
    
    public bool canMove = false;
    
    void Awake()
    {
        initialPosition = transform.position;
    }

    private void Start()
    {
        canMove = true;
    }

    void Update()
    {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                MoveTo(Vector3.right);

            if (Input.GetKey(KeyCode.LeftArrow))
                MoveTo(Vector3.left);
        }
    }

    void MoveTo(Vector3 direction)
    {
        transform.position = transform.position + (direction * (Time.deltaTime * paddleVelocity));
        
        if(transform.position.x < -11.4f)
            transform.position = new Vector3(-11.4f, transform.position.y, transform.position.z);

        if(transform.position.x > 11.4f)
            transform.position = new Vector3(11.4f, transform.position.y, transform.position.z);
    }

    public void Reset()
    {
        transform.position = initialPosition;
        canMove = false;
    }

    public void Restart()
    {
        canMove = true;
    }


}
