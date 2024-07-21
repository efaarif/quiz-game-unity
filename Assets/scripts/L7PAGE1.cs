using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L7PAGE1 : MonoBehaviour
{
    public void backgame()
    {
        SceneManager.LoadScene("game");
    }

    public void playL7PAGE2()
    {
        SceneManager.LoadScene("L7PAGE2");
    }
}
