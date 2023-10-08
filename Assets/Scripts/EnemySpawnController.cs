using System.Collections;
using UnityEngine;

public class EnemySpawnController : MonoBehaviour
{
    [SerializeField] private float _spawnInterval;
    [SerializeField] private Spawner[] _spawns;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
             int spawnIndex = Random.Range(0, _spawns.Length);
            _spawns[spawnIndex].Spawn();

           yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
