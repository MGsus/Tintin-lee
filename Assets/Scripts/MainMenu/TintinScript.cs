using UnityEngine;

namespace MainMenu
{
    public class TintinScript : MonoBehaviour
    {
        private static GameObject _tintin;
        private GameObject _tintinLArm;
        private GameObject _tintinRArm;
        private GameObject _tintinRFoot;
        private GameObject _tintinLFoot;
        private GameObject _balloons;
        private GameObject _greenB;
        private GameObject _blueB;
        private GameObject _redB;
        private GameObject _fluoB;
        private GameObject _purpleB;
        internal int _count;
    
    
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

            _greenB = _balloons.transform.GetChild(0).gameObject;
            _blueB = _balloons.transform.GetChild(1).gameObject;
            _redB = _balloons.transform.GetChild(2).gameObject;
            _fluoB = _balloons.transform.GetChild(3).gameObject;
            _purpleB = _balloons.transform.GetChild(4).gameObject;
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
                    break;
                case 155:
                    _tintinRArm.transform.Rotate(new Vector3(0, 0, 1), 2.5f);
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
                    _tintinRArm.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 30));
                    break;
                /********** Balloon Animations ***********
             *
             * Initial positions for each balloon:
             *     GreenB = x: -0.45f, y: 0.81f
             *     BlueB = x: -0.45f, y: 0,78f
             *     RedB = x: -0.44f, y: 0.73f
             *     FluoB  = x: -0.55f, y: 0.76f
             *     purpleB = x: -0.5f, y: 0.7f
             * 
             ****************************************/

                case 185:
                    _greenB.transform.position = new Vector2(-0.45f, 0.81f);
                    _blueB.transform.position = new Vector2(-0.45f, 0.78f);
                    _redB.transform.position = new Vector2(-0.44f, 0.73f);
                    _fluoB.transform.position = new Vector2(-0.55f, 0.76f);
                    _purpleB.transform.position = new Vector2(-0.5f, 0.7f);
                    break;
                case 190:
                    _greenB.transform.position = new Vector2(-0.456f, 0.8785f);
                    _blueB.transform.position = new Vector2(-0.3822f, 0.78f);
                    _redB.transform.position = new Vector2(-0.44f, 0.73f);
                    _fluoB.transform.position = new Vector2(-0.55f, 0.76f);
                    _purpleB.transform.position = new Vector2(0.45359f, 0.784f);
                    break;
                case 195:
                    _greenB.transform.position = new Vector3(-0.652f, 0.947f);
                    _blueB.transform.position = new Vector3(-0.3144f, 0.853f);
                    break;
                case 200:
                    _greenB.transform.position = new Vector3(-0.848f, 1.0155f);
                    _blueB.transform.position = new Vector3(-0.2466f, 0.922f);
                    break;
                case 205:
                    _greenB.transform.position = new Vector3(-1.004f, 1.084f);
                    _blueB.transform.position = new Vector3(-0.1788f, 0.991f);
                    break;
                case 210:
                    _greenB.transform.position = new Vector3(-1.24f, 1.1525f);
                    _blueB.transform.position = new Vector3(-0.111f, 1.06f);
                    break;
                case 215:
                    _greenB.transform.position = new Vector3(-1.436f, 1.221f);
                    _blueB.transform.position = new Vector3(-0.0432f, 1.129f);
                    break;
                case 220:
                    _greenB.transform.position = new Vector3(-1.632f, 1.2895f);
                    _blueB.transform.position = new Vector3(0.0246f, 1.198f);
                    break;
                case 225:
                    _greenB.transform.position = new Vector3(-1.828f, 1.358f);
                    _blueB.transform.position = new Vector3(0.0924f, 1.267f);
                    break;
                case 230:
                    _greenB.transform.position = new Vector3(-2.024f, 1.4265f);
                    _blueB.transform.position = new Vector3(0.1602f, 1.336f);
                    break;
                case 235:
                    _greenB.transform.position = new Vector3(-2.22f, 1.495f);
                    _blueB.transform.position = new Vector3(0.228f, 1.405f);
                    break;
                case 240:
                    _greenB.transform.position = new Vector3(-2.416f, 1.5635f);
                    _blueB.transform.position = new Vector3(0.2958f, 1.474f);
                    break;
                case 245:
                    _greenB.transform.position = new Vector3(-2.612f, 1.632f);
                    _blueB.transform.position = new Vector3(0.3636f, 1.543f);
                    break;
                case 250:
                    _greenB.transform.position = new Vector3(-2.808f, 1.7005f);
                    _blueB.transform.position = new Vector3(0.4314f, 1.612f);
                    break;
                case 255:
                    _greenB.transform.position = new Vector3(-3.004f, 1.769f);
                    _blueB.transform.position = new Vector3(0.4992f, 1.681f);
                    break;

                /* Final positions per balloon
             *
             * GreenB = x: -3.2, y: 1.77
             * BlueB = x: 0.5, y: 1.75
             * RedB = x: -1.2, y: 1.8
             * FluoB = x: 1.4, y: 1.93
             * PurpleB = x: -4.2, y: 1.97
             */
                case 260: // Final pos 
                    _greenB.transform.position = new Vector3(-3.2f, 1.77f);
                    _blueB.transform.position = new Vector3(0.5f, 1.75f);
                    _redB.transform.position = new Vector3(-1.2f, 1.8f);
                    _fluoB.transform.position = new Vector3(1.4f, 1.93f);
                    _purpleB.transform.position = new Vector3(-4.2f, 1.97f);
                    break;
            }
        }
    }
}