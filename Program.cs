using System;

namespace curriculo
{
    class Program
    {
        static void Main(string[] args)
        {
            string tel;
            string nascimento;
            string endereço;
            string cep;
            string numerocasa;
                string nome;
            string nacionalidade;
            string status;
            string email;
            string objetivo;
            string formaçâo;
            string exp;

            Console.WriteLine("olá." +
                "vamos começar seu cadstro completo");
            Console.WriteLine("digite seu nome:");
        nome= Console.ReadLine();
            Console.WriteLine("qual sua nacionalidade?");
        nacionalidade= Console.ReadLine();
            Console.WriteLine("qual seu estado civil?");
        status= Console.ReadLine();
            Console.WriteLine("qual sua data de nascimento?");
        nascimento= Console.ReadLine();
            Console.WriteLine("qual seu endereço?");
            endereço = Console.ReadLine();
            Console.WriteLine("numero da casa");
            numerocasa = Console.ReadLine();
            Console.WriteLine("cep");
            cep= Console.ReadLine();
            Console.WriteLine("telefone para contato");
            tel= Console.ReadLine();
            Console.WriteLine("email para contato");
            email= Console.ReadLine();
            Console.WriteLine("qual é o seu objetivo profissional?");
            objetivo= Console.ReadLine();
            Console.WriteLine("qual é a sua formação acadêmica?");
            formaçâo = Console.ReadLine();
            Console.WriteLine("possui experiência profissional?");
            exp= Console.ReadLine();
            Console.WriteLine("para fechar pressione qualquer tecla");
            Console.ReadLine();
        }
    }
}
