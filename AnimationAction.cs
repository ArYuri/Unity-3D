using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// 动画行为类
/// </summary>
public class AnimationAction
{
    private Animation アニメ;
    /// <summary>
    /// 创建动画行为类
    /// </summary>
    /// <param name="アニメ">附加在敌人模型上的动画组件引用</param>
    public AnimationAction(Animation アニメ)
    {
        this.アニメ = アニメ;
    }
    /// <summary>
    /// 播放动画
    /// </summary>
    public void Play(string animName)
    {
        アニメ.CrossFade(animName);
    }
}
