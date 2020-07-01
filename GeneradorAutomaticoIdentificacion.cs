using System;

namespace comprandoEnAki
{
    public class GeneradorAutomaticoIdentificacion
    {
        readonly Random random = new Random();

        public int Id { get; set; }

        public GeneradorAutomaticoIdentificacion()
        {
            Id = random.Next();
        }

    }
}
