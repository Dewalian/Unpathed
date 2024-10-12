using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlockState : MonoBehaviour
{
    public MoveBlockSO moveBlockSO;
    public GameObject block;
    public BlockTrigger blockScript;
    [SerializeField] private Transform trigger1;
    [SerializeField] private Transform trigger2;
    [SerializeField] private float moveBlockSpeed;

    void Update()
    {
        if(moveBlockSO.reachedTarget && !blockScript.onTargetPosition && !blockScript.stopped){
            block.transform.position = Vector3.MoveTowards(block.transform.position, trigger2.position, moveBlockSpeed * Time.deltaTime);
        }else if(!moveBlockSO.reachedTarget && !blockScript.onTargetPosition && !blockScript.stopped){
            block.transform.position = Vector3.MoveTowards(block.transform.position, trigger1.position, moveBlockSpeed * Time.deltaTime);
        }
    }
}
