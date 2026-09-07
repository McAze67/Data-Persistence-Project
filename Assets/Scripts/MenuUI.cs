
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUI : MonoBehaviour
{

    public TMP_InputField playerName;
    public GameObject noNameText;
    private bool hasName;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playerName != null)
        {
            playerName.onDeselect.AddListener(SavePlayerName);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SavePlayerName(string newName)
    {
        noNameText.SetActive(false);
        PersistData.Instance.PlayerName = newName;
        hasName = true;
    }
    
    
    public void StartNewGame()
    {
        if (hasName)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            noNameText.SetActive(true);
            Debug.Log("No player found");
        }
    }
    
    public void Quit()
    {
        PersistData.Instance.SaveHighScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    
    public void Tables()
    {
        SceneManager.LoadScene(2);
    }
    
}
