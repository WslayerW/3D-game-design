using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{
    public GameObject ball;
    public float Power = 10;//这个代表发射时的速度
    public float Angle = 45;//发射的角度
    public float Gravity = -10;//这个代表重力加速度



    private Vector3 MoveSpeed;//初速度向量
    private Vector3 GritySpeed = Vector3.zero;//重力的速度向量，t时为0
    private Vector3 currentAngle;//每时每刻位移向量的角度

    void Start()
    {

        MoveSpeed = Quaternion.Euler(new Vector3(0, 0, Angle)) * Vector3.right * Power;//向量点积计算水平速度
        currentAngle = Vector3.zero;
    }

    void FixedUpdate()
    {
        GritySpeed.y += Gravity * Time.fixedDeltaTime;//竖直速度
        ball.transform.position += (MoveSpeed + GritySpeed) * Time.fixedDeltaTime;//位移向量
        currentAngle.z = Mathf.Atan((MoveSpeed.y + GritySpeed.y) / MoveSpeed.x) * Mathf.Rad2Deg;//更新位移角度
        ball.transform.eulerAngles = currentAngle;
    }
}
