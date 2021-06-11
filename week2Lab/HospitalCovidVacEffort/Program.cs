using System;
using System.Collections.Generic;

namespace HospitalCovidVacEffort
{
    class Program {
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu(){
            var vaccineList = new List<Vaccine>{
                    new Vaccine() {id=0, VaccineName="Pfizer/BioNTech", DosesRequired=2, DaysBetweenDoses=21, TotalDosesReceived=10000},
                    new Vaccine() {id=1, VaccineName="Johnson & Johnson", DosesRequired=1, DaysBetweenDoses=0, TotalDosesReceived=5000},
                };

            bool x = true;
            while(x){
                Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------+");
                Console.WriteLine("                                                   Vaccine Management                                                       ");
                Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------+");
                Console.WriteLine("|           Id           Name                Doses Required         Days Between Doses        Total Doses Received         ");  
                foreach (Vaccine v in vaccineList)
                {
                    Console.WriteLine(v.displayInfo());
                }
                Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------+\n");
               
                Console.WriteLine("     a) Add a new vaccine                                       ");
                Console.WriteLine("     x) Exit                                                    ");
                Console.WriteLine("Please Enter Your Choice (id # for vaccine): ");

                string caseSwitch = Console.ReadLine();

                
                vaccineList = newDosesUpdate(caseSwitch, vaccineList);

                switch(caseSwitch) {
                case "a":
                    vaccineList= newVaccine(vaccineList);
                    break;
                case "x":
                    Console.WriteLine("Program has terminated!!");
                    x=false;
                    break;
            }
            }
        }

        public static List<Vaccine> newDosesUpdate( string id, List<Vaccine> list ) {
            for( int i = 0; i < list.Count; i++){
                if(id == list[i].id.ToString()){
                    Console.WriteLine("Vaccine Management - " + list[i].VaccineName);
                    Console.WriteLine("Please enter how many new doses are received: ");
                    int newDose = Int32.Parse(Console.ReadLine());
                    list[i].TotalDosesReceived = newDose;
                }
            }
            return list;
        }  

        public static List<Vaccine> newVaccine(List<Vaccine> list){
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------+");
            Console.WriteLine("                                                     New Vaccine Entry                                                   ");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------+\n");
               
            int id = list.Count+1;
            int days = 0;

            Console.WriteLine("Enter the name of vaccine: ");
            string name = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine(name + " doses required: ");
            int doseRequired = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            if(doseRequired > 1){
                Console.WriteLine("Days between doses: ");
                days = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n");
            }
            
            Console.WriteLine("Total Doses Recieved: ");
            long totalDoses = Int64.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------+\n");
               
            list.Add(new Vaccine(){id=id, VaccineName=name, DosesRequired=doseRequired, DaysBetweenDoses=days, TotalDosesReceived=totalDoses});
    
            return list;
            
        }      
    }
   

    class Vaccine {

        public int id { get; set; }
        public string VaccineName { get; set; }
        public int DosesRequired { get; set; }
        public int DaysBetweenDoses { get; set; }
        public Int64 TotalDosesReceived { get; set; }

        public string displayInfo(){
            return "|            "+id.ToString()+"           "+VaccineName+"         "+DosesRequired.ToString()+"                        "+
            DaysBetweenDoses.ToString()+"                        "+TotalDosesReceived.ToString();
        }
    }


}
