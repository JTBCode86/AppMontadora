using AppMontadora.Builders;
using AppMontadora.Componentes;

namespace AppMontadora.Diretores
{
    class Diretor
    {
        IBuilder Builder;

        public Diretor(IBuilder builder)
        {
            this.Builder = builder;
        }

        public void ContruirVeiculoSedan() 
        {
            Builder.SetTipoVeiculo(TipoVeiculo.Sedan);
            Builder.SetMotor(new Motor(200));
            Builder.SetAssentos(5);
            Builder.SetTransmissao(Transmissao.Automatico);
        }

        public void ContruirVeiculoTruck()
        {
            Builder.SetTipoVeiculo(TipoVeiculo.Truck);
            Builder.SetMotor(new Motor(4000));
            Builder.SetAssentos(2);
            Builder.SetTransmissao(Transmissao.Manual);
        }

        public void ContruirVeiculoPickupTruck()
        {
            Builder.SetTipoVeiculo(TipoVeiculo.PickupTruck);
            Builder.SetMotor(new Motor(5000));
            Builder.SetAssentos(4);
            Builder.SetTransmissao(Transmissao.Sequencial_automatico);
        }
    }
}
