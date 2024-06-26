using CommunityToolkit.Mvvm.ComponentModel;
using PreAvaliacao.Models;

namespace PreAvaliacao.ViewModels;

public class JokenpoViewModel : ContentPage
{

    [ObservableProperty]
    private string result;

    [ObservableProperty]
    private string Escolha;

    [ObservableProperty]
    private int pontuacaoJogador;

    [ObservableProperty]
    private int pontuacaoComputador;

    public void Joagr()
    {
        Jogador1 jogador = new Jogador1();
        Jogador1 pc = new Jogador1();
        jogador.Jogar();

        if (Escolha == "pedra" && jogador.Sorteio == "tesoura" || Escolha == "papel" && jogador.Sorteio == "pedra" || Escolha == "tesoura" && jogador.Sorteio == "papel")
        {
            result = "Voc� ganhou";
            jogador.Pontos++;
        }
        else
        {
            result = "Voc� perdeu";
            pc.Pontos++;
        }
    }
}