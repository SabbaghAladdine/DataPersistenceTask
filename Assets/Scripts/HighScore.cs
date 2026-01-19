using System.IO;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField] private Text highscoreText;
    [SerializeField] private GameObject manager;
    private SaveData oldData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        highscoreText = gameObject.GetComponent<Text>();
        LoadHighScore();
    }


    [System.Serializable]
    class SaveData
    {
        public string highScoreName;
        public int score;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.highScoreName = ScenesManager.Instance.PlayerName;
        int sccore = manager.GetComponent<MainManager>().m_Points;
        if (sccore>oldData.score)
        {
        data.score = sccore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        }
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            oldData = JsonUtility.FromJson<SaveData>(json);
            Debug.Log(oldData.score);
            highscoreText.text = "Best score : " + oldData.highScoreName + " : " + oldData.score;
        }
    }
}
