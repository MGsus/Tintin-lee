using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionScript : MonoBehaviour
{
    //Scene name for change by click on Olvidadiza Button
    public string sceneName;
    public AudioClip olvidadiza;
    public AudioClip alegre;
    public AudioClip generosa;
    public AudioClip grosera;
    public AudioClip intentalo;
    public AudioClip juiciosa;
    public AudioClip amable;
    public AudioClip bien;


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
            SoundManager.Instance.PlaySingle(bien);
            SceneManager.LoadScene(sceneName);
        }
        else
            SoundManager.Instance.PlaySingle(intentalo);
    }

    private void OnMouseEnter()
    {
        switch (gameObject.name)
        {
            case "BtnAlegre":
                SoundManager.Instance.PlaySingle(alegre);
                break;
            case "BtnGenerosa":
                SoundManager.Instance.PlaySingle(generosa);
                break;
            case "BtnGrosera":
                SoundManager.Instance.PlaySingle(grosera);
                break;
            case "BtnAmable":
                SoundManager.Instance.PlaySingle(amable);
                break;
            case "BtnJuiciosa":
                SoundManager.Instance.PlaySingle(juiciosa);
                break;
            case "BtnOlvidadiza":
                SoundManager.Instance.PlaySingle(olvidadiza);
                break;
        }
    }
}