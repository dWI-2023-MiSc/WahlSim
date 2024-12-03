using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinWahlLFH
{
    public class Kandidat
    {
        private int id;
        private string name;
        private string beruf;
        private int alter;


        public Kandidat(int id, string name, int alter, string beruf)
        {
            this.id = id;
            this.name = name;
            this.alter = alter;
            this.beruf = beruf;
        }

        public string Name => $"{this.id}: {this.name} | {this.alter} | {this.beruf}";

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getBeruf()
        {
            return this.beruf;
        }
        public void setBeruf(string beruf)
        {
            this.beruf = beruf;
        }
        public int getAlter()
        {
            return this.alter;
        }
        public void setAlter(int alter)
        {
            this.alter = alter;
        }
    }
}
