using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L5PAGE2 : MonoBehaviour
{
    public void backL5PAGE1()
    {
        SceneManager.LoadScene("L5PAGE1");
    }

    public void playL5PAGE3()
    {
        SceneManager.LoadScene("L5PAGE3");
    }
}
