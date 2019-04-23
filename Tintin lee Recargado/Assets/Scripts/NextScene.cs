using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneName;

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
    }

    private void OnMouseExit()
    {
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}