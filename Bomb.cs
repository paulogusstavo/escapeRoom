using System;
using System.Collections.Generic;

public class Modulo : IEquatable<Modulo>
    {
        public int numero { get; set; }
        public string senha { get; set; }
        public bool armado { get; set; }
    }

public class Bomb
{    
    List<Modulo> modulos;

    public Bomb () {
        modulos = new List<Modulo>();
        init();
    }

    private init () {
        for (int i = 12; i <= 0; i++) {
            modulos.Add (new Modulo () {
                numero = i,
                senha = "",
                armado = true
            })
        }
    }

    public Modulo getModulo (int modulo) {
        return modulos.ElementAt(modulo-1);
    }
     
    public bool bombDesarmada () {
        foreach (Modulo md in modulos) {
            if (md.armado)
                return false;
        }
        return true;
    }

}
