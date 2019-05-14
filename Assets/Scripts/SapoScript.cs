using UnityEngine;

public class SapoScript : MonoBehaviour
{
    private static GameObject _sapo;
    private GameObject _sapoHand;
    private int _cont;

    // Start is called before the first frame update
    void Start()
    {
        _sapo = GameObject.FindGameObjectWithTag("Sapo");
        _sapoHand = _sapo.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_sapo) return;
        _cont++;
        switch (_cont)
        {
            // Movement Animation
            case 1: // Initial Pos
                _sapo.transform.position = new Vector2(-4.03f, -0.51f);
                _sapo.transform.localScale = Vector3.one;
                break;
            case 5:
                _sapo.transform.position = new Vector2(-3.9608f, -0.5102f);
                _sapo.transform.localScale = new Vector2(1.045f, 1.045f);
                break;
            case 10:
                _sapo.transform.position = new Vector2(-3.9262f, -0.5675f);
                _sapo.transform.localScale = new Vector2(1.09f, 1.09f);
                break;
            case 15:
                _sapo.transform.position = new Vector2(-3.8916f, -0.6821f);
                _sapo.transform.localScale = new Vector2(1.135f, 1.135f);
                break;
            case 20:
                _sapo.transform.position = new Vector2(-3.857f, -0.6248f);
                _sapo.transform.localScale = new Vector2(1.18f, 1.18f);
                break;
            case 25:
                _sapo.transform.position = new Vector2(-3.8224f, -0.5102f);
                _sapo.transform.localScale = new Vector2(1.225f, 1.225f);
                break;
            case 30:
                _sapo.transform.position = new Vector2(-3.7878f, -0.5675f);
                _sapo.transform.localScale = new Vector2(1.27f, 1.27f);
                break;
            case 35:
                _sapo.transform.position = new Vector2(-3.7532f, -0.6248f);
                _sapo.transform.localScale = new Vector2(1.315f, 1.315f);
                break;
            case 40:
                _sapo.transform.position = new Vector2(-3.7186f, -0.6821f);
                _sapo.transform.localScale = new Vector2(1.36f, 1.36f);
                break;
            case 45:
                _sapo.transform.position = new Vector2(-3.684f, -0.7394f);
                _sapo.transform.localScale = new Vector2(1.405f, 1.405f);
                break;
            case 50:
                _sapo.transform.position = new Vector2(-3.6494f, -0.7967f);
                _sapo.transform.localScale = new Vector2(1.45f, 1.45f);
                break;
            case 55:
                _sapo.transform.position = new Vector2(-3.614f, -0.854f);
                _sapo.transform.localScale = new Vector2(1.5f, 1.5f);
                break;

            // Hand Animation
            case 60:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -20f));
                break;
            case 70:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 20f));
                break;
            case 80:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -20f));
                break;
            case 90:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 20f));
                break;
            case 100:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -20f));
                break;
            case 110:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 20f));
                break;
            case 120:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -20f));
                break;
            case 130:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 20f));
                break;
            case 140:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, -20f));
                break;
            case 150:
                _sapoHand.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 20f));
                break;
            case 160:
                _sapoHand.transform.rotation = Quaternion.Euler(Vector3.one);
                break;

            // Idle Animation
            case 230:
                _sapo.transform.position = new Vector2(-4.03f, -0.51f);
                _sapo.transform.rotation = Quaternion.Euler(Vector3.one);
                _sapo.transform.localScale = Vector2.one; // Max Scale
                _cont = 0;
                break;
        }
    }
}