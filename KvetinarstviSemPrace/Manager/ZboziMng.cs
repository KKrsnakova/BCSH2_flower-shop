using KvetinarstviSemPrace.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace.Manager
{
    public class ZboziMng
    {
        public Repo2<Zbozi> ZboziRepo { get; set; }

        public ZboziMng(Repo zboziRepo)
        {
            ZboziRepo = new Repo2<Zbozi>();
            ZboziRepo.Collection = zboziRepo.GetInstance().GetCollection<Zbozi>("Zbozi");
        }

        public Zbozi GetByIdZbozi(int id)
        {
            return ZboziRepo.GetById(id);
        }

        public ObservableCollection<Zbozi> GetAllZbozi()
        {
            return ZboziRepo.GetAll();
        }

        public void AddAllZbozi(ObservableCollection<Zbozi> list)
        {
            ZboziRepo.AddAll(list);
        }

        public void RemoveAllZbozi()
        {
            ZboziRepo.RemoveAll();
        }

    }
}
