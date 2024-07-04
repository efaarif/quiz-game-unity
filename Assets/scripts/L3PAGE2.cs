using UnityEngine;
using UnityEngine.SceneManagement;


public class L1PAGE2 : MonoBehaviour
{
   public void playL3PAGE3()
   {
      SceneManager.LoadScene("L3PAGE3");
   }

   public void backlL1PAGE1()
   {
      SceneManager.LoadScene("L3PAGE1");
   }
}
