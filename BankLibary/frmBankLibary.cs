using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibary
{
    public partial class frmBankLibary : Form
    {
        protected int TextBoxCount { get; set; } = 4; //número de controles TextBox en el formulario

        // las constantes en la enumeración específican los ínidces de los controles TextBox
        public enum TextBoxIndices { Account, First, Last, Balance }

        //constructor sin párametros
        public frmBankLibary()
        {
            InitializeComponent();
        }

        //limpia todos los controles TextBox

        public void ClearTextBOx()
        {
            // itera a través de cada Control en el formulario 
            foreach (Control guiControl in Controls)
            {
                // si el control es TextBox, lo limpia 
                (guiControl as TextBox)?.Clear();
            }
        }


        // establece los valores de los controles TextBox con el arreglo string values
        public void SetTextBoxValues(string[] values)
        {
            // determina si el arreglo string tiene la longitud correcta 
            if (values.Length != TextBoxCount)
            {
                //Lanza excepción si no tiene la longitud correcta 
                throw new ArgumentException($"There must be {TextBoxCount} string in the array", nameof(values));
            }
            else
            {
                // establece al arreglo los valores si el arreglos tiene la longitud correcta 
                txtAccount.Text = values[(int)TextBoxIndices.Account];
                txtFirstName.Text = values[(int)TextBoxIndices.First];
                txtLastName.Text = values[(int)TextBoxIndices.Last];
                txtBalance.Text = values[(int)TextBoxIndices.Balance];
            }
        }

        //devuelve los valores de los controles TextBox como un arreglo string

        public string[] GetTextBoxValues()
        {
            return new string[]
            {
                txtAccount.Text, txtFirstName.Text, txtLastName.Text, txtBalance.Text
            }; 
        }
    }
}
