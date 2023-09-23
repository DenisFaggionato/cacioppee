/*public classe Primo{
    public string nome;
    public int tempoCottura;
    public bool vegano;
    public string Immagine;

    public Primo(string nomePiatto, int tempoDiCottura, bool vega, string LinkImmagine){
        this.nome = nomePiatto;
        this.tempoCottura = tempoDiCottura;
        this.vegano = vega;
        this.Immagine = LinkImmagine;
    }
}
Primo cacioEPepe = new Primo("Cacio e Pepe", 30, false, "https://www.giallozafferano.it/images/ricette/219/21989/foto_hd/hd650x433_wm.jpg");*/

public class Piatto{
    public string nome;
    public string foto;

    virtual override impiatta(foto){
        return this.foto;
    }

   /* public string impiatta(immagine){

    }*/

}

public Primo : Piatto{
    public bool vegano;
    public bool formaggio;
    

}

public Secondo : Piatto{
    public string nomePiatto;
    public bool carne;
    public string Immagine;
}
public Dolce : Piatto{
    public string nomePiatto;
    public bool Freddo;
    public string Immagine;
}