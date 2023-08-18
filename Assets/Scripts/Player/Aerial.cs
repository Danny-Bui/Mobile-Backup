using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Aerial : Character
{
    public Aerial(Rigidbody rb)
    {
        playerRb = rb;
    }

    public override void Process()
    {
        
    }

    public override void Move(Vector3 movement)
    {
        playerRb.velocity = playerRb.transform.rotation * movement * 5f + new Vector3(0f, playerRb.velocity.y, 0f);
    }

    public override void Jump()
    {
        playerRb.velocity = new Vector3(playerRb.velocity.x, 30f, playerRb.velocity.z);
        Debug.Log("Aerial Jump");
    }

    public override void Ability()
    {
        Debug.Log("Aerial Ability");
    }
}
