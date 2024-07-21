using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L15PAGE1 : MonoBehaviour
{
    public void playgame()
    {
        SceneManager.LoadScene("game");
    }

    public void playL15PAGE2()
    {
        SceneManager.LoadScene("L15PAGE2");
    }
}
