using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    public static Saver instance ;
    public string changementCase;

    void Awake()
    {
        if(Saver.instance==null){
        instance=this;
        DontDestroyOnLoad(gameObject);}
        else{
            Destroy(gameObject);
        }
    }
}
