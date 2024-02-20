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
        public string openFile = "";
        public event EventHandler OnFileSended;
        public TextEditor()
        {
            InitializeComponent();
        }

        public void ReceiveFile(string file)
        {
            openFile = file;
            string text = System.IO.File.ReadAllText(openFile);
            contentTextArea.Text = text;
        }

        private void mnNew_Click(object sender, EventArgs e)
        {
            if (contentTextArea.Text != "")
            {
                string text = System.IO.File.ReadAllText(openFile);

                if (text == contentTextArea.Text)
                {
                    contentTextArea.Text = "";
                    openFile = "";
                    return;
                }

                DialogResult result = messageDialog.Show();
                if (result == DialogResult.Yes)
                {
                    mnSave_Click(sender, e);
                    contentTextArea.Text = "";
                    openFile = "";
                }
                else if (result == DialogResult.No)
                {
                    openFile = "";
                    contentTextArea.Text = "";
                    return;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            string appPath = getAppDirectory();
            string fullPath = System.IO.Path.Combine(appPath, "Storage", "Documents");

            openFileDialog.InitialDirectory = fullPath;
            openFileDialog.Title = "Open text file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Leer el archivo seleccionado
                string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                openFile = openFileDialog.FileName;
                // Mostrar el texto en el editor
                contentTextArea.Text = text;
            }
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            string appPath = getAppDirectory();
            string fullPath = System.IO.Path.Combine(appPath, "Storage", "Documents");

            if (openFile == "")
            {
                saveFileDialog.InitialDirectory = fullPath;
                saveFileDialog.Title = "Save text file";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Guardar el archivo seleccionado
                    System.IO.File.WriteAllText(saveFileDialog.FileName, contentTextArea.Text);
                    openFile = saveFileDialog.FileName;
                }
            }
            else
            {
                System.IO.File.WriteAllText(openFile, contentTextArea.Text);
            }

        }

        private string getAppDirectory()
        {
            // Obtener la ruta de ejecución de la aplicación
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // Obtener la ruta del directorio del proyecto
            string projectDirectory = System.IO.Path.GetDirectoryName(assemblyPath);
            while (!System.IO.Directory.Exists(System.IO.Path.Combine(projectDirectory, "Storage")))
            {
                projectDirectory = System.IO.Directory.GetParent(projectDirectory).FullName;
                if (projectDirectory == null)
                {
                    throw new InvalidOperationException("No se pudo encontrar el directorio del proyecto.");
                }
            }

            return projectDirectory;
        }

        private void mnCerrar_Click(object sender, EventArgs e)
        {
            if (contentTextArea.Text != "")
            {

                string text = System.IO.File.ReadAllText(openFile);

                if (text == contentTextArea.Text)
                {
                    contentTextArea.Text = "";
                    openFile = "";
                    return;
                }

                DialogResult result = messageDialog.Show();
                if (result == DialogResult.Yes)
                {
                    mnSave_Click(sender, e);
                    contentTextArea.Text = "";
                    openFile = "";
                }
                else if (result == DialogResult.No)
                {
                    openFile = "";
                    contentTextArea.Text = "";
                    return;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            string appPath = getAppDirectory();
            string fullPath = System.IO.Path.Combine(appPath, "Storage", "Documents");

            saveFileDialog.InitialDirectory = fullPath;
            saveFileDialog.Title = "Save text file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Guardar el archivo seleccionado
                System.IO.File.WriteAllText(saveFileDialog.FileName, contentTextArea.Text);
                openFile = saveFileDialog.FileName;
            }
        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            OnFileSended?.Invoke(this, new EventArgs());
        }
    }
}
