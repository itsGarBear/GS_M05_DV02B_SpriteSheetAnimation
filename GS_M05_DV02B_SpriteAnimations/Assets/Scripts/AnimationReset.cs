using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationReset : MonoBehaviour
{
    public GameObject[] goToAppear;
    public Animator animator;
    public ParticleSystem confCannon;

    public void AnimationComplete()
    {
        animator.SetTrigger("Done");
        animator.transform.localScale = new Vector3(1, 1, 1);
        foreach (GameObject go in goToAppear)
        {
            go.SetActive(true);
        }
    }

    public void FlipScale()
    {
        animator.transform.localScale = new Vector3(-1, 1, -1);
    }

    public void FireConfetti()
    {
        confCannon.Play();
    }
    public void StopConfetti()
    {
        confCannon.Stop();
    }
}
