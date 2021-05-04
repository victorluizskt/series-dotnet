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
        listSerie[id] = entity;
     }   

     public void delete(int id)
     {
        listSerie.RemoveAt(id);
     }

     public void add(Serie entity)
     {
        throw new NotImplementedException();
     }

     public List<Serie> Lista()
     {
        throw new NotImplementedException();
     }

    public int nextId()
    {
        throw new NotImplementedException();
    }

    public Serie ReturnForId(int id)
    {
        throw new NotImplementedException();
    }

    }
}