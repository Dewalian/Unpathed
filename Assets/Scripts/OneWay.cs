using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWay : MonoBehaviour
{
    [SerializeField] private Collider oneWay;

    void Start()
    {
        oneWay.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            oneWay.enabled = true;
        }
    }
}
