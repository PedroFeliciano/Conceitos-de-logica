using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class TelaPrincipalUsuarioComum : Form
    {
        public TelaPrincipalUsuarioComum(Usuario Usuario)
        {
            InitializeComponent();
            label1.Text = Usuario.Nome;
            Text = "Tela principal";
            
        }
    }
}
