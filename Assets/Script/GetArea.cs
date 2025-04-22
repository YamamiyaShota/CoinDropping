using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetArea : MonoBehaviour
{
    [SerializeField] GameManager _manager;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            _manager.GetCoin();
            Destroy(collision.gameObject);
        }
    }
}
