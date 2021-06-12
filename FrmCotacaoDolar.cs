using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotacaoDolar
{
    public partial class FrmCotacaoDolar : Form
    {
        public FrmCotacaoDolar()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string strURL = "https://api.hgbrasil.com/finance?array_limit=1&fields=only_results,USD&key=2690589e";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = client.GetAsync(strURL).Result;

                    if (!response.IsSuccessStatusCode)
                    {
                        lblCompra.Text = "-";
                        lblVenda.Text = "-";
                        lblVariacao.Text = "-";


                    }
                    else
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                        MercadoFinceiro mercado = JsonConvert.DeserializeObject<MercadoFinceiro>(result);

                        lblCompra.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Currency.buy);
                        lblVenda.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", mercado.Currency.sell);
                        lblVariacao.Text = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:P}", mercado.Currency.Varaiation / 100);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                
                
            }
        }
    }
}
