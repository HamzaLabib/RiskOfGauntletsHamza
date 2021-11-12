using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDropRandom : MonoBehaviour
{
    GameObject bomb;
    Transform bombPos;
    public GameObject toClone;
    public float cooling = 10f;

    void Awake()
    {
        bombPos = GetComponent<Transform>();
    }

    void Update()
    {
        Invoke("BombDrop", Random.Range(2, 10));
    }

    void BombDrop()
    {
        cooling -= Time.deltaTime;
        if (cooling < 0)
        {
            bomb = GameObject.Instantiate(toClone);
            bomb.transform.position = bombPos.position;
            cooling = 10f;
        }
    }

}
