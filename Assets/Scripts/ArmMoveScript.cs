using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ArmMoveScript : MonoBehaviour
{
    private int _cont = 0;
    private Transform brazo2;
    private Transform brazo3;

    private void Start()
    {
        if (gameObject.name == "Brazo_Arriba")
            brazo3 = transform;
        else
            brazo2 = transform;
    }

    // Update is called once per frame
    void Update()
    {
        _cont++;
        if (gameObject.name == "Brazo_Arriba")
        {
            switch (_cont)
            {
                case 95:
                    brazo3.position = new Vector2(1.427f, 0.167f);
                    break;
                case 100:
                    brazo3.position = new Vector2(1.4f, 0.167f);
                    break;
                case 105:
                    brazo3.position = new Vector2(1.3f, 0.167f);
                    break;
                case 110:
                    brazo3.position = new Vector2(1.2f, 0.167f);
                    break;
                case 115:
                    brazo3.position = new Vector2(1.18f, 0.167f);
                    break;
                case 120: // Middle Position
                    brazo3.position = new Vector2(1.18f, 0.167f);
                    break;
                case 125:
                    brazo3.position = new Vector2(1.2f, 0.167f);
                    break;
                case 130:
                    brazo3.position = new Vector2(1.25f, 0.167f);
                    break;
                case 135:
                    brazo3.position = new Vector2(1.3f, 0.167f);
                    break;
                case 140:
                    brazo3.position = new Vector2(1.4f, 0.167f);
                    break;
                case 145:
                    brazo3.position = new Vector2(1.427f, 0.167f);
                    _cont = 0;
                    break;
            }
        }else if (gameObject.name == "ClaritaArm")
        {
            switch (_cont)
            {
                case 95:
                    brazo2.position = new Vector2(0.2f, 0.05f); // 0.2x, 0.05y
                    break;
                case 100:
                    brazo2.position = new Vector2(0.17f, 0.0427f);
                    break;
                case 105:
                    brazo2.position = new Vector2(0.14f, 0.0354f);
                    break;
                case 110:
                    brazo2.position = new Vector2(0.11f, 0.0281f);
                    break;
                case 115:
                    brazo2.position = new Vector2(0.08f, 0.0208f);
                    break;
                case 120: // Middle Position
                    brazo2.position = new Vector2(0f, 0.006f); // 0x, 0.006y
                    break;
                case 125:
                    brazo2.position = new Vector2(0.08f, 0.0208f);
                    break;
                case 130:
                    brazo2.position = new Vector2(0.11f, 0.0281f);
                    break;
                case 135:
                    brazo2.position = new Vector2(0.14f, 0.0354f);
                    break;
                case 140:
                    brazo2.position = new Vector2(0.17f, 0.0427f);
                    break;
                case 145:
                    brazo2.position = new Vector2(0.2f, 0.05f);
                    break;
                case 150:
                    brazo2.position = new Vector2(0.17f, 0.0427f);
                    break;
                case 155:
                    brazo2.position = new Vector2(0.14f, 0.0354f);
                    break;
                case 160:
                    brazo2.position = new Vector2(0.11f, 0.0281f);
                    break;
                case 165:
                    brazo2.position = new Vector2(0.08f, 0.0208f);
                    break;
                case 170: // Middle Position
                    brazo2.position = new Vector2(0f, 0.006f); // 0x, 0.006y
                    break;
                case 175:
                    brazo2.position = new Vector2(0.08f, 0.0208f);
                    break;
                case 180:
                    brazo2.position = new Vector2(0.11f, 0.0281f);
                    break;
                case 185:
                    brazo2.position = new Vector2(0.14f, 0.0354f);
                    break;
                case 190:
                    brazo2.position = new Vector2(0.17f, 0.0427f);
                    break;
                case 195:
                    brazo2.position = new Vector2(0.2f, 0.05f);
                    _cont = 0;
                    break;
            }   
        }
        else
        {
            switch (_cont)
            {
                case 95: // Initial Rotation
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 1f));
                    break;
                case 100:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 3.5f));
                    break;
                case 105:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 5f));
                    break;
                case 110:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 9.5f));
                    break;
                case 115:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 11.5f));
                    break;
                case 120: // Normal Rotation
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 15f));
                    break;
                case 125:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 11.5f));
                    break;
                case 130:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 9.5f));
                    break;
                case 135:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 5f));
                    break;
                case 140:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 3.5f));
                    break;
                case 145:
                    brazo2.rotation = Quaternion.Euler(new Vector3(0f, 0f, 1f));
                    _cont = 0;
                    break;
            }
        }
    }
}