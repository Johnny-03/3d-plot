using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= 5;
}
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= 5;
    }
}
