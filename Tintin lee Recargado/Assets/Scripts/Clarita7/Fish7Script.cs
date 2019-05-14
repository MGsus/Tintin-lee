using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish7Script : MonoBehaviour
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
            case 50:
                transform.position = new Vector2(-2.75f, -1.2f); // Initial Pos
                transform.Rotate(new Vector3(0, 0, 1), 10f);
                break;
            case 55:
                transform.position = new Vector2(-2.855f, -1.17f);
                break;
            case 60:
                transform.position = new Vector2(-2.9595f, -1.14f);
//                transform.Rotate(new Vector3(0, 0, -1), 10f);
                break;
            case 65:
                transform.position = new Vector2(-3.064f, -1.11f);
                break;
            case 70:
                transform.position = new Vector2(-3.1685f, -1f);
                transform.Rotate(new Vector3(0, 0, -1), 10f);
                break;
            case 75:
                transform.position = new Vector2(-3.273f, -1.11f);
                break;
            case 80:
                transform.position = new Vector2(-3.3775f, -1.14f);
//                transform.Rotate(new Vector3(0, 0, -1), 10f);
                break;
            case 85:
                transform.position = new Vector2(-3.482f, -1.17f);
                break;
            case 90:
                transform.position = new Vector2(-3.5865f, -1.2f);
                transform.Rotate(new Vector3(0, 0, 1), 10f);
                break;
            case 95:
                transform.position = new Vector2(-3.691f, -1.17f);
                break;
            case 100:
                transform.position = new Vector2(-3.7955f, -1.14f);
//                transform.Rotate(new Vector3(0, 0, -1), 10f);
                break;
            case 105:
                transform.position = new Vector2(-3.855f, -1.11f);
                break;
            case 110:
                transform.position = new Vector2(-3.9f, -1f); // Final Pos
                transform.Rotate(new Vector3(0, 0, -1), 10f);
                break;
            case 115:
                transform.position = new Vector2(-3.855f, -1.11f);
                break;
            case 120:
                transform.position = new Vector2(-3.7955f, -1.14f);
//                transform.Rotate(new Vector3(0, 0, -1), 10f);
                break;
            case 125:
                transform.position = new Vector2(-3.691f, -1.17f);
                break;
            case 130:
                transform.position = new Vector2(-3.5865f, -1.2f);
                transform.Rotate(new Vector3(0, 0, 1), 10f);
                break;
            case 135:
                transform.position = new Vector2(-3.482f, -1.17f);
                break;
            case 140:
                transform.position = new Vector2(-3.3775f, -1.14f);
//                transform.Rotate(new Vector3(0, 0, -1), 10f);
                break;
            case 145:
                transform.position = new Vector2(-3.273f, -1.11f);
                break;
            case 150:
                transform.position = new Vector2(-3.1685f, -1f);
                transform.Rotate(new Vector3(0, 0, 1), 10f);
                break;
            case 155:
                transform.position = new Vector2(-3.064f, -1.11f);
                break;
            case 160:
                transform.position = new Vector2(-2.9595f, -1.14f);
//                transform.Rotate(new Vector3(0, 0, -1), 10f);
                break;
            case 165:
                transform.position = new Vector2(-2.855f, -1.17f);
                break;
            case 170:
                transform.position = new Vector2(-2.75f, -1.2f);
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
                _cont = 0;
                break;
        }
    }
}