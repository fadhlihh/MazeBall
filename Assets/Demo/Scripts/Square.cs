using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    private void Start()
    {
        // Mendapatkan nama object square
        Debug.Log(gameObject.name);

        // Mendapatkan tag object square
        Debug.Log(gameObject.tag);

        // Mendapatkan layer object square
        Debug.Log(gameObject.layer);

        // Mendapatkan status aktif/non-aktif object square
        Debug.Log(gameObject.activeInHierarchy);



        // Mengaktifkan objek square
        gameObject.SetActive(true);

        // Non-aktifkan objek square
        gameObject.SetActive(false);
    }
}
