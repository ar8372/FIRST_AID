using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    int ID;
    int ActiveStatus = 0;
    public GameObject CanvasOfpanels;
    GameObject[] PanelList = new GameObject[137];
    GameObject ExitButton;
    GameObject HomeButton;
    GameObject BackButton;

    // Start is called before the first frame update
  

    void Start()
    {
        ID = 0;
        ActiveStatus = 0;

        for(int j=0; j<137;j++)
        {
           PanelList[j] = CanvasOfpanels.transform.GetChild(j).gameObject;
            //PanelList[j].SetActive(true);
        }

        ExitButton = PanelList[0].transform.GetChild(5).gameObject;
        HomeButton = PanelList[0].transform.GetChild(7).gameObject;
        BackButton = PanelList[0].transform.GetChild(6).gameObject;

       
        
    }

    void IDPanel()
    {
        ActiveStatus = 0;
        
        
        //ID=1
        int i = ID;
        //i=1
        int[] b = new int[9];
        for(int k=0; k < 9; k++)
        {
            b[k] = (i * 10) + k + 1;
            // b[0]=11
            // b[1]=12
            // b[2]=13
            // b[3]=14
            // b[4]=15
            // b[5]=16
            // b[6]=17
            // b[7]=18
            // b[8]=19
        }

        for (int c = 1; c < 137; c++)
        {
            string Name = PanelList[c].name;
            int ChangedToInt = int.Parse(Name);

            if(ChangedToInt==b[0]||ChangedToInt==b[1] || ChangedToInt == b[2] || ChangedToInt == b[3] || ChangedToInt == b[4] || ChangedToInt == b[5] || ChangedToInt == b[6] || ChangedToInt == b[7] || ChangedToInt == b[8])
            {
                //then to set it active
                ActiveStatus = 1;
                PanelList[c].SetActive(true);
                
            }
            else
            {
                PanelList[c].SetActive(false);
                
            }
            
        }


        if (ActiveStatus == 0)
        {
            //it is the end
            ID = (ID * 10);
            
            for (int c = 1; c < 137; c++)
            {
                
                string Name = PanelList[c].name;
                int ChangedToInt = int.Parse(Name);

                if (ChangedToInt == ID)
                {
                    // end panel to display
                    PanelList[c].SetActive(true);
                    ActiveStatus = 1;
                    return;   ///prevents unnecessary repetition :)
                }
                
            }

        }

        
        
    }

    public void HomeExitButtonClicked()
    {
        if (ID == 0)
        {
            //this will work as exit buttons
            //Close the program

            Application.Quit();
        }
        else
        {
            // this will work as home button

            ActiveStatus = 0;  // since if at end screen it will become inactive 
            HomeButton.SetActive(false);
            ExitButton.SetActive(true);
            BackButton.SetActive(false);
            ID = 0;
            ///let's set all panel inactive
            for(int v=1; v < 137; v++)
            {
                PanelList[v].SetActive(false);
            }
            PanelList[1].SetActive(true);
            PanelList[20].SetActive(true);
            PanelList[28].SetActive(true);
            PanelList[37].SetActive(true);
            PanelList[61].SetActive(true);
            PanelList[65].SetActive(true);
            PanelList[68].SetActive(true);
            PanelList[78].SetActive(true);
            PanelList[85].SetActive(true);
        }
    }
    public void BackButtonClicked()
    {
        if (ID == 0)
        {
            //do nothing 
        }
        else if (ID%10 == 0)
        {
            //it is the end screen so first set it inactive
            for (int c = 1; c < 137; c++)
            {
                string Name = PanelList[c].name;
                int ChangedToInt = int.Parse(Name);

                if (ChangedToInt == ID)
                {
                    // end panel to displayed so set it inactive
                    PanelList[c].SetActive(false);
                    ActiveStatus = 0;
                    ID = ID / 100;
                    IDPanel();
                }

            }
        }
        else
        {
            /// ID=432
            ID = ID / 10;
            //ID=43

            ///Lets set active EXIT button and inactive HOME and BACK button if we reach first
            if (ID == 0)
            {
                // we reach first
                ExitButton.SetActive(true);
                HomeButton.SetActive(false);
                BackButton.SetActive(false);
            }
            IDPanel();
            
        }
    }

    

    public void Button1()
    {
        
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID%10 == 0&&ID!=0)
        {
            // we are at the end so do nothing

        }
        else
        {
            ID = (ID * 10) + 1;
            IDPanel();
            
        }
        
    }
    public void Button2()
    {
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID % 10 == 0 && ID != 0)
        {
            // we are at the end so do nothing

        }
        else
        {
            /// ID=43
            ID = (ID * 10) + 2;
            //ID=432
            IDPanel();
        }
    }
    public void Button3()
    {
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID % 10 == 0 && ID != 0)
        {
            // we are at the end so do nothing

        }
        else
        {
            ID = (ID * 10) + 3;
            IDPanel();
        }
    }
    public void Button4()
    {
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID % 10 == 0 && ID != 0)
        {
            // we are at the end so do nothing

        }
        else
        {
            ID = (ID * 10) + 4;
            IDPanel();
        }
    }
    public void Button5()
    {
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID % 10 == 0 && ID != 0)
        {
            // we are at the end so do nothing

        }
        else
        {
            ID = (ID * 10) + 5;
            IDPanel();
        }
    }
    public void Button6()
    {
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID % 10 == 0 && ID != 0)
        {
            // we are at the end so do nothing

        }
        else
        {
            ID = (ID * 10) + 6;
            IDPanel();
        }
    }
    public void Button7()
    {
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID % 10 == 0 && ID != 0)
        {
            // we are at the end so do nothing

        }
        else
        {
            ID = (ID * 10) + 7;
            IDPanel();
        }
    }
    public void Button8()
    {
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID % 10 == 0 && ID != 0)
        {
            // we are at the end so do nothing

        }
        else
        {
            ID = (ID * 10) + 8;
            IDPanel();
        }
    }
    public void Button9()
    {
        if (ID == 0)
        {
            // changes in ui is to be made
            // set EXIT inactive and HOME and BACK active
            ExitButton.SetActive(false);
            HomeButton.SetActive(true);
            BackButton.SetActive(true);
        }
        if (ID % 10 == 0 && ID != 0)
        {
            // we are at the end so do nothing

        }
        else
        {
            ID = (ID * 10) + 9;
            IDPanel();
        }
    }
}
