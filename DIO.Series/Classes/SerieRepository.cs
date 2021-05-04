using System;
using System.Collections.Generic;
using DIO.Series.Enum;

namespace DIO.Series
{
    public class SerieRepository : IRepository<Serie>
    {
    private List<Serie> listSerie = new List<Serie>();
     public void update(int id, Serie entity)
     {
       try 
       {
           if(id >= 0 && entity != null){
            listSerie[id] = entity;
        }
       } catch(ArgumentException e)
       {
          Console.WriteLine(e);
       }
     }   

     public void delete(int id)
     {
        try {
           listSerie[id].deleteAt();
        } catch(ArgumentException e)
        {
           Console.WriteLine(e);
        }
     }

     public void add(Serie entity)
     {
        try {
           if(entity != null)
           {
              listSerie.Add(entity);
           } 
        } catch(ArgumentException e)
        {
           Console.WriteLine(e);
        }
     }

     public List<Serie> Lista()
     {   
        return listSerie;
     }

    public int nextId()
    {
        return listSerie.Count;
    }

    public Serie ReturnForId(int id)
    {
       if(id >= 0)
       {
        return listSerie[id];
       }

      throw new ArgumentException("Id não é válido.");
    }
    }
}