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
* Script que sirve para recibir un evento que permite que cuando el cubo se aproxima al cilindro, las esferas del grupo 1 cambian su color y 
* saltan y las esferas del grupo 2 se orientan hacia un objeto ubicado en la escena con ese propósito.
* Referencias: https://docs.google.com/document/d/1f1fie9tx9cjhXi8gPyOTFDZIxWlraf5TCP9onbRMD54/edit?usp=sharing
* Enlaces de interés
* Historial de revisiones
* 18/10/2023 - Creación (primera versión) del código 
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_Listener_P4 : MonoBehaviour
{
    public Ejercicio3_Delegate_P4 EventEj3;
    public GameObject new_cube;
    public Material new_material;
    float altitude = 3.0f;

    void Start() {
        EventEj3.OnNearCylinder += OnNearCylinder;
    }

    private void OnNearCylinder() {
        if (gameObject.tag == "sphere_type_1") {
            Renderer rend = GetComponent<Renderer>();
            rend.material = new_material;
            Vector3 current_position = transform.position;
            transform.position = new Vector3(current_position.x, altitude, current_position.z);
        }
        if (gameObject.tag == "sphere_type_2") {
            transform.LookAt(new_cube.transform);
        }
    }

}
