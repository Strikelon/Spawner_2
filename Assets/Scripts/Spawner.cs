using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private EnemyMovement _enemyMovementPrefab;
    [SerializeField] private Transform _target;

    public void Spawn()
    {
        EnemyMovement enemyMovement = Instantiate(_enemyMovementPrefab, transform.position, Quaternion.identity);
        enemyMovement.SetTarget(_target);
    }
}
