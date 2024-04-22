using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;

public class ChangementMur : MonoBehaviour
{
    public bool ouvert =false ;

    void OnMouseDown(){
        //ouvrir et fermer un mur
        ouvert= !ouvert;
        gameObject.GetComponent<SpriteRenderer>().enabled= !ouvert;
    }
}
