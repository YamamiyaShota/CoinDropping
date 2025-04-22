using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 //クラス//
public class ArrowMoving : MonoBehaviour
{
    [SerializeField, Tooltip("オブジェクトの初期値")] Vector3 _targetPos;
    [SerializeField, Tooltip("移動する距離")] float _movePos;

    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * _movePos + _targetPos.x, _targetPos.y, _targetPos.z);
    }
}
