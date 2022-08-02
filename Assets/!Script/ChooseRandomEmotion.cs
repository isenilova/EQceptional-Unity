using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseRandomEmotion : MonoBehaviour
{
    //public List<string> choosen = new List<string>();

    public GameObject[] emoObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoChoose() {

        for (int i = 0; i < emoObj.Length; i++) {

            var k = Random.Range(0, LoadEmotionList.allEmotions.emotions.Count);

            emoObj[i].GetComponent<Text>().text = LoadEmotionList.allEmotions.emotions[k].emotion;



        }



    }

}
