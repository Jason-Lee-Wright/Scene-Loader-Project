using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelManager : MonoBehaviour
{
    public GameObject PlayMe;
    public GameObject Spawnpoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(1);
            //FindSpawn();
            //Spawnpoint = GameObject.Find("SpawnpointGamePlay");
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(0);
            //FindSpawn();
            //Spawnpoint = GameObject.Find("SpawnpointMenu");
        }
    }

    /*void FindSpawn()
    {
        Spawnpoint = GameObject.Find("Spawnpoint");
        PlayMe.transform.position = Spawnpoint.transform.position;
    }*/

    // called first
    void Awake()
    {
        Debug.Log("Awake");
    }

    // called second
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called third
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    // called fourth
    void Start()
    {
        Debug.Log("Start");
    }

    // called when the game is terminated
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
