using System;
namespace DIO.Series

{
    public class Serie : EntidadeBase
    {
        // Atibutos
        private Genre Genre {get; set;}
        private string Title {get; set;}
        private string Description {get; set;}
        private int Age {get; set;}

        private bool delete {get; set;}

        // Construtor
        public Serie (int id, Genre genre, string title, string description, int age)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Age = age;
            this.delete = false;
        }

        // Metódos
        public string returnTitle()
        {
            return this.Title;
        }

        public int returnId()
        {
            return this.Id;
        }

        public bool returnDelete()
        {
            return this.delete;
        }

        public void deleteAt()
        {
            this.delete = true;
        }

        // toString
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genre: " + this.Genre + "\n";
            retorno += "Title: " + this.Title + "\n";
            retorno += "Description: " + this.Description + "\n";
            retorno += "Age: " + this.Age;
            return retorno;
        }
    }
}