using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddEmoVal : MonoBehaviour
{

    public GameObject[] myValues;

    public GameObject[] mySectors;

    public GameObject[] myTextPersentage;

    public float total=0;

    float[] myvals = new float[6];

    public GameObject myEmoBut;

    public GameObject myNameCh;

    public float maxValue = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalcCustomEmo() {

        total = 0;

      

        for (int i = 0; i < myValues.Length; i++)

            total += myValues[i].GetComponent<Scrollbar>().value;

        if (total <= 0.01f) return; 

       mySectors[1].GetComponent<Image>().fillAmount = (float)(myValues[1].GetComponent<Scrollbar>().value
            + myValues[2].GetComponent<Scrollbar>().value+ myValues[3].GetComponent<Scrollbar>().value +
            myValues[4].GetComponent<Scrollbar>().value + myValues[5].GetComponent<Scrollbar>().value) / (float)total;


        mySectors[2].GetComponent<Image>().fillAmount = (float)(myValues[2].GetComponent<Scrollbar>().value+
            myValues[3].GetComponent<Scrollbar>().value + myValues[4].GetComponent<Scrollbar>().value + 
            myValues[5].GetComponent<Scrollbar>().value) / (float)total;

        mySectors[3].GetComponent<Image>().fillAmount = (myValues[3].GetComponent<Scrollbar>().value +
            myValues[4].GetComponent<Scrollbar>().value + myValues[5].GetComponent<Scrollbar>().value) / (float)total;

        mySectors[4].GetComponent<Image>().fillAmount = (myValues[4].GetComponent<Scrollbar>().value + myValues[5].GetComponent<Scrollbar>().value) / (float)total;

        mySectors[5].GetComponent<Image>().fillAmount = myValues[5].GetComponent<Scrollbar>().value / (float)total;


        for (int i = 0; i < 6; i++) myvals[i] = (myValues[i].GetComponent<Scrollbar>().value  *maxValue);



        myTextPersentage[0].GetComponent<Text>().text = "sadness " + ((int)(myValues[0].GetComponent<Scrollbar>().value *100/ total)).ToString() + "%";
        myTextPersentage[1].GetComponent<Text>().text = "fear " + ((int)(myValues[1].GetComponent<Scrollbar>().value *100/ total)).ToString() + "%";
        myTextPersentage[2].GetComponent<Text>().text = "joy " + ((int)(myValues[2].GetComponent<Scrollbar>().value *100/ total)).ToString() + "%";
        myTextPersentage[3].GetComponent<Text>().text = "anger " + ((int)(myValues[3].GetComponent<Scrollbar>().value *100/ total)).ToString() + "%";
        myTextPersentage[4].GetComponent<Text>().text = "disgust " + ((int)(myValues[4].GetComponent<Scrollbar>().value * 100 / total)).ToString() + "%";
        myTextPersentage[5].GetComponent<Text>().text = "surprise " + ((int)(myValues[5].GetComponent<Scrollbar>().value * 100 / total)).ToString() + "%";


        for (int i = 0; i < 6; i++)
            myEmoBut.GetComponent<emoBut>().myemo.type[i] = myvals[i];


    }
}
