using UnityEngine;
using UnityEngine.SceneManagement;
public class lesson1scene : MonoBehaviour
{
   public void PlayExcerise()
   {
     SceneManager.LoadScene("lesson1 excercisescene1");
   }

   public void backgame()
   {
     SceneManager.LoadScene("game");
   }
}
