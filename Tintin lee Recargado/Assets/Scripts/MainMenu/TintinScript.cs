using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;

public class TintinScript : MonoBehaviour
{
    private int _count;
    private static GameObject _tintin;
    private GameObject _tintinLArm;
    private GameObject _tintinRArm;
    private GameObject _tintinRFoot;
    private GameObject _tintinLFoot;
    private GameObject _balloons;

    // Start is called before the first frame update
    void Start()
    {
        _count = 0;
        _tintin = GameObject.FindGameObjectWithTag("Tintin");
        _tintinLArm = _tintin.transform.GetChild(1).gameObject;
        _tintinRArm = _tintin.transform.GetChild(2).gameObject;
        _tintinRFoot = _tintin.transform.GetChild(3).gameObject;
        _tintinLFoot = _tintin.transform.GetChild(4).gameObject;
        _balloons = _tintin.transform.GetChild(5).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        _count++;
        switch (_count)
        {
            case 5: // Initial pos & scale
                _tintin.transform.position = new Vector2(1f, -1f);
                _tintin.transform.localScale = new Vector3(0.5f, 0.5f, 1f);
                break;
            case 10:
                _tintin.transform.position = new Vector2(1f, -0.991f);
                _tintin.transform.localScale = new Vector3(0.58f, 0.58f, 1f);
                break;
            case 15:
                _tintin.transform.position = new Vector2(0.964f, -0.982f);
                _tintin.transform.localScale = new Vector3(0.652f, 0.652f, 1f);
                break;
            case 20:
                _tintin.transform.position = new Vector2(0.928f, -0.973f);
                _tintin.transform.localScale = new Vector3(0.724f, 0.724f, 1f);
                break;
            case 25:
                _tintin.transform.position = new Vector2(0.892f, -0.964f);
                _tintin.transform.localScale = new Vector3(0.796f, 0.796f, 1f);
                break;
            case 30:
                _tintin.transform.position = new Vector2(0.856f, -0.955f);
                _tintin.transform.localScale = new Vector3(0.868f, 0.868f, 1f);
                break;
            case 35:
                _tintin.transform.position = new Vector2(0.82f, -0.946f);
                _tintin.transform.localScale = new Vector3(0.94f, 0.94f, 1f);
                break;
            case 40:
                _tintin.transform.position = new Vector2(0.784f, -0.937f);
                _tintin.transform.localScale = new Vector3(1.012f, 1.012f, 1f);
                break;
            case 45:
                _tintin.transform.position = new Vector2(0.748f, -0.928f);
                _tintin.transform.localScale = new Vector3(1.084f, 1.084f, 1f);
                break;
            case 50:
                _tintin.transform.position = new Vector2(0.712f, -0.919f);
                _tintin.transform.localScale = new Vector3(1.156f, 1.156f, 1f);
                break;
            case 55:
                _tintin.transform.position = new Vector2(0.676f, -0.91f);
                _tintin.transform.localScale = new Vector3(1.228f, 1.228f, 1f);
                break;
            case 60: // Final pos & scale
                _tintin.transform.position = new Vector2(0.64f, -0.9f);
                _tintin.transform.localScale = new Vector3(1.3f, 1.3f, 1f);
                break;
            // Hi Animation
            case 65:
                _tintinLArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 15));
                break;
            case 70:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 75:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 80:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 85:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 90:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 95:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 100:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), -2f);
                break;
            case 105:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), -1f); // z = 0
                break;
            case 110:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 115:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 120:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 125:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 130:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 135:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 140:
                _tintinLArm.transform.Rotate(new Vector3(0, 0, 1), 2f);
                break;
            case 145:
                _tintinLArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 15));
                break;
            // Leave the balloons fly free!
            case 150:
                _tintinRArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 15));
//                _balloons.transform.position = new Vector2(-0.5f, 0.7f);
                break;
            case 155:
                _tintinRArm.transform.Rotate(new Vector3(0, 0, 1), 2.5f);
                _balloons.transform.position = new Vector3();
                break;
            case 160:
                _tintinRArm.transform.Rotate(new Vector3(0, 0, 1), 2.5f);
                break;
            case 165:
                _tintinRArm.transform.Rotate(new Vector3(0, 0, 1), 2.5f);
                break;
            case 170:
                _tintinRArm.transform.Rotate(new Vector3(0, 0, 1), 2.5f);
                break;
            case 175:
                _tintinRArm.transform.Rotate(new Vector3(0, 0, 1), 2.5f);
                break;
            case 180:
//                _balloons.transform.position = new Vector2(-0.5f,0.8f);
                _tintinRArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
                break;
        }
    }
}