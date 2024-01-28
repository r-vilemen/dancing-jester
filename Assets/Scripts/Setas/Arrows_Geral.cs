using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows_Geral : MonoBehaviour
{
    public Transform LeftArrow;
    public Transform UpArrow;
    public Transform RightArrow;
    public Transform DownArrow;
    public Vector3 upscale = new Vector3(1f, 1f, 1f);
    public Vector3 pressedscale = new Vector3(1.2f, 1.2f, 1.2f);

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftArrow.localScale = pressedscale;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            LeftArrow.localScale = upscale;
        }
        //
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            UpArrow.localScale = pressedscale;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            UpArrow.localScale = upscale;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightArrow.localScale = pressedscale;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            RightArrow.localScale = upscale;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            DownArrow.localScale = pressedscale;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            DownArrow.localScale = upscale;
        }
    }
}
