using LegoManager.Data;
using LegoManager.View;
using LegoManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoManager.Controllers
{
    public class LegoControllers
    {
        private LegoView legoView;
        private LegoRepository repository;

        public LegoControllers()
        {
            legoView = new LegoView();
            repository = new LegoRepository();
        }

        public void Run()
        {
            bool keeprunning = true;

            while (keeprunning)
            {
                int menuChoice = legoView.ShowMenuAndGetUserChoice();

                switch (menuChoice)
                {
                    case 1:
                        CreateLego();
                        break;
                    case 2:
                        ShowAllLegoSets();
                        break;
                    case 3:
                        SearchLegos();
                        break;
                    case 4:
                        UpdateLegoSet();
                        break;
                    case 5:
                        DeleteLegoSet();
                        break;
                    case 6:
                        keeprunning = false;
                        break;
                }
            }
        }

        private void CreateLego()
        {
            string add = "Add Set";
            if (repository.VerifySpace() == true)
            {
                Lego newLego = legoView.GetNewLego();
                repository.CreateLego(newLego);
                legoView.DisplayLego(newLego);
                legoView.ShowActionSuccess(add);
            }
            else
            {
                legoView.ArrayFull();
            }
        }

        private void ShowAllLegoSets()
        {
            Lego[] retrieved = repository.RetrieveAllLegos();
            for (int i = 0; i < retrieved.Length; i++)
            {
                if (retrieved[i] == null)
                {
                    continue;
                }
                else
                {
                    legoView.DisplayLego(retrieved[i]);
                }  
            }
        }

        private void SearchLegos()
        {
            int legoToSearch = legoView.GetLegoID();

            Lego lego = repository.RetrieveLegoById(legoToSearch);

            if (lego != null)
            {
                legoView.DisplayLego(repository.RetrieveLegoById(legoToSearch));
            }
            else
            {
                legoView.ArrayNull();
                ShowAllLegoSets();
            }
        }

        private void UpdateLegoSet()
        {
            int legoSetToUpdate = legoView.GetLegoID();

            Lego lego = repository.RetrieveLegoById(legoSetToUpdate);

            if(lego != null)
            {
                legoView.DisplayLego(lego);
                Lego updatedLego = legoView.GetNewLego();
                updatedLego.LegoID = legoSetToUpdate;
                repository.EditLego(updatedLego);
            }
            else
            {
                legoView.ArrayNull();
                ShowAllLegoSets();
            }
           
        }

        private void DeleteLegoSet()
        {
            int legoToDelete = legoView.GetLegoID();

            Lego lego = repository.RetrieveLegoById(legoToDelete);

            if(lego != null)
            {
                legoView.DisplayLego(repository.RetrieveLegoById(legoToDelete));
            }
            else
            {
                legoView.ArrayNull();
            }

            if (legoView.ConfirmDelete() == true)
            {
                repository.DeleteLego(legoToDelete);
                legoView.ShowActionSuccess("Remove Lego");
            }
        }
    }
}
