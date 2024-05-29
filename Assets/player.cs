using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    float _movePower = 10;

    [SerializeField] float _z = 10;


    Rigidbody _rb;

    Vector3 _dir = default;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _dir = new Vector3(0, -1, _z);

        _rb.velocity = _dir * _movePower;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Stop")
        {
            _movePower = 0;
            _rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
