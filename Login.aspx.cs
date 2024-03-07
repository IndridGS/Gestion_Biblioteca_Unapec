using System;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Verificar si se ha enviado el formulario
        if (Request.HttpMethod == "POST")
        {
            // Obtener los valores del formulario
            string usuario = Request.Form["usuario"];
            string contrasena = Request.Form["contrasena"];

            // Verificar las credenciales (usuario y contraseña predeterminados)
            if (ValidarCredenciales(usuario, contrasena))
            {
                // Inicio de sesión exitoso
                Console.WriteLine("Inicio de sesión exitoso para el usuario: " + usuario);
            }
            else
            {
                // Credenciales incorrectas
                Console.WriteLine("Credenciales inválidas. Acceso denegado.");
            }
        }
    }

    // Función para validar las credenciales (puede ser más compleja en una aplicación real)
    private bool ValidarCredenciales(string usuario, string contrasena)
    {
        return usuario == "usuario1" && contrasena == "contrasena1";
    }
}
