using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject rightTearPrefab;
    public GameObject leftTearPrefab;
    public Transform[] lfSpawnPoints;
    public Transform[] rfSpawnPoints;
    private int _spawnTime = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var lfSpawnPoint = lfSpawnPoints[Random.Range(0, lfSpawnPoints.Length)];
        var rfSpawnPoint = rfSpawnPoints[Random.Range(0, rfSpawnPoints.Length)];
        if (_spawnTime == 25)
        {
            Instantiate(rightTearPrefab, rfSpawnPoint.transform.position, rfSpawnPoint.transform.rotation);
            Instantiate(leftTearPrefab, lfSpawnPoint.transform.position, lfSpawnPoint.transform.rotation);
            _spawnTime = 0;
        }

        _spawnTime++;
    }
}