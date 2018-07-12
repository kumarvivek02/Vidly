namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMovieDBWithMovies1 : DbMigration
    {
        public override void Up()
        {
           // Sql("SET IDENTITY_INSERT Movies ON INSERT INTO Movies (Id, Name ,ReleaseDate, DateAdded, NumberInStock,GenreId) VALUES (1, 'The Hangover','2009/06/02','2010/01/03',5,5)");
            Sql("SET IDENTITY_INSERT Movies ON INSERT INTO Movies (Id, Name ,ReleaseDate, DateAdded, NumberInStock,GenreId) VALUES (2, 'Die Hard','1988/06/15','2010/02/03',3,1)");
            Sql("SET IDENTITY_INSERT Movies ON INSERT INTO Movies (Id, Name ,ReleaseDate, DateAdded, NumberInStock,GenreId) VALUES (3, 'The Terminator','1984/10/26','2010/02/03',8,1)");
            Sql("SET IDENTITY_INSERT Movies ON INSERT INTO Movies (Id, Name ,ReleaseDate, DateAdded, NumberInStock,GenreId) VALUES (4, 'Toy Story','1995/11/22','2010/02/03',4,3)");
            Sql("SET IDENTITY_INSERT Movies ON INSERT INTO Movies (Id, Name ,ReleaseDate, DateAdded, NumberInStock,GenreId) VALUES (5, 'Titanic','1997/12/19','2010/02/03',10,4)");

        }

        public override void Down()
        {
        }
    }
}
