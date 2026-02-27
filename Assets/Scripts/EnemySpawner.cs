using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyPrefabs;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _timeBetweenSpawns = 1f;

    private float _elapseTime = 0;

    private void Start()

    {
        Initialize(_enemyPrefabs);
    }
    private void Update()
    {
        _elapseTime += Time.deltaTime;
        if (_elapseTime >= _timeBetweenSpawns)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elapseTime = 0;
                int randomSpawnId = Random.Range(0, _spawnPoints.Length);
                SetEnemy(enemy, _spawnPoints[randomSpawnId].position);
            }
            

            

            
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    { 
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
