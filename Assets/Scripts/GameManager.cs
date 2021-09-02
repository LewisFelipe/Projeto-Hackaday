using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int maxTime;
    int timerInteger = 0, score = 0, selected = 0;
    float timer;
    public Text lblTimer, lblScore;
    public Image[] imageHolders;
    public Button[] button;
    public Sprite[] images;

    public GameObject zoom;

    public Text trueSite, fakeSite, zoomSite, trueHeader, fakeHeader, zoomHeader, trueNews, fakeNews, ZoomNews; //Temporary

    void TickTimer()
    {
        if(timer > 0)
        {
            timerInteger = (int)timer;
            lblTimer.text = timerInteger.ToString();
            timer -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Game Over");
        }
    }

    void ModifyScore()
    {
        lblScore.text = ("Score: " + score.ToString());
    }
    
    void StartGame()
    {
        imageHolders[0].sprite = images[0];
        imageHolders[1].sprite = images[0];

        imageHolders[2].sprite = images[0];

        trueSite.text = "https://g1.globo.com";
        trueHeader.text = "";
        trueNews.text = "";

        fakeSite.text = "https://g1.globo.news";
        fakeHeader.text = "";
        fakeNews.text = "";
    }

    public void ReportTemporary()
    {
        timer = maxTime;
        score += 10;
        ModifyScore();

        zoom.SetActive(false);

        if(score == 10)
        {
            imageHolders[0].sprite = images[0];
            imageHolders[1].sprite = images[0];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "(Ministério da Saúde)";

            fakeSite.text = "https://g1.globo.com";
            fakeHeader.text = "";
            fakeNews.text = "(Instituto Pamonha)";
        }
        else if(score == 20)
        {
            imageHolders[0].sprite = images[1];
            imageHolders[1].sprite = images[1];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "";

            fakeSite.text = "https://g1.globo.news";
            fakeHeader.text = "";
            fakeNews.text = "";
        }
        else if(score == 30)
        {
            imageHolders[0].sprite = images[2];
            imageHolders[1].sprite = images[2];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "";

            fakeSite.text = "https://g1.globo.news";
            fakeHeader.text = "";
            fakeNews.text = "";
        }
        else if(score == 40)
        {
            imageHolders[0].sprite = images[2];
            imageHolders[1].sprite = images[3];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "";

            fakeSite.text = "https://g1.globo.news";
            fakeHeader.text = "";
            fakeNews.text = "";
        }
        else if(score == 50)
        {
            imageHolders[0].sprite = images[0];
            imageHolders[1].sprite = images[0];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "";

            fakeSite.text = "https://g1.globo.news";
            fakeHeader.text = "";
            fakeNews.text = "";
        }
        else if(score == 60)
        {
            imageHolders[0].sprite = images[0];
            imageHolders[1].sprite = images[0];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "";

            fakeSite.text = "https://g1.globo.news";
            fakeHeader.text = "";
            fakeNews.text = "";
        }
        else if(score == 70)
        {
            imageHolders[0].sprite = images[0];
            imageHolders[1].sprite = images[0];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "";

            fakeSite.text = "https://g1.globo.news";
            fakeHeader.text = "";
            fakeNews.text = "";
        }
        else if(score == 80)
        {
            imageHolders[0].sprite = images[0];
            imageHolders[1].sprite = images[0];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "";

            fakeSite.text = "https://g1.globo.news";
            fakeHeader.text = "";
            fakeNews.text = "";
        }
    }

    public void BackButton()
    {
        button[selected].Select();
        zoom.SetActive(false);
    }

    public void Image1Pressed()
    {
        selected = 0;

        imageHolders[2].sprite = imageHolders[0].sprite;

        zoomSite.text = trueSite.text;
        zoomHeader.text = trueHeader.text;
        ZoomNews.text = trueNews.text;

        zoom.SetActive(true);
    }

    public void Image2Pressed()
    {
        selected = 1;

        imageHolders[2].sprite = imageHolders[1].sprite;

        zoomSite.text = fakeSite.text;
        zoomHeader.text = fakeHeader.text;
        ZoomNews.text = fakeNews.text;

        zoom.SetActive(true);
    }

    void Start()
    {
        timer = maxTime;

        StartGame();
    }

    void Update()
    {
        TickTimer();

        if(zoom.activeSelf)
        {
            button[2].interactable = true;
        }
        else
        {
            button[2].interactable = false;
        }
    }
}