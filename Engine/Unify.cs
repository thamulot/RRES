using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;

namespace Reagan.Engine
{
    public class Unify
    {
        public static String FAIL_VALUE = "-1";
        public static String[] VECTEUR_FAIL = { FAIL_VALUE };
        public static String[] VECTEUR_VIDE = { };
        public static String EMPTY_VALUE = "";
        public static String SPACE = " ";
        public static String LEFT_DELIMITER = "(";
        public static String RIGHT_DELIMITER = ")";
        public static String VARIABLE_DELIMITER = "?";
        public static String EMPTY_SUBSTITUTION_VALUE = LEFT_DELIMITER + RIGHT_DELIMITER;
	    // (a-Z)+(0-9a-Z)* - \w = alphanumeric....
        private static Regex CONSTANTE_PATTERN = new Regex("^[a-zA-Z]+(\\w)*$");
	    // '?'(a-Z)+(0-9a-Z)*
        private static Regex VARIABLE_PATTERN = new Regex("^\\" + VARIABLE_DELIMITER + "[a-zA-Z]+(\\w)*$");
        private static Regex FIRST_ELEMENT_PATTERN = new Regex("^\\((\\w|\\" + VARIABLE_DELIMITER + ")(\\w)*(\\s)*");
        
        /* "(\w " */
        private static Regex REST_OF_PATTERN = new Regex("^\\((\\w|\\" + VARIABLE_DELIMITER + ")(\\w)*(\\s)*");
    	
	    /**
	     * Entre du programme unify
	     * 
	     * @param args
	     */
	/*    public static void main(String[] args) {

		    // Demande le premier predicat
		    Console.Write("Entre le premier predicat: ");
		    String predicat1 = lectureInputStandard();

		    // Demande le deuxieme predicat
		    Console.Write("Entre le deuxieme predicat: ");
		    String predicat2 = lectureInputStandard();

		    // appel de la fonction d'unification ici
		    String[] reponse = unification(predicat1, predicat2);

		    // affichage des resultats
		    Console.Write(LEFT_DELIMITER);
		    for (int i = 0; i < reponse.Length; ++i) {
			    Console.Write(reponse[i]);
		    }
		    Console.WriteLine(RIGHT_DELIMITER);
    		 
		    Console.WriteLine("FIN");
	    }*/

	    /**
	     * Fonction recursive unificatrice des 2 predicats E1 et E2
	     * 
	     * @param E1 predicat
	     * @param E2 predicat
	     * @return substitution(s) de l'unification de E1 et E2
	     */
	    public static String[] unification(String E1, String E2) {

		    if ((estUneConstante(E1) && estUneConstante(E2))
				    || (E1.Equals(EMPTY_SUBSTITUTION_VALUE) && E2
						    .Equals(EMPTY_SUBSTITUTION_VALUE))) {

			    if (E1.Equals(E2)) {
				    return VECTEUR_VIDE;
			    }
			    else {
				    return VECTEUR_FAIL;
			    }
		    }
		    else if (estUneVariable(E1)) {
			    if (occure(E1, E2)) {
				    return VECTEUR_FAIL;
			    }
			    else {
				    String[] union = { LEFT_DELIMITER + E1 + SPACE + E2 + RIGHT_DELIMITER };
				    return union;
			    }
		    }
		    else if (estUneVariable(E2)) {
			    if (occure(E2, E1)) {
				    return VECTEUR_FAIL;
			    }
			    else {
				    String[] union = { LEFT_DELIMITER + E2 + SPACE + E1 + RIGHT_DELIMITER };
				    return union;
			    }
		    }
		    else if (E1.Equals(EMPTY_VALUE) || E2.Equals(EMPTY_VALUE)) {
			    return VECTEUR_FAIL;
		    }
		    else {
			    String HE1 = premierElementDe(E1);
			    String HE2 = premierElementDe(E2);
    			
			    // substitution des premiers elements
			    String[] SUBS1 = unification(HE1, HE2);
			    if (SUBS1.Equals(VECTEUR_FAIL)) { return VECTEUR_FAIL; }

			    String TE1 = applique(SUBS1, resteDe(E1));
			    String TE2 = applique(SUBS1, resteDe(E2));
    			
			    // substitution dans les restes
			    String[] SUBS2 = unification(TE1, TE2);
			    if (SUBS2.Equals(VECTEUR_FAIL)) { 
				    return VECTEUR_FAIL; 
			    }
			    else{
				    return composition(SUBS1, SUBS2);
			    }
		    }
	    }

