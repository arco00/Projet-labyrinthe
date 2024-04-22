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
    private Vector3 pos;

    void Start()
    {
        carte =map.GetComponent<MapMatrix>().carte;
        float hauteur=0;
        float largeur=0;
        float rotation=0;

        // pour afficher le labyrinthe
        foreach (List<string> innerList in carte)
        {largeur=0;
            foreach(string mot in innerList){
                pos=new (largeur,hauteur,0f);
                Quaternion rota=new Quaternion(0,0,0,1);
                
                if(mot=="murV" || mot=="murH"){
                    rotation=0;
                    if(!Utile.Even(Mathf.RoundToInt(hauteur*2))){
                        //savoir quel mur il faut mettre
                        rotation=90;
                    }
                    Quaternion rotat= Quaternion.Euler(0, 0, rotation);
                    GameObject newMur =Instantiate (config.mur,pos,new Quaternion(0,0,0,1),dossier);
                    newMur.transform.rotation=rotat;

                    if(pos.x==0 || pos.y==0 ){
                        //désactiver l'ouverture du mur si il est sur les bords
                        newMur.GetComponent<BoxCollider2D>().enabled=false;
                    }
                }
                else if(mot=="murC")
                {
                    //afficher les croisement(pilier entre les mur)
                    GameObject newJonction =Instantiate (config.jonction,pos,rota,dossier);
                }
                else{
                    //afficher les case
                    GameObject newCase =Instantiate (config.cases,pos,rota,dossier);
                    newCase.GetComponentInChildren<TextMeshPro>().text=mot;
                }
                largeur=largeur+0.5f;
            }
            hauteur=hauteur+0.5f;
        }

    }

}
