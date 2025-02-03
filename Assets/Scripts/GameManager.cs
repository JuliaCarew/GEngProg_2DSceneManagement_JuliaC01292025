using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public LevelManager levelManager;
    public PlayerMovement player;

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
