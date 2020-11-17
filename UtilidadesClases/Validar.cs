using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilidadesClases
{
    class Validar
    {
		public static void SoloLetras(KeyPressEventArgs l)
		{
			if (Char.IsLetter(l.KeyChar))
			{
				l.Handled = false;
			}
			else if (Char.IsSeparator(l.KeyChar))
			{
				l.Handled = false;
			}
			else if (char.IsControl(l.KeyChar))
			{
				l.Handled = false;
			}
			else
			{
				l.Handled = true;
				MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		public static void SoloNumeros(KeyPressEventArgs l)
		{
			if (Char.IsDigit(l.KeyChar))
			{
				l.Handled = false;
			}
			else if (Char.IsSeparator(l.KeyChar))
			{
				l.Handled = false;
			}
			else if (char.IsControl(l.KeyChar))
			{
				l.Handled = false;
			}
			else
			{
				l.Handled = true;
				MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

	}
}
