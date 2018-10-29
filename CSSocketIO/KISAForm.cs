using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

using Quobject.SocketIoClientDotNet.Client;

// https://qiita.com/kingyo222/items/5a6c6c024ecc14720934

namespace CSSocketIO
{
  public partial class KISAForm : Form
  {
    Socket socket;

    public KISAForm()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.socket = IO.Socket("http://localhost:2000");

      this.socket.On(Socket.EVENT_CONNECT, () =>
      {
        Debug.WriteLine("EVENT_CONNECT");
      });
    }

    private void BtnReset_Click(object sender, EventArgs e)
    {
      this.socket.Emit("reset", "reset");
    }

    private void KISAForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.socket.Disconnect();
    }

    private void ATTACK_Click(object sender, EventArgs e)
    {
      this.socket.Emit("attack", "attack");
    }
  }
}
