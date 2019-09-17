using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public class Mensajes
    {
        /*  Estararizacion de mensajes
        
            /// Para dar INFORMACION al usuario (Usualmente satisfactoria)
        MessageBox.Show("Mensaje","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);

            /// Para dar ADVERTIR al usuario
        MessageBox.Show("Mensaje","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            /// Para dar PREGUNTAR al usuario
        MessageBox.Show("Mensaje","Espera...",MessageBoxButtons.OK,MessageBoxIcon.Question);
             
            /// Para dar MARCAR UN ERROR al usuario
        MessageBox.Show("Mensaje","Ups...",MessageBoxButtons.OK,MessageBoxIcon.Error);
             
        */
        public void bienvenido()
        {
            MessageBox.Show("Hola, estas en la clase de mensajes emergentes que utilizaraz para el usuario final","Bienvenido al Desarrollo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        public void error()
        {
            MessageBox.Show("Su petición no pudo ser completada", "Ups...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
