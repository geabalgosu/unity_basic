using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollider : MonoBehaviour
{
    

    
    void Start()
    {
        
    }

    
    void Update()
    {

        //Debug.Log(Input.mousePosition);  //���콺�� ��ǥ(2d)�� ��ũ���� ��ġ���� �ٸ��� ��ǥ�� ���
        
        //Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition));  //��ũ���� �ִ� ���콺�� ��ġ�� ���� ������ ���

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);  //�Ʒ��� �ּ����� ���� �̰ɷ� ��ü����
            /*
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            Vector3 dir = mousePos - transform.position;  //����
            dir = dir.normalized; //������ 1.0f�θ�
            */


            Debug.DrawRay(Camera.main.transform.position, dir,Color.red,1.0f);
            
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit,100.0f))
            {
                Debug.Log($"{hit.collider.gameObject.name}");
            }
            
                                        //������                ,����,hit    ,���� 
                if(Physics.Raycast(Camera.main.transform.position,dir,out hit,100.0f))
                {
                    Debug.Log($"{hit.collider.gameObject.name}");
                }
        }
    }
}
