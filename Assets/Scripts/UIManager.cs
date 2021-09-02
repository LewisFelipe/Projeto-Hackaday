using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject configMenu;

    public bool canAnimate = false;

    private void Start()
    {
        configMenu = GameObject.FindGameObjectWithTag("Config");
    }

    public void GameStart()
    {
        SceneManager.LoadScene(2);
    }

    public void About()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ConfigWindowOpen()
    {
        configMenu.SetActive(true);
        canAnimate = true;
        
    }

    public void ConfigWindowClose()
    {
        configMenu.SetActive(false);
    }
}
