﻿using System;//Uso de las librerias del sistema
using System.Collections.Generic;//Uso de las librerias del sistema
using System.ComponentModel;//Uso de las librerias del sistema
using System.Data;//Uso de las librerias del sistema
using System.Drawing;//Uso de las librerias del sistema
using System.Linq;//Uso de las librerias del sistema
using System.Text;//Uso de las librerias del sistema
using System.Threading.Tasks;//Uso de las librerias del sistema
using System.Windows.Forms;//Uso de las librerias del sistema
using System.Diagnostics;//Uso de las librerias del sistema
using System.Runtime.InteropServices;//Uso de las librerias del sistema
using System.Speech.Synthesis;//Uso de las librerias del sistema de sintesis de texto a voz 
using System.Threading;//Uso de las librerias del sistema

/* 

 Controlador/Aplicación/Recepción/Conversión/Envío para Robot de 6 grados de libertad:

 SELECCION DEL TIPO DE SIMULADOR

 TFG - TRABAJO DE FIN DE GRADO
 MODULO DE RECONOCIMENTO GESTUAL PARA EL CONTROL DE ROBOT EN TAREAS DE ASISTENCIA

 ALUMNO : DAVID VELASCO GARCIA

 GRADO EN INGENIERÍA EN TECNOLOGÍAS INDUSTRIALES
 INTENSIFICACIÓN EN ELECTRÓNICA INDUSTRIAL Y AUTOMÁTICA

 UNIVERSISDAD CARLOS III DE MADRID
 ESCUELA POLITÉCNICA SUPERIOR

*/

namespace WindowsFormsApplication1//Namespace de la windows form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Inicialización de la form
            InitializeComponent();//Inicialización de la form
            //Inicialización de la pantalla
            FormBorderStyle = FormBorderStyle.None;//Desactivar bordes de la app, es decir los bordes de maximizar, minimizar y cerrar de windows
            WindowState = FormWindowState.Maximized;//Abrimos la form en modo pantalla completa
            TopMost = true;
        }
     

        private void label1_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void button1_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Fase 1 - copia\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void button2_Click_1(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Fase 2 - copia\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }

        private void button3_Click_1(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Leap Motion\Core Services\VisualizerApp.exe");//Herramienta de diagnostico
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)//Con ejecucion de la tecla escape
            {
                FormBorderStyle = FormBorderStyle.Sizable;//Cerrar pantalla completa
                WindowState = FormWindowState.Normal;//Modo ventana
                TopMost = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }


        [DllImport("user32.dll")]//Dll de software del sistema
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void button6_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {

            Process p = Process.Start(@"C:\Program Files (x86)\Leap Motion\Core Services\VisualizerApp.exe");//Ejecutamos la herramienta de diagnostico
            Thread.Sleep(500);//Tiempo de espera
            p.StartInfo.CreateNoWindow = true;//Manejo de forma embebida
            SetParent(p.MainWindowHandle, this.Handle);

        }

        private void button5_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Optimizacion y mejora de la precision\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual

        }


        private void button4_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Analisis de informacion gestual\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }

        private void button7_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            Application.Exit();//Cerrar app
        }

        private void button1_Click_1(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Inicio\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //Función privada de ejecución de un elemento gráfico de la app
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)//Temprizador de la aplicación
        {
            label13.Text = DateTime.Now.ToShortTimeString();//Mostrar la fecha y hora en al etiqueta
            label12.Text = DateTime.Now.ToString("dd/MM/yyyy");//Formato
            if (i == 0)//Condición para ejecutar solo al inicio una vez
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();//Instanciación de objeto de sistesis de voz

                //Selecionar dispositivo predeterminado del ordenador
                synth.SetOutputToDefaultAudioDevice();

                //Sintesis de texto a voz, con instruciones de uso

                synth.Speak("El módulo de control de robot vía simulador ha sido iniciado correctamente");
                synth.Speak("Porfavor, seleccione el simulador con el que desea trabajar, es decir, RobotStudio ");
                synth.Speak("Situe las manos sobre el dispositivo leap motion y comience a realizar el control de robot por medios gestuales");
                synth.Speak("Si desea realizar un control de cámaras, por favor seleccione la cámara deseada del listado, y seleccione iniciar, si desea detener la transmision de imagen, seleccione detener.");

                i++;//Condición para ejecutar solo al inicio una vez
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();//Inicio del reloj
          
        }

        private void button15_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Informacion del proyecto\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }

        private void button14_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Ejemplos de uso\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }

        private void button8_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Conversion\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }

        private void button11_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Control de robot via modulo\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }

        private void button13_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Control de robot prototipo\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }

        private void button17_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Simulacion via OpenRAVE\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }
        private void button16_Click(object sender, EventArgs e)//Función privada de ejecución de un elemento gráfico de la app
        {
            System.Diagnostics.Process.Start(@"C:\Users\david\Documents\Visual Studio 2015\Projects\Simulacion via RobotStudio\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\WindowsFormsApplication1.exe");
            Application.Exit();//Abrimos la windows form de la ruta seleccionada y cerramos la actual
        }
    }
       
}