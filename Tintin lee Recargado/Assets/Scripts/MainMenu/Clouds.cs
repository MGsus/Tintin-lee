using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
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
                transform.position = new Vector2();
                break;
            case 10:
                transform.position = new Vector2(-0.1f, 0f);
                break;
            case 15:
                transform.position = new Vector2(-0.2f, 0f);
                break;
            case 20:
                transform.position = new Vector2(-0.3f, 0f);
                break;
            case 25:
                transform.position = new Vector2(-0.4f, 0f);
                break;
            case 30:
                transform.position = new Vector2(-0.5f, 0f);
                break;
            case 35:
                transform.position = new Vector2(-0.6f, 0f);
                break;
            case 40:
                transform.position = new Vector2(-0.7f, 0f);
                break;
            case 45:
                transform.position = new Vector2(-0.8f, 0f);
                break;
            case 50:
                transform.position = new Vector2(-0.9f, 0f);
                break;
            case 55:
                transform.position = new Vector2(-1f, 0f);
                break;
            case 60:
                transform.position = new Vector2(-1.1f, 0f);
                break;
            case 65:
                transform.position = new Vector2(-1.2f, 0f);
                break;
            case 70:
                transform.position = new Vector2(-1.3f, 0f);
                break;
            case 75:
                transform.position = new Vector2(-1.4f, 0f);
                break;
            case 80:
                transform.position = new Vector2(-1.5f, 0f);
                break;
            case 85:
                transform.position = new Vector2(-1.6f, 0f);
                break;
            case 90:
                transform.position = new Vector2(-1.7f, 0f);
                break;
            case 95:
                transform.position = new Vector2(-1.8f, 0f);
                break;
            case 100:
                transform.position = new Vector2(-1.9f, 0f);
                _count = 0;
                break;
        }
    }
}