﻿using AppMontadora.Componentes;

namespace AppMontadora.Produtos
{
    class Veiculo
    {
        private TipoVeiculo tipoVeiculo;
        private int assentos;
        private Motor motor;
        private Transmissao transmissao;

        public TipoVeiculo TipoVeiculo 
        {
            get => tipoVeiculo;
            set => tipoVeiculo = value;
        }

        public Motor Motor
        {
            get => motor;
            set => motor = value;
        }

        public Transmissao Transmissao
        {
            get => transmissao;
            set => transmissao = value;
            
        }

        public int Assentos 
        {
            get => assentos;
            set => assentos = value;
        }
    }
}
