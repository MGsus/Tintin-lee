using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitShellScript : MonoBehaviour
{
    private int _cont;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _cont++;
        if (gameObject.name != "Rabbits") return;
        switch (_cont)
        {
            case 115:
                transform.position = Vector2.zero; // Initial Pos
                break;
            case 120:
                transform.position = new Vector2(0.1105f, 0.0494f);
                break;
            case 125:
                transform.position = new Vector2(0.221f, 0.0987f);
                break;
            case 130:
                transform.position = new Vector2(0.3315f, 0.148f); // Max height
                break;
            case 135:
                transform.position = new Vector2(0.442f, 0.0987f);
                break;
            case 140:
                transform.position = new Vector2(0.5525f, 0.0494f);
                break;
            case 145:
                transform.position = new Vector2(0.663f, 0f);
                break;
            case 150:
                transform.position = new Vector2(0.7735f, 0.0494f);
                break;
            case 155:
                transform.position = new Vector2(0.884f, 0.0987f);
                break;
            case 160:
                transform.position = new Vector2(0.9945f, 0.148f);
                break;
            case 165:
                transform.position = new Vector2(1.105f, 0.0987f);
                break;
            case 170:
                transform.position = new Vector2(1.2155f, 0.0494f);
                break;
            case 175:
                transform.position = new Vector2(1.216f, 0f); // Final Pos
                break;
            case 200:
                _cont = 0;
                break;
        }
    }
}