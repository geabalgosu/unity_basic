using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Talk());
    }
    
    
    
    //IEnumerator�� �ƴ� IEnumerable�� ����
    //coroutine�� string���� �ٲ� �� ���ٰ� �ϸ� ����
    //�򰥸��� �ʰ� ����
    private IEnumerator Talk()           
    {
        yield return null;
    }
}
