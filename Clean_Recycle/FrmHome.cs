using System;
using System.Windows.Forms;
using System.Management;
using AutoUpdaterDotNET;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace Clean_Recycle
{
    public partial class FrmHome : Form
    {
        #region Create Dll
        private static string StrCon = ConfigurationManager.ConnectionStrings["connectSQL"].ToString();
        private static string[] ad = StrCon.Split(';', '='); string[] ac = ad[1].Split(',', ' ');
        public static DataTable dt_BasicPolicy;
        public static List<string> ma_Scrip = new List<string>(), time_start = new List<string>();
        public static List<string> xapth = new List<string>();
        #endregion
        public FrmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\Keyboard-Tester-master\\KeyboardTester\\bin\\KeyboardTester.exe");
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt_BasicPolicy.Rows)
            {
                string xPath = row["Name_scripts"].ToString(); string[] path = xPath.Split('\r', '\n'); var xpat = path[0].ToString();
                xapth.Add(xpat);
                time_start.Add(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                ma_Scrip.Add(row["ID"].ToString());
                count_.Add(xpat);
            }
            Thread thread = new Thread(new ThreadStart(Select_SQL.Load_Basicxml)); thread.Start();
        }

        public static void check_()
        {
            AlertBox();
        }

        public static string thongbao_hile;
        private static void AlertBox()
        {
            Frm_AlertBox frm_Alert = new Frm_AlertBox();
            frm_Alert.ShowDialog();
        }
        public static List<string> count_ = new List<string>();


        private void FrmHome_Load(object sender, EventArgs e)
        {
            Select_SQL.Load_BasicPolicy();
            Double CPUtprt = 0;
            System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(@"root\WMI", "Select * From MSAcpi_ThermalZoneTemperature");
            foreach (System.Management.ManagementObject mo in mos.Get())
            {
                CPUtprt = Convert.ToDouble(Convert.ToDouble(mo.GetPropertyValue("CurrentTemperature").ToString()) - 2732) / 10;
                lb_Tempertature.Text = "Nhiệt độ CPU:" + CPUtprt.ToString() + " °C";
            }
            lb_IPadd.Text = "Địa chỉ IP: " + Connect_SQL.ipaddress;
            lb_MAC.Text = "Địa chỉ MAC: " + Connect_SQL.mac;
            lb_NamePC.Text = "Server IP: " + ac[1];
        }
    }
}
