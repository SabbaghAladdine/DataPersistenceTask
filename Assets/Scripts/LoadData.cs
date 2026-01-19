using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadData : MonoBehaviour
{

    private Text text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = gameObject.GetComponent<Text>();
        if (!string.IsNullOrEmpty(ScenesManager.Instance.PlayerName))
        {
            Debug.Log(ScenesManager.Instance.PlayerName);
            text.text = ScenesManager.Instance.PlayerName;
        }
        else
        {
            Debug.Log("life Could be dream");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
