# Practica-03SI

# Escenarios

En esta primera parte de la practia hemos realizado distintos escenarios para ver como se pueden llegar a comportar los objetos de una escena con **Rigidbody**, **Collider**
o siendo **Trigers**

## Escenario-1

  El plano no es un elemento físico. El cubo sí lo es, pero la esfera no. Por lo tanto, el plano y la esfera únicamente necesitan un **collider**, mientras que el cubo debe contar con un **Rigidbody**.

  ![escena1](./gift/Fisicas-escenario1.gif)

## Esceanrio-2
  El plano no es un objeto físico. El cubo es un objeto físico y la esfera también. En este caso, el plano sólo tendrán **collider**, mientras que el cubo y la esfera deben tener **Rigidbody**.

  ![escena2](./gift/Fisicas-escenario2.gif)

## Escenario-3
  El plano no se considera un objeto físico, mientras que el cubo sí lo es y la esfera se comporta como un objeto cinemático. Por lo tanto, el plano únicamente requiere un **collider**, mientras que tanto el cubo como la esfera deben tener un **Rigidbody**, siendo este último configurado como **cinemático**.

   ![escena3](./gift/Fisicas-escenario3.gif)
