using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionScript : MonoBehaviour
{
    //Scene name for change by click on Olvidadiza Button
    public string sceneName;
    private int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseOver()
    {
        transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
    }

    private void OnMouseExit()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Olvidadiza"))
        {
            // TODO Play congratulations sound

            for (timer = 0; timer < 5000; timer++)
                print(timer);

            SceneManager.LoadScene(sceneName);
        }
        else
        {
            // Play fail sound
            print(gameObject.name);
        }
    }
}