using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance ;

    // Store the player name
    public string PlayerName ;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
    if (!string.IsNullOrEmpty(PlayerName))
        {
            Debug.Log(PlayerName);
        }

    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }


}
