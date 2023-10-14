using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;
namespace Business
{
    public class BCustomer
    {
        public List<Customer> GetCustomersByName(string productName)
        {
            // Validar el nombre del producto (puedes agregar más validaciones según tus necesidades)
            if (string.IsNullOrEmpty(productName))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            }

            // Aquí puedes realizar lógica adicional antes de acceder a la capa de datos, si es necesario.

            List<Customer> products = new List<Customer>();

            CustomerDB customerDataAccess = new CustomerDB();
            products = customerDataAccess.GetCustomer();

            var results = products.Where(x => x.Name == productName).ToList();

            return results;
        }
    }
}