using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// 
/// </summary>
public class BombProp : MonoBehaviour
{
    public static Transform BbTF; 

    private void Start()
    {
        BbTF= GetComponent<Transform>();
    }
}
