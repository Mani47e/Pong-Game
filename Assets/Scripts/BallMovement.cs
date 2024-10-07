using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float startspeed;
    public float addspeed;
    public float maxaddspeed;

    private int hitCounter=0;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    public IEnumerator Launch()
    {
        hitCounter=0;

        yield return new WaitForSeconds(1);

        moveball(new Vector2(-1,0));
    }
 
    public void moveball(Vector2 direction)
    {
       direction = direction.normalized;

       float ballSpeed = startspeed+hitCounter*addspeed;

       rb.velocity = direction*ballSpeed;
    }

    public void addhitcounter()
    {
        if(hitCounter*addspeed<maxaddspeed)
        {
        hitCounter++;
    }
    }

}
  