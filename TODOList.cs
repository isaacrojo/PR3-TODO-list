using System;
using System.Collections.Generic;

namespace Tested_ToDoList
{
    /// <summary>
    /// Clase principal contiene las funcionalidades de la TODOList
    /// </summary>
    public class TODOList  
    {
        
        List<TODO> theTODOList = new List<TODO>();
      
        //List<TODO> unDoneTODOs = new List<TODO>();


        /// <summary>
        /// Variable inicialmente vacía que se irá sobreescribiendo conforme a cada método
        /// </summary>
        string check = "";
       
       /// <summary>
       /// Método creado para ir haciendo checks en las pruebas 
       /// </summary>
       /// <returns>variable check</returns>
       public string Check() {
            return this.check;
        }

        /// <summary>
        /// Agregar objeto TODO pendiente a la lista
        /// </summary>
        /// <param name="done"></param>
        public void AddUndoneTODO(TODO done)
        {
            if (done.TODOState() == false)
            {
                this.theTODOList.Add(done);
                this.check = "ToDo agregado";
            } else {
                this.check = "⚠ ToDo hecho agregado";
            }
            
        } 
        
        /// <summary>
        /// Consultar todos los TODOs 
        /// </summary>
        /// <returns>descripción del TODO como string</returns>
         public string ShowAllTODOs() {
             foreach (TODO todo in theTODOList)
             {   
                     return this.check = todo.description.ToString(); 
             }
             //para que todas las rutas de acceso devuelvan valor
             return null;
         }

        /// <summary>
        /// Marcar TODO como terminado
        /// </summary>
        /// <param name="description"></param>
         public void TODOIsDone(TODO description) {
            
            if(this.theTODOList.Contains(description))
            {
                this.theTODOList.Remove(description);
                TODO doneTODO = new TODO(description.ToString(), true);
                this.theTODOList.Add(doneTODO);
            
                this.check = "ToDo completado";
            }
            else
            { 
                this.check = "Error";
            }
         }

        
         /// <summary>
         /// Consultar TODOs pendientes
         /// </summary>
         /// <returns>"ToDo pendiente: {todo.description}"</returns>
         public string PendingTODOs() {
             foreach (TODO todo in theTODOList)
             {
                 if (todo.done == false)
                 {
                     return this.check = $"ToDo pendiente: {todo.description}";
                 }  
             }
             //para que todas las rutas de acceso devuelvan valor
             return null;
         }

         /// <summary>
         /// Consultar TODOs terminados
         /// </summary>
         /// <returns>"ToDo hecho: {todo.description}"</returns>
         public string DoneTODOs() {
             foreach (TODO todo in theTODOList)
             {
                 if (todo.done == true)
                 {
                     return this.check = $"ToDo hecho: {todo.description}";
                 }  
             }
             //para que todas las rutas de acceso devuelvan valor
             return null;
         }

         /// <summary>
         /// Borrar un TODO ya hecho
         /// </summary>
         public void DeleteDoneTODO() {
             for (int t = theTODOList.Count - 1; t >= 0; t--)
            {
                if (theTODOList[t].done == true)
                {
                    theTODOList.Remove(theTODOList[t]);
                    this.check = $"ToDo removido";
                    break;
                }
            }
         }

         /// <summary>
         /// Consultar TODOs pendientes
         /// </summary>
         /// <returns>"ToDo pendiente: {aToDo.description}"</returns>
        public string PendingTODOS()
        {
            foreach (var aToDo in theTODOList)
            {
                if (aToDo.done == false)
                {
                    return this.check = $"ToDo pendiente: {aToDo.description}"; 
                }
            }
            return null;
        } 

    }
}
