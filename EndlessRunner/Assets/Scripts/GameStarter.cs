using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    public GameObject startScreen; // ���� ȭ�� UI
    public Button startButton; // ���� ��ư
    public GameObject scoreText; // ���ھ� �ؽ�Ʈ UI
    public Button exitButton; // ���� ��ư
    public Button restartButton; // ����� ��ư
    public GameObject gameOverPanel; // ���ӿ��� �г�

    public static bool gameStarted = false; // ���� ���� ����

    void Start()
    {
        scoreText.SetActive(false); // ���� ���� ���� ���ھ� �ؽ�Ʈ ��Ȱ��ȭ
        gameOverPanel.SetActive(false); // ���ӿ��� �г� �ʱ� ��Ȱ��ȭ

        startButton.onClick.AddListener(StartGame); // ���� ��ư Ŭ�� �̺�Ʈ �߰�
        exitButton.onClick.AddListener(ExitGame); // ���� ��ư Ŭ�� �̺�Ʈ �߰�
        restartButton.onClick.AddListener(RestartGame); // ����� ��ư Ŭ�� �̺�Ʈ �߰�
    }

    void StartGame()
    {
        gameStarted = true;
        startScreen.SetActive(false); // ���� ȭ�� ��Ȱ��ȭ
        scoreText.SetActive(true); // ���ھ� �ؽ�Ʈ Ȱ��ȭ
    }

    void ExitGame()
    {
        // Unity Editor���� ���� ���� ��� �÷��� ��带 ����
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // ����� ������ ����
#endif
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
