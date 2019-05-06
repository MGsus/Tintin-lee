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
                //TODO: Add more frames
                case 1:
                    transform.position = new Vector2(transform.position.x, -0.313f); // Initial position
                    break;
                case 10:
                    transform.position = new Vector2(transform.position.x, -0.269f); // -0.269 Final position
                    break;
                case 55:
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
                //TODO: Add more frames
                case 1:
                    transform.position = new Vector2(transform.position.x, -0.287f); // Initial position
                    break;
                case 10:
                    transform.position = new Vector2(transform.position.x, -0.228f); //-0.228 Final position
                    break;
                case 55:
                    transform.position = new Vector2(transform.position.x, -0.287f); // Back to initial pos
                    break;
                case 200:
                    _cont = 0;
                    break;
            }
        }
    }
}