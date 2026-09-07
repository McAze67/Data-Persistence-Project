using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour
{

    string highScoreName;
    int highScoreValue;
    public TextMeshProUGUI highScoreText;
    private bool reset;
    public GameObject resetText;
    public Button resetButtonYes;
    public Button resetButtonNo;
    public GameObject highScores;

    void Awake()
    {
        highScoreValue = PersistData.Instance.highScore;
        highScoreName = PersistData.Instance.highScoreName;
        
        highScoreText.text = $" {highScoreName} " + " ---- " +  $"  {highScoreValue}"; 
    }
    
    
    public void BackMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetButton()
    {
        resetText.SetActive(true);
        highScores.SetActive(false);
        //highScoreText.gameObject.SetActive(false);
    }

    public void ResetHighScore()
    {
        highScoreValue =  0;
        PersistData.Instance.highScore = highScoreValue ;
        highScoreName = "";
        PersistData.Instance.highScoreName = highScoreName;
        BackMainMenu();
    }

    public void NotResetHighScore()
    {
        resetText.SetActive(false);
        highScores.SetActive(true);
        //highScoreText.gameObject.SetActive(true);
    }
    
}
