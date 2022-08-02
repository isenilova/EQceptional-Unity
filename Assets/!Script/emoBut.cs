using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class emoBut : MonoBehaviour
{
    public EmoItem myemo;

    public GameObject targetEmotion;

    public bool custName = false;
    // Start is called before the first frame update
    void Start()
    {
        //transform.GetChild(0).gameObject.GetComponent<Text>().text = myemo.emotion;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyAdd() {

        //transform.GetChild(0).gameObject.GetComponent<Text>().text

       transform.parent.gameObject.GetComponent<AddNewEmo>().curemo = myemo;

        if (custName) transform.parent.gameObject.GetComponent<AddNewEmo>().curemo.emotion = "custom";
       transform.parent.gameObject.GetComponent<AddNewEmo>().AddNewItem();

        if (targetEmotion != null) {

            targetEmotion.GetComponent<AddNewEmo>().curemo = myemo;

            if (custName) targetEmotion.GetComponent<AddNewEmo>().curemo.emotion = "custom";

            targetEmotion.GetComponent<AddNewEmo>().AddNewItem();

            myemo.DebugEmoItem();
            targetEmotion.GetComponent<AddNewEmo>().curemo.DebugEmoItem();
        }




    }

    public IEnumerator ChangeNameAfter() {

        yield return new WaitForSeconds(0.2f);

        gameObject.GetComponent<emoBut>().myemo.emotion = transform.GetChild(0).gameObject.GetComponent<Text>().text;

        yield return null;
    }


}
