using System.Windows.Forms;

namespace simulacion_del_horno.ventanas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Simular()
        {
            int Tipo_de_material, TipoCombustible;

            Tipo_de_material = material_comboBox.SelectedIndex;
            TipoCombustible = combustible_comboBox.SelectedIndex;


            if (TipoCombustible == 0)
            {
                if (Tipo_de_material == 0)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "35min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "25min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "15min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "0.44kg";
                }

                if (Tipo_de_material == 1)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "45min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "35min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "25min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "0.75kg";
                }
                if (Tipo_de_material == 2)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "23min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "15min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "6min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "0.25kg";
                }
            }
            if (TipoCombustible == 1)
            {
                if (Tipo_de_material == 0)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "55min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "45min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "35min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                    material_gastado_textBox.Text = "1kg";
                }
                if (Tipo_de_material == 1)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "65min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "55min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "45min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "1.5kg";
                }
                if (Tipo_de_material == 2)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "40min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "30min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "20min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "0.90kg";
                }
            }
            if (TipoCombustible == 2)
            {
                if (Tipo_de_material == 0)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "35min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "25min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "15min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "1kg";
                }


                if (Tipo_de_material == 1)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "45min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "35min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "20min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "1.9kg";
                }
                if(Tipo_de_material == 2)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "20min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "10min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "6min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "3kg";
                }
            }
            if (TipoCombustible == 3)
            {
                if (Tipo_de_material == 0)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "25min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "19min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "12min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "0.50kg";
                }

                if (Tipo_de_material == 1)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "30min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "25min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "20min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "0.70kg";
                }
                if(Tipo_de_material == 2)
                {
                    if (radioButton1.Checked)
                    {
                        tiempo_textBox.Text = "0min";
                    }
                    if (radioButton2.Checked)
                    {
                        tiempo_textBox.Text = "20min";
                    }
                    if (radioButton3.Checked)
                    {
                        tiempo_textBox.Text = "12min";
                    }
                    if (radioButton4.Checked)
                    {
                        tiempo_textBox.Text = "5min";
                    }
                    if (radioButton1.Checked)
                    {
                        material_gastado_textBox.Text = "0kg";
                    }
                    else
                        material_gastado_textBox.Text = "0.25";
                }
            }
        }

        private void Limpiar()
        {

           tiempo_textBox.Clear();
           material_gastado_textBox.Clear();
        }

        private void simular_incineracion_button_Click(object sender, System.EventArgs e)
        {
            Simular();
        }

        private void limpiar_button_Click(object sender, System.EventArgs e)
        {
            Limpiar();
        }
    }
}
