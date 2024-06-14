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
        _mazeTransform.Rotate(0, 0, -1);
    }
}
