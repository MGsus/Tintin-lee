using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneName;

    private float _tIni = 0;
    private const float DeltaT = 0.4f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseOver()
    {
        if (this)
        {
            var _tNow = Time.time;
            if (CompareTag("NextBtn"))
            {
                if (_tNow > _tIni)
                {
                    _tIni = _tNow + DeltaT;
                    transform.position = new Vector3(4.62f, -1.91f);
                }
                else
                    transform.position = new Vector3(4.39f, -1.91f);
            }
            else
            {
                if (_tNow > _tIni)
                {
                    _tIni = _tNow + DeltaT;
                    transform.position = new Vector3(2.31f, -1.91f);
                }
                else
                    transform.position = new Vector3(2.50f, -1.91f);
            }
        }
    }

    private void OnMouseExit()
    {
        transform.position = CompareTag("NextBtn") ? new Vector3(4.62f, -1.91f) : new Vector3(2.31f, -1.91f);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}