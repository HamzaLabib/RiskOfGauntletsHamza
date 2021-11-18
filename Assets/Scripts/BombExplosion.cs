using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BombExplosion : MonoBehaviour
{
    public float timeToExplode = 5f;
    public Animator explosion;
    Animator effect;

    SpriteRenderer sr;
    bool isExploded = false;
    float explosionLifeTime = 1.10f;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (!isExploded)
            Explosion();
        if (isExploded)
            DestroyOurObjects();
    }

    void Explosion()
    {
        timeToExplode -= Time.deltaTime;
        if (timeToExplode < 0)
        {
            effect = Instantiate(explosion);
            effect.transform.position = this.transform.position;
            sr.enabled = false;
            isExploded = true;
        }
    }

    void DestroyOurObjects()
    {
        explosionLifeTime -= Time.deltaTime;
        if (explosionLifeTime < 0)
        {
            GameObject.Destroy(effect.gameObject);
            GameObject.Destroy(this.gameObject);
        }
    }
}
