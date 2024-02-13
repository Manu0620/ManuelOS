using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ManuelOS
{
    public partial class TextEditor : UserControl
    {

        public TextEditor()
        {
            InitializeComponent();
        }

        private void mnNew_Click(object sender, EventArgs e)
        {

        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Leer el archivo seleccionado
                string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                // Mostrar el texto en el editor
                contentTextArea.Text = text;
            }
        }
    }
}
