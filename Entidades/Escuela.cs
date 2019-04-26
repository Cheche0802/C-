namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        public string Nombre {
            get {return nombre;}
            set {nombre = value.ToUpper();}
        }

        public int AñodeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

//contructor clasico
       /*  public Escuela(string nombre, int año)
        {
            this.nombre =nombre

            AñodeCreacion = año 
        }*/
        //contructor de igualacion por duplas
        public Escuela (string nombre, int año)=> 
        (Nombre, AñodeCreacion) = (nombre, año);


        public Escuela (string nombre, int año, TiposEscuela tipo, 
        string pais= "", string ciudad= "" )
        {
            (Nombre, AñodeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad =ciudad;
        }


         public override string ToString()
         {
             return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad: {Ciudad} ";
         }
   
    }
}