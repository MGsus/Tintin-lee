using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClaritaScript : MonoBehaviour
{
    public string sceneName;
    private static GameObject parentGameObject;
    private GameObject claritaHead;
    private GameObject claritaHeadL;
    public AudioClip clarita;
    private int cont;

    // Start is called before the first frame update
    private void Start()
    {
        parentGameObject = GameObject.FindGameObjectWithTag("Clarita1");
        claritaHead = parentGameObject.transform.GetChild(0).gameObject;
        claritaHeadL = parentGameObject.transform.GetChild(1).gameObject;
    }

    private void OnMouseEnter()
    {
        SoundManager.Instance.PlaySingle(clarita);
    }

    private void OnMouseOver()
    {
        // Animation
        if (parentGameObject)
        {
            cont++;
            parentGameObject.transform.localScale = new Vector3(1.1f, 1.1f, 1);
            switch (cont)
            {
                case 60:
                    claritaHead.SetActive(false);
                    claritaHeadL.SetActive(true);
                    parentGameObject.transform.Rotate(new Vector3(0, 0, 1), -3f);
                    break;
                case 120:
                    claritaHead.SetActive(true);
                    claritaHeadL.SetActive(false);
                    parentGameObject.transform.Rotate(new Vector3(0, 0, -1), -3f);
                    cont = 0;
                    break;
            }
        }
    }

    private void OnMouseExit()
    {
        if (parentGameObject)
        {
            claritaHead.SetActive(true);
            claritaHeadL.SetActive(false);
            parentGameObject.transform.localScale = new Vector3(1, 1, 1);
            parentGameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}