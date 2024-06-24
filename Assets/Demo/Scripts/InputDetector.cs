using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetector : MonoBehaviour
{
    private void Update()
    {
        // Mendeteksi apakah input spasi ditekan
        bool isPressSpace = Input.GetKeyUp(KeyCode.Space);
        if (isPressSpace)
        {
            // Kode yang dilakukan ketika input spasi ditekan
            Debug.Log("Input Mulai Ditekan");
        }

        // Mendeteksi apakah input spasi ditekan dan ditahan
        bool isHoldSpace = Input.GetKey(KeyCode.Space);
        if (isHoldSpace)
        {
            // Kode yang dilakukan ketika input spasi ditekan dan ditahan
            Debug.Log("Menekan Input");
        }

        // Mendeteksi apakah input spasi dilepas
        bool isReleaseSpace = Input.GetKeyUp(KeyCode.Space);
        if (isReleaseSpace)
        {
            // Kode yang dilakukan ketika input spasi dilepas
            Debug.Log("Melepas Input");
        }

        // Mendeteksi input axis horizontal
        float horizontalInput = Input.GetAxis("Horizontal");

        // Memunculkan nilai input axis horizontal
        // Bernilai 0 jika input horizontal tidak ditekan
        // Bernilai 1 jika input horizontal positif ditekan
        // Bernilai -1 jika input horizontal negatif ditekan
        Debug.Log(horizontalInput);
    }
}
