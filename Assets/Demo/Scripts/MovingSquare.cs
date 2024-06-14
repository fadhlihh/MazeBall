using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSquare : MonoBehaviour
{
    private Transform _squareTransform;

    private void Awake()
    {
        _squareTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        // Menentukan arah gerakan
        Vector3 movingDirection = new Vector3(1, 0, 0);
        // Menggeser object square
        _squareTransform.position = _squareTransform.position + movingDirection;

        // Menggeser object square
        // _squareTransform.Translate(1, 0, 0);

        // Memutar object square
        _squareTransform.Rotate(0, 0, 1);
    }
}
