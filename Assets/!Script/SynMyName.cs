using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynMyName : MonoBehaviour
{
    public GameObject myEmoName;
    public GameObject myNameOnTop;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mySyn(string s) {

       // myEmoName.GetComponent<AddNewEmo>().curemo.emotion = s;

        if (s != "") myNameOnTop.GetComponent<Text>().text = s + "?";
        else myNameOnTop.GetComponent<Text>().text = "Custom?";

    }


    public void RewriteToCustom() {


        myNameOnTop.GetComponent<Text>().text = "Custom?";

    }


    public void SynMyDesr(string a) {




    }
}
