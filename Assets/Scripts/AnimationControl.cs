using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator anim;

    public void AnimChanging(Vector2 getAnim)
    {
        Vector2 currentAnim = new Vector2(anim.GetInteger("xDir"), anim.GetInteger("yDir"));
        currentAnim = getAnim;
        anim.SetInteger("xDir", (int)currentAnim.x);
        anim.SetInteger("yDir", (int)currentAnim.y);
        //currentAnim = new Vector2 (anim.GetInteger("xDir"), anim.GetInteger("yDir"));
    }
}
