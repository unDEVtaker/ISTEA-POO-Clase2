
Alumno alumno1 = new Alumno(); //esquema clasico para crear un objeto de la clase.
alumno1.Apellido="Alonso";
alumno1.Nombre="Laura";

var alumno2 = new Alumno();//VAR = variable autodefinida, entiende o detecta lo que hay del otro lado. 
alumno2.Nombre="Mariana";
alumno2.Apellido="Lopez";

alumno1.Metodo1();
alumno1.Clave="nueva clave";
//Console.WriteLine(alumno1.Metodo2());
Console.WriteLine(alumno1.Clave);

alumno1.DNI=222222;
Console.WriteLine(alumno1.DNI);
class Alumno{
        private string nombre;
        private string claveGuardada;
        private int documento;  
        public string Clave{//intermediario 
            get{return claveGuardada;}
            set{claveGuardada=value;} //lo busca en el program
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI {
            get{return documento;}
            set{documento= value;} 
        }
        public void Metodo1(){
            claveGuardada="esta es una clave";
        }
        public string Metodo2(){
            return claveGuardada;
        }
}