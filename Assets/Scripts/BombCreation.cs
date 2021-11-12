using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCreation : MonoBehaviour
{
    public GameObject toClone;
    public Transform bombPos;
    GameObject bomb;

    bool isCloned = false;

    public void BombCreator()
    {
        if (!isCloned)
        {
            isCloned = true;
            bomb = GameObject.Instantiate(toClone);
            bomb.transform.position = bombPos.position;
        }
    }
}
