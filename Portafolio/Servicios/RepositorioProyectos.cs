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
				Titulo=".net Proyectos",
				Descripcion="Desarrollador de C#; desarrolle una parte de C# ",
				Link="https://google.com ",
				ImagenURL="/imagenes/Proyecto1.png"

			},
				new ProyectoDTO
			{
				Titulo="Spotify Page",
				Descripcion="Desarrollador Del front de Spotify ",
				Link="https://google.com ",
				ImagenURL="/imagenes/Proyecto2.png"

			},
				new ProyectoDTO
			{
				Titulo="Desarrollador de meta",
				Descripcion="Desarrolle la marketplace solito ",
				Link="https://google.com ",
				ImagenURL="/imagenes/Proyecto3.png"

			},
				new ProyectoDTO
			{
				Titulo="ASP.NET",
				Descripcion="Desarrolle ASP.NET para microsoft ",
				Link="https://google.com ",
				ImagenURL=""

			},


			};
		}

	}
}
