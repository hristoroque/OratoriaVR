using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardControllerStrategy : InputControllerStrategy
{
    public override void Move(float x, float y)
    {
        player.Move(new Vector3(x,y,0));
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Move(x, y);
    }
}
