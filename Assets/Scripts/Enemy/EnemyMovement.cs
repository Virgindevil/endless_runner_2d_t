using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5;

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime); 
    }
}
