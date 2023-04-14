using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float SpeedFactor;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed *= SpeedFactor;
        other.GetComponent<FirstPersonMovement>().runSpeed *= SpeedFactor;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed /= SpeedFactor;
        other.GetComponent<FirstPersonMovement>().runSpeed /= SpeedFactor;
    }
}
