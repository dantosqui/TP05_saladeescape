class escape{
    static string[] incognitas {get; private set;} = new string[];
    static int numsala {private get; private set;}=1;

    private static void InicializarJuego(){

    }
    public static int GetEstadoJuego(){
        return numsala;
    }
    public static bool ResolverSala(int sala, string incognita){
        if (sala!=numsala){
            if (incognita==incognitas[sala])
                return true;
                }
        else return false;
    }
}