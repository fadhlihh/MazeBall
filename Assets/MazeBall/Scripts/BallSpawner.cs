using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Ball;

    private void Start()
    {
        // Mendapatkan transform object BallSpawner
        Transform spawnTransform = GetComponent<Transform>();
        Instantiate(Ball, spawnTransform.position, spawnTransform.rotation);
    }
}
