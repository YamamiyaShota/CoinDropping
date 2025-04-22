using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpwner : MonoBehaviour
{
    [SerializeField] GameObject _coin;
    [SerializeField] int _coinNum;
    [SerializeField] GameObject _upFloor;
    [SerializeField] GameObject _floor;
    [SerializeField,Tooltip("コイン生成時の範囲")] Vector2 _spawnerPos;
    void Start()
    {
        CreateInitial();
    }

    /// <summary>コインの初期生成</summary>
    private void CreateInitial()
    {
        for (int i = 0; i < _coinNum; i++)
        {
            var x = Random.Range(0, _spawnerPos.x);
            var z = Random.Range(0, _spawnerPos.y);
            Instantiate(_coin, new Vector3(x, _upFloor.transform.position.y+1, z), Quaternion.identity);
        }
        for (int i = 0; i < _coinNum; ++i)
        {
            var x = Random.Range(0, _spawnerPos.x);
            var z = Random.Range(0, _spawnerPos.y);
            Instantiate(_coin, new Vector3(x, _floor.transform.position.y+1, z), Quaternion.identity);
        }
    }
}
