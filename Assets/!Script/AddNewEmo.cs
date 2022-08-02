using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNewEmo : MonoBehaviour
{
    public EmoItem curemo;
    public GameObject mydairy;

    public GameObject myPopUp;

    public bool sameName = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AddNewItem() {


        //setdata

        curemo.data = System.DateTime.Now.ToString();


        myPopUp.GetComponent<ContentPageGo>().GoUp();

       // Debug.Log(sameName.ToString());

        if (!sameName) myPopUp.transform.GetChild(3).gameObject.GetComponent<Text>().text = curemo.emotion + "?";
        else myPopUp.transform.GetChild(3).gameObject.GetComponent<Text>().text = "custom?";




    }

    public void ButAddYes() {

        curemo.data = System.DateTime.Now.ToString();
        GameController.playerparams.hist.Add(curemo);

        if (GameController.playerparams.hist.Count > 100) GameController.playerparams.hist.RemoveAt(0);

        GameController.Save();

        curemo.DebugEmoItem();

        mydairy.GetComponent<LoadDiary>().AddNew(curemo);



    }

}
