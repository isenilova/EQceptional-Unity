using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CalculateCustom : MonoBehaviour
{
    public int takeNum = 0;
    public bool takeAll = true;

    public GameObject[] myFields;

    string cur ="+++";
    int nm =0;

    class sorted {

        public int num;
        public string lable;

        public sorted(string s = "", int i = 1) {

            lable = s;
            num = i;

        }

        
    }

    List<sorted> mm = new List<sorted>();

    List<string> emoName = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void myDebug() {

        for (int i = 0; i < mm.Count; i++)

            Debug.Log("(" + mm[i].lable + " " + mm[i].num + ")");


        Debug.Log("%");

    }



    public void CalcCommon() {


        emoName.Clear();

        mm.Clear();

        if (takeAll) takeNum = GameController.playerparams.hist.Count;

        for (int i = 0; i < takeNum; i++)
            emoName.Add(GameController.playerparams.hist[GameController.playerparams.hist.Count - 1 - i].emotion);


        // emoName.Sort();

       // Debug.Log("First"+emoName[0]);


        emoName.Sort();

        

        for (int i = 0; i < emoName.Count; i++) {

            if (emoName[i] != cur)
            {

                cur = emoName[i];

                mm.Add(new sorted(cur));


            }

            else {

                mm.FindLast(x => true).num ++;



            }



        }

        //myDebug();


        mm.Sort((x, y) => y.num.CompareTo(x.num));


        //myDebug();

        for (int i = 0; i < myFields.Length; i++) {


            if (i < mm.Count)
                myFields[i].GetComponent<Text>().text = mm[i].lable + " " + mm[i].num.ToString();

            else myFields[i].GetComponent<Text>().text = "no emotion";

        }
        

    }

}
