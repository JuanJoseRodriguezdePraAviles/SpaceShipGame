using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float speedRot;

    private void Update()
    {
        if(Time.timeScale == 0)
        {
            return;
        }
        GetComponent<Rigidbody>().AddTorque(transform.up * speedRot * Input.GetAxis("Horizontal"), ForceMode.VelocityChange);

        GetComponent<Rigidbody>().AddTorque(transform.right * -speedRot * Input.GetAxis("Vertical"), ForceMode.VelocityChange);

        GetComponent<Rigidbody>().AddTorque(transform.forward * -speedRot * Input.GetAxis("ForwardRotation"), ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }
        




    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3();
            /*transform.forward * speed * Input.GetAxis("Vertical") +
            transform.right * speed * Input.GetAxis("Horizontal");*/

    }
}
