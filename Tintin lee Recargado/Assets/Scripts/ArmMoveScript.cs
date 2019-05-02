using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMoveScript : MonoBehaviour
{
    private int _cont = 0;

    // Update is called once per frame
    void Update()
    {
        _cont++;
        switch (_cont)
        {
            case 95: // Initial Rotation
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 1f));
                break;
            case 100:
                transform.rotation = Quaternion.Euler(new Vector3(0f,0f,3.5f));
                break;
            case 105:
                transform.rotation = Quaternion.Euler(new Vector3(0f,0f,5f));
                break;
            case 110:
                transform.rotation = Quaternion.Euler(new Vector3(0f,0f,9.5f));
                break;
            case 115:
                transform.rotation = Quaternion.Euler(new Vector3(0f,0f,11.5f));
                break;
            case 120: // Normal Rotation
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 15f));
                _cont = 0;
                break;
        }
    }
}