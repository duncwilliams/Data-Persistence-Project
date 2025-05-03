using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private Button startButton;

    public static MenuManager instance;

    public string username;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startButton = GameObject.Find("Start Button").GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ReadStringInput(string input)
    {
        username = input;
    }

    private void StartGame()
    {
        Debug.Log(username);
        SceneManager.LoadScene("Main");
    }
}
