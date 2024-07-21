using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L14PAGE1 : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("game");
    }

    public void playL14PAGE2()
    {
        SceneManager.LoadScene("L14PAGE2");
    }
}
