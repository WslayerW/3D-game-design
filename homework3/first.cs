using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{
    public GameObject ball;
    public float Power = 10;//���������ʱ���ٶ�
    public float Angle = 45;//����ĽǶ�
    public float Gravity = -10;//��������������ٶ�



    private Vector3 MoveSpeed;//���ٶ�����
    private Vector3 GritySpeed = Vector3.zero;//�������ٶ�������tʱΪ0
    private Vector3 currentAngle;//ÿʱÿ��λ�������ĽǶ�

    void Start()
    {

        MoveSpeed = Quaternion.Euler(new Vector3(0, 0, Angle)) * Vector3.right * Power;//�����������ˮƽ�ٶ�
        currentAngle = Vector3.zero;
    }

    void FixedUpdate()
    {
        GritySpeed.y += Gravity * Time.fixedDeltaTime;//��ֱ�ٶ�
        ball.transform.position += (MoveSpeed + GritySpeed) * Time.fixedDeltaTime;//λ������
        currentAngle.z = Mathf.Atan((MoveSpeed.y + GritySpeed.y) / MoveSpeed.x) * Mathf.Rad2Deg;//����λ�ƽǶ�
        ball.transform.eulerAngles = currentAngle;
    }
}
