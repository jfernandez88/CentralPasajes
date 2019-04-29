using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralDePasajes.RepositorioDeObjetos;
using OpenQA.Selenium;

namespace CentralDePasajes.Funciones
{
    public  class BusquedaDePasajes : PantallaDeInicio
    {

        public static void IngresarOrigen(string Origen)
        {
            Driver.FindElement(PantallaDeInicio.Origen).Click();
            Driver.FindElement(PantallaDeInicio.InputOrigen).SendKeys(Origen);
            Driver.FindElement(PantallaDeInicio.InputOrigen).SendKeys(Keys.Enter);

        }

        public static void IngresarDestino(string Destino)
        {
            Driver.FindElement(PantallaDeInicio.InputDestino).SendKeys(Destino);
            Driver.FindElement(PantallaDeInicio.InputOrigen).SendKeys(Keys.Enter);
        }

        public static void IngresarFechaPartida(string fecha)
        {
            Boolean bandera = false;
            Driver.FindElement(PantallaDeInicio.InputFechaPartida).Click();
            List<IWebElement> CalendarioFechaPartida = Driver.FindElement(PantallaDeInicio.TableCalendario).FindElements(By.TagName("td")).ToList();

            foreach (IWebElement Calendario in CalendarioFechaPartida)
            {
                if (fecha.Equals(Calendario.Text))
                {
                    Calendario.Click();
                    bandera = true;
                    break;
                }
            }

            if (!bandera)
            {
                Console.WriteLine("[LOG] LA FECHA INGRESADA NO EXISTE");
            }

        }

        public static void IngresarFechaVuelta(string fecha)
        {
            Boolean bandera = false;
            Driver.FindElement(PantallaDeInicio.InputFechaVuelta).Click();
            List<IWebElement> CalendarioFechaPartida = Driver.FindElement(PantallaDeInicio.CalendarioRegreso).FindElements(By.TagName("td")).ToList();

            foreach (IWebElement Calendario in CalendarioFechaPartida)
            {
                if (fecha.Equals(Calendario.Text))
                {
                    Calendario.Click();
                    bandera = true;
                    break;
                }
            }

            if (!bandera)
            {
                Console.WriteLine("[LOG] LA FECHA INGRESADA NO EXISTE");
            }

        }

        public static void PresionarBotonBuscar()
        {
            Driver.FindElement(PantallaDeInicio.BotonBuscar).Click();
        }

        public static void PresionarRadioSoloIda()
        {
            Driver.FindElement(PantallaDeInicio.RadioSoloIda).Click();
        }

        public static void PresionarRadioIdaVuelta()
        {
            Driver.FindElement(PantallaDeInicio.RadioIdaYVuelta).Click();
        }



    }
}
