using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiManager : MonoBehaviour
{
    public GameObject chemicalfirstAid;
    public GameObject BackTab;
    public GameObject ExitTab;
    public GameObject HomeTab;

    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;
    public GameObject A7;
    public GameObject A8;
    public GameObject A9;
    GameObject[] A;


    public GameObject B1;
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;
    public GameObject B6;
    public GameObject B7;
    public GameObject B8;
    public GameObject B9;
    GameObject[] B;

    // Start is called before the first frame update
    void Start()
    {
        A = new GameObject[9] { A1, A2, A3, A4, A5, A6, A7, A8, A9 };
        B = new GameObject[9] { B1, B2, B3, B4, B5, B6, B7, B8, B9 };
    }

    // Update is called once per frame
    void Update()
    {
        //if (appManager.instance.TabNO !=1)
        //{
        //    BackTab.SetActive(true);
        //    ExitTab.SetActive(false);
        //    HomeTab.SetActive(true);
        //}
        //else
        //{
        //    BackTab.SetActive(false);
        //    ExitTab.SetActive(true);
        //    HomeTab.SetActive(false);
        //}

    }

    public void EXITbuttonClicked()
    {
        if (appManager.instance.layerNO1 == 1)
        {
            Application.Quit();
        }
        else if(appManager.instance.layerNO1==2)
        {
            appManager.instance.layerNO1 = 1;
            BackTab.SetActive(false);
            ExitTab.SetActive(true);
            HomeTab.SetActive(false);
            foreach (GameObject i in A)
            {
                i.SetActive(true);
            }
            foreach (GameObject j in B)
            {
                j.SetActive(false);
            }
        }
        else if (appManager.instance.layerNO1 == 3)
        {
            appManager.instance.layerNO1 = 1;
            BackTab.SetActive(false);
            ExitTab.SetActive(true);
            HomeTab.SetActive(false);
            chemicalfirstAid.SetActive(false);
            foreach (GameObject i in A)
            {
                i.SetActive(true);
            }
        }
        
    }

    public void BACKbuttonClicked()
    {
        if (appManager.instance.layerNO1 == 2)
        {
            HomeTab.gameObject.SetActive(false);
            ExitTab.gameObject.SetActive(true);
            BackTab.gameObject.SetActive(false);
            foreach (GameObject j in B)
            {
                j.SetActive(false);
            }
            foreach (GameObject i in A)
            {
                i.SetActive(true);
            }
            appManager.instance.layerNO1 = 1;
        }
        if (appManager.instance.layerNO1 == 3)
        {
            appManager.instance.layerNO1 = 2;
            foreach (GameObject j in B)
            {
                j.SetActive(true);
            }
            if (appManager.instance.TabNO == 20)
            {
                chemicalfirstAid.SetActive(false);

            }
        }
        

    }

    public void Button1Clicked()
    {
        if (appManager.instance.layerNO1 == 1)
        {
            Debug.Log("hello");
            BackTab.SetActive(true);
            ExitTab.SetActive(false);
            HomeTab.SetActive(true);
            appManager.instance.TabNO = 11;
            appManager.instance.layerNO1 = 2;
            foreach (GameObject i in A)
            {
                i.SetActive(false);
            }
            foreach (GameObject j in B)
            {
                j.SetActive(true);
            }
        }
        

    }
    public void Button4Clicked()
    {
        if (appManager.instance.layerNO1 == 2)
        {
            appManager.instance.layerNO1 = 3;
            chemicalfirstAid.SetActive(true);
            appManager.instance.TabNO = 20;
            foreach (GameObject j in B)
            {
                j.SetActive(false);
            }
        }
    }
}
