using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    [SerializeField] private GameObject[] doors;
    [SerializeField] private Material closedMat;
    [SerializeField] private Material openMat;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") || other.CompareTag("Ball")){
            foreach(GameObject d in doors){
                if(d.GetComponent<DoorState>().doorSO.doorStateSO){
                    d.GetComponent<DoorState>().doorSO.doorStateSO = false;
                }else{
                    d.GetComponent<DoorState>().doorSO.doorStateSO = true;
                }
            }
        }
    }
}
