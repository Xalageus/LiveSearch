using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSearch
{
    public partial class Options : Form
    {
        private MainForm main;
        private Strings descriptionStrings;

        public Options(MainForm main, int current)
        {
            InitializeComponent();
            this.descriptionStrings = new Strings();
            stdLabel.MaximumSize = new Size(200, 0);
            stdLabel.AutoSize = true;

            this.main = main;

            searchTypeCB.SelectedIndex = current;
            setDescription(current);
        }

        private void searchTypeCB_SelectedValueChanged(object sender, EventArgs e)
        {
            main.setSearchType(searchTypeCB.SelectedIndex);
            setDescription(searchTypeCB.SelectedIndex);
        }

        private void setDescription(int current)
        {
            switch (current)
            {
                case 0:
                    stdLabel.Text = descriptionStrings.MANUAL_DESCRIPTION;
                    break;
                case 1:
                    stdLabel.Text = descriptionStrings.CONTAINS_DESCRIPTION;
                    break;
                case 2:
                    stdLabel.Text = descriptionStrings.SPREAD_DESCRIPTION;
                    break;
            }
        }
    }
}
