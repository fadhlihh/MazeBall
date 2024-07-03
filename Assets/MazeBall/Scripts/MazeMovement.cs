using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMovement : MonoBehaviour
{
    private Transform _mazeTransform;
    private float direction = 0;
    private float speed = 20;

    private void Awake()
    {
        _mazeTransform = GetComponent<Transform>();
    }

    public void RotateRight()
    {
        direction = -1;
    }

    public void RotateLeft()
    {
        direction = 1;
    }

    public void ResetRotation()
    {
        direction = 0;
    }

    private void Update()
    {
        _mazeTransform.Rotate(0, 0, direction * speed * Time.deltaTime);
    }
}
