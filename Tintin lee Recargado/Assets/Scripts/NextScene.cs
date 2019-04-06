using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        // Play Animation
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
