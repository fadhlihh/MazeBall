using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMovement : MonoBehaviour
{
    private Transform _mazeTransform;

    private void Awake()
    {
        _mazeTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        // bool isHoldRightInput = Input.GetKey(KeyCode.D);
        // if (isHoldRightInput)
        // {
        //     // Rotate Clockwise
        //     _mazeTransform.Rotate(0, 0, -1);
        // }
        // bool isHoldLeftInput = Input.GetKey(KeyCode.A);
        // if (isHoldLeftInput)
        // {
        //     // Rotate Anti-Clockwise
        //     _mazeTransform.Rotate(0, 0, 1);
        // }

        float horizontalInput = Input.GetAxis("Horizontal");
        // Memutar dengan arah sesuai horizontal input
        _mazeTransform.Rotate(0, 0, -horizontalInput);

    }
}
