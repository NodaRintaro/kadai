using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject _coin;
    Vector3 _insPos;
    void Start()
    {
        for (int i = 0; i < 80; i += 5)
        {
            float z = -6;
            z += i;
            _insPos = new Vector3(1, 2, z);
            Instantiate(_coin, _insPos, Quaternion.identity);
        }
    }
}
