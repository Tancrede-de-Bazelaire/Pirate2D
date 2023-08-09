using UnityEngine;

public class Script_Fonction : MonoBehaviour
{
    #region FONCTIONS SANS ARGUMENTS
    /*  DEFINIR UNE FONCTION 1
    .... Template sans argument:
        Déclaration     type Nom_De_Fonction ()
                        {
                            ...
                            instructions
                            ...
                            return variable;
                        }
    ....
    Note: la variable retournée doit être du type déclaré devant la fonction,
    à moins d'utiliser le type void et de ne pas utiliser return.
    Note2: comme pour les variables des fonctions peuvent être public et donc accessibles
    de l'extérieur du script.
    */

    void Je_Suis_La_Fonction_La_Plus_Basique()
    {
        // ..et la plus inutile !
    }

    public int La_Reponse_A_La_Question()
    {
        return 42;
    }

    public float Prof_De_Math_Pompeux()
    {
        return 3.14159265359f;
    }

    public string Cartographe()
    {
        return ("Je suis à la position " + transform.position);
    }

    public bool Verification_De_La_Reponse()
    {
        return La_Reponse_A_La_Question() == 42;
    }
    #endregion

    #region FONCTIONS AVEC ARGUMENTS
    /*  DEFINIR UNE FONCTION 2
    .... Template avec arguments:
        Déclaration     type Nom_De_Fonction (type argument_1, type argument_2, etc...)
                        {
                            ...
                            instructions
                            ...
                            return variable;
                        }
    ....
    Note: idem que pour le précédent descriptif.
    */

    public void Afficher(string du_texte)
    {
        Debug.Log(du_texte);
    }

    public int Addition(int variable_A, int variable_B)
    {
        return variable_A + variable_B;
    }

    public float Nombre_Au_Carre(float variable_A)
    {
        return variable_A * variable_A;
    }

    public string Combiner_Du_Texte(string mot_A, string mot_B)
    {
        return mot_A + mot_B;
    }

    public bool Ces_Textes_Sont_Differents(string mot_A, string mot_B)
    {
        return mot_A != mot_B;
    }
    #endregion
}
