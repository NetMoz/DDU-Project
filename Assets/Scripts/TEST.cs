using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class TEST : MonoBehaviour {

    public Image Notification;
    public bool Cunt = true; 
    public List<int> newList = new List<int>();

    void Loop()
    {
        for (int i = 0; i <= newList.Count; i++)
        {
            Notification.transform.position = new Vector2(0, 0);
            Cunt = true;
        }
    }


    void Update()
    {
        if (Cunt == false)
        {
            Loop();
        }
    }

}