	   /**
	     * @return La chaine lue sur la ligne de commande
	     */
        /*    private static String lectureInputStandard() {
               String valeur = null;

               // Lire ce qui est sur la ligne de commande
               try {
                   valeur = Console.ReadLine();
               } catch (IOException) {
                   Console.WriteLine("Erreur en lisant la ligne de commande");
                   //Application.Exit(); //TODO: Fix this
               }
               return valeur;
           }
           */

	    /**
	     * @param valeur : La chaine a verifier
	     * @return Vrai si la chaine est une constante, faux si non
	     */
	    public static bool estUneConstante(String valeur) {
            return CONSTANTE_PATTERN.IsMatch(valeur);
	    }

	    /**
	     * @param valeur : La chaine a verifier
	     * @return Vrai si ine variable, faux si non
	     */
	    public static bool estUneVariable(String valeur) {
            return VARIABLE_PATTERN.IsMatch(valeur);
	    }

	    /**
	     * <p>Determine si la variable recu est contenue dans l'expression.</p>
	     * <p>Ceci, afin de gerer le cas infini de A dans f(A) => f(f(f(...f(A)...)))</p>
	     * 
	     * @param variable : expression de la forme (espace)* ? (a-Z)+ ((espace)+ ou ')')
	     * @param expression
	     * @return vrai si la variable est contenue dans l'expression
	     */
	    public static bool occure(String variable, String expression) {
            Regex pattern = new Regex("\\s*" + "\\" + VARIABLE_DELIMITER + variable.Substring(1) + "(\\s+|\\))");
            return pattern.IsMatch(expression);
	    }

	    /**
	     * @param element : Chaine ou on extrait le premier element
	     * @return Le premier element de la chaine ou le nom du predicat/fonction
	     */
	    public static String premierElementDe(String element) {
    		
		    //	cas des fonctions: si on enleve la premiere ( et qu'il y en a une tout de suite apres		
		    if (element.Substring(1).IndexOf(LEFT_DELIMITER) != 0) {
			    if (FIRST_ELEMENT_PATTERN.IsMatch(element)) {
                    Match m= FIRST_ELEMENT_PATTERN.Match(element);
                    return m.ToString().Substring(1, m.Length - 1).Trim(); 
			    }
		    }
		    else {
			    int para = 0;
			    int i = 1;
			    do {
                    if (element[i] == ')') para--;
                    else if (element[i] == '(') para++;

				    ++i;
			    } while ( para != 0 && i < element.Length );

			    if (i < element.Length) return element.Substring(1, i-1);
		    }

		    return EMPTY_VALUE;
	    }

	    /**
	     * @param element : Chaine d'ou extraire le reste
	     * @return Le reste de la chaine entre ()
	     */
	    public static String resteDe(String element) {
    		
		    // cas des fonctions: si on enleve la premiere ( et qu'il y en a une tout de suite apres
		    if (element.Substring(1).IndexOf(LEFT_DELIMITER) != 0) {
			    if (REST_OF_PATTERN.IsMatch(element)) {
                    Match m = REST_OF_PATTERN.Match(element);
                    return LEFT_DELIMITER + element.Substring(m.Length).Trim(); ; 
			    }
		    }
		    else {
			    int para = 0;
			    int i = 1;
			    do {
				    if (element[i] == ')') para--;
                    else if (element[i] == '(') para++;

				    ++i;
			    } while (para != 0 && i < element.Length);

			    if (i < element.Length) {
				    return LEFT_DELIMITER + element.Substring(i).Trim();
			    }
		    }

		    return EMPTY_VALUE;
	    }

