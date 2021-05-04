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
    
        public Serie (int id, Genre genre, string title, string description, int age)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Age = age;
            this.delete = false;
        }

        public string returnTitle()
        {
            return this.Title;
        }

        public int returnId()
        {
            return this.Id;
        }

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