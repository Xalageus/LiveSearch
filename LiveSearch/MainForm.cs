using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveSearch
{
    public partial class MainForm : Form
    {
        private Searchables list;
        private int searchType;

        public MainForm()
        {
            InitializeComponent();

            this.list = new Searchables();
            this.searchType = 0;
            getInitList();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            if (searchBar.Text == "")
            {
                getInitList();
            }
            else
            {
                List<string> results;

                switch (searchType)
                {
                    case 0:
                        results = list.searchManual(searchBar.Text);
                        break;
                    case 1:
                        results = list.searchContains(searchBar.Text);
                        break;
                    case 2:
                        results = list.searchManualSpread(searchBar.Text);
                        break;
                    default:
                        results = list.searchManual(searchBar.Text);
                        break;
                }

                searchResults.Items.Clear();

                for (int i = 0; i < results.Count; i++)
                {
                    searchResults.Items.Add(results[i]);
                }
            }
        }

        private void getInitList()
        {
            string[] listItems = list.getList();

            for (int i = 0; i < listItems.Length; i++)
            {
                searchResults.Items.Add(listItems[i]);
            }
        }

        public void setSearchType(int type)
        {
            this.searchType = type;
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Options options = new Options(this, searchType);
            options.ShowDialog();
        }
    }
}