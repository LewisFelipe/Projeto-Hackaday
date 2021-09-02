using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameObject configMenu, infoMenu;

    public bool canAnimateConfig = false, canAnimateAbout = false;

    private void Start()
    {
        configMenu = GameObject.FindGameObjectWithTag("Config");
        configMenu.SetActive(false);

        infoMenu = GameObject.FindGameObjectWithTag("Info");
        infoMenu.SetActive(false);
    }

    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }

    public void About()
    {
        infoMenu.SetActive(true);
        canAnimateAbout = true;
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ConfigWindowOpen()
    {
        configMenu.SetActive(true);
        canAnimateConfig = true;
    }

    public void ConfigWindowClose()
    {
        configMenu.SetActive(false);
    }
}
