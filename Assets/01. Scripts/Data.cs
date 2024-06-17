using System;
using System.Collections;
using UnityEngine;

public class Data : MonoBehaviour
{
    private int currentCoin = 0;
    public short clickUpgradeLv;
    public short autoClickUpgradeLv;

    public event Action<int> CoinEvent;

    [SerializeField] private float clickUpgradeCoef;
    [SerializeField] private float autoClickUpgradeCoef;
    [SerializeField] private float coolTime;
    private bool isCoolTime;

    public int CurrentCoin { get { return currentCoin; } }


    private void Start()
    {
        GameManager.Instance.data = this;
    }

    private void Update()
    {
        StartCoroutine(AutoClickCoin());
    }

    public void ClickCoin()
    {
        currentCoin += (int) (clickUpgradeLv * clickUpgradeCoef) + 1;
        CallbackCoin(currentCoin);
    }

    private IEnumerator AutoClickCoin()
    {
        if(!isCoolTime)
        {
            isCoolTime = true;
            currentCoin += (int)(autoClickUpgradeLv * autoClickUpgradeCoef);
            CallbackCoin(currentCoin);
            yield return new WaitForSeconds(coolTime);
            isCoolTime = false;
        }
    }

    public void UpgradeCoin(int coin)
    {
        currentCoin -= coin;
        CallbackCoin(currentCoin);
    }

    private void CallbackCoin(int coin)
    {
        CoinEvent.Invoke(coin);
    }
}