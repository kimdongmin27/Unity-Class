using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject origin;  // ���� ���� �Ǵ� ���� ������Ʈ
    public float speed = 1.0f;  // ȸ�� �ӵ�

    void Start()
    {
        
    }

    void Update()
    {
        // (ȸ���� �ϱ� ���� �������� �Ǵ� ���� ������Ʈ ����), (ȸ���� �� ����), (ȸ���ӵ�)
        transform.RotateAround(origin.transform.position,Vector3.down,speed * Time.deltaTime);
    }
}
