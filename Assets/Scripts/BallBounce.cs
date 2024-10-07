using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public BallMovement ballMovement;
    public Score score;

    private void Bounce(Collision2D collision)
    {
       Vector3 BallPosition= transform.position;
        Vector3 racketposition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float PositionX;
        if(collision.gameObject.name=="P1")
        {
            PositionX=1;
        }
        else PositionX = -1;

        float PositionY = (BallPosition.y - racketposition.y)/racketHeight;

        ballMovement.addhitcounter();
        ballMovement.moveball(new Vector2(PositionX,PositionY));
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="P1"||collision.gameObject.name=="P2")
        {
            Bounce(collision);
        }
        else if(collision.gameObject.name=="RightBorder")
        {
          score.P1True();
        }
        else if(collision.gameObject.name=="left")
        {
          score.P2True();
        }

    }


}
