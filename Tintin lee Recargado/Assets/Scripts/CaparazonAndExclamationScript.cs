using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CaparazonAndExclamationScript : MonoBehaviour
{
    private int _cont = 0;
    private Transform _caparazonTransform;
    private Transform _exclamacionTransform;

    private void Start()
    {
        if (gameObject.name == "Caparazon")
            _caparazonTransform = transform;
        else
            _exclamacionTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        _cont++;
        if (gameObject.name == "Caparazon")
        {
            switch (_cont)
            {
                case 1:
                    _caparazonTransform.localScale = Vector3.zero; // Min Scale
                    break;
                case 5:
                    _caparazonTransform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    break;
                case 10:
                    _caparazonTransform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    break;
                case 15:
                    _caparazonTransform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
                    break;
                case 20:
                    _caparazonTransform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                    break;
                case 25:
                    _caparazonTransform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    break;
                case 30:
                    _caparazonTransform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                    break;
                case 35:
                    _caparazonTransform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                    break;
                case 40:
                    _caparazonTransform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                    break;
                case 45:
                    _caparazonTransform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                    break;
                case 50:
                    _caparazonTransform.localScale = Vector3.one;
                    break;
                case 55:
                    _caparazonTransform.localScale = Vector3.one; // Max Scale
                    break;
                case 230:
                    _caparazonTransform.localScale = Vector3.zero;
                    _cont = 0;
                    break;
            }
        }
        else
        {
            switch (_cont)
            {
                case 1:
                    _exclamacionTransform.localScale = Vector3.zero;
                    break;
                case 55:
                    _exclamacionTransform.localScale = Vector3.one;
                    break;
                case 230:
                    _exclamacionTransform.localScale = Vector3.zero;
                    _cont = 0;
                    break;
            }
        }
    }
}