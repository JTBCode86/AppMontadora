using AppMontadora.Componentes;
using AppMontadora.Produtos;

namespace AppMontadora.Builders
{
    class VeiculoBuilder : IBuilder
    {
        Veiculo veiculo = new Veiculo();

        public Veiculo GetVeiculo()
        {
            Veiculo result = veiculo;
            Reset();
            return result;
        }

        public void Reset()
        {
            veiculo = new Veiculo();
        }

        public void SetAssentos(int numeroAssentos)
        {
            veiculo.Assentos = numeroAssentos;
        }

        public void SetMotor(Motor motor)
        {
            veiculo.Motor = motor;
        }

        public void SetTipoVeiculo(TipoVeiculo tipoVeiculo)
        {
            veiculo.TipoVeiculo = tipoVeiculo;
            
        }

        public void SetTransmissao(Transmissao transmissao)
        {
            veiculo.Transmissao = transmissao;
        }
    }
}
