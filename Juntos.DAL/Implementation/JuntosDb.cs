using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Juntos.Domain.Model;
using Juntos.IDAL;

namespace Juntos.DAL.Implementation
{
    class JuntosDb
    {

        private JuntosContext context = null;

        private IBaseDao<Advertiser> _advertisers = null;
        private IBaseDao<Purchase> _purchases = null;
        private IBaseDao<Consumer> _consumers = null;
        private IBaseDao<Coupon> _coupons = null;
        private IBaseDao<Address> _addresses = null;
        private IBaseDao<Offer> _offers = null;
        private IBaseDao<Payment> _payments = null;
        private IBaseDao<Person> _persons = null;
        private IBaseDao<Telephone> _telephones = null;
        private IBaseDao<Coordinate> _coordinates = null;
        private IBaseDao<Login> _logins = null;


        public JuntosDb()
        {
            this.context = JuntosContext.Instance;

            //this.anunciantes = new AnuncianteDao(this.context);
            //this.compras = new CompraDao(this.context);
            //this.consumidores = new ConsumidorDao(this.context);
            //this.cupons = new CupomDao(this.context);
            //this.enderecos = new EnderecoDao(this.context);
            //this.ofertas = new OfertaDao(this.context);
            //this.pagamentos = new PagamentoDao(this.context);
            //this.telefones = new TelefoneDao(this.context);
        }


        private IBaseDao<Advertiser> advertisers { get { return this._advertisers; } }
        private IBaseDao<Purchase> purchases { get { return this._purchases; } }
        private IBaseDao<Consumer> consumers { get { return this._consumers; } }
        private IBaseDao<Coupon> coupons { get { return this._coupons; } }
        private IBaseDao<Address> addresses { get { return this._addresses; } }
        private IBaseDao<Offer> offers { get { return this._offers; } }
        private IBaseDao<Payment> payments { get { return this._payments; } }
        private IBaseDao<Person> persons { get { return this._persons; } }
        private IBaseDao<Telephone> telephones { get { return this._telephones; } }
        private IBaseDao<Coordinate> coordinates { get { return this._coordinates; } }
        private IBaseDao<Login> logins { get { return this._logins; } }


        

    }
}
