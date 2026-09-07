using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PersistData : MonoBehaviour
{
    public static  PersistData Instance;
    public string PlayerName;
    public int highScore;
    public string highScoreName;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScore();

    }
    [System.Serializable]
    class SaveData
    {
        public String HighScoreName;
        public int HighScore;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.HighScoreName = highScoreName;
        data.HighScore = highScore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScoreName = data.HighScoreName;
            highScore = data.HighScore;
        }
    }
   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
