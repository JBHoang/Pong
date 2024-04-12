using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;


    //this function will get called anytime a collision occurs 
    //with the object that is running BouncySurface script
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        // if ball is null, it means the collision was not the ball -> do not execute any logic
        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
