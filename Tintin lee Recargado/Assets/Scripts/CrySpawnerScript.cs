using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrySpawnerScript : MonoBehaviour
{
    public GameObject rightTearPrefab;
    public GameObject leftTearPrefab;
    private GameObject _rightTear;
    private GameObject _leftTear;
    private int _spawnTime = 0;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        switch (_spawnTime)
        {
            case 50:
                _rightTear = Instantiate(rightTearPrefab);
                _rightTear.transform.position =
                    new Vector3(this.transform.position.x - Random.Range(0f,3f), this.transform.position.y, 0);
                _leftTear = Instantiate(leftTearPrefab);
                _leftTear.transform.position =
                    new Vector3(transform.position.x + 2, this.transform.position.y - 1, 0);
                break;
            case 150:
                _rightTear = Instantiate(rightTearPrefab);
                _rightTear.transform.position =
                    new Vector3(Random.Range(0f,3f), transform.position.y + 1, 0);
                _leftTear = Instantiate(leftTearPrefab);
                _leftTear.transform.position =
                    new Vector3(transform.position.x + 2, transform.position.y - 1, 0);
                _spawnTime = 0;
                break;
        }

        _spawnTime++;
    }
}