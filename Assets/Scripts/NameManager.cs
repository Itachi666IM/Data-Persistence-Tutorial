using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameManager : MonoBehaviour
{
    public static NameManager Instance;

    public string playerName;

    private void Awake()
    {
        if(Instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            SavePlayerName();
        }
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName;
    }

    public void SavePlayerName()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        
    }

}
