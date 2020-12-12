using System;
using System.Collections.Generic;


namespace Tested_ToDoList
{
    /// <summary>
    /// Clase para objeto TODO, contiene descripcion y un booleano (que marca tarea como pendiente/terminada) como atributos
    /// </summary>
    public class TODO  
    {
        public string description { get; set; }
        public bool done { get; set; }

        /// <summary>
        /// Método constructor de TODO's
        /// </summary>
        /// <param name="description"></param>
        /// <param name="done"></param>
        public TODO(string description, bool done) {
            this.description = description;
            this.done = done;
        }


        /// <summary>
        /// Método que sobreescribe metodo ToString 
        /// </summary>
        /// <returns>description de objeto como string</returns>
        public override string ToString()
        {
              return $" {this.description}."; 
        }

        /// <summary>
        /// Método que toma el estado de la variable booleana done  
        /// </summary>
        /// <returns>variable bool done </returns>
        public bool TODOState() {
            return done;
        }
    }

    
}
