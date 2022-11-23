using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    ����ģ��
*/
/// <summary>
/// �������ṩ�ƶ�����ת��Ѱ·���ܣ�
/// </summary>
public class EnemyMotor : MonoBehaviour
{
    public float moveSpeed = 3;
    private int currentPointIndex = 0;
    public Transform[] wayLine;
    /*private Transform thisTransform;

/// <summary>
/// ��ǰ�ƶ�
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
    /// ��ǰ�ƶ�
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
    ///ע����ת
    /// </summary>
    /// <param name="targetPoint">��Ҫע�ӵ�Ŀ���</param>
    public void LookRotation(Vector3 targetPoint)
    {
        this.transform.LookAt(targetPoint); 
    }

    /// <summary>
    /// Ѱ·����·�ߣ�vector3���ƶ���
    /// </summary>
    /// <returns>�Ƿ񵽴��յ�</returns>
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
            return false;//��Ҫ����Ѱ·
        }

        //�������Ŀ���(��ǰλ�� �� Ŀ����� Vector3.distance)
        //����Ŀ��㣨����һ��Ŀ����ƶ���

        //����Ŀ���
        //��ǰ�ƶ�
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
        if (GUILayout.Button("��ǰ��"))
        {
            InvokeRepeating("MovermentForward", 0, 0.02f);

        }
    }
    */


}
