using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawns = 1f;

    private float _elapseTime = 0;

    private void Update()
    {
        _elapseTime += Time.deltaTime;
        if (_elapseTime >= _timeBetweenSpawns)
        { 
            int randomSpawnId = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemyPrefab, _spawnPoints[randomSpawnId].position, Quaternion.identity);
            _elapseTime = 0;
        }
    }
}
