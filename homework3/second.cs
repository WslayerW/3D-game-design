using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class second : MonoBehaviour
{

    public const float g = 9.8f;
    public Transform start; 
    public Transform target;
    public float speed = 10;
    private float verticalSpeed;
    void Start()
    {
        float tmpDistance = Vector3.Distance(start.position, target.position);
        float tmpTime = tmpDistance / speed;
        float riseTime = tmpTime / 2;
        verticalSpeed = g * riseTime;
        // 设置初始旋转朝向目标,这样就不会因为初始旋转方向不同导致Translate运动方向不同
        transform.LookAt(target.position);
        StartCoroutine(move());
    }
    private float time;
    IEnumerator move()
    {
        while (true)
        {
            time += Time.deltaTime;
            float test = verticalSpeed - g * time;
            start.Translate(transform.forward * speed * Time.deltaTime, Space.World);
            start.Translate(transform.up * test * Time.deltaTime, Space.World);
            if (start.position.y < target.position.y)
            {
                break;
            }
            yield return null;
        }
    }
}

