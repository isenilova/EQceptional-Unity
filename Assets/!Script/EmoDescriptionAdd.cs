using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmoDescriptionAdd : MonoBehaviour
{
    public GameObject myDescrEmo;
    public GameObject myEmoToWrite;


    public GameObject customToggle;
    public GameObject customField;

    public GameObject addButNewEmo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnYes() {

        myEmoToWrite.GetComponent<AddNewEmo>().curemo.discription = myDescrEmo.GetComponent<Text>().text;

        Debug.Log("add descr");

        myEmoToWrite.GetComponent<AddNewEmo>().curemo.DebugEmoItem();
        Debug.Log(myDescrEmo.GetComponent<Text>().text);

        if (customToggle.GetComponent<Toggle>().isOn && (customField.GetComponent<Text>().text != ""))
        {

           // Debug.Log("IF CHANGE "+myEmoToWrite.GetComponent<AddNewEmo>().curemo.discription);
            myEmoToWrite.GetComponent<AddNewEmo>().curemo.emotion = customField.GetComponent<Text>().text;




            addButNewEmo.GetComponent<AddEmotionPg>().AddNewCustomEmotionToList();

            Debug.Log("IF CHANGE " + myEmoToWrite.GetComponent<AddNewEmo>().curemo.discription);

            var a = (EmoItem)myEmoToWrite.GetComponent<AddNewEmo>().curemo.Clone();
              
            a.data = "";
            a.discription = "";

            Debug.Log("IF CHANGE " + myEmoToWrite.GetComponent<AddNewEmo>().curemo.discription);

            GameController.playerparams.customlist.Add(a);
            GameController.Save();

            //Debug.Log("IF CHANGE " + myEmoToWrite.GetComponent<AddNewEmo>().curemo.discription);

        }

       

        OnNo();



       // StartCoroutine(ClearEmoName());
    }


    public void OnNo() {

        myDescrEmo.transform.parent.GetComponent<InputField>().text = "";

        

    }

    IEnumerator ClearEmoName() {


        yield return new WaitForSeconds(1f);
        customField.GetComponent<Text>().text = "Custom";

        myEmoToWrite.GetComponent<AddNewEmo>().curemo.emotion = "Custom";

        yield return null;

    }
}
