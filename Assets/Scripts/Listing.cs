using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Listing : MonoBehaviour
{
    //For Add Med
    public Button Apply;
    public List<string> MedicinName = new List<string>();
    public List<string> MedicinTimeHour = new List<string>();
    public List<string> MedicinTimeMinute = new List<string>();
    public List<string> MedicinDosis = new List<string>();
    public InputField InputMedName;
    public InputField InputMedTimeHour;
    public InputField InputMedDosis;
    public InputField InputMedTimeMinute;
    public GameObject MedAdded;
    public Button InsertPic;
    public GameObject PicPill;

    //For Med List:


    public Text Medicin1;
    public Text Dosis1;
    public Text TidT1;

    public Text Med1;
    public Text Dos1;
    public Text Tid1Time;
    public Text Med2;
    public Text Dos2;
    public Text Tid2Time;
    public Text Med3;
    public Text Dos3;
    public Text Tid3Time;
    public Text Med4;
    public Text Dos4;
    public Text Tid4Time;
    public Text Med5;
    public Text Dos5;
    public Text Tid5Time;
    public Text Med6;
    public Text Dos6;
    public Text Tid6Time;
    public Text Med7;
    public Text Dos7;
    public Text Tid7Time;

    public Text Tid1Minute;
    public Text Tid2Minute;
    public Text Tid3Minute;
    public Text Tid4Minute;
    public Text Tid5Minute;
    public Text Tid6Minute;
    public Text Tid7Minute;


    //For Clock sys
    DateTime TimeDisplay;
    public Text HoursUI, MinutesUI, DayUI, DayofWeekUI, MonthUI, YearUI;

    //NotificationObjects
    public GameObject Notification;
    public Text NoteMedName;
    public Text NoteMedTime;
    public Text NoteMedDosis;
    public Image NoteMedImage;
    public Text NotiName;
    public Text NotiDosis;
    public Button Read;
    public Button Video;


    void Start()
    {
        Apply.onClick.AddListener(AddMed);
        InsertPic.onClick.AddListener(AddPic);
        MedAdded.SetActive(false);
    }


    //Notification components
    
        

  


    void Update()
    {

         //Clock Objects
        TimeDisplay = DateTime.Now;
        HoursUI.text = TimeDisplay.Hour.ToString();
        MinutesUI.text = TimeDisplay.Minute.ToString();
        DayUI.text = TimeDisplay.Day.ToString();
        DayofWeekUI.text = TimeDisplay.DayOfWeek.ToString();
        MonthUI.text = TimeDisplay.Month.ToString();
        YearUI.text = TimeDisplay.Year.ToString();

        
       


        //Notification Activation Script 

        if (
            HoursUI.text == MedicinTimeHour[0] && MinutesUI.text == MedicinTimeMinute[0] ||
            HoursUI.text == MedicinTimeHour[1] && MinutesUI.text == MedicinTimeMinute[1] ||
            HoursUI.text == MedicinTimeHour[2] && MinutesUI.text == MedicinTimeMinute[2] ||
            HoursUI.text == MedicinTimeHour[3] && MinutesUI.text == MedicinTimeMinute[3] ||
            HoursUI.text == MedicinTimeHour[4] && MinutesUI.text == MedicinTimeMinute[4] ||
            HoursUI.text == MedicinTimeHour[5] && MinutesUI.text == MedicinTimeMinute[5] ||
            HoursUI.text == MedicinTimeHour[6] && MinutesUI.text == MedicinTimeMinute[6]
            )
        {
            RunNotification();
        }


        if (HoursUI.text == MedicinTimeHour[0] && MinutesUI.text == MedicinTimeMinute[0])
        {
            NotiName.text = MedicinName[0];
            NotiDosis.text = MedicinDosis[0];
        }

        if (HoursUI.text == MedicinTimeHour[1] && MinutesUI.text == MedicinTimeMinute[1])
        {
            NotiName.text = MedicinName[1];
            NotiDosis.text = MedicinDosis[1];
        }

        if (HoursUI.text == MedicinTimeHour[2] && MinutesUI.text == MedicinTimeMinute[2])
        {
            NotiName.text = MedicinName[2];
            NotiDosis.text = MedicinDosis[2];
        }

        if (HoursUI.text == MedicinTimeHour[3] && MinutesUI.text == MedicinTimeMinute[3])
        {
            NotiName.text = MedicinName[3];
            NotiDosis.text = MedicinDosis[3];
        }

        if (HoursUI.text == MedicinTimeHour[4] && MinutesUI.text == MedicinTimeMinute[4])
        {
            NotiName.text = MedicinName[4];
            NotiDosis.text = MedicinDosis[4];
        }

        if (HoursUI.text == MedicinTimeHour[5] && MinutesUI.text == MedicinTimeMinute[5])
        {
            NoteMedName.text = MedicinName[5];
            NoteMedDosis.text = MedicinDosis[6];
        }

        if (HoursUI.text == MedicinTimeHour[6] && MinutesUI.text == MedicinTimeMinute[6])
        {
            NotiName.text = MedicinName[6];
            NotiDosis.text = MedicinDosis[6];
        }
        //MedListAdd
        Med1.text = MedicinName[0];
        Dos1.text = MedicinDosis[0];
        Tid1Time.text = MedicinTimeHour[0];
        Tid1Minute.text = MedicinTimeMinute[0];
        Med2.text = MedicinName[1];
        Dos2.text = MedicinDosis[1];
        Tid2Time.text = MedicinTimeHour[1];
        Tid2Minute.text = MedicinTimeMinute[1];
        Med3.text = MedicinName[2];
        Dos3.text = MedicinDosis[2];
        Tid3Time.text = MedicinTimeHour[2];
        Tid3Minute.text = MedicinTimeMinute[2];
        Med4.text = MedicinName[3];
        Dos4.text = MedicinDosis[3];
        Tid4Time.text = MedicinTimeHour[3];
        Tid4Minute.text = MedicinTimeMinute[3];
        Med5.text = MedicinName[4];
        Dos5.text = MedicinDosis[4];
        Tid5Time.text = MedicinTimeHour[4];
        Tid5Minute.text = MedicinTimeMinute[4];
        Med6.text = MedicinName[5];
        Dos6.text = MedicinDosis[5];
        Tid6Time.text = MedicinTimeHour[5];
        Tid6Minute.text = MedicinTimeMinute[5];
        Med7.text = MedicinName[6];
        Dos7.text = MedicinDosis[6];
        Tid7Time.text = MedicinTimeHour[6];
        Tid7Minute.text = MedicinTimeMinute[6];

    }

    void AddMed()
    {
        MedicinName.Add(InputMedName.text);
        MedicinDosis.Add(InputMedDosis.text);
        MedicinTimeHour.Add(InputMedTimeHour.text);
        MedicinTimeMinute.Add(InputMedTimeMinute.text);

        InputMedName.text = "";
        InputMedDosis.text = "";
        InputMedTimeHour.text = "";
        InputMedTimeMinute.text = "";

        MedAdded.SetActive(true);

        InsertPic.transform.position = new Vector2(0, 3.07075479664694f);
        PicPill.transform.position = new Vector2(0, 6.65190731616678f);
    }

    void AddPic()
    {
        PicPill.transform.position = new Vector2(0, 3.07075479664694f);
        InsertPic.transform.position = new Vector2(0, 450);
    }

    public void RunNotification()
    {

        Notification.transform.position = new Vector2(0, 0);
        //NotiName.transform.position = new Vector2(1, 0);
        //NotiDosis.transform.position = new Vector2(1, -1);
        //Read.transform.position = new Vector2(0, -2);
        //Video.transform.position = new Vector2(0, -3);
    }

}

