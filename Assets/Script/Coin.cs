using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] Vector3 _pos;
    [SerializeField,Tooltip("コインを消す高さ")] float _deadHeight;
    void Start()
    {
        _pos = transform.position;
    }

    void Update()
    {
        if(_pos.y <= _deadHeight)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "floor")
        {
            this.gameObject.transform.parent = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == ("floor"))
        {
            this.gameObject.transform.parent = null;
        }
    }
}
