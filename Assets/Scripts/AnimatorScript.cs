using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    Animator anim;

    [SerializeField]
    UIManager uiManager;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (uiManager.canAnimateConfig)
        {
            anim.Play("AnimConfig");
        }
        else if(uiManager.canAnimateAbout)
        {
            anim.Play("AnimAbout");
        }
    }
}
