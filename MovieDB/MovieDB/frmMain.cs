using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.movieDBDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDBDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.movieDBDataSet.Movie);

        }
    }
}
