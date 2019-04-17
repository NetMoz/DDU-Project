using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageManager : MonoBehaviour {
    public Canvas page2;
    public Canvas MedList;
    public Button ToPage2;
    public Button BacktoHomeFromPage2;
    public Button BacktoHomeFromMedList;
    public Button ToMedList;
    public Image YeetOff;
    public Button InsertPic;
    public GameObject PicPill;


    private void Start()
    {
        ToPage2.onClick.AddListener(ToPageTwo);
        BacktoHomeFromPage2.onClick.AddListener(ToHomePage);
        ToMedList.onClick.AddListener(MedListPage);
        BacktoHomeFromMedList.onClick.AddListener(ToHomePage);
    }

    void ToPageTwo()
    {
        page2.transform.position = new Vector2(0, 0);
        InsertPic.transform.position = new Vector2(0, 3.07075479664694f);
        PicPill.transform.position = new Vector2(0, 6.65190731616678f);

    }

    void ToHomePage()
    {
        page2.transform.position = new Vector2(1500, 0);
        MedList.transform.position = new Vector2(1500, 0);
        InsertPic.transform.position = new Vector2(0, 1500);
        PicPill.transform.position = new Vector2(0, 1500);
    }

    void MedListPage()
    {
        MedList.transform.position = new Vector2(0, 0);
    }
}
