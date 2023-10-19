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
* Script que sirve para crear un evento que genere una escena que incluya elementos que se ajusten a la escena del prototipo y 
* alguna de las mecánicas anteriores.
* Referencias: https://docs.google.com/document/d/1f1fie9tx9cjhXi8gPyOTFDZIxWlraf5TCP9onbRMD54/edit?usp=sharing
* Enlaces de interés
* Historial de revisiones
* 19/10/2023 - Creación (primera versión) del código 
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6_Delegate_P4 : MonoBehaviour
{
    public Ejercicio4_Delegate_P4[] EJ4;
    public int points;
    public delegate void CollisionEvent(int new_points);
    public event CollisionEvent OnUpdatePuntuation;

    private void Start() {
        foreach(var iterator in EJ4) {
            iterator.OnIncreasePuntuation += IncreasePuntuation;
        }
    }

    private void IncreasePuntuation(int new_points) {
        points += new_points;
        OnUpdatePuntuation?.Invoke(points);
    }

    private void EraseSphere() {
        foreach (var iterator in EJ4) {
            if (iterator != null) {
                iterator.OnIncreasePuntuation -= IncreasePuntuation;
            }
        }
    }
}
