using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// 
/// </summary>
public class PlayerProp : MonoBehaviour                                
{
    private Transform PlayerTF;
    private Transform BombTF;
    private Vector3 pv3;
    private Vector3 bv3;
    private Vector3 dv3;//两者圆心向量
    private Vector3 tv1;//
    private Vector3 tv2;//切线

    private float distance;//两者圆心距离
    private GameObject BOMB;
    public float bombAngle;
    private float tvDistance;

    private void Start()
    {
        BOMB = GameObject.FindWithTag("Bomb");
        BombTF = BOMB.GetComponent<Transform>();
        PlayerTF = GetComponent<Transform>();                                                                                                  
        
    }
    private void Update()
    {
        pv3 = PlayerTF.position;
        bv3 = BombTF.position;
        dv3 = pv3 - bv3;
        distance = Mathf.Sqrt(dv3.x * dv3.x + dv3.z * dv3.z);
        //Debug.DrawLine(bv3, pv3);

        bombAngle = Mathf.Asin(0.5f / distance);
        tvDistance = 0.5f/Mathf.Tan(bombAngle);

        tv1 = Quaternion.Euler(0, bombAngle*180/Mathf.PI, 0) * (dv3.normalized*tvDistance);
        tv2 = Quaternion.Euler(0, -bombAngle*Mathf.Rad2Deg, 0) * (dv3.normalized*tvDistance);

        Debug.DrawLine(bv3, bv3 + tv1);
        Debug.DrawLine(bv3, bv3 + tv2);


    }
}
