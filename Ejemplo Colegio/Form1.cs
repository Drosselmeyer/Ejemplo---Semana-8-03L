using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Colegio
{
    public partial class Form1 : Form
    {
        //Bandera o contador para llevar el control
        int conAlu = 0, conDoc = 0, conMat = 0;
        //Arreglos para manejar datos
        Alumno[] alumnos = new Alumno[3];
        Docente[] docentes = new Docente[3];
        Materia[] materias = new Materia[3];

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            alumnos[conAlu].Nombre = txtNombre.Text;
            alumnos[conAlu].Grado = txtGrado.Text;
            alumnos[conAlu].Seccion = txtSeccion.Text;

            conAlu++;
        }

        private void btnRegistrarNota_Click(object sender, EventArgs e)
        {
            docentes[conDoc].Nombre = txtDocente.Text;
            docentes[conDoc].Nivel = txtNivel.Text;
            conDoc++;

            materias[conMat].Nombre = txtMateria.Text;
            materias[conMat].Nota = Convert.ToDouble(txtNota.Text);
            conMat++;
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            dgvMostrarDatos.Columns.Clear();

            dgvMostrarDatos.ColumnCount = 4;

            dgvMostrarDatos.Columns[0].Name = "Nombre";
            //dgvMostrarDatos.Columns[1].Name = "Grado";
            //dgvMostrarDatos.Columns[2].Name = "Seccion";
            dgvMostrarDatos.Columns[1].Name = "Docente";
            //dgvMostrarDatos.Columns[4].Name = "Nivel";
            dgvMostrarDatos.Columns[2].Name = "Materia";
            dgvMostrarDatos.Columns[3].Name = "Nota";

            for(int i =0; i<conAlu; i++)
            {
                dgvMostrarDatos.Rows.Add();

                //Mostramos los datos del alumno
                dgvMostrarDatos.Rows[i].Cells[0].Value = alumnos[i].Nombre;
                //dgvMostrarDatos.Rows[i].Cells[1].Value = alumnos[i].Grado;
                //dgvMostrarDatos.Rows[i].Cells[2].Value = alumnos[i].Seccion;
                //Mostramos los datos del docente
                dgvMostrarDatos.Rows[i].Cells[1].Value = docentes[i].Nombre;
                //dgvMostrarDatos.Rows[i].Cells[4].Value = docentes[i].Nivel;
                //Mostramos los datos de la materia
                dgvMostrarDatos.Rows[i].Cells[2].Value = materias[i].Nombre;
                dgvMostrarDatos.Rows[i].Cells[3].Value = materias[i].Nota;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                alumnos[i] = new Alumno();
                docentes[i] = new Docente();
                materias[i] = new Materia();
            }
        }
    }
}
