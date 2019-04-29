using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace CentralDePasajes.RepositorioDeObjetos 
{
    public class PantallaSeleccionDeServicios : Setup
    {
        public static By Cabecera => By.Id("lblCabecera");

        public static By TablaDeResultados => By.XPath("//*[@id='mobile']/div[2]");

    }
}
