using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDropRandom : MonoBehaviour
{
    GameObject bomb;
    Transform bombPos;
    public GameObject toClone;
    public float cooling = 10f;
    
    bool isDropped = false;
    float bombcolliderOn = 0.5f;

    void Awake()
    {
        bombPos = GetComponent<Transform>();
    }

    void Update()
    {
        Invoke("BombDrop", Random.Range(2, 10));
        if (isDropped)
            BombColliderManage();
        if (!bomb)
            isDropped = false;
    }

    void BombDrop()
    {
        cooling -= Time.deltaTime;
        if (cooling < 0)
        {
            bomb = GameObject.Instantiate(toClone);
            bomb.GetComponent<Collider2D>().enabled = false;
            bomb.transform.position = bombPos.position;
            isDropped = true;
            cooling = 10f;
        }
    }

    void BombColliderManage()
    {
        bombcolliderOn -= Time.deltaTime;
        if (bombcolliderOn < 0)
            bomb.GetComponent<Collider2D>().enabled = true;
    }
}
