using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio6_Listener_P4 : MonoBehaviour
{
    public Ejercicio6_Delegate_P4 EJ6;
    public Text text_component;

    public void Start() {
        EJ6.OnUpdatePuntuation += OnUpdatePuntuation;
    }

    private void OnUpdatePuntuation(int new_points){
        text_component.text = "Puntuation: " + new_points;
    }
}
