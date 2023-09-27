using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programa1_practica_clase_alumno
{
    public partial class AlumnoForm : Form
    {
        private Alumno alumno;

        public AlumnoForm()
        {
            InitializeComponent();
        }

        private void CapturarDesplegarButton_Click(object sender, EventArgs e)
        {
            // Usar MessageBox para capturar datos del usuario
            string nombre = Prompt("Ingrese el nombre del alumno:");
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Nombre no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apellidos = Prompt("Ingrese los apellidos del alumno:");
            if (string.IsNullOrWhiteSpace(apellidos))
            {
                MessageBox.Show("Apellidos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numeroControl;
            string numeroControlStr = Prompt("Ingrese el número de control:");
            if (!int.TryParse(numeroControlStr, out numeroControl))
            {
                MessageBox.Show("Número de control no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte semestre;
            string semestreStr = Prompt("Ingrese el semestre:");
            if (!byte.TryParse(semestreStr, out semestre))
            {
                MessageBox.Show("Semestre no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string carrera = Prompt("Ingrese la carrera:");
            if (string.IsNullOrWhiteSpace(carrera))
            {
                MessageBox.Show("Carrera no válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear objeto Alumno
            alumno = new Alumno(nombre, apellidos, numeroControl, semestre, carrera);

            // Mostrar datos en el TextBox
            ResultadoTextBox.Clear(); // Limpia el TextBox antes de mostrar nuevos datos
            ResultadoTextBox.AppendText("Datos del alumno" + Environment.NewLine);
            ResultadoTextBox.AppendText("Nombre del alumno: " + alumno.Nombre + " " + alumno.Apellidos + Environment.NewLine);
            ResultadoTextBox.AppendText("Numero de control: " + alumno.NumeroControl + Environment.NewLine);
            ResultadoTextBox.AppendText("Semestre: " + alumno.Semestre + Environment.NewLine);
            ResultadoTextBox.AppendText("Carrera: " + alumno.Carrera);
        }

        private string Prompt(string promptText)
        {
            // Muestra un MessageBox con un cuadro de texto para que el usuario ingrese datos
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = promptText,
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox() { Left = 50, Top = 20, Width = 400 };
            Button okButton = new Button() { Text = "OK", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            okButton.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(okButton);
            prompt.AcceptButton = okButton;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            ResultadoTextBox.Clear(); // Limpia el TextBox

        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Sale de la aplicación
        }
    }

    // Clase Alumno (actualizada con apellidos)
    class Alumno
    {
        public string Nombre { get; private set; }
        public string Apellidos { get; private set; }
        public int NumeroControl { get; private set; }
        public byte Semestre { get; private set; }
        public string Carrera { get; private set; }

        public Alumno(string nombre, string apellidos, int numeroControl, byte semestre, string carrera)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            NumeroControl = numeroControl;
            Semestre = semestre;
            Carrera = carrera;
        }
    }
}
