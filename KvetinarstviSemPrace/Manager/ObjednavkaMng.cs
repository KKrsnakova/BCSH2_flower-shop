using KvetinarstviSemPrace.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvetinarstviSemPrace.Manager
{
    public class ObjednavkaMng
    {

        public Repo2<Objednavka> ObjednavkaRepo { get; set; }
        public ObjednavkaMng(Repo objednavkaRepo)
        {
            ObjednavkaRepo = new Repo2<Objednavka>();
            ObjednavkaRepo.Collection = objednavkaRepo.GetInstance().GetCollection<Objednavka>("Objednavka");
        }

        public Objednavka GetByIdObjednavka(int id)
        {
            return ObjednavkaRepo.GetById(id);
        }

        public ObservableCollection<Objednavka> GetAllObjednavky()
        {
            return ObjednavkaRepo.GetAll();
        }

        public void AddAllObjednavka(ObservableCollection<Objednavka> list)
        {
            ObjednavkaRepo.AddAll(list);
        }

        public void RemoveAllObjednavka()
        {
            ObjednavkaRepo.RemoveAll();
        }

    }
}
