using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Singleton
/// </summary>
public class Singleton
{
    private static Singleton instance;
    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    const string conn = "Data Source=(local);Initial Catalog=thuctap_56132389;Integrated Security=True";

}