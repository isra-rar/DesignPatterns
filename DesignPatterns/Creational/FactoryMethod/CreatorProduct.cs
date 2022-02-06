using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory_Method
{
    public abstract class CreatorProduct
    {

        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            var product = FactoryMethod();

            var result = "Creator: Them same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }

    public class NavioCreator : CreatorProduct
    {
        public override IProduct FactoryMethod()
        {
            return new ConcretNavio();
        }
    }

    public class CaminhaoCreator : CreatorProduct
    {
        public override IProduct FactoryMethod()
        {
            return new ConcretCaminhao();
        }
    }

    public interface IProduct
    {
        string Operation();
    }

    public class ConcretNavio : IProduct
    {
        public string Operation()
        {
            return "{Result of CONCRET NAVIO}";
        }
    }
    public class ConcretCaminhao : IProduct
    {
        public string Operation()
        {
            return "{Result of CONCRET CAMINHAO}";
        }
    }

    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Rodando o NavioCreator");
            ClientCode(new NavioCreator());

            Console.WriteLine("----------------------");

            Console.WriteLine("App: Rodando o Caminhao");
            ClientCode(new CaminhaoCreator());
        }




        public void ClientCode(CreatorProduct creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
            // ...
        }
    }

}
