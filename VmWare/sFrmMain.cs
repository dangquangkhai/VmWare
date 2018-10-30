using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.ServiceProcess;
using System.Diagnostics;

namespace VmWare
{
    public partial class sFrmMain : MetroForm
    {
        public sFrmMain()
        {
            InitializeComponent();
            sTooltip.SetToolTip(sBtnClear, "Xóa Log");
            sTooltip.SetToolTip(sBtnCopy, "Copy tới clipboard");
            sLogBox.ReadOnly = true;
        }

        // Append text of the given color.
        void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            box.SelectionLength = 0; // clear
        }



        public void startService(String serviceName)
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = serviceName;

            if (sc.Status == ServiceControllerStatus.Running ||
                sc.Status == ServiceControllerStatus.StartPending)
            {
                AppendText(sLogBox, Color.FromArgb(179, 179, 0),Environment.NewLine + "Warnning ");
                sLogBox.AppendText(DateTime.Today.ToString("dd/MM/yyyy") + ": Service "+ serviceName + " is already running");
            }
            else
            {
                try
                {
                    AppendText(sLogBox,Color.Black,Environment.NewLine + Environment.NewLine + DateTime.Today.ToString("dd/MM/yyyy") + ": Start pending... ");
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 10));

                    if (sc.Status == ServiceControllerStatus.Running)
                    {
                        AppendText(sLogBox, Color.Green, Environment.NewLine +  "Success ");
                        sLogBox.AppendText(DateTime.Today.ToString("dd/MM/yyyy") + ": Service " + serviceName + " started successfully.");
                    }
                    else
                    {
                        AppendText(sLogBox, Color.Red, Environment.NewLine +  "Error ");
                        sLogBox.AppendText(DateTime.Today.ToString("dd/MM/yyyy") + ": Service " + serviceName + " not started.");
                        sLogBox.AppendText("Error " + DateTime.Today.ToString("dd/MM/yyyy") + ": Current State: " + sc.Status.ToString("f"));
                    }
                }
                catch (InvalidOperationException)
                {
                    AppendText(sLogBox, Color.Red, Environment.NewLine +  "Error ");
                    sLogBox.AppendText(DateTime.Today.ToString("dd/MM/yyyy") + ": Could not start the service  " + serviceName + ".");
                }
            }
        }


        public void stopService(String serviceName)
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = serviceName;
            if (sc.Status == ServiceControllerStatus.Stopped ||
                sc.Status == ServiceControllerStatus.StopPending)
            {
                AppendText(sLogBox, Color.FromArgb(179, 179, 0), Environment.NewLine + "Warnning ");
                sLogBox.AppendText(DateTime.Today.ToString("dd/MM/yyyy") + ": Service " + serviceName + " is already stopped");
            }
            else
            {
                try
                {
                    AppendText(sLogBox, Color.Black, Environment.NewLine + Environment.NewLine + DateTime.Today.ToString("dd/MM/yyyy") + ": Stroping service...");
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped, new TimeSpan(0, 0, 10));
                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        AppendText(sLogBox, Color.Green, Environment.NewLine +  "Success ");
                        sLogBox.AppendText(DateTime.Today.ToString("dd/MM/yyyy") + ": Service " + serviceName + " stopped successfully.");
                    }
                    else
                    {
                        AppendText(sLogBox, Color.Red, Environment.NewLine +  "Error ");
                        sLogBox.AppendText(DateTime.Today.ToString("dd/MM/yyyy") + ": Service " + serviceName + " not stopped.");
                        sLogBox.AppendText("Error " + DateTime.Today.ToString("dd/MM/yyyy") + ": Current State: " + sc.Status.ToString("f"));
                    }
                }
                catch (InvalidOperationException)
                {
                    AppendText(sLogBox, Color.Red, Environment.NewLine +  "Error ");
                    sLogBox.AppendText(DateTime.Today.ToString("dd/MM/yyyy") + ": Could not stop the service  " + serviceName + ".");
                }
            }

            
        }

        private void sBtnStart_Click(object sender, EventArgs e)
        {
            startService("VMAuthdService"); 

            startService("VMnetDHCP"); 

            startService("VMware NAT Service"); 

            startService("VMUSBArbService"); 

            startService("VMwareHostd"); 

        }

        private void sBtnStop_Click(object sender, EventArgs e)
        {
            stopService("VMAuthdService");

            stopService("VMnetDHCP");

            stopService("VMware NAT Service");

            stopService("VMUSBArbService");

            stopService("VMwareHostd");
        }

        private void sBtnOpen_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "C:\\Program Files (x86)\\VMware\\VMware Workstation\\vmware.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
            AppendText(sLogBox,Color.Black, Environment.NewLine + DateTime.Today.ToString("dd/MM/yyyy") + ": VMware Workstation is running");
            proc.WaitForExit();
            AppendText(sLogBox, Color.Black, Environment.NewLine + DateTime.Today.ToString("dd/MM/yyyy") + ": VMware Workstation is stopped");
        }

        private void sBtnClear_Click(object sender, EventArgs e)
        {
            sLogBox.Text = "";
        }

        public void clearText()
        {
            sLogBox.Text = "";
        }

        private void sLogBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {   //click event
                //MessageBox.Show("you got it!");
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                MenuItem menuItem = new MenuItem("Clear All");
                menuItem.Click += new EventHandler(sBtnClear_Click);
                contextMenu.MenuItems.Add(menuItem);
                //menuItem = new MenuItem("Copy");
                //menuItem.Click += new EventHandler(CopyAction);
                //contextMenu.MenuItems.Add(menuItem);
                //menuItem = new MenuItem("Paste");
                //menuItem.Click += new EventHandler(PasteAction);
                //contextMenu.MenuItems.Add(menuItem);

                sLogBox.ContextMenu = contextMenu;
            }
        }
    }
}
