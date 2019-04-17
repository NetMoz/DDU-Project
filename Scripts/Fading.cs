using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fading : MonoBehaviour {
    public float FadeOutTime;
    public GameObject MedAdded;


    public void Update()
    {
        if (MedAdded.activeSelf)
        {
            StartCoroutine(FadeOutRoutine());
            StartCoroutine(DeAct());
        }
    }
    private IEnumerator FadeOutRoutine()
    {
        Text text = GetComponent<Text>();
        Color originalColor = text.color;
        for (float t = 0.01f; t < FadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / FadeOutTime));
            yield return null;
        }
    }
    private IEnumerator DeAct()
    {
        yield return new WaitForSeconds(3   );
        MedAdded.SetActive(false);
        MedAdded.GetComponent<Text>().color = new Color(0, 0, 0, 255);
    }
}
