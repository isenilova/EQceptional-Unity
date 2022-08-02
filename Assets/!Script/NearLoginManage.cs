using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NearLoginManage : MonoBehaviour
{
    public GameObject myButEdit;
    public GameObject myImg;

    // Start is called before the first frame update
    void Start()
    {
        if (GameController.playerparams.nearlogin != "") gameObject.GetComponent<InputField>().text = GameController.playerparams.nearlogin;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void EditBut() {

        gameObject.GetComponent<InputField>().interactable = true;
        myButEdit.SetActive(false);
        myImg.SetActive(true);

    }


    public void myLoginEndEdit(string a) {

        myButEdit.SetActive(true);
        myImg.SetActive(false);

        if (a != "") {

            GameController.playerparams.nearlogin = a;
            GameController.Save();

        }

        gameObject.GetComponent<InputField>().interactable = false;

    }
}
