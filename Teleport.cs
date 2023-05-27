using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    [Header("Время телепорта")] public int teleportTime = 3;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(DoTeleport(other.transform));
    }
    private void OnTriggerExit(Collider other)
    {
        StopAllCoroutines();
    }

    IEnumerator DoTeleport(Transform other)
    {
        yield return new WaitForSeconds(teleportTime);
        other.transform.position = teleportPoint.position;
    }
    
    
}
