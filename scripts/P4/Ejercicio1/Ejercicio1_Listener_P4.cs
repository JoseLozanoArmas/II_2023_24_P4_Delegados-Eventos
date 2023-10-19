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
* Script que sirve para recibir un evento que permite que las esferas del grupo 1 cambien de color y las del grupo 2 
* se situen donde el cilindro cuando el cubo choca con el mismo
* Referencias: https://docs.google.com/document/d/1f1fie9tx9cjhXi8gPyOTFDZIxWlraf5TCP9onbRMD54/edit?usp=sharing
* Enlaces de interés
* Historial de revisiones
* 18/10/2023 - Creación (primera versión) del código 
*/ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_Listener_P4 : MonoBehaviour
{
    public Material new_material;
    public GameObject find_object;
    public Vector3 moveDirection;
    public float speed;
    public Ejercicio1_Delegate_P4 eventEJ1;

    void Start() {
        eventEJ1.OnCollider += OnCollider;
    }
    
    private void OnCollider() {
        if (gameObject.tag == "sphere_type_1") {
            Renderer rend = GetComponent<Renderer>();
            rend.material = new_material;
        } 
        if (gameObject.tag == "sphere_type_2") {
            transform.position = eventEJ1.transform.position;
        }
    }
}
