using UnityEngine;
using UnityEngine.SceneManagement;

public class L2scene1 : MonoBehaviour
{
    public void backgame()
    {
        SceneManager.LoadScene("game");
    }

    public void nextexcercise()
    {
        SceneManager.LoadScene("L2PAGE2");
    }
}
