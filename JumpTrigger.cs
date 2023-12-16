using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public float jumpFactor = 2.5f;

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }
    private void OnTriggerExit(Collider other)
    {
       other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    }
}
