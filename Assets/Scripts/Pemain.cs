using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemain : MonoBehaviour
{
    public Animator playerAnimator;
    public GameObject rawImageVideo;

    public void playerAttack ()
    {
        playerAnimator.SetTrigger("Go_Attack");
    }

    public void invokeVideo ()
    {
        Invoke ("playVideo", 2.0f);
    }

    public void playVideo ()
    {
        rawImageVideo.SetActive (true);
    }

}
