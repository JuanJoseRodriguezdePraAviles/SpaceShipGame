using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField]
    float o2Max;

    [SerializeField]
    GameObject sliderO2;

    private void Start()
    {
        sliderO2.GetComponent<Slider>().value = 1 - o2Max;
    }

    private void FixedUpdate()
    {
        sliderO2.GetComponent<Slider>().value += 0.000067f;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            sliderO2.GetComponent<Slider>().value += 0.1f;
        }
    }
}
