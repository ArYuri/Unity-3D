using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// ���˶�����������Ҫ���Ŷ���������
/// </summary>
public class EnemyAnimation : MonoBehaviour
{
    /// <summary>
    /// ������������
    /// </summary>
    public string attackAminName;
    /// <summary>
    /// ���ö�������
    /// </summary>
    public string idleAminName;
    /// <summary>
    /// �ܲ���������
    /// </summary>
    public string runAminName;
    /// <summary>
    /// ������������
    /// </summary>
    public string deathAminName;

    public AnimationAction action;

    private void Awake()
    {
        //action = new AnimationAction();
    }
}
