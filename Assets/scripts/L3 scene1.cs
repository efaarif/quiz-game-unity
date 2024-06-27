using UnityEngine;
using UnityEngine.SceneManagement;

public class L3scene1 : MonoBehaviour
{
   public void playL3_Escene1()
   {
    SceneManager.LoadScene("L3 ES1");
   }

   public void backgame()
   {
    SceneManager.LoadScene("game");
   }
}
