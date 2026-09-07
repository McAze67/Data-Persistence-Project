using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighScoreTable : MonoBehaviour
{

    public string highScoreName;
    public int highScoreValue;
    public TextMeshProUGUI highScoreText;

    void Awake()
    {
        highScoreValue = PersistData.Instance.highScore;
        highScoreName = PersistData.Instance.highScoreName;
        
        highScoreText.text = $"High Score : {highScoreValue}" + $"  From :  {highScoreName}";
    }
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void BackMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
