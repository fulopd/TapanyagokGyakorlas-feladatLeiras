using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapanyagokGyakorlas.Models;

namespace TapanyagokGyakorlas.Repositoris
{
    public class TapanyagRepository : IDisposable
    {
        TapanyagokDbContext db;
        int _totalItems;

        public TapanyagRepository()
        {
            db = new TapanyagokDbContext();
        }

        public BindingList<tapanyag> GetAllTapanyag(
            int page = 0,
            int itemPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.tapanyag.OrderBy(x => x.id).AsQueryable();

            //Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search.Replace('.', ',').ToLower();

                decimal szamertek;
                decimal.TryParse(search, out szamertek);

                if (szamertek > 0)
                {
                    query = query.Where(x =>
                        x.energia == szamertek ||
                        x.feherje == szamertek ||
                        x.szenhidrat == szamertek ||
                        x.zsir == szamertek);
                }
                else
                {
                    query = query.Where(x => x.nev.Contains(search));
                }
            }

            //Sorba rendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.id) : query.OrderByDescending(x => x.id);
                        break;
                    case "nev":
                        query = ascending ? query.OrderBy(x => x.nev) : query.OrderByDescending(x => x.nev);
                        break;
                    case "energia":
                        query = ascending ? query.OrderBy(x => x.energia) : query.OrderByDescending(x => x.energia);
                        break;
                    case "feherje":
                        query = ascending ? query.OrderBy(x => x.feherje) : query.OrderByDescending(x => x.feherje);
                        break;
                    case "zsir":
                        query = ascending ? query.OrderBy(x => x.zsir) : query.OrderByDescending(x => x.zsir);
                        break;
                    case "szenhidrat":
                        query = ascending ? query.OrderBy(x => x.szenhidrat) : query.OrderByDescending(x => x.szenhidrat);
                        break;
                }
            }


            //Összes találat kiszámítása
            _totalItems = query.Count();

            //Oldaltördelés
            if ((page + itemPerPage) > 0)
            {
                query = query.Skip((page - 1) * itemPerPage).Take(itemPerPage);
            }

            return new BindingList<tapanyag>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public tapanyag GetTapanyag(int id)
        {
            return db.tapanyag.Find(id);
        }

        public void Inser(tapanyag param)
        {
            db.tapanyag.Add(param);
        }

        public void Update(tapanyag param)
        {
            var tapEredeti = db.tapanyag.Find(param.id);
            if (tapEredeti != null)
            {
                db.Entry(tapEredeti).CurrentValues.SetValues(param);
            }
        }

        public void Delete(int id)
        {
            var tapEredeti = db.tapanyag.Find(id);
            if (tapEredeti != null)
            {
                db.tapanyag.Remove(tapEredeti);
            }
        }

        public bool Exist(tapanyag param)
        {
            return db.tapanyag.Any(x => x.id.Equals(param.id));
        }

        public void Save()
        {
            db.SaveChanges();
        }

        #region IDisposable Support
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
                
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


    }
}
