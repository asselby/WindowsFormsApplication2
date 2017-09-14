using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first = "Имя - Асель;";
            string second = "Группа - СДП 162;";
            string third = "Направление - программирование;";
            double number = (first.Length + second.Length + third.Length) / 3;
            MessageBox.Show(first);
            MessageBox.Show(second);
            MessageBox.Show(third, number.ToString());
        
        }
    }
}
