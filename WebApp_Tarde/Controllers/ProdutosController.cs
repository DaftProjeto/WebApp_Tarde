using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using WebApp_Tarde.Models;
using WebApp_Tarde.Entidades;

namespace WebApp_Tarde.Controllers
{
    public class ProdutosController : Controller
    {
         
        public IActionResult Lista()
        {
            return View(db.Produtos.Include(a => a.Categoria).ToList());
        }

        public IActionResult Cadastro()
        {
            NovoProdutoViewModel model = new NovoProdutoViewModel();
            model.Lista_Categorias = db.Categorias.ToList();
            return View();
        }
    [HttpPost]

        public IActionResult SalvarDados(ProdutoEntidade produto)
    {
        db.Produto.Add(produto);

    }
    }

}
