using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    [SerializeField]
    private Transform _squareTransform;
    [SerializeField]
    private float speed = 1;

    private void Update()
    {
        // Mendeteksi input axis horizontal (A/D)
        float horizontalInput = Input.GetAxis("Horizontal");
        // Mendeteksi input axis vertical (W/S)
        float verticalInput = Input.GetAxis("Vertical");

        // Menggerakan object square
        // Sumbu x sesuai dengan input axis horizontal (A/D)
        // Sumbu y sesuai dengan input axis vertical (W/S)
        _squareTransform.Translate(horizontalInput * speed, verticalInput * speed, 0);
    }
}
