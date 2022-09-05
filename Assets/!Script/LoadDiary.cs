using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDiary : MonoBehaviour
{

    public GameObject mypref;
    EmoItem emo;
    GameObject ob;

    public Sprite[] emoPic;

    // Start is called before the first frame update
    void Start()
    {
        LoadStory(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadStory() {

        //for (int i = 0; i < transform.childCount; i++) Destroy(transform.GetChild(i).gameObject);

        Debug.Log(GameController.playerparams.hist.Count);

        for (int i = 0; i < GameController.playerparams.hist.Count; i++)
        {
            emo = GameController.playerparams.hist[GameController.playerparams.hist.Count-1-i];

            ob = Instantiate(mypref, transform);

            ob.transform.GetChild(0).gameObject.GetComponent<Text>().text = emo.data;
            ob.transform.GetChild(1).gameObject.GetComponent<Text>().text = emo.emotion;
            ob.transform.GetChild(3).gameObject.GetComponent<Text>().text = emo.discription;

            //emo.DebugEmoItem();

            


            ob.transform.GetChild(2).gameObject.GetComponent<Image>().overrideSprite = emoPic[FindMax(emo)];


        }

        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(transform.GetComponent<RectTransform>().sizeDelta.x,
           transform.GetComponent<RectTransform>().sizeDelta.y + 350f * GameController.playerparams.hist.Count);
    }

    public void AddNew(EmoItem em) {

        emo = em;

        ob = Instantiate(mypref, transform);
        ob.transform.SetAsFirstSibling();

        ob.transform.GetChild(0).gameObject.GetComponent<Text>().text = emo.data;
        ob.transform.GetChild(1).gameObject.GetComponent<Text>().text = emo.emotion;
        ob.transform.GetChild(3).gameObject.GetComponent<Text>().text = emo.discription;

        transform.GetComponent<RectTransform>().sizeDelta = new Vector2(transform.GetComponent<RectTransform>().sizeDelta.x,
           transform.GetComponent<RectTransform>().sizeDelta.y + 250f);

        ob.transform.GetChild(2).gameObject.GetComponent<Image>().overrideSprite = emoPic[FindMax(emo)];

    }


    int FindMax(EmoItem emo) {

        int k = 0;
        float m = 0;

        for (int j = 0; j < 6; j++)
        {


            if (emo.type[j] > m)
            {

                m = emo.type[j];
                k = j;

                //Debug.Log("CHANGE" + k.ToString());

            }

        }


        return k;

    }

}
