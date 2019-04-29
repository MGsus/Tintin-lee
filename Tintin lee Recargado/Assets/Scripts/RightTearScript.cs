using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightTearScript : MonoBehaviour
{
    private const float FallSpeed = 0.005f;
    private Vector3 _position;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        _position += Vector3.right * FallSpeed;
        _position += Vector3.down * FallSpeed;
        transform.position = _position;
    }
}