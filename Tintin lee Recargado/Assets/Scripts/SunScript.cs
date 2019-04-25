using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScript : MonoBehaviour
{
    private int _cont = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
        print(_cont);
        if (_cont > 60)
        {
            this.transform.localScale = new Vector3(1.1f, 1.1f);
            if (_cont == 120)
                _cont = 0;
        }
        else
        {
            _cont++;
            this.transform.localScale = new Vector3(1f, 1f);
        }
    }
}