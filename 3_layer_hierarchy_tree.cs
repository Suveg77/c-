using System;


public class SchoolDepartments
{

    public int DepartmentYear { get; set; }
    public string Coordinator { get; set; }
    public string UpcomingEvent { get; set; }

    public string ClassNumber { get; set; }
    public int StudentNumber { get; set; }




    public void DisplayInfo()
    {
        
        Console.WriteLine($"\nThe year department strarted: {DepartmentYear}");
        Console.WriteLine($"Department Coordinator: {Coordinator}");
        Console.WriteLine($"Upcoming events: {UpcomingEvent}");
        Console.WriteLine($"Classroom number: {ClassNumber}");

    }

}

public class Science : SchoolDepartments
{

    public string EmergencyShowers { get; set; }
    public string MaterialOfStudy { get; set; }

    public void Read()
    {
        Console.WriteLine($"Number of students in the department:{StudentNumber}");
    }


    public class BioLab : Science
    {
        public int Organisms { get; set; }
        public int OperationalTools { get; set; }
        public void Read() {

            Console.WriteLine($"\nEmergency showers: {EmergencyShowers}");
            Console.WriteLine($"Field of study of this subject: {MaterialOfStudy}");
            Console.WriteLine($"Number of organisms in Biology Lab: {Organisms}");
            Console.WriteLine($"Number of operational tools in Biology Lab: {OperationalTools}");


        }

    }



    public class ChemLab : Science
    {

        public int Chemicals { get; set; }
        public int WaterSupply { get; set; }
        public void Read()
        {
            
            Console.WriteLine($"\nEmergency showers:{EmergencyShowers}");
            Console.WriteLine($"Field of study of this subject:{MaterialOfStudy}");
            Console.WriteLine($"Total number of chemicals available right now for experimentation:{Chemicals}");
            Console.WriteLine($"Total number of water supply taps in the Chemistry Lab:{WaterSupply}");


        }


     

    }

}

public class Math : SchoolDepartments
{

    public void Read()
    {
        Console.WriteLine($"Number of students in the department:{StudentNumber}");
    }

}

public class Art : SchoolDepartments
{

    public void Read()
    {
        Console.WriteLine($"Number of students in the department: {StudentNumber}");
    }

   
}


class Program
{

    static void Main()
    {
        Science ScienceData = new Science
        {
            DepartmentYear = 2004,
            Coordinator = "Dr. The Rock",
            UpcomingEvent = "Science Fair",
            ClassNumber = "22D",
            StudentNumber = 300,
            
           
        };

        Science.BioLab BiologyData = new Science.BioLab
        {
            EmergencyShowers= "Non-Existing",
            MaterialOfStudy= "Organic Substances",
            Organisms= 35,
            OperationalTools= 80,


        };


        Science.ChemLab ChemistryData = new Science.ChemLab
        {
            EmergencyShowers = "Non-Existing",
            MaterialOfStudy = "Organic Substances",
            Chemicals = 200,
            WaterSupply = 6,


        };


        Math MathData = new Math
        {
            DepartmentYear = 2003,
            Coordinator = "Mr. Kevin Hart",
            UpcomingEvent = "Math Quiz",
            ClassNumber = "12B",
            StudentNumber = 370

        };
        

 
        Art ArtData = new Art
        {
            DepartmentYear = 2006,
            Coordinator = "Mrs. Danielle Nicolet",
            UpcomingEvent = "Art Comptition",
            ClassNumber = "5B",
            StudentNumber = 430

        };



        Console.WriteLine("Information regarding Science department:");
        ScienceData.DisplayInfo();
        ScienceData.Read();

        Console.WriteLine("\n\nBiologyLab Details");
        BiologyData.Read();

        Console.WriteLine("\n\nChemistry Details");
        ChemistryData.Read();


        Console.WriteLine("\n\nInformation regarding Math department:");
        MathData.DisplayInfo();
        MathData.Read();

       
        Console.WriteLine("\n\nInformation regarding Art department:");
        ArtData.DisplayInfo();
        ArtData.Read();
        

    }



    static void Science()
    {
        
    }
}
