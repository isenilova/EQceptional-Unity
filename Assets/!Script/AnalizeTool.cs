using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnalizeTool : MonoBehaviour
{
    public float sad = 15;
    public float fear = 20;
    public float joy = 25;
    public float anger = 10;
    public float disgust = 16;
    public float surprise = 10;

    public GameObject sadObj;
    public GameObject fearObj;
    public GameObject joyObj;
    public GameObject angerObj;
    public GameObject disgustObj;
    public GameObject surpriseObj;

    public GameObject sadtxt;
    public GameObject feartxt;
    public GameObject joytxt;
    public GameObject angertxt;
    public GameObject disgusttxt;
    public GameObject surprisetxt;

    public float spd = 1f;

    float total;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        EmoDiagr();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CalclResult() {

        sad = 0;
        fear = 0;
        joy = 0;
        anger = 0;
        disgust = 0;
        surprise = 0;

        for (int i = 0; i < GameController.playerparams.hist.Count; i++) {

            sad += GameController.playerparams.hist[i].type[0];

            fear += GameController.playerparams.hist[i].type[1];

            joy += GameController.playerparams.hist[i].type[2];

            anger += GameController.playerparams.hist[i].type[3];

           disgust += GameController.playerparams.hist[i].type[4];

            surprise += GameController.playerparams.hist[i].type[5];


        }





    }

    void TestHist()
    {

        for (int i = 0; i < GameController.playerparams.hist.Count; i++)
        {
            Debug.Log("(" + GameController.playerparams.hist[i].type[0] + "," + GameController.playerparams.hist[i].type[1] + "," + 
                GameController.playerparams.hist[i].type[2] +
                 GameController.playerparams.hist[i].type[3] + GameController.playerparams.hist[i].type[4] + GameController.playerparams.hist[i].type[5] + ")");


        }

    }

   public void EmoDiagr() {

        CalclResult();
        //TestHist();

        total = sad + fear + joy + anger+ disgust + surprise;

        // Debug.Log(total);
        if (total == 0) return;

        // fearObj.GetComponent<Image>().fillAmount = (float)(fear + joy + anger) / (float)total;
        //joyObj.GetComponent<Image>().fillAmount = (float)(joy + anger) / (float)total;
        //angerObj.GetComponent<Image>().fillAmount = (float)anger / (float)total;

        StartCoroutine(goFill(sadObj, 1f, 6));

        StartCoroutine(goFill(fearObj, (float)(fear + joy + anger + disgust + surprise) / (float)total, 5));

        StartCoroutine(goFill(joyObj, (float)(joy + anger + disgust + surprise) / (float)total, 4));

        StartCoroutine(goFill(angerObj, (float)(anger+disgust+surprise) / (float)total, 3));

        StartCoroutine(goFill(disgustObj, (float)(disgust+surprise) / (float)total, 2));

        StartCoroutine(goFill(surpriseObj, (float)(surprise) / (float)total, 1));

        sadtxt.GetComponent<Text>().text = "saddness " + ((int)((float)sad * 100 / (float)total)).ToString() + "%";
        feartxt.GetComponent<Text>().text = "fear " + ((int)((float)fear * 100 / (float)total)).ToString() + "%";
        joytxt.GetComponent<Text>().text = "joy " + ((int)((float)joy * 100 / (float)total)).ToString() + "%";
        angertxt.GetComponent<Text>().text = "anger " + ((int)((float)anger * 100 / (float)total)).ToString() + "%";
        disgusttxt.GetComponent<Text>().text = "disgust " + ((int)((float)disgust * 100 / (float)total)).ToString() + "%";
        surprisetxt.GetComponent<Text>().text = "surprise " + ((int)((float)surprise * 100 / (float)total)).ToString() + "%";


    }


    IEnumerator goFill(GameObject myobj, float tm, int kk = 1) {

        float qq = 0;
        myobj.GetComponent<Image>().fillAmount = qq;

        while (qq < tm) {

            qq += spd * Time.deltaTime*kk;

            myobj.GetComponent<Image>().fillAmount = qq;



            yield return null;
        }


        myobj.GetComponent<Image>().fillAmount = tm;

        yield return null;

    }

   
    }


