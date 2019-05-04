using UnityEngine;

public class SapoScript : MonoBehaviour
{
    private static GameObject _parentGameObject;
    private GameObject _sapoBody;
    private GameObject _sapoHand;
    private int _cont;

    // Start is called before the first frame update
    void Start()
    {
        _parentGameObject = GameObject.FindGameObjectWithTag("Sapo");
        _sapoBody = _parentGameObject.transform.GetChild(0).gameObject;
        _sapoHand = _parentGameObject.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_parentGameObject) return;
        switch (_cont)
        {
            case 1:
                _sapoBody.transform.localScale = new Vector3();
                break;
        }
    }
}