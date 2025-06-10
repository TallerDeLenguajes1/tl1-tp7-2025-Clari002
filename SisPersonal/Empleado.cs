
namespace espacioEmpleado
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private dateTime fechaNacimiento;
        private char estadoCivil;
        private double sueldoBasico;
        private Cargos cargo;

        
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public char EstadoCivil { get; set; } 
            public DateTime FechaIngreso { get; set; }
            public double SueldoBasico { get; set; }
            public Cargos Cargo { get; set; }

            public int Antiguedad => DateTime.Now.Year - FechaIngreso.Year - (DateTime.Now.DayOfYear < FechaIngreso.DayOfYear ? 1 : 0);

            public int Edad => DateTime.Now.Year - FechaNacimiento.Year - (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear ? 1 : 0);

            public int AniosParaJubilarse => Math.Max(65 - Edad, 0);

            public double Salario
            {
                get
                {
                    int antiguedad = Antiguedad;
                    double adicional = 0;

                    if (antiguedad < 20)
                        adicional = SueldoBasico * (antiguedad * 0.01);
                    else
                        adicional = SueldoBasico * 0.25;

                    if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
                        adicional *= 1.5;

                    if (EstadoCivil == 'C')
                        adicional += 150000;

                    return SueldoBasico + adicional;
                }
            }
        


    }
 public enum Cargos
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
}