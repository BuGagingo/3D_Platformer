using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    [Header("Время для телепортации")]
    public float timeToTeleport = 2.5f;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Telepotation(other));
    }

    private void OnTriggerExit(Collider other)
    {
         StopAllCoroutines();
    }
    IEnumerator Telepotation(Collider other)
    {
        yield return new WaitForSeconds(timeToTeleport);
        other.transform.position = teleportPoint.position;
    }


}
