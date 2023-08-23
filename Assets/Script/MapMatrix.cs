using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMatrix : MonoBehaviour
{
    public List<List<string>> carte= new List<List<string>>();
    public int tailleMapVertical;
    public int tailleMapHorizontal;

    void Awake()
    {
        //génération de la matrice du labyrinthe
       for(int i = 0; i < tailleMapVertical*2+1; i++){
            carte.Add(new List<string>());

            //ligne de chemin
            if (!Utile.Even(i)){
                for(int y = 0; y < tailleMapHorizontal*2+1; y++){
                    if (!Utile.Even(y)){
                        carte[i].Add("vide");
                        //Debug.Log("vide");
                    }
                    else{
                        carte[i].Add("murH");
                        //Debug.Log("murH");
                    }
                }
            }

            //ligne de mur
            else{
             for(int y = 0; y < tailleMapHorizontal*2+1; y++){
                    if (!Utile.Even(y)){
                        carte[i].Add("murV");
                        //Debug.Log("murV");
                    }
                    else{
                        carte[i].Add("murC");
                        //Debug.Log("murC");
                    }
                }
            }
            
        }

        //affichage de la matrice
        foreach (List<string> innerList in carte)
        {
            Debug.Log("Liste : " + string.Join(", ", innerList));
        }
        
        
    }
}
