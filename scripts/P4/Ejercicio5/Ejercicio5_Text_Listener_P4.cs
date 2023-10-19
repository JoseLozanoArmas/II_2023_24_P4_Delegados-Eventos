using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio5_Text_Listener_P4 : MonoBehaviour
{
    public Ejercicio5_Cube_Listener_P4 EJ5;
    public Text text_component;

    public void Start() {
        EJ5.OnUpdatePuntuation += OnUpdatePuntuation;
    }

    private void OnUpdatePuntuation(int new_points){
        text_component.text = "Puntuation: " + new_points;
    }

}
