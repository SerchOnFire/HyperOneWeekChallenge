using System.Collections;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public Vector3 initialPosition;
    public PaddleBehaviour paddle;
    public WallBehaviour wall;
    private bool gameStarted = false;
    [Range(0, 100)] public float ballforce = 0;
    private bool canMove = false;
    void Start()
    {
        initialPosition = transform.position;
        canMove = true;
    }
    
    void Update()
    {
        if (!gameStarted && canMove)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rigidBody.AddForce(new Vector2(10, 5) * ballforce);
                gameStarted = true;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rigidBody.AddForce(new Vector2(-10, 5) * ballforce);
                gameStarted = true;
            }
            paddle.Restart();
        }
    }

    void Reset()
    {
        transform.position = initialPosition;
        StartCoroutine(Restart());
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Bottom")
        {
            gameStarted = false;
            canMove = false;
            
            rigidBody.velocity = Vector2.zero;
            rigidBody.angularVelocity = 0;
            
            Reset();
            paddle.Reset();
            wall.Reset();
        }
    }
    
    IEnumerator Restart()
    {
        yield return new WaitForSecondsRealtime(2);
        canMove = true;
    }
}
