using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Player player01;
    private Player player02;

    private void Awake()
    {
        player01 = new Player("��ڻ�",1000);          //���� ���� 
        player02 = player01;                           //player01�� ����Ű�� ���� player02�� ����Ű�Ե�
        player02.ID = "����Ƽ";                        //�ᱹ player02�� ����Ű�°��� ID�� �ٲ� player01�� ID�� �ٲ��ó����


        player01 = new Player("��ڻ�", 1000);          //���� ����
        player02 = player01.DeepCopy();                 //�ᱹ ���� ���� ���� ����Ŵ
        player02.ID = "����Ƽ";                         //���θ������ ID�� �޶���
    }
}
