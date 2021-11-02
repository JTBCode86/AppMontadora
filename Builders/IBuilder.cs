using AppMontadora.Componentes;
using AppMontadora.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMontadora.Builders
{
    interface IBuilder
    {
        void Reset();
        Veiculo GetVeiculo();

        void SetAssentos(int numeroAssentos);

        void SetMotor(Motor motor);

        void SetTransmissao(Transmissao transmissao);

        void SetTipoVeiculo(TipoVeiculo tipoVeiculo);

    }
}
