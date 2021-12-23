using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventP : MonoBehaviour
{

    public bool ok = false;
    Vector3 target = new Vector3(0, 0, 0);
    private GameObject pie;
    public string p;
    public static int pass = 0;

    // Start is called before the first frame update
    void Start()
    {
        pie = GameObject.FindGameObjectWithTag(p);  //���� ���߱�
    }

    // Update is called once per frame
    void Update()
    {
        if (ok) //�̵� ����
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 2f);   //�ش� ��ġ�� �̵�
            if (target == transform.position)   //�̵� ��ġ ����
            {
                pass++;
                ok = false; //�̵� ����
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag(p))
        {
            target = other.transform.position;  //�ش� ������Ʈ ��ġ
            Destroy(this.GetComponent<DragScript>());   //Ŀ�� �̵� ����
            ok = true;  //�̵� ����
            Destroy(other.gameObject);  //��ġ ������Ʈ ����
        }
    }



}
