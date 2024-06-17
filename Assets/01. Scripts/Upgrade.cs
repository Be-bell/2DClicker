using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class Upgrade : MonoBehaviour
{
    protected Button UpgradeBtn;
    [SerializeField] protected TextMeshProUGUI m_UpgradeCost;
    [SerializeField] protected TextMeshProUGUI m_UpgradeLv;
    [SerializeField] protected int upgradeCost = 1000;

    // Start is called before the first frame update
    protected void Start()
    {
        UpgradeBtn = GetComponentInChildren<Button>();
        UpgradeBtn.onClick.AddListener(UpgradeLevel);
        m_UpgradeCost.text = upgradeCost.ToString();
        m_UpgradeLv.text = "0";
    }

    protected virtual void UpgradeLevel()
    {
        GameManager.Instance.data.UpgradeCoin(upgradeCost);
        upgradeCost = (int)(upgradeCost * 1.2f);
        m_UpgradeCost.text = upgradeCost.ToString();
        LevelUpUI();
    }

    protected bool isEnoughCoin()
    {
        return GameManager.Instance.data.CurrentCoin >= upgradeCost;
    }

    protected abstract void LevelUpUI();
    

}
