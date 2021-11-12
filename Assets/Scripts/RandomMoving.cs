using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoving : MonoBehaviour
{
    Rigidbody2D character;
    public float speed = 2f;
    public bool isHor;
    int lastDir;

    void Awake()
    {
        character = GetComponent<Rigidbody2D>();

        if (isHor)
            character.velocity = new Vector2(1, 0) * speed;
        else
            character.velocity = new Vector2(0, 1) * speed;
        
        lastDir = 1;
    }

    void ChangeDirVer()
    {
        if (lastDir < 0)
        {
            character.velocity = new Vector2(0, 1) * speed;
            lastDir = 1;
        }
        else
        {
            character.velocity = new Vector2(0, -1) * speed;
            lastDir = -1;
        }
    }

    void ChangeDirHor()
    {
        if (lastDir < 0)
        {
            character.velocity = new Vector2(1, 0) * speed;
            lastDir = 1;
        }
        else
        {
            character.velocity = new Vector2(-1, 0) * speed;
            lastDir = -1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isHor)
            ChangeDirHor();
        else
            ChangeDirVer();
    }
}
