using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text messageText;

    public void OpenWindow(bool winCase)
    {
        gameObject.SetActive(true);
        if (winCase)
        {
            messageText.text = "Congradulations";
        }
        else
        {
            messageText.text = "Unlucky";
        }
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("UI1");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
