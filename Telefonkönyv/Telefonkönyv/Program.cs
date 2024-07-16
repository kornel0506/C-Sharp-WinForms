using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

struct Person
{
    public string Name;
    public string Address;
    public string FatherName;
    public string MotherName;
    public long MobileNo;
    public string Sex;
    public string Email;
    public string CitizenNo;
}

class PhoneBook
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Start();
    }

    static void Back()
    {
        Start();
    }

    static void Start()
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("\t**********WELCOME TO PHONEBOOK**********");
        Console.WriteLine("\n\n\t\t\t MENU\t\t\n\n");
        Console.WriteLine("\t1.Add New \t2.List \t\t3.Exit \n\t4.Modify \t5.Search\t6.Delete");

        switch (Console.ReadKey().KeyChar)
        {
            case '1': AddRecord(); break;
            case '2': ListRecord(); break;
            case '3': Environment.Exit(0); break;
            case '4': ModifyRecord(); break;
            case '5': SearchRecord(); break;
            case '6': DeleteRecord(); break;
            default:
                Console.Clear();
                Console.WriteLine("\nEnter 1 to 6 only");
                Console.WriteLine("\n Press any key");
                Console.ReadKey();
                Menu();
                break;
        }
    }

    static void AddRecord()
    {
        Console.Clear();
        Person p = new Person();
        using (BinaryWriter writer = new BinaryWriter(File.Open("project", FileMode.Append)))
        {
            Console.Write("\n Enter name: ");
            p.Name = Console.ReadLine();
            Console.Write("\nEnter the address: ");
            p.Address = Console.ReadLine();
            Console.Write("\nEnter father name: ");
            p.FatherName = Console.ReadLine();
            Console.Write("\nEnter mother name: ");
            p.MotherName = Console.ReadLine();
            Console.Write("\nEnter phone no.:");
            p.MobileNo = long.Parse(Console.ReadLine());
            Console.Write("Enter sex:");
            p.Sex = Console.ReadLine();
            Console.Write("\nEnter e-mail:");
            p.Email = Console.ReadLine();
            Console.Write("\nEnter citizen no:");
            p.CitizenNo = Console.ReadLine();

            writer.Write(Encoding.UTF8.GetBytes(p.Name.PadRight(35)));
            writer.Write(Encoding.UTF8.GetBytes(p.Address.PadRight(50)));
            writer.Write(Encoding.UTF8.GetBytes(p.FatherName.PadRight(35)));
            writer.Write(Encoding.UTF8.GetBytes(p.MotherName.PadRight(30)));
            writer.Write(p.MobileNo);
            writer.Write(Encoding.UTF8.GetBytes(p.Sex.PadRight(8)));
            writer.Write(Encoding.UTF8.GetBytes(p.Email.PadRight(100)));
            writer.Write(Encoding.UTF8.GetBytes(p.CitizenNo.PadRight(20)));
        }

        Console.WriteLine("\nRecord saved");
        Console.WriteLine("\n\nPress any key");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void ListRecord()
    {
        Console.Clear();
        using (BinaryReader reader = new BinaryReader(File.Open("project", FileMode.Open)))
        {
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                Person p = new Person();
                p.Name = Encoding.UTF8.GetString(reader.ReadBytes(35)).Trim();
                p.Address = Encoding.UTF8.GetString(reader.ReadBytes(50)).Trim();
                p.FatherName = Encoding.UTF8.GetString(reader.ReadBytes(35)).Trim();
                p.MotherName = Encoding.UTF8.GetString(reader.ReadBytes(30)).Trim();
                p.MobileNo = reader.ReadInt64();
                p.Sex = Encoding.UTF8.GetString(reader.ReadBytes(8)).Trim();
                p.Email = Encoding.UTF8.GetString(reader.ReadBytes(100)).Trim();
                p.CitizenNo = Encoding.UTF8.GetString(reader.ReadBytes(20)).Trim();

                Console.WriteLine("\n\n\n YOUR RECORD IS\n\n ");
                Console.WriteLine($"\nName={p.Name}\nAddress={p.Address}\nFather name={p.FatherName}\nMother name={p.MotherName}\nMobile no={p.MobileNo}\nSex={p.Sex}\nE-mail={p.Email}\nCitizen no={p.CitizenNo}");
                Console.ReadKey();
                Console.Clear();
            }
        }

        Console.WriteLine("\n Press any key");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void SearchRecord()
    {
        Console.Clear();
        Console.Write("\nEnter name of person to search\n");
        string name = Console.ReadLine();

        using (BinaryReader reader = new BinaryReader(File.Open("project", FileMode.Open)))
        {
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                Person p = new Person();
                p.Name = Encoding.UTF8.GetString(reader.ReadBytes(35)).Trim();
                p.Address = Encoding.UTF8.GetString(reader.ReadBytes(50)).Trim();
                p.FatherName = Encoding.UTF8.GetString(reader.ReadBytes(35)).Trim();
                p.MotherName = Encoding.UTF8.GetString(reader.ReadBytes(30)).Trim();
                p.MobileNo = reader.ReadInt64();
                p.Sex = Encoding.UTF8.GetString(reader.ReadBytes(8)).Trim();
                p.Email = Encoding.UTF8.GetString(reader.ReadBytes(100)).Trim();
                p.CitizenNo = Encoding.UTF8.GetString(reader.ReadBytes(20)).Trim();

                if (p.Name == name)
                {
                    Console.WriteLine($"\n\tDetail Information About {name}");
                    Console.WriteLine($"\nName:{p.Name}\nAddress:{p.Address}\nFather name:{p.FatherName}\nMother name:{p.MotherName}\nMobile no:{p.MobileNo}\nSex:{p.Sex}\nEmail:{p.Email}\nCitizen no:{p.CitizenNo}");
                    break;
                }
            }
        }

        Console.WriteLine("\n Press any key");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void DeleteRecord()
    {
        Console.Clear();
        Console.Write("Enter CONTACT'S NAME:");
        string name = Console.ReadLine();

        bool found = false;
        string tempFile = Path.GetTempFileName();

        using (BinaryReader reader = new BinaryReader(File.Open("project", FileMode.Open)))
        using (BinaryWriter writer = new BinaryWriter(File.Open(tempFile, FileMode.Create)))
        {
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                Person p = new Person();
                byte[] nameBytes = reader.ReadBytes(35);
                p.Name = Encoding.UTF8.GetString(nameBytes).Trim();

                if (p.Name != name)
                {
                    writer.Write(nameBytes);
                    writer.Write(reader.ReadBytes(243));  
                }
                else
                {
                    found = true;
                    reader.ReadBytes(243); 
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("NO CONTACT'S RECORD TO DELETE.");
            File.Delete(tempFile);
        }
        else
        {
            File.Delete("project");
            File.Move(tempFile, "project");
            Console.WriteLine("RECORD DELETED SUCCESSFULLY.");
        }

        Console.WriteLine("\n Press any key");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }

    static void ModifyRecord()
    {
        Console.Clear();
        Console.Write("\nEnter CONTACT'S NAME TO MODIFY:\n");
        string name = Console.ReadLine();

        string tempFile = Path.GetTempFileName();
        bool found = false;

        using (BinaryReader reader = new BinaryReader(File.Open("project", FileMode.Open)))
        using (BinaryWriter writer = new BinaryWriter(File.Open(tempFile, FileMode.Create)))
        {
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                Person p = new Person();
                byte[] nameBytes = reader.ReadBytes(35);
                p.Name = Encoding.UTF8.GetString(nameBytes).Trim();

                if (p.Name == name)
                {
                    found = true;
                    Console.WriteLine("\nEnter new record\n");
                    Console.Write("\nEnter name: ");
                    p.Name = Console.ReadLine();
                    Console.Write("\nEnter the address: ");
                    p.Address = Console.ReadLine();
                    Console.Write("\nEnter father name: ");
                    p.FatherName = Console.ReadLine();
                    Console.Write("\nEnter mother name: ");
                    p.MotherName = Console.ReadLine();
                    Console.Write("\nEnter phone no.: ");
                    p.MobileNo = long.Parse(Console.ReadLine());
                    Console.Write("Enter sex: ");
                    p.Sex = Console.ReadLine();
                    Console.Write("\nEnter e-mail: ");
                    p.Email = Console.ReadLine();
                    Console.Write("\nEnter citizen no: ");
                    p.CitizenNo = Console.ReadLine();

                    writer.Write(Encoding.UTF8.GetBytes(p.Name.PadRight(35)));
                    writer.Write(Encoding.UTF8.GetBytes(p.Address.PadRight(50)));
                    writer.Write(Encoding.UTF8.GetBytes(p.FatherName.PadRight(35)));
                    writer.Write(Encoding.UTF8.GetBytes(p.MotherName.PadRight(30)));
                    writer.Write(p.MobileNo);
                    writer.Write(Encoding.UTF8.GetBytes(p.Sex.PadRight(8)));
                    writer.Write(Encoding.UTF8.GetBytes(p.Email.PadRight(100)));
                    writer.Write(Encoding.UTF8.GetBytes(p.CitizenNo.PadRight(20)));

                    reader.ReadBytes(243);  // Skip the rest of the old record
                }
                else
                {
                    writer.Write(nameBytes);
                    writer.Write(reader.ReadBytes(243));  // Rest of the record
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("NO CONTACT'S RECORD TO MODIFY.");
            File.Delete(tempFile);
        }
        else
        {
            File.Delete("project");
            File.Move(tempFile, "project");
            Console.WriteLine("RECORD MODIFIED SUCCESSFULLY.");
        }

        Console.WriteLine("\n Press any key");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}


