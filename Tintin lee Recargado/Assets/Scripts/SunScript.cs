using UnityEngine;

public class SunScript : MonoBehaviour
{
    private int _cont = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
        _cont++;
        switch (_cont)
        {
            case 10:
                this.transform.localScale = new Vector3(1.01f, 1.01f);
                break;
            case 20:
                this.transform.localScale = new Vector3(1.02f, 1.02f);
                break;
            case 30:
                this.transform.localScale = new Vector3(1.03f, 1.03f);
                break;
            case 40:
                this.transform.localScale = new Vector3(1.04f, 1.04f);
                break;
            case 50:
                this.transform.localScale = new Vector3(1.05f, 1.05f);
                break;
            case 60:
                this.transform.localScale = new Vector3(1.04f, 1.04f);
                break;
            case 70:
                this.transform.localScale = new Vector3(1.03f, 1.03f);
                break;
            case 80:
                this.transform.localScale = new Vector3(1.02f, 1.02f);
                break;
            case 90:
                this.transform.localScale = new Vector3(1.01f, 1.01f);
                break;
            case 100:
                this.transform.localScale = new Vector3(1f, 1f);
                _cont = 0;
                break;
        }
    }
}