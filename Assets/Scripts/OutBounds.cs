using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutBounds : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            GameManager.instance.ResetStage();
        }
    }
}
