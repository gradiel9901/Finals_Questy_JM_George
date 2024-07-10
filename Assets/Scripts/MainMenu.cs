using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayTutorial()
   {
        SceneManager.LoadSceneAsync(1);
   }
   public void QuitGame()
   {
      Application.Quit();
   }
   public void ShowMenu()
   {
      SceneManager.LoadSceneAsync(0);
   }
   public void PlayGame()
   {
        SceneManager.LoadSceneAsync(2);
   }
}
