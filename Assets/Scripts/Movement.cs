using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void Move(Vector2 move)
    {
        Vector2 pos = transform.position;
        pos += new Vector2(move.x, move.y) * Time.deltaTime;
        transform.position = pos;
    }
}
