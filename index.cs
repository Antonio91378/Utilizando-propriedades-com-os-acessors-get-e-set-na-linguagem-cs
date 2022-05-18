using System;

class Carro
{
    private int velMax;

    // criei a 'propriedade' vm para manipular minha variável private 'velMax', na qual possui os assesores get e set.
    public int vm
    {
        get
        {
            return velMax;
        }
        set
        {
            if (value < 0)
            {
                velMax = 0;
            }
            if (value > 300)
            {
                velMax = 300;
            }
            else
            {
                velMax = value;
            }
        }
    }

    public Carro()
    {
        vm = 120;
    }
}

class Principal
{
    static void Main()
    {
        Carro c1 = new Carro();
        c1.vm = 350;
        Console.WriteLine("velocidade:{0}", c1.vm);
    }
}
