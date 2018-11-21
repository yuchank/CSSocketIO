using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

using System.Diagnostics;

using Quobject.SocketIoClientDotNet.Client;

// https://qiita.com/kingyo222/items/5a6c6c024ecc14720934

namespace CSSocketIO
{
  public partial class KISAForm : Form
  {
    private Socket socket;

    public KISAForm()
    {
      InitializeComponent();

      // Full Screen 
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.WindowState = FormWindowState.Maximized;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.socket = IO.Socket("http://localhost:2000");

      this.socket.On(Socket.EVENT_CONNECT, () =>
      {
        Debug.WriteLine("EVENT_CONNECT");
      });

      this.socket.On("speed-cs", (v) =>
      {
        String s = String.Format("{0:F0}", Convert.ToDouble(v));
        // CSafeSetText(speed, s);
      });

      this.socket.On("gear-cs", (v) =>
      {
        String s = String.Format("{0:F0}", v);
        // CSafeSetText(gear, s);
      });
    }

    delegate void CrossThreadSafetySetText(Control ctl, String text);

    private void CSafeSetText(Control ctl, String text)
    {
      if (ctl.InvokeRequired)
      {
        ctl.Invoke(new CrossThreadSafetySetText(CSafeSetText), ctl, text);
      }
      else
      {
        ctl.Text = text;
      }
    }

    //public void setSpeed(String str)
    //{
    //  this.speed.Text = str;
    //}

    //public void setGear(String str)
    //{
    //  this.gear.Text = str;
    //}

    private void KISAForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.socket.Disconnect();
      this.socket.Close();
    }

    protected override void WndProc(ref Message m)
    {
      UInt32 WM_DEVICECHANGE = 0x0219;
      UInt32 DBT_DEVTUP_VOLUME = 0x02;
      UInt32 DBT_DEVICEARRIVAL = 0x8000;
      UInt32 DBT_DEVICEREMOVECOMPLETE = 0x8004;
      if ((m.Msg == WM_DEVICECHANGE) && (m.WParam.ToInt32() == DBT_DEVICEARRIVAL)) //디바이스 연결
      {
        int devType = Marshal.ReadInt32(m.LParam, 4);
        if (devType == DBT_DEVTUP_VOLUME)
        {
          this.socket.Emit("attack", "attack");
        }
      }
      if ((m.Msg == WM_DEVICECHANGE) && (m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)) // 디바이스 연결 해제
      {
        int devType = Marshal.ReadInt32(m.LParam, 4);
        if (devType == DBT_DEVTUP_VOLUME)
        {
        }
      }
      base.WndProc(ref m);
    }

    private void BtnApp_Click(object sender, EventArgs e)
    {
      this.socket.Emit("app", "app");
    }

    private void BtnOBD_Click(object sender, EventArgs e)
    {
      this.socket.Emit("obd", "obd");
    }

    private void BtnAuto_Click(object sender, EventArgs e)
    {
      this.socket.Emit("auto", "auto");
    }

    //public void RefreshDevice()
    //{
    //  LbUsb.Items.Clear();
    //  string[] ls_drivers = System.IO.Directory.GetLogicalDrives();
    //  foreach (string device in ls_drivers)
    //  {
    //    System.IO.DriveInfo dr = new System.IO.DriveInfo(device);
    //    if (dr.DriveType == System.IO.DriveType.Removable) //제거 가능한 타입이라면
    //    {
    //      LbUsb.Items.Add(device);
    //    }
    //  }
    //}

  }
}
