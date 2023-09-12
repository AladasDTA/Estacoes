using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estações
{
    public partial class Es : Form
    {
        public Es()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnInverno.Enabled = true; //habilitar o botão do inverno
            btnoutono.Enabled = true; // 
            btnprimavera.Enabled = true; //
            btnverao.Enabled = true; //
            BtnAvançarOutono1.Visible = false; //
            BtnVoltar.Visible = false; //
            Btninicio.Visible = false; // 
            BtnAvançarInverno1.Visible = false; //
            BtnAvançarOutono1.Visible = false; //
            BtnAvançarPrimavera1.Visible = false; //
            BtnAvançarVerao1.Visible = false; //
            Btn1Vv1.Visible = false; //
            BtnVv2.Visible = false; //
            BtnVv3.Visible = false; //
            BtnVv4.Visible = false; //
            BtnVo1.Visible = false; //
            BtnVo2.Visible = false; //
            BtnVo3.Visible = false; //
            BtnVo4.Visible = false; //
            BtnVi1.Visible = false; //
            BtnVi2.Visible = false; //
            BtnVi3.Visible = false; //
            BtnVi4.Visible = false; //
            BtnVp1.Visible = false; //
            BtnVp2.Visible = false; //
            BtnVp3.Visible = false; //
            BtnVp4.Visible = false; //
            BtnVoltar.Visible = false; //
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources._4; //
            lbl1.ForeColor = Color.DarkOrange; //
            lbl1.Text = "Outono"; //
            Btninicio.Visible = true; //
            Btninicio.Enabled = true; //
            BtnAvançarOutono1.Visible = true; //
            BtnAvançarOutono1.Enabled = true; //
            BtnVoltar.Enabled = true; //
            BtnInverno.Enabled = false; //
            btnprimavera.Enabled = false; //
            btnverao.Enabled = false; //
            BtnVoltar.Visible = true; //
            Btn1Vv1.Visible = false; //
            BtnVv2.Visible = false; //
            BtnVv3.Visible = false; //
            BtnVv4.Visible = false; //
            BtnVo1.Visible = false; //
            BtnVo2.Visible = false; //
            BtnVo3.Visible = false; //
            BtnVo4.Visible = false; //
            BtnVi1.Visible = false; //
            BtnVi2.Visible = false; //
            BtnVi3.Visible = false; //
            BtnVi4.Visible = false; //
            BtnVp1.Visible = false; //
            BtnVp2.Visible = false; //
            BtnVp3.Visible = false; //
            BtnVp4.Visible = false; //
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources._5; //
            lbl1.ForeColor = Color.LightGray; //
            lbl1.Text = "Inverno"; //
            BtnAvançarInverno1.Visible = true; //
            BtnAvançarInverno1.Enabled = true; //
            BtnVoltar.Enabled = true; //
            Btninicio.Enabled = true; //
            Btninicio.Visible = true; //
            BtnVoltar.Visible = true; //
            btnoutono.Enabled = false; //
            btnprimavera.Enabled = false; //
            btnverao.Enabled = false; //
            Btn1Vv1.Visible = false; //
            BtnVv2.Visible = false; //
            BtnVv3.Visible = false; //
            BtnVv4.Visible = false; //
            BtnVo1.Visible = false; //
            BtnVo2.Visible = false; //
            BtnVo3.Visible = false; //
            BtnVo4.Visible = false; //
            BtnVi1.Visible = false; //
            BtnVi2.Visible = false; //
            BtnVi3.Visible = false; //
            BtnVi4.Visible = false; //
            BtnVp1.Visible = false; //
            BtnVp2.Visible = false; //
            BtnVp3.Visible = false; //
            BtnVp4.Visible = false; //
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources._3; //
            lbl1.ForeColor = Color.DarkViolet; //
            lbl1.Text = "Verão"; //
            BtnAvançarVerao1.Visible = true; //
            BtnAvançarVerao1.Enabled = true; //
            Btninicio.Enabled = true; //
            BtnVoltar.Enabled = true; //
            BtnVoltar.Visible = true; //
            Btninicio.Visible = true; //
            btnoutono.Enabled = false; //
            btnprimavera.Enabled = false; //
            BtnInverno.Enabled = false; //
            Btn1Vv1.Visible = false; //
            BtnVv2.Visible = false; //
            BtnVv3.Visible = false; //
            BtnVv4.Visible = false; //
            BtnVo1.Visible = false; //
            BtnVo2.Visible = false; //
            BtnVo3.Visible = false; //
            BtnVo4.Visible = false; //
            BtnVi1.Visible = false; //
            BtnVi2.Visible = false; //
            BtnVi3.Visible = false; //
            BtnVi4.Visible = false; //
            BtnVp1.Visible = false; //
            BtnVp2.Visible = false; //
            BtnVp3.Visible = false; //
            BtnVp4.Visible = false; //
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources._72; //
            lbl1.ForeColor = Color.DeepPink; //
            lbl1.Text = "Primavera"; //
            BtnAvançarPrimavera1.Visible = true; //
            BtnAvançarPrimavera1.Enabled = true; //
            Btninicio.Visible = true; //
            Btninicio.Enabled = true; //
            BtnVoltar.Visible = true; //
            BtnVoltar.Enabled = true; //
            btnoutono.Enabled = false; //
            btnverao.Enabled = false; //
            BtnInverno.Enabled = false; //
            Btn1Vv1.Visible = false; //
            BtnVv2.Visible = false; //
            BtnVv3.Visible = false; //
            BtnVv4.Visible = false; //
            BtnVo1.Visible = false; //
            BtnVo2.Visible = false; //
            BtnVo3.Visible = false; //
            BtnVo4.Visible = false; //
            BtnVi1.Visible = false; //
            BtnVi2.Visible = false; //
            BtnVi3.Visible = false; //
            BtnVi4.Visible = false; //
            BtnVp1.Visible = false; //
            BtnVp2.Visible = false; //
            BtnVp3.Visible = false; //
            BtnVp4.Visible = false; //
            

        }

        private void Btninicio_Click(object sender, EventArgs e)
        {
            BtnInverno.Enabled = true; //habilitar o botão do inverno
            btnoutono.Enabled = true; // 
            btnprimavera.Enabled = true; //
            btnverao.Enabled = true; //
            BtnAvançarOutono1.Visible = false; //
            BtnVoltar.Visible = false; //
            Btninicio.Visible = false; // 
            BtnAvançarInverno1.Visible = false; //
            BtnAvançarOutono1.Visible = false; //
            BtnAvançarPrimavera1.Visible = false; //
            BtnAvançarVerao1.Visible = false; //
            BtnAvançarInicio.Visible = true; //
            BtnAvançarInicio.Enabled = true; //
            BackgroundImage = Properties.Resources._2; //
            lbl1.Visible = true; //
            lbl1.Text = "Estações"; //
            lbl1.ForeColor = Color.Black; //
            Txt1.Visible = false; //
            Btn1Vv1.Visible = false; //
            BtnVv2.Visible = false; //
            BtnVv3.Visible = false; //
            BtnVv4.Visible = false; //
            BtnVo1.Visible = false; //
            BtnVo2.Visible = false; //
            BtnVo3.Visible = false; //
            BtnVo4.Visible = false; //
            BtnVi1.Visible = false; //
            BtnVi2.Visible = false; //
            BtnVi3.Visible = false; //
            BtnVi4.Visible = false; //
            BtnVp1.Visible = false; //
            BtnVp2.Visible = false; //
            BtnVp3.Visible = false; //
            BtnVp4.Visible = false; //
            

        }

        private void BtnAvançarInicio_Click(object sender, EventArgs e)
        {
            BtnInverno.Enabled = false; //habilitar o botão do inverno
            btnoutono.Enabled = false; // 
            btnprimavera.Enabled = false; //
            btnverao.Enabled = false; //
            BtnAvançarOutono1.Visible = false; //
            BtnVoltar.Visible = true; //
            BtnVoltar.Enabled = true; //
            Btninicio.Visible = true; // 
            Btninicio.Enabled = true; //
            BtnAvançarInverno1.Visible = false; //
            BtnAvançarOutono1.Visible = false; //
            BtnAvançarPrimavera1.Visible = false; //
            BtnAvançarVerao1.Visible = false; //
            lbl1.Visible = false; //
            Txt1.Visible = true; //
            Txt1.Text = "As estações do ano representam quatro subdivisões climáticas no período de um ano: verão, outono, inverno e primavera.As estações não ocorrem de forma simultânea em todo o mundo, já que são determinadas, em cada localidade, pela dinâmica de rotação e translação do planeta."; //
            Txt1.ReadOnly = true; //
            BtnAvançarInicio.Visible = false; //
            Btn1Vv1.Visible = false; //
            BtnVv2.Visible = false; //
            BtnVv3.Visible = false; //
            BtnVv4.Visible = false; //
            BtnVo1.Visible = false; //
            BtnVo2.Visible = false; //
            BtnVo3.Visible = false; //
            BtnVo4.Visible = false; //
            BtnVi1.Visible = false; //
            BtnVi2.Visible = false; //
            BtnVi3.Visible = false; //
            BtnVi4.Visible = false; //
            BtnVp1.Visible = false; //
            BtnVp2.Visible = false; //
            BtnVp3.Visible = false; //
            BtnVp4.Visible = false; //
           






        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {
            BtnInverno.Enabled = true; //habilitar o botão do inverno
            btnoutono.Enabled = true; // 
            btnprimavera.Enabled = true; //
            btnverao.Enabled = true; //
            BtnAvançarOutono1.Visible = false; //
            BtnVoltar.Visible = false; //
            Btninicio.Visible = false; // 
            BtnAvançarInverno1.Visible = false; //
            BtnAvançarOutono1.Visible = false; //
            BtnAvançarPrimavera1.Visible = false; //
            BtnAvançarVerao1.Visible = false; //
            Btn1Vv1.Visible = false; //
            BtnVv2.Visible = false; //
            BtnVv3.Visible = false; //
            BtnVv4.Visible = false; //
            BtnVo1.Visible = false; //
            BtnVo2.Visible = false; //
            BtnVo3.Visible = false; //
            BtnVo4.Visible = false; //
            BtnVi1.Visible = false; //
            BtnVi2.Visible = false; //
            BtnVi3.Visible = false; //
            BtnVi4.Visible = false; //
            BtnVp1.Visible = false; //
            BtnVp2.Visible = false; //
            BtnVp3.Visible = false; //
            BtnVp4.Visible = false; //
            BtnVoltar.Visible = false; //
            lbl1.Visible = true; //
            lbl1.Text = "Estações"; //
            lbl1.ForeColor = Color.Black; //
            Txt1.Visible = false; //
            BackgroundImage = Properties.Resources._2; //
            BtnAvançarInicio.Enabled = true; //
            BtnAvançarInicio.Visible = true; //
        }
    }
}
