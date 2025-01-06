using System;

class OggettoSegreto
{
    private float valueD;

    public float ValueD
    {
        get { return valueD; }
        set { valueD = value; }
    }

    virtual public float valueA()
    {
        return ValueD;
    }
}

class Gioiello : OggettoSegreto
{
    override public float valueA()
    {
        return ValueD * 5;
    }
}

class Documento : OggettoSegreto
{
    override public float valueA()
    {
        if (ValueD >= 100)
            return ValueD;
        else
            return 50;
    }
}

class Chiave : OggettoSegreto
{
    override public float valueA()
    {
        return ValueD * 1000;
    }
}

class CassettaDiSicurezza
{
    priv
    private OggettoSegreto contenuto;

    public void inserisci(OggettoSegreto o)
    {
        contenuto = o;
    }

    public OggettoSegreto rimuovi()
    {
        OggettoSegreto o = contenuto;
        contenuto = null;
        return o;
    }

    public float CheckValueA()
    {
        if (contenuto != null)
            return contenuto.valueA();
        else
            return 0;
    }

    public string checkType1()
    {
        if (contenuto is Documento) return "Documento";
        if (contenuto is Gioiello) return "Gioiello";
        if (contenuto is Chiave) return "Chiave";
        if (contenuto is OggettoSegreto) return "OggettoSegreto";

        return "oggetto sconosciuto";
    }

    public string checkType()
    {
        return contenuto.GetType().ToString();
    }
}
class MAIN
{
    static void Main()
    {
        CassettaDiSicurezza cassetta1 = new CassettaDiSicurezza();
        CassettaDiSicurezza cassetta2 = new CassettaDiSicurezza();
        CassettaDiSicurezza cassetta3 = new CassettaDiSicurezza();
        Gioiello collana = new Gioiello();
        collana.ValueD = 10000;
        Documento doc = new Documento();
        doc.ValueD = 70;
        Chiave chiave = new Chiave();
        chiave.ValueD = 500;

        cassetta1.inserisci(collana);
        cassetta2.inserisci(doc);
        cassetta3.inserisci(chiave);

        Console.WriteLine(cassetta1.CheckValueA());
        Console.WriteLine(cassetta2.CheckValueA());
        Console.WriteLine(cassetta3.CheckValueA());

        Console.WriteLine(cassetta1.checkType());
        Console.WriteLine(cassetta2.checkType());
        Console.WriteLine(cassetta3.checkType());
    }
}