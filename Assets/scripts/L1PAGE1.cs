using UnityEngine;
using UnityEngine.SceneManagement;
public class lesson1scene : MonoBehaviour
{
   public void PlayExcerise()
   {
     SceneManager.LoadScene("L1PAGE2");
   }

   public void backgame()
   {
     SceneManager.LoadScene("game");
   }
}
