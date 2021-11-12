using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControllerEvent : MonoBehaviour
{
    public UnityEvent<Vector2> directions;
    public UnityEvent cloneBomb;

    public KeyCode upKey = KeyCode.UpArrow;
    public KeyCode downKey = KeyCode.DownArrow;
    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode bombKey = KeyCode.Space;


    void Update()
    {
        GetKey();
    }

    void GetKey()
    {
        Vector2 toSend = new Vector2();

        if (Input.GetKey(rightKey))
            toSend.x = 1;
        if (Input.GetKey(leftKey))
            toSend.x = -1;
        if (Input.GetKey(upKey))
            toSend.y = 1;
        if (Input.GetKey(downKey))
            toSend.y = -1;
        if (Input.GetKeyUp(bombKey))
            cloneBomb.Invoke();

        directions.Invoke(toSend);
    }
}
