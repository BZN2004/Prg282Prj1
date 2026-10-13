using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prg282Prj
{
    internal class Animal
    {
       public string AnimalID {  get; set; }
        public string AnimalName { get; set; }
        public string AnimalSpecies { get; set; }
        public int AnimalAge { get; set; }
        public int RecoveryScore { get; set; }
        public string Status {  get; private set; }
        //Calculated from recovery store (User may not enter value)
        public string HousingUnit {  get; private set; }
        //Calculated from recovery store (User may not enter value)


        /* Calculates and assigns the Status and Housing Unit based on the Animal's RecoveryScore. */
        public void Classification()
        {

            if (RecoveryScore <= 19)
                {
                    Status = "Critical";
                    HousingUnit = "Intensive Care Unit";
                }
                else if (RecoveryScore <= 39 && RecoveryScore >= 20)
                {
                    Status = "Serious";
                    HousingUnit = "High-Dependency Ward";
                }
                else if (RecoveryScore <= 59 && RecoveryScore >= 40)
                {
                    Status = "Stable";
                    HousingUnit = "Recovery Ward";
                }
                else if (RecoveryScore <= 79 && RecoveryScore >= 60)
                {
                    Status = "Recovering";
                    HousingUnit = "Outdoor Enclosure";
                }
                else
                {
                    Status = "Release-Ready";
                    HousingUnit = "Pre-Release Camp";
                }

            
        
        }

        /* Formats the animal's data into a pipe-separated string to be written to animals.txt. */
        public string ToFileFormat()
        {
            return $"{AnimalID}|{AnimalName}|{AnimalSpecies}|{AnimalAge}|{RecoveryScore}|{Status}|{HousingUnit}";
        }






    }

}
