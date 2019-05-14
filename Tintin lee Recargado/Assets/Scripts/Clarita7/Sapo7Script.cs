using UnityEngine;

public class Sapo7Script : MonoBehaviour
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
            // Movement Animation
            case 1: // Initial Pos
                transform.position = new Vector2(-1.97f, 0.37f);
                break;
            case 5:
                transform.position = new Vector2(-1.97f, 0.375f);
                break;
            case 15:
                transform.position = new Vector2(-1.97f, 0.35f);
                break;
            case 20:
                transform.position = new Vector2(-1.97f, 0.3f);
                break;
            case 25:
                transform.position = new Vector2(-1.97f, 0.25f);
                break;
            case 30:
                transform.position = new Vector2(-1.97f, 0.23f); // Min height
                break;
            case 35:
                transform.position = new Vector2(-1.97f, 0.25f);
                break;
            case 40:
                transform.position = new Vector2(-1.97f, 0.3f);
                break;
            case 45:
                transform.position = new Vector2(-1.97f, 0.35f);
                break;
            case 50:
                transform.position = new Vector2(-1.97f, 0.375f);
                break;
            case 55:
                transform.position = new Vector2(-1.97f, 0.37f); // Initial pos
                break;
            case 65:
                transform.position = new Vector2(-1.9555f, 0.375f);
                break;
            case 70:
                transform.position = new Vector2(-1.941f, 0.35f);
                break;
            case 75:
                transform.position = new Vector2(-1.9265f, 0.3f);
                break;
            case 80:
                transform.position = new Vector2(-1.912f, 0.25f);
                break;
            case 85:
                transform.position = new Vector2(-1.883f, 0.23f); // Min height
                break;
            case 90:
                transform.position = new Vector2(-1.8685f, 0.25f);
                break;
            case 95:
                transform.position = new Vector2(-1.854f, 0.3f);
                break;
            case 100:
                transform.position = new Vector2(-1.8395f, 0.35f);
                break;
            case 105:
                transform.position = new Vector2(-1.825f, 0.375f);
                break;
            case 110:
                transform.position = new Vector2(-1.81f, 0.37f);
                _count = 0;
                break;
        }
    }
}