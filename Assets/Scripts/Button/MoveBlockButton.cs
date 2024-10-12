using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockButton : MonoBehaviour
{
    [SerializeField] private GameObject[] moveBlock;
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") || other.CompareTag("Ball")){
            foreach(GameObject mb in moveBlock){
                mb.GetComponent<MoveBlockState>().block.GetComponent<BlockTrigger>().onTargetPosition = false;
                mb.GetComponent<MoveBlockState>().moveBlockSO.reachedTarget = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player") || other.CompareTag("Ball")){
            foreach(GameObject mb in moveBlock){
                mb.GetComponent<MoveBlockState>().block.GetComponent<BlockTrigger>().onTargetPosition = false;
                mb.GetComponent<MoveBlockState>().moveBlockSO.reachedTarget = false;
            }
        }
    }
}
