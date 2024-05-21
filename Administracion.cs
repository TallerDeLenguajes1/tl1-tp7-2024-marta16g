namespace EspacioAdministracion
{

    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    class Empleado
    {
        public string nombre;
        public string apellido;
        public DateTime fechaDeNacimiento = new DateTime();
        public char estadoCivil;
        public DateTime fechaDeIngreso = new DateTime();
        public double sueldo;
    }
}