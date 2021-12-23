using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    Text timeText;
    private float playTime = 30;    //���� �ð�
    private float successTiem = 0;  //���� �ð�
    //���� ���� Bolol

    private bool creat = false;     //����� ����
    private bool destroy = false;       //���� ����

    [SerializeField] private GameObject PlayUI = null;
    [SerializeField] private GameObject SuccessUI = null;
    [SerializeField] private GameObject FailUI = null;



    // Start is called before the first frame update
    void Start()
    {
        PlayUI = GameObject.Find("Play");
        SuccessUI = GameObject.Find("Success");
        FailUI = GameObject.Find("Fail");

        timeText = GameObject.Find("Play").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Ing();
    }

    void CreatT()   //����� ���� ��ư ����
    {
        creat = true;
    }
    void DestroyT()     //�����ϱ� ���� ��ư ����
    {
        destroy = true;
    }

    void Ing()
    {
        if(creat == true)
        {
            //if(�ϼ�����Bool�� == false)
            playTime -= Time.deltaTime;
            timeText.text = "���� �ð� : " + Mathf.Round(playTime);

            //�ϼ��� ���� â ����
            //
            //successTiem = 30.0 - playTime;        //�����ð� ���ϱ�
            //Play.SetActive(false);    //�÷��� â ����
            //SuccessUI.SetActive(true);    //���� UI
            //playTime = 30;  //�� �ʱ�ȭ
            //creat = false;    //�� ������

            if (playTime <= 0)   //���� ���� �� �ʱ�ȭ
            {
                playTime = 30;
                creat = false;
                FailUI.SetActive(true);
            }
        }
        else if(destroy == true)
        {

        }
    }

}
