using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    void Update()
    {
 
        //Если игрок кликает левой кнопкой мыши, то создаётся огненный шар
        if (Input.GetMouseButton(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
 
    }
}
