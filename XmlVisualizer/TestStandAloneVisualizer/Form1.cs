﻿// Xml Visualizer v.2
// by Lars Hove Christiansen (larshove@gmail.com)
// http://www.codeplex.com/XmlVisualizer

using System;
using System.Threading;
using System.Windows.Forms;
using XmlVisualizer;

namespace TestStandAloneVisualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void modelessButton_Click(object sender, EventArgs e)
        {
            ThreadStart threadDelegate = ShowModeless;
            Thread thread = new Thread(threadDelegate);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void modalButton_Click(object sender, EventArgs e)
        {
            ShowModal();
        }

        private static void ShowModeless()
        {
            using (Visualizer visualizer = new Visualizer(true))
            {
                visualizer.Show();
            }
        }

        private static void ShowModal()
        {
            using (Visualizer visualizer = new Visualizer(true))
            {
                visualizer.ShowDialog();
            }
        }
    }
}
