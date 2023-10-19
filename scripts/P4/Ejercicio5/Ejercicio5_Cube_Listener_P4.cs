using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_Cube_Listener_P4 : MonoBehaviour
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
