using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Rabbit7Script : MonoBehaviour
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
            case 5:
                transform.localScale = Vector3.one;
                break;
            case 8:
                transform.localScale = new Vector3(1f, 1.0055f, 1f);
                break;
            case 11:
                transform.localScale = new Vector3(1f, 1.011f, 1f);
                break;
            case 14:
                transform.localScale = new Vector3(1f, 1.0165f, 1f);
                break;
            case 17:
                transform.localScale = new Vector3(1f, 1.022f, 1f);
                break;
            case 20:
                transform.localScale = new Vector3(1f, 1.0275f, 1f);
                break;
            case 23:
                transform.localScale = new Vector3(1f, 1.033f, 1f);
                break;
            case 26:
                transform.localScale = new Vector3(1f, 1.0385f, 1f);
                break;
            case 29:
                transform.localScale = new Vector3(1f, 1.044f, 1f);
                break;
            case 32:
                transform.localScale = new Vector3(1f, 1.0495f, 1f);
                break;
            case 35:
                transform.localScale = new Vector3(1f, 1.05f, 1f); // Final pos
                break;
            case 38:
                transform.localScale = new Vector3(1f, 1.0495f, 1f);
                break;
            case 41:
                transform.localScale = new Vector3(1f, 1.044f, 1f);
                break;
            case 44:
                transform.localScale = new Vector3(1f, 1.0385f, 1f);
                break;
            case 47:
                transform.localScale = new Vector3(1f, 1.033f, 1f);
                break;
            case 50:
                transform.localScale = new Vector3(1f, 1.0275f, 1f);
                break;
            case 53:
                transform.localScale = new Vector3(1f, 1.022f, 1f);
                break;
            case 56:
                transform.localScale = new Vector3(1f, 1.0165f, 1f);
                break;
            case 59:
                transform.localScale = new Vector3(1f, 1.011f, 1f);
                break;
            case 62:
                transform.localScale = new Vector3(1f, 1.0055f, 1f);
                break;
            case 65:
                transform.localScale = Vector3.one;
                _cont = 0;
                break;
        }
    }
}