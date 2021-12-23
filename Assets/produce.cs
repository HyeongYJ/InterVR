using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class produce : MonoBehaviour
{

    public GameObject pie1;
    public GameObject pie2;

    public GameObject eventP1;
    public GameObject eventP2;

    public GameObject pro1;
    public GameObject pro2;

    public GameObject eventP1_1;
    public GameObject eventP2_1;

    public static bool test1T = false;
    public static bool test2T = false;

    private bool retryYes = false;

    // Start is called before the first frame update
    void Start()
    {
        //pie1 = GameObject.FindGameObjectWithTag("1testPie");
        //pie2 = GameObject.FindGameObjectWithTag("2testPie");
    }

    // Update is called once per frame
    void Update()
    {

    }



 
    public void pie1T()
    {
        //pie = GameObject.FindGameObjectWithTag("1testPie");
        test1T = true;
    }
    public void pie2T()
    {
        //pie = GameObject.FindGameObjectWithTag("2testPie");
        test2T = true;
    }

    public void back()
    {
        test1T = false;
        test2T = false;
    }

    public void InstantCre()
    {

        if (retryYes)
        {
            OnDestroy();
        }
        if (test1T) {
            Instantiate(pie1, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(eventP1, new Vector3(0, 0, 0), Quaternion.identity);

            retryYes = true;
            
        }
        else if (test2T)
        {
            Instantiate(pie2, Vector3.zero, Quaternion.Euler(0, 0, 0));
            Instantiate(eventP2, new Vector3(0, 0, 0), Quaternion.identity);

            retryYes = true;
        }

    }

    public void InstantDes()
    {

        if (retryYes)
        {
            OnDestroy();
        }
        if (test1T)
        {
            Instantiate(pro1, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(eventP1_1, new Vector3(0, 0, 0), Quaternion.identity);

            retryYes = true;

        }
        else if (test2T)
        {
            Instantiate(pro2, Vector3.zero, Quaternion.Euler(0, 0, 0));
            Instantiate(eventP2_1, new Vector3(0, 0, 0), Quaternion.identity);

            retryYes = true;
        }

    }

    public void OnDestroy()
    {
        Destroy(GameObject.FindGameObjectWithTag("1test"));
        Destroy(GameObject.FindGameObjectWithTag("1testPie"));
        EventP.pass = 0;
    }

}
