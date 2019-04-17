using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTrigger : MonoBehaviour {

    public Dialogue dialogue;

    public void TriggerNotification()
    {
        FindObjectOfType<NotificationManager>().StartNotification(dialogue);
    }
}
