using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TemporarySolutionForSites : MonoBehaviour
{
    public Text trueSite, fakeSite, zoomSite, trueHeader, fakeHeader, zoomHeader, trueNews, fakeNews, ZoomNews;
    void Start()
    {
        trueSite.text = "";
        trueHeader.text = "";
        trueNews.text = "";

        fakeSite.text = "";
        fakeHeader.text = "";
        fakeNews.text = "";
    }
}
