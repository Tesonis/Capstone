using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowList.Models
{
    /// <summary>
    /// Generic Repository interface to be used by Entities 
    /// </summary>
    /// <typeparam name="T">T</typeparam>
    /// <typeparam name="TPk">TPK</typeparam>
    public interface IRepository<T, in TPk> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(TPk id);
        void InsertObj(T obj);
        void DeleteObj(TPk id);
        void UpdateObj(T obj);
        void Save();
    }   
    public interface IJoinTableRepository<T, in TPk1, in TPk2> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(TPk1 id, TPk2 id2);
        void InsertObj(T obj);
        void DeleteObj(TPk1 id, TPk2 id2);
        void UpdateObj(T obj);
        void Save();
    }
}
