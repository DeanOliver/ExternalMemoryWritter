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
using ProcessMemoryReaderLib;
using System.Globalization;

namespace ExternalMemoryWritter
{
    public partial class Form1 : Form
    {
        ProcessModule mainModule;
        ProcessMemoryReader Mem = new ProcessMemoryReader();
        bool ProcessFound = false;

        // Look for the games process
        Process[] MyProcess = Process.GetProcessesByName("ac_client");


        #region -----LocalPlayerAddresses----
        int LocalPlayerBase = 0x50F4F4; // Base address for local player
        int[] LocalPlayerOff = new int[] { 0x0 };
        // Off sets
        int off_health = 0xF8;       // Health
        int off_rifle_ammo = 0x150;  // Assault rifle ammo
        int off_fire = 0x224;        // Shoot
        int off_Xmouse = 0x40;       // X co-ordinate of mouse
        int off_Ymouse = 0x44;       // Y co-ordinate of mouse
        int off_XPos = 0x4;          // X co-ordinate of player location
        int off_YPos = 0x8;          // Y co-ordinate of player location
        int off_ZPos = 0xC;          // Z co-ordinate of player location
        #endregion

        #region -----Enemy1Addresses------
        int Enemy1Base = 0x510D90;
        // This points at enemy health so need to minus the offsets
        // if the offset is less than F8
        int[] Enemy1Off = new int[] {0x0, 0x34C, 0x8, 0xf8 };
        // Off Sets
        int Enemy1XPos = 0xf4;
        int Enemy1YPos = 0xf0;
        int Enemy1ZPos = 0xEC;
        #endregion

        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (MyProcess.Length == 0)
            {
                MessageBox.Show("Make sure game is running");
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                mainModule = MyProcess[0].MainModule;
                Mem.ReadProcess = MyProcess[0];
                Mem.OpenProcess();
                ProcessFound = true;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {         
            if (ProcessFound)
            {
                // Store entities memory addresses
                int LocalPlayerAddress = Mem.ReadMultiLevelPointer(LocalPlayerBase, 4, LocalPlayerOff);
                int Enemy1Address = Mem.ReadMultiLevelPointer(Enemy1Base, 4, Enemy1Off);

                // Read Local PLayer Values
                int HealthValue = Mem.ReadInt(LocalPlayerAddress + off_health);
                int RiffleAmmoValue = Mem.ReadInt(LocalPlayerAddress + off_rifle_ammo);

                // Read Enemy 1 Values
                int Enemy1HealthValue = Mem.ReadInt(Enemy1Address);
                float Enemy1XPosValue = Mem.ReadFloat(Enemy1Address - Enemy1XPos);
                float Enemy1YPosValue = Mem.ReadFloat(Enemy1Address - Enemy1YPos);
                float Enemy1ZPosValue = Mem.ReadFloat(Enemy1Address - Enemy1ZPos);

                // Local Player Lables
                Health.Text = "Health: " + HealthValue.ToString();
                RiffleAmmo.Text = "Riffle Ammo: " + RiffleAmmoValue.ToString();

                // Enemy 1 Lables
                enemy1_hp_lable.Text = "Enemy 1 HP: " + Enemy1HealthValue.ToString();
                enemy1_xpos_lable.Text = "X-Pos: " + Enemy1XPosValue.ToString();
                enemy1_ypos_lable.Text = "Y-Pos: " + Enemy1YPosValue.ToString();
                enemy1_zpos_lable.Text = "Z-Pos: " + Enemy1ZPosValue.ToString();


                if (RiffleAmmoValue < 5)
                {
                    // Set Local Player Riffle Ammo to 20 if it less than 5
                    Mem.WriteInt(LocalPlayerAddress + off_rifle_ammo, 20);
                    // Set Local Player HP to 1000 when ammo is less han 5
                    Mem.WriteInt(LocalPlayerAddress + off_health, 1000);
                }

                // Left mouse button pressed
                int pressedLeftMouse = ProcessMemoryReaderApi.GetKeyState(01);
                if((pressedLeftMouse & 0x8000) !=0)
                {
                    Mem.WriteInt(LocalPlayerAddress + off_fire, 1);

                    // Remove Y-axin recoil when shooting
                    float Ymouse_pos = Mem.ReadFloat(LocalPlayerAddress + off_Ymouse);
                    Ymouse_pos -= 0.38f;
                    Mem.WriteFloat(LocalPlayerAddress + off_Ymouse, Ymouse_pos);
                }
                else
                {
                    Mem.WriteInt(LocalPlayerAddress + off_fire, 0);
                }

                // F1 button pressed
                int pressedF1 = ProcessMemoryReaderApi.GetKeyState(0x70);
                if ((pressedF1 & 0x8000) != 0)
                {


                    Mem.WriteFloat(LocalPlayerAddress + off_XPos, Enemy1XPosValue);
                    Mem.WriteFloat(LocalPlayerAddress + off_YPos, Enemy1YPosValue);
                    Mem.WriteFloat(LocalPlayerAddress + off_ZPos, Enemy1ZPosValue);

                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
