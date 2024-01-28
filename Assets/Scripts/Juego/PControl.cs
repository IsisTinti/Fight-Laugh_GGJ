using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PControl : MonoBehaviour
{
    PMovement _movement;

    public PControl(PMovement movement)
    {
        _movement = movement;
    }

    public void ArtificialUpdate()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");

        if (h != 0 || v != 0)
        {
            _movement.Move(v, h);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _movement.Jump();
        }
    }
}