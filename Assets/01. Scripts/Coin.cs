using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    TextMeshProUGUI m_coin;

    private void Awake()
    {
        m_coin = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        GameManager.Instance.data.CoinEvent += UpdateCoin;
    }

    private void UpdateCoin(int coin)
    {
        m_coin.text = coin.ToString();
    }
}