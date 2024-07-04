    using UnityEngine;
    using UnityEngine.SceneManagement;
    
    public class L1excerscene1 : MonoBehaviour
    {
       public void playexcercisescene2()
       {
        SceneManager.LoadScene("L1PAGE3");
       }

       public void backL1S()
       {
         SceneManager.LoadScene("L1PAGE1");
       }
    }

 