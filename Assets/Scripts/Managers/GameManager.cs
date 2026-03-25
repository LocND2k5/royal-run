using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải thêm thư viện này để thao tác với Scene

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
    [SerializeField] TMP_Text timeText;
    [SerializeField] GameObject gameOverText; // Bạn có thể xóa biến này ở Editor nếu không dùng UI Text ở scene hiện tại nữa
    [SerializeField] float startTime = 5f;

    float timeLeft;
    bool gameOver = false;

    public bool GameOver => gameOver;

    void Start()
    {
        timeLeft = startTime;
    }

    void Update()
    {
        DecreaseTime();
    }

    public void IncreaseTime(float amount)
    {
        timeLeft += amount;
    }

    void DecreaseTime()
    {
        if (gameOver) return;

        timeLeft -= Time.deltaTime;
        timeText.text = timeLeft.ToString("F1");

        if (timeLeft <= 0f)
        {
            PlayerGameOver();
        }
    }

    void PlayerGameOver()
    {
        gameOver = true;
        playerController.enabled = false;

        // Reset lại tốc độ game về bình thường trước khi sang scene mới
        Time.timeScale = 1f;

        // Load scene GameOver (Dựa vào video, file scene của bạn tên chính xác là "GameOver")
        SceneManager.LoadScene("GameOver");
    }
}