# Leap_Motion-Robot_Controller
Módulo de reconocimiento gestual para control de robot en tareas de asistencia
/*

David Velasco García

Grado en Ingeniería en Tecnologías Industriales

Intensificación en Electrónica Industrial y Automática

TFG

Módulo de reconocimiento gestual para control de robot en tareas de asistencia

Universidad Carlos III de Madrid

Tutor

Edwin Daniel Oña Simbaña

*/

El siguiente proyecto consta de un software de tipo interfaz gráfica, para el control de robot vía gestual a partir del dispositivo Leap Motion.

Modalidades de control: -Control coordenadas cartesianas 3 DOF. -Control coordenadas cartesianas + garra 4 DOF -Control YAW, PITCH, ROLL, + control de garra 4 DOF. -Control coordenadas cartesianas + inclinaciones de la mano YAW, PITCH, ROLL, más control de estado de apertura y cerrado 7 DOF. -Control incremental e incremental telematico 4 DOF. -Control por voz 4 DOF. -Modo balance con zona muerta 7 DOF. -Modo campo de velocidades con zona muerta 7 DOF. -Fusión control por voz + método de control gestual a elegir.

Aplicable a:

-Robot genérico -Robot industrial -Robot Arduino por servomotores 6 DOF.

Añadidos:

-Control en tiempo real de las cámara conectadas. -Asistente virtual, notificaciones de voz, instrucciones de uso y advertencias de estados de posiciones críticas. -Conexiones embidas con simulador RobotStudio con plugin Leap Motion, y visualizador de diagnostico de Leap Motion (Requiere instalación previa).

Se trata de un conjunto de windows form desarrolladas por separado e intercomunicadas.
Puede descargar y emplear por separado la sección deseada, si desea un control completo, descargue cada una de las form y extraiga todo en una misma ruta.