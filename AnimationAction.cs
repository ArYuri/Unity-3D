using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// ������Ϊ��
/// </summary>
public class AnimationAction
{
    private Animation ���˥�;
    /// <summary>
    /// ����������Ϊ��
    /// </summary>
    /// <param name="���˥�">�����ڵ���ģ���ϵĶ����������</param>
    public AnimationAction(Animation ���˥�)
    {
        this.���˥� = ���˥�;
    }
    /// <summary>
    /// ���Ŷ���
    /// </summary>
    public void Play(string animName)
    {
        ���˥�.CrossFade(animName);
    }
}
