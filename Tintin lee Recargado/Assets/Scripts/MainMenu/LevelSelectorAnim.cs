using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectorAnim : MonoBehaviour
{
    private TintinScript _tintinScript;
    private GameObject _claritaB;
    private GameObject _encuentroB;
    private GameObject _gamesB;
    private GameObject _tintin;
    private GameObject _bg;
    private GameObject _clouds;
    private int _count;

    private void Awake()
    {
        _claritaB = transform.GetChild(0).gameObject;
        _encuentroB = transform.GetChild(1).gameObject;
        _gamesB = transform.GetChild(2).gameObject;
        _tintin = transform.GetChild(3).gameObject;
        _clouds = transform.GetChild(4).gameObject;
        _bg = transform.GetChild(5).gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        _tintinScript = _tintin.GetComponent<TintinScript>();
    }

    // Update is called once per frame
    void Update()
    {
        _count = _tintinScript._count;
        _count++;
        if (_count < 261) return;

        switch (_count)
        {
            case 262:
                _claritaB.SetActive(true);
                _encuentroB.SetActive(true);
                _gamesB.SetActive(true);
                _tintin.SetActive(false);
                _clouds.SetActive(false);
                _bg.transform.localScale = new Vector3(1.5f, 1.5f, 1f);
                break;
        }
    }
}