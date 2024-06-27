    using UnityEngine;
    using UnityEngine.SceneManagement;
    
    public class L1excerscene1 : MonoBehaviour
    {
       public void playexcercisescene2()
       {
        SceneManager.LoadScene("lesson1 excercisescene2");
       }

       public void backL1S()
       {
         SceneManager.LoadScene("lesson1 scene");
       }
    }

 