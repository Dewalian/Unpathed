using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
public class ArenaController : MonoBehaviour
{
    [SerializeField] private KeyCode rotateLeftKey;
    [SerializeField] private KeyCode rotateRightKey;

    [SerializeField] private int rotateSpeed;
    [SerializeField] private Transform kelvinsBall;
    [SerializeField] private Transform mainCamera;
    [SerializeField] private GameObject[] allDoorState;
    private bool posChanged = false;

    void Start()
    {
        kelvinsBall = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if(GameManager.instance.stageReseted){
            transform.rotation = Quaternion.identity;
            foreach(GameObject d in allDoorState){
                d.GetComponent<DoorState>().doorSO.doorStateSO = d.GetComponent<DoorState>().doorSO.defaultDoorStateSO;
            }
            GameManager.instance.stageReseted = false;
        }else{
            transform.rotation = GameManager.instance.arenaRotation;
        }
    }

    void Update()
    {
        if(!posChanged){
            kelvinsBall.position = GameManager.instance.spawnPointAfterRotation.transform.position;
            posChanged = true;
        }
        if(Input.GetKeyDown(rotateLeftKey)){
            transform.RotateAround(kelvinsBall.position, new Vector3(0, 0, 1), rotateSpeed);
        }else if(Input.GetKeyDown(rotateRightKey)){
            transform.RotateAround(kelvinsBall.position, new Vector3(0, 0, -1), rotateSpeed);
        }
        mainCamera.position = new Vector3(transform.position.x, transform.position.y, mainCamera.position.z);
        GameManager.instance.arenaRotation = transform.rotation;
    }

    
}
