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
        private bool caseSensitive;

        public MainForm()
        {
            InitializeComponent();

            this.list = new Searchables();
            this.searchType = 0;
            this.caseSensitive = true;
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
                        results = list.searchManual(searchBar.Text, caseSensitive);
                        break;
                    case 1:
                        results = list.searchContains(searchBar.Text, caseSensitive);
                        break;
                    case 2:
                        results = list.searchManualSpread(searchBar.Text, caseSensitive);
                        break;
                    default:
                        results = list.searchManual(searchBar.Text, caseSensitive);
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

        public void setCaseS(bool enable)
        {
            this.caseSensitive = enable;
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            Options options = new Options(this, searchType, caseSensitive);
            options.ShowDialog();
        }
    }
}