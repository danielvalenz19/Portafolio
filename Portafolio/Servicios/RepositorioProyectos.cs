using Portafolio.Models;

namespace Portafolio.Servicios
{

	public interface IRepositorioProyectos
	{
		List<ProyectoDTO> ObtenerProyectos();
	}
	public class RepositorioProyectos : IRepositorioProyectos
	{

		public List<ProyectoDTO> ObtenerProyectos()
		{
			return new List<ProyectoDTO> {
				new ProyectoDTO
			{
				Titulo="To Do",
				Descripcion="Pequeña herramienta de lista de tareas",
				Link="https://github.com/danielvalenz19/To-Do-asp.net",
				ImagenURL="/imagenes/TODO.png"

			},
				new ProyectoDTO
			{
				Titulo="Manejo de presupuesto",
				Descripcion="Aplicacion donde pueden consultar sus finanzas",
				Link="https://github.com/danielvalenz19/Manejador-de-presupuestos",
				ImagenURL="/imagenes/ManejoPre.png"

			},
				new ProyectoDTO
			{
				Titulo="Manejador de nominas",
				Descripcion="Aplicacion para empresas para poder administrar las nominas pagos etc",
				Link="https://github.com/danielvalenz19/TConsultingSA",
				ImagenURL="/imagenes/presupuesto.png"

			},
				new ProyectoDTO
			{
				Titulo="Todo Js",
				Descripcion="Aplicacion sobre lista de tarea hecho en Javascript",
				Link="https://github.com/danielvalenz19/To-Do",
				ImagenURL="/imagenes/todoJs.png"

			},
					new ProyectoDTO
			{
				Titulo="Ecommerce",
				Descripcion="Trabajo universitario, tienda enlinea",
				Link="https://github.com/esdrasspd/ProyectoDB2",
				ImagenURL=""

			},


			};
		}

	}
}
