class escape{
    public static string[] incognitas {get; private set;} = new string[] {"aaab","cntj", "uyiws","tres","cuato"};
    public static int numsala {get; private set;}=0;

    private static void InicializarJuego(){

    }
    public static int GetEstadoJuego(){
        return numsala;
    }
    public static bool ResolverSala(int sala, string incognita){
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