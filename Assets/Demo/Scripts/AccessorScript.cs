using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccessorScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _square;

    private void Start()
    {
        // Mendapatkan nama object square
        Debug.Log(_square.name);

        // Mendapatkan tag object square
        Debug.Log(_square.tag);

        // Mendapatkan layer object square
        Debug.Log(_square.layer);

        // Mendapatkan status aktif/non-aktif object square
        Debug.Log(_square.activeInHierarchy);



        // Mengaktifkan objek square
        _square.SetActive(true);

        // Non-aktifkan objek square
        _square.SetActive(false);
    }
}
