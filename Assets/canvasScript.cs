using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasScript : MonoBehaviour
{
    [SerializeField] private GameObject MainUI = null;
    [SerializeField] private GameObject ChoseUI = null;
    [SerializeField] private GameObject PlayUI = null;
    [SerializeField] private GameObject SuccessUI = null;
    [SerializeField] private GameObject FailUI = null;

    // Start is called before the first frame update
    void Start()
    {
        MainUI = GameObject.Find("Main");
        ChoseUI = GameObject.Find("Chose");
        PlayUI = GameObject.Find("Play");
        SuccessUI = GameObject.Find("Success");
        FailUI = GameObject.Find("Fail");

        MainUI.SetActive(true);
        ChoseUI.SetActive(false);
        PlayUI.SetActive(false);
        SuccessUI.SetActive(false);
        FailUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (EventP.pass == 3)
        {
           
            PlayUI.SetActive(false);
            SuccessUI.SetActive(true); //¼Í°ø UI Ã¢ ¶ç¿ì±â
            this.gameObject.GetComponent<produce>().OnDestroy();
            
        }
    }

    public void Exit()    //°ÔÀÓ Á¾·á
    {
        Application.Quit();
    }


}
