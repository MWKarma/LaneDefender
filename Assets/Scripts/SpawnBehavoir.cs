using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehavoir : MonoBehaviour
{
    [SerializeField] private float _startTimeBtwSpawn;
    [SerializeField] private float _timeBtwSpawn;
    [SerializeField] private GameObject[] enemies;
    private void Update()
    {
        if (_timeBtwSpawn <= 0)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], transform.position, Quaternion.identity);
            _timeBtwSpawn = _startTimeBtwSpawn;
        }
        else
        {
            _timeBtwSpawn -= Time.deltaTime;
        }
    }
}
