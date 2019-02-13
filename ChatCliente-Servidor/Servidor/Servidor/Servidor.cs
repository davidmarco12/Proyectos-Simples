using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//directivas a usar
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace Servidor
{
    class Servidor
    {
        /* TcpListener ----> Espera la conexion del Cliente
         * TcpClient   ----> Proporciona la conexion entre el servidor y el cliente
         * NetWorkStream ---> Se encarga de enviar mensajes atravez de los sockets
         */

        private TcpListener server;
        private TcpClient client = new TcpClient();
        private IPEndPoint ipendp = new IPEndPoint(IPAddress.Any, 8000);
        private List<Connection> list = new List<Connection>();

        Connection conn;


        private struct Connection {
            public NetworkStream stream;
            public StreamWriter streamW;
            public StreamReader streamR;
            public string nick;
        }

        public Servidor() {

            Inicio();
        }



        public void Inicio() {

            Console.WriteLine("Servidor OK");
            server = new TcpListener(ipendp); //Empieza a escuchar por ipendp
            server.Start(); //Arranca el sv

            while (true) {
                client = server.AcceptTcpClient(); //Espero que un cliente se conecte

                conn = new Connection();
                conn.stream = client.GetStream(); //Obtenemos el flujo de informacion
                conn.streamR = new StreamReader(conn.stream); //de lectura(letra y texto)
                conn.streamW = new StreamWriter(conn.stream); //y de escritura si queremos mandarle informacion

                conn.nick = conn.streamR.ReadLine(); //lo leemos por stream y lo almaceno en nick

                list.Add(conn); //lo guardo en la lista
                Console.WriteLine(conn.nick + " se a conectado");


                Thread t = new Thread(Escuchar_conexion); //creo el hilo

                t.Start();//inicio el hilo

            }
        }
        void Escuchar_conexion() {
            Connection hcon = conn;
            do {
                try {
                    string tmp = hcon.streamR.ReadLine();
                    Console.WriteLine(hcon.nick + ": " + tmp);
                    foreach (Connection c in list) {
                        try {
                            c.streamW.WriteLine(hcon.nick + ": " + tmp);
                            c.streamW.Flush();

                        }
                        catch{ }
                    }
                }
                catch{
                    list.Remove(hcon);
                    Console.WriteLine(conn.nick + " se a desconectado...");
                    break;
                }
            } while (true);

        }
    }
}
