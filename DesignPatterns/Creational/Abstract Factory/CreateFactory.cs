using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    public interface ICreateFactory
    {
        ICamisa CreateCamisa();
        IShorts CreateShorts();
        ITenis CreateTenis();
    }

    public class Camisa : ICamisa
    {
        public string Vestir()
        {
            return "Vestir Camisa";
        }
    }

    public class Shorts : IShorts
    {
        public string Vestir()
        {
            return "Vestir Shorts";
        }
    }

    public class Tenis : ITenis
    {
        public string Vestir()
        {
            return "Calçar Tenis";
        }
    }


    public interface ICamisa
    {
        string Vestir();
    }

    public interface IShorts
    {
        string Vestir();
    }

    public interface ITenis
    {
        string Vestir();
    }

    public class NikeFactory : ICreateFactory
    {
        public ICamisa CreateCamisa()
        {
            Console.WriteLine("Camisa Nike Criada");
            return new Camisa();
        }

        public IShorts CreateShorts()
        {
            Console.WriteLine("Shorts Nike Criada");
            return new Shorts();
        }

        public ITenis CreateTenis()
        {
            Console.WriteLine("Tenis Nike Criada");
            return new Tenis();
        }
    }

    public class AdidasFactory : ICreateFactory
    {
        public ICamisa CreateCamisa()
        {
            Console.WriteLine("Camisa Adidas Criada");
            return new Camisa();
        }

        public IShorts CreateShorts()
        {
            Console.WriteLine("Shorts Adidas Criada");
            return new Shorts();
        }

        public ITenis CreateTenis()
        {
            Console.WriteLine("Tenis Adidas Criada");
            return new Tenis();
        }
    }

    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Client: Testando client code com NikeFactory");
            ClientMethod(new NikeFactory());

            Console.WriteLine("------------------------");

            Console.WriteLine("Client: Testando client code com AdidasFactory");
            ClientMethod(new AdidasFactory());
        }

        public void ClientMethod(ICreateFactory roupasFactory)
        {
            var camisa = roupasFactory.CreateCamisa();

            var shorts = roupasFactory.CreateShorts();

            var tenis = roupasFactory.CreateTenis();

            Console.WriteLine(camisa.Vestir());

            Console.WriteLine(shorts.Vestir());

            Console.WriteLine(tenis.Vestir());
        }
    }
}
