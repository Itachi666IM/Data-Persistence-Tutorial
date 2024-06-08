using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class MenuUI : MonoBehaviour
{
    public Text HighScoreText;
    public TextMeshProUGUI PlayerNameInput;

    class HighScore
    {
        public string highScorePlayer;
        public int highScore;
    }

    private void Start()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            HighScore data = JsonUtility.FromJson<HighScore>(json);

            HighScoreText.text = "Best Score : " + data.highScorePlayer + " : " + data.highScore;
        }
        else
        {
            HighScoreText.text = "Best Score : name : 0";
        }
    }

    public void PlayGame()
    {
        NameManager.Instance.playerName = PlayerNameInput.text;
        NameManager.Instance.SavePlayerName();
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
