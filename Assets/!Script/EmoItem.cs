using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class EmoItem : ICloneable
{
    public string emotion = "";

    public float[] type = new float[6];

    public string data = "";


    public string discription = "";

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public void DebugEmoItem() {

        Debug.Log("ITEM " + emotion + "(" + type[0].ToString() + ","+ type[1].ToString() + ","+ type[2].ToString() + ","+
            type[3].ToString() + ","+ type[4].ToString() + ","+ type[5].ToString() + ","+") " + data + " descr: " + discription);

    }

    
}
