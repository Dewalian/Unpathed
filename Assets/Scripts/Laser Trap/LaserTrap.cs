using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    [SerializeField] private Transform nozzle;
    [SerializeField] private GameObject laser;
    [SerializeField] private LayerMask ignoreRaycast;
    [SerializeField] private float laserCD;
    private bool stopped;

    void Start()
    {
        ignoreRaycast = ~ignoreRaycast;
        laser.SetActive(false);
        StartCoroutine(LaserOn());
    }

    void Update(){
        RaycastHit hit;
        if(Physics.Raycast(nozzle.position, nozzle.TransformDirection(Vector3.up), out hit, Mathf.Infinity, ignoreRaycast)){
            Vector3 midPoint = nozzle.position + hit.transform.position;
            float laserLength = Vector3.Distance(nozzle.position, hit.transform.position);

            laser.transform.position = new Vector3(midPoint.x / 2, laser.transform.position.y, laser.transform.position.z);
            laser.transform.localScale = new Vector3(laser.transform.localScale.x, laserLength / 2, laser.transform.localScale.z);
        }
    }

     IEnumerator StopObject(){
        yield return new WaitForSeconds(GameManager.instance.stopSkillTime);
        stopped = false;
    }

    IEnumerator LaserOn(){
        laser.SetActive(true);
        yield return new WaitForSeconds(laserCD);
        if(stopped){
            StartCoroutine(StopObject());
            yield return new WaitUntil(() => !stopped);
        }
        StartCoroutine(LaserOff());
        
    }

    IEnumerator LaserOff(){
        laser.SetActive(false);
        yield return new WaitForSeconds(laserCD);
        if(stopped){
            StartCoroutine(StopObject());
            yield return new WaitUntil(() => !stopped);
        }
        StartCoroutine(LaserOn());
    }

    void OnMouseDown()
    {
        if(GameManager.instance.gotMagicBug && GameManager.instance.hasStopSkill){
            stopped = true;
            StartCoroutine(GameManager.instance.StopSkill());
            Debug.Log("Kepencet");
        }
    }
}
