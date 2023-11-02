using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float LaunchForce;
    public float fowardForce;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * LaunchForce + Vector3.forward * fowardForce , ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
