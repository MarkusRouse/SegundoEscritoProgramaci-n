using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoEscritoProgramacion
{
    public partial class Form1 : Form
    {
        List<Profesional> listaProfesionales = new List<Profesional>();
        List<Amateur> listaAmateurs = new List<Amateur>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarAmateur_Click(object sender, EventArgs e)
        {
            if (txtBoxNombreAmateur.Text.Trim() != "" && txtCiAmateur.Text.Trim() != "" && txtFechaAmateur.Text.Trim() != "" && txtHorasAmateur.Text.Trim() != "" && txtAñosAmateur.Text.Trim() != "")
            {
                if (listaAmateurs.Count == 0)
                {
                    Amateur amateur = new Amateur(Convert.ToInt32(txtAñosAmateur.Text),Convert.ToInt32(txtCiAmateur.Text),Convert.ToInt32(txtHorasAmateur.Text),txtBoxNombreAmateur.Text,txtFechaAmateur.Text);
                    listaAmateurs.Add(amateur);
                    lstBoxAmateur.Items.Add(amateur.ToStringA());
                }
                else
                {
                    foreach (Amateur deportista in listaAmateurs)
                    {
                        if (deportista.CI == Convert.ToInt32(txtCiAmateur.Text))
                        {
                            MessageBox.Show("El deportista amateur ya existe");
                            break;
                        }
                        else if (listaAmateurs.Last() == deportista)
                        {
                            Amateur amateur = new Amateur(Convert.ToInt32(txtAñosAmateur.Text), Convert.ToInt32(txtCiAmateur.Text), Convert.ToInt32(txtHorasAmateur.Text), txtBoxNombreAmateur.Text, txtFechaAmateur.Text);
                            listaAmateurs.Add(amateur);
                            lstBoxAmateur.Items.Add(amateur.ToStringA());
                            break;
                        }
                    }
                }
            }
            else
            {
                if (txtBoxNombreAmateur.Text.Trim() == "")
                {
                    txtBoxNombreAmateur.Clear();
                }
                if (txtCiAmateur.Text.Trim() == "")
                {
                    txtCiAmateur.Clear();
                }
                if(txtAñosAmateur.Text.Trim() == "")
                {
                    txtAñosAmateur.Clear();
                }
                if (txtHorasAmateur.Text.Trim() == "")
                {
                    txtHorasAmateur.Clear();
                }
                if (txtFechaAmateur.Text.Trim() == "")
                {
                    txtFechaAmateur.Clear();
                }
            }
        }

        private void btnEliminarAmateur_Click(object sender, EventArgs e)
        {
            if (lstBoxAmateur.SelectedIndex != -1)
            {
                lstBoxAmateur.Items.Remove(lstBoxAmateur.SelectedItem);
                listaAmateurs.RemoveAt(lstBoxAmateur.SelectedIndex + 1);
            }
        }

        private void btnAgregarProfesional_Click(object sender, EventArgs e)
        {
            if (txtNombreProfesional.Text.Trim() != "" && txtCiProfesional.Text.Trim() != "" && txtFechaProfesional.Text.Trim() != "" && txtHorasProfesional.Text.Trim() != "" && txtSueldoProfesional.Text.Trim() != "")
            {
                if (listaProfesionales.Count == 0)
                {
                    Profesional profesional = new Profesional(Convert.ToInt32(txtSueldoProfesional.Text), Convert.ToInt32(txtCiProfesional.Text), Convert.ToInt32(txtHorasProfesional.Text), txtNombreProfesional.Text, txtFechaProfesional.Text);
                    listaProfesionales.Add(profesional);
                    lstBoxProfesional.Items.Add(profesional.ToStringP());
                }
                else
                {
                    foreach (Profesional deportista in listaProfesionales)
                    {
                        if (deportista.CI == Convert.ToInt32(txtCiProfesional.Text))
                        {
                            MessageBox.Show("El deportista profesional ya existe");
                            break;
                        }
                        else if (listaProfesionales.Last() == deportista)
                        {
                            Profesional profesional = new Profesional(Convert.ToInt32(txtSueldoProfesional.Text), Convert.ToInt32(txtCiProfesional.Text), Convert.ToInt32(txtHorasProfesional.Text), txtNombreProfesional.Text, txtFechaProfesional.Text);
                            listaProfesionales.Add(profesional);
                            lstBoxProfesional.Items.Add(profesional.ToStringP());
                            break;
                        }
                    }
                }
            }
            else
            {
                if (txtNombreProfesional.Text.Trim() == "")
                {
                    txtNombreProfesional.Clear();
                }
                if (txtCiProfesional.Text.Trim() == "")
                {
                    txtCiProfesional.Clear();
                }
                if (txtSueldoProfesional.Text.Trim() == "")
                {
                    txtSueldoProfesional.Clear();
                }
                if (txtHorasProfesional.Text.Trim() == "")
                {
                    txtHorasProfesional.Clear();
                }
                if (txtFechaProfesional.Text.Trim() == "")
                {
                    txtFechaProfesional.Clear();
                }
            }
        }

        private void btnEliminarProfesional_Click(object sender, EventArgs e)
        {
            if (lstBoxProfesional.SelectedIndex != -1)
            {
                lstBoxProfesional.Items.Remove(lstBoxProfesional.SelectedItem);
                listaProfesionales.RemoveAt(lstBoxProfesional.SelectedIndex + 1);
            }
        }

        private void txtCiProfesional_TextChanged(object sender, EventArgs e)
        {

        }
    }
    /*
     * sobre la cantidad indefinida de socios deportistas que integran la planilla, se quiere efectuar la siguientes operaciones
     * ..Agregar.. Que dado un deportista lo agrego a la plantilla. Esta operación se usara tanto para agregar deportistas profesionales como amateur
     * ..Listar.. que retorna la lista de todos los deportistas dicha lista se hace por pantalla 
     * 
    */
    public class Deportista
    {
        int ci, horas_almes;
        string nombre, fecha_nacimiento;

        public int CI
        {
            set
            {
                ci = value;
            }
            get
            {
                return ci;
            }
        }
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public string Fecha_nacimiento
        {
            set
            {
                fecha_nacimiento = value;
            }
            get
            {
                return fecha_nacimiento;
            }
        }
        public int HorasAlMes
        {
            set
            {
                horas_almes = value;
            }
            get
            {
                return horas_almes;
            }
        }
        public Deportista()
        {

        }
        public Deportista(int _ci,int _horas_almes,string _nombre,string _fecha)
        {
            nombre = _nombre;
            fecha_nacimiento = _fecha;
            horas_almes = _horas_almes;
            ci = _ci;
        }
        public string ToString()
        {
            return ("Ci: " + ci + " Nombre: " + nombre + " Nacimiento: " + fecha_nacimiento + " Horas de entrenamiento: " + horas_almes);
        }   
    }
    public class Amateur : Deportista
    {
        int años;
        public int Años
        {
            set
            {
                años = value;
            }
            get
            {
                return años;
            }
        }
        public Amateur()
        {

        }
        public Amateur(int _años, int _ci, int _horas_almes, string _nombre,string _fecha) : base(_ci,_horas_almes,_nombre,_fecha)
        {
            años = _años;
        }
        public string ToStringA()
        {
            return (this.ToString() + " Cantidad de años como deportista: " + años);
        }
        public int CostoMensual()
        {
            return (this.HorasAlMes * 300);
        }
    }
    public class Profesional : Deportista
    {
        int sueldo;
        public int Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }
        public Profesional()
        {

        }
        public Profesional(int _sueldo, int _ci,int _horas_almes, string _nombre, string _fecha) : base(_ci,_horas_almes,_nombre,_fecha)
        {
            sueldo = _sueldo;
        }
        public string ToStringP()
        {
            return (this.ToString() + " Sueldo: " + sueldo + " Costo mensual: " + CostoMensual());
        }
        public int CostoMensual()
        {
            return (HorasAlMes * 30000 + Sueldo);
        }
    }
}
