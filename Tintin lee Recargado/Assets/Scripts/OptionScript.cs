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
        // TODO Play shine and sound
    void OnMouseOver(){
    }

    private void OnMouseDown(){
        if (this.gameObject.CompareTag("Olvidadiza"))
        {
            // TODO Play congratulations sound
            
            for (timer = 0; timer < 5000; timer++)
                print(timer);
            
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            // Play fail sound
            print(this.gameObject.name);
        }
    }
}
