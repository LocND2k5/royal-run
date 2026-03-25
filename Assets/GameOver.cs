using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class GameOver : MonoBehaviour
{

    public void OnRestartClicked()
    {
        SceneManager.LoadScene("Game"); // đổi thành tên scene chơi của bạn
    }

    public void OnMenuClicked()
    {
        SceneManager.LoadScene("Main Menu");
    }  
}
