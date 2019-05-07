using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class Clarita3AnimScript : MonoBehaviour
{
    private static GameObject _parentGameObject;
    private GameObject _cejaIzq;
    private GameObject _cejaDer;
    private GameObject _ojoIzq;
    private GameObject _ojoDer;
    private int _cont;
    private float _xPosParent;

    // Start is called before the first frame update
    void Start()
    {
        _parentGameObject = GameObject.FindGameObjectWithTag("Clarita1");
        _xPosParent = _parentGameObject.transform.position.x;
        _cejaIzq = _parentGameObject.transform.GetChild(1).gameObject;
        _cejaDer = _parentGameObject.transform.GetChild(2).gameObject;
        _ojoIzq = _parentGameObject.transform.GetChild(3).gameObject;
        _ojoDer = _parentGameObject.transform.GetChild(4).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_parentGameObject) return;
        _cont++;
        switch (_cont)
        {
            case 1: // Initial Pos
                _cejaIzq.transform.position = new Vector3(-0.46f + _xPosParent, 1.52f);
                _cejaDer.transform.position = new Vector3(-0.16f + _xPosParent, 1.54f); // -0.16x
                _ojoIzq.transform.position = new Vector3(-0.4104f + _xPosParent, 1.25f); // -0.414x
                _ojoDer.transform.position = new Vector3(-0.08f + _xPosParent, 1.24f); // -0.08x
                break;
            case 4:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4559f + _xPosParent, 1.5198f);
                _cejaDer.transform.position = new Vector3(-0.17f + _xPosParent, 1.535f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -1f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0.9166f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.4212f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.0987f + _xPosParent, 1.24f);
                break;
            case 7:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4518f + _xPosParent, 1.5144f);
                _cejaDer.transform.position = new Vector3(-0.18f + _xPosParent, 1.53f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -2f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 1.8332f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.432f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.117f + _xPosParent, 1.24f);
                break;
            case 10:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4477f + _xPosParent, 1.509f);
                _cejaDer.transform.position = new Vector3(-0.19f + _xPosParent, 1.525f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -3f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 2.7498f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.4428f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.1353f + _xPosParent, 1.24f);
                break;
            case 13:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4436f + _xPosParent, 1.5036f);
                _cejaDer.transform.position = new Vector3(-0.20f + _xPosParent, 1.52f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -4f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 2.6664f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.4536f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.1536f + _xPosParent, 1.24f);
                break;
            case 16:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4395f + _xPosParent, 1.4982f);
                _cejaDer.transform.position = new Vector3(-0.21f + _xPosParent, 1.515f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -5f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 4.583f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.4644f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.1719f + _xPosParent, 1.24f);
                break;
            case 19:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4354f + _xPosParent, 1.4928f);
                _cejaDer.transform.position = new Vector3(-0.22f + _xPosParent, 1.51f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -4f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 5.4996f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.4752f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.1902f + _xPosParent, 1.24f);
                break;
            case 22:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4313f + _xPosParent, 1.4874f);
                _cejaDer.transform.position = new Vector3(-0.23f + _xPosParent, 1.505f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -5f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 6.4162f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.486f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.2085f + _xPosParent, 1.24f);
                break;
            case 25:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4272f + _xPosParent, 1.482f);
                _cejaDer.transform.position = new Vector3(-0.24f + _xPosParent, 1.5f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -6f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 7.3328f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.4968f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.2268f + _xPosParent, 1.24f);
                break;
            case 28:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4231f + _xPosParent, 1.4766f);
                _cejaDer.transform.position = new Vector3(-0.21f + _xPosParent, 1.495f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -28f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 8.24f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.5076f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.2451f + _xPosParent, 1.24f);
                break;
            case 31:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.419f + _xPosParent, 1.4712f);
                _cejaDer.transform.position = new Vector3(-0.22f + _xPosParent, 1.49f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -29f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 9.166f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.5184f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.2634f + _xPosParent, 1.24f);
                break;
            case 34:
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.4149f + _xPosParent, 1.4658f);
                _cejaDer.transform.position = new Vector3(-0.23f + _xPosParent, 1.485f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -30f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 10.08f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.5292f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.2817f + _xPosParent, 1.24f);
                break;
            case 37: // Final Position
                // Eyebrows
                _cejaIzq.transform.position = new Vector3(-0.41f + _xPosParent, 1.455f);
                _cejaDer.transform.position = new Vector3(-0.23f + _xPosParent, 1.48f);
                // Rotation
                _cejaIzq.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -30f));
                _cejaDer.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 11f));
                // Eyes
                _ojoIzq.transform.position = new Vector3(-0.54f + _xPosParent, 1.25f);
                _ojoDer.transform.position = new Vector3(-0.3f + _xPosParent, 1.24f);
                break;
            case 230: // Reset to initial position
                _cejaIzq.transform.position = new Vector3(-0.46f + _xPosParent, 1.52f);
                _cejaDer.transform.position = new Vector3(-0.16f + _xPosParent, 1.54f); // -0.16x
                _ojoIzq.transform.position = new Vector3(-0.4104f + _xPosParent, 1.25f); // -0.414x
                _ojoDer.transform.position = new Vector3(-0.08f + _xPosParent, 1.24f); // -0.08x
                _cont = 0;
                break;
        }
    }
}