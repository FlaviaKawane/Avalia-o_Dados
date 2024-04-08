using Microsoft.Extensions.Options;

namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {

        int valor = 0;
        public MainPage()
        {

            InitializeComponent();
        }

        private void RollBtn_Clicked(object sender, EventArgs e)
        {
            //Pegar o valor que foi selecionado pelo usuario no picker
            valor = Convert.ToInt32( SidesPicker.SelectedItem);
            //Jogar esse valor em uma variavel
            //Sortear um número em um dado utilizando o Random
            //Colocar o valor sorteado em uma variavel // OBS: Classe é um modelo/ideia e objeto é uma coisa
            var umvalor = 0;
            umvalor = new Random().Next(1, 10);  //ou Random.Shared.Next
            ResultLabel.Text = umvalor.ToString();
            //Exibir o valor para o usúario na  ResultLabel


        }
    }

}
