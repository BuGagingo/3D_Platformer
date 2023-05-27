using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public float speed = 5f;

    public float runSpeed = 9f;

    private float targetMovingSpeed;

    public bool canRun;

    public bool isRunning;

    public KeyCode runningkey = KeyCode.LeftShift;

    private Rigidbody pRB;
    
    // Start is called before the first frame update
    void Awake()
    {
        pRB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isRunning = canRun && Input.GetKey(runningkey);
        targetMovingSpeed = isRunning ? runSpeed : speed;
        pRB.velocity = transform.rotation *
                       new Vector3(Input.GetAxis("Horizontal") * targetMovingSpeed, pRB.velocity.y, Input.GetAxis("Vertical") * targetMovingSpeed);
        transform.Rotate(Vector3.up * (Input.GetAxis("Horizontal") * 3 * (100f *Time.deltaTime)), Space.Self);
    }
}
