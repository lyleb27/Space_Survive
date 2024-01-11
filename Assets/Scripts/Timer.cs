using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float tempsÉcoulé = 0.0f;
    public Text texteTemps;

    void Start()
    {
        tempsÉcoulé = PlayerPrefs.GetFloat("TempsEcoule", 0.0f);

        texteTemps.text = "Temps écoulé : " + tempsÉcoulé.ToString("F1") + "s";
    }

    void Update()
    {
        tempsÉcoulé += Time.deltaTime;
        texteTemps.text = "Temps écoulé : " + tempsÉcoulé.ToString("F1") + "s";
    }
}
