using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L8PAGE1 : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("game");
    }

    public void playL8PAGE2()
    {
        SceneManager.LoadScene("L8PAGE2");
    }
}
