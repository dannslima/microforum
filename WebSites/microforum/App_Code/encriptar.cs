using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for encriptar
/// </summary>
public class encriptar
{
    public string CriarMD5(string password)
    {
        MD5 encriptador = MD5.Create();
        byte[] inicial = Encoding.ASCII.GetBytes(password);
        byte[] final = encriptador.ComputeHash(inicial);

        StringBuilder str = new StringBuilder();
        for (int i = 0; i < final.Length; i++)
        {
            str.Append(final[i].ToString("X2"));
        }

        return str.ToString();
    }
}