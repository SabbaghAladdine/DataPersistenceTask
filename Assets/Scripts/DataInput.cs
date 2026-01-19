using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataInput : MonoBehaviour
{
    private TMP_InputField nameField;

    void Start()
    {
        nameField = gameObject.GetComponent<TMP_InputField>();
        
    }

    public void SaveInput()
    {
        Debug.Log(nameField.text);
        ScenesManager.Instance.PlayerName = nameField.text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
