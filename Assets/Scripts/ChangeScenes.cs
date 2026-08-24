using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScenes : MonoBehaviour
{
    private Button sceneOneButton;

    private void Start()
    {
        sceneOneButton = GetComponent<Button>();
        sceneOneButton.onClick.AddListener(OnSceneOneButtonClicked);
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
