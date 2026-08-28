using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D rb2d;
    public float maxInitialAngle = 0.0f;
    public float moveSpeed = 1f;
    public float maxStartY = 4f;
    public float speedMultiplier = 1.1f;
 
    private float StartX = 0f;
    
    private void Start()
    {
        
        GameManager.instance.onReset += ResetBall;
        GameManager.instance.gameUI.onStartGame += ResetBall;
    }
    private void ResetBall()
    {
        ResetBallPosition();
      
        InitialPush();
    }
    private void ResetBallPosition()
    {
        float posY = Random.Range(-maxStartY, maxStartY);
        Vector2 position = new Vector2(StartX, posY);
        transform.position = position;
    }

    private void InitialPush()
    {

        Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;
        dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb2d.linearVelocity = dir * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreZone scoreZone = collision.GetComponent<ScoreZone>();
        if(scoreZone)
        {
            GameManager.instance.OnScoreZoneReached(scoreZone.id);
            ResetBall();
            InitialPush();   
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Paddle paddle = collision.collider.GetComponent<Paddle>();
        if (paddle)
        {
            rb2d.linearVelocity *= speedMultiplier;
        }
    }

}
