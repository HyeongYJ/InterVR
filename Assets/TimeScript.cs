using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    Text timeText;
    private float playTime = 30;    //제한 시간
    private float successTiem = 0;  //성공 시간
    //성공 여부 Bolol

    private bool creat = false;     //만들기 상태
    private bool destroy = false;       //분해 상태

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

    void CreatT()   //만들기 시작 버튼 누름
    {
        creat = true;
    }
    void DestroyT()     //분해하기 시작 버튼 누름
    {
        destroy = true;
    }

    void Ing()
    {
        if(creat == true)
        {
            //if(완성여부Bool값 == false)
            playTime -= Time.deltaTime;
            timeText.text = "남은 시간 : " + Mathf.Round(playTime);

            //완성시 성공 창 띄우기
            //
            //successTiem = 30.0 - playTime;        //성공시간 구하기
            //Play.SetActive(false);    //플레이 창 끄기
            //SuccessUI.SetActive(true);    //성공 UI
            //playTime = 30;  //로 초기화
            //creat = false;    //로 무상태

            if (playTime <= 0)   //게임 오퍼 시 초기화
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
