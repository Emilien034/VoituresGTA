namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] cars = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };

        Console.WriteLine("Voici les voitures:\n");

        void carsStock()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Voiture {i + 1}: {cars[i]}.");
            }
        }

        carsStock();

        Console.Write("\nQuelle voiture souhaîte-tu remplacer? (1 à 5): ");
        int carReplace = Convert.ToInt32(Console.ReadLine());
        Console.Write("Et quel est le nom du nouveau véhicule? ");
        string carName = Convert.ToString(Console.ReadLine());

        //int replacementIndex = System.Array.IndexOf(cars, carReplace);

        cars[carReplace - 1] = carName;

        carsStock();
    }
}