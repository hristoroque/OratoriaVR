using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputControllerStrategy : MonoBehaviour
{
    protected CharacterController player;

    protected void Start()
    {
        player = GetComponent<CharacterController>();   
    }

    public abstract void Move(float x, float y);
}
