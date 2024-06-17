using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public Data data;
    public static GameManager Instance { get { return instance; } }

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(instance);
        }

        instance = this;

        DontDestroyOnLoad(gameObject);

    }
}