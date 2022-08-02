using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddEmotionPg : MonoBehaviour
{
    public GameObject emoBut;

    public GameObject emoButParrent;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < emoButParrent.transform.childCount; i++) Destroy(emoButParrent.transform.GetChild(i).gameObject);

       LoadEmotionList.allEmotions.emotions.AddRange(GameController.playerparams.customlist);

        LoadEmotionList.allEmotions.emotions.Sort((x, y) => x.emotion.CompareTo(y.emotion));

        for (int i = 0; i < LoadEmotionList.allEmotions.emotions.Count; i++) {

            var a = Instantiate(emoBut, emoButParrent.transform);

            a.transform.SetAsLastSibling();

            a.GetComponent<emoBut>().myemo = LoadEmotionList.allEmotions.emotions[i];

            a.GetComponent<emoBut>().transform.GetChild(0).gameObject.GetComponent<Text>().text = LoadEmotionList.allEmotions.emotions[i].emotion;

        }

        int k = LoadEmotionList.allEmotions.emotions.Count / 4;

        if ((LoadEmotionList.allEmotions.emotions.Count % 4) != 0) k++;

        //Debug.Log("MY NUM" + k.ToString());
        //Debug.Log("MY NUM" + k.ToString() + "   " + (transform.GetComponent<RectTransform>().sizeDelta.y).ToString() + "    " + (130f * k).ToString());

        emoButParrent.GetComponent<RectTransform>().sizeDelta = new Vector2(transform.GetComponent<RectTransform>().sizeDelta.x,
          200f + 130f * k);

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AddNewCustomEmotionToList(string nm = "") {


        var s = Instantiate(emoBut, emoButParrent.transform);

        s.transform.SetAsLastSibling();

        s.GetComponent<emoBut>().myemo = emoButParrent.GetComponent<AddNewEmo>().curemo;

        s.GetComponent<emoBut>().transform.GetChild(0).gameObject.GetComponent<Text>().text = emoButParrent.GetComponent<AddNewEmo>().curemo.emotion;

        if (nm != "") s.GetComponent<emoBut>().myemo.emotion = nm;

        //s.GetComponent<emoBut>().myemo.emotion = emoButParrent.GetComponent<AddNewEmo>().curemo.emotion;

            //StartCoroutine(s.GetComponent<emoBut>().ChangeNameAfter());

        if((emoButParrent.transform.childCount % 4) == 1) emoButParrent.GetComponent<RectTransform>().sizeDelta = new Vector2(transform.GetComponent<RectTransform>().sizeDelta.x,
          transform.GetComponent<RectTransform>().sizeDelta.y + 130f);

    }
}
