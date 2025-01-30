using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelManager : MonoBehaviour
{
    public GameObject PlayMe;
    public GameObject Spawnpoint;

    void GoLeft()
    {
        Spawnpoint = GameObject.Find("SpawnPoint");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    void GoRight()
    {
        Spawnpoint = GameObject.Find("SpawnPoint1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        ActionEvents.Goingright += GoRight;
        ActionEvents.Goingleft += GoLeft;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayMe.transform.position = Spawnpoint.transform.position;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        ActionEvents.Goingright -= GoRight;
        ActionEvents.Goingleft -= GoLeft;
    }
}
