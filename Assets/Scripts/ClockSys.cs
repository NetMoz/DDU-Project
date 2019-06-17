using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;



public class ClockSys : MonoBehaviour {
    DateTime TimeDisplay;
    public Text HoursUI, MinutesUI, DayUI,DayofWeekUI,MonthUI,YearUI;
    public Button CloseNote;
    public GameObject NoteBox;
    public InputField InputHour;
    public InputField InputMinute;
    bool noton = false;
    




    void Update()
    {
        TimeDisplay = DateTime.Now;
        HoursUI.text = TimeDisplay.Hour.ToString();
        MinutesUI.text = TimeDisplay.Minute.ToString();
        DayUI.text = TimeDisplay.Day.ToString();
        DayofWeekUI.text = TimeDisplay.DayOfWeek.ToString();
        MonthUI.text = TimeDisplay.Month.ToString();
        YearUI.text = TimeDisplay.Year.ToString();

        //SecondsUI.text = TimeDisplay.Second.ToString();

        if (HoursUI.text == InputHour.text && MinutesUI.text == InputMinute.text && noton == false)
        {
            NoteBox.SetActive(true);
        }

        if (HoursUI.text != InputHour.text && MinutesUI.text != InputMinute.text)
        {
            NoteBox.transform.position = new Vector2(0, 0);
        }

        Debug.Log(NoteBox.transform.position);
    }

    void Start()
    {
        NoteBox.SetActive(false);
        CloseNote.onClick.AddListener(Deact);
    }

    public void Deact()
    {
        NoteBox.transform.position = new Vector2(10000000000000000000, 0);
        //NoteBox.SetActive(false);
    }
}
