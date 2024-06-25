using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Kode akan dijalankan ketika object mulai bertabrakan
        //  dengan object lain
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        // Kode akan dijalankan selama object bertabrakan
        //  dengan object lain
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        // Kode akan dijalankan ketika object selesai bertabrakan
        //  dengan object lain
        Debug.Log("Collision Exit");
    }
}
