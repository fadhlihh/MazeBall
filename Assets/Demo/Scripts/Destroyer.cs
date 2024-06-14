using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    private GameObject _destroyedObject;

    private void Start()
    {
        Destroy(_destroyedObject);
    }
}
