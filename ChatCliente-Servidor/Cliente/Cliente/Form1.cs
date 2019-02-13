using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;
using MySql.Data.MySqlClient;

namespace Cliente
{
    public partial class Form1 : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamW;
        static private StreamReader streamR;
        static private TcpClient client = new TcpClient();
        static private string nick = "unknown";

        private delegate void DAddItem(string s);


        private void AddItem(String s) {
            listBox1.Items.Add(s);
        }

        void Listen() {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DAddItem(AddItem), streamR.ReadLine());

                }
                catch {
                    MessageBox.Show("No se ha podido conectar al servidor");
                    Application.Exit();

                }

            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        void Conectar() {
            try
            {
                client.Connect("127.0.0.1", 8000);

                if (client.Connected)
                {
                    Thread t = new Thread(Listen);
                    stream = client.GetStream();
                    streamW = new StreamWriter(stream);
                    streamR = new StreamReader(stream);
                    
                    streamW.WriteLine(nick);
                    streamW.Flush();
                    streamW.WriteLine("se ha conectado");
                    t.Start();
                }
                else
                {
                    MessageBox.Show("Servidor no Disponible");
                    Application.Exit();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Servidor No Dispoible");
                Application.Exit();

            }


        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
            if (txtConectar.Text != "")
            {
                //Hago conexion con la base de datos y verifico si el usuario existe
                MySqlConnection conectarSQL = new MySqlConnection("server = 127.0.0.1; database = mibd; UId = root; pwd = '' ;SslMode = none");
                conectarSQL.Open();

                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectamos = new MySqlConnection();
                codigo.Connection = conectarSQL;

                codigo.CommandText = ("SELECT * FROM usuarios WHERE usuario = '" + txtConectar.Text + "' and pwd = '" + txtContra.Text + "'  ");
                MySqlDataReader leer = codigo.ExecuteReader();

                //Verifico si exite, y me conecto al server
                if (leer.Read())
                {
                    //MessageBox.Show("Bienvenido");

                    label1.Visible = false;
                    txtConectar.Visible = false;
                    btnConectar.Visible = false;
                    txtContra.Visible = false;
                    lblError.Visible = false;
                    label2.Visible = false;
                    txtRegistro.Visible = false;
                    txtRegistroContra.Visible = false;
                    btnRegistro.Visible = false;


                    nick = txtConectar.Text;

                    Conectar();
                }
                else
                {

                    lblError.Text = "Usuario o Contraseña incorrectos\nPuedes crear un usuario en el Registro";
                }
                conectarSQL.Close();
            }
            else {
                lblError.Text = "Por favor, ingrese un nombre";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            streamW.WriteLine(txtEnviar.Text);
            streamW.Flush();
            txtEnviar.Clear();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Hago un nuevo registro agregando usuario y contraseña
            if (txtRegistro.Text != "" && txtRegistroContra.Text != "") {
                MySqlConnection conectarSQL = new MySqlConnection("server = 127.0.0.1; database = mibd; UId = root; pwd = '' ;SslMode = none");

                string sql = "INSERT INTO usuarios(usuario,pwd) VALUES('" + txtRegistro.Text + "', '" + txtRegistroContra.Text + "');";
                MySqlCommand cmd = new MySqlCommand(sql, conectarSQL);
                MySqlDataReader leer;
                conectarSQL.Open();
                leer = cmd.ExecuteReader();
                MessageBox.Show("Registro con exito");
                while (leer.Read())
                {

                }
                txtRegistroContra.Clear();
                txtRegistro.Clear();
                conectarSQL.Close();

            }
            else{
                MessageBox.Show("Por favor llene todos los campos");
            }
        }
    }
}
