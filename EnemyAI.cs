using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
*/
/// <summary>
/// ����AI��
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
        //�ж�
        switch (currentState)
        {
            case State.Attak:        
                //ִ��Ѱ·,�������
                //�������Ѱ·���޸�״̬Ϊ����
                break;
            case State.PathFinding:        
                //ִ�й��������Ź�������
                break;
        }


    }
}
