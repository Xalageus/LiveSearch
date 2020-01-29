using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSearch
{
    class Searchables
    {
        private string[] list;
        private List<string> results;

        public Searchables()
        {
            this.list = System.IO.File.ReadAllLines(@"list.txt");
            this.results = new List<string>();
        }

        public string[] getList()
        {
            return this.list;
        }

        public List<string> searchManualSpread(string term)
        {
            this.results.Clear();

            for (int i = 0; i < list.Length; i++)
            {
                int termPos = 0;
                bool found = false;

                for (int j = 0; j < list[i].Length; j++)
                {
                    if (!found)
                    {
                        if (list[i][j] == term[termPos])
                        {
                            termPos++;

                            if (termPos == term.Length)
                            {
                                found = true;
                            }
                        }
                    }
                }

                if (found)
                {
                    this.results.Add(list[i]);
                }
            }

            return this.results;
        }

        public List<string> searchManual(string term)
        {
            this.results.Clear();

            for (int i = 0; i < list.Length; i++)
            {
                int termPos = 0;
                bool found = false;

                for (int j = 0; j < list[i].Length; j++)
                {
                    if (!found)
                    {
                        if (list[i][j] == term[termPos])
                        {
                            termPos++;

                            if (termPos == term.Length)
                            {
                                found = true;
                            }
                        }
                        else
                        {
                            termPos = 0;
                        }
                    }
                }

                if (found)
                {
                    this.results.Add(list[i]);
                }
            }

            return this.results;
        }

        public List<string> searchContains(string term)
        {
            this.results.Clear();

            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Contains(term))
                {
                    this.results.Add(list[i]);
                }
            }

            return this.results;
        }
    }
}
