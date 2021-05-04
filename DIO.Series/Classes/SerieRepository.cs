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
        listSerie[id].deleteAt();
     }

     public void add(Serie entity)
     {
        listSerie.Add(entity);
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
        return listSerie[id];
    }

    }
}