using System;
using System.Windows.Forms;

namespace MsgBox_Uso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            // A forma mais simples de MessageBox.Show.
            //
            MessageBox.Show("C# é uma ótima linguagem de programação.");
            //
            // Caixa de diálogo com texto e título.
            //
            MessageBox.Show("Não deslsigue o compuador.",
            "Mensagem Importante");
            //
            // Caixa de diálogo com dois botões: sim e não. 
            //
            DialogResult result1 = MessageBox.Show("Você quer continuar mesmo?",
            "Importante Questão",
            MessageBoxButtons.YesNo);
            //
            // Caixa de diálogo com ícone de pergunta.
            //
            DialogResult result2 = MessageBox.Show("Você acha C# é uma ótima linguagem de programação?",
            "Consulta Importante",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);
            //
            // Caixa de diálogo com ícone de pergunta e botão padrão.
            //
            DialogResult result3 = MessageBox.Show("Você gostou do C#?",
            "A pergunta",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            //
            // Testa os resultados dos três diálogos anteriores.
            //
            if (result1 == DialogResult.Yes &&
                result2 == DialogResult.Yes &&
                result3 == DialogResult.No)
            {
                MessageBox.Show("Você respondeu sim, sim e não.");
            }
            //
            // Caixa de diálogo alinhada à direita (não é útil).
            //
            MessageBox.Show("Salve antes de desligar.",
            "Aviso critico",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign,
            true);
            //
            // Caixa de diálogo com ícone de exclamação.
            //
            MessageBox.Show("C# é fantástico!",
            "Nota Importante",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1);

            string nomeservidor = "Financeiro";
                // verificar se a variável tem valor.

                if (nomeservidor.Length != 0) // se a variável não tiver conteúdo
                {

                // Inicializa as variáveis para passar para o método MessageBox.Show.

                string message = "O nome do servidor é inválido. Cancela esta operação?";
                    string caption = "Nome incorreto do servidor.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Exibe o MessageBox.

                    result = MessageBox.Show(this, message, caption, buttons,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign);

                    if (result == DialogResult.Yes)
                    {

                        // Fecha o formulário

                        this.Close();
                    }
                }
            

        }
    }
}
