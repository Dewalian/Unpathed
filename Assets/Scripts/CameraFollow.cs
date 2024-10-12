using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform arena;
    void Update()
    {
        transform.position = new Vector3(arena.position.x, arena.position.y, transform.position.z);
    }
}