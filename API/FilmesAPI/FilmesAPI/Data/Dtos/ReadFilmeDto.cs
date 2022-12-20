using FilmesAPI.Models;
using System;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto: Filme
    {
        public DateTime HoraDaConsulta { get; set; }
    }
}
