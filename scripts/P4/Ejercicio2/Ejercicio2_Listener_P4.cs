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
* Script que sirve para recibir un evento que permite que cuando el cubo colisiona con cualquier objeto que no sean esferas del grupo 1, las esferas 
* en el grupo 1 se acercan al cilindro y que cuando el cubo toca cualquier esfera del grupo 1, las esferas del grupo 2 aumentan de tamaño.
* Referencias: https://docs.google.com/document/d/1f1fie9tx9cjhXi8gPyOTFDZIxWlraf5TCP9onbRMD54/edit?usp=sharing
* Enlaces de interés
* Historial de revisiones
* 18/10/2023 - Creación (primera versión) del código 
*/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_Listener_P4 : MonoBehaviour
{
    public Ejercicio2_Delegate_P4 eventEJ2;
    public GameObject cylinder;
    float increase = 3;
    
    void Start() {
        eventEJ2.OnCollideOtherType += OnCollideOtherType;
        eventEJ2.OnCollideFirstGroup += OnCollideFirstGroup;
    }

    private void OnCollideOtherType() {
        if (gameObject.tag == "sphere_type_1") {
            if (gameObject != null)
            transform.position = cylinder.transform.position;
        }
    }

    private void OnCollideFirstGroup() {
        if (gameObject.tag == "sphere_type_2") {
            transform.localScale *= increase;
        }
    }
}
