using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player
{
    public string ID;
    private int currentHP;
    public Player DeepCopy()
    {
        Player clone = new Player();        //Player�� clone�� ������
        clone.ID = ID;                      //ID�� currentHP�� �ٲ�
        clone.currentHP = currentHP;

        return clone;                       //�ٷ� return
    }
}
