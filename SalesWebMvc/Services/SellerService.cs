using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Data;


namespace SalesWebMvc.Services
{
    public class SellerService
    {

        private readonly SalesWebMvcContext _context;


        //A criação do construtor garante que a injeção de dependência possa ocorrer.
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }


    }
}
