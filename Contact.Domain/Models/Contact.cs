using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Domain.Models;

public class Contact : BaseEntity
{
    // nova instância da classe (consistêcia)
    public Contact(string name, string email)
    {
        ValidateCategory(name, email);
        Name = name;
        Email = email;
    }
    [Required] public string Name { get; private set; }
    [Required] public string Email { get; private set; }


    public void Update(string name, string email) 
    { 
        ValidateCategory(name, email); 
    }

    public void ValidateCategory(string name, string email)
    {
        if (string.IsNullOrEmpty(name))
            throw new InvalidOperationException("Nome inválido");

        if (string.IsNullOrEmpty(email))
            throw new InvalidOperationException("Email inválido");
    }
}
