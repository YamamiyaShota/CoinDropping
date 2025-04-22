using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMoving : MonoBehaviour
{
    [SerializeField,Tooltip("オブジェクトの初期値")] Vector3 _targetPos;
    [SerializeField,Tooltip("移動する距離")] float _movePos;

    void Update()
    {
        transform.position = new Vector3(_targetPos.x, _targetPos.y, Mathf.Sin(Time.time) * _movePos + _targetPos.z);
    }
}
