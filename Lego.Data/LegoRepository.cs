using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegoManager.Models;
using LegoManager.View;

namespace LegoManager.Data
{
    public class LegoRepository
    {
        Lego[] legos;

        public LegoRepository()
        {
            legos = new Lego[20];

            Lego set1 = new Lego();
            set1.LegoID = 0;
            set1.SetName = "UCS Millenium Falcon";
            set1.ReleaseYear = 2019;
            set1.CurrentValue = 800;
            set1.NumberOfPieces = 7541;
            set1.NumberOfSetsOwned = 1;

            legos[0] = set1;

            Lego set2 = new Lego();
            set2.LegoID = 1;
            set2.SetName = "UCS Snow Speeder";
            set2.ReleaseYear = 2017;
            set2.CurrentValue = 554;
            set2.NumberOfSetsOwned = 2;
            set2.NumberOfPieces = 1703;

            legos[1] = set2;

            Lego set3 = new Lego();
            set3.LegoID = 2;
            set3.SetName = "UCS A-Wing";
            set3.ReleaseYear = 2020;
            set3.CurrentValue = 199.95;
            set3.NumberOfPieces = 1672;
            set3.NumberOfSetsOwned = 1;

            legos[2] = set3;
        }

        public Lego CreateLego(Lego lego)
        {
            //Find first open spot in lego list
            for (int i = 0; i < legos.Length; i++)
            {
                if (legos[i] == null)
                {
                    lego.LegoID = i;
                    legos[i] = lego;
                    return lego;
                }
            }
            //the array was full. Lego wasn't added
            return null;
        }

        public Lego[] RetrieveAllLegos()
        {
            return legos;
        }

        public Lego RetrieveLegoById(int legoID)
        {
            if (legos[legoID] != null)
            {
                return legos[legoID];
            }
            else
            {
                return null;
            } 
        }

        public void DeleteLego(int LegoID)
        {
            if(legos[LegoID] != null)
            {
                legos[LegoID] = null;
            }
            else
            {
                legos[LegoID] = null;
            }
        }

        public Lego EditLego(Lego lego)
        {
            DeleteLego(lego.LegoID);
            Lego updatedLego = CreateLego(lego);
            return updatedLego;
              
        }

        public bool VerifySpace()
        {
            for (int i = 0; i < legos.Length; i++)
            {
                if(legos[i] == null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
