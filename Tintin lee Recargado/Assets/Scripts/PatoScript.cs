using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatoScript : MonoBehaviour
{
    private static GameObject parentGameObject;
    private GameObject patoLfHead;
    private GameObject patoRfHead;
    private int cont;

    // Start is called before the first frame update
    void Start()
    {
        parentGameObject = GameObject.FindGameObjectWithTag("Pato");
        patoLfHead = parentGameObject.transform.GetChild(1).gameObject;
        patoRfHead = parentGameObject.transform.GetChild(2).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!parentGameObject) return;
        cont++;
        switch (cont)
        {
            case 100:
                patoLfHead.SetActive(true);
                patoRfHead.SetActive(false);
                break;
            case 110:
                patoLfHead.SetActive(false);
                patoRfHead.SetActive(true);
                break;
            case 120:
                patoLfHead.SetActive(true);
                patoRfHead.SetActive(false);
                break;
            case 130:
                patoLfHead.SetActive(false);
                patoRfHead.SetActive(true);
                cont = 0;
                break;
        }
    }
}