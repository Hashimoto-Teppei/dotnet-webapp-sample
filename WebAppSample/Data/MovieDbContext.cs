using System;
using Microsoft.EntityFrameworkCore;
using WebAppSample.Models;

namespace WebAppSample.Data
{
	public class MovieDbContext: DbContext
	{
		public MovieDbContext(DbContextOptions<MovieDbContext> options): base(options)
		{
		}

		public DbSet<Movie> Movie => Set<Movie>();
	}
}

