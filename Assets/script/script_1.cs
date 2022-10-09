using System.Collections.Generic;

class Inventory{
    // Propriétés (variables)
    public List<Objet> objets;
    //Méthodes
}

class Objet{
    string nom;
    int quantite;
    public Objet(string nomIni, int quantiteIni){
        string nom = nomIni;
        int quantite = quantiteIni;
    }
    private void Increase(int increment){
        quantite = quantite+increment;
    }
    private void ModifierNom(string nouveauNom){
        nom = nouveauNom;
    }
}

class Arme : Objet{
    private int ptsDegats;

    public Arme(string nomIni, int quantiteIni, int ptsDegatsIni) : base(nomIni, quantiteIni){
        ptsDegats = ptsDegatsIni;
    }
}

class Main{
    private void main(){
        Inventory inventaire = new Inventory();
        inventaire.objets = new List<Objet>();
        
        Objet objet1=new Objet("Potion", 6);
        Objet objet2=new Objet("Bouclier", 1);


        inventaire.objets.Add(objet1);
        inventaire.objets.Add(objet2);
    }
}