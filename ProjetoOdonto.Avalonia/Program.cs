using Avalonia;
using ProjetoOdonto.Avalonia.Data;
using ProjetoOdonto.Avalonia.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ProjetoOdonto.Avalonia
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            // Se você quiser rodar o console de inserção de usuário:
            //InserirUsuario();

            // Inicializa a aplicação Avalonia normalmente
            BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace();

        // Função separada para inserir usuários no banco
        public static void InserirUsuario()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=meubanco;Username=postgres;Password=pgbenkyou");

            using var context = new MyDbContext(optionsBuilder.Options);

            Console.WriteLine("Digite o nome do usuário:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o email do usuário:");
            var email = Console.ReadLine();

            var usuario = new Usuario
            {
                Nome = nome!,
            };

            context.Usuarios.Add(usuario);
            context.SaveChanges();

            Console.WriteLine($"Usuário {usuario.Nome} adicionado com sucesso!");
        }
    }
}
