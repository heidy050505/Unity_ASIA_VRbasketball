using UnityEngine;
using UnityEngine.SceneManagement;   //引用 場景管理器 API

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene("籃球機");
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        //應用程式.離開遊戲()
        Application.Quit();
    }
}
