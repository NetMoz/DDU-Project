using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationManager : MonoBehaviour {

    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

public void StartNotification (Dialogue dialogue)
    {
        Debug.Log("Starting conversation");
    }
}
