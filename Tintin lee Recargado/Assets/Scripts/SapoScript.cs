using UnityEngine;

public class SapoScript : MonoBehaviour
{
    private static GameObject _sapo;
    private GameObject _sapoBody;
    private GameObject _sapoHand;
    private int _cont;

    // Start is called before the first frame update
    void Start()
    {
        _sapo = GameObject.FindGameObjectWithTag("Sapo");
        _sapoBody = _sapo.transform.GetChild(0).gameObject;
        _sapoHand = _sapo.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_sapo) return;
        switch (_cont)
        {
            // Movement Animation
            case 1: // Initial Pos
                _sapo.transform.localScale = Vector3.one;
                _sapo.transform.position = new Vector2(-4.03f, -0.51f);
                break;
            case 5:
                
                break;
            case 10:
                break;
            case 15:
                break;
            case 20:
                break;
            case 25:

                break;
            case 30:

                break;
            case 35:

                break;
            case 40:

                break;
            case 45:

                break;
            case 50:

                break;
            case 55:

                break;

            // Hand Animation
            case 60:
                break;
            case 65:
                break;
            case 70:
                break;
            case 75:
                break;
            case 80:
                break;

            // Idle Animation
            case 230:
                _sapo.transform.position = new Vector2(-3.614f, -0.854f);
                _sapo.transform.localScale = Vector2.one; // Max Scale
                _cont = 0;
                break;
        }
    }
}