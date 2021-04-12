using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }

        delegate void CB();
        void AddText()
        {
            if(tbReceive.InvokeRequired)
            {
                CB cb = new CB(AddText);
                Invoke(cb);
            }
            else
            {
                tbReceive.AppendText(TmpString);
            }
            
        }

        string TmpString = "";
        Thread threadServer = null;
        Thread threadRead = null;
        TcpListener listener = null;
        TcpClient tcp = null;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(listener ==null)
            {
                listener = new TcpListener(int.Parse(tbSerPort.Text));
                listener.Start();
            }
            if(threadServer==null)
            {
                threadServer = new Thread(ServerProcess);
                threadServer.Start();
                threadRead = new Thread(ReadProcess);
            }
        }

        void ServerProcess()
        {
            while(true)
            {
                if(listener.Pending() == true) //접속 요청이 있는 경우...
                {
                    tcp = listener.AcceptTcpClient(); //블로킹 모드
                    threadRead.Start();
                }
                Thread.Sleep(100);
            }
            
        }

        void ReadProcess()
        {
            if(tcp != null)
            {
                NetworkStream ns = tcp.GetStream();
                byte[] bArr = new byte[50];
                while (true)
                {
                    while (ns.DataAvailable)
                    {
                        int n = ns.Read(bArr, 0, 50);
                        TmpString = Encoding.Default.GetString(bArr, 0, n);
                        AddText();
                    }
                }
            }
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(threadServer != null)
                threadServer.Abort();
            if (threadRead != null)
                threadRead.Abort();
        }
    }
}
