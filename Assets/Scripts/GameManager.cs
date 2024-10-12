using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField] private KeyCode restartKey;
    [SerializeField] private GameObject kelvinsBall;

    public GameObject[] spawnPoints;
    public string spawnPoint = "S0";
    public bool stageReseted = false;
    public Quaternion arenaRotation;
    public GameObject spawnPointAfterRotation;
    public bool gotMagicBug = false;
    public bool hasStopSkill = true;
    public float stopSkillCD = 5f;
    public float stopSkillTime = 3f;

    void Awake()
    {
        if(instance == null){
            instance = this;
        }else if(instance != this){
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode){
        hasStopSkill = true;
        if(GameObject.FindGameObjectWithTag("Player") == null){
            spawnPoints = GameObject.FindGameObjectsWithTag("Spawn Point");
            foreach (GameObject sp in spawnPoints){
                if(sp.name == spawnPoint){
                    Instantiate(kelvinsBall, sp.transform.position, Quaternion.identity);
                    spawnPointAfterRotation = sp;
                    break;
                }
            }
        }
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void Update()
    {
        if(Input.GetKeyDown(restartKey)){
            ResetStage();
        }
    }

    public void ResetStage(){
        spawnPoint = "S0";
        stageReseted = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void hallwayWarp(string stageName, string spawnPointEnter){
        spawnPoint = spawnPointEnter;
        SceneManager.LoadScene(stageName);
    }

    public IEnumerator StopSkill(){
        hasStopSkill = false;
        yield return new WaitForSeconds(stopSkillCD);
        hasStopSkill = true;
    }
}
