using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Security.Cryptography;
using Encriptar.Models;

namespace Encriptar.Controllers
{
    public class CifradoController : Controller
    {
        // GET: Cifrado
        public ActionResult CifradoHash()
        {
            return View();
        }

        //POST: CifradoHash
        [HttpPost]
        public ActionResult CifradoHash(String texto
            , String password,String accion )
        {


            if (accion == "cifrar")
            {
                var encriptado = Cipher.Encrypt(texto, password);
                ViewBag.Resultado = encriptado.ToString();
            }
            if(accion=="descifrar")
            {
                var encriptado = Cipher.Decrypt(texto, password);
                ViewBag.Resultado = encriptado.ToString();
            }

            return View();


        }

    }
}