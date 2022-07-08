using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class AutoNegocio
    {
        public List<Auto> Listar()
        {
            List<Auto> lista = new List<Auto>();
            lista.Add(new Auto());
            lista.Add(new Auto());

            lista[0].Id = 1;
            lista[0].Modelo = "Golf";
            lista[0].Descripcion = "Lindo Auto";
            lista[0].Color = "Blanco";
            lista[0].Fecha = DateTime.Now;
            lista[0].Usado = true;
            lista[0].Importado = true;

            lista[1].Id = 2;
            lista[1].Modelo = "Focus";
            lista[1].Descripcion = "Auto de rally";
            lista[1].Color = "Negro";
            lista[1].Fecha = DateTime.Now;
            lista[1].Usado = false;
            lista[1].Importado = false;
            return lista;
        }
    }
}
