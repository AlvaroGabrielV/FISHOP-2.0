using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FISHOP
{
    public class GeradorProduto
    {
        public static List<Item> GerarProdutos(string busca)
        {
            try
            {
                string url = "https://google.serper.dev/shopping?q=" + busca + "&location=Brazil&gl=br&hl=pt-br&apiKey=376df5a263ccd5aaaa0dc4631c4e8605b635576c";
                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(url);
                    ApiResponse response = JsonConvert.DeserializeObject<ApiResponse>(json);
                    return response?.Shopping ?? new List<Item>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar produtos: " + ex.Message);
                return new List<Item>();
            }
        }
    }
}
