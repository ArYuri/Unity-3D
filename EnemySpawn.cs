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
    //需要创建的敌人预制件数组
    public GameObject[] EnemyType;
    /// <summary>
    /// 需要创建的敌人最大数量
    /// </summary>
    public int maxEnemyCount = 5;
    /// <summary>
    /// 开始同时创建的敌人数目
    /// </summary>
    public int startEnemyCount = 2;
    /// <summary>
    /// 已经创建的敌人数量
    /// </summary>
    private int spawnedCount;
}
