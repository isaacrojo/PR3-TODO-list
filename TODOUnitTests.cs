using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace Tested_ToDoList
{
    [TestFixture]
    /// <summary>
    /// Clase exclusiva para realizar pruebas de funcionalidades de la TODOList
    /// </summary>
    class TODOUnitTests
    {
        /// <summary>
        /// Prueba 1 Agregar un TODO a la lista
        /// </summary>
        [Test]
        [TestCase(TestName = "Agregar un TODO a lista")]

        public void AddUndoneTODOTest()
        {
            TODOList testList = new TODOList();
            TODO testTODO = new TODO("Hacer tarea", false);
            testList.AddUndoneTODO(testTODO);
            //Assert.That(testList, Is.All.Not.Null);
            Assert.That(testList.Check(), Is.EqualTo("ToDo agregado"));
            
            TODOList testList2 = new TODOList();
            TODO testTODO2 = new TODO("Hacer tarea", true);
            testList2.AddUndoneTODO(testTODO2);
            Assert.That(testList2.Check(), Is.EqualTo("⚠ ToDo hecho agregado"));

        }


        /// <summary>
        /// Prueba 2: Mostrar todos los TODOS de la lista
        /// </summary>
        [Test]
        [TestCase(TestName = "Mostrar todos los TODOS")]
        public void ShowAllTODOsTest()
        {
            TODOList testShowAll = new TODOList();
            testShowAll.ShowAllTODOs();
            Assert.That(testShowAll.Check(), Is.Empty);

            TODOList testShowAll2 = new TODOList();
            TODO testTODO1 = new TODO("hola", false);
            TODO testTODO2 = new TODO("mundo", false);
            testShowAll2.AddUndoneTODO(testTODO1);
            testShowAll2.AddUndoneTODO(testTODO2);
            testShowAll2.ShowAllTODOs();
            Assert.That(testShowAll2.Check(), Is.EqualTo("hola")); //solo imprime el primero (??)

        }

        /// <summary>
        /// Prueba 3: Mostrar TODOs pendientes
        /// </summary>
        [Test]
        [TestCase(TestName = "Mostrar TODOs pendientes")]
        public void PendingTODOsTest()
        {
            TODOList pendingList = new TODOList();
            TODO testTODO = new TODO("Salvar el semestre", false);
            //TODO testTODO2 = new TODO("Hacer tarea2", false);
            pendingList.AddUndoneTODO(testTODO);
            //pendingList.AddUndoneTODO(testTODO2);
            pendingList.PendingTODOs();
            Assert.That(pendingList.Check(), Is.EqualTo("ToDo pendiente: Salvar el semestre"));

            TODOList pendingList2 = new TODOList();
            TODO testTODO1 = new TODO("Hacer tarea", false);
            TODO testTODO2 = new TODO("Hacer tarea2", false);
            pendingList2.AddUndoneTODO(testTODO1);
            pendingList2.AddUndoneTODO(testTODO2);
            pendingList2.PendingTODOs();
            Assert.That(pendingList2.Check(), Is.EqualTo("ToDo pendiente: Hacer tarea")); //solo imprime el primero

        }

        
        /// <summary>
        /// Prueba 4: Mostrar TODOs completados
        /// </summary>
        [Test]
        [TestCase(TestName = "Mostrar TODOs hechos")]
        public void DoneTODOsTest()
        {
            TODOList testList = new TODOList();
            TODO testTODO = new TODO("Comer", false);
            //TODO testTODO2 = new TODO("Hacer tarea2", false);
            testList.AddUndoneTODO(testTODO);
            //testList.AddUndoneTODO(testTODO2);
            testList.TODOIsDone(testTODO);
            Assert.That(testList.Check(), Is.EqualTo("ToDo completado"));
            testList.DoneTODOs();
            Assert.That(testList.Check(), Is.EqualTo("ToDo hecho:  Comer."));
            // Assert.That(testList.Check(), Contains.Item(true));

        }

        /// <summary>
        /// Prueba 5: Borrar un TODO terminado de la lista
        /// </summary>
        [Test]
        [TestCase(TestName = "Borrar un TODO terminado")]
        public void DeleteDoneTODOTest()
        {
            TODOList testList = new TODOList();
            TODO testTODO = new TODO("Hacer comida", false);
            testList.AddUndoneTODO(testTODO);
            testList.TODOIsDone(testTODO);
            testList.DeleteDoneTODO();
            Assert.That(testList.Check(), Is.EqualTo("ToDo removido"));


        }


    }
}
