﻿using System.Text.Json.Serialization;

namespace KintelaAPI.DTOs
{
	public class RecetaDTO
	{
		public RecetaDTO(int recetaId, string nombre, string[] ingredientes, string[] preparacion, string[] presentacion, string enlaceVideo, string imagen, int? comensales, List<int> categoriaIds)
		{
			RecetaId = recetaId;
			Nombre = nombre;
			Ingredientes = ingredientes;
			Preparacion = preparacion;
			Presentacion = presentacion;
			EnlaceVideo = enlaceVideo;
			Imagen = imagen;
			Comensales = comensales;
			CategoriaIds = categoriaIds;
		}

    public int RecetaId { get; init; }
		public string Nombre { get; init; }
		public string[] Ingredientes { get; init; }
		public string[] Preparacion { get; init; }
		public string[] Presentacion { get; init; }
		public int? Comensales { get; init; }
		public string EnlaceVideo { get; init; }
		public string Imagen { get; init; }
		public List<int> CategoriaIds { get; init; }


	}
}
