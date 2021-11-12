using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombExplosion : MonoBehaviour
{
    public float timeToExplode = 5f;
    public Animator explosionAnim;
    bool isExplode = false;

    public void Explosion()
    {
        if (!isExplode)
        {
            timeToExplode -= Time.deltaTime;
            if (timeToExplode < 0)
            {
                explosionAnim.enabled = true;
                timeToExplode = 5f;
            }
        }
    }
}
