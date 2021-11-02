using AppMontadora.Builders;
using AppMontadora.Diretores;
using AppMontadora.Componentes;
using AppMontadora.Produtos;
using System;

namespace AppMontadora
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder Builder = new VeiculoBuilder();
            Diretor diretor = new Diretor(Builder);

            diretor.ContruirVeiculoSedan();
            Veiculo sedan = Builder.GetVeiculo();

            diretor.ContruirVeiculoTruck();
            Veiculo Truck = Builder.GetVeiculo();

            diretor.ContruirVeiculoPickupTruck();
            Veiculo PickupTruck = Builder.GetVeiculo();

            Console.WriteLine($"Criado um veículo do tipo: {sedan.TipoVeiculo}");
            Console.WriteLine($"Criado um veículo do tipo: {Truck.TipoVeiculo}");
            Console.WriteLine($"Criado um veículo do tipo: {PickupTruck.TipoVeiculo}");

            Console.ReadLine();
        }
    }
}
