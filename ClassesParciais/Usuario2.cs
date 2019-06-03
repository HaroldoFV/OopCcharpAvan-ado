using System;

public partial class Usuario
{
    public bool Autenticar()
    {
        return (Nome == "haroldo") & (Senha == "123");
    }
}

