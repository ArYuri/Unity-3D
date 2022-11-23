using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    敌人模块
*/
/// <summary>
/// 敌人马达，提供移动，旋转，寻路功能；
/// </summary>
public class EnemyMotor : MonoBehaviour
{
    public float moveSpeed = 3;
    private int currentPointIndex = 0;
    public Transform[] wayLine;
    /*private Transform thisTransform;

/// <summary>
/// 向前移动
/// </summary>
public void MovermentForward()
{
thisTransform.localPosition += new Vector3(0, 0, 0.01f);
}
public void MovermentBack()
{
thisTransform.localPosition += new Vector3(0, 0, -0.01f);
}
public void MovermentLeft()
{
thisTransform.localPosition += new Vector3(-0.01f, 0, 0);
}
public void MovermentRight()
{
thisTransform.localPosition += new Vector3(0.01f, 0, 0);
}*/
    /// <summary>
    /// 向前移动
    /// </summary>
    public void MovermentForward()
    {
        this.transform.Translate(0, 0, moveSpeed*Time.deltaTime);
    }
    public void MovermentBack()
    {
        this.transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
    }
    public void MovermentLeft()
    {
        this.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
    }
    public void MovermentRight()
    {
        this.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
    }

    /// <summary>
    ///注视旋转
    /// </summary>
    /// <param name="targetPoint">需要注视的目标点</param>
    public void LookRotation(Vector3 targetPoint)
    {
        this.transform.LookAt(targetPoint); 
    }

    /// <summary>
    /// 寻路，沿路线（vector3）移动；
    /// </summary>
    /// <returns>是否到达终点</returns>
    public bool Pathfinding()
    {
        if (wayLine== null||currentPointIndex >= wayLine.Length)
        {
            return true;
           
        }
        else 
        {
            if (Vector3.Distance(this.transform.position, wayLine[currentPointIndex].position) < 0.2f)
            {
                LookRotation(wayLine[currentPointIndex].position);
                currentPointIndex++;
            }
            MovermentForward();
            return false;//需要继续寻路
        }

        //如果到达目标点(当前位置 与 目标点间距 Vector3.distance)
        //更新目标点（向下一个目标点移动）

        //朝向目标点
        //向前移动
    }
    private void Start()
    {
        this.transform.position = wayLine[currentPointIndex].position;
    }
    private void Update()
    {
        Pathfinding();
    }


    /*
    public void OnGUI()
    {
        if (GUILayout.Button("向前走"))
        {
            InvokeRepeating("MovermentForward", 0, 0.02f);

        }
    }
    */


}
