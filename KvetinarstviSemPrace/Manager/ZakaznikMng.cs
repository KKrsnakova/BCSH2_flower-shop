using KvetinarstviSemPrace.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace.Manager
{
    public class ZakaznikMng
    {
        public Repo2<Zakaznik> ZakazniciRepo { get; set; }
        public ZakaznikMng(Repo zakazniciRepo)
        {
            ZakazniciRepo = new Repo2<Zakaznik>();
            ZakazniciRepo.Collection = zakazniciRepo.GetInstance().GetCollection<Zakaznik>("Zakaznik");
        }

        public Zakaznik GetByIdZakaznik(int id)
        {
            return ZakazniciRepo.GetById(id);
        }

        public ObservableCollection<Zakaznik> GetAllZakaznik()
        {
            return ZakazniciRepo.GetAll();
        }

        public void AddAllZakaznik(ObservableCollection<Zakaznik> list)
        {
            ZakazniciRepo.AddAll(list);
        }

        public void RemoveAllZakaznik()
        {
            ZakazniciRepo.RemoveAll();
        }

    }

}
