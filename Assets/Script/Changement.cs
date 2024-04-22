using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Changement : MonoBehaviour
{
    void OnMouseDown(){
        gameObject.GetComponentInChildren<TextMeshPro>().text=Saver.instance.changementCase;
    }
}
