using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public Vector2 turn;
    public float sensititvity = .25f;
    void Update()
    {
        turn.y += Input.GetAxis("Mouse Y") * sensititvity;
        turn.x += Input.GetAxis("Mouse X") * sensititvity;
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
