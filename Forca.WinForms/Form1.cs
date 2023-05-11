using System;

namespace Forca.WinForms {
    public partial class Form1 : Form {
        public Form1() {

            InitializeComponent();
            IniciarNovoJogo();
        }

         string[] palavras = {"ABACATE","ABACAXI", "ACEROLA", "ACAI", "ARACA", "BACABA", "BACURI", "BANANA",
            "CAJA", "CAJU", "CARAMBOLA", "CUPUAÇU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO","MAÇA", "MANGABA",
            "MANGA", "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};

         int indicePalavraSecreta = 0, erros = 0, acertos = 0;
         char chute;

        char[] palavraSecretaArray;
        char[] arrayAcerto;

        private void DesenharForca() {
            switch (erros) {

                case 0: {
                        labelCabeca.Text = "";
                        labelCorpo.Text  = "";
                        labelBraco1.Text = "";
                        labelBraco2.Text = "";
                        labelPernas.Text = "";
                        break;
                    }
                case 1: labelCabeca.Text = "😧"; break;
                case 2: labelCabeca.Text = "😨"; labelCorpo.Text = "|"; break;
                case 3: labelCabeca.Text = "😥"; labelBraco1.Text = "/"; break;
                case 4: labelCabeca.Text = "😣"; labelBraco2.Text = "\\"; break;
                case 5: labelCabeca.Text = "😵"; labelPernas.Text = "👖"; break;

            }
            
        }
        private char[] SortearPalavra() {
            Random random = new Random();
            indicePalavraSecreta = random.Next(palavras.Length);
            palavraSecretaArray = palavras[indicePalavraSecreta].ToCharArray();
            return palavraSecretaArray;
        }

        private char[] ConfigurarLetrasCorretas(int tamanhoPalavra) { // Configura o array que será mostrado em tela com o mesmo tamanho da palavra sorteada
            char[] arrayAcerto = new char[tamanhoPalavra];
            Array.Fill<char>(arrayAcerto, '_');
            return arrayAcerto;
        }
        private void EscreverLetrasCorretas(char[] arrayAcerto) {
            for (int i = 0; i < arrayAcerto.Length; i++) {
                
                labelPalavra.Text += arrayAcerto[i];
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            chute = char.ToUpper(char.Parse(txtPalpite.Text));
            txtPalpite.Text = "";
            AnalisarChute(palavraSecretaArray, arrayAcerto);
            labelPalavra.Text = "";
            DesenharForca();
            EscreverLetrasCorretas(arrayAcerto);
            VerificarVitoria(acertos, palavraSecretaArray);
            VerificarDerrota(erros, arrayAcerto);

        }

        private void VerificarVitoria(int acertos, char[] palavraSecretaArray) {
           
            if (acertos >= palavraSecretaArray.Length) {
                MessageBox.Show("Você Ganhou!");
                IniciarNovoJogo();
            }
        }

        private void VerificarDerrota(int erros, char[] arrayAcerto) {
            
            if (erros >= 5) {
                MessageBox.Show("Você MORREU!");
                IniciarNovoJogo();
            }      
        }

        private void AnalisarChute(char[] palavraSecretaArray, char[] arrayAcerto) {
            
            bool acertou = false;

            for (int i = 0; i < palavraSecretaArray.Length; i++) {
                if (chute == palavraSecretaArray[i] && arrayAcerto[i] != palavraSecretaArray[i]) {
                    acertou = true;
                    acertos++;
                    arrayAcerto[i] = palavraSecretaArray[i];
                }
                if (chute == arrayAcerto[i]) {
                    acertou = true;
                }
            }
            if (!acertou) {
                erros++;
            }
        }

        private void IniciarNovoJogo() {

            erros = 0;
            acertos = 0;
            labelPalavra.Text = "";
            SortearPalavra();
            arrayAcerto = ConfigurarLetrasCorretas(palavraSecretaArray.Length);
            DesenharForca();
            EscreverLetrasCorretas(arrayAcerto);
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }
        private void label2_Click(object sender, EventArgs e) {

        }

    }
}