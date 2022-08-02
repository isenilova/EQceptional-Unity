using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalizeGraph : MonoBehaviour
{
    public GameObject myAlphaObj;

    public float[] sad = new float[4];
    public float[] fear = new float[4];
    public float[] joy = new float[4];
    public float[] anger = new float[4];
    public float[] disgust = new float[4];
    public float[] surprise = new float[4];

    int cnt;
    int num;


    public float[] total = new float[4];

    public GameObject sadPar;
    public GameObject fearPar;
    public GameObject joyPar;
    public GameObject angerPar;
    public GameObject disgustPar;
    public GameObject surprisePar;


    public GameObject myContent;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {

        myContent.GetComponent<RectTransform>().position = Vector3.zero;
        AnalizeGraf();
        
    }


    public void AnalizeGraf() {

        CalclResult();


        CalcPersents(sadPar, sad);
        CalcPersents(fearPar, fear);
        CalcPersents(joyPar, joy);
        CalcPersents(angerPar, anger);
        CalcPersents(disgustPar, disgust);
        CalcPersents(surprisePar, surprise);


        myAlphaObj.GetComponent<ChangeAlfa>().GoVis();
    }


    void CalcPersents(GameObject myPar, float[] myArr) {


        for (int i = 0; i < 4; i++) {


            total[i] = sad[i] + joy[i] + anger[i] + fear[i] + disgust[i]+ surprise[i];

            var a = myPar.transform.GetChild(i).gameObject.GetComponent<RectTransform>().anchorMax;

            if (total[i] != 0)
            {
                myPar.transform.GetChild(i).gameObject.GetComponent<RectTransform>().anchorMax = new Vector2(a.x, myArr[i] / total[i]);

                myPar.transform.GetChild(i).gameObject.GetComponent<RectTransform>().anchorMin = new Vector2(a.x, myArr[i] / total[i]);
            }
            else {

                myPar.transform.GetChild(i).gameObject.GetComponent<RectTransform>().anchorMax = new Vector2(a.x, 0f);

                myPar.transform.GetChild(i).gameObject.GetComponent<RectTransform>().anchorMin = new Vector2(a.x, 0f);



            }
            myPar.transform.GetChild(i).gameObject.GetComponent<RectTransform>().offsetMax = Vector2.zero;
            myPar.transform.GetChild(i).gameObject.GetComponent<RectTransform>().offsetMin = Vector2.zero;

            myPar.transform.GetChild(i).gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 50);
                                   


        }
                     


    }




    void CalclResult()
    {

        for (int i = 0; i < 4; i++)
        {
            sad[i] = 0;
            fear[i] = 0;
            joy[i] = 0;
            anger[i] = 0;
            disgust[i] = 0;
            surprise[i] = 0;
        }

        if (GameController.playerparams.hist.Count < 4)
        {

            num = GameController.playerparams.hist.Count;


        }
        else {

            num = 4;


        }

        cnt = GameController.playerparams.hist.Count / 4;


        Debug.Log("hist"+ GameController.playerparams.hist.Count + "num =" + num + " cnt ="+cnt);
        


        if (num == 4)
        {

            for (int j = 0; j < 3; j++)
            {
                Debug.Log("("+(cnt * j).ToString()+ ","+(cnt-1 + cnt * j).ToString()+")");

                for (int i = 0 + cnt * j; i < cnt-1 + cnt * j; i++)
                {

                    sad[j] += GameController.playerparams.hist[i].type[0];

                    fear[j] += GameController.playerparams.hist[i].type[1];

                    joy[j] += GameController.playerparams.hist[i].type[2];

                    anger[j] += GameController.playerparams.hist[i].type[3];

                    disgust[j] += GameController.playerparams.hist[i].type[4];

                   surprise[j] += GameController.playerparams.hist[i].type[5];


                }
            }

            Debug.Log("(" + (cnt * 3).ToString() + "," + (cnt * 4 -1+ (GameController.playerparams.hist.Count % 4)).ToString() + ")");

            for (int i = 3 * cnt; i < 4 * cnt - 1 + (GameController.playerparams.hist.Count % 4); i++)
            {


                sad[3] += GameController.playerparams.hist[i].type[0];

                fear[3] += GameController.playerparams.hist[i].type[1];

                joy[3] += GameController.playerparams.hist[i].type[2];

                anger[3] += GameController.playerparams.hist[i].type[3];

                disgust[3] += GameController.playerparams.hist[i].type[4];

                surprise[3] += GameController.playerparams.hist[i].type[5];




            }
        }

        else {

            for (int i = 0; i < num; i++) {

                sad[3-i] += GameController.playerparams.hist[num -1 -i].type[0];

                fear[3-i] += GameController.playerparams.hist[num-1-i].type[1];

                joy[3-i] += GameController.playerparams.hist[num-1-i].type[2];

                anger[3-i] += GameController.playerparams.hist[num-1-i].type[3];

                disgust[3 - i] += GameController.playerparams.hist[num - 1 - i].type[4];

                surprise[3 - i] += GameController.playerparams.hist[num - 1 - i].type[5];





            }




        }



    }

}
