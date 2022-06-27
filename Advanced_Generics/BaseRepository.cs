using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced_Generics
{
    public class BaseRepository<T> where T : Entity, new() //cia parasom kad T paveldi is entity klases
    {
        private List<T> Items { get; set; }
        public BaseRepository()
        {
            Items = new List<T>();
        }
        public BaseRepository(List<T> items)
        {
            Items = items;
        }

        public T Get(int id)
        {

            return Items.Single(x => x.Id == id);
        }
        public List<T> Get()
        {
            return Items;
        }

    }
    public class BaseRepositoryStruct<T> where T : struct
    { 
    private List<T> Items { get; set; }
    }
    
}
