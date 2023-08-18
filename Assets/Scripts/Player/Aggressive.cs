using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Aggressive : Character
{
    float timer;
    bool moving = false;
    Quaternion rotation;

    public Aggressive(Rigidbody rb)
    {
        playerRb = rb;
        timer = 0f;
    }

    public override void Process()
    {

    }

    public override void Move(Vector3 movement)
    {
        playerRb.velocity = playerRb.transform.rotation * movement * 20f + new Vector3(0f, playerRb.velocity.y, 0f);
    }

    public override void Jump()
    {
        playerRb.velocity = new Vector3(playerRb.velocity.x, 5f, playerRb.velocity.z);
        Debug.Log("Aggressive Jump");
    }

    public override void Ability()
    {
        Debug.Log("Aggressive Ability");
    }
}
