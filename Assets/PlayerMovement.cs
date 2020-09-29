using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
        rb.AddForce(new Vector3(-2, -1, 0) * 20f, ForceMode.Impulse);
    }

    
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * 5f * Time.deltaTime);   
        
    }
}
