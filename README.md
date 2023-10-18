# II_2023_24_P4_Delegados-Eventos
## Introducción
El objetivo de esta práctica es el de poner en práctica lo aprendido sobre delegados y eventos. A continuación adjunto los gifs relacionados con los ejercicios realizados

## Ejercicios

### Ejercicio 1
A partir de la escena que has estado utilizando en las últimas prácticas, crea la siguiente mecánica. Cuando el cubo colisiona con el cilindro, las esferas de tipo 1 cambian su color y las esferas de tipo 2 se desplazan hacia el cilindro.
Ayuda: La colisión con el cilindro será manejada con alguno de los eventos OnCollider u OnTrigger según su configuración. El cilindro debe enviar un mensaje. Las esferas deben estar suscritas a ese mensaje y según el grupo al que pertenezcan implementarán la función de callback correspondiente.
![Ejercicio 1](/gifs/P4-EJ-1.gif)

### Ejercicio 2
Adapta la escena anterior para que:
Cuando el cubo colisiona con cualquier objeto que no sean esferas del grupo 1, las esferas en el grupo 1 se acercan al cilindro. Cuando el cubo toca cualquier esfera del grupo 1, las esferas del grupo 2 aumentan de tamaño.
Ayuda: Debes gestionar las colisiones de forma similar al caso anterior. Puedes usar prefabs para generar objetos con las mismas características (esferas en el grupo 1 y esferas en el grupo 2).

### Ejercicio 3
Cuando el cubo se aproxima al cilindro, las esferas del grupo 1 cambian su color y saltan y las esferas del grupo 2 se orientan hacia un objeto ubicado en la escena con ese propósito. 


### Ejercicio 4
Implementar la mecánica de recoger esferas en la escena que actualicen la puntuación del jugador. Las esferas de tipo 1 suman 5 puntos y las esferas de tipo 2 suman 10. Mostrar la puntuación en la consola.
Ayuda: Debes gestionar las colisiones. El cubo puede conocer con quién ha chocado a través del collider de la colisión:
```csharp
OnTriggerEnter(Collider other){
    other.gameobject.name;
 }
OnCollisionEnter(Collision collision){
    Debug.Log(collision.collider.gameobject.name);
}
```


### Ejercicio 5
Partiendo del script anterior crea una interfaz que muestre la puntuación que va obteniendo el cubo. 
Ayuda: La interfaz se genera con el objeto Canvas, que actúa como contenedor de elementos de la UI. En este caso, el elemento que debe incorporar es el componente texto, que debe ir siendo actualizado.


### Ejercicio 6
Genera una escena que incluya elementos que se ajusten a la escena del prototipo y alguna de las mecánicas anteriores.