using UnityEngine;

public class Clarita5Script : MonoBehaviour
{
    private int _cont;

    // Update is called once per frame
    private void Update()
    {
        _cont++;
        if (gameObject.name == "ClaritaLArm")
        {
            switch (_cont)
            {
                case 1:
                    transform.position = new Vector2(transform.position.x, -0.313f); // Initial position
                    break;
                case 10:
                    transform.position = new Vector2(transform.position.x, -0.3f);
                    break;
                case 15:
                    transform.position = new Vector2(transform.position.x, -0.29f);
                    break;
                case 20:
                    transform.position = new Vector2(transform.position.x, -0.285f);
                    break;
                case 25:
                    transform.position = new Vector2(transform.position.x, -0.28f);
                    break;
                case 30:
                    transform.position = new Vector2(transform.position.x, -0.269f); // Final position
                    break;
                case 35:
                    transform.position = new Vector2(transform.position.x, -0.28f);
                    break;
                case 40:
                    transform.position = new Vector2(transform.position.x, -0.285f);
                    break;
                case 45:
                    transform.position = new Vector2(transform.position.x, -0.29f);
                    break;
                case 50:
                    transform.position = new Vector2(transform.position.x, -0.3f);
                    break;
                case 55:
                    transform.position = new Vector2(transform.position.x, -0.313f); // Back to initial pos
                    break;
                case 65:
                    transform.position = new Vector2(transform.position.x, -0.313f); // Initial position
                    break;
                case 70:
                    transform.position = new Vector2(transform.position.x, -0.3f);
                    break;
                case 75:
                    transform.position = new Vector2(transform.position.x, -0.29f);
                    break;
                case 80:
                    transform.position = new Vector2(transform.position.x, -0.285f);
                    break;
                case 85:
                    transform.position = new Vector2(transform.position.x, -0.28f);
                    break;
                case 90:
                    transform.position = new Vector2(transform.position.x, -0.269f); // Final position
                    break;
                case 95:
                    transform.position = new Vector2(transform.position.x, -0.28f);
                    break;
                case 100:
                    transform.position = new Vector2(transform.position.x, -0.285f);
                    break;
                case 105:
                    transform.position = new Vector2(transform.position.x, -0.29f);
                    break;
                case 110:
                    transform.position = new Vector2(transform.position.x, -0.3f);
                    break;
                case 115:
                    transform.position = new Vector2(transform.position.x, -0.313f); // Back to initial pos
                    break;
                case 200:
                    _cont = 0;
                    break;
            }
        }
        else
        {
            switch (_cont)
            {
                case 1:
                    transform.position = new Vector2(transform.position.x, -0.287f); // Initial position
                    break;
                case 10:
                    transform.position = new Vector2(transform.position.x, -0.2752f);
                    break;
                case 15:
                    transform.position = new Vector2(transform.position.x, -0.2634f);
                    break;
                case 20:
                    transform.position = new Vector2(transform.position.x, -0.2516f);
                    break;
                case 25:
                    transform.position = new Vector2(transform.position.x, -0.2398f);
                    break;
                case 30:
                    transform.position = new Vector2(transform.position.x, -0.228f); //-0.228 Final position
                    break;
                case 35:
                    transform.position = new Vector2(transform.position.x, -0.2398f);
                    break;
                case 40:
                    transform.position = new Vector2(transform.position.x, -0.2516f);
                    break;
                case 45:
                    transform.position = new Vector2(transform.position.x, -0.2634f);
                    break;
                case 50:
                    transform.position = new Vector2(transform.position.x, -0.2752f);
                    break;
                case 55:
                    transform.position = new Vector2(transform.position.x, -0.287f); // Back to initial pos
                    break;
                case 65:
                    transform.position = new Vector2(transform.position.x, -0.287f); // Initial position
                    break;
                case 70:
                    transform.position = new Vector2(transform.position.x, -0.2752f);
                    break;
                case 75:
                    transform.position = new Vector2(transform.position.x, -0.2634f);
                    break;
                case 80:
                    transform.position = new Vector2(transform.position.x, -0.2516f);
                    break;
                case 85:
                    transform.position = new Vector2(transform.position.x, -0.2398f);
                    break;
                case 90:
                    transform.position = new Vector2(transform.position.x, -0.228f); //-0.228 Final position
                    break;
                case 95:
                    transform.position = new Vector2(transform.position.x, -0.2398f);
                    break;
                case 100:
                    transform.position = new Vector2(transform.position.x, -0.2516f);
                    break;
                case 105:
                    transform.position = new Vector2(transform.position.x, -0.2634f);
                    break;
                case 110:
                    transform.position = new Vector2(transform.position.x, -0.2752f);
                    break;
                case 115:
                    transform.position = new Vector2(transform.position.x, -0.287f); // Back to initial pos
                    break;
                case 200:
                    _cont = 0;
                    break;
            }
        }
    }
}