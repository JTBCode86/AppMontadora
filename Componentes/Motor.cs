namespace AppMontadora.Componentes
{
    public class Motor
    {
        private int power;

        public Motor(int power) 
        {
            this.Power = power;
        }

        private int Power
        {
            get => power;
            set => power = value;
        }

    }
}
