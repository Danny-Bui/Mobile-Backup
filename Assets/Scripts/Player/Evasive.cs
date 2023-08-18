using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evasive : Character
{
    public Evasive(Rigidbody rb)
    {
        playerRb = rb;
    }

    public override void Process()
    {

    }

    public override void Move(Vector3 movement)
    {
        playerRb.velocity = playerRb.transform.rotation * movement * 10f + new Vector3(0f, playerRb.velocity.y, 0f);
    }

    public override void Jump()
    {
        playerRb.velocity = new Vector3(playerRb.velocity.x, 15f, playerRb.velocity.z);
        Debug.Log("Evasive Jump");
    }

    public override void Ability()
    {
        Debug.Log("Evasive Ability");
    }
}
