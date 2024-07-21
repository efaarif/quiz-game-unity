using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L12PAGE1 : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("game");
    }

    public void playL12PAGE2()
    {
        SceneManager.LoadScene("L12PAGE2");
    }
}
