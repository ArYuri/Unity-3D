using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// 敌人AI，
/// </summary>
public class EnemyAI : MonoBehaviour
{
    public enum State
    {
        Attak,
        PathFinding
    }
    private State currentState = State.PathFinding;
    private EnemyAnimation anim;
    private EnemyMotor motor;

    private void Start()
    {
        anim = GetComponent<EnemyAnimation>();
        motor = GetComponent<EnemyMotor>();
    }
    private void Update()
    {
        //判断
        switch (currentState)
        {
            case State.Attak:        
                //执行寻路,调用马达
                //如果结束寻路，修改状态为攻击
                break;
            case State.PathFinding:        
                //执行攻击，播放攻击动画
                break;
        }


    }
}
