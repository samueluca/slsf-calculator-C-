using Exemplo.Classes;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        Operacoes op;
        public Form1()
        {
            InitializeComponent();
            op = new Operacoes();
        }

        public void setInputValues()
        {
            op.setXFromInput(double.Parse(inputTextX.Text));
            op.setYFromInput(double.Parse(inputTextY.Text));
        }

        public void printResult(double x, double y, string opSymbol, double result)
        {
            string operacaoDisplay;

            switch (opSymbol)
            {
                case "soma":
                    operacaoDisplay = $"{x} + {y}";
                    break;
                case "sub":
                    operacaoDisplay = $"{x} - {y}";
                    break;
                case "mult":
                    operacaoDisplay = $"{x} * {y}";
                    break;
                case "div":
                    operacaoDisplay = $"{x} / {y}";
                    break;
                case "quad":
                    operacaoDisplay = $"Quadrado de {x} ({x}²)";
                    break;
                case "raiz":
                    operacaoDisplay = $"Raiz de {x} (√{x})";
                    break;
                case "porc":
                    operacaoDisplay = $"{x}% de {y}";
                    break;
                case "bin":
                    operacaoDisplay = $"Binario ({x} e {y})";
                    break;
                case "elev":
                    operacaoDisplay = $"Potência ({x} ^ {y})";
                    break;
                default:
                    operacaoDisplay = "Cálculo desconhecido";
                    break;
            }

            string formatoSaida = $"Operação: {operacaoDisplay}\n\n";
            formatoSaida += $"O resultado é: {result:F4}";

            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;
        }

        private void onSomaClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = op.soma();
            printResult(op.getX(), op.getY(), "soma", result);
        }

        private void onSubClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = op.sub();
            printResult(op.getX(), op.getY(), "sub", result);
        }

        private void onMultClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = op.mult();
            printResult(op.getX(), op.getY(), "mult", result);
        }

        private void onDivClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = op.div();
            printResult(op.getX(), op.getY(), "div", result);
        }

        private void onQuadClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = op.quad();
            printResult(op.getX(), op.getY(), "quad", result);
        }

        private void onRaizClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = op.raiz();
            printResult(op.getX(), op.getY(), "raiz", result);
        }

        private void onPorcClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = op.porc();
            printResult(op.getX(), op.getY(), "porc", result);
        }

        private void onBinClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = (double)op.bin();
            printResult(op.getX(), op.getY(), "bin", result);
        }

        private void onElevClick(object sender, EventArgs e)
        {
            setInputValues();
            double result = op.elev();
            printResult(op.getX(), op.getY(), "elev", result);
        }

        private void inputTextX_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTextY_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}