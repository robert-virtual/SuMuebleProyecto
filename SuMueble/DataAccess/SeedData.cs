using SuMueble.Helpers;
using SuMueble.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuMueble.DataAccess
{
    public class SeedData
    {

        public static bool CheckDefaultColaborador() 
        {
            using (var context = new SuMuebleDBContext())
            {
               var defaultDni = "0703200101235";
                var defaultColaborador = new Colaborador()
                {
                    DNI = defaultDni,
                    Clave = Credentials.Encrypt("admin678"),
                    Nombre = "Administrador",
                    Puesto = new Puesto() { Nombre = "Gerente" }
                };
                var colaboradorExist = context.Colaboradores.Find(defaultDni);
                if (colaboradorExist == null)
                {
                    context.Colaboradores.Add(defaultColaborador);
                    IList<Puesto> defaultPuestos = new List<Puesto>()
                    {
                        new Puesto() { Nombre = "Ventas"}, // 2 
                        new Puesto() { Nombre = "Bodega"}, // 3
                        new Puesto() { Nombre = "Secretaria"}, // 4

                    };

                    context.Puestos.AddRange(defaultPuestos);
                    return context.SaveChanges() > 0;
                }
                return true;


            }
        }

        private void others()
        {

            using (var context = new SuMuebleDBContext())
            {
                IList<TipoVenta> defaultTiposVenta = new List<TipoVenta>()
                {
                    new TipoVenta() { Nombre = "Al Contado"},
                    new TipoVenta() { Nombre = "Al Credito"}

                };
                context.TiposVenta.AddRange(defaultTiposVenta);

                IList<Categoria> defaultCategorias = new List<Categoria>()
                {
                    new Categoria() { Nombre = "Muebles"},
                    new Categoria() { Nombre = "Electro domesticos"},
                    new Categoria() { Nombre = "Motocicletas"}

                };
                context.Categorias.AddRange(defaultCategorias);




                var defaultColaborador = new Colaborador()
                {
                    DNI = "0703200101235",
                    Clave = Credentials.Encrypt("admin678"),
                    Nombre = "Administrador",
                    Puesto = new Puesto() { Nombre = "Gerente" }
                };
                context.Colaboradores.Add(defaultColaborador);

                IList<Puesto> defaultPuestos = new List<Puesto>()
                {
                    new Puesto() { Nombre = "Ventas"}, // 2 
                    new Puesto() { Nombre = "Bodega"}, // 3
                    new Puesto() { Nombre = "Secretaria"}, // 4

                };

                context.Puestos.AddRange(defaultPuestos);

            }
        }

    }
}
