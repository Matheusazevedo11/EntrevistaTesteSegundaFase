using EntrevistaTesteSegundaFase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EntrevistaTesteSegundaFase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Durante a realização dos Exercicios fique a vontate para criar pastas e classes
            //Parte 1 - Crie um menu para que o valiador possa escolher 
            //entre executar a parte 2 ou a parte 3 do exercicio apertando os numeros 2 e 3 no console
    private void Form1_Load(object sender, EventArgs e)
{
    ContextMenuStrip menu = new ContextMenuStrip();
    menu.Items.Add("ExercicioParte2");
    menu.Items.Add("ExercicioParte3");
    this.ContextMenuStrip = menu;
    menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
       
}
            void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
{
    string comando = string.Empty;
    switch (e.ClickedItem.Text)
    {
        case "2":
            comando = "ExercicioParte2.exe";
            break;
        case "3":
            comando = "ExercicioParte3.exe";
            break;
    }
    if (!comando.Equals(""))
        System.Diagnostics.Process.Start(comando);
}

            
            ExercicioParte2();

            ExercicioParte3();
        }

        private static void ExercicioParte2()
        {
            //1 - ordene os numeros de maneira decrescente e mostre no console o resultado.
            var numeros = new List<int> { 18, 92, 43, 11, 90, 56, 87, 78, 11, 18, 56};
            int[] Newnumeros = numeros.OrderByDescending(i => i).ToArray();
            //2 - Com a lista ordenada remova os números repetidos e mostre no console o resultado.
            var numeroSemDuplicidade = lista.Distinct();
		
		foreach(var n in numeroSemDuplicidade)
		{		
			Console.WriteLine(n);
		}
        }

        private static void ExercicioParte3()
            
            //Esse exercicício eu não consegui fazer, pois não tenho tanta experiencia em C#, nem achei nada na internet nem em ingles, pt, ou pt pt
        {
            //1 - Extraia o texto do arquivo 'Texto Ipsum.txt' e atribua-o a variável texto
            //Coloque aqui o caminho do arquivo Ipsum
            protected void FillForm(object sender, EventArgs e)
{
    string inputString;
    textBoxContents.Text = "";
    using (StreamReader streamReader = File.OpenText("Ipsum.txt")
    {
        inputString = streamReader.ReadLine();

        while (inputString != null)
        {
            textBoxContents.Text += inputString + "<br />";
            inputString = streamReader.ReadLine();
        }
    }
}
            string caminhoArquivoIpsum = @"";
            string texto = default;

            //2 - Mostre o texto no console
           Consile.WriteLine("")
           

            //3 - No meio do texto tem o valor {Referencia: 958220}.
            //    Extraia o valor 958220 direto do texto e atribua-o a variavel referencia.
            string referencia = default;
           string default = Default.Text.Substring(0, 6);
           

            //Salve o texto da variável relatório em um novo arquivo de texto na pasta documentos do windows
            // O nome do arquivo de texto será: relatorio_referencia_958220.txt
            //Dica: use a variavel caminhoPastaDocumento para criar o caminho de salvamento do arquivo
           
           
            var relatorioService = new RelatorioService();
            var relatorio = relatorioService.GetTexto(referencia);
            var caminhoPastaDocumento = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
