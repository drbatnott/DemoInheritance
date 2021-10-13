using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceDemo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// theLibrary will store any sort of Media
        /// We are going to make a CD library
        /// But CDs are types of Media
        /// </summary>
        List<Media> theLibrary;
        public Form1()
        {
            InitializeComponent();
            theLibrary = new List<Media>();
            CD cD = new CD("Schubert Symphonies 3 & 5", "Artist Wiener Philarmoniker");
            theLibrary.Add(cD);
            mediaListBox.Items.Add(cD.Title);
            mediaListBox.Items.Add(cD.ShortDescription);
            CD aCD = (CD)theLibrary[0];
            mediaListBox.Items.Add(aCD.TotalLength);
            cD.ShortDescription = "A Longer String than 10 characters";
            mediaListBox.Items.Add(cD.ShortDescription);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
