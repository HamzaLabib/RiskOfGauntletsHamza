using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCreation : MonoBehaviour
{
    public GameObject toClone;
    public Transform bombPos;
    GameObject bomb;
    SpriteRenderer flipping;

    bool isCloned = false;

    private void Awake()
    {
        flipping = this.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        FlippingManage(flipping.flipX);
        if (isCloned)
            BombColliderManage();
        if (!bomb)
            isCloned = false;
    }

    void FlippingManage(bool isFacingLeft)
    {
        if (isFacingLeft)
            bombPos.localPosition = new Vector3(-0.5f, bombPos.localPosition.y, 0);
        if (!isFacingLeft)
            bombPos.localPosition = new Vector3(Mathf.Abs(bombPos.localPosition.x), bombPos.localPosition.y, 0);
    }

    public void BombCreator()
    {
        if (!isCloned)
        {
            isCloned = true;
            bomb = GameObject.Instantiate(toClone);
            bomb.GetComponent<Collider2D>().enabled = false;
            bomb.transform.position = bombPos.position;
        }
    }

    void BombColliderManage()
    {
        if (bomb)
            bomb.GetComponent<Collider2D>().enabled = true;
    }
}
