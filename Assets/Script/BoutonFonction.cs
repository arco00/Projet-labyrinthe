using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonFonction : MonoBehaviour
{
     [SerializeField]
    private string changementCase="rempli";
    public void ChoixChangement(){
        //changement des cases
        //Debug.Log(gameObject.GetComponentInChildren<TextMeshPro>().text);    
        Saver.instance.changementCase=changementCase;
    }

    [SerializeField]
    private string scenetoload="rempli";
    public void ChangeScene() {
     Time.timeScale=1f;  // si on change depuis une pause 
     SceneManager.LoadScene(scenetoload);
   }

   public void Quit(){
    Application.Quit(); //marche pas directement dans unity
    Debug.Log("On quitte le jeu");
   }
}
