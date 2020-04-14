using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    private bool isSwiping = false;
    Vector2 mousePos, mouseStartPos, playerPos;
    public float rightBoundaryLimit, leftBoundaryLimit;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        GetInput();
        MovePlayer();
    }

    private void GetInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isSwiping = true; //true unti mousebutton is lifted
            mouseStartPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y)); //the position where the mousebutton is clicked first
            playerPos = transform.position;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isSwiping = false;
        }
    }

    void MovePlayer()
    {
        if (isSwiping)
        {
            mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            transform.position = new Vector2(playerPos.x + (mousePos.x - mouseStartPos.x), transform.position.y);
        }
        if (transform.position.x >= rightBoundaryLimit)
        {
            transform.position = new Vector2(rightBoundaryLimit, transform.position.y);
        }
        if (transform.position.x <= leftBoundaryLimit)
        {
            transform.position = new Vector2(leftBoundaryLimit, transform.position.y);
        }
    }
}
