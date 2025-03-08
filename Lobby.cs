using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace ferreirosDeYork
{
    public partial class TelaLobby: Form
    {
        public TelaLobby()
        {
            InitializeComponent();
        }

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltarLobby_Click(object sender, EventArgs e)
        {
            TelaInicial menu = new TelaInicial();
            menu.Show();
            this.Close();
        }
    }
}
