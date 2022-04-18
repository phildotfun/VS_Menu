using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleFadeIn : MonoBehaviour
{
    public GameObject camera;
    public Animator cameraAnimation;

    private void Awake()
    {
        cameraAnimation = camera.GetComponent<Animator>();
        cameraAnimation.enabled = false;
    }

    public void OnButtonClick()
    {
        cameraAnimation.enabled = true;
    }
}
