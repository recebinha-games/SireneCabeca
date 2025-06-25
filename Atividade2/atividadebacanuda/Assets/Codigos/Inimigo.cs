using UnityEngine;

public class Inimigo : Personagem
{
    public enum ArmaDoInimigo
    {
        VARA_DE_PESCA, ARPAO, REDE
    }

    public enum ArmaduraDoInimigo
    {
        CAMISA_POLO, JAQUETA
    }

    [ SerializeField ]
    private ArmaduraDoInimigo armadura;
    [ SerializeField ]
    private ArmaDoInimigo arma;

    public void AtribuirArmadura(ArmaduraDoInimigo armadura)
    {
        this.armadura = armadura;
    }

    public ArmaduraDoInimigo Armadura()
    {
        return this.armadura;
    }

    public void AtribuirArma(ArmaDoInimigo arma)
    {
        this.arma = arma;
    }

    public ArmaDoInimigo Arma()
    {
        return this.arma;
    }


    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case ArmaDoInimigo.VARA_DE_PESCA:
                dano = Forca_Ataque() + 10;
                break;
            case ArmaDoInimigo.ARPAO:
                dano = Forca_Ataque() + 25;
                break;
            case ArmaDoInimigo.REDE:
                dano = Forca_Ataque() + 5;
                break;
        }
        
       
        
        return dano;
    }















    void Start()
    {
        
    }
    void Update()
    {
        
    }
}