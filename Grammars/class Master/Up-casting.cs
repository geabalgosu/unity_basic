using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster
{
   public void Attack()
    {
        Debug.Log("���� �����Ѵ�");
    }
    public void Heal()
    {
        Debug.Log("ü���� ȸ���Ѵ�");
    }
}
public class Slime : Monster
{

    private Monster monster = new Monster();        //Monster�� Attack,Heal�� �����ִ�
    private Slime slime = new Slime();              //Slime�� Monster���� ����� �޾Ƽ� Monster�� Attack�� �����ִ�
    private Monster monster2= new Slime();          //Monster�� Attack,Heal�� �����ִ�

   

    public void Avoid()
    {
        Debug.Log("������!!");
    }
    public void Heal()                              //Slime�� Monster�� Heal�� ��ӹ޾Ƶ� slime�����ڴ� slime�� Heal�� ����
    {
        Debug.Log("��� ü�� ȸ��");
    }
}
