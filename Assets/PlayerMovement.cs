using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float power;
    public Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * power, ForceMode.Impulse);
    }


    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * 5f * Time.deltaTime);

    }
}
