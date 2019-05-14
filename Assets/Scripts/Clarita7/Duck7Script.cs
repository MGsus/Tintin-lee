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
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -10f));
                break;
            case 10:
                transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 15:
                transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 20:
                transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 25:
                transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 30:
                transform.Rotate(new Vector3(0, 0, 1), 2f); // z = 0;
                break;
            case 35:
                transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 40:
                transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 45:
                transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 50:
                transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 55:
                transform.Rotate(new Vector3(0, 0, 1), 2f); // z = 10
                break;
            case 60:
                transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 65:
                transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 70:
                transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 75:
                transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 80:
                transform.Rotate(new Vector3(0, 0, 1), -2f); // z = 0
                break;
            case 85:
                transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 90:
                transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 95:
                transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 100:
                transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 105:
                transform.Rotate(new Vector3(0, 0, 1), -2f); // z = -10
                _count = 0;
                break;
        }
    }
}