using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    [SerializeField] private GameObject spike;
    [SerializeField] private float spikeCD;
    private bool stopped = false;

    void Start()
    {
        StartCoroutine(SpikeOn());
    }

    IEnumerator StopObject(){
        yield return new WaitForSeconds(GameManager.instance.stopSkillTime);
        stopped = false;
    }

    IEnumerator SpikeOn(){
        spike.SetActive(true);
        yield return new WaitForSeconds(spikeCD);
        if(stopped){
            StartCoroutine(StopObject());
            yield return new WaitUntil(() => !stopped);
        }
        StartCoroutine(SpikeOff());
        
    }

    IEnumerator SpikeOff(){
        spike.SetActive(false);
        yield return new WaitForSeconds(spikeCD);
        if(stopped){
            StartCoroutine(StopObject());
            yield return new WaitUntil(() => !stopped);
        }
        StartCoroutine(SpikeOn());
    }

    void OnMouseDown()
    {
        if(GameManager.instance.gotMagicBug && GameManager.instance.hasStopSkill){
            stopped = true;
            StartCoroutine(GameManager.instance.StopSkill());
            Debug.Log("Spike Kepencet");
        }
    }
}
