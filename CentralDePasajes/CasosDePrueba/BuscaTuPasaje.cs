using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using CentralDePasajes.Funciones;
using CentralDePasajes.RepositorioDeObjetos;
using CsvHelper;

namespace CentralDePasajes.CasosDePrueba
{
    [TestFixture]
    public class TestCases
    {
        [TestCase]
        public void PruebaJenkins()
        {
            Setup.InicializarConChrome(10, 30);
            BusquedaDePasajes.IngresarOrigen("Mendoza");
            BusquedaDePasajes.IngresarDestino("Buenos Aires");

        }

        [TestCase]
        public void Busqueda_SoloIda()
        {
            Setup.InicializarConChrome(10,30);           
            BusquedaDePasajes.IngresarOrigen("Mendoza");
            BusquedaDePasajes.IngresarDestino("Buenos Aires");
            BusquedaDePasajes.IngresarFechaPartida("10");
            Setup.Esperar(10, PantallaDeInicio.BotonBuscar);
            BusquedaDePasajes.PresionarBotonBuscar();

            Setup.Esperar(10, PantallaSeleccionDeServicios.Cabecera);
            Assert.IsTrue(Setup.Driver.FindElement(PantallaSeleccionDeServicios.Cabecera).Text.Contains("Mendoza"),"La busqueda no coincide");     
        }

        [TestCase]
        public void Busqueda_IdaYVuelta()
        {
            Setup.InicializarConChrome(10, 30);
            BusquedaDePasajes.IngresarOrigen("Mendoza");
            BusquedaDePasajes.IngresarDestino("Buenos Aires");
            BusquedaDePasajes.PresionarRadioIdaVuelta();
            BusquedaDePasajes.IngresarFechaPartida("10");
            BusquedaDePasajes.IngresarFechaVuelta("20");
            Setup.Esperar(10, PantallaDeInicio.BotonBuscar);
            BusquedaDePasajes.PresionarBotonBuscar();

            Setup.Esperar(10,PantallaSeleccionDeServicios.Cabecera);
            SeleccionDeServicios.BuscarElementoEnResultados("comprar");
        }

        [TestCase]
        public void MapaJorgito()
        {
            ////*[@id="map"]/div[1]/div[2]/div[3]/div[141]/div/div[2]

            Setup.InicializarConChrome(10, 30, "https://elmapa.com.ar/");

            System.Threading.Thread.Sleep(3000);

            List<IWebElement> Lista = Setup.Driver.FindElements(By.XPath("//*[@id='map']/div[1]/div[2]/div[3]/div/div/div[2]")).ToList();


            Console.WriteLine("Cantidad: "+Lista.Count());

            int i = 0;
            foreach (IWebElement e in Lista)
            {
          
                if (e.GetAttribute("style").Equals("background-color: rgba(255, 29, 0, 0.7);"))
                {
                    Console.WriteLine("Se encontro un rojo");
                    Setup.Driver.FindElement(By.XPath("//*[@id='map']/div[1]/div[2]/div[3]/div["+i+"]/div/div[1]")).Click();
                    break;
                }
                i = i + 1;
            }



        }




        

    }
}
