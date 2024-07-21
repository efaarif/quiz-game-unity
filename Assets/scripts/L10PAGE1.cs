using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L10PAGE1 : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("game");
    }

    public void playL10PAGE2()
    {
        SceneManager.LoadScene("L10PAGE2");
    }
}
