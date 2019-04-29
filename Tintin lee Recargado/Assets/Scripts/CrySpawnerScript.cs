using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrySpawnerScript : MonoBehaviour
{
    public GameObject clarita;
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
                    new Vector3(clarita.transform.position.x - 2, clarita.transform.position.y + 1, 0);
                _leftTear = Instantiate(leftTearPrefab);
                break;
            case 150:
                _rightTear = Instantiate(rightTearPrefab);
                _rightTear.transform.position =
                    new Vector3(clarita.transform.position.x - 2, clarita.transform.position.y + 1, 0);
                _leftTear = Instantiate(leftTearPrefab);
                _spawnTime = 0;
                break;
        }

        _spawnTime++;
    }
}