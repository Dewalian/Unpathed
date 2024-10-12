using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Hallway", menuName = "Scriptable Object/Hallway")]
public class HallwaySO : ScriptableObject
{
    public int hallwayExit;
    public string sceneEnter;
    public string spawnPointEnter;
}
