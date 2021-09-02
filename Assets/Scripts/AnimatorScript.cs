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

    // Update is called once per frame
    void Update()
    {
        if (uiManager.canAnimate == true)
        {
            anim.Play("AnimConfig");
        }
        
    }
}
