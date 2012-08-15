using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juntos.Domain.Model
{
    public abstract class Person : Entity
    {
        public string name { get; set; }
        public string document { get; set; }
        public DateTime birthDate { get; set; }
        public string email { get; set; }

        private List<Telephone> _telephones = new List<Telephone>();
        public virtual List<Telephone> telephones { get { return this._telephones; } private set { this._telephones = value; } }

        private List<Address> _addresses = new List<Address>();
        public virtual List<Address> addresses { get { return this._addresses; } private set { this._addresses = value; } }

        public virtual Login login { get; set; }

        public PersonType type { get; set; }

       

        public void AddTelephone(Telephone parameter) 
        {

            this.telephones.Add(parameter);
        
        }

        public void AddAddress(Address parameter)
        {
           
            this.addresses.Add(parameter);
            
        }





    }





}