	    /**
	     * Applique une unification au reste d'un "predicat"
	     * 
	     * @param subs : chaine d'unification d'une autre partie des predicats
	     * @param reste : chaine
	     * @return Le resultat de l'application de subs au reste
	     */
	    public static String applique(String[] subs, String reste) {

		    for (int i = 0; i < subs.Length; ++i) {
			    String tmp = subs[i];
			    String variable = tmp.Substring(2, tmp.IndexOf(SPACE) - 2);
                int lastPos= tmp.LastIndexOf(RIGHT_DELIMITER) - (tmp.IndexOf(SPACE)+1);
			    String constante = tmp.Substring(tmp.IndexOf(SPACE) + 1, lastPos);
			    // identification de l'expression reguliere
			    Regex pattern = new Regex("(\\" + VARIABLE_DELIMITER + variable + ")(\\s+|\\))");

                if (pattern.IsMatch(reste)) {
                    Match m= pattern.Match(reste);
                    String tmp1 = m.Groups[2].Value.Trim();
                    String test = pattern.Replace(reste, constante + tmp1);
                    return test; //TODO : vérifier si ca fais du replaceAll 
			    }
		    }

		    return reste;
	    }

	    /**
	     * Compose deux unifications ensembles
	     * 
	     * @param subs1 : premiere chaine d'unification a composer
	     * @param subs2 : deuxieme chaine d'unification a composer
	     * @return Le resultat de la composition
	     */
	    public static String[] composition(String[] subs1, String[] subs2) {

		    // Composition des 2 subs...
		    for (int i = 0; i < subs1.Length; ++i) {
			    String tmp = subs1[i];
    			
			    //applique les constantes aux variables
			    subs1[i] = applique(subs2, subs1[i]);

                String variable = tmp.Substring(2, tmp.IndexOf(SPACE) - 2);
                int lastPos = tmp.LastIndexOf(RIGHT_DELIMITER) - (tmp.IndexOf(SPACE) + 1);
                String constante = tmp.Substring(tmp.IndexOf(SPACE) + 1, lastPos);

			    for (int j = 0; j < subs2.Length; j++) {
				    String tmp2 = subs2[j];
    				
				    //	applique les constantes aux variables
				    subs2[j] = applique(subs1, subs2[j]);
                    String variable2 = tmp2.Substring(2, tmp2.IndexOf(SPACE) - 2);
                    int lastPos2 = tmp2.LastIndexOf(RIGHT_DELIMITER) - (tmp2.IndexOf(SPACE) + 1);
                    String constante2 = tmp2.Substring(tmp2.IndexOf(SPACE) + 1, lastPos2);

				    // On cree la transition
				    if (variable.Equals(constante2)) {
					    subs2[j] = LEFT_DELIMITER + variable2 + SPACE + constante + RIGHT_DELIMITER;
				    }// S'il n'y a pas transition on fait l'union
				    else if (variable2.Equals(constante)) {
					    subs1[i] = LEFT_DELIMITER + variable + SPACE + constante2 + RIGHT_DELIMITER;
				    }
			    }
		    }

		    return reunion2Elements(subs1, subs2);
	    }

	    /**
	     * 
	     * @param subs1
	     * @param subs2
	     * @return
	     */
	    public static String[] reunion2Elements(String[] subs1, String[] subs2) {
		    ArrayList reunion = new ArrayList();

		    bool pasTrouve = true;

		    for (int i = 0; i < subs1.Length; i++) {
			    reunion.Add(subs1[i]);
		    }
    		
		    int j = 0;
		    /* Prendre un vecteur et verifie si chacun de ces 
		     * elements existent dans l'autre vecteur a reunir.
		     * Si oui on n'ajoute pas, sinon on ajoute.
		     * Ici on ajoute seulement dans array1. 
		     * Donc on enleve les doublons de array2
		     */
		    for (int i = 0; i < subs2.Length; i++) {

			    j = 0;
			    while (pasTrouve && j < subs1.Length) {
    				
				    if (subs2[i].Equals(subs1[j])) {
					    pasTrouve = false;
				    }
				    j++;
			    }
    			
			    if (pasTrouve) {
				    reunion.Add(subs2[i]);
			    }
			    else{
				    pasTrouve = true;
			    }
		    }
    		
		    // Union des transitions et de subs1
		    String[] union = new String[reunion.Count];
            for (int i = 0; i < reunion.Count; i++)
            {
			    union[i] = (String)reunion[i];
		    }

		    return union;
	    }
    }
}
