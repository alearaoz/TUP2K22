#include<stdio.h>
/*

Carrera: Tecnicatura en Programacion Universitaria
Materia: Programacion II
Docente: Sergio Durigo
Alumno: Jose Alejandro Araoz

Enunciado:

    Ejercicio 1:
        Escribe un programa que use un bucle for para mostrar el resultado de 
        multiplicar los números del 1 al 20 por el resultado de obtener el 
        módulo (resto de la división que se obtiene usando el operador % de C)
        de dicho número con un número elegido por el usuario.

*/

int main(){

  // Definicion de las variables del ciclo for
  int i=1, k=20, num=0, modulo=0;

  // Muestra mensaje de explicacion y posteriormente solicita el ingreso del numero para el calculo
  printf("Ejercicio 1:\n");
  printf("Este programa calculara el modulo entre los numeros del 1 al 20, divididos por un numero de su eleccion.\n\n");
  printf("Por favor elija un numero: ");
  scanf_s("%i", &num);
  printf("\n");
  // Comienza el bucle for para el calculo del modulo
  for(i=1;i<=k;i++){

    // Calcula el modulo entre i y num
    modulo=i%num;
  
    // Muestra el resultado por pantalla
    printf("El modulo de %i en %i es %i\n",i,num,modulo);
  }

  // Si no hay errores el programa finaliza con 0
  return 0;

};