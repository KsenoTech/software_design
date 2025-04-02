using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBD_Click(object sender, EventArgs e)
        {
            using (GameContext dbcontext = new GameContext())
            {
                dbcontext.Teams.Select(i => i).ToList();
                //Можно сразу добавить данные:
                dbcontext.Teams.Add(new Team() { Coach = "Allegri", Name = "Juventus" });
                dbcontext.SaveChanges();
            }
        }
    }
}
