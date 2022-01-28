using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : Mover
{
    private bool isReflecting = true;
    private Vector3 offset = new Vector3(0.25f, 0.15f, 0);
    private Transform playerTransform;
    private Vector3 playerVelocity;


    protected override void Start()
    {
        base.Start();
        playerTransform = GameManager.instance.player.transform;
        playerVelocity = GameManager.instance.player.GetComponent<Rigidbody2D>().velocity;
        stickToMe();

    }


    private void FixedUpdate()
    {
        stickToMe();
        //jeœli siê ma odbijaæ, wraca do gracza i to czyni :)
        if (isReflecting)
        {
            Vector3 difference = playerTransform.position - transform.position + offset;

            //sprawdz czy wystarczaj¹co blisko gracza
            if ((difference.x > 0.2f || difference.x < -0.2f) && (difference.y > 0.2f || difference.y < -0.2f))
            {
                rigidBody.velocity = new Vector3(difference.x * movementSpeed, difference.y * movementSpeed, 0);
                
            }
            else
            {
                //idz do pozycji gracza
                stickToMe();
            }

            //no te animacji nie dziala
            //AnimationUpdate(rigidBody.velocity);
            
        }

        AnimationUpdate(playerVelocity);
    }

    //przyklej siê do gracza
    private void stickToMe()
    {
        transform.position = playerTransform.position + offset;
        //transform.position.Set(13.71f, -0.88f, 0);
    }

}
