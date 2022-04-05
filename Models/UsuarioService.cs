using System.Linq;
using System.Collections.Generic;
using System.Collections;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models
{
    public class UsuarioService 
    {
        public List<Usuario> Listar()
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.ToList();
            }
        }

        public Usuario Listar(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                return bc.Usuarios.Find(id);
            }
        }

        public void incluirUsuario(Usuario novoUser)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Add(novoUser);
                bc.SaveChanges();
            }
        }
        public void editarUsuario(Usuario userEditado)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario usuario = bc.Usuarios.Find(userEditado.Id);

                usuario.Nome = userEditado.Nome;
                usuario.Login = userEditado.Login;
                usuario.Senha = userEditado.Senha;
                usuario.Tipo = userEditado.Tipo;

                bc.SaveChanges();
            }
            
        }

        public void excluirUsuario(int id)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {   
                bc.Usuarios.Remove(bc.Usuarios.Find(id));
                bc.SaveChanges();
            }
        }
    }
} 