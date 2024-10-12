using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : MonoBehaviour
{
    [SerializeField] private HallwaySO hallway;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            GameManager.instance.hallwayWarp(hallway.sceneEnter, hallway.spawnPointEnter);
        }
    }
}
