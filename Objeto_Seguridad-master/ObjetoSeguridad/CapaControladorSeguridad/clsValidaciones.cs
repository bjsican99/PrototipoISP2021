using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControladorSeguridad
{
    public class clsValidaciones
    {
        char coma = (char)44;
        char guion = (char)45;
        char guionb = (char)95;
        char punto = (char)46;
        char bs = (char)8;
        char dosp = (char)58;
        //char arr = (char)64;
        int contador;
        int contadordp = 0;
        public void CamposNumerosYLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }
        public void CampoNumerico(KeyPressEventArgs e)
        {

            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }
        public void CamposLetrasTexto(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == guionb)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == guion)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == punto)
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == coma)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }
        public void Combobox(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }
        public void CamposVchar(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
            catch
            {

            }
        }
        public void CamposLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }
        public void Camposdecimales(KeyPressEventArgs e)
        {

            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (e.KeyChar == punto)
                {

                    contador++;
                    e.Handled = false;

                    if (contador >= 2)
                    {

                        e.Handled = true;
                        contador = 2;
                    }

                }
                else if (e.KeyChar == bs)
                {
                    contador = contador - contador;

                    if (contador <= 1)
                    {
                        e.Handled = false;
                    }
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }

                else
                {
                    e.Handled = true;
                }

            }
            catch
            {

            }
        }
        public void CamposHora(KeyPressEventArgs e)
        {

            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (e.KeyChar == dosp)
                {

                    contadordp++;
                    e.Handled = false;

                    if (contadordp >= 2)
                    {

                        e.Handled = true;

                    }

                }
                else if (e.KeyChar == bs)
                {
                    contadordp = contadordp - contadordp;

                    if (contadordp <= 1)
                    {
                        e.Handled = false;
                    }
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;
                }

                else
                {
                    e.Handled = true;
                }
            }
            catch
            {

            }
        }
    }
}
