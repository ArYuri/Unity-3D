using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// 敌人动画，定义需要播放动画的名称
/// </summary>
public class EnemyAnimation : MonoBehaviour
{
    /// <summary>
    /// 攻击动画名称
    /// </summary>
    public string attackAminName;
    /// <summary>
    /// 闲置动画名称
    /// </summary>
    public string idleAminName;
    /// <summary>
    /// 跑步动画名称
    /// </summary>
    public string runAminName;
    /// <summary>
    /// 死亡动画名称
    /// </summary>
    public string deathAminName;

    public AnimationAction action;

    private void Awake()
    {
        //action = new AnimationAction();
    }
}
