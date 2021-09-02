using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Sites : MonoBehaviour
{
    public const int PAIRS = 2;
    private static Sites Instance;
    public static Sites Singleton
    {
        get
        {
            if(Instance == null)
                Instance = FindObjectOfType<Sites>();
            return Instance;
        }
    }
    public int quantitieImagePairs;
    public Sprite[] images;
}
