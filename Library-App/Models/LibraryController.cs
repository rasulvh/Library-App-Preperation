using Domain.Models;
using Repository.Repositories;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Library_App.Models
{
    public class LibraryController
    {
        private readonly LibraryService _libraryService;

        public LibraryController()
        {
            _libraryService= new LibraryService();
        }

        public void Create()
        {
            try
            {
                ConsoleColor.DarkYellow.CW("Add library name: ");
                string name = Console.ReadLine();

                ConsoleColor.DarkYellow.CW("Add library seat count: ");
            SeatCount: string seatCountStr = Console.ReadLine();
                int seatCount;
                bool isParseSeatCount = int.TryParse(seatCountStr, out seatCount);

                if (isParseSeatCount)
                {
                    Library library = new()
                    {
                        Name = name,
                        SeatCount = seatCount,
                    };

                    var result = _libraryService.Create(library);

                    ConsoleColor.Green.CW($"Id: {result.Id}, Name: {result.Name}, Seat Count: {result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.CW("Add write correct seat count: ");
                    goto SeatCount;
                }
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.CW(ex.Message);
            }
            
    
        }

        public void GetById()
        {
            try
            {
                ConsoleColor.DarkYellow.CW("Write library id: ");

                Id: string idStr = Console.ReadLine();
                int id;
                bool isParseId = int.TryParse(idStr, out id);

                if (isParseId) 
                {
                    var result = _libraryService.GetById(id);

                    if(result is null)
                    {
                        ConsoleColor.Red.CW("Library not found, try again");
                        goto Id;
                    }

                    ConsoleColor.Green.CW($"Id: {result.Id}, Name: {result.Name}, Seat Count: {result.SeatCount}");
                }
                else
                {
                    ConsoleColor.Red.CW("Write correct library id: ");
                    goto Id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
