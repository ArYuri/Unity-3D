using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// 
/// </summary>
public class EnemySpawn : MonoBehaviour
{
    //��Ҫ�����ĵ���Ԥ�Ƽ�����
    public GameObject[] EnemyType;
    /// <summary>
    /// ��Ҫ�����ĵ����������
    /// </summary>
    public int maxEnemyCount = 5;
    /// <summary>
    /// ��ʼͬʱ�����ĵ�����Ŀ
    /// </summary>
    public int startEnemyCount = 2;
    /// <summary>
    /// �Ѿ������ĵ�������
    /// </summary>
    private int spawnedCount;
}
