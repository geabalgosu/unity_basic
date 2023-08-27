using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    int Speed = 6;
    Vector3 vec = Vector3.zero;

    Rigidbody2D rigid;
    void Update()
    {
        //transform���� �������� ��� �浹�Ѵٸ� ���������� �߻��Ѵ�
        transform.position += Speed * vec * Time.deltaTime;

        //�̶� rigidbody�� �̿��� �����̸� �ذ�ȴ�
        rigid.velocity = vec * Speed;
    }
}
