using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck7Script : MonoBehaviour
{
    private int _count;

    // Start is called before the first frame update
    void Start()
    {
        _count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _count++;
        switch (_count)
        {
            case 5:
                transform.Rotate(new Vector3(0, 0, 1), -10f);
                break;
            case 10:
                transform.Rotate(new Vector3(0, 0, 1), 5f);
                break;
            case 15:
                transform.Rotate(new Vector3(0, 0, 1), 5f);
                break;
            case 20:
                transform.Rotate(new Vector3(0, 0, 1), 2.5f);
                break;
            case 25:
                transform.Rotate(new Vector3(0, 0, 1), 2.5f);
                break;
            case 30:
                transform.Rotate(new Vector3(0, 0, 1), -2.5f);
                break;
            case 35:
                transform.Rotate(new Vector3(0, 0, 1), -2.5f);
                break;
            case 40:
                transform.Rotate(new Vector3(0, 0, 1), -5f);
                break;
            case 45:
                transform.Rotate(new Vector3(0, 0, 1), -5f);
                break;
            case 50:
                break;
            case 55:
                transform.Rotate(new Vector3(0, 0, 1), 10f);
                _count = 0;
                break;
        }
    }
}