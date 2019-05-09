using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovementScript : MonoBehaviour
{
    private int _cont;
    private Transform pez1Transform;
    private Transform pez2Transform;

    // Start is called before the first frame update
    void Start()
    {
        if (CompareTag("Pez1"))
            pez1Transform = transform;
        else
            pez2Transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        _cont++;
        if (CompareTag("Pez1"))
        {
            switch (_cont)
            {
                //Start Idle Animation
                case 5:
                    pez1Transform.position = new Vector3(-4f, -1.2f, 0f); // Initial Position
                    break;
                case 10:
                    pez1Transform.position = new Vector3(-3.99f, -1.21f, 0);
                    break;
                case 15:
                    pez1Transform.position = new Vector3(-3.98f, -1.22f, 0f);
                    break;
                case 20:
                    pez1Transform.position = new Vector3(-3.97f, -1.23f, 0f);
                    break;
                case 25:
                    pez1Transform.position = new Vector3(-3.96f, -1.24f, 0f);
                    break;
                case 30:
                    pez1Transform.position = new Vector3(-3.95f, -1.25f, 0f);
                    break;
                case 35:
                    pez1Transform.position = new Vector3(-3.94f, -1.26f, 0f);
                    break;
                case 40:
                    pez1Transform.position = new Vector3(-3.93f, -1.27f, 0f);
                    break;
                case 45:
                    pez1Transform.position = new Vector3(-3.92f, -1.28f, 0f);
                    break;
                case 50:
                    pez1Transform.position = new Vector3(-3.91f, -1.29f, 0f);
                    break;
                case 55:
                    pez1Transform.position = new Vector3(-3.9f, -1.3f, 0f); // Middle Position
                    break;
                case 60:
                    pez1Transform.position = new Vector3(-3.91f, -1.3f, 0);
                    break;
                case 65:
                    pez1Transform.position = new Vector3(-3.92f, -1.3f, 0f);
                    break;
                case 70:
                    pez1Transform.position = new Vector3(-3.93f, -1.3f, 0f);
                    break;
                case 75:
                    pez1Transform.position = new Vector3(-3.94f, -1.3f, 0f);
                    break;
                case 80:
                    pez1Transform.position = new Vector3(-3.95f, -1.3f, 0f);
                    break;
                case 85:
                    pez1Transform.position = new Vector3(-3.96f, -1.3f, 0f);
                    break;
                case 90:
                    pez1Transform.position = new Vector3(-3.97f, -1.3f, 0f);
                    break;
                case 95:
                    pez1Transform.position = new Vector3(-3.98f, -1.3f, 0f);
                    break;
                case 100:
                    pez1Transform.position = new Vector3(-3.99f, -1.3f, 0f);
                    break;
                // End Idle Animation

                // Start Jump Animation
                case 105:
                    pez1Transform.position = new Vector3(-3.99f, -1.2f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,1f));
                    break;
                case 110:
                    pez1Transform.position = new Vector3(-3.99f, -1.1f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,1f));
                    break;
                case 115:
                    pez1Transform.position = new Vector3(-3.99f, -1f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,2f));
                    break;
                case 120:
                    pez1Transform.position = new Vector3(-3.99f, -0.9f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,2f));
                    break;
                case 125:
                    pez1Transform.position = new Vector3(-3.99f, -0.8f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,10f));
                    break;
                case 130:
                    pez1Transform.position = new Vector3(-3.99f, -0.7f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
                    break;
                case 135:
                    pez1Transform.position = new Vector3(-3.99f, -0.6f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,10f));
                    break;
                case 140:
                    pez1Transform.position = new Vector3(-3.99f, -0.5f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
                    break;
                case 145:
                    pez1Transform.position = new Vector3(-3.99f, -0.4f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,10f));
                    break;
                case 150:
                    pez1Transform.position = new Vector3(-3.99f, -0.3f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
                    break;
                case 155:
                    pez1Transform.position = new Vector3(-3.99f, -0.2f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,10f));
                    break;
                case 160:
                    pez1Transform.position = new Vector3(-3.99f, -0.1f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
                    break;
                case 165: // Top High
                    pez1Transform.position = new Vector3(-3.99f, 0f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-10f));
                    break;
                case 170:
                    pez1Transform.position = new Vector3(-3.99f, -0.1f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-15f));
                    break;
                case 175:
                    pez1Transform.position = new Vector3(-3.99f, -0.2f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-20f));
                    break;
                case 180:
                    pez1Transform.position = new Vector3(-3.99f, -0.3f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-30f));
                    break;
                case 185:
                    pez1Transform.position = new Vector3(-3.99f, -0.4f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-40f));
                    break;
                case 190:
                    pez1Transform.position = new Vector3(-3.99f, -0.5f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-50f));
                    break;
                case 195:
                    pez1Transform.position = new Vector3(-3.99f, -0.6f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-60f));
                    break;
                case 200:
                    pez1Transform.position = new Vector3(-3.99f, -0.7f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-70f));
                    break;
                case 205:
                    pez1Transform.position = new Vector3(-3.99f, -0.8f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-80f));
                    break;
                case 210:
                    pez1Transform.position = new Vector3(-3.99f, -0.9f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-90f));
                    break;
                case 215:
                    pez1Transform.position = new Vector3(-3.99f, -1f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-90f));
                    break;
                case 220:
                    pez1Transform.position = new Vector3(-3.99f, -1.1f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-90f));
                    break;
                case 225:
                    pez1Transform.position = new Vector3(-3.99f, -1.2f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,-90f));
                    break;
                // End Jump Animation

                case 230:
                    pez1Transform.position = new Vector3(-4f, -1.2f, 0f);
                    pez1Transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
                    _cont = 0;
                    break;
            }
        }
        else // Pez2
        {
            switch (_cont)
            {
                //Start Idle Animation
                case 5:
                    pez2Transform.position = new Vector3(-3.2f, -1.26f, 0f); // Initial Position
                    break;
                case 10:
                    pez2Transform.position = new Vector3(-3.19f, -1.26f, 0);
                    break;
                case 15:
                    pez2Transform.position = new Vector3(-3.18f, -1.26f, 0f);
                    break;
                case 20:
                    pez2Transform.position = new Vector3(-3.17f, -1.25f, 0f);
                    break;
                case 25:
                    pez2Transform.position = new Vector3(-3.16f, -1.24f, 0f);
                    break;
                case 30:
                    pez2Transform.position = new Vector3(-3.15f, -1.23f, 0f);
                    break;
                case 35:
                    pez2Transform.position = new Vector3(-3.14f, -1.24f, 0f);
                    break;
                case 40:
                    pez2Transform.position = new Vector3(-3.13f, -1.25f, 0f);
                    break;
                case 45:
                    pez2Transform.position = new Vector3(-3.12f, -1.26f, 0f);
                    break;
                case 50:
                    pez2Transform.position = new Vector3(-3.11f, -1.27f, 0f);
                    break;
                case 55:
                    pez2Transform.position = new Vector3(-3.1f, -1.27f, 0f); // Middle Position
                    break;
                case 60:
                    pez2Transform.position = new Vector3(-3.11f, -1.27f, 0);
                    break;
                case 65:
                    pez2Transform.position = new Vector3(-3.12f, -1.27f, 0f);
                    break;
                case 70:
                    pez2Transform.position = new Vector3(-3.13f, -1.27f, 0f);
                    break;
                case 75:
                    pez2Transform.position = new Vector3(-3.14f, -1.27f, 0f);
                    break;
                case 80:
                    pez2Transform.position = new Vector3(-3.15f, -1.27f, 0f);
                    break;
                case 85:
                    pez2Transform.position = new Vector3(-3.16f, -1.27f, 0f);
                    break;
                case 90:
                    pez2Transform.position = new Vector3(-3.17f, -1.27f, 0f);
                    break;
                case 95:
                    pez2Transform.position = new Vector3(-3.18f, -1.27f);
                    break;
                case 100:
                    pez2Transform.position = new Vector3(-3.19f, -1.27f);
                    break;
                // End Idle Animation

                // Start Swim Animation
                case 105:
                    pez2Transform.position = new Vector3(-3.2f, -1.26f);
                    break;
                case 110:
                    pez2Transform.position = new Vector3(-3.19f, -1.25f);
                    break;
                case 125:
                    pez2Transform.position = new Vector3(-3.18f, -1.26f);
                    break;
                case 130:
                    pez2Transform.position = new Vector3(-3.17f, -1.29f);
                    break;
                case 145:
                    pez2Transform.position = new Vector3(-3.16f, -1.31f);
                    break;
                case 150:
                    pez2Transform.position = new Vector3(-3.15f, -1.33f);
                    break;
                case 155:
                    pez2Transform.position = new Vector3(-3.14f, -1.36f);
                    break;
                case 160:
                    pez2Transform.position = new Vector3(-3.13f, -1.39f);
                    break;
                case 165:
                    pez2Transform.position = new Vector3(-3.12f, -1.42f);
                    break;
                case 170:
                    pez2Transform.position = new Vector3(-3.11f, -1.45f);
                    break;
                case 175:
                    pez2Transform.position = new Vector3(-3.1f, -1.48f);
                    break;
                case 180:
                    pez2Transform.position = new Vector3(-3.11f, -1.51f); //Middle Swim Animation
                    break;
                case 185:
                    pez2Transform.position = new Vector3(-3.12f, -1.48f);
                    break;
                case 190:
                    pez2Transform.position = new Vector3(-3.13f, -1.45f);
                    break;
                case 195:
                    pez2Transform.position = new Vector3(-3.14f, -1.42f);
                    break;
                case 200:
                    pez2Transform.position = new Vector3(-3.15f, -1.39f);
                    break;
                case 205:
                    pez2Transform.position = new Vector3(-3.16f, -1.36f);
                    break;
                case 210:
                    pez2Transform.position = new Vector3(-3.17f, -1.33f);
                    break;
                case 215:
                    pez2Transform.position = new Vector3(-3.18f, -1.3f);
                    break;
                case 220:
                    pez2Transform.position = new Vector3(-3.19f, -1.27f);
                    break;
                case 225:
                    pez2Transform.position = new Vector3(-3.2f, -1.25f);
                    break;
                case 230:
                    pez2Transform.position = new Vector3(-3.2f, -1.26f);
                    _cont = 0;
                    break;
                // End Swim Animation
            }
        }
    }
}