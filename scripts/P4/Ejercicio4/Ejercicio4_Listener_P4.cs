/* 
* Universidad de La Laguna
* Escuela Superior de Ingeniería y Tecnología
* Grado en Ingeniería Informatíca
* Asignatura: Interfaces Inteligentes
* Curso: 4º
* Práctica 4: Delegados, Eventos
* Autor: José Lozano Armas
* Correo: alu0101392561@ull.es
* Fecha: 18/10/23
* Script que sirve para recibir un evento que Implementar la mecánica de recoger esferas en la escena que actualicen la puntuación del jugador. 
* Las esferas de tipo 1 suman 5 puntos y las esferas de tipo 2 suman 10. Mostrar la puntuación en la consola.
* Referencias: https://docs.google.com/document/d/1f1fie9tx9cjhXi8gPyOTFDZIxWlraf5TCP9onbRMD54/edit?usp=sharing
* Enlaces de interés
* Historial de revisiones
* 18/10/2023 - Creación (primera versión) del código 
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_Listener_P4 : MonoBehaviour
{
    public Ejercicio4_Delegate_P4[] EJ4;
    public int points;

    private void Start() {
        foreach(var iterator in EJ4) {
            iterator.OnIncreasePuntuation += IncreasePuntuation;
        }
    }

    private void IncreasePuntuation(int new_points) {
        points += new_points;
        Debug.Log("Puntuación actual:" + points);
    }

    private void EraseSphere() {
        foreach (var iterator in EJ4) {
            if (iterator != null) {
                iterator.OnIncreasePuntuation -= IncreasePuntuation;
            }
        }
    }
}
