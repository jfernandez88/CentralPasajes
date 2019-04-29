using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralDePasajes.RepositorioDeObjetos;
using OpenQA.Selenium;


namespace CentralDePasajes.Funciones
{
    public class SeleccionDeServicios : Setup
    {
        /// <summary>
        /// Buscar elemento en tabla de resultados
        /// </summary>
        /// <param name="TagName"></param>
        /// <param name="ElementoBuscado"></param>
        public static void BuscarElementoEnResultados(string ClassName)
        {
            List<IWebElement> Campos = Driver.FindElement(PantallaSeleccionDeServicios.TablaDeResultados).FindElements(By.ClassName(ClassName)).ToList();

            foreach (IWebElement c in Campos)
            {
                Console.WriteLine(c.GetAttribute("id"));

            }
        }

    }
}
