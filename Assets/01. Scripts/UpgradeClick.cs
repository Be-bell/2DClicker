public class UpgradeClick : Upgrade
{
    protected override void UpgradeLevel()
    {
        if (!isEnoughCoin()) return;
        base.UpgradeLevel();
    }

    protected override void LevelUpUI()
    {
        GameManager.Instance.data.clickUpgradeLv++;
        m_UpgradeLv.text = GameManager.Instance.data.clickUpgradeLv.ToString();
    }
}