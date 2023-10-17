using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimation : MonoBehaviour
{
    public AnimationClip aniclip;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.CrossFade(aniclip.name, 0);
        anim.SetLayerWeight(1, 1);
        anim.SetInteger("ActType", Random.Range(0, 4));
    }
}
