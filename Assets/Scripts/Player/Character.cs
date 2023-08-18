using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : Equipment
{
    protected Rigidbody playerRb;
    protected Vector3 savedDirection;
    protected Equipment currentEquipment;

    public Equipment GetEquipment()
    {
        return currentEquipment;
    }

    public void Equip()
    {

    }

    public abstract void Process();
    public abstract void Move(Vector3 movement);
    public abstract void Jump();
    public abstract void Ability();
}
