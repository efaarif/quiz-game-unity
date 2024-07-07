using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L5PAGE1 : MonoBehaviour
{
    public void backgame()
    {
        SceneManager.LoadScene("game");
    }

    public void playL5PAGE2()
    {
        SceneManager.LoadScene("L5PAGE2");
    }
}
