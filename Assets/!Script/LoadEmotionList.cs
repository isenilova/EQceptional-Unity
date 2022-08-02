using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadEmotionList : MonoBehaviour
{
    public static EmoList allEmotions= new EmoList();
    public static bool ready = false;

    public TextAsset myEmoBase;

    // Start is called before the first frame update
    void Start()
    {

       /*

        var a = new EmoItem();

        a.data = "11.11";
        a.emotion = "GLUPODAUN";
        a.type = new float[4];
        for (int i = 0; i < 4; i++) a.type[i] = 0.25f;

        var b = a;

        var c = new EmoList();
        c.emotions.Add(a);
        c.emotions.Add(b);

        var d = JsonUtility.ToJson(c);
        Debug.Log(d);

          
        allEmotions = JsonUtility.FromJson<EmoList>(d);

    */

    }

    private void Awake()
    {
        LoadEmo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadEmo() {


        var s = myEmoBase.text;
       

        allEmotions = JsonUtility.FromJson<EmoList>(s);


        //Debug.Log(allEmotions.emotions.FindLast(x => true).emotion);
        
    }

   


}
