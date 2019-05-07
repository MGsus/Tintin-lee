using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clarita7Script : MonoBehaviour
{
    private int _cont;

    // Start is called before the first frame update
    void Start()
    {
        _cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _cont++;
        switch (_cont)
        {
            case 10:
                transform.Rotate(new Vector3(0, 0, 1), -5f);
                break;
            case 15:
                transform.Rotate(new Vector3(0, 0, -1), -2.5f);
                break;
            case 20:
                transform.Rotate(new Vector3(0, 0, -1), -2.5f);
                break;
            case 25:
                transform.Rotate(new Vector3(0, 0, -1), -2.5f);
                break;
            case 30:
                transform.Rotate(new Vector3(0, 0, -1), -5f);
                break;
            case 35:
                transform.Rotate(new Vector3(0, 0, 1), -2.5f);
                break;
            case 40:
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
                _cont = 0;
                break;
        }
    }
}