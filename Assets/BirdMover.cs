using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _speed;
    [SerializeField] private float _tapForce = 500;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _maxRotationZ;
    [SerializeField] private float _minRotationZ;


    private Quaternion _maxRotation;
    private Quaternion _minRotation;
    private Rigidbody2D _rigedbody;
    void Start()
    {
        transform.position = _startPosition;  
        _rigedbody = GetComponent<Rigidbody2D>();
        _rigedbody.velocity = Vector2.zero;

        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, _minRotationZ);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigedbody.velocity = new Vector2(_speed, 0);
            transform.rotation = _maxRotation;
            _rigedbody.AddForce(Vector3.up * _tapForce, ForceMode2D.Force);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, _rotationSpeed * Time.deltaTime);
    }
}
