using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(GameManager.Instance.data.ClickCoin);
    }

}
