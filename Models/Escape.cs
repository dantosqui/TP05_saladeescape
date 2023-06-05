class escape{
    public static string[] incognitas {get; private set;}
    public static int numsala {get; private set;}=0;

    public static void InicializarJuego(){
        numsala=0;
        incognitas= new string[] {"cntj", "uyiws","tres","cuato"};
    }
    public static int GetEstadoJuego(){
        return numsala;
    }
    public static bool ResolverSala(int sala, string incognita){
        if(incognitas == null){
            InicializarJuego();
        }
        if (sala==numsala){
            if (incognita==incognitas[sala]){
                numsala+=1;
                return true;
            }
            else return false;
        }
        else return false;
    }
}