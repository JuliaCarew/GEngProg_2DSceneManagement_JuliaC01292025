using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Set players position to the spawn point
        SetPlayerToSpawn(spawnPointName);
        // Unsubscribe from callback to avoid repeated triggers
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void SetPlayerToSpawn(string spawnPointName)
    {
        // Find the spawn point
        GameObject spawnPoint = GameObject.Find(spawnPointName);

        // If the spawn point is found
        if (spawnPoint != null)
        {
            // Find the player
            GameObject player = GameObject.Find("Player");
            // If the player is found
            if (player != null)
            {
                // Set the players position to the spawn point
                player.transform.position = spawnPoint.transform.position;
            }
        }
    }

    public void LoadSceneWithSpawnPoint(string sceneName, string spawnPoint)
    {
        spawnPointName = spawnPoint;
        // Set players position to the spawn point
        SceneManager.LoadScene(sceneName);
        // Load the scene
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
}
