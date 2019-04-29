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
            if (_tNow > _tIni)
            {
                _tIni = _tNow + DeltaT;
                this.transform.position = new Vector3(4.09f, -1.91f);
            }
            else
            {
                this.transform.position = new Vector3(4.39f, -1.91f);
            }
        }
    }

    private void OnMouseExit()
    {
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}