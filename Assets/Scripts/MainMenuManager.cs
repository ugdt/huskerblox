using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    private Button PlayButton;
    
    void Start()
    {
        PlayButton = GameObject.Find("PlayButton").GetComponent<Button>();
        PlayButton.onClick.AddListener(PlayGameScene);
    }

    void PlayGameScene()
    {
        SceneManager.LoadScene("gameScene");
    }
}
