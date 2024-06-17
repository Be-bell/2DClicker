public class UpgradeAutoClick : Upgrade
{
    protected override void UpgradeLevel()
    {
        if(!isEnoughCoin()) return;
        base.UpgradeLevel();
    }

    protected override void LevelUpUI()
    {
        GameManager.Instance.data.autoClickUpgradeLv++;
        m_UpgradeLv.text = GameManager.Instance.data.autoClickUpgradeLv.ToString();
    }
}