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
        pie = GameObject.FindGameObjectWithTag(p);  //퍼즐 맞추기
    }

    // Update is called once per frame
    void Update()
    {
        if (ok) //이동 시작
        {
            transform.position = Vector3.MoveTowards(transform.position, target, 2f);   //해당 위치로 이동
            if (target == transform.position)   //이동 위치 도달
            {
                pass++;
                ok = false; //이동 종료
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag(p))
        {
            target = other.transform.position;  //해당 오브젝트 위치
            Destroy(this.GetComponent<DragScript>());   //커서 이동 ㄴㄴ
            ok = true;  //이동 시작
            Destroy(other.gameObject);  //위치 오브젝트 삭제
        }
    }



}
