using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTrigger : MonoBehaviour
{
    public bool onTargetPosition = true;
    public bool stopped = false;
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("blockTrigger")){
            onTargetPosition = true;
        }
    }

    void OnMouseDown()
    {
        if(GameManager.instance.gotMagicBug && GameManager.instance.hasStopSkill){
            Debug.Log("kepencet");
            StartCoroutine(StopObject());
            StartCoroutine(GameManager.instance.StopSkill());
        }
    }

    IEnumerator StopObject(){
        stopped = true;
        yield return new WaitForSeconds(GameManager.instance.stopSkillTime);
        stopped = false;
    }
}
