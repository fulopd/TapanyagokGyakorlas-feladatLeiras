using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapanyagokGyakorlas.Models;
using TapanyagokGyakorlas.Repositoris;
using TapanyagokGyakorlas.ViewInterfaces;

namespace TapanyagokGyakorlas.Presenters
{
    class TablazatPresenter
    {
        private TapanyagRepository repo;
        private ITablazatView view;

        public TablazatPresenter(ITablazatView param)
        {
            view = param;
            repo = new TapanyagRepository();
        }

        public void LoadData()
        {
            view.BindingList = repo.GetAllTapanyag(
                view.page, view.itemPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(tapanyag param)
        {
            if (view.BindingList.Any(x => x.id == param.id))
            {
                //már létezik
            }
            else
            {
                view.BindingList.Add(param);
                repo.Inser(param);
            }
        }

        public void Modify(int index, tapanyag param)
        {
            view.BindingList[index] = param;
            repo.Update(param);
        }

        public void Remove(int index) 
        {
            var tapa = view.BindingList.ElementAt(index);
            view.BindingList.RemoveAt(index);
            if (tapa.id > 0)
            {
                repo.Delete(tapa.id);
            }
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
