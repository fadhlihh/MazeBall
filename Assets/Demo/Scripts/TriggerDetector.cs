using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kode akan dijalankan ketika ada object lain masuk ke dalam trigger
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // Kode akan dijalankan selama ada object lain di dalam trigger
        Debug.Log("Trigger Stay");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Kode akan dijalankan ketika object lain keluar trigger
        Debug.Log("Trigger Exit");
    }
}
