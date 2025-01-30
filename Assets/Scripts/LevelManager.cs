using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LevelManager : MonoBehaviour
{
    public GameObject PlayMe;
    public GameObject Spawnpoint;

    private static string lastDirection;

    void GoLeft()
    {
        lastDirection = "Left";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    void GoRight()
    {
        lastDirection = "Right";
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
        if (lastDirection == "Left")
        {
            Spawnpoint = GameObject.Find("SpawnPoint"); // Left entry
        }
        else
        {
            Spawnpoint = GameObject.Find("SpawnPoint1"); // Right entry
        }


        PlayMe.transform.position = Spawnpoint.transform.position;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        ActionEvents.Goingright -= GoRight;
        ActionEvents.Goingleft -= GoLeft;
    }
}
