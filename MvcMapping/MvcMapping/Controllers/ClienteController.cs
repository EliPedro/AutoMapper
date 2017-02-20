using AutoMapper;
using MvcMapping.Models;
using MvcMapping.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMapping.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var rdnGen = new Random();

            // Um fake de uma consulta de cliente na base de dados.

            var cliente = new Cliente
            {
                Nome = "Teste",
                Sobrenome = "OK",
                DataNascimento = Convert.ToDateTime("30/11/1991"),
                Ativo = true
            };

            // Transformando a Model Cliente em ClienteViewModel

            var clienteView = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            // Atribuindo valor aos dados adicionais da entidade Cliente

            clienteView.NumeroDaSorte = rdnGen.Next(1, 100);
            return View(clienteView);

        }
    }
}