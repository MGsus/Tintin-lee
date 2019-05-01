using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearScript : MonoBehaviour
{
    private const float FallSpeed = 0.002f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameObject.tag)
        {
            case "LagrimaDer":
                transform.position = new Vector3(transform.position.x + FallSpeed, transform.position.y - FallSpeed);
                break;
            case "LagrimaIzq":
                transform.position = new Vector3(transform.position.x-FallSpeed, transform.position.y - FallSpeed);
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 20f));
                break;
        }
    }
}