using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// player控制器
/// </summary>
public class DoRotation : MonoBehaviour
{
    public float rotateSpeed = 5f;
    
    public float moveSpeed = 1f;

    private float fastMoveSpeed;

    private float slowMoveSpeed;

    private Transform childTF;

    private Transform thisTF;

    private Vector3 R3;

    private bool Jumping = false;

    private float T0 = 0;

    public AnimationCurve curve;

    private float x = 0;

    private GameObject kidPlayer;

    private void Start()
    {
        childTF = GetComponentInChildren<Transform>();
        thisTF = GetComponent<Transform>();
        fastMoveSpeed = 1.75f * moveSpeed;
        slowMoveSpeed =  moveSpeed / 1.75f;
        kidPlayer = GameObject.FindGameObjectWithTag("Camera");

    }


    private void Update()
    {
        //水平视角转动
        float x1 = Input.GetAxis("Mouse X");
        //float y1 = Input.GetAxis("Mouse Y");

        x1=x1* Time.deltaTime * 120 * rotateSpeed;
        //y1=y1* Time.deltaTime * 120 * rotateSpeed;

        //垂直视角转动
        float y1 = Input.GetAxis("Mouse Y");
        y1 = y1 * Time.deltaTime * 120 * rotateSpeed;
        kidPlayer.transform.Rotate(-y1, 0, 0, Space.Self);

        //我快吐了，为什么子物体的局部坐标不变啊
        //childTF.localEulerAngles += new Vector3(-y1, 0, 0);
        //childTF.Rotate(-y1, 0, 0,Space.Self);
        thisTF.Rotate(0, x1, 0,Space.Self);

        //移动
        float x2 = Input.GetAxis("Horizontal");
        float z2 = Input.GetAxis("Vertical");

        x2 = x2 * Time.deltaTime * 12 * moveSpeed;
        z2 = z2 * Time.deltaTime * 12 * moveSpeed;

        thisTF.Translate(x2, 0, 0,Space.Self);
        thisTF.Translate(0, 0, z2,Space.Self);

        //跳跃
        bool isJump = Input.GetKeyDown("space");
        
        if (isJump==true&&Jumping==false)
        {
            x = 0;
            T0 = Time.time;
            Jumping = true;
            //this.transform.Translate(0, +1f, 0);
        }
        if(Jumping==true&&Time.time < T0 + 0.3f)
        {
            x += Time.deltaTime;
            kidPlayer.transform.localPosition = Vector3.Lerp(Vector3.zero,new Vector3(0,1,0),curve.Evaluate(x/0.3f));
        }
        if (Jumping==true && Time.time >= T0 + 0.3f)
        {
            x += Time.deltaTime;
            //this.transform.Translate(0, -1f, 0);
            kidPlayer.transform.localPosition = Vector3.Lerp(Vector3.zero,new Vector3(0,1,0),curve.Evaluate((0.6f-x)/0.3f));
        }
        if(Jumping == true && Time.time >= T0 + 0.6f)
        {
            Jumping = false;
        }

        //跑步功能
        bool isRun = Input.GetKey("left shift");

        if (isRun)
            moveSpeed = fastMoveSpeed;
        else
            moveSpeed = slowMoveSpeed;
    }
}
