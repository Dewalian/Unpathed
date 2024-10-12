using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorState : MonoBehaviour
{
    public DoorSO doorSO;
    [SerializeField] private Material closedMat;
    [SerializeField] private Material openMat;


    void Update()
    {
        if(doorSO.doorStateSO){
            gameObject.GetComponent<Collider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().material = closedMat;
        }else{
            gameObject.GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().material = openMat;
        }
    }
}

