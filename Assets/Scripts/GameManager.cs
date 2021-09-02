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

    public GameObject[] zoom;

    public Animator anim;
    public GameObject answerObject;
    int whitchZoomed = 0;
    public Text trueSite, fakeSite, trueHeader, fakeHeader, trueNews, fakeNews, zoomSite1, zoomSite2, zoomSite3, zoomHeader1, zoomHeader2, zoomHeader3, zoomNews1, zoomNews2, zoomNews3; //Temporary

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
        lblScore.text = ("Fakes: " + score.ToString());
    }
    
    void StartGame()
    {
        imageHolders[0].sprite = images[0];
        imageHolders[1].sprite = images[0];

        imageHolders[2].sprite = images[0];

        trueSite.text = "https://g1.globo.com";
        trueHeader.text = "É #FAKE que substâncias presentes em vacinas para a Covid-19 podem causar Alzheimer e fibromialgia";
        trueNews.text = "Circula nas redes sociais um vídeo de um homem, que veste um jaleco de profissional de saúde, que afirma que os adjuvantes de vacinas para a Covid-19 podem causar Alzheimer e fibromialgia.";

        fakeSite.text = "https://g1.gl00bo.news";
        fakeHeader.text = "Substâncias presentes em vacinas para a Covid-19 podem causar Alzheimer e fibromialgia.";
        fakeNews.text = "Circula nas redes sociais um vídeo de um homem, que veste um jaleco de profissional de saúde, que afirma que os adjuvantes de vacinas para a Covid-19 podem causar Alzheimer e fibromialgia.";
    }

    public void ReportTemporary()
    {
        timer = maxTime;
        score += 10;
        ModifyScore();

        foreach(GameObject element in zoom)
        {
            element.SetActive(false);
        }

        if(score == 10)
        {   
            anim.Play("AnswerAnim");

            whitchZoomed = 1;

            imageHolders[0].sprite = images[2];
            imageHolders[1].sprite = images[2];

            trueSite.text = "https://noticias.uol.com.br";
            trueHeader.text = "Aceitação da vacina é insuficiente!";
            trueNews.text = "Brasileiros confiam na vacina, mas aceitação é insuficiente para imunidade(Ministério da Saúde).";

            fakeSite.text = "https://noticias.uol.com.br";
            fakeHeader.text = "Aceitação da vacina está em alta!";
            fakeNews.text = "Brasileiros confiam na vacina e a aceitação é mais que suficiente para imunidade(Instituto Pamonha).";
        }
        else if(score == 20)
        {
            anim.Play("AnswerAnim");

            whitchZoomed = 2;

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
            anim.Play("AnswerAnim");

            whitchZoomed = 1;

            imageHolders[0].sprite = images[2];
            imageHolders[1].sprite = images[2];

            trueSite.text = "https://cnnbrasil.com";
            trueHeader.text = "Covid-19: agosto foi o mês com mortes de Brasil";
            trueNews.text = "Com o avanço da vacinação, as mortes diminuiram, ou seja, não tome vacina!";

            fakeSite.text = "https://cnnbrasil.com.br";
            fakeHeader.text = "Covid-19: agosto foi o mês com o menor número de casos e mortes no Brasil!";
            fakeNews.text = "Segundo levantamento da CNN, foram 24.043 mortes e 859.015 infecções confirmadas pela doença no país no oitavo mês do ano.";
        }
        else if(score == 40)
        {
            anim.Play("WrongAnswer");

            whitchZoomed = 2;

            imageHolders[0].sprite = images[1];
            imageHolders[1].sprite = images[1];

            trueSite.text = "https://g1.globo.com";
            trueHeader.text = "";
            trueNews.text = "";

            fakeSite.text = "https://g1.globo.news";
            fakeHeader.text = "";
            fakeNews.text = "";
        }
        else if(score == 50)
        {

            imageHolders[0].sprite = images[3];
            imageHolders[1].sprite = images[3];

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
        foreach(GameObject element in zoom)
        {
            element.SetActive(false);
        }
    }

    public void Image1Pressed()
    {
        selected = 0;

        imageHolders[2].sprite = imageHolders[0].sprite;

        zoomSite1.text = trueSite.text;
        zoomHeader1.text = trueHeader.text;
        zoomNews1.text = trueNews.text;

        zoomSite2.text = trueSite.text;
        zoomHeader2.text = trueHeader.text;
        zoomNews2.text = trueNews.text;

        zoomSite3.text = trueSite.text;
        zoomHeader3.text = trueHeader.text;
        zoomNews3.text = trueNews.text;

        zoom[whitchZoomed].SetActive(true);
    }

    public void Image2Pressed()
    {
        selected = 1;

        imageHolders[2].sprite = imageHolders[1].sprite;

        zoomSite1.text = fakeSite.text;
        zoomHeader1.text = fakeHeader.text;
        zoomNews1.text = fakeNews.text;

        zoomSite2.text = fakeSite.text;
        zoomHeader2.text = fakeHeader.text;
        zoomNews2.text = fakeNews.text;

        zoomSite3.text = fakeSite.text;
        zoomHeader3.text = fakeHeader.text;
        zoomNews3.text = fakeNews.text;

        zoom[whitchZoomed].SetActive(true);
    }

    void Start()
    {
        timer = maxTime;

        StartGame();
    }

    void Update()
    {
        TickTimer();

        if(zoom[0].activeSelf || zoom[1].activeSelf || zoom[2].activeSelf)
        {
            button[2].interactable = true;
        }
        else
        {
            button[2].interactable = false;
        }
    }
}