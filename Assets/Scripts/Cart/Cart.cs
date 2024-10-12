using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{
    [SerializeField] private float cartSpeed = 5f;
    [SerializeField] private Transform target;
    [SerializeField] private Transform trigger1;
    [SerializeField] private Transform trigger2;
    private bool stopped = false;

    void Start()
    {
        target.position = trigger2.position;
    }

    void Update()
    {
        if(!stopped){
            MoveCart();
        }
    }

    void MoveCart(){
        transform.position = Vector3.MoveTowards(transform.position, target.position, cartSpeed * Time.deltaTime);
    }

    IEnumerator StopObject(){
        stopped = true;
        yield return new WaitForSeconds(GameManager.instance.stopSkillTime);
        stopped = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("cartTrigger")){
            if(target.position == trigger1.position){
                target.position = trigger2.position;
            }else{
                target.position = trigger1.position;
            }
        }
    }

    void OnMouseDown()
    {
        if(GameManager.instance.gotMagicBug && GameManager.instance.hasStopSkill){
            StartCoroutine(StopObject());
            StartCoroutine(GameManager.instance.StopSkill());
            Debug.Log("Kepencet");
        }
    }
}
