using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabsOnePage : MonoBehaviour
{
    public Color actcolor;
    public Color discolor;


    public GameObject myButCalc;
    public GameObject myResults;

    public int curTab = -1;

    public GameObject[] myTabs;

    public GameObject[] myPages;

    public bool dops = true;

    public GameObject[] myDopObj;

    // Start is called before the first frame update
    void Start()
    {
        changeTab(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void changeTab(int nm) {

      //  Debug.Log("change"+nm);

        if (nm == curTab) return;


       curTab= nm;

        for (int i = 0; i < myPages.Length; i++) {

            if (i == nm)
            {
                myPages[i].SetActive(true);

                if (dops)
                {


                    //myPages[i].transform.GetChild(0).gameObject.SetActive(true);
                    //myPages[i].transform.GetChild(1).gameObject.SetActive(false);
                    //myPages[i].transform.GetChild(0).GetChild(0).gameObject.GetComponent<GoBigSmall>().myScale();
                }

            }
            else {

                myPages[i].SetActive(false);

            }


        }



        //myButCalc.SetActive(true);
        //myButCalc.transform.GetChild(0).gameObject.GetComponent<GoBigSmall>().myScale();
        //myResults.SetActive(false);

        for (int i = 0; i < myTabs.Length; i++) {

            if (i == curTab)
            {

                myTabs[i].transform.GetChild(0).gameObject.SetActive(true);
                myTabs[i].transform.GetChild(1).gameObject.GetComponent<Text>().color = actcolor;

            }

            else {

                myTabs[i].transform.GetChild(0).gameObject.SetActive(false);
                myTabs[i].transform.GetChild(1).gameObject.GetComponent<Text>().color = discolor;



            }



        }



    }

}
