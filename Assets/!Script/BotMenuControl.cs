using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMenuControl : MonoBehaviour
{
   // public string status = "home";
    public int myCurNum = 4;

    public GameObject[] myButts;
    public GameObject[] myPages;

    public GameObject startobj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void myMenuClick(int nm) {

        if (myCurNum == nm) return;


        myPages[myCurNum].transform.position = startobj.transform.position;

        myPages[nm].GetComponent<PagesMenuGo>().GoLeft();

        myButts[myCurNum].transform.GetChild(1).gameObject.SetActive(false);
        myButts[nm].transform.GetChild(1).gameObject.SetActive(true);

        myCurNum = nm;


    }

}
