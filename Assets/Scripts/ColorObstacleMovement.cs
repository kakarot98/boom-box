using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObstacleMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float offCameraPointVerticalAxis;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveInVerticalAxis();
    }

    void MoveInVerticalAxis() {
        Vector2 temp = transform.position;
        temp.y += moveSpeed * Time.deltaTime;
        transform.position = temp;

        if (transform.position.y < offCameraPointVerticalAxis) {
            Destroy(gameObject);
        }
    }
}
