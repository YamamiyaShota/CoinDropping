using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Tooltip("コインの所持数")] public int coinCount = 0;

    [SerializeField] GameObject _coin;
    [SerializeField,Tooltip("コインの発射速度")] float _shootPower;
    [SerializeField,Tooltip("コインを持っていない時間")] float _deadTime = 3f;
    [SerializeField] float _cout;
    [SerializeField,Tooltip("コインの所持数を表示させる用")] TextMeshProUGUI _coinText;

    [SerializeField] GameObject _arrow;
    [SerializeField] GameObject _gameOverUI;

    void Start()
    {
        _gameOverUI.SetActive(false);
        _coinText.text = "Coin : " + coinCount.ToString();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShootCoin();
        }

        if (coinCount == 0)
        {
            _cout += Time.deltaTime;
        }
        else
        {
            _cout = 0;
        }

        if (_cout >= _deadTime)
        {
            GameOver();
        }
    }

    public void ShootCoin()
    {
        if(coinCount <= 0)
        {
            return;
        }
        coinCount--;
        Instantiate(_coin, new Vector3(_arrow.transform.position.x,_arrow.transform.position.y - 1,_arrow.transform.position.z),Quaternion.identity);
        _coinText.text = "Coin : " + coinCount.ToString();
    }

    public void GetCoin()
    {
        coinCount++;
        _coinText.text = "Coin : " + coinCount.ToString();
    }

    public void GameOver()
    {
         _gameOverUI.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}