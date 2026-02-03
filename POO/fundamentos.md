# PROGRAMACIÓN ORIENTADA A OBJETOS

Es un paradigma de programación que organiza el código en torno a "Objetos".

## ¿Qué es un OBJETO?

La definición de Objeto puede darse como la **INSTANCIA** de una **CLASE** que tiene sus propios ATRIBUTOS y COMPORTAMIENTOS únicos.

## ¿Qué es una CLASE?

Es como un tipo de **plantilla, molde**... etc. Que indica cómo debe definirse los **ATRIBUTOS y MÉTODOS** que tendrán los objetos.
Una vez tenemos nuestra clase creada, podemos hacer INSTANCIAS de esta clase.

### Caracteristicas principales que toda Clase debe de tener:

- **Atriubos o Estado**: Son los datos o características que describen un objetos (ej. color, modelo).
- **Métodos o Comportamiento**: Son las acciones o funcionalidades que el objeto puede realizar (ej. Arrancar, frenar).
- **Identidad**: Es la asignación de un nombre para poder identificarla.

## Encapsulación

El encapsulamiento lo que hace es **ocultar** los **datos internos** de una Clase y solo permite su acceso a través de metódos seguros, protegiendo la integridad de la información.

### Modificadores de Acceso

Son palabras claves (**Private, Protected, Public**) que **controlan** la **visibilidad y acceso** de los diferentes atributos, métodos y constructores de una clase.
Son funadamentales para el encapsulamiento, protegiendo los datos de accesos externos no autorizados y definiendo que componentes son accesibles internamente o desde afuera.

## Constructores

El constructor es un metodo especial que **se encarga de darle un estado inicial a un objeto**.

## Herencia

La Herencia en POO es un mecanimos clave donde una **clase (hija o subclase) adquiere los atributos y metódos** de otra **clase (padre o superclase)**, permitiendo la reutilización de código y la creación de jerarquías.

### Conceptos clave

- **Superclase (Clase Padre/Base)**: La clase original que provee atributos y métodos.
- **Subclase (Clase Hija/Derivada)**: La clase que hereda de la superclase y puede añadir o modificar características.
- **Reutilización de Código:** Evita escribir el mismo código varias veces, definiendo lo común una sola vez en la clase padre.
- **Jerarquía:** Crea relaciones lógicas de "es un" (ej. "un Automóvil es un Vehículo").
- **Extensibilidad:** Permite crear nuevas clases especializadas fácilmente.

### Beneficios

- **Organización:** Código más estructurado y fácil de mantener.
- **Eficiencia:** Ahorro de tiempo y recursos al no duplicar lógica.
- **Mantenimiento:** Los cambios en la clase padre se reflejan en las hijas.

### Fundamentos de la herencia (Visual Basic)

La instrucción **Inherits** se usa para declarar una nueva clase, denominada clase derivada, basada en una clase existente, conocida como clase base. Las clases derivadas **heredan y pueden extenderse, las propiedades, métodos, eventos, campos y constantes definidos** en la clase base.

### La Palabra clave MyBase

La palabra clave **MyBase** se comporta como una variable de objeto que **hace referencia a la clase base de la instancia actual de una clase**. MyBase **se usa** normalmente para **acceder a los miembros de la clase base** que se invalidan o se reemplazan en una clase derivada. En concreto, MyBase.New se usa para llamar explícitamente a un constructor de clase base desde un constructor de clase derivada.

## Campos de clase estáticos (SHARED)

En VB.NET los campos de clase estáticos **se definen con la palabra clase SHARED**(Compartido). Estos **pertenecen a la clase** en sí y **NO a una instancia** especifica.

### Puntos clave:

- **Acceso directo**: No es necesario crea un objeto con "New" para usarlos; Accedes mediante "NombreClase.Campo"
- **Instancia única**: Solo existe una copia del campo en memoria, compartida por todas las intancias de la clase.
- **Inicialización**: Se cargan cuando se accede a la clase por primera vez.

## Clases estáticas (STATIC MODULE MODULOS)
