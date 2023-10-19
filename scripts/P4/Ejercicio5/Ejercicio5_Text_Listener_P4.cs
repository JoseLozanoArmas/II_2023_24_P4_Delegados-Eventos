/* 
* Universidad de La Laguna
* Escuela Superior de Ingeniería y Tecnología
* Grado en Ingeniería Informatíca
* Asignatura: Interfaces Inteligentes
* Curso: 4º
* Práctica 4: Delegados, Eventos
* Autor: José Lozano Armas
* Correo: alu0101392561@ull.es
* Fecha: 19/10/23
* Script que sirve para recibir un evento que partiendo del script anterior cree una interfaz que muestre la puntuación que va obteniendo el cubo. 
* Referencias: https://docs.google.com/document/d/1f1fie9tx9cjhXi8gPyOTFDZIxWlraf5TCP9onbRMD54/edit?usp=sharing
* Enlaces de interés
* Historial de revisiones
* 19/10/2023 - Creación (primera versión) del código 
*/ 
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
