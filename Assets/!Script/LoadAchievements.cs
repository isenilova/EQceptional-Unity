using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAchievements : MonoBehaviour
{
    public GameObject[] myAch;

    public string myFunc = "";

    // Start is called before the first frame update
    void Start()
    {
        AllLoad();
        TestMonth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AllLoad() {

        for (int i = 0; i < myAch.Length; i++) {

            if (GameController.playerparams.ach[i]) {

                myAch[i].transform.GetChild(1).gameObject.SetActive(false);

                myAch[i].transform.GetChild(2).gameObject.SetActive(false);


            }
        }

    }

    void ActAch(int nm) {

        myAch[nm].transform.GetChild(1).gameObject.SetActive(false);

        myAch[nm].transform.GetChild(2).gameObject.SetActive(false);

        GameController.Save();


        StartCoroutine(GetNFT(nm));
        //StartCoroutine(GetNFT(3));

        //here will be function
    }

    IEnumerator GetNFT(int k) {



        var www = new WWW(myFunc+"?nearid='"+GameController.playerparams.nearlogin+"'&tokentype="+k.ToString());

        Debug.Log("INCOME: "+ myFunc + "?nearid='" + GameController.playerparams.nearlogin + "'&tokentype=" + k.ToString());



        yield return www;

        Debug.Log("TANIA!!! "+www.text);
    }


    public void TestEch(int i) {


        if (GameController.playerparams.ach[i]) return;

        GameController.playerparams.ach[i] = true;
        GameController.Save();

        ActAch(i);



    }

    public void TestMonth() {


        if (GameController.playerparams.firstDayCheckIn == "") return;

        Debug.Log(GameController.playerparams.firstDayCheckIn);

       // var p = System.DateTime.Now.Date.ToString();

        

       // System.DateTime.Parse(p);
        var s = (System.DateTime.Now.Date  - System.DateTime.Parse(GameController.playerparams.firstDayCheckIn)).TotalDays;

        // Debug.Log(s);

        if (s >= 30) ActAch(3);

    }

}
