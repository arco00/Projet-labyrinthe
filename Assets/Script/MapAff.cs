using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MapAff : MonoBehaviour
{

    private List<List<string>> carte;
    public GameObject map;
    public Configuration config;
    public Transform dossier;
    void Start()
    {
        carte =map.GetComponent<MapMatrix>().carte;
        float hauteur=0;
        float largeur=0;
        foreach (List<string> innerList in carte)
        {largeur=0;
            foreach(string mot in innerList){
                Vector3 pos=new Vector3(hauteur,largeur,0f);
                Quaternion rota=new Quaternion(0,0,0,1);
                
                if(mot=="murV" || mot=="murH"){
                   GameObject newMur =Instantiate (config.mur,pos,new Quaternion(0,90f*hauteur,0,1),dossier);
                }
                else if(mot=="murC")
                {
                    GameObject newJonction =Instantiate (config.jonction,pos,rota,dossier);
                }
                else{
                    GameObject newCase =Instantiate (config.cases,pos,rota,dossier);
                    newCase.GetComponentInChildren<TextMeshPro>().text=mot;
                }
                largeur=largeur+(1/2);
            }
            hauteur=hauteur+(1/2);
        }

    }

}
