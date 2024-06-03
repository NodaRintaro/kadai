using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] float _movePower = 10;

    [SerializeField] float _z = 10;

    [SerializeField] GameObject _scoreManagerObject;

    private GameObject _coin = null;

    Rigidbody _rb;

    Vector3 _dir = default;

    ScoreManager _scoreManager;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _scoreManager = _scoreManagerObject.GetComponent<ScoreManager>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        _dir = new Vector3(x, -1, _z);

        _rb.velocity = _dir * _movePower;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Stop")
        {
            _movePower = 0;
            _rb.constraints = RigidbodyConstraints.FreezeAll;
        }

        if(other.gameObject.tag == "Money")
        {
            _coin = other.gameObject;
            int plus = 10;
            _scoreManager.Score(plus);
            Destroy(_coin);
        }
    }
}
