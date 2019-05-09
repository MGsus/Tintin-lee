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
       
            var _tNow = Time.time;
            if (CompareTag("NextBtn"))
            {
                if (_tNow > _tIni)
                {
                    _tIni = _tNow + DeltaT;
                    transform.position = new Vector3(4.62f, -1.91f);
                }
                else{
                    transform.position = new Vector3(4.39f, -1.91f);
                    }
            }
            else if (CompareTag("NextBtn3"))
            {
                if (_tNow > _tIni)
                {
                    _tIni = _tNow + DeltaT;
                    transform.position = new Vector3(6.17f, -1.91f);
                }
                else{
                    transform.position = new Vector3(6f, -1.91f);
                    }
            }
            else if (CompareTag("BackBtn"))
            {
                if (_tNow > _tIni)
                {
                    _tIni = _tNow + DeltaT;
                    transform.position = new Vector3(3.9f, -1.91f);
                }
                else{
                    transform.position = new Vector3(4f, -1.91f);
                    }
            }
           
        
    }

    private void OnMouseExit()
    {
        // transform.position = CompareTag("NextBtn") ? new Vector3(4.62f, -1.91f) : new Vector3(2.31f, -1.91f);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}