using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {            
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }                        

            List<Department> departments = new List<Department>{
                new Department { Name = "Computers" },
                new Department { Name = "Electronics" },
                new Department { Name = "Fashion" },
                new Department { Name = "Book"}
            };
            
            List<Seller> sellers = new List<Seller> {
                new Seller { Name = "Bob Brown",   Email = "bob@gmail.com",    BirthDate = new DateTime(1998, 4, 21),  BaseSalary = 1000.0, Department = departments[0] },
                new Seller { Name = "Maria Green", Email = "maria@gmail.com",  BirthDate = new DateTime(1979, 12, 31), BaseSalary = 3500.0, Department = departments[1] },
                new Seller { Name = "Alex Grey",   Email = "alex@gmail.com",   BirthDate = new DateTime(1988, 1, 15),  BaseSalary = 2200.0, Department = departments[0] },
                new Seller { Name = "Martha Red",  Email = "martha@gmail.com", BirthDate = new DateTime(1993, 11, 30), BaseSalary = 3000.0, Department = departments[3] },
                new Seller { Name = "Donald Blue", Email = "donald@gmail.com", BirthDate = new DateTime(2000, 1, 9),   BaseSalary = 4000.0, Department = departments[2] },
                new Seller { Name = "Alex Pink",   Email = "bob@gmail.com",    BirthDate = new DateTime(1997, 3, 4),   BaseSalary = 3000.0, Department = departments[1] }
            };

            List<SalesRecord> sales = new List<SalesRecord> {
                new SalesRecord { Date = new DateTime(2018, 09, 25), Amount = 11000.0, Status = SaleStatus.Billed,   Seller = sellers[0] },
                new SalesRecord { Date = new DateTime(2018, 09, 4),  Amount = 7000.0,  Status = SaleStatus.Billed,   Seller = sellers[4] },
                new SalesRecord { Date = new DateTime(2018, 09, 13), Amount = 4000.0,  Status = SaleStatus.Canceled, Seller = sellers[3] },
                new SalesRecord { Date = new DateTime(2018, 09, 1),  Amount = 8000.0,  Status = SaleStatus.Billed,   Seller = sellers[0] },
                new SalesRecord { Date = new DateTime(2018, 09, 21), Amount = 3000.0,  Status = SaleStatus.Billed,   Seller = sellers[2] },
                new SalesRecord { Date = new DateTime(2018, 09, 15), Amount = 2000.0,  Status = SaleStatus.Billed,   Seller = sellers[0] },
                new SalesRecord { Date = new DateTime(2018, 09, 28), Amount = 13000.0, Status = SaleStatus.Billed,   Seller = sellers[1] },
                new SalesRecord { Date = new DateTime(2018, 09, 11), Amount = 4000.0,  Status = SaleStatus.Billed,   Seller = sellers[3] },
                new SalesRecord { Date = new DateTime(2018, 09, 14), Amount = 11000.0, Status = SaleStatus.Pending,  Seller = sellers[5] },
                new SalesRecord { Date = new DateTime(2018, 09, 7),  Amount = 9000.0,  Status = SaleStatus.Billed,   Seller = sellers[5] },
                new SalesRecord { Date = new DateTime(2018, 09, 13), Amount = 6000.0,  Status = SaleStatus.Billed,   Seller = sellers[1] },
                new SalesRecord { Date = new DateTime(2018, 09, 25), Amount = 7000.0,  Status = SaleStatus.Pending,  Seller = sellers[2] },
                new SalesRecord { Date = new DateTime(2018, 09, 29), Amount = 10000.0, Status = SaleStatus.Billed,   Seller = sellers[3] },
                new SalesRecord { Date = new DateTime(2018, 09, 4),  Amount = 3000.0,  Status = SaleStatus.Billed,   Seller = sellers[4] },
                new SalesRecord { Date = new DateTime(2018, 09, 12), Amount = 4000.0,  Status = SaleStatus.Billed,   Seller = sellers[0] },
                new SalesRecord { Date = new DateTime(2018, 10, 5),  Amount = 2000.0,  Status = SaleStatus.Billed,   Seller = sellers[3] },
                new SalesRecord { Date = new DateTime(2018, 10, 1),  Amount = 12000.0, Status = SaleStatus.Billed,   Seller = sellers[0] },
                new SalesRecord { Date = new DateTime(2018, 10, 24), Amount = 6000.0,  Status = SaleStatus.Billed,   Seller = sellers[2] },
                new SalesRecord { Date = new DateTime(2018, 10, 22), Amount = 8000.0,  Status = SaleStatus.Billed,   Seller = sellers[4] },
                new SalesRecord { Date = new DateTime(2018, 10, 15), Amount = 8000.0,  Status = SaleStatus.Billed,   Seller = sellers[5] },
                new SalesRecord { Date = new DateTime(2018, 10, 17), Amount = 9000.0,  Status = SaleStatus.Billed,   Seller = sellers[1] },
                new SalesRecord { Date = new DateTime(2018, 10, 24), Amount = 4000.0,  Status = SaleStatus.Billed,   Seller = sellers[3] },
                new SalesRecord { Date = new DateTime(2018, 10, 19), Amount = 11000.0, Status = SaleStatus.Canceled, Seller = sellers[1] },
                new SalesRecord { Date = new DateTime(2018, 10, 12), Amount = 8000.0,  Status = SaleStatus.Billed,   Seller = sellers[4] },
                new SalesRecord { Date = new DateTime(2018, 10, 31), Amount = 7000.0,  Status = SaleStatus.Billed,   Seller = sellers[2] },
                new SalesRecord { Date = new DateTime(2018, 10, 6),  Amount = 5000.0,  Status = SaleStatus.Billed,   Seller = sellers[3] },
                new SalesRecord { Date = new DateTime(2018, 10, 13), Amount = 9000.0,  Status = SaleStatus.Pending,  Seller = sellers[0] },
                new SalesRecord { Date = new DateTime(2018, 10, 7),  Amount = 4000.0,  Status = SaleStatus.Billed,   Seller = sellers[2] },
                new SalesRecord { Date = new DateTime(2018, 10, 23), Amount = 12000.0, Status = SaleStatus.Billed,   Seller = sellers[4] },
                new SalesRecord { Date = new DateTime(2018, 10, 12), Amount = 5000.0,  Status = SaleStatus.Billed,   Seller = sellers[1] }
            };

            await _context.Department.AddRangeAsync(departments);
            await _context.Seller.AddRangeAsync(sellers);
            await _context.SalesRecord.AddRangeAsync(sales);

            try
            {                
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new ArgumentException("SeedingService.Seed: " + e.Message + "\nType: " + e.GetType());
            }
        }
    }
}
