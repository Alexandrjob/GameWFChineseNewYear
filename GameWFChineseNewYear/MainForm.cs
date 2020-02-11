﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace GameWFChineseNewYear
{
    public partial class MainForm : Form
    {
        private static World world;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Go);
            GamePlayForm gamePlayForm = new GamePlayForm(this,t);
            world = new World(gamePlayForm);
            gamePlayForm.Chinese = world.Chinese;

            this.Visible = false;

            gamePlayForm.Show();
            gamePlayForm.Refresh();


            
            Control.CheckForIllegalCrossThreadCalls = false;
            t.Start();
        }

        private void Go()
        {
            world.RunTheWorld();
        }
        
        private void buttonStartGame_MouseEnter(object sender, EventArgs e)
        {
            buttonStartGame.Size = new Size(260, 60);
        }

        private void buttonStartGame_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStartGame.Size = new Size(250, 50);
        }

        private void buttonStartGame_MouseUp(object sender, MouseEventArgs e)
        {
            buttonStartGame.Size = new Size(260, 60);
        }

        private void buttonStartGame_MouseLeave(object sender, EventArgs e)
        {
            buttonStartGame.Size = new Size(255, 55);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
