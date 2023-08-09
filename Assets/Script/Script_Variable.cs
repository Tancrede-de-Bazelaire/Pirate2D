using UnityEngine;

public class Script_Variable : MonoBehaviour
{
    #region VARIABLES
    /*  DEFINIR UNE VARIABLE
    .... Vocabulaire:
        Déclaration     type nom_De_Variable;
        Initialisation  nom_De_Variable = valeur;
        les deux        type nom_De_Variable = valeur;
    .... Types:
        entier          int
        decimal         float
        texte           string
        booléen         bool
    .... Exemples:
        int variableEntiere = 5;
        float variableDecimale = -670.51f;
        string variableTextuelle = "Je suis du texte";
        bool variableBooleenne = true;
    ....
    Note: Rajouter public devant le type rend la variable visible dans l'inspector
    */

    public int entierA;
    int entierB = 3, entierC = -7;

    public float decimalA, decimalB;
    float decimalC = -51.75f;

    public string stringA;
    string stringB = "Je suis du texte", stringC = "Et moi aussi !";

    public bool boolA;
    bool boolB = true, boolC = false;
    #endregion

    // Fonction spécifique à Unity éxécutée 1 fois seulement à son chargement dans une scène si appliquer à un GameObject
    void Awake()
    {
        #region OPERATION
        /*  OPERATEURS DE CALCUL SIMPLE
        ....
            Addition        +
            Soustraction    -
            Multiplication  *
            Division        /
        ....
        */
        #endregion


        #region COMPARAISON
        /*  OPERATEURS LOGIQUES DE COMPARAISON
        ....
            Egalité         ==
            Différent       !=
            Et              &&
            Ou              ||
            +Petit que      <
            +Petit ou Egal  <=
            +Grand que      >
            +Grand ou Egal  >=
        ....
        Note: Produit un résultat de type bool (true ou false)
        */
        #endregion

        Debug.Log( entierB + entierC );
        Debug.Log( entierB == entierC );

        int resultat_De_Deux_Entier = entierB + entierC;
        Debug.Log( resultat_De_Deux_Entier * entierA );



        #region EXECUTION CONDITIONNELLE
        /*  OPERATEURS CONDITIONNELS
        - Si une expression est vrai alors son corps est éxécuté et le reste ignoré
          Autrement l'expression suivante est vérifiée et ainsi de suite
        ....
            if (expression 1) {
                instruction 1;
            } else if (expression 2) {
                instruction 2a;
                instruction 2b;
            } else {
                instruction 3;
            }
        ....
        */
        #endregion


        if( resultat_De_Deux_Entier > entierA ){
            Debug.Log("le résultats de B + C est supérieur à A");
        } else if( resultat_De_Deux_Entier == entierA ){
            Debug.Log("le résultat est égale");
        } else {
            Debug.Log("le résultat est inférieur à A");
        }


        // VRAI && VRAI => VRAI 
        // VRAI && FAUX => FAUX
        // FAUX && FAUX => FAUX
        if( resultat_De_Deux_Entier > -5 && resultat_De_Deux_Entier < 10 ){
            Debug.Log("Le résultat est supérieur à -5 et inférieur à 10");
        }


        // VRAI || VRAI => VRAI 
        // VRAI || FAUX => VRAI
        if( resultat_De_Deux_Entier <= 0 || resultat_De_Deux_Entier > 10 ){
            Debug.Log("le résultat est inférieur/égal à 0 OU supérieur à 10");
        }


    }

    public Script_Fonction fonctions;
    // Idem que la fonction Awake mais se déclenche en 2ème
    void Start()
    {
        // appeler une fonction locale:
        Debug.Log(Multiplication_De_A_Par_B());
      

        // accéder au Script_Fonction
        // et utiliser l'une des ces fonctions
        Debug.Log(fonctions.La_Reponse_A_La_Question());

        Debug.Log(fonctions.Addition(9, 11));

        Debug.Log(fonctions.Addition(entierA , entierB));

        // Appeler multiplication et lui donner deux entier
        Debug.Log(Multiplication(7 , 5));

        Afficher_Si_SUP_455(45.5f);
    }






    void Je_Suis_La_Fonction_La_Plus_Basique()
    {
        // ..et la plus inutile !
    }

    // creé une fonction qui retourne le résultat de 
    // entier A * entier B 

    int Multiplication_De_A_Par_B(){
        return entierA * entierB;
    }

    //créer une fonction qui retourne si entierB est inférieur à 42
    /*
    bool entierB_inférieur_à_42_V1(){
        return entierB < 42;

    bool entierB_inférieur_à_42_V2(){
        if(entierB < 42)
            return true;
        else
            return false;
    }
    */

    //créer une fonction qui :
    // - Divise decimalA ou decimalB
    // - Verifier SI c'est 
    //                     inférieur à 1 OU supérieur à 5 
    // - Et retourner la réponse
    /*

    type Nom_De_Fonction()
    {
        x instructions

        return variable; 
    }

    bool decimalA_Diviser_Par_DecimalB()
    {
        if( decimalA / decimalB < 1 || decimalA / decimalB > 5)
            return true;
        else
            return false;
    }
    */ 

    //crée une fonction qui multiplie deux entier et renvoit le résultat
    /* 
        type Nom_De_Fonction (paramètres)
        {
            return variable
        }
        
    */
    public int Multiplication(int variable_a, int variable_b)
    {
        return variable_a * variable_b;
    }

    // créer une fonction qui prends un décimal et s'affiche SI 
    // ce décimal est supérieur à 45.5
    
    void Afficher_Si_SUP_455 (float X)
    {
        Debug.Log( X > 45.5f );
    }

    // Créer une fonction qui prend un décimal et un entier
    // puis qui les soustraits 
    // Si le résultat est inférieur ou égale a 0 
    //       afficher à l'écran la réponse 
    // autrement ne rien faire
    /*

    type Nom_De_Fonction(type param1 , type param2)
    {
        param1 - param2
        if()
        Debug.Log()
    }
    */ 

    void PrintStuff(float X , int Y)
    {
         if(X - Y <= 0)
             Debug.Log(true);
    }

}
