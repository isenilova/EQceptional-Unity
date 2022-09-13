using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text curScore;
    public Text sendMessage;

    public float disSpd = 0.1f;
    public float viewTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameController.playerparams.curBalance.ToString() == curScore.text)
            return;

        if (GameController.playerparams.curBalance > System.Int32.Parse(curScore.text)) {

            curScore.text = GameController.playerparams.curBalance.ToString();
            return;
        
        }

        curScore.text = (System.Int32.Parse(curScore.text)-1).ToString();

    }




    public void GetMyEQTokens() {


        GameController.ChangeScore();
        StartCoroutine(SendMessageView());
    
    }

    IEnumerator SendMessageView() {

        sendMessage.color = new Color(sendMessage.color.r, sendMessage.color.g, sendMessage.color.b, 1f);

        float k = viewTime;

        while (k > 0) {

            k -= Time.deltaTime;

            yield return null;
        
        }

        while (sendMessage.color.a >= 0.5f) {


            sendMessage.color = new Color(sendMessage.color.r, sendMessage.color.g, sendMessage.color.b, sendMessage.color.a -Time.deltaTime*disSpd);

        }


        sendMessage.color = new Color(sendMessage.color.r, sendMessage.color.g, sendMessage.color.b, 0f);

        yield return null;
    }
}
