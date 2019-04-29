using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralDePasajes;
using OpenQA.Selenium;


namespace CentralDePasajes.RepositorioDeObjetos 
{ 
    public class PantallaDeInicio : Setup
    {
        public static By Origen => By.XPath(@"id(""select2-PadOrigen-container"")/span[1]");

        public static By InputOrigen => By.XPath(@"/html/body/span[1]/span[1]/span[1]/input[1]");

        public static By InputDestino => By.XPath("/html/body/span/span/span[1]/input");

        public static By InputFechaPartida => By.Id("fechaPartida");

        public static By TableCalendario => By.XPath("//*[@id='cdp-calendar-container']");

        public static By CalendarioRegreso => By.Id("cdp-calendar-container-regreso");

        public static By InputFechaVuelta => By.Id("fechaVuelta");

        public static By RadioSoloIda => By.XPath("//*[@id='parametros_busqueda_servicios_home']/div[5]/label[1]");

        public static By RadioIdaYVuelta => By.XPath("//*[@id='parametros_busqueda_servicios_home']/div[5]/label[2]");

        public static By BotonBuscar => By.Id("btnCons");

        public static By GrillaDeResultados => By.Id("grillaservicios");

    }
}
