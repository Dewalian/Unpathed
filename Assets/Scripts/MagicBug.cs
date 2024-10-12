using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBug : MonoBehaviour
{
    void Start()
    {
        if(GameManager.instance.gotMagicBug){
            gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            GameManager.instance.gotMagicBug = true;
            gameObject.SetActive(false);
        }
    }
}
