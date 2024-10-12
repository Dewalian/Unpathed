using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] private float springPower = 1000f;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            other.attachedRigidbody.AddForce(transform.up * springPower);
            Debug.Log("spring");
        }
    }
}
