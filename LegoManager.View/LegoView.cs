using LegoManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoManager.View
{
    public class LegoView
    {
        private UserInputOutput userInputOutput;

        public LegoView()
        {
            userInputOutput = new UserInputOutput();
        }

        public int ShowMenuAndGetUserChoice()
        {
            Console.WriteLine("\nEnter a choice from the list below:");
            Console.WriteLine("1. Add Lego Set");
            Console.WriteLine("2. Show All Lego Sets");
            Console.WriteLine("3. Look Up Lego Set");
            Console.WriteLine("4. Edit Lego Set");
            Console.WriteLine("5. Remove Lego Set");
            Console.WriteLine("6. Exit Program");
            int userChoice = userInputOutput.ReadInt("Enter your choice: \n", 1, 6);

            return userChoice;
        }

        public Lego GetNewLego()
        {
            Lego lego = new Lego();
            int min = 1949;
            int max = 2021;

            lego.SetName = userInputOutput.ReadString("\nEnter the name of the set: ");
            lego.ReleaseYear = userInputOutput.ReadYear("Enter the year the set was released: ", min, max);
            lego.NumberOfPieces = userInputOutput.ReadPieces("Enter the number of pieces in the set: ");
            lego.NumberOfSetsOwned = userInputOutput.ReadSetsOwned("How many sets do you own? ");
            lego.CurrentValue = userInputOutput.ReadDouble("What's the current value of this set? ");

            return lego;
        }

        public void DisplayLego(Lego lego)
        {
            Console.WriteLine("\nLego ID:               {0}", lego.LegoID);
            Console.WriteLine("Set Name:                {0}", lego.SetName);
            Console.WriteLine("Release Year:            {0}", lego.ReleaseYear);
            Console.WriteLine("Number of Pieces:        {0}", lego.NumberOfPieces);
            Console.WriteLine("Current Value:           {0}", lego.CurrentValue);
            Console.WriteLine("Number of sets owned:    {0}", lego.NumberOfSetsOwned);
        }

        public int GetLegoID()
        {
            Console.WriteLine("\nPlease enter the Lego ID of the set you're interested in: ");
            int userChoice = userInputOutput.ReadInt("Enter your choice: \n", 0, 19);
            return userChoice;
        }

        public void ShowActionSuccess(string actionName)
        {
            Console.WriteLine("\n{0} executed successfully!\n", actionName);
        }

        public void ArrayFull()
        {
            Console.WriteLine("\nThere is no more space to add. PLease remove a Lego set to add another.\n\n");
        }

        public bool ConfirmDelete()
        {
            Console.WriteLine("\nPlease confirm that you want to delete this set. Press Y to delete. Press any other key to continue.\n");
            bool confirm = userInputOutput.ReadKey();
            Console.WriteLine("\n\n");
            return confirm;
        }

        public void ArrayNull()
        {
            Console.WriteLine("\nYou have selected an empty space. Please try again.\n");
        }
    }
}
