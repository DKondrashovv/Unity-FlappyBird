using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTracker : MonoBehaviour
{
    [SerializeField] private GameObject _bird;
    private float _xOffset = -1;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(_bird.transform.position.x - _xOffset, transform.position.y, transform.position.z);    
    }
}
