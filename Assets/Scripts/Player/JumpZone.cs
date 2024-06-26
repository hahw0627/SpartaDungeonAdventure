using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpZone : MonoBehaviour
{
    public float jumpForce = 50f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if(rb != null )
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }    
    }
}
